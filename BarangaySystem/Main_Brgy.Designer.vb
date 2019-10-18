<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Brgy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Barangay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_VAWC = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_Health = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_SK = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_Lupon = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_Treasury = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_Senior = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UC_Treasury1 = New BarangaySystem.UC_Treasury()
        Me.UC_Senior1 = New BarangaySystem.UC_Senior()
        Me.UC_LT1 = New BarangaySystem.UC_LT()
        Me.UC_VAWC1 = New BarangaySystem.UC_VAWC()
        Me.UC_Sk1 = New BarangaySystem.UC_Sk()
        Me.UC_Health1 = New BarangaySystem.UC_Health()
        Me.UC_Barangay1 = New BarangaySystem.UC_HealthOffice()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 28)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1031, 91)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1031, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Pamahalaang Barangay Tayuman"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1031, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Municipality of Binangonan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1031, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Province of Rizal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1031, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Republic of the Philippines"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Barangay
        '
        Me.btn_Barangay.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btn_Barangay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Barangay.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_Barangay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Barangay.BorderRadius = 0
        Me.btn_Barangay.ButtonText = "Barangay"
        Me.btn_Barangay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Barangay.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Barangay.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Barangay.Iconimage = Nothing
        Me.btn_Barangay.Iconimage_right = Nothing
        Me.btn_Barangay.Iconimage_right_Selected = Nothing
        Me.btn_Barangay.Iconimage_Selected = Nothing
        Me.btn_Barangay.IconMarginLeft = 0
        Me.btn_Barangay.IconMarginRight = 0
        Me.btn_Barangay.IconRightVisible = True
        Me.btn_Barangay.IconRightZoom = 0R
        Me.btn_Barangay.IconVisible = True
        Me.btn_Barangay.IconZoom = 90.0R
        Me.btn_Barangay.IsTab = False
        Me.btn_Barangay.Location = New System.Drawing.Point(10, 130)
        Me.btn_Barangay.Name = "btn_Barangay"
        Me.btn_Barangay.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_Barangay.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.btn_Barangay.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Barangay.selected = False
        Me.btn_Barangay.Size = New System.Drawing.Size(105, 43)
        Me.btn_Barangay.TabIndex = 9
        Me.btn_Barangay.Text = "Barangay"
        Me.btn_Barangay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Barangay.Textcolor = System.Drawing.Color.White
        Me.btn_Barangay.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_VAWC
        '
        Me.btn_VAWC.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btn_VAWC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_VAWC.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_VAWC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_VAWC.BorderRadius = 0
        Me.btn_VAWC.ButtonText = "VAWC's Office"
        Me.btn_VAWC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_VAWC.DisabledColor = System.Drawing.Color.Gray
        Me.btn_VAWC.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_VAWC.Iconimage = Nothing
        Me.btn_VAWC.Iconimage_right = Nothing
        Me.btn_VAWC.Iconimage_right_Selected = Nothing
        Me.btn_VAWC.Iconimage_Selected = Nothing
        Me.btn_VAWC.IconMarginLeft = 0
        Me.btn_VAWC.IconMarginRight = 0
        Me.btn_VAWC.IconRightVisible = True
        Me.btn_VAWC.IconRightZoom = 0R
        Me.btn_VAWC.IconVisible = True
        Me.btn_VAWC.IconZoom = 90.0R
        Me.btn_VAWC.IsTab = False
        Me.btn_VAWC.Location = New System.Drawing.Point(116, 130)
        Me.btn_VAWC.Name = "btn_VAWC"
        Me.btn_VAWC.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_VAWC.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.btn_VAWC.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_VAWC.selected = False
        Me.btn_VAWC.Size = New System.Drawing.Size(130, 43)
        Me.btn_VAWC.TabIndex = 10
        Me.btn_VAWC.Text = "VAWC's Office"
        Me.btn_VAWC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_VAWC.Textcolor = System.Drawing.Color.White
        Me.btn_VAWC.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_Health
        '
        Me.btn_Health.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btn_Health.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Health.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_Health.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Health.BorderRadius = 0
        Me.btn_Health.ButtonText = "Health Office"
        Me.btn_Health.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Health.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Health.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Health.Iconimage = Nothing
        Me.btn_Health.Iconimage_right = Nothing
        Me.btn_Health.Iconimage_right_Selected = Nothing
        Me.btn_Health.Iconimage_Selected = Nothing
        Me.btn_Health.IconMarginLeft = 0
        Me.btn_Health.IconMarginRight = 0
        Me.btn_Health.IconRightVisible = True
        Me.btn_Health.IconRightZoom = 0R
        Me.btn_Health.IconVisible = True
        Me.btn_Health.IconZoom = 90.0R
        Me.btn_Health.IsTab = False
        Me.btn_Health.Location = New System.Drawing.Point(247, 130)
        Me.btn_Health.Name = "btn_Health"
        Me.btn_Health.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_Health.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.btn_Health.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Health.selected = False
        Me.btn_Health.Size = New System.Drawing.Size(122, 43)
        Me.btn_Health.TabIndex = 11
        Me.btn_Health.Text = "Health Office"
        Me.btn_Health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Health.Textcolor = System.Drawing.Color.White
        Me.btn_Health.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_SK
        '
        Me.btn_SK.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btn_SK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SK.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_SK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_SK.BorderRadius = 0
        Me.btn_SK.ButtonText = "SK Office"
        Me.btn_SK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SK.DisabledColor = System.Drawing.Color.Gray
        Me.btn_SK.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_SK.Iconimage = Nothing
        Me.btn_SK.Iconimage_right = Nothing
        Me.btn_SK.Iconimage_right_Selected = Nothing
        Me.btn_SK.Iconimage_Selected = Nothing
        Me.btn_SK.IconMarginLeft = 0
        Me.btn_SK.IconMarginRight = 0
        Me.btn_SK.IconRightVisible = True
        Me.btn_SK.IconRightZoom = 0R
        Me.btn_SK.IconVisible = True
        Me.btn_SK.IconZoom = 90.0R
        Me.btn_SK.IsTab = False
        Me.btn_SK.Location = New System.Drawing.Point(370, 130)
        Me.btn_SK.Name = "btn_SK"
        Me.btn_SK.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_SK.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.btn_SK.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_SK.selected = False
        Me.btn_SK.Size = New System.Drawing.Size(93, 43)
        Me.btn_SK.TabIndex = 12
        Me.btn_SK.Text = "SK Office"
        Me.btn_SK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_SK.Textcolor = System.Drawing.Color.White
        Me.btn_SK.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_Lupon
        '
        Me.btn_Lupon.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btn_Lupon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Lupon.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_Lupon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Lupon.BorderRadius = 0
        Me.btn_Lupon.ButtonText = "Lupon Tagapamayapa"
        Me.btn_Lupon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Lupon.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Lupon.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Lupon.Iconimage = Nothing
        Me.btn_Lupon.Iconimage_right = Nothing
        Me.btn_Lupon.Iconimage_right_Selected = Nothing
        Me.btn_Lupon.Iconimage_Selected = Nothing
        Me.btn_Lupon.IconMarginLeft = 0
        Me.btn_Lupon.IconMarginRight = 0
        Me.btn_Lupon.IconRightVisible = True
        Me.btn_Lupon.IconRightZoom = 0R
        Me.btn_Lupon.IconVisible = True
        Me.btn_Lupon.IconZoom = 90.0R
        Me.btn_Lupon.IsTab = False
        Me.btn_Lupon.Location = New System.Drawing.Point(464, 130)
        Me.btn_Lupon.Name = "btn_Lupon"
        Me.btn_Lupon.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_Lupon.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.btn_Lupon.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Lupon.selected = False
        Me.btn_Lupon.Size = New System.Drawing.Size(197, 43)
        Me.btn_Lupon.TabIndex = 13
        Me.btn_Lupon.Text = "Lupon Tagapamayapa"
        Me.btn_Lupon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Lupon.Textcolor = System.Drawing.Color.White
        Me.btn_Lupon.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_Treasury
        '
        Me.btn_Treasury.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btn_Treasury.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Treasury.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_Treasury.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Treasury.BorderRadius = 0
        Me.btn_Treasury.ButtonText = "Treasury Office"
        Me.btn_Treasury.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Treasury.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Treasury.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Treasury.Iconimage = Nothing
        Me.btn_Treasury.Iconimage_right = Nothing
        Me.btn_Treasury.Iconimage_right_Selected = Nothing
        Me.btn_Treasury.Iconimage_Selected = Nothing
        Me.btn_Treasury.IconMarginLeft = 0
        Me.btn_Treasury.IconMarginRight = 0
        Me.btn_Treasury.IconRightVisible = True
        Me.btn_Treasury.IconRightZoom = 0R
        Me.btn_Treasury.IconVisible = True
        Me.btn_Treasury.IconZoom = 90.0R
        Me.btn_Treasury.IsTab = False
        Me.btn_Treasury.Location = New System.Drawing.Point(662, 130)
        Me.btn_Treasury.Name = "btn_Treasury"
        Me.btn_Treasury.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_Treasury.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.btn_Treasury.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Treasury.selected = False
        Me.btn_Treasury.Size = New System.Drawing.Size(141, 43)
        Me.btn_Treasury.TabIndex = 14
        Me.btn_Treasury.Text = "Treasury Office"
        Me.btn_Treasury.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Treasury.Textcolor = System.Drawing.Color.White
        Me.btn_Treasury.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_Senior
        '
        Me.btn_Senior.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btn_Senior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Senior.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_Senior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Senior.BorderRadius = 0
        Me.btn_Senior.ButtonText = "Senior Citizen / Livelihood"
        Me.btn_Senior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Senior.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Senior.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Senior.Iconimage = Nothing
        Me.btn_Senior.Iconimage_right = Nothing
        Me.btn_Senior.Iconimage_right_Selected = Nothing
        Me.btn_Senior.Iconimage_Selected = Nothing
        Me.btn_Senior.IconMarginLeft = 0
        Me.btn_Senior.IconMarginRight = 0
        Me.btn_Senior.IconRightVisible = True
        Me.btn_Senior.IconRightZoom = 0R
        Me.btn_Senior.IconVisible = True
        Me.btn_Senior.IconZoom = 90.0R
        Me.btn_Senior.IsTab = False
        Me.btn_Senior.Location = New System.Drawing.Point(803, 130)
        Me.btn_Senior.Name = "btn_Senior"
        Me.btn_Senior.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_Senior.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.btn_Senior.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Senior.selected = False
        Me.btn_Senior.Size = New System.Drawing.Size(218, 43)
        Me.btn_Senior.TabIndex = 15
        Me.btn_Senior.Text = "Senior Citizen / Livelihood"
        Me.btn_Senior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Senior.Textcolor = System.Drawing.Color.White
        Me.btn_Senior.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.UC_Treasury1)
        Me.Panel3.Controls.Add(Me.UC_Senior1)
        Me.Panel3.Controls.Add(Me.UC_LT1)
        Me.Panel3.Controls.Add(Me.UC_VAWC1)
        Me.Panel3.Controls.Add(Me.UC_Sk1)
        Me.Panel3.Controls.Add(Me.UC_Health1)
        Me.Panel3.Controls.Add(Me.UC_Barangay1)
        Me.Panel3.Location = New System.Drawing.Point(10, 179)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1012, 370)
        Me.Panel3.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BarangaySystem.My.Resources.Resources.unnamed__1_
        Me.PictureBox2.Location = New System.Drawing.Point(681, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BarangaySystem.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(247, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'UC_Treasury1
        '
        Me.UC_Treasury1.BackColor = System.Drawing.Color.White
        Me.UC_Treasury1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Treasury1.Location = New System.Drawing.Point(0, 0)
        Me.UC_Treasury1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_Treasury1.Name = "UC_Treasury1"
        Me.UC_Treasury1.Size = New System.Drawing.Size(1012, 370)
        Me.UC_Treasury1.TabIndex = 6
        '
        'UC_Senior1
        '
        Me.UC_Senior1.BackColor = System.Drawing.Color.White
        Me.UC_Senior1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Senior1.Location = New System.Drawing.Point(0, 0)
        Me.UC_Senior1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_Senior1.Name = "UC_Senior1"
        Me.UC_Senior1.Size = New System.Drawing.Size(1012, 370)
        Me.UC_Senior1.TabIndex = 5
        '
        'UC_LT1
        '
        Me.UC_LT1.BackColor = System.Drawing.Color.White
        Me.UC_LT1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_LT1.Location = New System.Drawing.Point(0, 0)
        Me.UC_LT1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_LT1.Name = "UC_LT1"
        Me.UC_LT1.Size = New System.Drawing.Size(1012, 370)
        Me.UC_LT1.TabIndex = 4
        '
        'UC_VAWC1
        '
        Me.UC_VAWC1.BackColor = System.Drawing.Color.White
        Me.UC_VAWC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_VAWC1.Location = New System.Drawing.Point(0, 0)
        Me.UC_VAWC1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_VAWC1.Name = "UC_VAWC1"
        Me.UC_VAWC1.Size = New System.Drawing.Size(1012, 370)
        Me.UC_VAWC1.TabIndex = 3
        '
        'UC_Sk1
        '
        Me.UC_Sk1.BackColor = System.Drawing.Color.White
        Me.UC_Sk1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Sk1.Location = New System.Drawing.Point(0, 0)
        Me.UC_Sk1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_Sk1.Name = "UC_Sk1"
        Me.UC_Sk1.Size = New System.Drawing.Size(1012, 370)
        Me.UC_Sk1.TabIndex = 2
        '
        'UC_Health1
        '
        Me.UC_Health1.BackColor = System.Drawing.Color.White
        Me.UC_Health1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Health1.Location = New System.Drawing.Point(0, 0)
        Me.UC_Health1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_Health1.Name = "UC_Health1"
        Me.UC_Health1.Size = New System.Drawing.Size(1012, 370)
        Me.UC_Health1.TabIndex = 1
        '
        'UC_Barangay1
        '
        Me.UC_Barangay1.BackColor = System.Drawing.Color.White
        Me.UC_Barangay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Barangay1.Location = New System.Drawing.Point(0, 0)
        Me.UC_Barangay1.Margin = New System.Windows.Forms.Padding(2)
        Me.UC_Barangay1.Name = "UC_Barangay1"
        Me.UC_Barangay1.Size = New System.Drawing.Size(1012, 370)
        Me.UC_Barangay1.TabIndex = 0
        '
        'Main_Brgy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1031, 558)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_Senior)
        Me.Controls.Add(Me.btn_Treasury)
        Me.Controls.Add(Me.btn_Lupon)
        Me.Controls.Add(Me.btn_SK)
        Me.Controls.Add(Me.btn_Health)
        Me.Controls.Add(Me.btn_VAWC)
        Me.Controls.Add(Me.btn_Barangay)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Main_Brgy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_VAWC"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Lupon As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_SK As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_Health As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_VAWC As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_Barangay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Senior As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_Treasury As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents UC_Barangay1 As UC_HealthOffice
    Friend WithEvents UC_Sk1 As UC_Sk
    Friend WithEvents UC_Health1 As UC_Health
    Friend WithEvents UC_VAWC1 As UC_VAWC
    Friend WithEvents UC_Treasury1 As UC_Treasury
    Friend WithEvents UC_Senior1 As UC_Senior
    Friend WithEvents UC_LT1 As UC_LT
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
