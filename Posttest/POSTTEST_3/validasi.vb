Module validasi
    Public Sub cumaangka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub cumahuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiPictureBox(pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            MessageBox.Show(pesan, "Gambar Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiTextBox(txt As TextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            MessageBox.Show(pesan, "Input kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiCheckBox(grupCheckBox() As CheckBox, pesan As String) As Boolean
        For Each cb As CheckBox In grupCheckBox
            If cb.Checked Then
                Return True
            End If
        Next
        MessageBox.Show(pesan, "Pilihan Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Public Function ValidasiRadioButton(grupRadio() As RadioButton, pesan As String) As Boolean
        For Each rb As RadioButton In grupRadio
            If rb.Checked Then
                Return True
            End If
        Next
        MessageBox.Show(pesan, "Pilihan kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

End Module