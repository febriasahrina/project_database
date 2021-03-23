<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMobil
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.JlhMobil = New System.Windows.Forms.TextBox()
        Me.Asal1 = New System.Windows.Forms.RadioButton()
        Me.Asal2 = New System.Windows.Forms.RadioButton()
        Me.Asal3 = New System.Windows.Forms.RadioButton()
        Me.Asal4 = New System.Windows.Forms.RadioButton()
        Me.IsiS = New System.Windows.Forms.ComboBox()
        Me.ThnPem = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PajakMob = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LimeGreen
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(10, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(328, 31)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "DATA FASILITAS MOBIL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 32)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Jumlah Mobil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yang Dimiliki"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Negara Asal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pemegang Merk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Isi Silinder"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 32)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Tahun Pembuatan/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perakitan"
        '
        'JlhMobil
        '
        Me.JlhMobil.Location = New System.Drawing.Point(199, 99)
        Me.JlhMobil.Name = "JlhMobil"
        Me.JlhMobil.Size = New System.Drawing.Size(46, 20)
        Me.JlhMobil.TabIndex = 27
        '
        'Asal1
        '
        Me.Asal1.AutoSize = True
        Me.Asal1.Location = New System.Drawing.Point(199, 139)
        Me.Asal1.Name = "Asal1"
        Me.Asal1.Size = New System.Drawing.Size(96, 17)
        Me.Asal1.TabIndex = 28
        Me.Asal1.TabStop = True
        Me.Asal1.Text = "Eropa/Amerika"
        Me.Asal1.UseVisualStyleBackColor = True
        '
        'Asal2
        '
        Me.Asal2.AutoSize = True
        Me.Asal2.Location = New System.Drawing.Point(199, 164)
        Me.Asal2.Name = "Asal2"
        Me.Asal2.Size = New System.Drawing.Size(105, 17)
        Me.Asal2.TabIndex = 29
        Me.Asal2.TabStop = True
        Me.Asal2.Text = "Jepang/Australia"
        Me.Asal2.UseVisualStyleBackColor = True
        '
        'Asal3
        '
        Me.Asal3.AutoSize = True
        Me.Asal3.Location = New System.Drawing.Point(199, 189)
        Me.Asal3.Name = "Asal3"
        Me.Asal3.Size = New System.Drawing.Size(53, 17)
        Me.Asal3.TabIndex = 30
        Me.Asal3.TabStop = True
        Me.Asal3.Text = "Korea"
        Me.Asal3.UseVisualStyleBackColor = True
        '
        'Asal4
        '
        Me.Asal4.AutoSize = True
        Me.Asal4.Location = New System.Drawing.Point(199, 214)
        Me.Asal4.Name = "Asal4"
        Me.Asal4.Size = New System.Drawing.Size(93, 17)
        Me.Asal4.TabIndex = 31
        Me.Asal4.TabStop = True
        Me.Asal4.Text = "ASEAN/China"
        Me.Asal4.UseVisualStyleBackColor = True
        '
        'IsiS
        '
        Me.IsiS.FormattingEnabled = True
        Me.IsiS.Items.AddRange(New Object() {"> 5000 cc", "3000 - 4999 cc", "2000 - 2999 cc", "1500 - 1999 cc", "< 1500 cc"})
        Me.IsiS.Location = New System.Drawing.Point(199, 246)
        Me.IsiS.Name = "IsiS"
        Me.IsiS.Size = New System.Drawing.Size(121, 21)
        Me.IsiS.TabIndex = 32
        '
        'ThnPem
        '
        Me.ThnPem.FormattingEnabled = True
        Me.ThnPem.Items.AddRange(New Object() {"<= 2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016"})
        Me.ThnPem.Location = New System.Drawing.Point(199, 284)
        Me.ThnPem.Name = "ThnPem"
        Me.ThnPem.Size = New System.Drawing.Size(121, 21)
        Me.ThnPem.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "unit"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(31, 60)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(170, 15)
        Me.Label46.TabIndex = 88
        Me.Label46.Text = "(Silahkan isi data mobil Anda)"
        '
        'HapusButton
        '
        Me.HapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HapusButton.Location = New System.Drawing.Point(187, 375)
        Me.HapusButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(103, 29)
        Me.HapusButton.TabIndex = 36
        Me.HapusButton.Text = "HAPUS"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanButton.Location = New System.Drawing.Point(49, 375)
        Me.SimpanButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(103, 29)
        Me.SimpanButton.TabIndex = 35
        Me.SimpanButton.Text = "SIMPAN"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 50)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Pajak Mobil"
        '
        'PajakMob
        '
        Me.PajakMob.Location = New System.Drawing.Point(200, 324)
        Me.PajakMob.Name = "PajakMob"
        Me.PajakMob.Size = New System.Drawing.Size(120, 20)
        Me.PajakMob.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Rp"
        '
        'DataMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 423)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PajakMob)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ThnPem)
        Me.Controls.Add(Me.IsiS)
        Me.Controls.Add(Me.Asal4)
        Me.Controls.Add(Me.Asal3)
        Me.Controls.Add(Me.Asal2)
        Me.Controls.Add(Me.Asal1)
        Me.Controls.Add(Me.JlhMobil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "DataMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataMobil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents JlhMobil As System.Windows.Forms.TextBox
    Friend WithEvents Asal1 As System.Windows.Forms.RadioButton
    Friend WithEvents Asal2 As System.Windows.Forms.RadioButton
    Friend WithEvents Asal3 As System.Windows.Forms.RadioButton
    Friend WithEvents Asal4 As System.Windows.Forms.RadioButton
    Friend WithEvents IsiS As System.Windows.Forms.ComboBox
    Friend WithEvents ThnPem As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PajakMob As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
