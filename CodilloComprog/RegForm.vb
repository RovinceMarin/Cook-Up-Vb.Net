Public Class RegForm

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        If Txtreguname.Text = String.Empty Then
            MessageBox.Show("Enter Username!")
        ElseIf Txtregpword.Text = String.Empty Then
            MessageBox.Show("Enter Password!")
        ElseIf Txtregconpword.Text <> Txtregpword.Text Then
            MessageBox.Show("Please Re-Confirm Password!")
        Else
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chbox.CheckedChanged
        If Chbox.Checked = False Then
            btnreg.Enabled = False
        Else
            btnreg.Enabled = True
        End If

        'btnreg.Enabled
    End Sub

    Private Sub Txtreguname_Click(sender As Object, e As EventArgs) Handles Txtreguname.Click
        Txtreguname.Clear()
    End Sub

    Private Sub Txtregpword_Click(sender As Object, e As EventArgs) Handles Txtregpword.Click
        Txtregpword.Clear()
    End Sub

    Private Sub Txtregconpword_Click(sender As Object, e As EventArgs) Handles Txtregconpword.Click
        Txtregconpword.Clear()
    End Sub
End Class