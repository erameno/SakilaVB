Imports MySql.Data.MySqlClient

Public Class frmAccueil
    Private Sub frmAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login()
    End Sub

    Dim idList As New ArrayList
    Dim idFilmList As New ArrayList

    Dim cmd As New MySqlCommand
    Dim myReader As MySqlDataReader
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection

    Dim uid As String = frmConnexion.uid
    Dim password As String = frmConnexion.password

    Dim myConnectionString As String
    Dim actorId As String
    Dim id As String = ""

    Dim categ As String = ""
    Dim categId As String = ""
    Dim langueId As String = ""

    Private Sub login()
        Try
            myConnectionString = "server=localhost;" _
                    & "uid=" & uid & ";" _
                    & "pwd=" & password & ";" _
                    & "database=sakila"
            conn.ConnectionString = myConnectionString
            conn.Open()
            Connexion()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Connexion()
        Try
            'Affichage de la liste des acteurs par ordre alphabétique
            cmd.CommandText = "SELECT first_name, last_name, actor_id FROM actor ORDER BY first_name ASC"
            cmd.Connection = conn
            myReader = cmd.ExecuteReader()
            Try
                While myReader.Read()
                    lst1.Items.Add(myReader.GetString(0) + " " + myReader.GetString(1))
                    idList.Add(myReader.GetString(2))
                End While
            Finally
                myReader.Close()
            End Try

            'Affichage de la liste des catégories
            cmd.CommandText = "SELECT name FROM category"
            cmd.Connection = conn
            myReader = cmd.ExecuteReader()
            Try
                While myReader.Read()
                    lstCateg.Items.Add(myReader.GetString(0))
                End While
            Finally
                myReader.Close()
            End Try


        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ActuFilm() Handles lst1.Click
        Try
            'Si aucun acteur n'est sélectionné, on ne fait rien

            If lst1.SelectedIndex.ToString IsNot Nothing Then
                id = idList((lst1.SelectedIndex)).ToString
            End If

        Catch ex As Exception

            id = ""
        End Try

        'If lstCateg.SelectedItem.ToString IsNot Nothing Then
        'categ = lstCateg.SelectedItem.ToString
        ' End If

        'Efface les listes d'acteurs et de film
        dGV1.Rows.Clear()
        idFilmList.Clear()
        Dim nbFilm As Integer = 0

        Try
            ActuActeur(id)
            Try
                cmd.CommandText = "SELECT DISTINCT title, fdescription, release_year, film.film_id FROM film JOIN film_actor ON film.film_id = " _
                                    & "film_actor.film_id JOIN film_category ON film.film_id = film_category.film_id WHERE film_actor.actor_id LIKE  '%" + id + "%' AND category_id LIKE '%" + categId + "%'"
                cmd.Connection = conn
                myReader = cmd.ExecuteReader()
                While myReader.Read()
                    dGV1.Rows.Add(myReader.GetString(0))
                    idFilmList.Add(myReader.GetString(3))
                    nbFilm += 1
                End While
            Finally
                myReader.Close()
                txtNbFilm.Text = "L'acteur a jouer dans : " + nbFilm.ToString + " films"
            End Try
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Quitte l'application
    Private Sub Quit(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmConnexion.Close()
    End Sub
    'Retourne à l'accueil
    Private Sub Accueil(sender As Object, e As EventArgs) Handles btnAccueil.Click
        Me.Close()
        frmConnexion.Show()
    End Sub

    Private Sub Recherche(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged
        'Efface la liste des acteurs
        lst1.Items.Clear()
        Try
            cmd.CommandText = "SELECT first_name, last_name FROM actor WHERE first_name LIKE '%" + txtRecherche.Text + "%' OR last_name LIKE '%" + txtRecherche.Text + "%' ORDER BY first_name ASC"
            cmd.Connection = conn
            myReader = cmd.ExecuteReader()
            While myReader.Read()
                lst1.Items.Add(myReader.GetString(0) + " " + myReader.GetString(1))
            End While
        Catch ex As MySql.Data.MySqlClient.MySqlException
            txtRecherche.Text = ""
            MessageBox.Show("erreur : pas de caractère spéciaux")
        Finally
            myReader.Close()
        End Try
    End Sub

    Dim idFilm As String = ""
    Private Sub SelectionCell(sender As Object, e As DataGridViewCellEventArgs) Handles dGV1.CellClick
        txtModif.Enabled = True
        Dim cell As DataGridViewCell = dGV1.CurrentCell
        idFilm = idFilmList((cell.RowIndex)).ToString
        txtModif.Text = cell.Value
    End Sub

    Private Sub Modifier() Handles btnModif.Click
        Try
            cmd.CommandText = "UPDATE film set title = '" + txtModif.Text + "' Where film_id = '" + idFilm + "'"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("erreur")
        Finally
            ActuFilm()
        End Try
    End Sub

    Private Sub AjoutActeur(sender As Object, e As EventArgs) Handles btnAjoutActeur.Click
        frmAjoutActeur.Show()
    End Sub

    Private Sub AjoutFilm(sender As Object, e As EventArgs) Handles btnAjoutFilm.Click
        frmAjoutFilm.Show()
    End Sub

    Private Sub ModifNomActeur() Handles btnModifNom.Click
        Try
            cmd.CommandText = "UPDATE actor set last_name = '" + txtModifNom.Text + "' Where actor_id = '" + id + "'"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("erreur")
        Finally
            ActuFilm()
            ActuListActeur()
        End Try
    End Sub

    Public Sub ActuListActeur()
        lst1.Items.Clear()
        Try
            cmd.CommandText = "SELECT first_name, last_name FROM actor ORDER BY first_name ASC"
            cmd.Connection = conn
            myReader = cmd.ExecuteReader()
            While myReader.Read()
                lst1.Items.Add(myReader.GetString(0) + " " + myReader.GetString(1))
            End While
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myReader.Close()
        End Try
    End Sub

    Private Sub ActuActeur(id As String)
        dGVActeur.Rows.Clear()
        Try
            cmd.CommandText = "SELECT first_name, last_name, actor_id FROM actor WHERE actor_id = '" + id + "'"
            cmd.Connection = conn
            myReader = cmd.ExecuteReader()
            While myReader.Read()
                Dim ligne As DataGridViewRow
                Dim cel1 As New DataGridViewTextBoxCell
                Dim cel2 As New DataGridViewTextBoxCell

                cel1.Value = myReader.GetString(0)
                cel2.Value = myReader.GetString(1)

                txtModifPrenom.Text = myReader.GetString(0)
                txtModifNom.Text = myReader.GetString(1)

                txtModifNom.Enabled = True
                txtModifPrenom.Enabled = True

                ligne = New DataGridViewRow
                ligne.Cells.Add(cel1)
                ligne.Cells.Add(cel2)

                dGVActeur.Rows.Add(ligne)
            End While
        Finally
            myReader.Close()
        End Try
    End Sub

    Private Sub SelectionCateg(sender As Object, e As EventArgs) Handles lstCateg.Click
        If lstCateg.SelectedItem.ToString IsNot Nothing Then
            categ = lstCateg.SelectedItem.ToString
        End If

        Try
            cmd.CommandText = "SELECT category_id FROM category WHERE name = '" + lstCateg.SelectedItem.ToString + "'"
            cmd.Connection = conn
            myReader = cmd.ExecuteReader()
            While myReader.Read()
                categId = myReader.GetString(0)
            End While

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        Finally
            myReader.Close()
            ActuFilm()
        End Try
    End Sub

    Private Sub ModifNomActeur(sender As Object, e As EventArgs) Handles btnModifNom.Click

    End Sub

    Private Sub btnDesecCateg_Click(sender As Object, e As EventArgs) Handles btnDesecCateg.Click
        lstCateg.ClearSelected()
        categId = ""
        ActuFilm()
    End Sub

    Private Sub btnDesecFilm_Click(sender As Object, e As EventArgs) Handles btnDesecFilm.Click
        lst1.ClearSelected()
        id = ""
        ActuFilm()
    End Sub
End Class