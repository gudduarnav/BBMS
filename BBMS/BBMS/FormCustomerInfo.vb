Public Class FormCustomerInfo
    Dim bgroup() As String = {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"}
    Private Sub LoadBloodGroups()
        cbBloodGroup.Items.Clear()
        cbBloodGroup.Items.AddRange(bgroup)
        cbBloodGroup.SelectedIndex = 0
    End Sub

    Private Sub FormCustomerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbId.Text = BBDatabase.GenerateId()
        LoadBloodGroups()

        tbName.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tbName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbName.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbHospital.Focus()
        End If
    End Sub

    Private Sub tbHospital_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbHospital.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbBloodGroup.Focus()
        End If
    End Sub

    Private Sub cbBloodGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbBloodGroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbPackets.Focus()
        End If
    End Sub

    Private Sub tbPackets_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPackets.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim db As New BBDatabase()
            Dim info As New BBDatabase.CustomerInfo()
            info.BillNo = Integer.Parse(tbId.Text)

            If tbName.Text.Trim.Length < 1 Then
                tbName.Focus()
                Exit Sub
            End If
            info.CustomerName = tbName.Text.Trim

            If tbHospital.Text.Trim.Length < 1 Then
                tbHospital.Focus()
                Exit Sub
            End If
            info.Hospital_Name = tbHospital.Text.Trim

            info.Blood_Group = cbBloodGroup.Text.Trim
            info.Purchase_Date = Date.Today
            info.No_Of_Packet = 0
            If Integer.TryParse(tbPackets.Text, info.No_Of_Packet) = False Then
                tbPackets.Focus()
                Exit Sub
            End If
            If info.No_Of_Packet < 1 Then
                tbPackets.Focus()
                Exit Sub
            End If

            If db.AppendCustomer(info) = False Then
                MessageBox.Show("Sorry!!! The required number of Blood Packets cannot be supplied", "Inadequate Blood subbply", _
                                  MessageBoxButtons.OK, MessageBoxIcon.Hand)
                tbPackets.Focus()
                Exit Sub
            End If

            db.GenerateCustomerBill(ParentForm, info.BillNo)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error occurred adding customer", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub
End Class