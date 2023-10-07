Imports System.Data.Odbc
Public Class Penjualan

    Private Sub Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From tbl_penjualan", Conn)
        Ds = New DataSet()
        Da.Fill(Ds, "tbl_penjualan")
        DataGridView1.DataSource = Ds.Tables("tbl_penjualan")
        DataGridView1.ReadOnly = True
    End Sub
End Class