Module ModuleSession
    Public Profil As String = ""
    Public LoginUtilisateur As String = ""

    Public ReadOnly Property EstAdmin As Boolean
        Get
            Return Profil = "Administrateur"
        End Get
    End Property
End Module