Public Class FormMain

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Try
            Me.Visible = False
            Dim frm As New FormLogin()
            If frm.ShowDialog() = DialogResult.Cancel Then
                Throw New Exception()
            End If
            Me.Visible = True
            Me.Focus()
            tsTimer.Text = ""
            Timer1.Enabled = True
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tsTimer.Text = Date.Now
    End Sub

    Private Sub AboutBloodBankManagementSystemToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutBloodBankManagementSystemToolStripMenuItem.Click
        MessageBox.Show("Blood Bank Management System " & vbCrLf & _
                        "Designed by Arnav Mukhopadhyay" & vbCrLf & _
                        "Roll: YS-N24/29-2200011/2011  Batch: 45051 Session: 29th" & vbCrLf & _
                        "ADITA-SEM-III Project " & vbCrLf & _
                        "Year: 2011", _
                        "About Blood Bank Management System", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub


    Public Sub ShowMdiForm(ByVal childForm As Form)
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        ShowMdiForm(FormUserAccount)
    End Sub

    Private Sub AddDonorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddDonorToolStripMenuItem.Click
        ShowMdiForm(New FormDonorInfo(-1))
    End Sub

    Private Sub ListDonorsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListDonorsToolStripMenuItem.Click
        ShowMdiForm(FormDonorUpdate)
    End Sub

    Private Sub ViewStockListToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewStockListToolStripMenuItem.Click
        ShowMdiForm(FormStockList)
    End Sub

    Private Sub PrintTodaysBloodStockToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintTodaysBloodStockToolStripMenuItem.Click
        Dim db As New BBDatabase()
        db.PrintBloodStock(Me)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        ShowMdiForm(FormCustomerInfo)
    End Sub

    Private Sub ViewCustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomersToolStripMenuItem.Click
        Dim db As New BBDatabase()
        db.GenerateAllReport(Me)
    End Sub
End Class
