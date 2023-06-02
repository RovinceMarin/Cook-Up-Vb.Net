<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VeggiesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VeggiesForm))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbPAstry = New System.Windows.Forms.GroupBox()
        Me.gbpass = New System.Windows.Forms.GroupBox()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.btnkong = New System.Windows.Forms.Button()
        Me.btnchop = New System.Windows.Forms.Button()
        Me.btnceasar = New System.Windows.Forms.Button()
        Me.gbPAstry.SuspendLayout()
        Me.gbpass.SuspendLayout()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(863, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 40)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gbPAstry
        '
        Me.gbPAstry.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPAstry.Controls.Add(Me.btnkong)
        Me.gbPAstry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbPAstry.Location = New System.Drawing.Point(653, 222)
        Me.gbPAstry.Name = "gbPAstry"
        Me.gbPAstry.Size = New System.Drawing.Size(210, 187)
        Me.gbPAstry.TabIndex = 41
        Me.gbPAstry.TabStop = False
        Me.gbPAstry.Text = "Fried Kangkong"
        '
        'gbpass
        '
        Me.gbpass.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbpass.Controls.Add(Me.btnchop)
        Me.gbpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbpass.Location = New System.Drawing.Point(380, 222)
        Me.gbpass.Name = "gbpass"
        Me.gbpass.Size = New System.Drawing.Size(210, 187)
        Me.gbpass.TabIndex = 40
        Me.gbpass.TabStop = False
        Me.gbpass.Text = "Chopseuy"
        '
        'GB
        '
        Me.GB.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GB.Controls.Add(Me.btnceasar)
        Me.GB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GB.Location = New System.Drawing.Point(94, 222)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(210, 187)
        Me.GB.TabIndex = 39
        Me.GB.TabStop = False
        Me.GB.Text = "Ceasar Salad"
        '
        'btnkong
        '
        Me.btnkong.BackColor = System.Drawing.Color.Gray
        Me.btnkong.BackgroundImage = CType(resources.GetObject("btnkong.BackgroundImage"), System.Drawing.Image)
        Me.btnkong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnkong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkong.Location = New System.Drawing.Point(23, 20)
        Me.btnkong.Name = "btnkong"
        Me.btnkong.Size = New System.Drawing.Size(163, 146)
        Me.btnkong.TabIndex = 2
        Me.btnkong.UseVisualStyleBackColor = False
        '
        'btnchop
        '
        Me.btnchop.BackColor = System.Drawing.Color.Gray
        Me.btnchop.BackgroundImage = CType(resources.GetObject("btnchop.BackgroundImage"), System.Drawing.Image)
        Me.btnchop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnchop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnchop.Location = New System.Drawing.Point(27, 19)
        Me.btnchop.Name = "btnchop"
        Me.btnchop.Size = New System.Drawing.Size(163, 146)
        Me.btnchop.TabIndex = 1
        Me.btnchop.UseVisualStyleBackColor = False
        '
        'btnceasar
        '
        Me.btnceasar.BackColor = System.Drawing.Color.Gray
        Me.btnceasar.BackgroundImage = CType(resources.GetObject("btnceasar.BackgroundImage"), System.Drawing.Image)
        Me.btnceasar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnceasar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnceasar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnceasar.Location = New System.Drawing.Point(25, 19)
        Me.btnceasar.Name = "btnceasar"
        Me.btnceasar.Size = New System.Drawing.Size(163, 146)
        Me.btnceasar.TabIndex = 0
        Me.btnceasar.Text = " "
        Me.btnceasar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnceasar.UseVisualStyleBackColor = False
        '
        'VeggiesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.gbPAstry)
        Me.Controls.Add(Me.gbpass)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VeggiesForm"
        Me.Text = "VeggiesForm"
        Me.gbPAstry.ResumeLayout(False)
        Me.gbpass.ResumeLayout(False)
        Me.GB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents gbPAstry As GroupBox
    Friend WithEvents btnkong As Button
    Friend WithEvents gbpass As GroupBox
    Friend WithEvents btnchop As Button
    Friend WithEvents GB As GroupBox
    Friend WithEvents btnceasar As Button
End Class
