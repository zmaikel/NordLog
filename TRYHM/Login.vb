Imports System.Data.SqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim conexion As New SqlConnection("Server= DESKTOP-JH043U3\SQLEXPRESS; Database = LimpiezaBD; Integrated Security = true")

        Dim command As New SqlCommand("select * from  [dbo].[Usuarios] where USER_NAME =@usuarios and USER_PASSWORD = @pass", conexion)

        command.Parameters.Add("@usuarios", SqlDbType.VarChar).Value = txtuser.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Username Or Password Are Invalid")
            REFRESCAR()
        Else

            MessageBox.Show("Login Successfully")

            Me.Hide()
            Seleccion.Show()
            REFRESCAR()
        End If

    End Sub

    Sub REFRESCAR()
        txtuser.Text = ""
        txtpassword.Text = ""
    End Sub
End Class