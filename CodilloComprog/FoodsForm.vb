Public Class FoodsForm
    Private Sub btnChicken_Click(sender As Object, e As EventArgs) Handles btnChicken.Click
        Form1.pnlFill.Controls.Clear()
        Dim form3 As New ChickenForm()
        form3.TopLevel = False
        Form1.pnlFill.Controls.Add(form3)
        form3.Visible = True
        form3.Show()
    End Sub

    Private Sub btnPasta_Click(sender As Object, e As EventArgs) Handles btnPasta.Click
        Form1.pnlFill.Controls.Clear()
        Dim pastafrm As New PastaForm
        pastafrm.TopLevel = False
        Form1.pnlFill.Controls.Add(pastafrm)
        pastafrm.Dock = DockStyle.Fill
        pastafrm.Show()
    End Sub

    Private Sub btnVeggies_Click(sender As Object, e As EventArgs) Handles btnVeggies.Click
        Form1.pnlFill.Controls.Clear()
        Dim vegfrm As New VeggiesForm
        vegfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(vegfrm)
        vegfrm.Dock = DockStyle.Fill
        vegfrm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPork.Click
        Form1.pnlFill.Controls.Clear()
        Dim porkfrm As New PorkForm
        porkfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(porkfrm)
        porkfrm.Dock = DockStyle.Fill
        porkfrm.Show()
    End Sub

    Private Sub btnBeef_Click(sender As Object, e As EventArgs) Handles btnBeef.Click
        Form1.pnlFill.Controls.Clear()
        Dim beeffrm As New BeefForm
        beeffrm.TopLevel = False
        Form1.pnlFill.Controls.Add(beeffrm)
        beeffrm.Dock = DockStyle.Fill
        beeffrm.Show()
    End Sub

    Private Sub btnOthers_Click(sender As Object, e As EventArgs) Handles btnOthers.Click
        MessageBox.Show("Coming Soon!!!")
    End Sub
End Class