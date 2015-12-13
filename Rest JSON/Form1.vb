Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JSONWEBTEST()
        JSONTEST()
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
        Dim Chuck As New Joke
        ' Create a request for the URL. 
        Dim request As WebRequest = WebRequest.Create("http://api.icndb.com/jokes/random")

        ' If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        'Dim responseFromServer As String = reader.ReadToEnd()
        Console.WriteLine(responseFromServer)
        'HACK We don't need a list or an array
        Chuck = JsonConvert.DeserializeObject(Of Joke)(responseFromServer)
        'Dim result = serial.Deserialize(responseFromServer)
        ContentBox.Text = Chuck.value.joke
        ContentBox.Text = ContentBox.Text.Replace("&quot;", "'")
        JokeID.Text = "Joke: " & Chuck.value.id
        ' Clean up the streams and the response.
        reader.Close()
        response.Close()
    End Sub

    Public Class Account
        Public Email As String
        Public Active As Boolean
    End Class

    Private Sub JSONTEST()
        Dim json As String = "{'Email': 'james@example.com','Active': true}"
        Dim account As Account = New Account()
        Dim testObject As Object = New Object()
        testObject = JsonConvert.DeserializeObject(json)
        account = JsonConvert.DeserializeObject(Of Account)(json)
        Console.WriteLine(account.Email)
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        JSONWEBTEST()
    End Sub

End Class
