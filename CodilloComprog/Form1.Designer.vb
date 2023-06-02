<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pnlNavbar = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnDesserts = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnFoods = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlYellow = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.pnlFill = New System.Windows.Forms.Panel()
        Me.pnlNavbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlYellow.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNavbar
        '
        Me.pnlNavbar.BackColor = System.Drawing.Color.LightCoral
        Me.pnlNavbar.Controls.Add(Me.btnExit)
        Me.pnlNavbar.Controls.Add(Me.btnAbout)
        Me.pnlNavbar.Controls.Add(Me.btnDesserts)
        Me.pnlNavbar.Controls.Add(Me.btnDrinks)
        Me.pnlNavbar.Controls.Add(Me.btnFoods)
        Me.pnlNavbar.Controls.Add(Me.PictureBox1)
        Me.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavbar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlNavbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavbar.Name = "pnlNavbar"
        Me.pnlNavbar.Size = New System.Drawing.Size(245, 663)
        Me.pnlNavbar.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 590)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(245, 73)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.people
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnAbout.ForeColor = System.Drawing.Color.Black
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 359)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(245, 71)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.Text = "  About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnDesserts
        '
        Me.btnDesserts.BackColor = System.Drawing.Color.Transparent
        Me.btnDesserts.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.dessert
        Me.btnDesserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDesserts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDesserts.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnDesserts.ForeColor = System.Drawing.Color.Black
        Me.btnDesserts.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDesserts.Location = New System.Drawing.Point(0, 289)
        Me.btnDesserts.Name = "btnDesserts"
        Me.btnDesserts.Size = New System.Drawing.Size(245, 70)
        Me.btnDesserts.TabIndex = 4
        Me.btnDesserts.Text = "    Desserts"
        Me.btnDesserts.UseVisualStyleBackColor = False
        '
        'btnDrinks
        '
        Me.btnDrinks.BackColor = System.Drawing.Color.Transparent
        Me.btnDrinks.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.water_glass
        Me.btnDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDrinks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnDrinks.ForeColor = System.Drawing.Color.Black
        Me.btnDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDrinks.Location = New System.Drawing.Point(0, 219)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(245, 70)
        Me.btnDrinks.TabIndex = 3
        Me.btnDrinks.Text = " Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = False
        '
        'btnFoods
        '
        Me.btnFoods.BackColor = System.Drawing.Color.Transparent
        Me.btnFoods.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.cutlery1
        Me.btnFoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFoods.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnFoods.ForeColor = System.Drawing.Color.Black
        Me.btnFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFoods.Location = New System.Drawing.Point(0, 148)
        Me.btnFoods.Name = "btnFoods"
        Me.btnFoods.Size = New System.Drawing.Size(245, 71)
        Me.btnFoods.TabIndex = 2
        Me.btnFoods.Text = " Foods"
        Me.btnFoods.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.Chef_Hat_cooking_logo_template_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 148)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlYellow
        '
        Me.pnlYellow.BackColor = System.Drawing.Color.RosyBrown
        Me.pnlYellow.Controls.Add(Me.btnback)
        Me.pnlYellow.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlYellow.Location = New System.Drawing.Point(245, 0)
        Me.pnlYellow.Name = "pnlYellow"
        Me.pnlYellow.Size = New System.Drawing.Size(957, 60)
        Me.pnlYellow.TabIndex = 1
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(832, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(113, 42)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        Me.btnback.Visible = False
        '
        'pnlFill
        '
        Me.pnlFill.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.Chef_Hat_cooking_logo_template_removebg_preview
        Me.pnlFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(245, 60)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(957, 603)
        Me.pnlFill.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 663)
        Me.Controls.Add(Me.pnlFill)
        Me.Controls.Add(Me.pnlYellow)
        Me.Controls.Add(Me.pnlNavbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlNavbar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlYellow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlNavbar As Panel
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnDesserts As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnFoods As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlYellow As Panel
    Friend WithEvents pnlFill As Panel
    Friend WithEvents btnback As Button
End Class
