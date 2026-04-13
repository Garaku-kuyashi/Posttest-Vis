Imports MySqlConnector

Module DataModule
    Public Function GetAllJenis() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT AnimusKode, NamaKarakter, Tahun, Lokasi FROM tbjenis ORDER BY AnimusKode ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function SearchJenis(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT AnimusKode, NamaKarakter, Tahun, Lokasi FROM tbjenis " &
                             "WHERE AnimusKode LIKE @keyword " &
                             "OR NamaKarakter LIKE @keyword " &
                             "OR Lokasi LIKE @keyword " &
                             "ORDER BY AnimusKode ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbjenis WHERE AnimusKode = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function UbahJenis(kode As String, nama As String, tahun As String, lokasi As String) As Boolean
        Try
            Dim query As String = "UPDATE tbjenis SET NamaKarakter=@nama, Tahun=@tahun, Lokasi=@lokasi " &
                             "WHERE AnimusKode=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@lokasi", lokasi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Ubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusJenis(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbjenis WHERE AnimusKode = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetJenisByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT AnimusKode, NamaKarakter, Tahun, Lokasi FROM tbjenis WHERE AnimusKode = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil detail data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanJenis(kode As String, nama As String, tahun As String, lokasi As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbjenis (AnimusKode, NamaKarakter, Tahun, Lokasi) " &
                             "VALUES (@kode, @nama, @tahun, @lokasi)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@lokasi", lokasi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal Simpan: " & ex.Message)
            Return False
        End Try
    End Function
End Module