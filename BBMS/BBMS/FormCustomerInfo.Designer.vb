<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerInfo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbHospital = New System.Windows.Forms.TextBox()
        Me.tbPackets = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cbBloodGroup = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hospital Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Blood Group:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Number of Packets:"
        '
        'tbId
        '
        Me.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbId.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(186, 21)
        Me.tbId.MaxLength = 10
        Me.tbId.Name = "tbId"
        Me.tbId.ReadOnly = True
        Me.tbId.Size = New System.Drawing.Size(151, 23)
        Me.tbId.TabIndex = 5
        Me.tbId.TabStop = False
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(186, 61)
        Me.tbName.MaxLength = 64
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(337, 30)
        Me.tbName.TabIndex = 1
        '
        'tbHospital
        '
        Me.tbHospital.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHospital.Location = New System.Drawing.Point(186, 100)
        Me.tbHospital.MaxLength = 64
        Me.tbHospital.Name = "tbHospital"
        Me.tbHospital.Size = New System.Drawing.Size(337, 30)
        Me.tbHospital.TabIndex = 2
        '
        'tbPackets
        '
        Me.tbPackets.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPackets.Location = New System.Drawing.Point(186, 186)
        Me.tbPackets.MaxLength = 5
        Me.tbPackets.Name = "tbPackets"
        Me.tbPackets.Size = New System.Drawing.Size(126, 30)
        Me.tbPackets.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(331, 150)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(192, 66)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save and Show Bill"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(343, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(180, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cbBloodGroup
        '
        Me.cbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBloodGroup.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBloodGroup.FormattingEnabled = True
        Me.cbBloodGroup.Location = New System.Drawing.Point(187, 147)
        Me.cbBloodGroup.Name = "cbBloodGroup"
        Me.cbBloodGroup.Size = New System.Drawing.Size(98, 31)
        Me.cbBloodGroup.TabIndex = 3
        '
        'FormCustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 245)
        Me.Controls.Add(Me.cbBloodGroup)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbPackets)
        Me.Controls.Add(Me.tbHospital)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormCustomerInfo"
        Me.Text = "Customer Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbId As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbHospital As System.Windows.Forms.TextBox
    Friend WithEvents tbPackets As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cbBloodGroup As System.Windows.Forms.ComboBox
End Class
