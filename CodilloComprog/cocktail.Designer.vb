<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cocktail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cocktail))
        Me.gbcock3 = New System.Windows.Forms.GroupBox()
        Me.gbcock2 = New System.Windows.Forms.GroupBox()
        Me.gbcock = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnpineapple = New System.Windows.Forms.Button()
        Me.btnwatermelon = New System.Windows.Forms.Button()
        Me.btnraspberry = New System.Windows.Forms.Button()
        Me.gbcock3.SuspendLayout()
        Me.gbcock2.SuspendLayout()
        Me.gbcock.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbcock3
        '
        Me.gbcock3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbcock3.Controls.Add(Me.btnpineapple)
        Me.gbcock3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbcock3.Location = New System.Drawing.Point(649, 210)
        Me.gbcock3.Name = "gbcock3"
        Me.gbcock3.Size = New System.Drawing.Size(210, 187)
        Me.gbcock3.TabIndex = 20
        Me.gbcock3.TabStop = False
        Me.gbcock3.Text = "pineapple vodka"
        '
        'gbcock2
        '
        Me.gbcock2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbcock2.Controls.Add(Me.btnwatermelon)
        Me.gbcock2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbcock2.Location = New System.Drawing.Point(376, 210)
        Me.gbcock2.Name = "gbcock2"
        Me.gbcock2.Size = New System.Drawing.Size(210, 187)
        Me.gbcock2.TabIndex = 19
        Me.gbcock2.TabStop = False
        Me.gbcock2.Text = "watermelon tequilla"
        '
        'gbcock
        '
        Me.gbcock.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbcock.Controls.Add(Me.btnraspberry)
        Me.gbcock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbcock.Location = New System.Drawing.Point(90, 210)
        Me.gbcock.Name = "gbcock"
        Me.gbcock.Size = New System.Drawing.Size(210, 187)
        Me.gbcock.TabIndex = 18
        Me.gbcock.TabStop = False
        Me.gbcock.Text = "Rasberry lime"
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
        'btnpineapple
        '
        Me.btnpineapple.BackColor = System.Drawing.Color.Gray
        Me.btnpineapple.BackgroundImage = CType(resources.GetObject("btnpineapple.BackgroundImage"), System.Drawing.Image)
        Me.btnpineapple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpineapple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpineapple.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpineapple.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnpineapple.Location = New System.Drawing.Point(24, 20)
        Me.btnpineapple.Name = "btnpineapple"
        Me.btnpineapple.Size = New System.Drawing.Size(163, 146)
        Me.btnpineapple.TabIndex = 2
        Me.btnpineapple.Text = " "
        Me.btnpineapple.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnpineapple.UseVisualStyleBackColor = False
        '
        'btnwatermelon
        '
        Me.btnwatermelon.BackColor = System.Drawing.Color.Gray
        Me.btnwatermelon.BackgroundImage = CType(resources.GetObject("btnwatermelon.BackgroundImage"), System.Drawing.Image)
        Me.btnwatermelon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnwatermelon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwatermelon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnwatermelon.Location = New System.Drawing.Point(24, 20)
        Me.btnwatermelon.Name = "btnwatermelon"
        Me.btnwatermelon.Size = New System.Drawing.Size(163, 146)
        Me.btnwatermelon.TabIndex = 1
        Me.btnwatermelon.Text = " "
        Me.btnwatermelon.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnwatermelon.UseVisualStyleBackColor = False
        '
        'btnraspberry
        '
        Me.btnraspberry.BackColor = System.Drawing.Color.Gray
        Me.btnraspberry.BackgroundImage = CType(resources.GetObject("btnraspberry.BackgroundImage"), System.Drawing.Image)
        Me.btnraspberry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnraspberry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnraspberry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnraspberry.Location = New System.Drawing.Point(25, 19)
        Me.btnraspberry.Name = "btnraspberry"
        Me.btnraspberry.Size = New System.Drawing.Size(163, 146)
        Me.btnraspberry.TabIndex = 0
        Me.btnraspberry.Text = " "
        Me.btnraspberry.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnraspberry.UseVisualStyleBackColor = False
        '
        'cocktail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbcock3)
        Me.Controls.Add(Me.gbcock2)
        Me.Controls.Add(Me.gbcock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cocktail"
        Me.Text = "cocktail"
        Me.gbcock3.ResumeLayout(False)
        Me.gbcock2.ResumeLayout(False)
        Me.gbcock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbcock3 As GroupBox
    Friend WithEvents gbcock2 As GroupBox
    Friend WithEvents gbcock As GroupBox
    Friend WithEvents btnraspberry As Button
    Friend WithEvents btnpineapple As Button
    Friend WithEvents btnwatermelon As Button
    Friend WithEvents btnBack As Button
End Class
