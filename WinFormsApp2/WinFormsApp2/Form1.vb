Public Class Form1
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim subsidio As Integer
        Dim basico As Integer
        Dim hed As Integer
        Dim hen As Integer
        Dim hedf As Integer
        Dim henf As Integer

        basico = Val(TextBox4.Text) / 30 * (TextBox11.Text)
        TextBox5.Text = basico

        If TextBox5.Text <= 2000000 Then
            subsidio = 117172 / 30 * (TextBox11.Text)
            TextBox7.Text = subsidio

        ElseIf TextBox5.Text > 2000000 Then
            TextBox7.Text = 0


        End If


        hed = (TextBox5.Text) / 240 * (TextBox6.Text) * 1.25
        hen = (TextBox5.Text) / 240 * (TextBox6.Text) * 1.75
        hedf = (TextBox5.Text) / 240 * (TextBox6.Text) * 2.0
        henf = (TextBox5.Text) / 240 * (TextBox6.Text) * 2.5

        TextBox16 = hed + hen + hedf + henf



    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
