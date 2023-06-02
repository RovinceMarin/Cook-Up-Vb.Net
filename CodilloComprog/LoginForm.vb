Public Class LoginForm
    Private Sub Lblsign_Click(sender As Object, e As EventArgs) Handles Lblsign.Click

    End Sub

    Private Sub Linklblsignin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linklblsignin.LinkClicked
        Me.Hide()
        RegForm.Show()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUname.Text <> RegForm.Txtreguname.Text Then
            MessageBox.Show("Invalid Username!")
        ElseIf TxtPword.Text <> RegForm.Txtregpword.Text Then
            MessageBox.Show("Invalid Password")


        ElseIf TxtUname.Text = String.Empty Then
            MessageBox.Show("Enter Username And Password!")
        ElseIf TxtPword.Text = String.Empty Then
            MessageBox.Show("Enter Username And Password!")
        Else
            Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picexit.Click
        Me.Close()
    End Sub
End Class