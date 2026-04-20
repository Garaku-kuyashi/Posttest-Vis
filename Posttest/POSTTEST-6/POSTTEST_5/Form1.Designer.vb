<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtKode = New TextBox()
        TxtNama = New TextBox()
        TxtTahun = New TextBox()
        TxtLokasi = New TextBox()
        TxtCari = New TextBox()
        BtnSimpan = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnBatal = New Button()
        dgvAnimus = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        btnPindah = New Button()
        CType(dgvAnimus, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("NSimSun", 9.75F)
        Label1.Location = New Point(97, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 13)
        Label1.TabIndex = 0
        Label1.Text = "Kode Animus"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("NSimSun", 9.75F)
        Label2.Location = New Point(97, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 13)
        Label2.TabIndex = 1
        Label2.Text = "Nama Karakter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("NSimSun", 9.75F)
        Label3.Location = New Point(473, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 13)
        Label3.TabIndex = 2
        Label3.Text = "Lokasi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("NSimSun", 9.75F)
        Label4.Location = New Point(473, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 13)
        Label4.TabIndex = 3
        Label4.Text = "Tahun Latar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("NSimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(140, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 13)
        Label5.TabIndex = 4
        Label5.Text = "Cari"
        ' 
        ' TxtKode
        ' 
        TxtKode.Location = New Point(201, 115)
        TxtKode.Name = "TxtKode"
        TxtKode.Size = New Size(240, 23)
        TxtKode.TabIndex = 5
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(201, 151)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(240, 23)
        TxtNama.TabIndex = 6
        ' 
        ' TxtTahun
        ' 
        TxtTahun.Location = New Point(577, 147)
        TxtTahun.Name = "TxtTahun"
        TxtTahun.Size = New Size(134, 23)
        TxtTahun.TabIndex = 7
        ' 
        ' TxtLokasi
        ' 
        TxtLokasi.Location = New Point(577, 112)
        TxtLokasi.Name = "TxtLokasi"
        TxtLokasi.Size = New Size(134, 23)
        TxtLokasi.TabIndex = 8
        ' 
        ' TxtCari
        ' 
        TxtCari.Location = New Point(201, 187)
        TxtCari.Name = "TxtCari"
        TxtCari.Size = New Size(510, 23)
        TxtCari.TabIndex = 9
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = Color.Thistle
        BtnSimpan.Location = New Point(201, 216)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(117, 23)
        BtnSimpan.TabIndex = 10
        BtnSimpan.Text = "Tambah"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.Thistle
        BtnHapus.Location = New Point(471, 216)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(117, 23)
        BtnHapus.TabIndex = 11
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.Thistle
        BtnUbah.Location = New Point(324, 216)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(117, 23)
        BtnUbah.TabIndex = 12
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.Thistle
        BtnBatal.Location = New Point(594, 216)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(117, 23)
        BtnBatal.TabIndex = 13
        BtnBatal.Text = "Batal"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvAnimus
        ' 
        dgvAnimus.BackgroundColor = Color.AntiqueWhite
        dgvAnimus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnimus.Location = New Point(201, 245)
        dgvAnimus.Name = "dgvAnimus"
        dgvAnimus.Size = New Size(510, 150)
        dgvAnimus.TabIndex = 14
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Group_7373__4_
        PictureBox1.Location = New Point(-1, -17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(909, 486)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(129, 41)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(133, 45)
        AxWindowsMediaPlayer1.TabIndex = 16
        ' 
        ' btnPindah
        ' 
        btnPindah.BackColor = Color.Thistle
        btnPindah.Location = New Point(390, 401)
        btnPindah.Name = "btnPindah"
        btnPindah.Size = New Size(132, 23)
        btnPindah.TabIndex = 17
        btnPindah.Text = "Swicth"
        btnPindah.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(897, 450)
        Controls.Add(btnPindah)
        Controls.Add(dgvAnimus)
        Controls.Add(BtnBatal)
        Controls.Add(BtnUbah)
        Controls.Add(BtnHapus)
        Controls.Add(BtnSimpan)
        Controls.Add(TxtCari)
        Controls.Add(TxtLokasi)
        Controls.Add(TxtTahun)
        Controls.Add(TxtNama)
        Controls.Add(TxtKode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(AxWindowsMediaPlayer1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvAnimus, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtTahun As TextBox
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents dgvAnimus As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnPindah As Button

End Class
