Public Class FormDonorInfo
    Private updateId As Integer
    Dim bgroup() As String = {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"}

    Private Sub LoadBloodGroups()
        cbBloodGroup.Items.Clear()
        cbBloodGroup.Items.AddRange(bgroup)
        cbBloodGroup.SelectedIndex = 0
    End Sub
    Private Sub LoadTheDonor()
        Dim info As New BBDatabase.DonorInfo()
        Dim db As New BBDatabase()
        If db.FindDonorById(updateId, info) = False Then
            MessageBox.Show("Cannot retrieve the Donor information of the providied ID", "Error retrieving Donor Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Dispose()
            Exit Sub
        End If

        tbDonorId.Text = info.Donor_ID
        tbName.Text = info.Donor_Name
        tbAddress.Text = info.Address
        tbPhone.Text = info.PhoneNo
        Try
            cbBloodGroup.SelectedIndex = cbBloodGroup.Items.IndexOf(info.Blood_Group)
        Catch ex As Exception
            Debug.Print(ex.ToString())
        End Try
        tbName.Focus()
        cbBloodGroup.Enabled = False
    End Sub

    Private Sub FormDonorInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBloodGroups()
        If updateId = -1 Then
            tbDonorId.Text = BBDatabase.GenerateId()
            tbName.Focus()
        Else
            LoadTheDonor()
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub tbName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbName.KeyUp
        If e.KeyCode = Keys.Enter Then
            If cbBloodGroup.Enabled = False Then
                tbAddress.Focus()
            Else
                cbBloodGroup.Focus()

            End If
        End If
    End Sub

   

    Private Sub tbPhone_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPhone.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            ' Generate Donor Info Structure
            Dim info As BBDatabase.DonorInfo
            If Integer.TryParse(tbDonorId.Text.Trim, info.Donor_ID) = False Then
                MessageBox.Show("Severe Error... Invalid Donor ID", "Invalid Doonor ID", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If tbName.Text.Trim.Length < 1 Then
                tbName.Focus()
                Exit Sub
            End If
            info.Donor_Name = tbName.Text.Trim

            info.Blood_Group = cbBloodGroup.Text

            If tbAddress.Text.Trim.Length < 1 Then
                tbAddress.Focus()
                Exit Sub
            End If
            info.Address = tbAddress.Text.Trim

            If Long.TryParse(tbPhone.Text.Trim, info.PhoneNo) = False Then
                info.PhoneNo = 0
                tbPhone.Text = info.PhoneNo.ToString
            End If

            Dim db As New BBDatabase()
            If updateId = -1 Then
                If db.AppendDonor(info) = False Then
                    Throw New Exception()
                End If

                If db.AddDonorToStock(info) = False Then
                    Throw New Exception()
                End If
            Else
                If db.UpdateDonor(info) = False Then
                    Throw New Exception()
                End If
            End If
            MessageBox.Show("Donor information saved successfully", "Donor Information Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error saving Donor Information", "Error in Save", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub cbBloodGroup_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbBloodGroup.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbAddress.Focus()
        End If

    End Sub


    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        updateId = id
    End Sub
End Class