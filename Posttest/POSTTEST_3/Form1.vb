Imports System.IO

Public Class Form1
	Dim hobi() As CheckBox
	Dim jeniskelamin() As RadioButton
	Private Function CekData() As Boolean
		hobi = {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10}
		jeniskelamin = {cowo, cewe}
		If Not ValidasiTextBox(TxtNm, "Nama Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(Txtumr, "Umur Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(Txthp, "Nomor Hp Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(Txtalmt, "Alamat Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(jeniskelamin, "Pilih Jenis Kelamin") Then Return False
        If Not ValidasiCheckBox(hobi, "Pilih Minimal 1 Hobi") Then Return False
		If Not ValidasiPictureBox(gambar, "Gambar Tidak Boleh Kosong") Then Return False
		Return True
	End Function

	Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
		If CekData() Then
			hobi = {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10}
			jeniskelamin = {cowo, cewe}
			Dim Hobi_Selected As String = GetSelectedCheckBox(hobi)
			Dim jk_Selected As String = GetSelectedRadioButton(jeniskelamin)
			Module1.Nama = TxtNm.Text
            Module1.Umur = Txtumr.Text
            Module1.Hp = Txthp.Text
            Module1.Almt = Txtalmt.Text
            Module1.Hobi = Hobi_Selected
			Module1.JK = jk_Selected
			Module1.Tgl = tglL.Value.ToShortDateString()
			Form2.Show()
		End If
	End Sub

	Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnCari.Click
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
	Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNm.KeyPress
		validasi.cumahuruf(sender, e)
	End Sub
	Private Sub Txtumur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtumr.KeyPress
		validasi.cumaangka(sender, e)
	End Sub

	Private Sub Txtno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txthp.KeyPress
		validasi.cumaangka(sender, e)
	End Sub
End Class
