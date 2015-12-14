Imports System
Imports System.IO
Imports System.Net
'Imports System.Text
Imports Newtonsoft.Json
'Imports Newtonsoft.Json.Linq
''' <summary>
''' Object for easy handling of JSON
''' </summary>
''' <remarks></remarks>
Public Module Z_JSON

    Public Function WebToObject(Of t)(URL As String)
        ' Create a request for the URL. 
        Dim request As WebRequest = WebRequest.Create(URL)
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
        Console.WriteLine("WebResponse: " & responseFromServer)
        ' Clean up the streams and the response.
        reader.Close()
        response.Close()

        ' Return the object.
        Return JsonConvert.DeserializeObject(Of t)(responseFromServer)

    End Function
    ''' <summary>
    ''' Assembles argumnets belonging to a URL
    ''' </summary>
    ''' <param name="argDictionary"></param>
    ''' <returns>?arg1=1;arg2</returns>
    ''' <remarks>Not Implemented Yet</remarks>
    Private Function ArgAssebly(ByVal argDictionary As Dictionary(Of String, String)) As String
        ' Make Dictionary into a list
        Dim argList As List(Of KeyValuePair(Of String, String)) = argDictionary.ToList()
        'Dim pairList As List(Of String)
        For Each pair As KeyValuePair(Of String, String) In argList
            Dim content As String = pair.Key & "="
            'pairList.Add(content)
        Next

        Throw New NotImplementedException
        Return Nothing
    End Function
End Module
