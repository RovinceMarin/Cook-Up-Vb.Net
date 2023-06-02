<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DessertForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVeggies = New System.Windows.Forms.Button()
        Me.gbPasta = New System.Windows.Forms.GroupBox()
        Me.btnPasta = New System.Windows.Forms.Button()
        Me.gbChicken = New System.Windows.Forms.GroupBox()
        Me.btnChicken = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbPasta.SuspendLayout()
        Me.gbChicken.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnVeggies)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(631, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 187)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pastries"
        '
        'btnVeggies
        '
        Me.btnVeggies.BackColor = System.Drawing.Color.Gray
        Me.btnVeggies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVeggies.Image = Global.CodilloComprog.My.Resources.Resources.bakery
        Me.btnVeggies.Location = New System.Drawing.Point(23, 20)
        Me.btnVeggies.Name = "btnVeggies"
        Me.btnVeggies.Size = New System.Drawing.Size(163, 146)
        Me.btnVeggies.TabIndex = 2
        Me.btnVeggies.UseVisualStyleBackColor = False
        '
        'gbPasta
        '
        Me.gbPasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPasta.Controls.Add(Me.btnPasta)
        Me.gbPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbPasta.Location = New System.Drawing.Point(357, 217)
        Me.gbPasta.Name = "gbPasta"
        Me.gbPasta.Size = New System.Drawing.Size(210, 187)
        Me.gbPasta.TabIndex = 19
        Me.gbPasta.TabStop = False
        Me.gbPasta.Text = "Ice Cream"
        '
        'btnPasta
        '
        Me.btnPasta.BackColor = System.Drawing.Color.Gray
        Me.btnPasta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPasta.Image = Global.CodilloComprog.My.Resources.Resources.ice_cream
        Me.btnPasta.Location = New System.Drawing.Point(27, 19)
        Me.btnPasta.Name = "btnPasta"
        Me.btnPasta.Size = New System.Drawing.Size(163, 146)
        Me.btnPasta.TabIndex = 1
        Me.btnPasta.UseVisualStyleBackColor = False
        '
        'gbChicken
        '
        Me.gbChicken.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbChicken.Controls.Add(Me.btnChicken)
        Me.gbChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbChicken.Location = New System.Drawing.Point(80, 217)
        Me.gbChicken.Name = "gbChicken"
        Me.gbChicken.Size = New System.Drawing.Size(210, 187)
        Me.gbChicken.TabIndex = 18
        Me.gbChicken.TabStop = False
        Me.gbChicken.Text = "Cake"
        '
        'btnChicken
        '
        Me.btnChicken.BackColor = System.Drawing.Color.Gray
        Me.btnChicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChicken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChicken.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChicken.Image = Global.CodilloComprog.My.Resources.Resources.cake
        Me.btnChicken.Location = New System.Drawing.Point(25, 19)
        Me.btnChicken.Name = "btnChicken"
        Me.btnChicken.Size = New System.Drawing.Size(163, 146)
        Me.btnChicken.TabIndex = 0
        Me.btnChicken.Text = " "
        Me.btnChicken.UseVisualStyleBackColor = False
        '
        'DessertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CodilloComprog.My.Resources.Resources.backgrouunddessert
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPasta)
        Me.Controls.Add(Me.gbChicken)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DessertForm"
        Me.Text = "DessertForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbPasta.ResumeLayout(False)
        Me.gbChicken.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVeggies As Button
    Friend WithEvents gbPasta As GroupBox
    Friend WithEvents btnPasta As Button
    Friend WithEvents gbChicken As GroupBox
    Friend WithEvents btnChicken As Button
End Class
