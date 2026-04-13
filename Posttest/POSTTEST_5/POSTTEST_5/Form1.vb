Imports WMPLib

Public Class Form1
    Dim musik As New WMPLib.WindowsMediaPlayer
    Private Sub Kosong()
        TxtKode.Clear()
        TxtNama.Clear()
        TxtTahun.Clear()
        TxtLokasi.Clear()
        TxtCari.Clear()
        ErrorProvider1.Clear()
        TxtKode.Focus()
    End Sub
    Private Sub TampilData()
        dgvAnimus.DataSource = GetAllJenis()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()

        Try
            musik.URL = Application.StartupPath & "\Animus.mp3"
            musik.settings.setMode("loop", True)
            musik.settings.volume = 50
            musik.controls.play()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ErrorProvider1.Clear()
        If Not Validasiinput(ErrorProvider1, TxtKode, TxtNama, TxtLokasi, TxtTahun) Then Exit Sub

        Dim kode As String = TxtKode.Text.Trim()
        Dim nama As String = TxtNama.Text.Trim()
        Dim tahun As String = TxtTahun.Text.Trim()
        Dim lokasi As String = TxtLokasi.Text.Trim()


        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Animus sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanJenis(kode, nama, tahun, lokasi) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

        ErrorProvider1.Clear()
        If Not Validasiinput(ErrorProvider1, TxtKode, TxtNama, TxtLokasi, TxtTahun) Then Exit Sub

        Dim kode As String = TxtKode.Text.Trim()
        Dim namaKarakter As String = TxtNama.Text.Trim()
        Dim tahun As String = TxtTahun.Text.Trim()
        Dim lokasi As String = TxtLokasi.Text.Trim()

        If UbahJenis(kode, namaKarakter, tahun, lokasi) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If TxtKode.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus",
            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            TxtKode.Focus()
            Exit Sub
        End If
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?",
        "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusJenis(TxtKode.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Kosong()
        TampilData()
    End Sub
    Private Sub dgvAnimus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimus.CellClick
        If e.RowIndex >= 0 Then
            TxtKode.Text = dgvAnimus.Rows(e.RowIndex).Cells("AnimusKode").Value.ToString()
            TxtNama.Text = dgvAnimus.Rows(e.RowIndex).Cells("NamaKarakter").Value.ToString()
            TxtTahun.Text = dgvAnimus.Rows(e.RowIndex).Cells("Tahun").Value.ToString()
            TxtLokasi.Text = dgvAnimus.Rows(e.RowIndex).Cells("Lokasi").Value.ToString()
        End If
    End Sub
    Private Sub txtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetJenisByKode(TxtKode.Text.Trim())
            If dt.Rows.Count > 0 Then
                TxtNama.Text = dt.Rows(0)("NamaKarakter").ToString()
                TxtTahun.Text = dt.Rows(0)("Tahun").ToString()
                TxtLokasi.Text = dt.Rows(0)("Lokasi").ToString()
            Else
                TxtNama.Clear() : TxtTahun.Clear() : TxtLokasi.Clear()
            End If
            TxtNama.Focus()
        End If
    End Sub
    Private Sub txtJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress

        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            BtnSimpan.Focus()
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        If TxtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvAnimus.DataSource = SearchJenis(TxtCari.Text.Trim())
        End If
    End Sub

    Private Sub TxtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahun.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            TxtLokasi.Focus()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer2_Enter(sender As Object, e As EventArgs)

    End Sub
End Class