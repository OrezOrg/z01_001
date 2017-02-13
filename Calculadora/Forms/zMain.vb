Public Class zMain
    Public zTitle As String = Me.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Eres un rebelde, me agradas...")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("A mi ni me mires, no dije que hicieras nada...")
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.Text = zTitle & " Wolas"
        Else
            Me.Text = zTitle
        End If
    End Sub
End Class
