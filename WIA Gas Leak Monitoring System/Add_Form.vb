Imports System.Data.OleDb
Imports System.IO
Imports DPFP
Imports DPFP.Capture
Public Class Add_Form
    Implements DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Delegate Sub FunctionCall(ByVal param)
    Private Event OnTemplate(ByVal template)
    Private Enroller As DPFP.Processing.Enrollment

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        Eng_CheckBox.Checked = False
        PO3_CheckBox.Checked = False
    End Sub
    Private Sub Eng_CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        PO3_CheckBox.Checked = False
        Op_CheckBox.Checked = False
    End Sub

    Private Sub PO3_CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Eng_CheckBox.Checked = False
        Op_CheckBox.Checked = False
    End Sub

    Private Sub F4_Login_btn_Click(sender As Object, e As EventArgs) Handles F4_Login_btn.Click
        If F4_Username_txt.Text = "" Then
            MsgBox("Please enter a valid username and password!")
        Else

            If Op_CheckBox.Checked = False And Eng_CheckBox.Checked = False And PO3_CheckBox.Checked = False And SPC_CheckBox.Checked = False And Tech_CheckBox.Checked = False And QA_CheckBox.Checked = False And Production_CheckBox.Checked = False And Prod_CheckBox.Checked = False Then
                MsgBox("Please select title")
            Else
                check_valid()
                'F4_Login_btn.Enabled = False
                clearform()
                'Me.Close()
                'Master_login.Close()
                'Home_Form.Show()
            End If

        End If

    End Sub

    Public F4_get_user As String
    Public F4_get_pass As String
    Public F4_get_title As String
    Public Sub check_valid()
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\SWMaster_db.accdb;Jet OLEDB:Database Password=lfswmaster")
        Try
            conn.Open()
            Dim strsql As String
            strsql = "select Username from Uname where Username='" + F4_Username_txt.Text + "'"
            Dim cmd As New OleDbCommand(strsql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            F4_get_user = myreader("Username")
            conn.Close()
            MsgBox("User Name" & F4_get_user & "already exists. Please try with another one.")
        Catch ex As Exception
            'adduser()
            new_user()
            'MsgBox("Pass")
        End Try

    End Sub
    Dim mycommand As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim F4_Username, F4_Pass, F4_Title As String
    Dim F4_Finger As Object

    Public Sub new_user()
        If Enroller.FeaturesNeeded > 0 Then
            MsgBox("Insuficient Templates...")
            Exit Sub
        End If

        Dim fs As MemoryStream = New MemoryStream
        Enroller.Template.Serialize(fs)

        fs.Position = 0
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim fs_bytes() As Byte = br.ReadBytes(CType(fs.Length, Int32))

        F4_Username = F4_Username_txt.Text
        F4_Pass = "nopassword"
        If Op_CheckBox.Checked = True Then
            F4_Title = "Operator"
        End If
        If Eng_CheckBox.Checked = True Then
            F4_Title = "Engineer"
        End If
        If PO3_CheckBox.Checked = True Then
            F4_Title = "PO3"
        End If
        If SPC_CheckBox.Checked = True Then
            F4_Title = "SPC"
        End If
        If Tech_CheckBox.Checked = True Then
            F4_Title = "Technician"
        End If
        If QA_CheckBox.Checked = True Then
            F4_Title = "QA"
        End If
        If Production_CheckBox.Checked = True Then
            F4_Title = "Production"
        End If
        If Prod_CheckBox.Checked = True Then
            F4_Title = "Product"
        End If
        F4_Finger = fs_bytes
        'Console.WriteLine(F4_Finger)
        myconnection.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\SWMaster_db.accdb;Jet OLEDB:Database Password=lfswmaster")
        Try
            myconnection.Open()
            mycommand = "INSERT INTO [Uname] ([Username],[Title],[Finger]) VALUES (@F4_Username, @F4_Title, @F4_Finger)"
            Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                cmd.Parameters.AddWithValue("@F4_Username", F4_Username)
                cmd.Parameters.AddWithValue("@F4_Title", F4_Title)
                cmd.Parameters.AddWithValue("@F4_Finger", fs_bytes)
                cmd.ExecuteNonQuery()
            End Using
            myconnection.Close()
            MsgBox("Associate is now added successfully!")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally

            PictureBox1.Image = My.Resources.fingerprint_BLACK_
            PictureBox2.Image = My.Resources.fingerprint_BLACK_
            PictureBox3.Image = My.Resources.fingerprint_BLACK_
            PictureBox4.Image = My.Resources.fingerprint_BLACK_
            PictureBox5.Image = My.Resources.fingerprint_BLACK_

            Init()
            StartCapture()
            'Me.Close()
            'Home_Form.Show()
        End Try
    End Sub

    Private Sub F4_Exit_btn_Click(sender As Object, e As EventArgs) Handles F4_Exit_btn.Click
        clearform()
        Me.Close()
        'Master_login.Close()
        'Home_Form.Show()
    End Sub
    Public Sub clearform()
        F4_Username_txt.Text = ""
        Op_CheckBox.Checked = False
        Eng_CheckBox.Checked = False
        PO3_CheckBox.Checked = False
        SPC_CheckBox.Checked = False
        Tech_CheckBox.Checked = False
        QA_CheckBox.Checked = False
        Production_CheckBox.Checked = False
        Prod_CheckBox.Checked = False
    End Sub

    Private Sub Add_User_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        StartCapture()
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        Process_Enrol(Sample)
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub
    Public Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture() 'create capture event
            Enroller = New DPFP.Processing.Enrollment

            Label6.Text = "Add a finger print.."
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
    Private Sub MakeReport(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _MakeReport), status)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Private Sub _MakeReport(ByVal status)
        Try
            Me.Label3.Text = status

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub
    Dim _piccount As Integer
    Private Sub _DrawPicture(ByVal bmp)
        Me.PictureBox1.Image = New Bitmap(bmp, Me.PictureBox1.Size)
        _piccount += 1
        If _piccount = 1 Then
            Me.PictureBox2.Image = Me.PictureBox1.Image
        End If
        If _piccount = 2 Then
            Me.PictureBox3.Image = Me.PictureBox1.Image
        End If
        If _piccount = 3 Then
            Me.PictureBox4.Image = Me.PictureBox1.Image
        End If
        If _piccount = 4 Then
            Me.PictureBox5.Image = Me.PictureBox1.Image
            _piccount = 0
        End If


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

    Protected Sub SetStatus(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _SetStatus), status)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub _SetStatus(ByVal Status)
        Try
            Me.Label6.Text = Status
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Add_Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        StopCapture()
    End Sub

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

    Private Sub Process_Enrol(ByVal Sample As DPFP.Sample)
        Try
            DrawPicture(ConvertSampleToBitmap(Sample))
            Dim Features_Enrol As DPFP.FeatureSet = Extract_Features(Sample, DPFP.Processing.DataPurpose.Enrollment)
            If Not Features_Enrol Is Nothing Then 'check quality of sample if good
                Try
                    'MakeReport("Fingerprint feature was created")
                    Enroller.AddFeatures(Features_Enrol)
                Finally
                    SetStatus("Fingerprint Template remaining:" & Enroller.FeaturesNeeded.ToString & ". Keep going.")
                    Select Case Enroller.TemplateStatus
                        Case DPFP.Processing.Enrollment.Status.Ready ' Report success and stop capturing
                            RaiseEvent OnTemplate(Enroller.Template)
                            StopCapture()
                            SetStatus("Fingerprint Templates Completed. Save now....")
                            F4_Login_btn.Enabled = True
                        Case DPFP.Processing.Enrollment.Status.Failed
                            Enroller.Clear()
                            StopCapture()
                            RaiseEvent OnTemplate(Nothing)
                            StartCapture()
                    End Select
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class