<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChickenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChickenForm))
        Me.gbMiddle = New System.Windows.Forms.GroupBox()
        Me.btnmiddle = New System.Windows.Forms.Button()
        Me.gbFilipino = New System.Windows.Forms.GroupBox()
        Me.btnfilipino = New System.Windows.Forms.Button()
        Me.gbJapan = New System.Windows.Forms.GroupBox()
        Me.btnjapan = New System.Windows.Forms.Button()
        Me.gbThai = New System.Windows.Forms.GroupBox()
        Me.btnthai = New System.Windows.Forms.Button()
        Me.gbitalianAmerica = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnitalian = New System.Windows.Forms.Button()
        Me.gbMiddle.SuspendLayout()
        Me.gbFilipino.SuspendLayout()
        Me.gbJapan.SuspendLayout()
        Me.gbThai.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMiddle
        '
        Me.gbMiddle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbMiddle.Controls.Add(Me.btnmiddle)
        Me.gbMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbMiddle.Location = New System.Drawing.Point(86, 314)
        Me.gbMiddle.Name = "gbMiddle"
        Me.gbMiddle.Size = New System.Drawing.Size(210, 187)
        Me.gbMiddle.TabIndex = 21
        Me.gbMiddle.TabStop = False
        Me.gbMiddle.Text = "Middle Eastern Style"
        '
        'btnmiddle
        '
        Me.btnmiddle.BackColor = System.Drawing.Color.Gray
        Me.btnmiddle.BackgroundImage = CType(resources.GetObject("btnmiddle.BackgroundImage"), System.Drawing.Image)
        Me.btnmiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmiddle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmiddle.Location = New System.Drawing.Point(25, 19)
        Me.btnmiddle.Name = "btnmiddle"
        Me.btnmiddle.Size = New System.Drawing.Size(163, 146)
        Me.btnmiddle.TabIndex = 3
        Me.btnmiddle.UseVisualStyleBackColor = False
        '
        'gbFilipino
        '
        Me.gbFilipino.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbFilipino.Controls.Add(Me.btnfilipino)
        Me.gbFilipino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbFilipino.Location = New System.Drawing.Point(645, 90)
        Me.gbFilipino.Name = "gbFilipino"
        Me.gbFilipino.Size = New System.Drawing.Size(210, 187)
        Me.gbFilipino.TabIndex = 20
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
        Me.gbJapan.Location = New System.Drawing.Point(86, 90)
        Me.gbJapan.Name = "gbJapan"
        Me.gbJapan.Size = New System.Drawing.Size(210, 187)
        Me.gbJapan.TabIndex = 18
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
        'gbThai
        '
        Me.gbThai.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbThai.Controls.Add(Me.btnthai)
        Me.gbThai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbThai.Location = New System.Drawing.Point(372, 314)
        Me.gbThai.Name = "gbThai"
        Me.gbThai.Size = New System.Drawing.Size(210, 187)
        Me.gbThai.TabIndex = 22
        Me.gbThai.TabStop = False
        Me.gbThai.Text = "Thai Style"
        '
        'btnthai
        '
        Me.btnthai.BackColor = System.Drawing.Color.Gray
        Me.btnthai.BackgroundImage = CType(resources.GetObject("btnthai.BackgroundImage"), System.Drawing.Image)
        Me.btnthai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnthai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnthai.Location = New System.Drawing.Point(27, 20)
        Me.btnthai.Name = "btnthai"
        Me.btnthai.Size = New System.Drawing.Size(163, 146)
        Me.btnthai.TabIndex = 4
        Me.btnthai.UseVisualStyleBackColor = False
        '
        'gbitalianAmerica
        '
        Me.gbitalianAmerica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbitalianAmerica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbitalianAmerica.ForeColor = System.Drawing.Color.Black
        Me.gbitalianAmerica.Location = New System.Drawing.Point(372, 90)
        Me.gbitalianAmerica.Name = "gbitalianAmerica"
        Me.gbitalianAmerica.Size = New System.Drawing.Size(210, 187)
        Me.gbitalianAmerica.TabIndex = 23
        Me.gbitalianAmerica.TabStop = False
        Me.gbitalianAmerica.Text = "Italian-American Style"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(863, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 40)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnitalian
        '
        Me.btnitalian.BackColor = System.Drawing.Color.Gray
        Me.btnitalian.BackgroundImage = CType(resources.GetObject("btnitalian.BackgroundImage"), System.Drawing.Image)
        Me.btnitalian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnitalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnitalian.Location = New System.Drawing.Point(399, 109)
        Me.btnitalian.Name = "btnitalian"
        Me.btnitalian.Size = New System.Drawing.Size(163, 146)
        Me.btnitalian.TabIndex = 5
        Me.btnitalian.Text = " "
        Me.btnitalian.UseVisualStyleBackColor = False
        '
        'ChickenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.btnitalian)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbMiddle)
        Me.Controls.Add(Me.gbFilipino)
        Me.Controls.Add(Me.gbJapan)
        Me.Controls.Add(Me.gbThai)
        Me.Controls.Add(Me.gbitalianAmerica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChickenForm"
        Me.Text = "ChickenForm"
        Me.gbMiddle.ResumeLayout(False)
        Me.gbFilipino.ResumeLayout(False)
        Me.gbJapan.ResumeLayout(False)
        Me.gbThai.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMiddle As GroupBox
    Friend WithEvents btnmiddle As Button
    Friend WithEvents gbFilipino As GroupBox
    Friend WithEvents btnfilipino As Button
    Friend WithEvents gbJapan As GroupBox
    Friend WithEvents btnjapan As Button
    Friend WithEvents gbThai As GroupBox
    Friend WithEvents btnthai As Button
    Friend WithEvents gbitalianAmerica As GroupBox
    Friend WithEvents btnitalian As Button
    Friend WithEvents btnBack As Button
End Class
