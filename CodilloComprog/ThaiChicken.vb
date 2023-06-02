Imports System.IO
Public Class ThaiChicken
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.pnlFill.Controls.Clear()
        Dim chickfrm As New ChickenForm
        chickfrm.TopLevel = False
        Form1.pnlFill.Controls.Add(chickfrm)
        chickfrm.Dock = DockStyle.Fill
        chickfrm.Show()
    End Sub

    Private Sub gbJapan_Enter(sender As Object, e As EventArgs) Handles gbJapan.Enter

    End Sub

    Private Sub gbFilipino_Enter(sender As Object, e As EventArgs) Handles gbFilipino.Enter

    End Sub

    Private Sub gbThai_Enter(sender As Object, e As EventArgs) Handles gbThai.Enter

    End Sub

    Private Sub btncurry_Click(sender As Object, e As EventArgs) Handles btncurry.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.curry__1_
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnpadthai_Click(sender As Object, e As EventArgs) Handles btnpadthai.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.pad_thai
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnsatay_Click(sender As Object, e As EventArgs) Handles btnsatay.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.satay
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btntomyum_Click(sender As Object, e As EventArgs) Handles btntomyum.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.tom_yum
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnkhagai_Click(sender As Object, e As EventArgs) Handles btnkhagai.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.tom_kha_gai
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub
End Class