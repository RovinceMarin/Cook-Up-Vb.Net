<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DrinksFormvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrinksFormvb))
        Me.gbPork = New System.Windows.Forms.GroupBox()
        Me.gbPasta = New System.Windows.Forms.GroupBox()
        Me.gbBeef = New System.Windows.Forms.GroupBox()
        Me.btnCock = New System.Windows.Forms.Button()
        Me.btnSmoothies = New System.Windows.Forms.Button()
        Me.btnJuice = New System.Windows.Forms.Button()
        Me.gbPork.SuspendLayout()
        Me.gbPasta.SuspendLayout()
        Me.gbBeef.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPork
        '
        Me.gbPork.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPork.Controls.Add(Me.btnCock)
        Me.gbPork.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbPork.Location = New System.Drawing.Point(91, 228)
        Me.gbPork.Name = "gbPork"
        Me.gbPork.Size = New System.Drawing.Size(210, 187)
        Me.gbPork.TabIndex = 15
        Me.gbPork.TabStop = False
        Me.gbPork.Text = "CockTail"
        '
        'gbPasta
        '
        Me.gbPasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPasta.Controls.Add(Me.btnSmoothies)
        Me.gbPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbPasta.Location = New System.Drawing.Point(377, 228)
        Me.gbPasta.Name = "gbPasta"
        Me.gbPasta.Size = New System.Drawing.Size(210, 187)
        Me.gbPasta.TabIndex = 13
        Me.gbPasta.TabStop = False
        Me.gbPasta.Text = "Smoothies"
        '
        'gbBeef
        '
        Me.gbBeef.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbBeef.Controls.Add(Me.btnJuice)
        Me.gbBeef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbBeef.Location = New System.Drawing.Point(650, 228)
        Me.gbBeef.Name = "gbBeef"
        Me.gbBeef.Size = New System.Drawing.Size(210, 187)
        Me.gbBeef.TabIndex = 16
        Me.gbBeef.TabStop = False
        Me.gbBeef.Text = "Juice"
        '
        'btnCock
        '
        Me.btnCock.BackColor = System.Drawing.Color.Gray
        Me.btnCock.BackgroundImage = CType(resources.GetObject("btnCock.BackgroundImage"), System.Drawing.Image)
        Me.btnCock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCock.Location = New System.Drawing.Point(25, 19)
        Me.btnCock.Name = "btnCock"
        Me.btnCock.Size = New System.Drawing.Size(163, 146)
        Me.btnCock.TabIndex = 3
        Me.btnCock.UseVisualStyleBackColor = False
        '
        'btnSmoothies
        '
        Me.btnSmoothies.BackColor = System.Drawing.Color.Gray
        Me.btnSmoothies.BackgroundImage = CType(resources.GetObject("btnSmoothies.BackgroundImage"), System.Drawing.Image)
        Me.btnSmoothies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSmoothies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSmoothies.Location = New System.Drawing.Point(27, 19)
        Me.btnSmoothies.Name = "btnSmoothies"
        Me.btnSmoothies.Size = New System.Drawing.Size(163, 146)
        Me.btnSmoothies.TabIndex = 1
        Me.btnSmoothies.UseVisualStyleBackColor = False
        '
        'btnJuice
        '
        Me.btnJuice.BackColor = System.Drawing.Color.Gray
        Me.btnJuice.BackgroundImage = CType(resources.GetObject("btnJuice.BackgroundImage"), System.Drawing.Image)
        Me.btnJuice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJuice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJuice.Location = New System.Drawing.Point(27, 20)
        Me.btnJuice.Name = "btnJuice"
        Me.btnJuice.Size = New System.Drawing.Size(163, 146)
        Me.btnJuice.TabIndex = 4
        Me.btnJuice.UseVisualStyleBackColor = False
        '
        'DrinksFormvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.gbPork)
        Me.Controls.Add(Me.gbPasta)
        Me.Controls.Add(Me.gbBeef)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DrinksFormvb"
        Me.Text = "DrinksFormvb"
        Me.gbPork.ResumeLayout(False)
        Me.gbPasta.ResumeLayout(False)
        Me.gbBeef.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbPork As GroupBox
    Friend WithEvents btnCock As Button
    Friend WithEvents gbPasta As GroupBox
    Friend WithEvents btnSmoothies As Button
    Friend WithEvents gbBeef As GroupBox
    Friend WithEvents btnJuice As Button
End Class
