Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports ZEKE_JSON

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JSONWEBTEST()
    End Sub

    Public Class Joke
        Public type As String
        Public value As New ValueObj
        Public Class ValueObj
            Public id As Integer
            Public joke As String
        End Class
    End Class

    Private Sub JSONWEBTEST()
        Dim URL As String = "http://api.icndb.com/jokes/random"
        Dim Chuck As New Joke

        Chuck = Z_JSON.WebToObject(Of Joke)(URL)
        ContentBox.Text = Chuck.value.joke
        ContentBox.Text = ContentBox.Text.Replace("&quot;", "'")
        JokeID.Text = "Joke: " & Chuck.value.id
    End Sub


    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        JSONWEBTEST()
    End Sub

End Class
