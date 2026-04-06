Module Validasi
    Public Sub CumaAngka(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub CumaHuruf(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(txt As TextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            MessageBox.Show(pesan, "Input kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiHP(mtb As MaskedTextBox, err As ErrorProvider) As Boolean
        If Not mtb.MaskFull Then
            err.SetError(mtb, "Nomor HP harus diisi lengkap!")
            Return False
        Else
            err.SetError(mtb, "") ' 
            Return True
        End If
    End Function

    Public Function CekKosong(input As Object, namaField As String) As Boolean
        Dim kosong As Boolean = False
        If TypeOf input Is TextBox Then
            If String.IsNullOrWhiteSpace(DirectCast(input, TextBox).Text) Then kosong = True
        ElseIf TypeOf input Is ComboBox Then
            If DirectCast(input, ComboBox).SelectedIndex = -1 Then kosong = True
        End If

        If kosong Then
            MessageBox.Show("Inputan tidak boleh kosong (" & namaField & ")", "Rhodes Island Terminal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
End Module