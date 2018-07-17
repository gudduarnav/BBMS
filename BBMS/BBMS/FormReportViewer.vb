Public Class FormReportViewer
    Private Sub FormReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub ShowReportWindow(ByVal mdiForm As Form, ByVal strPath As String)
        wbReport.Url = New Uri(strPath)

        If mdiForm Is Nothing Then
            Me.ShowDialog()
            Exit Sub
        End If

        If mdiForm.IsMdiContainer = True Then
            Me.MdiParent = mdiForm
            Me.Show()
        Else
            Me.ShowDialog()
        End If
    End Sub

End Class