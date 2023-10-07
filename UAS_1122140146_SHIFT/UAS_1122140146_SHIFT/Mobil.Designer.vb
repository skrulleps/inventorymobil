<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mobil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewtbl_mobil = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewtbl_mobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Data Mobil"
        '
        'DataGridViewtbl_mobil
        '
        Me.DataGridViewtbl_mobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtbl_mobil.Location = New System.Drawing.Point(12, 246)
        Me.DataGridViewtbl_mobil.Name = "DataGridViewtbl_mobil"
        Me.DataGridViewtbl_mobil.RowTemplate.Height = 28
        Me.DataGridViewtbl_mobil.Size = New System.Drawing.Size(620, 172)
        Me.DataGridViewtbl_mobil.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(104, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Beli Mobil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(342, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Jual Mobil"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 430)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewtbl_mobil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mobil"
        Me.Text = "Mobilvb"
        CType(Me.DataGridViewtbl_mobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewtbl_mobil As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
