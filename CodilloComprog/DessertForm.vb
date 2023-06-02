Public Class DessertForm
    Private Sub gbChicken_Enter(sender As Object, e As EventArgs) Handles gbChicken.Enter

    End Sub

    Private Sub DessertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPasta_Click(sender As Object, e As EventArgs) Handles btnPasta.Click
        Form1.pnlFill.Controls.Clear()
        Dim iC As New Ice_Cream
        iC.TopLevel = False
        Form1.pnlFill.Controls.Add(iC)
        iC.Dock = DockStyle.Fill
        iC.Show()
    End Sub

    Private Sub btnChicken_Click(sender As Object, e As EventArgs) Handles btnChicken.Click
        Form1.pnlFill.Controls.Clear()
        Dim C As New Cake
        C.TopLevel = False
        Form1.pnlFill.Controls.Add(C)
        C.Dock = DockStyle.Fill
        C.Show()
    End Sub

    Private Sub btnVeggies_Click(sender As Object, e As EventArgs) Handles btnVeggies.Click
        Form1.pnlFill.Controls.Clear()
        Dim p As New pastries
        p.TopLevel = False
        Form1.pnlFill.Controls.Add(p)
        p.Dock = DockStyle.Fill
        p.Show()
    End Sub
End Class