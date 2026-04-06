Imports System.IO

Public Class Form1
    Dim daftarHobi() As CheckBox
    Dim daftarJK() As RadioButton

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daftarHobi = {c1, c2, c3, c4, c5, c6, c7, c8, c9}
        daftarJK = {cowo, cewe}
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
    End Sub

    Private Function IsDataValid() As Boolean
        ErrorProvider1.Clear()
        If Not CekKosong(TxtNm, "Nama") Then Return False
        If Not CekKosong(TxtId, "ID/Umur") Then Return False
        If Not CekKosong(Txtalmt, "Alamat") Then Return False
        If Not CekKosong(cbDivisi, "Divisi") Then Return False
        If Not CekKosong(TxtEmail, "Email") Then Return False
        If Not ValidasiHP(Txthp, ErrorProvider1) Then
            MessageBox.Show("Format Nomor HP belum lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If GetSelectedRadioButton(daftarJK) = "" Then
            MessageBox.Show("Pilih jenis kelamin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrEmpty(GetSelectedCheckBox(daftarHobi)) Then
            MessageBox.Show("Pilih minimal satu hobi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If gambar.Image Is Nothing Then
            MessageBox.Show("Foto Operator wajib diunggah!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If ValidasiTextBox(TxtNm, "Nama Tidak Boleh Kosong") Then
            Dim NamaFile As String = TxtNm.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.Copy(openFileDialog.FileName, destinationPath, True)
                Module1.Gambar = destinationPath
                gambar.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil dimuat", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If IsDataValid() Then
            Module1.Nama = TxtNm.Text
            Module1.Id = TxtId.Text
            Module1.Hp = Txthp.Text
            Module1.Almt = Txtalmt.Text
            Module1.Email = TxtEmail.Text
            Module1.JK = GetSelectedRadioButton(daftarJK)
            Module1.Hobi = GetSelectedCheckBox(daftarHobi)
            Module1.Tgl = Tgll.Value
            Module1.Divisi = cbDivisi.Text

            If MessageBox.Show("Konfirmasi cetak kartu identitas?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Form2.Show()
            End If
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If IsDataValid() Then
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "Text File|*.txt"
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim data As String = $"NAMA: {TxtNm.Text}; ID: {TxtId.Text}; DIVISI: {cbDivisi.Text}; HP: {Txthp.Text}; EMAIL: {TxtEmail.Text}"
                File.WriteAllText(sfd.FileName, data)
                MessageBox.Show("Data berhasil disimpan", "info")
            End If
        End If
    End Sub
    Private Sub TxtNm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNm.KeyPress
        Validasi.CumaHuruf(sender, e)
    End Sub

    Private Sub TxtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtId.KeyPress
        Validasi.CumaAngka(sender, e)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Ingin keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim opn As New OpenFileDialog
        opn.Filter = "Text File|*.txt"
        opn.Title = "Buka Data"

        If opn.ShowDialog = DialogResult.OK Then
            Try
                Dim isiFile As String = File.ReadAllText(opn.FileName)
                Dim data() As String = isiFile.Split(";"c)
                If data.Length >= 5 Then
                    TxtNm.Text = data(0).Replace("NAMA: ", "").Trim()
                    TxtId.Text = data(1).Replace("ID: ", "").Trim()
                    cbDivisi.Text = data(2).Replace("DIVISI: ", "").Trim()
                    Txthp.Text = data(3).Replace("HP: ", "").Trim()
                    TxtEmail.Text = data(4).Replace("EMAIL: ", "").Trim()



                    MessageBox.Show("Data berhasil dimuat", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Format file tidak diketahui", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal membuka file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class