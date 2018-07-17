Public Class FormDonorUpdate

    Private Sub FormDonorUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvDonor.ColumnHeadersVisible = True
        dgvDonor.Columns.Add("DONOR_ID", "Donor ID")
        dgvDonor.Columns.Add("DONOR_NAME", "Name")
        dgvDonor.Columns.Add("BLOOD_GROUP", "Blood Group")
        dgvDonor.Columns.Add("ADDRESS", "Address")
        dgvDonor.Columns.Add("PHONENO", "Phone Number")

        LoadData()
    End Sub

    Private Sub LoadData()
        Dim db As New BBDatabase()
        Dim infolist() As BBDatabase.DonorInfo = db.EnumDonors()
        If infolist Is Nothing Then
            MessageBox.Show("No Donor list found", "Donor list empty", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Dispose()
            Exit Sub
        End If

        dgvDonor.Rows.Clear()
        For Each info As BBDatabase.DonorInfo In infolist
            Dim sarr() As String = {info.Donor_ID.ToString(), info.Donor_Name, info.Blood_Group, info.Address, info.PhoneNo.ToString()}
            dgvDonor.Rows.Add(sarr)
        Next

    End Sub
    Private Sub FormDonorUpdate_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        dgvDonor.Width = Me.Width
        dgvDonor.Height = Me.Height
    End Sub


    Private Sub dgvDonor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDonor.CellDoubleClick
        Try
            Dim selrow As Integer = dgvDonor.SelectedCells.Item(0).RowIndex
            Dim id As Integer = dgvDonor.Rows(selrow).Cells.Item(0).Value
            Dim frm As New FormDonorInfo(id)
            frm.ShowDialog()
            LoadData()
        Catch ex As Exception


        End Try

    End Sub
End Class