<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sumber
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
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SumAir = New System.Windows.Forms.ComboBox()
        Me.BatasDaya = New System.Windows.Forms.ComboBox()
        Me.Genset = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LimeGreen
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(64, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 31)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "DATA SUMBER"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(22, 67)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(292, 15)
        Me.Label46.TabIndex = 106
        Me.Label46.Text = "(Silahkan isi data sumber air dan penerangan Anda)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Sumber Air"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Batas Daya (VA)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Genset"
        '
        'SumAir
        '
        Me.SumAir.FormattingEnabled = True
        Me.SumAir.Items.AddRange(New Object() {"PDAM", "Sumur Bor", "Lainnya"})
        Me.SumAir.Location = New System.Drawing.Point(163, 103)
        Me.SumAir.Name = "SumAir"
        Me.SumAir.Size = New System.Drawing.Size(121, 21)
        Me.SumAir.TabIndex = 110
        '
        'BatasDaya
        '
        Me.BatasDaya.FormattingEnabled = True
        Me.BatasDaya.Items.AddRange(New Object() {"<= 450 VA", "900 VA", "1300 VA", "2200 VA", "3500 - 5500 VA", ">= 6600 VA"})
        Me.BatasDaya.Location = New System.Drawing.Point(163, 148)
        Me.BatasDaya.Name = "BatasDaya"
        Me.BatasDaya.Size = New System.Drawing.Size(121, 21)
        Me.BatasDaya.TabIndex = 111
        '
        'Genset
        '
        Me.Genset.Location = New System.Drawing.Point(163, 199)
        Me.Genset.Name = "Genset"
        Me.Genset.Size = New System.Drawing.Size(121, 20)
        Me.Genset.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "VA"
        '
        'HapusButton
        '
        Me.HapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HapusButton.Location = New System.Drawing.Point(194, 252)
        Me.HapusButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(103, 29)
        Me.HapusButton.TabIndex = 115
        Me.HapusButton.Text = "HAPUS"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanButton.Location = New System.Drawing.Point(56, 252)
        Me.SimpanButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(103, 29)
        Me.SimpanButton.TabIndex = 114
        Me.SimpanButton.Text = "SIMPAN"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 50)
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Sumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 307)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Genset)
        Me.Controls.Add(Me.BatasDaya)
        Me.Controls.Add(Me.SumAir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Sumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sumber"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SumAir As System.Windows.Forms.ComboBox
    Friend WithEvents BatasDaya As System.Windows.Forms.ComboBox
    Friend WithEvents Genset As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
End Class
