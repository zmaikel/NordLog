Imports System.Data.SqlClient
Public Class Conexion

    ''Dim cadena = "Data Source=CR5CG63022NR\MSSQLSERVER01;Initial Catalog=PruebaCone;User ID= sa;Password=contraseña"
    Dim cadena = "Data Source=DESKTOP-JH043U3\SQLEXPRESS;Initial Catalog=LimpiezaBD;Integrated Security = True"

    Dim conexion As New SqlConnection(cadena)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim ds As New DataSet


    Public Sub ComandoSQL(ByVal codigoSql1 As String, ByVal tablas As String, ByVal formulario As Integer)

        cmd.Connection = conexion
        cmd.CommandText = codigoSql1 'parametro
        conexion.Open()
        dr = cmd.ExecuteReader()
        ds.Load(dr, LoadOption.PreserveChanges, (tablas))

        Select Case (formulario)
            Case 1

                Control_de_Usuarios.DataGridUsers.DataSource = ds.Tables(tablas)

        End Select


        dr.Close()

        conexion.Close()
    End Sub
    Public Sub ComandoSQL2(ByVal codigoSql1 As String)

        cmd.Connection = conexion
        cmd.CommandText = codigoSql1 'parametro
        conexion.Open()
        dr = cmd.ExecuteReader()



        conexion.Close()
    End Sub

    Public Sub LimpiarGrid(ByVal GridALimpiar As DataGridView)
        Dim dt As DataTable
        dt = CType(GridALimpiar.DataSource, DataTable)
        Try
            dt.Rows.Clear()
        Catch
        End Try
    End Sub

End Class

