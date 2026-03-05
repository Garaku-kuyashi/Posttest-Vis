Public Class Form1
    Dim ipTotal As Double
    Dim semester As Integer
    Dim ipSemester As Double
    Dim ipRata As Double

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        If Double.TryParse(IpMu.Text, ipSemester) Then
            If ipSemester > 4 Or ipSemester < 0 Then
                MessageBox.Show("yang bener dong dari negara mana kamu")
            Else
                ipTotal += ipSemester
                semester += 1
                ipRata = ipTotal / semester
                IpHasil.Text = ipRata.ToString("0.00")
                If ipRata >= 3.01 Then
                    Hasil.Text = "Hell yah GG"
                ElseIf ipRata >= 2.76 And ipRata <= 3.0 Then
                    Hasil.Text = "bolehlah"
                ElseIf ipRata >= 2.0 And ipRata <= 2.75 Then
                    Hasil.Text = "ah aman ini mah"
                ElseIf ipRata <= 1.99 Then
                    Hasil.Text = "nah you're cooked"
                End If

            End If
        Else
            MessageBox.Show("Masukkan IP Semester yang valid.")
        End If
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
		ipRata = 0
		ipTotal = 0
		semester = 0
		IpHasil.Text = ""
        Hasil.Text = ""
    End Sub
End Class
