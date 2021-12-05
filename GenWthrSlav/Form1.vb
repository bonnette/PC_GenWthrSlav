Imports WinSCP
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

' This Windows application uses "SCP" to copy the wthr.dat file from a Raspberry Pi weather client to the windows system running this app.
' The wthr.dat file contains local weather information that was gathered from a local weather website. This data is formatted as JSON and looks like this:
'
'{"lat":30.22,"lon":-95.36,"timezone":"America/Chicago","timezone_offset":-21600,"current":{"dt":1637771625,"sunrise":1637758495,"sunset":1637796116,
'"temp":73.26,"feels_like":73.58,"pressure":1019,"humidity":70,"dew_point":62.89,"uvi":1.08,"clouds":98,"visibility":10000,"wind_speed":10,"wind_deg":65,
'"wind_gust":13,"weather":[{"id":804,"main":"Clouds","description":"overcast clouds","icon":"04d"}]}}
'
' The reason we copy data from a local Raspberry pi is to save money. The source website only allows 60 copies of its data for free.
'
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear the JSON text field and all other labels then prepare SCP to copy data.
        lbl_dwnloaded.Text = ""
        'lbl_deg.Text = ""
        'lbl_feels.Text = ""
        'lbl_gust.Text = ""
        'lbl_humid.Text = ""
        'lbl_presinch.Text = ""
        'lbl_press.Text = ""
        'lbl_speed.Text = ""
        'lbl_temp.Text = ""
        Try

            ' Set up session options
            Dim sessionOptions As New SessionOptions
            With sessionOptions
                .Protocol = Protocol.Sftp
                .HostName = "Pi Hostname"
                .UserName = "Pi Username"
                .Password = "Pi Password"
                .SshHostKeyFingerprint = "ssh-ed25519 255 xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx="
            End With
            ' Connect to the Raspberry Pi
            Using session As New Session
                ' Connect
                session.Open(sessionOptions)

                ' Download files
                Dim transferOptions As New TransferOptions
                transferOptions.TransferMode = TransferMode.Binary

                Dim transferResult As TransferOperationResult
                transferResult =
                    session.GetFiles("/home/pi/wthr.dat", "C:\Users\bonne\Desktop\", False, transferOptions)

                ' Throw on any error
                transferResult.Check()

                ' Print results
                For Each transfer In transferResult.Transfers
                    Console.WriteLine("Download of {0} succeeded", transfer.FileName)
                Next
            End Using


        Catch a As Exception
            Console.WriteLine("Error: {0}", a)
        End Try
        ' We have just copied the JSON filled weather  file from the Pi we will now read the contents of the file into "fileReader" Then display the contents of
        ' "fileReader" in the large label in the App.

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\bonne\Desktop\wthr.dat")
        lbl_dwnloaded.Text = fileReader
        'MsgBox(fileReader)

        ' Now we parse the contents of fileReader in order to get all of the weather information out of it.

        ' Set up variables for wind direction conversion
        Dim deg As Double
        Dim ndeg As String
        Dim jsonObject As JObject = JObject.Parse(fileReader)
        ' Display the temperature, humidity, Wind speed and direction ETC.
        lbl_temp.Text = "Temp: " & jsonObject.SelectToken("current.temp").ToString
        lbl_humid.Text = "Humidity: " & jsonObject.SelectToken("current.humidity").ToString & "%"
        lbl_feels.Text = "Feels Like: " & jsonObject.SelectToken("current.feels_like").ToString

        ' Convert Wind direction in compass degrees to text (North, South, East Etc.)
        deg = jsonObject.SelectToken("current.wind_deg")
        ndeg = DirCalc(deg) ' Do the conversion and put it in the wind direction label
        lbl_deg.Text = "Dir: " & ndeg

        lbl_speed.Text = "Speed: " & FormatNumber(jsonObject.SelectToken("current.wind_speed").ToString, 1) ' Display speed with only 1 digit after the decimal 

        ' Sometimes the weather service does not send "current.wind_gust" information. So, we must
        ' test to see if it exsists, then deal with the resuluts.

        If jsonObject.SelectToken("current.wind_gust") Is Nothing Then
            lbl_gust.Text = "Gust: 0"
        Else
            lbl_gust.Text = "Gust: " & FormatNumber(jsonObject.SelectToken("current.wind_gust").ToString, 1) ' Display gust with only 1 digit after the decimal
        End If
        lbl_press.Text = jsonObject.SelectToken("current.pressure").ToString & " Millibars" ' Pressure in HGA
        Dim InchPress As Double
        InchPress = jsonObject.SelectToken("current.pressure")
        'lbl_presinch.Text = (FormatNumber((InchPress / 33.863), 2)).ToString & " Inches" ' Pressure in Inches displayed with only 2 digits after the decimal
        lbl_presinch.Text = (FormatNumber(((InchPress * 0.295301) / 10), 2)).ToString & " Inches" ' Pressure in Inches displayed with only 2 digits after the decimal
    End Sub

    ' Wind direction conversion function returns string with wind direction in it
    Public Shared Function DirCalc(x)

        Select Case (x)
            Case 0 To 22
                'MsgBox(x)
                Return "North"
            Case 22 To 45
                Return "NNE"
            Case 45 To 67
                Return "NE"
            Case 67 To 90
                Return "ENE"
            Case 90 To 112
                Return "East"
            Case 112 To 135
                Return "ESE"
            Case 135 To 157
                Return "SE"
            Case 157 To 180
                Return "SSE"
            Case 180 To 202
                Return "South"
            Case 202 To 225
                Return "SW"
            Case 225 To 247
                Return "SW"
            Case 247 To 270
                Return "WSW"
            Case 270 To 292
                Return "West"
            Case 292 To 315
                Return "WNW"
            Case 315 To 337
                Return "NW"
            Case 337 To 359
                Return "NNW"
            Case Else
                Return "No Dir"
        End Select

    End Function
End Class

