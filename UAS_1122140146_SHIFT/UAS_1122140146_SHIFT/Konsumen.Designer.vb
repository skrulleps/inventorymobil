<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konsumen
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
        Me.DataGridViewKonsumen = New System.Windows.Forms.DataGridView()
        Me.lbl_idkonsumen = New System.Windows.Forms.Label()
        Me.lbl_namakonsumen = New System.Windows.Forms.Label()
        Me.lbl_alamatkonsumen = New System.Windows.Forms.Label()
        Me.lbl_notelp = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_tmbhkonsumen = New System.Windows.Forms.Button()
        Me.btn_edtkonsumen = New System.Windows.Forms.Button()
        Me.btn_hpskonsumen = New System.Windows.Forms.Button()
        Me.btn_tutupkonsumen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewKonsumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewKonsumen
        '
        Me.DataGridViewKonsumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKonsumen.Location = New System.Drawing.Point(21, 345)
        Me.DataGridViewKonsumen.Name = "DataGridViewKonsumen"
        Me.DataGridViewKonsumen.RowTemplate.Height = 28
        Me.DataGridViewKonsumen.Size = New System.Drawing.Size(709, 163)
        Me.DataGridViewKonsumen.TabIndex = 0
        '
        'lbl_idkonsumen
        '
        Me.lbl_idkonsumen.AutoSize = True
        Me.lbl_idkonsumen.Location = New System.Drawing.Point(67, 83)
        Me.lbl_idkonsumen.Name = "lbl_idkonsumen"
        Me.lbl_idkonsumen.Size = New System.Drawing.Size(106, 20)
        Me.lbl_idkonsumen.TabIndex = 1
        Me.lbl_idkonsumen.Text = "ID Konsumen"
        '
        'lbl_namakonsumen
        '
        Me.lbl_namakonsumen.AutoSize = True
        Me.lbl_namakonsumen.Location = New System.Drawing.Point(67, 117)
        Me.lbl_namakonsumen.Name = "lbl_namakonsumen"
        Me.lbl_namakonsumen.Size = New System.Drawing.Size(51, 20)
        Me.lbl_namakonsumen.TabIndex = 2
        Me.lbl_namakonsumen.Text = "Nama"
        '
        'lbl_alamatkonsumen
        '
        Me.lbl_alamatkonsumen.AutoSize = True
        Me.lbl_alamatkonsumen.Location = New System.Drawing.Point(67, 154)
        Me.lbl_alamatkonsumen.Name = "lbl_alamatkonsumen"
        Me.lbl_alamatkonsumen.Size = New System.Drawing.Size(59, 20)
        Me.lbl_alamatkonsumen.TabIndex = 3
        Me.lbl_alamatkonsumen.Text = "Alamat"
        '
        'lbl_notelp
        '
        Me.lbl_notelp.AutoSize = True
        Me.lbl_notelp.Location = New System.Drawing.Point(57, 237)
        Me.lbl_notelp.Name = "lbl_notelp"
        Me.lbl_notelp.Size = New System.Drawing.Size(94, 20)
        Me.lbl_notelp.TabIndex = 4
        Me.lbl_notelp.Text = "No. Telepon"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(204, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(204, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(230, 26)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(204, 151)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(285, 74)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(204, 231)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(169, 26)
        Me.TextBox4.TabIndex = 8
        '
        'btn_tmbhkonsumen
        '
        Me.btn_tmbhkonsumen.Location = New System.Drawing.Point(98, 291)
        Me.btn_tmbhkonsumen.Name = "btn_tmbhkonsumen"
        Me.btn_tmbhkonsumen.Size = New System.Drawing.Size(86, 37)
        Me.btn_tmbhkonsumen.TabIndex = 9
        Me.btn_tmbhkonsumen.Text = "Tambah"
        Me.btn_tmbhkonsumen.UseVisualStyleBackColor = True
        '
        'btn_edtkonsumen
        '
        Me.btn_edtkonsumen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edtkonsumen.ForeColor = System.Drawing.Color.Black
        Me.btn_edtkonsumen.Location = New System.Drawing.Point(218, 291)
        Me.btn_edtkonsumen.Name = "btn_edtkonsumen"
        Me.btn_edtkonsumen.Size = New System.Drawing.Size(86, 37)
        Me.btn_edtkonsumen.TabIndex = 2
        Me.btn_edtkonsumen.Text = "Edit"
        Me.btn_edtkonsumen.UseVisualStyleBackColor = True
        '
        'btn_hpskonsumen
        '
        Me.btn_hpskonsumen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hpskonsumen.ForeColor = System.Drawing.Color.Black
        Me.btn_hpskonsumen.Location = New System.Drawing.Point(333, 291)
        Me.btn_hpskonsumen.Name = "btn_hpskonsumen"
        Me.btn_hpskonsumen.Size = New System.Drawing.Size(86, 37)
        Me.btn_hpskonsumen.TabIndex = 10
        Me.btn_hpskonsumen.Text = "Hapus"
        Me.btn_hpskonsumen.UseVisualStyleBackColor = True
        '
        'btn_tutupkonsumen
        '
        Me.btn_tutupkonsumen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tutupkonsumen.ForeColor = System.Drawing.Color.Black
        Me.btn_tutupkonsumen.Location = New System.Drawing.Point(450, 291)
        Me.btn_tutupkonsumen.Name = "btn_tutupkonsumen"
        Me.btn_tutupkonsumen.Size = New System.Drawing.Size(86, 37)
        Me.btn_tutupkonsumen.TabIndex = 11
        Me.btn_tutupkonsumen.Text = "Tutup"
        Me.btn_tutupkonsumen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Data Konsumen"
        '
        'Konsumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 520)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_tutupkonsumen)
        Me.Controls.Add(Me.btn_hpskonsumen)
        Me.Controls.Add(Me.btn_edtkonsumen)
        Me.Controls.Add(Me.btn_tmbhkonsumen)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_notelp)
        Me.Controls.Add(Me.lbl_alamatkonsumen)
        Me.Controls.Add(Me.lbl_namakonsumen)
        Me.Controls.Add(Me.lbl_idkonsumen)
        Me.Controls.Add(Me.DataGridViewKonsumen)
        Me.Name = "Konsumen"
        Me.Text = "konsumen"
        CType(Me.DataGridViewKonsumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewKonsumen As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_idkonsumen As System.Windows.Forms.Label
    Friend WithEvents lbl_namakonsumen As System.Windows.Forms.Label
    Friend WithEvents lbl_alamatkonsumen As System.Windows.Forms.Label
    Friend WithEvents lbl_notelp As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btn_tmbhkonsumen As System.Windows.Forms.Button
    Friend WithEvents btn_edtkonsumen As System.Windows.Forms.Button
    Friend WithEvents btn_hpskonsumen As System.Windows.Forms.Button
    Friend WithEvents btn_tutupkonsumen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
