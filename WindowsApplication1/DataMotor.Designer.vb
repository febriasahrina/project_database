<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMotor
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ThnPemM = New System.Windows.Forms.ComboBox()
        Me.IsiSM = New System.Windows.Forms.ComboBox()
        Me.Asal4M = New System.Windows.Forms.RadioButton()
        Me.Asal3M = New System.Windows.Forms.RadioButton()
        Me.Asal2M = New System.Windows.Forms.RadioButton()
        Me.Asal1M = New System.Windows.Forms.RadioButton()
        Me.JlhMotor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PajakMot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HapusButton
        '
        Me.HapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HapusButton.Location = New System.Drawing.Point(188, 373)
        Me.HapusButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(103, 29)
        Me.HapusButton.TabIndex = 106
        Me.HapusButton.Text = "HAPUS"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanButton.Location = New System.Drawing.Point(50, 373)
        Me.SimpanButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(103, 29)
        Me.SimpanButton.TabIndex = 105
        Me.SimpanButton.Text = "SIMPAN"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(24, 59)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(171, 15)
        Me.Label46.TabIndex = 105
        Me.Label46.Text = "(Silahkan isi data motor Anda)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "unit"
        '
        'ThnPemM
        '
        Me.ThnPemM.FormattingEnabled = True
        Me.ThnPemM.Items.AddRange(New Object() {"<= 2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016"})
        Me.ThnPemM.Location = New System.Drawing.Point(192, 283)
        Me.ThnPemM.Name = "ThnPemM"
        Me.ThnPemM.Size = New System.Drawing.Size(121, 21)
        Me.ThnPemM.TabIndex = 103
        '
        'IsiSM
        '
        Me.IsiSM.FormattingEnabled = True
        Me.IsiSM.Items.AddRange(New Object() {"> 500 cc", "300 - 499 cc", "200 - 299 cc", "100 - 199 cc", "< 100 cc"})
        Me.IsiSM.Location = New System.Drawing.Point(192, 245)
        Me.IsiSM.Name = "IsiSM"
        Me.IsiSM.Size = New System.Drawing.Size(121, 21)
        Me.IsiSM.TabIndex = 102
        '
        'Asal4M
        '
        Me.Asal4M.AutoSize = True
        Me.Asal4M.Location = New System.Drawing.Point(192, 213)
        Me.Asal4M.Name = "Asal4M"
        Me.Asal4M.Size = New System.Drawing.Size(93, 17)
        Me.Asal4M.TabIndex = 101
        Me.Asal4M.TabStop = True
        Me.Asal4M.Text = "ASEAN/China"
        Me.Asal4M.UseVisualStyleBackColor = True
        '
        'Asal3M
        '
        Me.Asal3M.AutoSize = True
        Me.Asal3M.Location = New System.Drawing.Point(192, 188)
        Me.Asal3M.Name = "Asal3M"
        Me.Asal3M.Size = New System.Drawing.Size(53, 17)
        Me.Asal3M.TabIndex = 100
        Me.Asal3M.TabStop = True
        Me.Asal3M.Text = "Korea"
        Me.Asal3M.UseVisualStyleBackColor = True
        '
        'Asal2M
        '
        Me.Asal2M.AutoSize = True
        Me.Asal2M.Location = New System.Drawing.Point(192, 163)
        Me.Asal2M.Name = "Asal2M"
        Me.Asal2M.Size = New System.Drawing.Size(105, 17)
        Me.Asal2M.TabIndex = 99
        Me.Asal2M.TabStop = True
        Me.Asal2M.Text = "Jepang/Australia"
        Me.Asal2M.UseVisualStyleBackColor = True
        '
        'Asal1M
        '
        Me.Asal1M.AutoSize = True
        Me.Asal1M.Location = New System.Drawing.Point(192, 138)
        Me.Asal1M.Name = "Asal1M"
        Me.Asal1M.Size = New System.Drawing.Size(96, 17)
        Me.Asal1M.TabIndex = 98
        Me.Asal1M.TabStop = True
        Me.Asal1M.Text = "Eropa/Amerika"
        Me.Asal1M.UseVisualStyleBackColor = True
        '
        'JlhMotor
        '
        Me.JlhMotor.Location = New System.Drawing.Point(192, 98)
        Me.JlhMotor.Name = "JlhMotor"
        Me.JlhMotor.Size = New System.Drawing.Size(46, 20)
        Me.JlhMotor.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 32)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Tahun Pembuatan/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perakitan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Isi Silinder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Negara Asal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pemegang Merk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 32)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Jumlah Motor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yang Dimiliki"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LimeGreen
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(4, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(341, 31)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "DATA FASILITAS MOTOR"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 50)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(167, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Rp"
        '
        'PajakMot
        '
        Me.PajakMot.Location = New System.Drawing.Point(193, 322)
        Me.PajakMot.Name = "PajakMot"
        Me.PajakMot.Size = New System.Drawing.Size(120, 20)
        Me.PajakMot.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Pajak Motor"
        '
        'DataMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 423)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PajakMot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ThnPemM)
        Me.Controls.Add(Me.IsiSM)
        Me.Controls.Add(Me.Asal4M)
        Me.Controls.Add(Me.Asal3M)
        Me.Controls.Add(Me.Asal2M)
        Me.Controls.Add(Me.Asal1M)
        Me.Controls.Add(Me.JlhMotor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "DataMotor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataMotor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ThnPemM As System.Windows.Forms.ComboBox
    Friend WithEvents IsiSM As System.Windows.Forms.ComboBox
    Friend WithEvents Asal4M As System.Windows.Forms.RadioButton
    Friend WithEvents Asal3M As System.Windows.Forms.RadioButton
    Friend WithEvents Asal2M As System.Windows.Forms.RadioButton
    Friend WithEvents Asal1M As System.Windows.Forms.RadioButton
    Friend WithEvents JlhMotor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PajakMot As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
