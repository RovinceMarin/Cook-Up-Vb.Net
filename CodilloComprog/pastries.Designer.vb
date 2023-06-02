<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pastries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pastries))
        Me.gbPAstry = New System.Windows.Forms.GroupBox()
        Me.btnbrownies = New System.Windows.Forms.Button()
        Me.gpPass = New System.Windows.Forms.GroupBox()
        Me.btncookies = New System.Windows.Forms.Button()
        Me.gbpas = New System.Windows.Forms.GroupBox()
        Me.btncaramelbars = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbPAstry.SuspendLayout()
        Me.gpPass.SuspendLayout()
        Me.gbpas.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPAstry
        '
        Me.gbPAstry.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbPAstry.Controls.Add(Me.btnbrownies)
        Me.gbPAstry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbPAstry.Location = New System.Drawing.Point(646, 193)
        Me.gbPAstry.Name = "gbPAstry"
        Me.gbPAstry.Size = New System.Drawing.Size(210, 187)
        Me.gbPAstry.TabIndex = 38
        Me.gbPAstry.TabStop = False
        Me.gbPAstry.Text = "brownies"
        '
        'btnbrownies
        '
        Me.btnbrownies.BackColor = System.Drawing.Color.Gray
        Me.btnbrownies.BackgroundImage = CType(resources.GetObject("btnbrownies.BackgroundImage"), System.Drawing.Image)
        Me.btnbrownies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbrownies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbrownies.Location = New System.Drawing.Point(23, 20)
        Me.btnbrownies.Name = "btnbrownies"
        Me.btnbrownies.Size = New System.Drawing.Size(163, 146)
        Me.btnbrownies.TabIndex = 2
        Me.btnbrownies.UseVisualStyleBackColor = False
        '
        'gpPass
        '
        Me.gpPass.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gpPass.Controls.Add(Me.btncookies)
        Me.gpPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gpPass.Location = New System.Drawing.Point(373, 193)
        Me.gpPass.Name = "gpPass"
        Me.gpPass.Size = New System.Drawing.Size(210, 187)
        Me.gpPass.TabIndex = 37
        Me.gpPass.TabStop = False
        Me.gpPass.Text = "cookies"
        '
        'btncookies
        '
        Me.btncookies.BackColor = System.Drawing.Color.Gray
        Me.btncookies.BackgroundImage = CType(resources.GetObject("btncookies.BackgroundImage"), System.Drawing.Image)
        Me.btncookies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncookies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncookies.Location = New System.Drawing.Point(27, 19)
        Me.btncookies.Name = "btncookies"
        Me.btncookies.Size = New System.Drawing.Size(163, 146)
        Me.btncookies.TabIndex = 1
        Me.btncookies.UseVisualStyleBackColor = False
        '
        'gbpas
        '
        Me.gbpas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbpas.Controls.Add(Me.btncaramelbars)
        Me.gbpas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gbpas.Location = New System.Drawing.Point(87, 193)
        Me.gbpas.Name = "gbpas"
        Me.gbpas.Size = New System.Drawing.Size(210, 187)
        Me.gbpas.TabIndex = 36
        Me.gbpas.TabStop = False
        Me.gbpas.Text = "caramel bars"
        '
        'btncaramelbars
        '
        Me.btncaramelbars.BackColor = System.Drawing.Color.Gray
        Me.btncaramelbars.BackgroundImage = CType(resources.GetObject("btncaramelbars.BackgroundImage"), System.Drawing.Image)
        Me.btncaramelbars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncaramelbars.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncaramelbars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncaramelbars.Location = New System.Drawing.Point(25, 19)
        Me.btncaramelbars.Name = "btncaramelbars"
        Me.btncaramelbars.Size = New System.Drawing.Size(163, 146)
        Me.btncaramelbars.TabIndex = 0
        Me.btncaramelbars.Text = " "
        Me.btncaramelbars.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btncaramelbars.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnBack.Location = New System.Drawing.Point(863, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 40)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'pastries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 630)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbPAstry)
        Me.Controls.Add(Me.gpPass)
        Me.Controls.Add(Me.gbpas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pastries"
        Me.Text = "pastries"
        Me.gbPAstry.ResumeLayout(False)
        Me.gpPass.ResumeLayout(False)
        Me.gbpas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbPAstry As GroupBox
    Friend WithEvents btnbrownies As Button
    Friend WithEvents gpPass As GroupBox
    Friend WithEvents btncookies As Button
    Friend WithEvents gbpas As GroupBox
    Friend WithEvents btncaramelbars As Button
    Friend WithEvents btnBack As Button
End Class
