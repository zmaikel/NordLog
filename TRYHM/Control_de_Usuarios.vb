
Public Class Control_de_Usuarios
    Dim nuevaConexion As New Conexion


    Sub refrescar()
        nuevaConexion.LimpiarGrid(DataGridUsers)
        ''nuevaConexion.ComandoSQL2("Exec Mostrar_Users")
        nuevaConexion.ComandoSQL("select * from Empleados", "Empleados", 1)
    End Sub


    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        refrescar()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Seleccion.Show()
        Me.Close()
    End Sub

    Private Sub btnSent_Click(sender As Object, e As EventArgs) Handles btnSent.Click

        Dim nuevapersona As New Datos()
        nuevapersona.nombre = txtname.Text
        nuevapersona.apellido1 = txtapellido1.Text
        nuevapersona.apellido2 = txtapellido2.Text
        nuevapersona.identificacion = txtidentificacion.Text


        nuevaConexion.ComandoSQL(" DBCC CHECKIDENT ('Empleados', RESEED,0) DBCC CHECKIDENT ('Empleados', RESEED)", "Empleados", 1)
        nuevaConexion.ComandoSQL("insert into Empleados(EMP_NOMBRE,EMP_APELLIDO1,EMP_APELLIDO2,EMP_IDENTIFICACION)VALUES('" + txtname.Text + "','" + txtapellido1.Text + "','" + txtapellido2.Text + "','" + txtidentificacion.Text + "')", "Empleados", 1)
        refrescar()
        LimpiezaTXT()


    End Sub
    Sub LimpiezaTXT()
        txtapellido1.Clear()
        txtapellido2.Clear()
        txtname.Clear()
        txtidentificacion.Clear()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim ideliminar As String
        ideliminar = DataGridUsers.CurrentCell.Value.ToString()
        nuevaConexion.ComandoSQL("delete from Empleados where EMP_ID=" + ideliminar, "Empleados", 1)
        refrescar()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim newSC As New Datos
        Dim idupdate As String
        idupdate = DataGridUsers.CurrentCell.Value.ToString()
        nuevaConexion.ComandoSQL("update Empleados set EMP_Nombre='" + txtname.Text + "',EMP_APELLIDO1='" + txtapellido1.Text + "',EMP_APELLIDO2= '" + txtapellido2.Text + "',EMP_IDENTIFICACION='" + txtidentificacion.Text + "'where EMP_ID=" + idupdate, "Empleados", 1)
        refrescar()
        LimpiezaTXT()
    End Sub
End Class