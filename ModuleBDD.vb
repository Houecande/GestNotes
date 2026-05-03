Imports System.Data.OleDb

Module ModuleBDD

    ' Chemin fixe vers le dossier bin\Debug
    Private ReadOnly CheminBDD As String =
        IO.Path.Combine(Application.StartupPath, "GestNotes.accdb")

    Public ReadOnly Property ConnexionString As String
        Get
            Return "Provider=Microsoft.ACE.OLEDB.12.0;" &
                   "Data Source=" & CheminBDD & ";" &
                   "Persist Security Info=False;"
        End Get
    End Property

    ' Vérifier que le fichier existe
    Public Function FichierBDDExiste() As Boolean
        If Not IO.File.Exists(CheminBDD) Then
            MsgBox("Fichier BDD introuvable !" & vbCrLf &
                   "Chemin : " & CheminBDD,
                   MsgBoxStyle.Critical, "BDD introuvable")
            Return False
        End If
        Return True
    End Function

    Public Function GetConnexion() As OleDbConnection
        Dim conn As New OleDbConnection(ConnexionString)
        conn.Open()
        Return conn
    End Function

    Public Function TesterConnexion() As Boolean
        Try
            If Not FichierBDDExiste() Then Return False
            Using conn = GetConnexion()
                Return conn.State = ConnectionState.Open
            End Using
        Catch ex As Exception
            MsgBox("Erreur connexion BDD :" & vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur BDD")
            Return False
        End Try
    End Function

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
            MsgBox("Erreur opération :" & vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur BDD")
            Return False
        End Try
    End Function

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
            MsgBox("Erreur lecture BDD :" & vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur BDD")
        End Try
        Return dt
    End Function

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