Imports System.Data.Odbc

Module ModulKoneksi
    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String

    Public Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 3.51 Driver};server=localhost;database=dbinventorymobil;uid=root;password=;"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
