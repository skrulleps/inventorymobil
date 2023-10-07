Imports System.Data.Odbc

Public Class Konsumen

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        btn_tmbhkonsumen.Text = "Tambah"
        btn_edtkonsumen.Text = "Edit"
        btn_hpskonsumen.Text = "Hapus"
        btn_tutupkonsumen.Text = "Tutup"
        btn_tmbhkonsumen.Enabled = True
        btn_hpskonsumen.Enabled = True
        btn_edtkonsumen.Enabled = True
        btn_hpskonsumen.Enabled = True

        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From konsumen", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "konsumen")
        DataGridViewKonsumen.DataSource = Ds.Tables("konsumen")
        DataGridViewKonsumen.ReadOnly = True

    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewKonsumen.CellContentClick

    End Sub

    Private Sub Konsumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        
    End Sub

    Private Sub btn_tutupkonsumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tutupkonsumen.Click
        If btn_tutupkonsumen.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btn_tmbhkonsumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tmbhkonsumen.Click
        If btn_tmbhkonsumen.Text = "Tambah" Then
            btn_tmbhkonsumen.Text = "Simpan"
            btn_edtkonsumen.Enabled = False
            btn_hpskonsumen.Enabled = False
            btn_tutupkonsumen.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silakan Isi dulu")
            Else
                Call Koneksi()
                Dim InputData As String = "INSERT INTO `konsumen` values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Success")
                Call KondisiAwal()
            End If

        End If
    End Sub

    Private Sub btn_edtkonsumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edtkonsumen.Click
        If btn_edtkonsumen.Text = "Edit" Then
            btn_edtkonsumen.Text = "Simpan"
            btn_edtkonsumen.Enabled = True
            btn_tmbhkonsumen.Enabled = False
            btn_hpskonsumen.Enabled = False
            btn_tutupkonsumen.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silakan Isi dulu")
            Else
                Call Koneksi()
                Dim UpdateData As String = "Update `konsumen` set nama_konsumen='" & TextBox2.Text & "',alamat_konsumen='" & TextBox3.Text & "',telp_konsumen='" & TextBox4.Text & "' where id_konsumen='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Success")
                Call KondisiAwal()
            End If

        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * from konsumen where id_konsumen='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Id Konsumen Tidak ada")
            Else
                TextBox1.Enabled = False
                TextBox1.Text = Rd.Item("id_konsumen")
                TextBox2.Text = Rd.Item("nama_konsumen")
                TextBox3.Text = Rd.Item("alamat_konsumen")
                TextBox4.Text = Rd.Item("telp_konsumen")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btn_hpskonsumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hpskonsumen.Click
        If btn_hpskonsumen.Text = "Hapus" Then
            btn_hpskonsumen.Text = "Delete"
            btn_edtkonsumen.Enabled = False
            btn_tmbhkonsumen.Enabled = False
            btn_tutupkonsumen.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silakan Isi dulu")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete From konsumen where id_konsumen='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Delete Success")
                Call KondisiAwal()
            End If

        End If
    End Sub
End Class