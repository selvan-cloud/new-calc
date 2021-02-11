Public Class Form1
    Public sum As Integer

    Private Sub textbox1_TextChanged(sender As Object, e As EventArgs) Handles textbox1.TextChanged
        If textbox1.Text = "" Or
               IsNumeric(textbox1.Text) = False Then
            MessageBox.Show("Please enter a numeric value")
        End If
    End Sub

    Private Sub textbox2_TextChanged(sender As Object, e As EventArgs) Handles textbox2.TextChanged
        If textbox2.Text = "" Or
               IsNumeric(textbox2.Text) = False Then
            MessageBox.Show("Please enter the numeric value")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sum = Val(textbox1.Text) + Val(textbox2.Text)
        MessageBox.Show("The sum is:" & sum)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sum = Val(textbox1.Text) - Val(textbox2.Text)
        MessageBox.Show("The sum is:" & sum)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sum = Val(textbox1.Text) * Val(textbox2.Text)
        MessageBox.Show("The sum is:" & sum)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sum = Val(textbox1.Text) / Val(textbox2.Text)
        MessageBox.Show("The sum is:" & sum)
    End Sub
End Class
