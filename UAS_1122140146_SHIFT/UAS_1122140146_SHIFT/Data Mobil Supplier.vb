Imports System.Data.Odbc
Public Class Data_Mobil_Supplier

    Private Sub Data_Mobil_Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * from mobil_supplier where id_supplier='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Id Supplier Tidak ada")
            Else
                TextBox1.Enabled = False
                Call Koneksi()
                Da = New OdbcDataAdapter("Select * From mobil_supplier", Conn)
                Ds = New DataSet()
                Da.Fill(Ds, "mobil_supplier")
                DataGridViewDMS.DataSource = Ds.Tables("mobil_supplier")
                DataGridViewDMS.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class