Imports System.Data.Odbc
Public Class Mobil

    Sub KondisiAwal()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From tbl_mobil", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "tbl_mobil")
        DataGridViewtbl_mobil.DataSource = Ds.Tables("tbl_mobil")
        DataGridViewtbl_mobil.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_dtkonsumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Mobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Beli_Mobil.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Jual_Mobil.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Call KondisiAwal()
    End Sub
End Class