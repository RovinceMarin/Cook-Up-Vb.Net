Public Class pdfviewer
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Form1.btnback.Visible = True
        If Form1.pnlFill.Controls.Contains(Me) <> True Then
            Form1.btnback.Visible = True
        End If
    End Sub
End Class