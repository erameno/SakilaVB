Imports MySql.Data.MySqlClient

Public Class frmAjoutActeur
    Dim cmd As New MySqlCommand
    Dim myReader As MySqlDataReader
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection

    Dim uid As String = frmConnexion.uid
    Dim password As String = frmConnexion.password

    Dim myConnectionString As String
    Private Sub login()
        Try
            myConnectionString = "server=localhost;" _
                    & "uid=" & uid & ";" _
                    & "pwd=" & password & ";" _
                    & "database=sakila"
            conn.ConnectionString = myConnectionString
            conn.Open()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmAjoutActeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConfirmation.Visible = False
        login()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Try
            cmd.CommandText = "INSERT into actor (`actor_id`, `first_name`, `last_name`, `last_update`) VALUES (NULL, '" + txtPrenom.Text + "', '" + txtNom.Text + "', CURRENT_TIMESTAMP)"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("erreur")
        Finally
            conn.Close()
            txtPrenom.Text = ""
            txtNom.Text = ""
            lblConfirmation.Visible = True
            btnAjout.Enabled = False
            frmAccueil.ActuListActeur()
        End Try
    End Sub
End Class