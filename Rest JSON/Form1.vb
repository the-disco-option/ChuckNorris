Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports ZEKE_JSON

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetJoke()
    End Sub
    ''' <summary>
    ''' A Joke
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Joke
        Public type As String
        Public value As New ValueObj
        Public Class ValueObj
            Public id As Integer
            Public joke As String
        End Class
    End Class
    ''' <summary>
    ''' Get a random joke.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetJoke()
        Dim URL As String = "http://api.icndb.com/jokes/random"
        Dim Chuck As New Joke

        Chuck = Z_JSON.WebToObject(Of Joke)(URL)
        ContentBox.Text = Chuck.value.joke
        ContentBox.Text = ContentBox.Text.Replace("&quot;", Chr(34))
        JokeID.Text = "Joke: " & Chuck.value.id
    End Sub

    ''' <summary>
    ''' The New button was pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        GetJoke()
    End Sub
    ''' <summary>
    ''' The Copy button was clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Clipboard.SetText(ContentBox.Text)
    End Sub
End Class
