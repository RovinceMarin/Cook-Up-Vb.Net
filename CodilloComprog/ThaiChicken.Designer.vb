<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThaiChicken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThaiChicken))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbMiddle = New System.Windows.Forms.GroupBox()
        Me.gbFilipino = New System.Windows.Forms.GroupBox()
        Me.gbJapan = New System.Windows.Forms.GroupBox()
        Me.gbThai = New System.Windows.Forms.GroupBox()
        Me.gbitalianAmerica = New System.Windows.Forms.GroupBox()
        Me.btnpadthai = New System.Windows.Forms.Button()
        Me.btntomyum = New System.Windows.Forms.Button()
        Me.btnsatay = New System.Windows.Forms.Button()
        Me.btncurry = New System.Windows.Forms.Button()
        Me.btnkhagai = New System.Windows.Forms.Button()
        Me.gbMiddle.SuspendLayout()
        Me.gbFilipino.SuspendLayout()
        Me.gbJapan.SuspendLayout()
        Me.gbThai.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(863, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 40)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gbMiddle
        '
        Me.gbMiddle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbMiddle.Controls.Add(Me.btntomyum)
        Me.gbMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbMiddle.Location = New System.Drawing.Point(94, 334)
        Me.gbMiddle.Name = "gbMiddle"
        Me.gbMiddle.Size = New System.Drawing.Size(210, 187)
        Me.gbMiddle.TabIndex = 30
        Me.gbMiddle.TabStop = False
        Me.gbMiddle.Text = "Tom Yum"
        '
        'gbFilipino
        '
        Me.gbFilipino.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbFilipino.Controls.Add(Me.btnsatay)
        Me.gbFilipino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbFilipino.Location = New System.Drawing.Point(653, 110)
        Me.gbFilipino.Name = "gbFilipino"
        Me.gbFilipino.Size = New System.Drawing.Size(210, 187)
        Me.gbFilipino.TabIndex = 29
        Me.gbFilipino.TabStop = False
        Me.gbFilipino.Text = "Satay"
        '
        'gbJapan
        '
        Me.gbJapan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbJapan.Controls.Add(Me.btncurry)
        Me.gbJapan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbJapan.Location = New System.Drawing.Point(94, 110)
        Me.gbJapan.Name = "gbJapan"
        Me.gbJapan.Size = New System.Drawing.Size(210, 187)
        Me.gbJapan.TabIndex = 28
        Me.gbJapan.TabStop = False
        Me.gbJapan.Text = "Curry"
        '
        'gbThai
        '
        Me.gbThai.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbThai.Controls.Add(Me.btnkhagai)
        Me.gbThai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbThai.Location = New System.Drawing.Point(380, 334)
        Me.gbThai.Name = "gbThai"
        Me.gbThai.Size = New System.Drawing.Size(210, 187)
        Me.gbThai.TabIndex = 31
        Me.gbThai.TabStop = False
        Me.gbThai.Text = "Tom Kha gai"
        '
        'gbitalianAmerica
        '
        Me.gbitalianAmerica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbitalianAmerica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbitalianAmerica.ForeColor = System.Drawing.Color.Black
        Me.gbitalianAmerica.Location = New System.Drawing.Point(380, 110)
        Me.gbitalianAmerica.Name = "gbitalianAmerica"
        Me.gbitalianAmerica.Size = New System.Drawing.Size(210, 187)
        Me.gbitalianAmerica.TabIndex = 32
        Me.gbitalianAmerica.TabStop = False
        Me.gbitalianAmerica.Text = "Pad Thai"
        '
        'btnpadthai
        '
        Me.btnpadthai.BackColor = System.Drawing.Color.Gray
        Me.btnpadthai.BackgroundImage = CType(resources.GetObject("btnpadthai.BackgroundImage"), System.Drawing.Image)
        Me.btnpadthai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpadthai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnpadthai.Location = New System.Drawing.Point(407, 129)
        Me.btnpadthai.Name = "btnpadthai"
        Me.btnpadthai.Size = New System.Drawing.Size(163, 146)
        Me.btnpadthai.TabIndex = 27
        Me.btnpadthai.Text = " "
        Me.btnpadthai.UseVisualStyleBackColor = False
        '
        'btntomyum
        '
        Me.btntomyum.BackColor = System.Drawing.Color.Gray
        Me.btntomyum.BackgroundImage = CType(resources.GetObject("btntomyum.BackgroundImage"), System.Drawing.Image)
        Me.btntomyum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntomyum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntomyum.Location = New System.Drawing.Point(25, 19)
        Me.btntomyum.Name = "btntomyum"
        Me.btntomyum.Size = New System.Drawing.Size(163, 146)
        Me.btntomyum.TabIndex = 3
        Me.btntomyum.UseVisualStyleBackColor = False
        '
        'btnsatay
        '
        Me.btnsatay.BackColor = System.Drawing.Color.Gray
        Me.btnsatay.BackgroundImage = CType(resources.GetObject("btnsatay.BackgroundImage"), System.Drawing.Image)
        Me.btnsatay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsatay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsatay.Location = New System.Drawing.Point(23, 20)
        Me.btnsatay.Name = "btnsatay"
        Me.btnsatay.Size = New System.Drawing.Size(163, 146)
        Me.btnsatay.TabIndex = 2
        Me.btnsatay.UseVisualStyleBackColor = False
        '
        'btncurry
        '
        Me.btncurry.BackColor = System.Drawing.Color.Gray
        Me.btncurry.BackgroundImage = CType(resources.GetObject("btncurry.BackgroundImage"), System.Drawing.Image)
        Me.btncurry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncurry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncurry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncurry.Location = New System.Drawing.Point(25, 19)
        Me.btncurry.Name = "btncurry"
        Me.btncurry.Size = New System.Drawing.Size(163, 146)
        Me.btncurry.TabIndex = 0
        Me.btncurry.Text = " "
        Me.btncurry.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btncurry.UseVisualStyleBackColor = False
        '
        'btnkhagai
        '
        Me.btnkhagai.BackColor = System.Drawing.Color.Gray
        Me.btnkhagai.BackgroundImage = CType(resources.GetObject("btnkhagai.BackgroundImage"), System.Drawing.Image)
        Me.btnkhagai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnkhagai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkhagai.Location = New System.Drawing.Point(27, 20)
        Me.btnkhagai.Name = "btnkhagai"
        Me.btnkhagai.Size = New System.Drawing.Size(163, 146)
        Me.btnkhagai.TabIndex = 4
        Me.btnkhagai.UseVisualStyleBackColor = False
        '
        'ThaiChicken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.btnpadthai)
        Me.Controls.Add(Me.gbMiddle)
        Me.Controls.Add(Me.gbFilipino)
        Me.Controls.Add(Me.gbJapan)
        Me.Controls.Add(Me.gbThai)
        Me.Controls.Add(Me.gbitalianAmerica)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ThaiChicken"
        Me.Text = "ThaiChicken"
        Me.gbMiddle.ResumeLayout(False)
        Me.gbFilipino.ResumeLayout(False)
        Me.gbJapan.ResumeLayout(False)
        Me.gbThai.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnpadthai As Button
    Friend WithEvents gbMiddle As GroupBox
    Friend WithEvents btntomyum As Button
    Friend WithEvents gbFilipino As GroupBox
    Friend WithEvents btnsatay As Button
    Friend WithEvents gbJapan As GroupBox
    Friend WithEvents btncurry As Button
    Friend WithEvents gbThai As GroupBox
    Friend WithEvents btnkhagai As Button
    Friend WithEvents gbitalianAmerica As GroupBox
End Class
