<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockList
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
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.AllowUserToResizeColumns = False
        Me.dgvStock.AllowUserToResizeRows = False
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStock.Location = New System.Drawing.Point(0, 0)
        Me.dgvStock.MultiSelect = False
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.Size = New System.Drawing.Size(425, 300)
        Me.dgvStock.TabIndex = 0
        '
        'FormStockList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 300)
        Me.Controls.Add(Me.dgvStock)
        Me.Name = "FormStockList"
        Me.Text = "Stock List"
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
End Class
