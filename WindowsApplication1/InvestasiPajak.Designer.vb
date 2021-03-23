<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvestasiPajak
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
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BenBeg = New System.Windows.Forms.ComboBox()
        Me.BenTbeg = New System.Windows.Forms.ComboBox()
        Me.Netto = New System.Windows.Forms.ComboBox()
        Me.PPH21 = New System.Windows.Forms.TextBox()
        Me.PPH23 = New System.Windows.Forms.TextBox()
        Me.PPN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HapusButton
        '
        Me.HapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HapusButton.Location = New System.Drawing.Point(206, 430)
        Me.HapusButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(103, 29)
        Me.HapusButton.TabIndex = 141
        Me.HapusButton.Text = "HAPUS"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanButton.Location = New System.Drawing.Point(68, 430)
        Me.SimpanButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(103, 29)
        Me.SimpanButton.TabIndex = 140
        Me.SimpanButton.Text = "SIMPAN"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(19, 59)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(281, 15)
        Me.Label46.TabIndex = 127
        Me.Label46.Text = "(Silahkan isi data investasi dan beban pajak Anda)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Beban Pajak PPH 21"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 48)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Usaha/Investasi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pada Badan Usaha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pendapatan Bersih/Netto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Benda Tidak Bergerak"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Benda Bergerak"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LimeGreen
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(105, -2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 50)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "   DATA PAJAK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DAN INVESTASI "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 50)
        Me.PictureBox1.TabIndex = 111
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Beban Pajak PPH 23"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "PPN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 45)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "(Mis. kendaraan sewa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seperti kepemilikan taxi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MPU, dsb) per tahun"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 60)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "(Mis. rumah sewa, hotel, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tanah, gudang,perkebunan, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pertanian, perikanan, dsb)" & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "per tahun"
        '
        'BenBeg
        '
        Me.BenBeg.FormattingEnabled = True
        Me.BenBeg.Items.AddRange(New Object() {"< Rp 500 Jt", "Rp 500 Jt - 1M", "Rp 1M - 2M", "Rp 2M - 5M", "Rp 5M - 10M", "> Rp 10M"})
        Me.BenBeg.Location = New System.Drawing.Point(211, 105)
        Me.BenBeg.Name = "BenBeg"
        Me.BenBeg.Size = New System.Drawing.Size(121, 21)
        Me.BenBeg.TabIndex = 134
        '
        'BenTbeg
        '
        Me.BenTbeg.FormattingEnabled = True
        Me.BenTbeg.Items.AddRange(New Object() {"< Rp 500 Jt", "Rp 500 Jt - 1M", "Rp 1M - 2M", "Rp 2M - 5M", "Rp 5M - 10M", "> Rp 10M"})
        Me.BenTbeg.Location = New System.Drawing.Point(211, 190)
        Me.BenTbeg.Name = "BenTbeg"
        Me.BenTbeg.Size = New System.Drawing.Size(121, 21)
        Me.BenTbeg.TabIndex = 135
        '
        'Netto
        '
        Me.Netto.FormattingEnabled = True
        Me.Netto.Items.AddRange(New Object() {"< Rp 500 Jt", "Rp 500 Jt - 1M", "Rp 1M - 2M", "Rp 2M - 5M", "Rp 5M - 10M", "> Rp 10M"})
        Me.Netto.Location = New System.Drawing.Point(211, 256)
        Me.Netto.Name = "Netto"
        Me.Netto.Size = New System.Drawing.Size(121, 21)
        Me.Netto.TabIndex = 136
        '
        'PPH21
        '
        Me.PPH21.Location = New System.Drawing.Point(211, 305)
        Me.PPH21.Name = "PPH21"
        Me.PPH21.Size = New System.Drawing.Size(121, 20)
        Me.PPH21.TabIndex = 137
        '
        'PPH23
        '
        Me.PPH23.Location = New System.Drawing.Point(211, 343)
        Me.PPH23.Name = "PPH23"
        Me.PPH23.Size = New System.Drawing.Size(121, 20)
        Me.PPH23.TabIndex = 138
        '
        'PPN
        '
        Me.PPN.Location = New System.Drawing.Point(211, 381)
        Me.PPN.Name = "PPN"
        Me.PPN.Size = New System.Drawing.Size(121, 20)
        Me.PPN.TabIndex = 139
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(335, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 15)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "/ thn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(336, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 15)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "/ thn"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(334, 384)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 15)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "/ thn"
        '
        'InvestasiPajak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 480)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PPN)
        Me.Controls.Add(Me.PPH23)
        Me.Controls.Add(Me.PPH21)
        Me.Controls.Add(Me.Netto)
        Me.Controls.Add(Me.BenTbeg)
        Me.Controls.Add(Me.BenBeg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "InvestasiPajak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InvestasiPajak"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BenBeg As System.Windows.Forms.ComboBox
    Friend WithEvents BenTbeg As System.Windows.Forms.ComboBox
    Friend WithEvents Netto As System.Windows.Forms.ComboBox
    Friend WithEvents PPH21 As System.Windows.Forms.TextBox
    Friend WithEvents PPH23 As System.Windows.Forms.TextBox
    Friend WithEvents PPN As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
