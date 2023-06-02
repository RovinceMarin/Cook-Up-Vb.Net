Public Class PorkForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim foodfrm As New FoodsForm
        foodfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(foodfrm)
        foodfrm.Dock = DockStyle.Fill
        foodfrm.Show()
    End Sub

    Private Sub btnjapan_Click(sender As Object, e As EventArgs) Handles btnjapan.Click
        Form1.pnlFill.Controls.Clear()
        Dim japork As New JapanesePork
        japork.TopLevel = False
        Form1.pnlFill.Controls.Add(japork)
        japork.Dock = DockStyle.Fill
        japork.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.pnlFill.Controls.Clear()
        Dim korpork As New KoreanPork
        korpork.TopLevel = False
        Form1.pnlFill.Controls.Add(korpork)
        korpork.Dock = DockStyle.Fill
        korpork.Show()
    End Sub

    Private Sub btnfilipino_Click(sender As Object, e As EventArgs) Handles btnfilipino.Click
        Form1.pnlFill.Controls.Clear()
        Dim Filpork As New FilipinoPork
        Filpork.TopLevel = False
        Form1.pnlFill.Controls.Add(Filpork)
        Filpork.Dock = DockStyle.Fill
        Filpork.Show()
    End Sub

    Private Sub btnmiddle_Click(sender As Object, e As EventArgs) Handles btnmiddle.Click
        Form1.pnlFill.Controls.Clear()
        Dim Midpork As New MiddlePork
        Midpork.TopLevel = False
        Form1.pnlFill.Controls.Add(Midpork)
        Midpork.Dock = DockStyle.Fill
        Midpork.Show()
    End Sub

    Private Sub btnthai_Click(sender As Object, e As EventArgs) Handles btnthai.Click
        Form1.pnlFill.Controls.Clear()
        Dim Thapork As New ThaiPork
        Thapork.TopLevel = False
        Form1.pnlFill.Controls.Add(Thapork)
        Thapork.Dock = DockStyle.Fill
        Thapork.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.pnlFill.Controls.Clear()
        Dim Itapork As New ItalianPork
        Itapork.TopLevel = False
        Form1.pnlFill.Controls.Add(Itapork)
        Itapork.Dock = DockStyle.Fill
        Itapork.Show()
    End Sub
End Class