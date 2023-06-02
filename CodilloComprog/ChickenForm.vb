Public Class ChickenForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim foodfrm As New FoodsForm
        foodfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(foodfrm)
        foodfrm.Dock = DockStyle.Fill
        foodfrm.Show()
    End Sub

    Private Sub ChickenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnjapan_Click(sender As Object, e As EventArgs) Handles btnjapan.Click
        Form1.pnlFill.Controls.Clear()
        Dim japchick As New JapaneseChicken
        japchick.TopLevel = False
        Form1.pnlFill.Controls.Add(japchick)
        japchick.Dock = DockStyle.Fill
        japchick.Show()
    End Sub

    Private Sub btnfilipino_Click(sender As Object, e As EventArgs) Handles btnfilipino.Click
        Form1.pnlFill.Controls.Clear()
        Dim filchick As New FilipinoChicken
        filchick.TopLevel = False
        Form1.pnlFill.Controls.Add(filchick)
        filchick.Dock = DockStyle.Fill
        filchick.Show()
    End Sub

    Private Sub btnmiddle_Click(sender As Object, e As EventArgs) Handles btnmiddle.Click
        Form1.pnlFill.Controls.Clear()
        Dim midchick As New MiddleChicken
        midchick.TopLevel = False
        Form1.pnlFill.Controls.Add(midchick)
        midchick.Dock = DockStyle.Fill
        midchick.Show()
    End Sub

    Private Sub btnthai_Click(sender As Object, e As EventArgs) Handles btnthai.Click
        Form1.pnlFill.Controls.Clear()
        Dim thaichick As New ThaiChicken
        thaichick.TopLevel = False
        Form1.pnlFill.Controls.Add(thaichick)
        thaichick.Dock = DockStyle.Fill
        thaichick.Show()
    End Sub

    Private Sub btnitalian_Click(sender As Object, e As EventArgs) Handles btnitalian.Click
        Form1.pnlFill.Controls.Clear()
        Dim itachick As New ItalianChicken
        itachick.TopLevel = False
        Form1.pnlFill.Controls.Add(itachick)
        itachick.Dock = DockStyle.Fill
        itachick.Show()
    End Sub

    Private Sub gbitalianAmerica_Enter(sender As Object, e As EventArgs) Handles gbitalianAmerica.Enter

    End Sub
End Class