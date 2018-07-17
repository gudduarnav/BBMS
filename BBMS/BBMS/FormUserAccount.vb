Public Class FormUserAccount

    Private Sub FormUserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbUsername.Enabled = False
        tbPassword.Enabled = False
        btnNew.Enabled = True
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        lbUsers.Enabled = True
        Dim db As New BBDatabase()
        db.EnumAccounts(AddressOf LoadAllAccounts, Nothing)
    End Sub

    Private Sub LoadAllAccounts(ByVal username As String, ByVal pass As String, ByVal obj As Object)
        lbUsers.Items.Add(username)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        tbUsername.Enabled = True
        tbPassword.Enabled = True
        lbUsers.SelectedIndex = -1
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        tbUsername.Text = ""
        tbPassword.Text = ""
        tbUsername.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim db As New BBDatabase()
        Dim username As String = tbUsername.Text.Trim
        Dim password As String = tbPassword.Text.Trim
        Dim tPass As String = ""
        If db.GetPassword(username, tPass) = True Then
            MessageBox.Show("Username already exist", "Cannot add user", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            tbUsername.Text = ""
            tbPassword.Text = ""
            tbUsername.Focus()
            Exit Sub
        End If

        If db.AppendUser(username, password) = False Then
            MessageBox.Show("User account cannot be created. Please try again later.", "Cannot add user", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            tbUsername.Focus()
            Exit Sub
        End If

        MessageBox.Show("User account created successfully", "New User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbUsers.SelectedIndex = lbUsers.Items.Add(username)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim db As New BBDatabase()
        Dim username As String = lbUsers.Items(lbUsers.SelectedIndex)
        Dim password As String = tbPassword.Text

        If db.UpdateUser(username, password) = False Then
            MessageBox.Show("Cannot update the user", "Failed to update user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        MessageBox.Show("User account updated successfully", "User account updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim db As New BBDatabase()
        Dim username As String = lbUsers.Items(lbUsers.SelectedIndex)
        If db.DeleteUser(username) = False Then
            MessageBox.Show("Cannot delete the user", "Failed to remove user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        lbUsers.Items.RemoveAt(lbUsers.SelectedIndex)
        If lbUsers.Items.Count < 1 Then
            lbUsers.SelectedIndex = -1
        Else
            lbUsers.SelectedIndex = 0
        End If

        MessageBox.Show("User account deleted successfully", "User removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lbUsers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbUsers.SelectedIndexChanged
        If lbUsers.SelectedIndex = -1 Then
            btnNew.Enabled = True
            btnAdd.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        End If

        tbUsername.Enabled = False
        tbPassword.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = True
        btnUpdate.Enabled = True

        Dim username As String = lbUsers.Items(lbUsers.SelectedIndex)
        Dim pass As String = ""
        Dim db As New BBDatabase()
        If db.GetPassword(username, pass) = False Then
            MessageBox.Show("Cannot get the user account details. ", "Severe Error with database", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
            Exit Sub
        End If

        tbUsername.Text = username
        tbPassword.Text = pass
        tbPassword.Focus()
    End Sub

    Private Sub tbUsername_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbUsername.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbPassword.Focus()
            tbPassword.Text = ""
        End If
    End Sub


    Private Sub tbUsername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbUsername.TextChanged
        If btnDelete.Enabled = False Then
            ' New user is being added
            If tbUsername.Text.Trim.Length > 0 Then
                btnAdd.Enabled = True
            Else
                btnAdd.Enabled = False
            End If

        End If
    End Sub

    Private Sub tbPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            If btnUpdate.Enabled = True Then
                btnUpdate.PerformClick()
                Exit Sub
            End If

            If btnAdd.Enabled = True Then
                btnAdd.PerformClick()
                Exit Sub
            End If
        End If
    End Sub
End Class