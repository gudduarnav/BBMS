<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDonorUpdate
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
        Me.dgvDonor = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDonor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDonor
        '
        Me.dgvDonor.AllowUserToAddRows = False
        Me.dgvDonor.AllowUserToDeleteRows = False
        Me.dgvDonor.AllowUserToResizeColumns = False
        Me.dgvDonor.AllowUserToResizeRows = False
        Me.dgvDonor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDonor.Location = New System.Drawing.Point(3, 1)
        Me.dgvDonor.MultiSelect = False
        Me.dgvDonor.Name = "dgvDonor"
        Me.dgvDonor.ReadOnly = True
        Me.dgvDonor.Size = New System.Drawing.Size(679, 315)
        Me.dgvDonor.TabIndex = 0
        '
        'FormDonorUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 310)
        Me.Controls.Add(Me.dgvDonor)
        Me.Name = "FormDonorUpdate"
        Me.Text = "FormDonorUpdate"
        CType(Me.dgvDonor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDonor As System.Windows.Forms.DataGridView
End Class
