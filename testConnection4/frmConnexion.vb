Imports MySql.Data.MySqlClient

Public Class frmConnexion

    Dim cmd As New MySqlCommand
    Dim myReader As MySqlDataReader
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String

    Public password As String
    Public uid As String

    Private Sub login() Handles btnConnexion.Click
        uid = txtLogin.Text
        password = txtPassword.Text

        Try
            myConnectionString = "server=localhost;" _
                    & "uid=" & uid & ";" _
                    & "pwd=" & password & ";" _
                    & "database=sakila"
            conn.ConnectionString = myConnectionString
            conn.Open()
            conn.Close()
            frmAccueil.Show()
            Me.Hide()

        Catch ex As Exception
            txtLogin.Text = ""
            txtPassword.Text = ""
            MessageBox.Show("Erreur d'identifiant")
        End Try
    End Sub

    Private Sub Quit(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class