
Public Class Form1


    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlFill.Controls.Clear()
        'pagpapalabas ng form sa panel
        Dim foodfrm As New FoodsForm
        foodfrm.TopLevel = False
        pnlFill.Controls.Add(foodfrm)
        foodfrm.Dock = DockStyle.Fill
        foodfrm.Show()
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlFill.Controls.Clear()
        Dim drinksfrm As New DrinksFormvb
        drinksfrm.TopLevel = False
        pnlFill.Controls.Add(drinksfrm)
        drinksfrm.Dock = DockStyle.Fill
        drinksfrm.Show()
    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        pnlFill.Controls.Clear()
        Dim dessertfrm As New DessertForm
        dessertfrm.TopLevel = False
        pnlFill.Controls.Add(dessertfrm)
        dessertfrm.Dock = DockStyle.Fill
        dessertfrm.Show()
    End Sub

    Private Sub btnMyList_Click(sender As Object, e As EventArgs)
        pnlFill.Controls.Clear()
        Dim listfrm As New MyListForm
        listfrm.TopLevel = False
        pnlFill.Controls.Add(listfrm)
        listfrm.Dock = DockStyle.Fill
        listfrm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub pnlFill_Paint(sender As Object, e As PaintEventArgs) Handles pnlFill.Paint

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlFill.Controls.Clear()
        Dim abtfrm As New AboutForm
        abtfrm.TopLevel = False
        pnlFill.Controls.Add(abtfrm)
        abtfrm.Dock = DockStyle.Fill
        abtfrm.Show()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        pnlFill.Controls.Clear()
        Dim foodfrm As New FoodsForm
        foodfrm.TopLevel = False
        pnlFill.Controls.Add(foodfrm)
        foodfrm.Dock = DockStyle.Fill
        foodfrm.Show()
        btnback.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pnlFill.Controls.Contains(pdfviewer) = True Then
            btnback.Visible = True
        End If
    End Sub
End Class
