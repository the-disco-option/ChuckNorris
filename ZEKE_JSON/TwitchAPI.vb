Public Module TwitchAPI
    'Wishlist:
    'IsChannelOnline(channel)
    'MostPopularChannels[n]
    'MostPopularGames[n]
    '
    Private Class Preview
        Public Property small As String
        Public Property medium As String
        Public Property large As String
        Public Property template As String
    End Class

    Private Class Channel
        Public Property mature As Boolean
        Public Property status As String
        Public Property broadcaster_language As String
        Public Property display_name As String
        Public Property game As String
        Public Property language As String
        Public Property _id As Integer
        Public Property name As String
        Public Property created_at As DateTime
        Public Property updated_at As DateTime
        Public Property delay As Object
        Public Property logo As String
        Public Property banner As Object
        Public Property video_banner As String
        Public Property background As Object
        Public Property profile_banner As String
        Public Property profile_banner_background_color As String
        Public Property partner As Boolean
        Public Property url As String
        Public Property views As Integer
        Public Property followers As Integer
        Public Property _links As Dictionary(Of String, String)
    End Class

    Private Class TStream
        Public Property _id As Long
        Public Property game As String
        Public Property viewers As Integer
        Public Property created_at As DateTime
        Public Property video_height As Integer
        Public Property average_fps As Double
        Public Property delay As Integer
        Public Property is_playlist As Boolean
        Public Property _links As Dictionary(Of String, String)
        Public Property preview As Preview
        Public Property channel As Channel
    End Class

    Private Class JSON_Stream
        Public Property stream As TStream
        Public Property _links As Dictionary(Of String, String)
    End Class

    Private Class JSON_Popular
        Public Property streams As List(Of TStream)
        Public Property _links As Dictionary(Of String, String)
        Public Property _total As Integer
    End Class
    Private Property streamsURL
        Get
            Return "https://api.twitch.tv/kraken/streams/"
        End Get

        Set(value)
            todo()
        End Set

    End Property
    Public Function IsChannelOnline(channel As String) As Boolean
        Dim streamObj As New JSON_Stream
        streamObj = WebToObject(Of JSON_Stream)(streamsURL & channel)
        Return Not IsNothing(streamObj.stream)

    End Function

    Public Function MostPopluarChannels(ByVal n As Integer) As List(Of String)
        Dim streamObj As New JSON_Popular
        Dim list As New List(Of String)

        'Get Streams

        streamObj = WebToObject(Of JSON_Popular)(streamsURL & "?limit=" & n)
        
        'Populate list
        For Each stream In streamObj.streams
            list.Add(stream.channel.display_name)

        Next
        Return list
    End Function

    Private Sub todo()
        Throw New NotImplementedException
    End Sub
End Module
