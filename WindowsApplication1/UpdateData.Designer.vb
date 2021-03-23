<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateData))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nopen = New System.Windows.Forms.TextBox()
        Me.namaM = New System.Windows.Forms.TextBox()
        Me.notelM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BlnlM = New System.Windows.Forms.ComboBox()
        Me.ThnLM = New System.Windows.Forms.ComboBox()
        Me.TglLM = New System.Windows.Forms.ComboBox()
        Me.nisn = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pengukt = New System.Windows.Forms.ComboBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(22, 282)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 16)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Tanggal Lahir"
        '
        'nopen
        '
        Me.nopen.Location = New System.Drawing.Point(174, 172)
        Me.nopen.Name = "nopen"
        Me.nopen.Size = New System.Drawing.Size(223, 20)
        Me.nopen.TabIndex = 76
        '
        'namaM
        '
        Me.namaM.Location = New System.Drawing.Point(174, 197)
        Me.namaM.Name = "namaM"
        Me.namaM.Size = New System.Drawing.Size(223, 20)
        Me.namaM.TabIndex = 77
        '
        'notelM
        '
        Me.notelM.Location = New System.Drawing.Point(174, 309)
        Me.notelM.Name = "notelM"
        Me.notelM.Size = New System.Drawing.Size(223, 20)
        Me.notelM.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Pengajuan UKT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "No. Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Nama Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "No Pendaftaran"
        '
        'BlnlM
        '
        Me.BlnlM.FormattingEnabled = True
        Me.BlnlM.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.BlnlM.Location = New System.Drawing.Point(244, 281)
        Me.BlnlM.Name = "BlnlM"
        Me.BlnlM.Size = New System.Drawing.Size(58, 21)
        Me.BlnlM.TabIndex = 81
        Me.BlnlM.Text = "Bln"
        '
        'ThnLM
        '
        Me.ThnLM.DropDownHeight = 156
        Me.ThnLM.FormattingEnabled = True
        Me.ThnLM.IntegralHeight = False
        Me.ThnLM.Items.AddRange(New Object() {"2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990"})
        Me.ThnLM.Location = New System.Drawing.Point(314, 281)
        Me.ThnLM.Name = "ThnLM"
        Me.ThnLM.Size = New System.Drawing.Size(83, 21)
        Me.ThnLM.TabIndex = 82
        Me.ThnLM.Text = "Tahun"
        '
        'TglLM
        '
        Me.TglLM.DropDownHeight = 156
        Me.TglLM.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TglLM.FormattingEnabled = True
        Me.TglLM.IntegralHeight = False
        Me.TglLM.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "21"})
        Me.TglLM.Location = New System.Drawing.Point(173, 281)
        Me.TglLM.Name = "TglLM"
        Me.TglLM.Size = New System.Drawing.Size(58, 21)
        Me.TglLM.TabIndex = 80
        Me.TglLM.Text = "Tgl"
        '
        'nisn
        '
        Me.nisn.Location = New System.Drawing.Point(174, 226)
        Me.nisn.Name = "nisn"
        Me.nisn.Size = New System.Drawing.Size(223, 20)
        Me.nisn.TabIndex = 78
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(23, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 16)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "NISN"
        '
        'pengukt
        '
        Me.pengukt.FormattingEnabled = True
        Me.pengukt.Items.AddRange(New Object() {"UKT Penuh", "UKT Berkeadilan", "Program Bidik Misi"})
        Me.pengukt.Location = New System.Drawing.Point(174, 253)
        Me.pengukt.Name = "pengukt"
        Me.pengukt.Size = New System.Drawing.Size(222, 21)
        Me.pengukt.TabIndex = 105
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(558, -1)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(36, 26)
        Me.PictureBox6.TabIndex = 86
        Me.PictureBox6.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button2
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(263, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 48)
        Me.Panel1.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Image = Global.WindowsApplication1.My.Resources.Resources.back4
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 27)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "CLEAR"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button2
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(46, 353)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 48)
        Me.Panel3.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Image = Global.WindowsApplication1.My.Resources.Resources.back4
        Me.Label5.Location = New System.Drawing.Point(47, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 27)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "UPDATE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Geometr415 Blk BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Image = Global.WindowsApplication1.My.Resources.Resources.back4
        Me.Label16.Location = New System.Drawing.Point(168, 73)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(213, 32)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "UPDATE DATA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BACK5
        Me.PictureBox1.Location = New System.Drawing.Point(-219, -79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(813, 236)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'UpdateData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 497)
        Me.Controls.Add(Me.pengukt)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BlnlM)
        Me.Controls.Add(Me.ThnLM)
        Me.Controls.Add(Me.TglLM)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.nopen)
        Me.Controls.Add(Me.namaM)
        Me.Controls.Add(Me.notelM)
        Me.Controls.Add(Me.nisn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateData"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents nopen As System.Windows.Forms.TextBox
    Friend WithEvents namaM As System.Windows.Forms.TextBox
    Friend WithEvents notelM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BlnlM As System.Windows.Forms.ComboBox
    Friend WithEvents ThnLM As System.Windows.Forms.ComboBox
    Friend WithEvents TglLM As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nisn As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents pengukt As System.Windows.Forms.ComboBox
End Class
