Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq ' للتعامل مع JSON
'========================
'حيونا بتلغرام تفضلو
'My Telegram : MONSTERMC
'========================
Public Class Form1
    Private botToken As String = "7059390488:AAGXKbHiki8s4Z4dKqq2-a6yyd-VxhJw" 'التوكين الخاص بك

    Private Async Function GetFilePathAsync(fileId As String) As Task(Of String)
        Using client As New HttpClient()
            Dim url = $"https://api.telegram.org/bot{7059390488:AAGXKbHiki8s4Z4dKqq2-a6yyd-VxhJw}/getFile?file_id={fileId}"
            Dim response = Await client.GetStringAsync(url)
            Dim json = JObject.Parse(response)
            Dim filePath = json("result")("file_path").ToString()
            Return filePath
        End Using
    End Function

    Private Async Function DownloadFileAsync(fileId As String, fileName As String) As Task
        Try
            ' الحصول على file_path
            Dim filePath = Await GetFilePathAsync(fileId)
            Dim fileUrl = $"https://api.telegram.org/file/bot{7059390488:AAGXKbHiki8s4Z4dKqq2-a6yyd-VxhJw}/{filePath}"

            ' تحميل الملف من رابط التحميل
            Using client As New HttpClient()
                Dim fileResponse = Await client.GetAsync(fileUrl)
                fileResponse.EnsureSuccessStatusCode()

                Dim savePath = System.IO.Path.Combine(Application.StartupPath, fileName)
                Using fileStream = New IO.FileStream(savePath, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
                    Await fileResponse.Content.CopyToAsync(fileStream)
                End Using

                MessageBox.Show($"تم تحميل الملف: {fileName} في {savePath}")
            End Using
        Catch ex As Exception
            MessageBox.Show($"حدث خطأ أثناء تحميل الملف: {ex.Message}")
        End Try
    End Function

    ' استخدام المثال:
    Private Async Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click

    End Sub
End Class
