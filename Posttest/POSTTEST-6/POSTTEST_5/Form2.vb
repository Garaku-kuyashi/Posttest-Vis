Public Class Form2
    Private Sub KosongkanTextBox()
        txtKodeKarakter.Clear()
        cbNama.SelectedIndex = -1
        cbNama.Text = ""
        txtSenjata.Clear()
        txtDesk.Clear()
        cbOrdo.SelectedIndex = -1
        cbOrdo.Text = ""
        ErrorProvider1.Clear()
        txtKodeKarakter.Focus()
    End Sub

    Private Sub TampilData()
        dgvDetail.DataSource = DataModule.GetAllChar()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiInputTextBox(ErrorProvider1, txtKodeKarakter, txtSenjata, txtDesk) OrElse
           Not ValidationModule.ValidasiComboBox(ErrorProvider1, cbNama, "Pilih Nama Karakter Terlebih Dahulu") OrElse
           Not ValidationModule.ValidasiComboBox(ErrorProvider1, cbOrdo, "Pilih Ordo Terlebih Dahulu") Then
            Exit Sub
        End If

        Dim kodeKarakter As String = txtKodeKarakter.Text.Trim()
        Dim senjata As String = txtSenjata.Text.Trim()
        Dim ordo As String = cbOrdo.Text
        Dim desk As String = txtDesk.Text.Trim()
        If cbNama.SelectedValue Is Nothing Then
            MessageBox.Show("Nama Karakter tidak valid. Silakan pilih dari daftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim animusKode As String = cbNama.SelectedValue.ToString()

        If DataModule.KodeCharSudahAda(kodeKarakter) Then
            MessageBox.Show("Kode karakter '" & kodeKarakter & "' sudah ada. Gunakan kode lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtKodeKarakter.Focus()
            Exit Sub
        End If

        If DataModule.SimpanChar(kodeKarakter, animusKode, senjata, ordo, desk) Then
            MessageBox.Show("Data Assassin berhasil disimpan ke database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            KosongkanTextBox()
            TampilData()
        Else
            MessageBox.Show("Gagal menyimpan data. Periksa koneksi database Anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidationModule.ValidasiInputTextBox(ErrorProvider1, txtKodeKarakter, txtSenjata, txtDesk) OrElse
           Not ValidationModule.ValidasiInputComboBox(ErrorProvider1, cbNama, cbOrdo) Then
            Exit Sub
        End If

        Dim kode As String = txtKodeKarakter.Text.Trim()
        Dim animusKode As String = cbNama.SelectedValue.ToString()
        Dim senjata As String = txtSenjata.Text.Trim()
        Dim ordo As String = cbOrdo.Text
        Dim deskripsi As String = txtDesk.Text.Trim()

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data karakter ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If DataModule.UbahChar(kode, animusKode, senjata, ordo, deskripsi) Then
                MessageBox.Show("Data karakter berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanTextBox()
            Else
                MessageBox.Show("Gagal memperbarui data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim kode As String = txtKodeKarakter.Text.Trim()

        If String.IsNullOrEmpty(kode) Then
            MessageBox.Show("Silakan pilih data yang ingin dihapus terlebih dahulu melalui tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus karakter dengan kode '" & kode & "'?",
                                                     "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            If DataModule.HapusChar(kode) Then
                MessageBox.Show("Data berhasil dihapus dari sistem.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TampilData()
                KosongkanTextBox()
            Else
                MessageBox.Show("Data gagal dihapus atau kode tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanTextBox()
        TampilData()
    End Sub

    Private Sub dgvDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetail.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDetail.Rows(e.RowIndex)

            txtKodeKarakter.Text = row.Cells("KodeKarakter").Value.ToString()
            cbNama.Text = row.Cells("Nama Karakter").Value.ToString()
            txtSenjata.Text = row.Cells("senjata").Value.ToString()
            cbOrdo.Text = row.Cells("ordo").Value.ToString()
            txtDesk.Text = row.Cells("deskripsi").Value.ToString()
        End If
    End Sub

    Private Sub txtKodeKarakter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeKarakter.KeyPress
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True

            Dim dt As DataTable = DataModule.SearchChar(txtKodeKarakter.Text.Trim())

            If dt.Rows.Count > 0 Then

                cbNama.Text = dt.Rows(0)("Nama Karakter").ToString()
                txtSenjata.Text = dt.Rows(0)("senjata").ToString()
                cbOrdo.Text = dt.Rows(0)("ordo").ToString()
                txtDesk.Text = dt.Rows(0)("deskripsi").ToString()
            Else
                cbNama.SelectedIndex = -1
                txtSenjata.Clear()
                cbOrdo.SelectedIndex = -1
                txtDesk.Clear()
            End If

            cbNama.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvDetail.DataSource = DataModule.SearchChar(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtNama As DataTable = DataModule.GetAllJenis()

        cbNama.DataSource = dtNama
        cbNama.DisplayMember = "NamaKarakter"
        cbNama.ValueMember = "AnimusKode"
        cbNama.SelectedIndex = -1
        TampilData()
    End Sub
End Class