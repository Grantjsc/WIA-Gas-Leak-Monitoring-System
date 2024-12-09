Imports System.IO
Imports System.Net
Imports System.Net.Mime.MediaTypeNames
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Security.Policy
Imports System.Threading
Imports System.Web.Configuration

Module Omron_Module
    'Inherits System.Windows.Forms.Form
    Public SID, RSV, GCT, ICF As String
    Public NIC_Count As Integer
    Public Receiving_Done As Boolean

    Public DNA1, DA11, DA21, SNA1, SA11, SA21 As String

    Public _Send, Combo1, Received_Text As String

    Public RemoteIPAddress As String = "192.168.250.4"

    Public cboLocalIP As String = "192.168.250.20"

    Public Text2 As String = "0"
    Public Text1 As String = "0"
    Public Text4 As String = "0"
    Public Text7 As String = "0"



    Sub SendData()
        Dim X, CmdLength, Cnt As Integer
        Dim ByteArray() As Byte ' Changed from fixed-size to dynamic array
        Dim Header, tmp1, CMND As String
        Dim Remote_IP, Local_IP As IPAddress
        Dim Remote_IPEndPoint, Local_IPEndPoint As IPEndPoint
        Dim Ethernet_Socket As Socket
        Dim myByte(1024) As Byte
        Dim retval As Integer
        Cnt = 0

        Header = ICF & RSV & GCT & DNA1 & DA11 & DA21 & SNA1 & SA11 & SA21 & SID
        CMND = Header & Combo1 ' Corrected the string concatenation
        _Send = ""
        CmdLength = Len(CMND)

        ReDim ByteArray((CmdLength - 2) \ 2) ' Using integer division

        For X = 1 To CmdLength Step 2
            tmp1 = Mid(CMND, X, 2)
            Dim byteValue As Integer = Val("&H" & tmp1)
            If byteValue >= 0 AndAlso byteValue <= 255 Then
                ByteArray(Cnt) = CByte(byteValue)
            Else
                MsgBox("Invalid byte value: " & byteValue, MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Cnt += 1
        Next X

        For X = 0 To (Cnt - 1)
            _Send &= Hex(ByteArray(X)) & ""
        Next

        'txtSend.Refresh()
        Console.WriteLine(_Send)

        Try
            Local_IP = IPAddress.Parse(cboLocalIP)
        Catch ex As Exception
            MsgBox("Invalid Local IP Address", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Try
            Remote_IP = IPAddress.Parse(RemoteIPAddress)
        Catch ex As Exception
            MsgBox("Invalid Remote IP Address", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Remote_IPEndPoint = New System.Net.IPEndPoint(Remote_IP, 9600)
        Local_IPEndPoint = New System.Net.IPEndPoint(Local_IP, 9600)

        Ethernet_Socket = New Socket(Local_IPEndPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp)

        If Ethernet_Socket IsNot Nothing Then
            Ethernet_Socket.SendTo(ByteArray, Remote_IPEndPoint)
            Ethernet_Socket.ReceiveTimeout = 200

            Try
                retval = Ethernet_Socket.ReceiveFrom(myByte, Remote_IPEndPoint)
                Socket_Recieved_Data(myByte, retval)

                'Text1 = Remote_IPEndPoint.Address.ToString
                'Text4 = Remote_IPEndPoint.Port.ToString
                'Text7 = retval

                'Console.WriteLine("Address: " & Text1 & vbNewLine &
                '                  "From: " & Text7)

            Catch ex As Exception
                Form1.StartTimer.Enabled = False
                MsgBox("No Response from Remote Device", MsgBoxStyle.Exclamation)

                Form1.StartTimer.Enabled = False
                Exit Sub
            End Try
        End If
    End Sub

    Dim recconter As String
    Public Sub Socket_Recieved_Data(ByVal RX_Data() As Byte, ByVal RX_Count As Integer)
        'recconter = D0_Dec.Text
        Dim X, l, ln As Integer
        Dim t, c, tr, resp, R As String
        R = ""
        resp = ""
        Received_Text = ""
        Dim vtData() As Byte
        Static b(1024) As Byte
        Static d(1024) As String
        Static ascii(1024) As String
        System.Array.Clear(b, 0, b.Length)
        System.Array.Clear(d, 0, d.Length)
        System.Array.Clear(ascii, 0, ascii.Length)



        vtData = RX_Data
        ln = RX_Count

        For l = 1 To ln
            b(l) = Val(CStr(vtData(l - 1)))
            c = Hex(b(l))
            If Len(c) < 2 Then c = "0" & c
            d(l) = c
            resp = resp & c
        Next l

        t = "  ICF RSV GCT DNA DA1 DA2 SNA SA1 SA2 SID MRC SRC MEC SEC" & Chr(13) & Chr(10)
        t = t & "   " & d(1) & "  " & d(2) & "  " & d(3) & "  " & d(4) & "  " & d(5) & "  " & d(6) & "  " & d(7) & "  " & d(8) & "  " & d(9) & "  " & d(10) & "  " & d(11) & "  " & d(12) & "  " & d(13) & "  " & d(14) & vbCrLf
        Text2 = t

        For X = 15 To ln
            If b(X) > 31 And b(X) < 256 Then
                ascii(X) = Chr(b(X))
            Else
                ascii(X) = "."
            End If
        Next X
        tr = ""

        For X = 15 To ln Step 20
            tr = d(X) & d(X + 1) & " " & d(X + 2) & d(X + 3) & " " & d(X + 4) & d(X + 5) & " " & d(X + 6) & d(X + 7) & " " & d(X + 8) & d(X + 9) & " " & d(X + 10) & d(X + 11) & " " & d(X + 12) & d(X + 13) & " " & d(X + 14) & d(X + 15) & " " & d(X + 16) & d(X + 17) & " " & d(X + 18) & d(X + 19) & " | " & ascii(X) & ascii(X + 1) & ascii(X + 2) & ascii(X + 3) & ascii(X + 4) & ascii(X + 5) & ascii(X + 6) & ascii(X + 7) & ascii(X + 8) & ascii(X + 9) & ascii(X + 10) & ascii(X + 11) & ascii(X + 12) & ascii(X + 13) & ascii(X + 14) & ascii(X + 15) & ascii(X + 16) & ascii(X + 17) & ascii(X + 18) & ascii(X + 19) & vbCrLf
            Received_Text &= tr
        Next X
        'If d(13) = "00" AndAlso d(14) = "00" Then Text3.Text = "Successful"
        'If d(13) <> "00" OrElse d(14) <> "00" Then Text3.Text = "Error Code " & d(13) & d(14)
        If tr = "" Then
            Receiving_Done = False
        Else
            Receiving_Done = True

        End If
    End Sub

    Dim Start_Machine As Integer
    Dim bitmap1, bitmap2, bitmap3 As Bitmap

    Dim x1 As Integer
    Dim x As Integer = 22

    Dim inc, incf As Integer
    Public Sub Initialise_System()

        x = 12

        incf = 0
    End Sub
    Sub GetData()
        Dim one As String = Received_Text.Substring(0, 4)
        Dim Two As String = Received_Text.Substring(5, 4)
        Dim Three As String = Received_Text.Substring(10, 4)
        Dim Four As String = Received_Text.Substring(15, 4)
        Dim Five As String = Received_Text.Substring(20, 4)


        Dim One_Dec As Int32 = Convert.ToInt32(one, 16)
        Dim Two_Dec As Int32 = Convert.ToInt32(Two, 16)
        Dim Three_Dec As Int32 = Convert.ToInt32(Three, 16)
        Dim Four_Dec As Int32 = Convert.ToInt32(Four, 16)
        Dim Five_Dec As Int32 = Convert.ToInt32(Five, 16)


        Form1.txtGT01.Text = Math.Round(One_Dec, 2)

        Console.WriteLine(One_Dec)

        Form1.txtGT02.Text = Math.Round(Two_Dec, 2)

        Form1.txtGT03.Text = Math.Round(Three_Dec, 2)

        Form1.txtGT04.Text = Math.Round(Four_Dec, 2)

        Form1.txtGT05.Text = Math.Round(Five_Dec, 2)
    End Sub
End Module