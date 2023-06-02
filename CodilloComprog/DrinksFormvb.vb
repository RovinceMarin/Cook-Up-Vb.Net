Public Class DrinksFormvb
    Private Sub btnSmoothies_Click(sender As Object, e As EventArgs) Handles btnSmoothies.Click
        Form1.pnlFill.Controls.Clear()
        Dim smooth As New smoothies
        smooth.TopLevel = False
        Form1.pnlFill.Controls.Add(smooth)
        smooth.Dock = DockStyle.Fill
        smooth.Show()
    End Sub

    Private Sub btnOthers_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Coming Soon!!!")
    End Sub

    Private Sub btnCock_Click(sender As Object, e As EventArgs) Handles btnCock.Click
        Form1.pnlFill.Controls.Clear()
        Dim cock As New cocktail
        cock.TopLevel = False
        Form1.pnlFill.Controls.Add(cock)
        cock.Dock = DockStyle.Fill
        cock.Show()
    End Sub

    Private Sub btnJuice_Click(sender As Object, e As EventArgs) Handles btnJuice.Click
        Form1.pnlFill.Controls.Clear()
        Dim jui As New Juice
        jui.TopLevel = False
        Form1.pnlFill.Controls.Add(jui)
        jui.Dock = DockStyle.Fill
        jui.Show()
    End Sub
End Class