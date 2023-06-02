Public Class BeefForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim foodfrm As New FoodsForm
        foodfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(foodfrm)
        foodfrm.Dock = DockStyle.Fill
        foodfrm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnkor.Click
        Form1.pnlFill.Controls.Clear()
        Dim korbeef As New KoreanBeef
        korbeef.TopLevel = False
        Form1.pnlFill.Controls.Add(korbeef)
        korbeef.Dock = DockStyle.Fill
        korbeef.Show()
    End Sub

    Private Sub btnjapan_Click(sender As Object, e As EventArgs) Handles btnjapan.Click
        Form1.pnlFill.Controls.Clear()
        Dim japbeef As New JapaneseBeef
        japbeef.TopLevel = False
        Form1.pnlFill.Controls.Add(japbeef)
        japbeef.Dock = DockStyle.Fill
        japbeef.Show()
    End Sub

    Private Sub btnfilipino_Click(sender As Object, e As EventArgs) Handles btnfilipino.Click
        Form1.pnlFill.Controls.Clear()
        Dim filbeef As New FilipinoBeef
        filbeef.TopLevel = False
        Form1.pnlFill.Controls.Add(filbeef)
        filbeef.Dock = DockStyle.Fill
        filbeef.Show()
    End Sub
End Class