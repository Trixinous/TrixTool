'Copyright 2023 - Trixinous
'With thanks to MCServerStaus for their awesome API :)

Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports System.Drawing.Imaging
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String = txtHostname.Text

        'Clear all values to give the visual recognition that the form has refreshed on button click
        DownloadBar.Value = 0
        'txtHostname.Text = Nothing
        txtPort.Text = Nothing
        txtMOTD.Text = Nothing
        txtPlayers.Text = Nothing
        txtOnlinePlayers.Text = Nothing
        txtMaxPlayers.Text = Nothing
        txtUUIDs.Text = Nothing
        picIcon.Image = Nothing


        'Download the data from the website
        Dim webClient As New WebClient()
        Dim rawData As String = ""
        Try
            rawData = webClient.DownloadString("https://api.mcsrvstat.us/2/" & userInput)
        Catch
        End Try
        DownloadBar.Increment(33)
        'Parse the JSON data
        If rawData <> Nothing Then
            Dim data As JObject = JObject.Parse(rawData)
            DownloadBar.Increment(33)
            'Extract the required information
            Dim online As String = data("online").ToString()
            If online = "True" Then
                Dim hostname As String = data("hostname").ToString()
                Dim Version As String = data("version").ToString
                Dim port As Integer = data("port").ToObject(Of Integer)()
                Dim motd As String = data("motd")("clean")(0).ToString()
                Dim players As JArray = data("players")("list")
                Dim onlinePlayers As Integer = data("players")("online").ToObject(Of Integer)()
                Dim maxPlayers As Integer = data("players")("max").ToObject(Of Integer)()
                Dim uuids As JObject = data("players")("uuid")





                Dim base64StringinASCII As String
                base64StringinASCII = data("icon")
                If base64StringinASCII <> Nothing Then
                    base64StringinASCII = base64StringinASCII.ToString
                    Dim base64String As String = base64StringinASCII.Trim
                    base64String = base64String.Replace("\", "")
                    base64String = base64String.Replace("data:image/png;base64,", "")
                    Dim imageData As Byte() = Convert.FromBase64String(base64String)
                    'creating a memory stream from the byte array
                    Using ms As New MemoryStream(imageData)
                        Dim bmp As New Bitmap(ms)
                        bmp.Save("icon.png", ImageFormat.Png)
                        picIcon.Image = bmp
                        Dim G As Graphics = Graphics.FromImage(picIcon.Image)
                        G.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor = 1
                    End Using
                Else
                    picIcon.Image = Image.FromFile("fallback.png")
                End If


                'Display the information in textboxes
                txtHostname.Text = hostname
                txtPort.Text = port.ToString()
                txtMOTD.Text = motd

                Try
                    txtPlayers.Text = String.Join(", ", players)
                Catch
                End Try

                txtOnlinePlayers.Text = onlinePlayers.ToString()
                txtMaxPlayers.Text = maxPlayers.ToString()
                DownloadBar.Increment(24)

                If txtPlayers.Text <> Nothing Then
                    txtUUIDs.Text = String.Join(Environment.NewLine, uuids.Properties().Select(Function(u) $"{u.Name}: {u.Value}"))
                Else
                    txtPlayers.Text = "No Online Players."
                End If



                DownloadBar.Increment(10)

                Else
                    MsgBox("error #001 - Server not online :(", MsgBoxStyle.OkOnly + vbExclamation, "Error #001")
                DownloadBar.Value = 0
            End If
        Else
            MsgBox("error #002 - MCServerSatus did not return any data :(")
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


