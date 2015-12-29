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
        Dim URL As String = "http://api.icndb.com/jokes/random?exclude=[explicit]"
        Dim Chuck As New Joke

        'URL = Nothing 
        'HACK: Set URL to Nothing in order to trigger an ArgumentNullException. Removable.
        Try
            Chuck = Z_JSON.WebToObject(Of Joke)(URL)
        Catch e As ArgumentNullException
            SetFormValues("404: Chuck Not Found", "404")
            Return
        End Try
        SetFormValues(Chuck.value.joke, Chuck.value.id)
    End Sub

    Private Sub SetFormValues(ByVal unsafeText As String, ByVal id As String)

        Dim safetext As String = System.Net.WebUtility.HtmlDecode(unsafeText)
        ContentBox.Text = safetext
        JokeID.Text = "Joke: " & id
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAdress As String = "http://www.icndb.com/"
        Process.Start(webAdress)
    End Sub
End Class
