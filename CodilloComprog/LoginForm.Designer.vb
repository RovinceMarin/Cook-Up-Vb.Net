<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LblUname = New System.Windows.Forms.Label()
        Me.LblPword = New System.Windows.Forms.Label()
        Me.TxtUname = New System.Windows.Forms.TextBox()
        Me.TxtPword = New System.Windows.Forms.TextBox()
        Me.Lblsign = New System.Windows.Forms.Label()
        Me.Linklblsignin = New System.Windows.Forms.LinkLabel()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picexit = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picexit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUname
        '
        Me.LblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUname.Location = New System.Drawing.Point(294, 365)
        Me.LblUname.Name = "LblUname"
        Me.LblUname.Size = New System.Drawing.Size(154, 38)
        Me.LblUname.TabIndex = 1
        Me.LblUname.Text = "User Name:"
        Me.LblUname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPword
        '
        Me.LblPword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPword.Location = New System.Drawing.Point(294, 430)
        Me.LblPword.Name = "LblPword"
        Me.LblPword.Size = New System.Drawing.Size(154, 38)
        Me.LblPword.TabIndex = 2
        Me.LblPword.Text = "Password:"
        Me.LblPword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUname
        '
        Me.TxtUname.Location = New System.Drawing.Point(468, 377)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.Size = New System.Drawing.Size(272, 20)
        Me.TxtUname.TabIndex = 3
        '
        'TxtPword
        '
        Me.TxtPword.Location = New System.Drawing.Point(468, 442)
        Me.TxtPword.Name = "TxtPword"
        Me.TxtPword.Size = New System.Drawing.Size(272, 20)
        Me.TxtPword.TabIndex = 4
        '
        'Lblsign
        '
        Me.Lblsign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsign.Location = New System.Drawing.Point(465, 482)
        Me.Lblsign.Name = "Lblsign"
        Me.Lblsign.Size = New System.Drawing.Size(183, 40)
        Me.Lblsign.TabIndex = 5
        Me.Lblsign.Text = "Not Yet Registered?"
        Me.Lblsign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Linklblsignin
        '
        Me.Linklblsignin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linklblsignin.Location = New System.Drawing.Point(630, 482)
        Me.Linklblsignin.Name = "Linklblsignin"
        Me.Linklblsignin.Size = New System.Drawing.Size(68, 40)
        Me.Linklblsignin.TabIndex = 6
        Me.Linklblsignin.TabStop = True
        Me.Linklblsignin.Text = "Sign in."
        Me.Linklblsignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(536, 554)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(112, 41)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Log In"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.Image = Global.CodilloComprog.My.Resources.Resources.Chef_Hat_cooking_logo_template_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(401, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'picexit
        '
        Me.picexit.Image = CType(resources.GetObject("picexit.Image"), System.Drawing.Image)
        Me.picexit.Location = New System.Drawing.Point(1153, 12)
        Me.picexit.Name = "picexit"
        Me.picexit.Size = New System.Drawing.Size(36, 28)
        Me.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picexit.TabIndex = 8
        Me.picexit.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1201, 664)
        Me.Controls.Add(Me.picexit)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Linklblsignin)
        Me.Controls.Add(Me.Lblsign)
        Me.Controls.Add(Me.TxtPword)
        Me.Controls.Add(Me.TxtUname)
        Me.Controls.Add(Me.LblPword)
        Me.Controls.Add(Me.LblUname)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picexit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblUname As Label
    Friend WithEvents LblPword As Label
    Friend WithEvents TxtUname As TextBox
    Friend WithEvents TxtPword As TextBox
    Friend WithEvents Lblsign As Label
    Friend WithEvents Linklblsignin As LinkLabel
    Friend WithEvents BtnLogin As Button
    Friend WithEvents picexit As PictureBox
End Class
