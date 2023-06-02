Imports System.IO
Public Class JapanesePork
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim porkfrm As New PorkForm
        porkfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(porkfrm)
        porkfrm.Dock = DockStyle.Fill
        porkfrm.Show()
    End Sub

    Private Sub btnshoga_Click(sender As Object, e As EventArgs) Handles btnshoga.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.shogayaki
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btntonka_Click(sender As Object, e As EventArgs) Handles btntonka.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.tonkatsu
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnbuta_Click(sender As Object, e As EventArgs) Handles btnbuta.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.butamaki
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btngyo_Click(sender As Object, e As EventArgs) Handles btngyo.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.gyoza
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnyaki_Click(sender As Object, e As EventArgs) Handles btnyaki.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.yakiton
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnkaku_Click(sender As Object, e As EventArgs) Handles btnkaku.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.kakuni
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub
End Class