<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lnkLbl_ForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.btnCreateAcc = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = "Username"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.RoyalBlue
        Me.txtUsername.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.txtUsername.LineThickness = 2
        Me.txtUsername.Location = New System.Drawing.Point(57, 223)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(385, 44)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = "Password"
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.RoyalBlue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(57, 292)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(385, 44)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 30
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 30
        Me.btnLogin.IdleFillColor = System.Drawing.Color.White
        Me.btnLogin.IdleForecolor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.IdleLineColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.Location = New System.Drawing.Point(57, 414)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(152, 53)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkLbl_ForgotPassword
        '
        Me.lnkLbl_ForgotPassword.AutoSize = True
        Me.lnkLbl_ForgotPassword.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLbl_ForgotPassword.Location = New System.Drawing.Point(53, 350)
        Me.lnkLbl_ForgotPassword.Name = "lnkLbl_ForgotPassword"
        Me.lnkLbl_ForgotPassword.Size = New System.Drawing.Size(156, 21)
        Me.lnkLbl_ForgotPassword.TabIndex = 4
        Me.lnkLbl_ForgotPassword.TabStop = True
        Me.lnkLbl_ForgotPassword.Text = "Forgot Password?"
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.ActiveBorderThickness = 1
        Me.btnCreateAcc.ActiveCornerRadius = 30
        Me.btnCreateAcc.ActiveFillColor = System.Drawing.Color.RoyalBlue
        Me.btnCreateAcc.ActiveForecolor = System.Drawing.Color.White
        Me.btnCreateAcc.ActiveLineColor = System.Drawing.Color.RoyalBlue
        Me.btnCreateAcc.BackColor = System.Drawing.Color.White
        Me.btnCreateAcc.BackgroundImage = CType(resources.GetObject("btnCreateAcc.BackgroundImage"), System.Drawing.Image)
        Me.btnCreateAcc.ButtonText = "Create Account"
        Me.btnCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateAcc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnCreateAcc.IdleBorderThickness = 1
        Me.btnCreateAcc.IdleCornerRadius = 30
        Me.btnCreateAcc.IdleFillColor = System.Drawing.Color.White
        Me.btnCreateAcc.IdleForecolor = System.Drawing.Color.RoyalBlue
        Me.btnCreateAcc.IdleLineColor = System.Drawing.Color.RoyalBlue
        Me.btnCreateAcc.Location = New System.Drawing.Point(218, 414)
        Me.btnCreateAcc.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Size = New System.Drawing.Size(224, 53)
        Me.btnCreateAcc.TabIndex = 5
        Me.btnCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 35)
        Me.Panel1.TabIndex = 6
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Brgy. Tayuman Binangonan , Rizal"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(503, 564)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCreateAcc)
        Me.Controls.Add(Me.lnkLbl_ForgotPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(503, 564)
        Me.MinimumSize = New System.Drawing.Size(503, 564)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCreateAcc As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lnkLbl_ForgotPassword As LinkLabel
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label1 As Label
End Class
