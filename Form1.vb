Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim decOne As Decimal

        'InputBox("insert a number with a decimal point")
        'TextBox1.Text = decOne

        'If decOne = " " Then
        'MessageBox.Show("INSERT A DECIMAL")
        'End If

        'Dim decOne As Decimal

        'Decimal.TryParse(TextBox1.Text, decOne)

        'If Double.TryParse(TextBox1.Text, decOne) Then
        'TextBox2.Text = decOne.ToString()
        'Else MessageBox.Show("Please enter a valid number")
        'TextBox1.Text = " "
        'End If

        Dim output As Integer
        If (Integer.TryParse(TextBox1.Text, output)) Then
            MsgBox("Please enter a number with decimal point")
        Else
            TextBox2.Text = TextBox1.Text.IndexOf(".")
        End If


    End Sub


End Class
