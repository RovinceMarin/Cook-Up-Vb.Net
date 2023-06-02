Imports System.IO
Public Class PastaForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim foodfrm As New FoodsForm
        foodfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(foodfrm)
        foodfrm.Dock = DockStyle.Fill
        foodfrm.Show()
    End Sub

    Private Sub btnbamac_Click(sender As Object, e As EventArgs) Handles btnbamac.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.baked_mac__1_
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btncarb_Click(sender As Object, e As EventArgs) Handles btncarb.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.carbonara
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnlas_Click(sender As Object, e As EventArgs) Handles btnlas.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.lasagna
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnmacsal_Click(sender As Object, e As EventArgs) Handles btnmacsal.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.macaroni_salad
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnspag_Click(sender As Object, e As EventArgs) Handles btnspag.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.spag
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btntuna_Click(sender As Object, e As EventArgs) Handles btntuna.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.tuna_pasta
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)

    End Sub
End Class