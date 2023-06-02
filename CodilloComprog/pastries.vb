Imports System.IO
Public Class pastries
    Private Sub btncaramelbars_Click(sender As Object, e As EventArgs) Handles btncaramelbars.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.caramel_bar
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btncookies_Click(sender As Object, e As EventArgs) Handles btncookies.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.cookies
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnbrownies_Click(sender As Object, e As EventArgs) Handles btnbrownies.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.brownies
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim dessfrm As New DessertForm
        dessfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(dessfrm)
        dessfrm.Dock = DockStyle.Fill
        dessfrm.Show()
    End Sub
End Class