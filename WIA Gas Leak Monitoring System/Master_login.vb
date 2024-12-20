Imports DPFP
Imports DPFP.Capture
Imports System.CodeDom
Imports System.Data.OleDb
Imports System.IO.Ports
Imports System.Windows

Public Class Master_login
    Implements DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Delegate Sub FunctionCall(ByVal param)
    Private Event OnTemplate(ByVal template)
    Private Enroller As DPFP.Processing.Enrollment
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        Process_Verify(Sample)

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        'Throw New NotImplementedException()
    End Sub

    Private Sub Master_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Init()
        StartCapture()
        'F1_get_user = "admin"
        'F1_get_title = "Engineer"
        'Me.Hide()
        'Home_Form.WireJam()
    End Sub
    Public Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture() 'create capture event
            Enroller = New DPFP.Processing.Enrollment
            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me 'capturing events
            Else
                MsgBox("Can't initiate capture operation")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub StartCapture()
        Try
            If (Not Capturer Is Nothing) Then
                Capturer.StartCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub StopCapture()
        Try
            If (Not Capturer Is Nothing) Then
                Capturer.StopCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub
    Dim _picCount As Integer
    Private Sub _DrawPicture(ByVal bmp)
        Me.PictureBox1.Image = New Bitmap(bmp, Me.PictureBox1.Size)
    End Sub
    Private Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim bitmap As Bitmap = Nothing
        Try
            Dim convertor As New DPFP.Capture.SampleConversion()
            convertor.ConvertToPicture(Sample, bitmap)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return bitmap
    End Function



    Private Function Extract_Features(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Try
            Dim extractor As New DPFP.Processing.FeatureExtraction() 'create feature extractor
            Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
            Dim features As New DPFP.FeatureSet()
            extractor.CreateFeatureSet(Sample, Purpose, feedback, features) 'TODO: return features as a result
            If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
                Return features
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return Nothing
    End Function

    Protected Sub SetStatus(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _SetStatus), status)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
    Public F1_get_id As String
    Public F1_get_user As String
    Public F1_get_pass As String
    Public F1_get_title As String
    Public Sub Process_Verify(ByVal Sample As DPFP.Sample)
        Try
            DrawPicture(ConvertSampleToBitmap(Sample))
            Dim Features_Verify As DPFP.FeatureSet = Extract_Features(Sample, DPFP.Processing.DataPurpose.Verification)
            Dim Verificator As New DPFP.Verification.Verification
            Dim result As New DPFP.Verification.Verification.Result()

            If Not Features_Verify Is Nothing Then 'check if quality is good
                Dim conn As New OleDbConnection
                conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\SWMaster_db.accdb;Jet OLEDB:Database Password=lfswmaster")
                conn.Open()

                Dim strsql As String
                strsql = "select Username,Title,Finger FROM Uname"
                Dim cmd As New OleDbCommand(strsql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                Dim dt As New DataTable
                dt.Load(myreader)
                'For Each dtrow In dt.Rows 'print all data in table
                '    For Each item In dtrow.ItemArray
                '        Console.WriteLine(item)
                '    Next
                'Next
                For Each dr As DataRow In dt.Rows

                    Dim bytes As Byte() = Nothing
                    bytes = dr.Item("Finger")
                    Dim saved_temp As New DPFP.Template
                    saved_temp.DeSerialize(bytes)
                    Verificator.Verify(Features_Verify, saved_temp, result)
                    If result.Verified Then
                        Label1.ForeColor = Color.White
                        F1_get_user = dr.Item("Username")
                        F1_get_title = dr.Item("Title")

                        Biometric_Name = F1_get_user
                        StopCapture()


                        Me.Close()

                        Exit For


                    End If
                Next
                If Not result.Verified Then
                    Label1.ForeColor = Color.Red
                    Label1.Text = "Authorized personnel only!"

                    'MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                    'Me.Close()
                    'Application.ExitThread()

                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub _SetStatus(ByVal Status)
        Try
            Me.Label1.Text = Status
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Dim msgclose As String
    Private Sub Master_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StopCapture()
        'If F1_get_title = "" Then
        '    msgclose = MessageBox.Show("Do you really want to exit?", "Exit Sand Mixer Timer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    If msgclose = vbYes Then
        '        End
        '    End If
        'End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class