Imports System.IO
Public Class KoreanPork
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim porkfrm As New PorkForm
        porkfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(porkfrm)
        porkfrm.Dock = DockStyle.Fill
        porkfrm.Show()
    End Sub

    Private Sub btnbicol_Click(sender As Object, e As EventArgs) Handles btnboss.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.Bossam
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnbulg_Click(sender As Object, e As EventArgs) Handles btnbulg.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.bulgogi
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btndwae_Click(sender As Object, e As EventArgs) Handles btndwae.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.dwaeji_galbi
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnbokk_Click(sender As Object, e As EventArgs) Handles btnbokk.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.jeyuk_bokkeum
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnjok_Click(sender As Object, e As EventArgs) Handles btnjok.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.jokbal
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnsuyu_Click(sender As Object, e As EventArgs) Handles btnsuyu.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.suyuk
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub
End Class