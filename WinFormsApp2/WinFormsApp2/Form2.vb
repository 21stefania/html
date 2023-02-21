Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "stefania" And TextBox2.Text = 123 Then
            Form1.Show()
        Else
            MsgBox("Usuario o clave incorrecto")

        End If

    End Sub
End Class