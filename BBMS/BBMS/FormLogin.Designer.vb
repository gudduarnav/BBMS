<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(299, 55)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(140, 30)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(37, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(37, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password: "
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.Black
        Me.tbUsername.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.ForeColor = System.Drawing.Color.White
        Me.tbUsername.Location = New System.Drawing.Point(157, 15)
        Me.tbUsername.MaxLength = 32
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(282, 30)
        Me.tbUsername.TabIndex = 1
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.Black
        Me.tbPassword.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.ForeColor = System.Drawing.Color.White
        Me.tbPassword.Location = New System.Drawing.Point(157, 55)
        Me.tbPassword.MaxLength = 16
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(140, 30)
        Me.tbPassword.TabIndex = 2
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.ForeColor = System.Drawing.Color.Red
        Me.lbTime.Location = New System.Drawing.Point(335, 97)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(60, 23)
        Me.lbTime.TabIndex = 6
        Me.lbTime.Text = "lbTime"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(478, 129)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blook Bank Management System : Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
