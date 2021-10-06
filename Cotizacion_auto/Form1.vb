Public Class Form1

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If Val(TextBox1.Text) = "figo" Then
            TextBox7.Text = "$220,900"
        ElseIf Val(TextBox1.Text)  Val(TextBox2.Text) Then
            TextBox3.Text = "El segundo valor es mayor que el segundo"
        ElseIf Val(TextBox1.Text) = Val(TextBox2.Text) Then
            TextBox3.Text = "Ambos tienen el mismo valor"
        End If
    End Sub
    If 
End Class
