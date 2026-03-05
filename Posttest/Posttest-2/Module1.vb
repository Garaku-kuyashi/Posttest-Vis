Imports System.Dynamic

Module Module1
	Public daftarBuku(99, 1) As String
	Public jumlahBuku As Integer

	Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
		If GetIndexBuku(judul) >= 0 Then
			MessageBox.Show("sudah ada bukunya")
			Return
		End If

		If jumlahBuku < 100 Then
			daftarBuku(jumlahBuku, 0) = judul
			daftarBuku(jumlahBuku, 1) = genre
			jumlahBuku += 1
		Else
			MessageBox.Show("buku sudah maks")
		End If
	End Sub

	Public Sub HapusBuku(ByVal judul As String)
		If GetIndexBuku(judul) < 0 Then
			MessageBox.Show("bukunya gak ada")
			Return
		End If

		Dim index As Integer = GetIndexBuku(judul)
		If index >= 0 And index < jumlahBuku Then
			For i As Integer = index To jumlahBuku - 2
				daftarBuku(i, 0) = daftarBuku(i + 1, 0)
				daftarBuku(i, 1) = daftarBuku(i + 1, 1)
			Next
			jumlahBuku -= 1
			daftarBuku(jumlahBuku, 0) = Nothing
			daftarBuku(jumlahBuku, 1) = Nothing
		End If

	End Sub

	Public Function GetIndexBuku(ByVal judul As String) As Integer
		For i As Integer = 0 To jumlahBuku - 1
			If daftarBuku(i, 0) = judul Then
				Return i
			End If
		Next
		Return -1
	End Function
End Module
