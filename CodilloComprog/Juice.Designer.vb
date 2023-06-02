<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juice))
        Me.gbjuice3 = New System.Windows.Forms.GroupBox()
        Me.gbjuice2 = New System.Windows.Forms.GroupBox()
        Me.gbjuice = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnlemonjuice = New System.Windows.Forms.Button()
        Me.btncarrotjuice = New System.Windows.Forms.Button()
        Me.btnorange = New System.Windows.Forms.Button()
        Me.gbjuice3.SuspendLayout()
        Me.gbjuice2.SuspendLayout()
        Me.gbjuice.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbjuice3
        '
        Me.gbjuice3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbjuice3.Controls.Add(Me.btnlemonjuice)
        Me.gbjuice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbjuice3.Location = New System.Drawing.Point(653, 222)
        Me.gbjuice3.Name = "gbjuice3"
        Me.gbjuice3.Size = New System.Drawing.Size(210, 187)
        Me.gbjuice3.TabIndex = 20
        Me.gbjuice3.TabStop = False
        Me.gbjuice3.Text = "Lemon juice"
        '
        'gbjuice2
        '
        Me.gbjuice2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbjuice2.Controls.Add(Me.btncarrotjuice)
        Me.gbjuice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbjuice2.Location = New System.Drawing.Point(380, 222)
        Me.gbjuice2.Name = "gbjuice2"
        Me.gbjuice2.Size = New System.Drawing.Size(210, 187)
        Me.gbjuice2.TabIndex = 19
        Me.gbjuice2.TabStop = False
        Me.gbjuice2.Text = "carrot juice"
        '
        'gbjuice
        '
        Me.gbjuice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbjuice.Controls.Add(Me.btnorange)
        Me.gbjuice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbjuice.Location = New System.Drawing.Point(94, 222)
        Me.gbjuice.Name = "gbjuice"
        Me.gbjuice.Size = New System.Drawing.Size(210, 187)
        Me.gbjuice.TabIndex = 18
        Me.gbjuice.TabStop = False
        Me.gbjuice.Text = "Orange Juice "
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(863, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 40)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnlemonjuice
        '
        Me.btnlemonjuice.BackColor = System.Drawing.Color.Gray
        Me.btnlemonjuice.BackgroundImage = CType(resources.GetObject("btnlemonjuice.BackgroundImage"), System.Drawing.Image)
        Me.btnlemonjuice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlemonjuice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlemonjuice.Location = New System.Drawing.Point(23, 20)
        Me.btnlemonjuice.Name = "btnlemonjuice"
        Me.btnlemonjuice.Size = New System.Drawing.Size(163, 146)
        Me.btnlemonjuice.TabIndex = 2
        Me.btnlemonjuice.UseVisualStyleBackColor = False
        '
        'btncarrotjuice
        '
        Me.btncarrotjuice.BackColor = System.Drawing.Color.Gray
        Me.btncarrotjuice.BackgroundImage = CType(resources.GetObject("btncarrotjuice.BackgroundImage"), System.Drawing.Image)
        Me.btncarrotjuice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncarrotjuice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncarrotjuice.Location = New System.Drawing.Point(27, 19)
        Me.btncarrotjuice.Name = "btncarrotjuice"
        Me.btncarrotjuice.Size = New System.Drawing.Size(163, 146)
        Me.btncarrotjuice.TabIndex = 1
        Me.btncarrotjuice.UseVisualStyleBackColor = False
        '
        'btnorange
        '
        Me.btnorange.BackColor = System.Drawing.Color.Gray
        Me.btnorange.BackgroundImage = CType(resources.GetObject("btnorange.BackgroundImage"), System.Drawing.Image)
        Me.btnorange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnorange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnorange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnorange.Location = New System.Drawing.Point(25, 19)
        Me.btnorange.Name = "btnorange"
        Me.btnorange.Size = New System.Drawing.Size(163, 146)
        Me.btnorange.TabIndex = 0
        Me.btnorange.Text = " "
        Me.btnorange.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnorange.UseVisualStyleBackColor = False
        '
        'Juice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbjuice3)
        Me.Controls.Add(Me.gbjuice2)
        Me.Controls.Add(Me.gbjuice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Juice"
        Me.Text = "Juice"
        Me.gbjuice3.ResumeLayout(False)
        Me.gbjuice2.ResumeLayout(False)
        Me.gbjuice.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbjuice3 As GroupBox
    Friend WithEvents btnlemonjuice As Button
    Friend WithEvents gbjuice2 As GroupBox
    Friend WithEvents btncarrotjuice As Button
    Friend WithEvents gbjuice As GroupBox
    Friend WithEvents btnorange As Button
    Friend WithEvents btnBack As Button
End Class
