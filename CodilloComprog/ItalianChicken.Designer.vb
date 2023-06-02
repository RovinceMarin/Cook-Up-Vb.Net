<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItalianChicken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItalianChicken))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbMiddle = New System.Windows.Forms.GroupBox()
        Me.gbFilipino = New System.Windows.Forms.GroupBox()
        Me.gbJapan = New System.Windows.Forms.GroupBox()
        Me.gbThai = New System.Windows.Forms.GroupBox()
        Me.btnparmesan = New System.Windows.Forms.Button()
        Me.btnmarsala = New System.Windows.Forms.Button()
        Me.btnflorentine = New System.Windows.Forms.Button()
        Me.btnpiccata = New System.Windows.Forms.Button()
        Me.gbitalianAmerica = New System.Windows.Forms.GroupBox()
        Me.btnalfredo = New System.Windows.Forms.Button()
        Me.gbMiddle.SuspendLayout()
        Me.gbFilipino.SuspendLayout()
        Me.gbJapan.SuspendLayout()
        Me.gbThai.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(847, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 40)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gbMiddle
        '
        Me.gbMiddle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbMiddle.Controls.Add(Me.btnparmesan)
        Me.gbMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbMiddle.Location = New System.Drawing.Point(86, 314)
        Me.gbMiddle.Name = "gbMiddle"
        Me.gbMiddle.Size = New System.Drawing.Size(210, 187)
        Me.gbMiddle.TabIndex = 36
        Me.gbMiddle.TabStop = False
        Me.gbMiddle.Text = "Parmesan"
        '
        'gbFilipino
        '
        Me.gbFilipino.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbFilipino.Controls.Add(Me.btnmarsala)
        Me.gbFilipino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbFilipino.Location = New System.Drawing.Point(645, 90)
        Me.gbFilipino.Name = "gbFilipino"
        Me.gbFilipino.Size = New System.Drawing.Size(210, 187)
        Me.gbFilipino.TabIndex = 35
        Me.gbFilipino.TabStop = False
        Me.gbFilipino.Text = "Marsala"
        '
        'gbJapan
        '
        Me.gbJapan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbJapan.Controls.Add(Me.btnflorentine)
        Me.gbJapan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbJapan.Location = New System.Drawing.Point(86, 90)
        Me.gbJapan.Name = "gbJapan"
        Me.gbJapan.Size = New System.Drawing.Size(210, 187)
        Me.gbJapan.TabIndex = 34
        Me.gbJapan.TabStop = False
        Me.gbJapan.Text = "Florentine"
        '
        'gbThai
        '
        Me.gbThai.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbThai.Controls.Add(Me.btnpiccata)
        Me.gbThai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbThai.Location = New System.Drawing.Point(372, 314)
        Me.gbThai.Name = "gbThai"
        Me.gbThai.Size = New System.Drawing.Size(210, 187)
        Me.gbThai.TabIndex = 37
        Me.gbThai.TabStop = False
        Me.gbThai.Text = "Piccata"
        '
        'btnparmesan
        '
        Me.btnparmesan.BackColor = System.Drawing.Color.Gray
        Me.btnparmesan.BackgroundImage = CType(resources.GetObject("btnparmesan.BackgroundImage"), System.Drawing.Image)
        Me.btnparmesan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnparmesan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnparmesan.Location = New System.Drawing.Point(25, 20)
        Me.btnparmesan.Name = "btnparmesan"
        Me.btnparmesan.Size = New System.Drawing.Size(163, 146)
        Me.btnparmesan.TabIndex = 3
        Me.btnparmesan.UseVisualStyleBackColor = False
        '
        'btnmarsala
        '
        Me.btnmarsala.BackColor = System.Drawing.Color.Gray
        Me.btnmarsala.BackgroundImage = CType(resources.GetObject("btnmarsala.BackgroundImage"), System.Drawing.Image)
        Me.btnmarsala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmarsala.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmarsala.Location = New System.Drawing.Point(23, 20)
        Me.btnmarsala.Name = "btnmarsala"
        Me.btnmarsala.Size = New System.Drawing.Size(163, 146)
        Me.btnmarsala.TabIndex = 2
        Me.btnmarsala.UseVisualStyleBackColor = False
        '
        'btnflorentine
        '
        Me.btnflorentine.BackColor = System.Drawing.Color.Gray
        Me.btnflorentine.BackgroundImage = CType(resources.GetObject("btnflorentine.BackgroundImage"), System.Drawing.Image)
        Me.btnflorentine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnflorentine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnflorentine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnflorentine.Location = New System.Drawing.Point(25, 19)
        Me.btnflorentine.Name = "btnflorentine"
        Me.btnflorentine.Size = New System.Drawing.Size(163, 146)
        Me.btnflorentine.TabIndex = 0
        Me.btnflorentine.Text = " "
        Me.btnflorentine.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnflorentine.UseVisualStyleBackColor = False
        '
        'btnpiccata
        '
        Me.btnpiccata.BackColor = System.Drawing.Color.Gray
        Me.btnpiccata.BackgroundImage = CType(resources.GetObject("btnpiccata.BackgroundImage"), System.Drawing.Image)
        Me.btnpiccata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpiccata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpiccata.Location = New System.Drawing.Point(27, 20)
        Me.btnpiccata.Name = "btnpiccata"
        Me.btnpiccata.Size = New System.Drawing.Size(163, 146)
        Me.btnpiccata.TabIndex = 4
        Me.btnpiccata.UseVisualStyleBackColor = False
        '
        'gbitalianAmerica
        '
        Me.gbitalianAmerica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbitalianAmerica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbitalianAmerica.ForeColor = System.Drawing.Color.Black
        Me.gbitalianAmerica.Location = New System.Drawing.Point(372, 90)
        Me.gbitalianAmerica.Name = "gbitalianAmerica"
        Me.gbitalianAmerica.Size = New System.Drawing.Size(210, 187)
        Me.gbitalianAmerica.TabIndex = 38
        Me.gbitalianAmerica.TabStop = False
        Me.gbitalianAmerica.Text = "Alfredo"
        '
        'btnalfredo
        '
        Me.btnalfredo.BackColor = System.Drawing.Color.Gray
        Me.btnalfredo.BackgroundImage = CType(resources.GetObject("btnalfredo.BackgroundImage"), System.Drawing.Image)
        Me.btnalfredo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnalfredo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnalfredo.Location = New System.Drawing.Point(399, 109)
        Me.btnalfredo.Name = "btnalfredo"
        Me.btnalfredo.Size = New System.Drawing.Size(163, 146)
        Me.btnalfredo.TabIndex = 33
        Me.btnalfredo.Text = " "
        Me.btnalfredo.UseVisualStyleBackColor = False
        '
        'ItalianChicken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 591)
        Me.Controls.Add(Me.btnalfredo)
        Me.Controls.Add(Me.gbMiddle)
        Me.Controls.Add(Me.gbFilipino)
        Me.Controls.Add(Me.gbJapan)
        Me.Controls.Add(Me.gbThai)
        Me.Controls.Add(Me.gbitalianAmerica)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItalianChicken"
        Me.Text = "ItalianChicken"
        Me.gbMiddle.ResumeLayout(False)
        Me.gbFilipino.ResumeLayout(False)
        Me.gbJapan.ResumeLayout(False)
        Me.gbThai.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents gbMiddle As GroupBox
    Friend WithEvents btnparmesan As Button
    Friend WithEvents gbFilipino As GroupBox
    Friend WithEvents btnmarsala As Button
    Friend WithEvents gbJapan As GroupBox
    Friend WithEvents btnflorentine As Button
    Friend WithEvents gbThai As GroupBox
    Friend WithEvents btnpiccata As Button
    Friend WithEvents gbitalianAmerica As GroupBox
    Friend WithEvents btnalfredo As Button
End Class
