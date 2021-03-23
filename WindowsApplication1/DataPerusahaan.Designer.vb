<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPerusahaan
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NamaP = New System.Windows.Forms.TextBox()
        Me.AlamatP = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 50)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LimeGreen
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(20, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(244, 26)
        Me.Label11.TabIndex = 184
        Me.Label11.Text = "DATA PERUSAHAAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "Nama Perusahaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 16)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Alamat Perusahaan"
        '
        'NamaP
        '
        Me.NamaP.Location = New System.Drawing.Point(15, 112)
        Me.NamaP.Name = "NamaP"
        Me.NamaP.Size = New System.Drawing.Size(213, 20)
        Me.NamaP.TabIndex = 187
        '
        'AlamatP
        '
        Me.AlamatP.Location = New System.Drawing.Point(15, 170)
        Me.AlamatP.Name = "AlamatP"
        Me.AlamatP.Size = New System.Drawing.Size(213, 20)
        Me.AlamatP.TabIndex = 188
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(11, 61)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(175, 15)
        Me.Label46.TabIndex = 189
        Me.Label46.Text = "(Silahkan isi data Perusahaan)"
        '
        'HapusButton
        '
        Me.HapusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HapusButton.Location = New System.Drawing.Point(125, 209)
        Me.HapusButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(103, 29)
        Me.HapusButton.TabIndex = 190
        Me.HapusButton.Text = "HAPUS"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanButton.Location = New System.Drawing.Point(13, 209)
        Me.SimpanButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(103, 29)
        Me.SimpanButton.TabIndex = 189
        Me.SimpanButton.Text = "SIMPAN"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'DataPerusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.AlamatP)
        Me.Controls.Add(Me.NamaP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "DataPerusahaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataPerusahaan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NamaP As System.Windows.Forms.TextBox
    Friend WithEvents AlamatP As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
End Class
