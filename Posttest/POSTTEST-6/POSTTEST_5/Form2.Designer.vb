<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        dgvDetail = New DataGridView()
        txtKodeKarakter = New TextBox()
        txtDesk = New TextBox()
        txtSenjata = New TextBox()
        txtSearch = New TextBox()
        cbOrdo = New ComboBox()
        cbNama = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDetail, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Group_7374__1_
        PictureBox1.Location = New Point(-2, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(824, 457)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dgvDetail
        ' 
        dgvDetail.BackgroundColor = Color.AntiqueWhite
        dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetail.Location = New Point(60, 288)
        dgvDetail.Name = "dgvDetail"
        dgvDetail.Size = New Size(680, 150)
        dgvDetail.TabIndex = 1
        ' 
        ' txtKodeKarakter
        ' 
        txtKodeKarakter.Location = New Point(167, 102)
        txtKodeKarakter.Name = "txtKodeKarakter"
        txtKodeKarakter.Size = New Size(121, 23)
        txtKodeKarakter.TabIndex = 2
        ' 
        ' txtDesk
        ' 
        txtDesk.Location = New Point(525, 61)
        txtDesk.Multiline = True
        txtDesk.Name = "txtDesk"
        txtDesk.Size = New Size(215, 142)
        txtDesk.TabIndex = 3
        ' 
        ' txtSenjata
        ' 
        txtSenjata.Location = New Point(167, 146)
        txtSenjata.Name = "txtSenjata"
        txtSenjata.Size = New Size(121, 23)
        txtSenjata.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(60, 259)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(680, 23)
        txtSearch.TabIndex = 5
        txtSearch.Text = "Cari... (pastikan dihapus dulu sebelum ingin mencari)"
        ' 
        ' cbOrdo
        ' 
        cbOrdo.FormattingEnabled = True
        cbOrdo.Items.AddRange(New Object() {"Assassin's", "Templar", "The Hidden Ones", "The Order Of The Ancients", "Instruments Of The First Will", "Cult Of Kosmos", "Children Of Danu", "Abstergo Industries"})
        cbOrdo.Location = New Point(167, 194)
        cbOrdo.Name = "cbOrdo"
        cbOrdo.Size = New Size(121, 23)
        cbOrdo.TabIndex = 6
        ' 
        ' cbNama
        ' 
        cbNama.FormattingEnabled = True
        cbNama.Location = New Point(167, 61)
        cbNama.Name = "cbNama"
        cbNama.Size = New Size(121, 23)
        cbNama.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("NSimSun", 9.75F)
        Label1.Location = New Point(60, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 13)
        Label1.TabIndex = 8
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("NSimSun", 9.75F)
        Label2.Location = New Point(60, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 13)
        Label2.TabIndex = 9
        Label2.Text = "Kode Karakter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("NSimSun", 9.75F)
        Label3.Location = New Point(60, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 13)
        Label3.TabIndex = 10
        Label3.Text = "Senjata"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("NSimSun", 9.75F)
        Label4.Location = New Point(60, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 13)
        Label4.TabIndex = 11
        Label4.Text = "Ordo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("NSimSun", 9.75F)
        Label5.Location = New Point(566, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 13)
        Label5.TabIndex = 12
        Label5.Text = "Deskripsi Karakter"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Thistle
        btnSimpan.Location = New Point(60, 230)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(127, 23)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Thistle
        btnUbah.Location = New Point(193, 231)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(124, 23)
        btnUbah.TabIndex = 14
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Thistle
        btnHapus.Location = New Point(479, 231)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(124, 23)
        btnHapus.TabIndex = 15
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Thistle
        btnBatal.Location = New Point(609, 231)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(131, 23)
        btnBatal.TabIndex = 16
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(821, 450)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbNama)
        Controls.Add(cbOrdo)
        Controls.Add(txtSearch)
        Controls.Add(txtSenjata)
        Controls.Add(txtDesk)
        Controls.Add(txtKodeKarakter)
        Controls.Add(dgvDetail)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDetail, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents txtKodeKarakter As TextBox
    Friend WithEvents txtDesk As TextBox
    Friend WithEvents txtSenjata As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbOrdo As ComboBox
    Friend WithEvents cbNama As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
End Class
