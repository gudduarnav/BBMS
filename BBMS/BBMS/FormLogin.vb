Public Class FormLogin
    Dim nTries As Integer = 0
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbTime.Text = ""
        tbUsername.Focus()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tm As Date = Date.Now
        lbTime.Text = tm.ToString()
    End Sub

    Private Sub tbUsername_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbUsername.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbPassword.Focus()
            tbPassword.Text = ""
        End If
    End Sub

    Private Sub tbPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim db As New BBDatabase
        If db.VerifyUser(tbUsername.Text, tbPassword.Text) = True Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
            Exit Sub
        Else
            If nTries > 5 Then
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
                Exit Sub
            End If
            nTries += 1
            MessageBox.Show("The Username or Password do not match. Please re-enter the username and password", "Invalid Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            tbUsername.Focus()
            tbUsername.Text = ""
            tbPassword.Text = ""
        End If
    End Sub
End Class