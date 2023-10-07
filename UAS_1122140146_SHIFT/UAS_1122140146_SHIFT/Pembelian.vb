Imports System.Data.Odbc
Public Class Pembelian

    Private Sub Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From tbl_pembelian", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "tbl_pembelian")
        DataGridView1.DataSource = Ds.Tables("tbl_pembelian")
        DataGridView1.ReadOnly = True
    End Sub
End Class