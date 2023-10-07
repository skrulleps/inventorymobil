Imports System.Data.Odbc
Public Class MDIUTAMA
    Private Sub ToolStripContainer1_ContentPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        Supplier.MdiParent = Me
        Supplier.Show()
    End Sub

    Private Sub MobilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Konsumen.MdiParent = Me
        Konsumen.Show()
    End Sub

    Private Sub MobilToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MobilToolStripMenuItem1.Click
        Mobil.MdiParent = Me
        Mobil.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        Penjualan.MdiParent = Me
        Penjualan.Show()
    End Sub

    Private Sub BELIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub JualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Jual_Mobil.MdiParent = Me
        Jual_Mobil.Show()
    End Sub

    Private Sub MobilToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click

    End Sub

    Private Sub MDIUTAMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub DataMobilSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataMobilSupplierToolStripMenuItem.Click
        Data_Mobil_Supplier.MdiParent = Me
        Data_Mobil_Supplier.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        Pembelian.MdiParent = Me
        Pembelian.Show()
    End Sub

    Private Sub KonsumenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KonsumenToolStripMenuItem.Click
        Konsumen.MdiParent = Me
        Konsumen.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
