Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then

            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)



            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function
    Public Function Validasiinput(ep As ErrorProvider,
    txtKodeJenis As TextBox, txtnama As TextBox, txtlokasi As TextBox, txttahun As TextBox) As Boolean

        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKodeJenis, "Kode animus tidak boleh kosong")

        Dim namaValid As Boolean = ValidasiTextBox(ep, txtnama, "Nama karakter tidak boleh kosong")
        Dim lokasiValid As Boolean = ValidasiTextBox(ep, txtlokasi, "Lokasi tidak boleh kosong")
        Dim tahunValid As Boolean = ValidasiTextBox(ep, txttahun, "Tahun tidak boleh kosong")

        Return kodeValid And namaValid And lokasiValid And tahunValid
    End Function
    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiInputComboBox(ep As ErrorProvider, cbNama As ComboBox, cbOrdo As ComboBox) As Boolean
        Dim namaValid As Boolean = ValidasiComboBox(ep, cbNama, "Nama karakter harus dipilih")
        Dim ordoValid As Boolean = ValidasiComboBox(ep, cbOrdo, "Ordo harus dipilih")
        Return namaValid And ordoValid
    End Function

    Public Function ValidasiInputTextBox(ep As ErrorProvider, txtKodeKarakter As TextBox, txtSenjata As TextBox, txtDesk As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKodeKarakter, "Kode karakter tidak boleh kosong")
        Dim senjataValid As Boolean = ValidasiTextBox(ep, txtSenjata, "Senjata tidak boleh kosong")
        Dim deskValid As Boolean = ValidasiTextBox(ep, txtDesk, "Deskripsi tidak boleh kosong")
        Return kodeValid And senjataValid And deskValid
    End Function
End Module


