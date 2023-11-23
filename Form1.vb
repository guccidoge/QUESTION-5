Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim decInput As String = TextBox1.Text

        If IsNumeric(decInput) = True And decInput >= 0 Then
            If Int(decInput) = CDec(decInput) Then
                MsgBox("Please enter a number with DECIMAL point!")
                TextBox1.Text = " "
            Else
                Dim firstDec As String = TextBox1.Text.IndexOf(".")
                Dim startPos = InStrRev(decInput, ".")
                Dim subString = decInput.ToString.Substring(startPos)
                Dim len = subString.Length

                Label1.Text = firstDec
                Label2.Text = len
            End If
        Else
            MsgBox("Please enter a POSITIVE NUMBER!")
        End If
    End Sub
End Class