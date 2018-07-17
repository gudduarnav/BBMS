<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintTodaysBloodStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListDonorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutBloodBankManagementSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.StockToolStripMenuItem, Me.DonorToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddUserToolStripMenuItem.Text = "Manage User"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewStockListToolStripMenuItem, Me.PrintTodaysBloodStockToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(57, 21)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ViewStockListToolStripMenuItem
        '
        Me.ViewStockListToolStripMenuItem.Name = "ViewStockListToolStripMenuItem"
        Me.ViewStockListToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.ViewStockListToolStripMenuItem.Text = "View Stock List"
        '
        'PrintTodaysBloodStockToolStripMenuItem
        '
        Me.PrintTodaysBloodStockToolStripMenuItem.Name = "PrintTodaysBloodStockToolStripMenuItem"
        Me.PrintTodaysBloodStockToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.PrintTodaysBloodStockToolStripMenuItem.Text = "Report of Today's Blood Stock"
        '
        'DonorToolStripMenuItem
        '
        Me.DonorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDonorToolStripMenuItem, Me.ListDonorsToolStripMenuItem})
        Me.DonorToolStripMenuItem.Name = "DonorToolStripMenuItem"
        Me.DonorToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.DonorToolStripMenuItem.Text = "Donor"
        '
        'AddDonorToolStripMenuItem
        '
        Me.AddDonorToolStripMenuItem.Name = "AddDonorToolStripMenuItem"
        Me.AddDonorToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AddDonorToolStripMenuItem.Text = "New Donor"
        '
        'ListDonorsToolStripMenuItem
        '
        Me.ListDonorsToolStripMenuItem.Name = "ListDonorsToolStripMenuItem"
        Me.ListDonorsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ListDonorsToolStripMenuItem.Text = "List Donors"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ViewCustomersToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(85, 21)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.NewToolStripMenuItem.Text = "New Customer"
        '
        'ViewCustomersToolStripMenuItem
        '
        Me.ViewCustomersToolStripMenuItem.Name = "ViewCustomersToolStripMenuItem"
        Me.ViewCustomersToolStripMenuItem.Size = New System.Drawing.Size(318, 22)
        Me.ViewCustomersToolStripMenuItem.Text = "Show Purchase And Donation Report"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutBloodBankManagementSystemToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(57, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutBloodBankManagementSystemToolStripMenuItem
        '
        Me.AboutBloodBankManagementSystemToolStripMenuItem.Name = "AboutBloodBankManagementSystemToolStripMenuItem"
        Me.AboutBloodBankManagementSystemToolStripMenuItem.Size = New System.Drawing.Size(333, 22)
        Me.AboutBloodBankManagementSystemToolStripMenuItem.Text = "About Blood Bank Management System"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTimer})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(789, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsTimer
        '
        Me.tsTimer.Name = "tsTimer"
        Me.tsTimer.Size = New System.Drawing.Size(149, 17)
        Me.tsTimer.Text = "ToolStripStatusLabel1"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(789, 395)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Bank Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStockListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListDonorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutBloodBankManagementSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PrintTodaysBloodStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
