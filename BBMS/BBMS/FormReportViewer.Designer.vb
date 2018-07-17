<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.wbReport = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wbReport
        '
        Me.wbReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbReport.Location = New System.Drawing.Point(0, 0)
        Me.wbReport.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbReport.Name = "wbReport"
        Me.wbReport.Size = New System.Drawing.Size(292, 270)
        Me.wbReport.TabIndex = 0
        '
        'FormReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 270)
        Me.Controls.Add(Me.wbReport)
        Me.Name = "FormReportViewer"
        Me.Text = "ReportViewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbReport As System.Windows.Forms.WebBrowser
End Class
