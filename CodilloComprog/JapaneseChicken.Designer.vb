<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JapaneseChicken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JapaneseChicken))
        Me.gbChicken = New System.Windows.Forms.GroupBox()
        Me.gbPasta = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbPork = New System.Windows.Forms.GroupBox()
        Me.gbBeef = New System.Windows.Forms.GroupBox()
        Me.gbOthers = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnKaraage = New System.Windows.Forms.Button()
        Me.btnOyakodon = New System.Windows.Forms.Button()
        Me.btnTempura = New System.Windows.Forms.Button()
        Me.btnCurry = New System.Windows.Forms.Button()
        Me.btnTakitori = New System.Windows.Forms.Button()
        Me.btnChickenTeriyaki = New System.Windows.Forms.Button()
        Me.gbChicken.SuspendLayout()
        Me.gbPasta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbPork.SuspendLayout()
        Me.gbBeef.SuspendLayout()
        Me.gbOthers.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbChicken
        '
        Me.gbChicken.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbChicken.Controls.Add(Me.btnChickenTeriyaki)
        Me.gbChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbChicken.Location = New System.Drawing.Point(94, 110)
        Me.gbChicken.Name = "gbChicken"
        Me.gbChicken.Size = New System.Drawing.Size(210, 187)
        Me.gbChicken.TabIndex = 12
        Me.gbChicken.TabStop = False
        Me.gbChicken.Text = "Chicken Teriyaki"
        '
        'gbPasta
        '
        Me.gbPasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPasta.Controls.Add(Me.btnKaraage)
        Me.gbPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbPasta.Location = New System.Drawing.Point(380, 110)
        Me.gbPasta.Name = "gbPasta"
        Me.gbPasta.Size = New System.Drawing.Size(210, 187)
        Me.gbPasta.TabIndex = 13
        Me.gbPasta.TabStop = False
        Me.gbPasta.Text = "Karaage"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnOyakodon)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(653, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 187)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oyakodon"
        '
        'gbPork
        '
        Me.gbPork.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPork.Controls.Add(Me.btnTempura)
        Me.gbPork.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbPork.Location = New System.Drawing.Point(94, 334)
        Me.gbPork.Name = "gbPork"
        Me.gbPork.Size = New System.Drawing.Size(210, 187)
        Me.gbPork.TabIndex = 15
        Me.gbPork.TabStop = False
        Me.gbPork.Text = "Chicken Tempura"
        '
        'gbBeef
        '
        Me.gbBeef.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbBeef.Controls.Add(Me.btnCurry)
        Me.gbBeef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbBeef.Location = New System.Drawing.Point(380, 334)
        Me.gbBeef.Name = "gbBeef"
        Me.gbBeef.Size = New System.Drawing.Size(210, 187)
        Me.gbBeef.TabIndex = 16
        Me.gbBeef.TabStop = False
        Me.gbBeef.Text = "Chicken Curry"
        '
        'gbOthers
        '
        Me.gbOthers.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbOthers.Controls.Add(Me.btnTakitori)
        Me.gbOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbOthers.ForeColor = System.Drawing.Color.Black
        Me.gbOthers.Location = New System.Drawing.Point(653, 334)
        Me.gbOthers.Name = "gbOthers"
        Me.gbOthers.Size = New System.Drawing.Size(210, 187)
        Me.gbOthers.TabIndex = 17
        Me.gbOthers.TabStop = False
        Me.gbOthers.Text = "Yakitori"
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
        'btnKaraage
        '
        Me.btnKaraage.BackColor = System.Drawing.Color.Gray
        Me.btnKaraage.BackgroundImage = CType(resources.GetObject("btnKaraage.BackgroundImage"), System.Drawing.Image)
        Me.btnKaraage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKaraage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKaraage.Location = New System.Drawing.Point(27, 19)
        Me.btnKaraage.Name = "btnKaraage"
        Me.btnKaraage.Size = New System.Drawing.Size(163, 146)
        Me.btnKaraage.TabIndex = 1
        Me.btnKaraage.UseVisualStyleBackColor = False
        '
        'btnOyakodon
        '
        Me.btnOyakodon.BackColor = System.Drawing.Color.Gray
        Me.btnOyakodon.BackgroundImage = CType(resources.GetObject("btnOyakodon.BackgroundImage"), System.Drawing.Image)
        Me.btnOyakodon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOyakodon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOyakodon.Location = New System.Drawing.Point(23, 20)
        Me.btnOyakodon.Name = "btnOyakodon"
        Me.btnOyakodon.Size = New System.Drawing.Size(163, 146)
        Me.btnOyakodon.TabIndex = 2
        Me.btnOyakodon.UseVisualStyleBackColor = False
        '
        'btnTempura
        '
        Me.btnTempura.BackColor = System.Drawing.Color.Gray
        Me.btnTempura.BackgroundImage = CType(resources.GetObject("btnTempura.BackgroundImage"), System.Drawing.Image)
        Me.btnTempura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTempura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTempura.Location = New System.Drawing.Point(25, 19)
        Me.btnTempura.Name = "btnTempura"
        Me.btnTempura.Size = New System.Drawing.Size(163, 146)
        Me.btnTempura.TabIndex = 3
        Me.btnTempura.UseVisualStyleBackColor = False
        '
        'btnCurry
        '
        Me.btnCurry.BackColor = System.Drawing.Color.Gray
        Me.btnCurry.BackgroundImage = CType(resources.GetObject("btnCurry.BackgroundImage"), System.Drawing.Image)
        Me.btnCurry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCurry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCurry.Location = New System.Drawing.Point(27, 20)
        Me.btnCurry.Name = "btnCurry"
        Me.btnCurry.Size = New System.Drawing.Size(163, 146)
        Me.btnCurry.TabIndex = 4
        Me.btnCurry.UseVisualStyleBackColor = False
        '
        'btnTakitori
        '
        Me.btnTakitori.BackColor = System.Drawing.Color.Gray
        Me.btnTakitori.BackgroundImage = CType(resources.GetObject("btnTakitori.BackgroundImage"), System.Drawing.Image)
        Me.btnTakitori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTakitori.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnTakitori.Location = New System.Drawing.Point(23, 20)
        Me.btnTakitori.Name = "btnTakitori"
        Me.btnTakitori.Size = New System.Drawing.Size(163, 146)
        Me.btnTakitori.TabIndex = 5
        Me.btnTakitori.Text = " "
        Me.btnTakitori.UseVisualStyleBackColor = False
        '
        'btnChickenTeriyaki
        '
        Me.btnChickenTeriyaki.BackColor = System.Drawing.Color.Gray
        Me.btnChickenTeriyaki.BackgroundImage = CType(resources.GetObject("btnChickenTeriyaki.BackgroundImage"), System.Drawing.Image)
        Me.btnChickenTeriyaki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChickenTeriyaki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChickenTeriyaki.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChickenTeriyaki.Location = New System.Drawing.Point(25, 19)
        Me.btnChickenTeriyaki.Name = "btnChickenTeriyaki"
        Me.btnChickenTeriyaki.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnChickenTeriyaki.Size = New System.Drawing.Size(163, 146)
        Me.btnChickenTeriyaki.TabIndex = 0
        Me.btnChickenTeriyaki.Text = " "
        Me.btnChickenTeriyaki.UseVisualStyleBackColor = False
        '
        'JapaneseChicken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbChicken)
        Me.Controls.Add(Me.gbPasta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPork)
        Me.Controls.Add(Me.gbBeef)
        Me.Controls.Add(Me.gbOthers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "JapaneseChicken"
        Me.Text = "Japansestyle"
        Me.gbChicken.ResumeLayout(False)
        Me.gbPasta.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbPork.ResumeLayout(False)
        Me.gbBeef.ResumeLayout(False)
        Me.gbOthers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbChicken As GroupBox
    Friend WithEvents btnChickenTeriyaki As Button
    Friend WithEvents gbPasta As GroupBox
    Friend WithEvents btnKaraage As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOyakodon As Button
    Friend WithEvents gbPork As GroupBox
    Friend WithEvents btnTempura As Button
    Friend WithEvents gbBeef As GroupBox
    Friend WithEvents btnCurry As Button
    Friend WithEvents gbOthers As GroupBox
    Friend WithEvents btnTakitori As Button
    Friend WithEvents btnBack As Button
End Class
