<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblUname = New System.Windows.Forms.Label()
        Me.Txtreguname = New System.Windows.Forms.TextBox()
        Me.Txtregpword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreg = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Chbox = New System.Windows.Forms.CheckBox()
        Me.Txtregconpword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.Image = Global.CodilloComprog.My.Resources.Resources.Chef_Hat_cooking_logo_template_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(393, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(378, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LblUname
        '
        Me.LblUname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUname.Location = New System.Drawing.Point(329, 326)
        Me.LblUname.Name = "LblUname"
        Me.LblUname.Size = New System.Drawing.Size(115, 23)
        Me.LblUname.TabIndex = 7
        Me.LblUname.Text = "User Name:"
        Me.LblUname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txtreguname
        '
        Me.Txtreguname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtreguname.Location = New System.Drawing.Point(486, 329)
        Me.Txtreguname.Name = "Txtreguname"
        Me.Txtreguname.Size = New System.Drawing.Size(214, 20)
        Me.Txtreguname.TabIndex = 1
        Me.Txtreguname.Text = "Enter username"
        '
        'Txtregpword
        '
        Me.Txtregpword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtregpword.Location = New System.Drawing.Point(486, 378)
        Me.Txtregpword.Name = "Txtregpword"
        Me.Txtregpword.Size = New System.Drawing.Size(214, 20)
        Me.Txtregpword.TabIndex = 2
        Me.Txtregpword.Text = "Enter Password"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Password:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnreg
        '
        Me.btnreg.Enabled = False
        Me.btnreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Location = New System.Drawing.Point(486, 554)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(149, 44)
        Me.btnreg.TabIndex = 5
        Me.btnreg.Text = "Register"
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(1091, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(73, 38)
        Me.btnback.TabIndex = 6
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Chbox
        '
        Me.Chbox.AutoSize = True
        Me.Chbox.Location = New System.Drawing.Point(452, 491)
        Me.Chbox.Name = "Chbox"
        Me.Chbox.Size = New System.Drawing.Size(271, 30)
        Me.Chbox.TabIndex = 4
        Me.Chbox.Text = "I Agree, to the policy and terms the services offered." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Chbox.UseVisualStyleBackColor = True
        '
        'Txtregconpword
        '
        Me.Txtregconpword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtregconpword.Location = New System.Drawing.Point(486, 431)
        Me.Txtregconpword.Name = "Txtregconpword"
        Me.Txtregconpword.Size = New System.Drawing.Size(214, 20)
        Me.Txtregconpword.TabIndex = 3
        Me.Txtregconpword.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 53)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Confirm Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(1176, 651)
        Me.Controls.Add(Me.Txtregconpword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chbox)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.Txtregpword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtreguname)
        Me.Controls.Add(Me.LblUname)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegForm"
        Me.Text = "RegForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblUname As Label
    Friend WithEvents Txtreguname As TextBox
    Friend WithEvents Txtregpword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreg As Button
    Friend WithEvents btnback As Button
    Friend WithEvents Chbox As CheckBox
    Friend WithEvents Txtregconpword As TextBox
    Friend WithEvents Label2 As Label
End Class
