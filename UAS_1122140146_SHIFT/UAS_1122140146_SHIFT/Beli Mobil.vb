Imports System.Data.Odbc
Public Class Beli_Mobil
    Sub KondisiAwal()
        lblnamasupp.Text = ""
        lblalamatsup.Text = ""
        lblteleponsup.Text = ""
        lbljenis.Text = ""
        lblnomesin.Text = ""
        DateTimePicker1.Text = Today
        lblnorangka.Text = ""
        txtharga.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
       
    End Sub

    Sub MunculSupplier()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from supplier", Conn)
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
    
    Private Sub Beli_Mobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call MunculMobil()
        Call MunculSupplier()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from supplier where id_supplier ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lblnamasupp.Text = Rd!nama_supplier
            lblalamatsup.Text = Rd!alamat_supplier
            lblteleponsup.Text = Rd!telp_supplier
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from mobil_supplier where kd_jenis ='" & ComboBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lbljenis.Text = Rd!jenis_s
            lbltipe.Text = Rd!tipe_s
            lblwarna.Text = Rd!warna_s
            lblnorangka.Text = Rd!no_rangka
            lblnomesin.Text = Rd!no_mesin
            txtharga.Text = Rd!harga_jual
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lbltotal.Text = Val(txtjumlah.Text) * Val(txtharga.Text) * 500000
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Silakan Isi dulu")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO `tbl_pembelian` values ('" & TextBox1.Text & "','" & DateTimePicker1.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & lblnorangka.Text & "','" & lblnomesin.Text & "','" & txtjumlah.Text & "','" & lbltotal.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Success")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub lbltotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotal.Click

    End Sub
End Class