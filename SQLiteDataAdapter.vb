Imports Microsoft.Data.Sqlite
Imports System.Data

Friend Class SQLiteDataAdapter
    Private v As String
    Private conn As SqliteConnection

    Public Sub New(v As String, conn As SqliteConnection)
        Me.v = v
        Me.conn = conn
    End Sub

    Friend Sub Fill(dt As DataTable)
        Using cmd As New SqliteCommand(v, conn)
            Using reader As SqliteDataReader = cmd.ExecuteReader()
                dt.Clear()
                dt.Load(reader)
            End Using
        End Using
    End Sub
End Class
