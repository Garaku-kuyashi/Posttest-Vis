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
        Label1 = New Label()
        Label2 = New Label()
        IpMu = New TextBox()
        IpHasil = New TextBox()
        Hasil = New Label()
        btn = New Button()
        btnR = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(140, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP SEMESTER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(140, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 1
        Label2.Text = "IP KUMULATIF"
        ' 
        ' IpMu
        ' 
        IpMu.Location = New Point(230, 105)
        IpMu.Name = "IpMu"
        IpMu.Size = New Size(210, 23)
        IpMu.TabIndex = 2
        ' 
        ' IpHasil
        ' 
        IpHasil.Location = New Point(230, 201)
        IpHasil.Name = "IpHasil"
        IpHasil.Size = New Size(210, 23)
        IpHasil.TabIndex = 3
        ' 
        ' Hasil
        ' 
        Hasil.AutoSize = True
        Hasil.Location = New Point(262, 260)
        Hasil.Name = "Hasil"
        Hasil.Size = New Size(145, 15)
        Hasil.TabIndex = 6
        Hasil.Text = "                                              "
        ' 
        ' btn
        ' 
        btn.Location = New Point(253, 153)
        btn.Name = "btn"
        btn.Size = New Size(75, 23)
        btn.TabIndex = 7
        btn.Text = "Tambah"
        btn.UseVisualStyleBackColor = True
        ' 
        ' btnR
        ' 
        btnR.Location = New Point(349, 153)
        btnR.Name = "btnR"
        btnR.Size = New Size(75, 23)
        btnR.TabIndex = 8
        btnR.Text = "Reset"
        btnR.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnR)
        Controls.Add(btn)
        Controls.Add(Hasil)
        Controls.Add(IpHasil)
        Controls.Add(IpMu)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IpMu As TextBox
    Friend WithEvents IpHasil As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Hasil As Label
    Friend WithEvents btn As Button
    Friend WithEvents btnR As Button

End Class
