Imports System.Data.Odbc
Public Class Jual_Mobil

    Sub KondisiAwal()
        lblnamakonsumen.Text = ""
        lblalalamat.Text = ""
        lbltelepon.Text = ""
        lblnamajenis.Text = ""
        lblnomesin.Text = ""
        DateTimePicker1.Text = Today
        lblnorangka.Text = ""
        txtharga.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""

       
    End Sub

    Sub MunculPelanggan()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from konsumen", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop

    End Sub

    Sub MunculMobil()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_mobil", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox2.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub Jual_Mobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call MunculPelanggan()
        Call MunculMobil()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from konsumen where id_konsumen ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lblnamakonsumen.Text = Rd!nama_konsumen
            lblalalamat.Text = Rd!alamat_konsumen
            lbltelepon.Text = Rd!telp_konsumen
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_mobil where kd_jenis ='" & ComboBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lblnamajenis.Text = Rd!jenis
            lbltipe.Text = Rd!tipe
            lblwarna.Text = Rd!warna
            lblnorangka.Text = Rd!no_rangka
            lblnomesin.Text = Rd!no_mesin
            txtharga.Text = Rd!harga_jual
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lbltotal.Text = Val(txtjumlah.Text) * Val(txtharga.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Silakan Isi dulu")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO `tbl_penjualan` values ('" & TextBox1.Text & "','" & DateTimePicker1.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & lblnorangka.Text & "','" & lblnomesin.Text & "','" & txtjumlah.Text & "','" & lbltotal.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Success")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub
End Class