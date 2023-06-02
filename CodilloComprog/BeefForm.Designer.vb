<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeefForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeefForm))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnkor = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gbFilipino = New System.Windows.Forms.GroupBox()
        Me.btnfilipino = New System.Windows.Forms.Button()
        Me.gbJapan = New System.Windows.Forms.GroupBox()
        Me.btnjapan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbFilipino.SuspendLayout()
        Me.gbJapan.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(863, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 40)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnkor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(378, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 187)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Korean Style"
        '
        'btnkor
        '
        Me.btnkor.BackColor = System.Drawing.Color.Gray
        Me.btnkor.BackgroundImage = CType(resources.GetObject("btnkor.BackgroundImage"), System.Drawing.Image)
        Me.btnkor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnkor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnkor.Location = New System.Drawing.Point(27, 22)
        Me.btnkor.Name = "btnkor"
        Me.btnkor.Size = New System.Drawing.Size(163, 146)
        Me.btnkor.TabIndex = 6
        Me.btnkor.Text = " "
        Me.btnkor.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.italian_amrican1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Button3.Location = New System.Drawing.Point(405, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 146)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = " "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'gbFilipino
        '
        Me.gbFilipino.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbFilipino.Controls.Add(Me.btnfilipino)
        Me.gbFilipino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbFilipino.Location = New System.Drawing.Point(651, 222)
        Me.gbFilipino.Name = "gbFilipino"
        Me.gbFilipino.Size = New System.Drawing.Size(210, 187)
        Me.gbFilipino.TabIndex = 40
        Me.gbFilipino.TabStop = False
        Me.gbFilipino.Text = "Filipino Style"
        '
        'btnfilipino
        '
        Me.btnfilipino.BackColor = System.Drawing.Color.Gray
        Me.btnfilipino.BackgroundImage = CType(resources.GetObject("btnfilipino.BackgroundImage"), System.Drawing.Image)
        Me.btnfilipino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilipino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfilipino.Location = New System.Drawing.Point(23, 20)
        Me.btnfilipino.Name = "btnfilipino"
        Me.btnfilipino.Size = New System.Drawing.Size(163, 146)
        Me.btnfilipino.TabIndex = 2
        Me.btnfilipino.UseVisualStyleBackColor = False
        '
        'gbJapan
        '
        Me.gbJapan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbJapan.Controls.Add(Me.btnjapan)
        Me.gbJapan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbJapan.Location = New System.Drawing.Point(92, 222)
        Me.gbJapan.Name = "gbJapan"
        Me.gbJapan.Size = New System.Drawing.Size(210, 187)
        Me.gbJapan.TabIndex = 39
        Me.gbJapan.TabStop = False
        Me.gbJapan.Text = "Japanese Style"
        '
        'btnjapan
        '
        Me.btnjapan.BackColor = System.Drawing.Color.Gray
        Me.btnjapan.BackgroundImage = CType(resources.GetObject("btnjapan.BackgroundImage"), System.Drawing.Image)
        Me.btnjapan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnjapan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnjapan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnjapan.Location = New System.Drawing.Point(25, 19)
        Me.btnjapan.Name = "btnjapan"
        Me.btnjapan.Size = New System.Drawing.Size(163, 146)
        Me.btnjapan.TabIndex = 0
        Me.btnjapan.Text = " "
        Me.btnjapan.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnjapan.UseVisualStyleBackColor = False
        '
        'BeefForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.gbFilipino)
        Me.Controls.Add(Me.gbJapan)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BeefForm"
        Me.Text = "BeefForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbFilipino.ResumeLayout(False)
        Me.gbJapan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnkor As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents gbFilipino As GroupBox
    Friend WithEvents btnfilipino As Button
    Friend WithEvents gbJapan As GroupBox
    Friend WithEvents btnjapan As Button
End Class
