Imports System.IO
Public Class MiddleChicken
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

    Private Sub gbMiddle_Enter(sender As Object, e As EventArgs) Handles gbMiddle.Enter

    End Sub

    Private Sub gbFilipino_Enter(sender As Object, e As EventArgs) Handles gbFilipino.Enter

    End Sub

    Private Sub btnitalian_Click(sender As Object, e As EventArgs) Handles btnfatteh.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.fatteh
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub gbThai_Enter(sender As Object, e As EventArgs) Handles gbThai.Enter

    End Sub

    Private Sub gbitalianAmerica_Enter(sender As Object, e As EventArgs) Handles gbitalianAmerica.Enter

    End Sub

    Private Sub btnmandi_Click(sender As Object, e As EventArgs) Handles btnmandi.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.mandi
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnkebab_Click(sender As Object, e As EventArgs) Handles btnkebab.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.kebab
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnmansaf_Click(sender As Object, e As EventArgs) Handles btnmansaf.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.mansaf
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub

    Private Sub btnshawarma_Click(sender As Object, e As EventArgs) Handles btnshawarma.Click
        Form1.pnlFill.Controls.Clear()

        Dim pdfBytes() As Byte = My.Resources.shawarma
        Dim tempFilePath As String = Path.GetTempFileName() & ".pdf"

        File.WriteAllBytes(tempFilePath, pdfBytes)

        Dim pdfviewer As New pdfviewer
        pdfviewer.WebBrowser1.Navigate(tempFilePath)
        Form1.pnlFill.Controls.Add(pdfviewer.WebBrowser1)
    End Sub
End Class