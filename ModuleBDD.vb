Imports System.Data.OleDb

Module ModuleBDD

    ' ── Chaîne de connexion ───────────────────────────────────
    Private ReadOnly CheminBDD As String =
        IO.Path.Combine(Application.StartupPath, "GestNotes.accdb")

    Public ReadOnly Property ConnexionString As String
        Get
            Return "Provider=Microsoft.ACE.OLEDB.12.0;" &
                   "Data Source=" & CheminBDD & ";"
        End Get
    End Property

    ' ── Obtenir une connexion ouverte ─────────────────────────
    Public Function GetConnexion() As OleDbConnection
        Dim conn As New OleDbConnection(ConnexionString)
        conn.Open()
        Return conn
    End Function

    ' ── Tester la connexion ───────────────────────────────────
    Public Function TesterConnexion() As Boolean
        Try
            Using conn = GetConnexion()
                Return conn.State = ConnectionState.Open
            End Using
        Catch ex As Exception
            MsgBox("Erreur de connexion BDD :" & vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur BDD")
            Return False
        End Try
    End Function

    ' ── Exécuter une requête sans retour (INSERT/UPDATE/DELETE)
    Public Function ExecuterRequete(sql As String,
                                    ParamArray params() As OleDbParameter) As Boolean
        Try
            Using conn = GetConnexion()
                Using cmd As New OleDbCommand(sql, conn)
                    If params IsNot Nothing Then
                        cmd.Parameters.AddRange(params)
                    End If
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de l'opération :" & vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur BDD")
            Return False
        End Try
    End Function

    ' ── Obtenir un DataTable (SELECT) ─────────────────────────
    Public Function GetDataTable(sql As String,
                                 ParamArray params() As OleDbParameter) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnexion()
                Using cmd As New OleDbCommand(sql, conn)
                    If params IsNot Nothing Then
                        cmd.Parameters.AddRange(params)
                    End If
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erreur de lecture BDD :" & vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur BDD")
        End Try
        Return dt
    End Function

    ' ── Obtenir une valeur unique (COUNT, MAX...) ─────────────
    Public Function GetValeur(sql As String,
                               ParamArray params() As OleDbParameter) As Object
        Try
            Using conn = GetConnexion()
                Using cmd As New OleDbCommand(sql, conn)
                    If params IsNot Nothing Then
                        cmd.Parameters.AddRange(params)
                    End If
                    Return cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Module