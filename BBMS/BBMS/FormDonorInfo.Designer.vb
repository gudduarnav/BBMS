<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDonorInfo
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
        Me.tbDonorId = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbBloodGroup = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donor ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blood Group:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone No. :"
        '
        'tbDonorId
        '
        Me.tbDonorId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbDonorId.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDonorId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbDonorId.Location = New System.Drawing.Point(181, 21)
        Me.tbDonorId.MaxLength = 10
        Me.tbDonorId.Name = "tbDonorId"
        Me.tbDonorId.ReadOnly = True
        Me.tbDonorId.Size = New System.Drawing.Size(149, 23)
        Me.tbDonorId.TabIndex = 5
        Me.tbDonorId.TabStop = False
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(120, 57)
        Me.tbName.MaxLength = 64
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(341, 30)
        Me.tbName.TabIndex = 1
        '
        'tbAddress
        '
        Me.tbAddress.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddress.Location = New System.Drawing.Point(120, 131)
        Me.tbAddress.MaxLength = 128
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAddress.Size = New System.Drawing.Size(341, 102)
        Me.tbAddress.TabIndex = 3
        '
        'tbPhone
        '
        Me.tbPhone.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPhone.Location = New System.Drawing.Point(133, 239)
        Me.tbPhone.MaxLength = 10
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(328, 30)
        Me.tbPhone.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(482, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 62)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(482, 207)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 62)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "JDDB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(348, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "/ 2011"
        '
        'cbBloodGroup
        '
        Me.cbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBloodGroup.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBloodGroup.FormattingEnabled = True
        Me.cbBloodGroup.Location = New System.Drawing.Point(135, 93)
        Me.cbBloodGroup.MaxLength = 3
        Me.cbBloodGroup.Name = "cbBloodGroup"
        Me.cbBloodGroup.Size = New System.Drawing.Size(93, 32)
        Me.cbBloodGroup.TabIndex = 2
        '
        'FormDonorInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 295)
        Me.Controls.Add(Me.cbBloodGroup)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbDonorId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormDonorInfo"
        Me.Text = "Donor Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbDonorId As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbBloodGroup As System.Windows.Forms.ComboBox
End Class
