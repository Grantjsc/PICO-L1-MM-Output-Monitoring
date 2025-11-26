Imports System.IO.Ports
Imports HslCommunication
Imports HslCommunication.Profinet.Omron
Imports System.Configuration
Module Function_Module

    Public omronPLC As OmronHostLinkCMode

    Public L1A_TrayCount As String 'D10
    Public L1A_FuseCount As String ' D12
    Public L1A_Total_TrayCount As String 'D30

    Public L1B_TrayCount As String 'D20
    Public L1B_FuseCount As String 'D22
    Public L1B_Total_TrayCount As String 'D32
    Sub Connect_toPLC_RS232()

        omronPLC = New OmronHostLinkCMode()

        ' Configure RS232 communication
        omronPLC.SerialPortInni(COM, 9600, 7, Parity.Even, StopBits.Two)

        ' HostLink unit number
        omronPLC.UnitNumber = 0

        ' Open the COM port
        Dim connectResult = omronPLC.Open()

        If connectResult.IsSuccess Then
            'MsgBox("RS232 Connected to Omron PLC successfully!")
            Form1.lblConMess.Text = "Connected to OMRON PLC"
            Count_Form.TimerTrig.Enabled = True
        Else
            'MsgBox("Failed to connect via RS232: " & connectResult.Message)
            Form1.lblConMess.Text = "Failed to connect OMRON PLC via RS232"
            Form1.lblConMess.ForeColor = Color.Red
        End If


    End Sub

    Public Function ReadData(address As String) As Integer
        Try
            Dim result = omronPLC.ReadUInt32(address)

            If result.IsSuccess Then
                Return result.Content
            Else
                MsgBox("Read Data failed: " & result.Message)
                Return -1
            End If

        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
            Return -1
        End Try
    End Function

    Public Function ReadHex32(address As String) As String
        Try
            ' Read 32-bit unsigned value (2 words)
            Dim result = omronPLC.ReadUInt32(address)

            If result.IsSuccess Then
                ' Convert decimal → HEX (uppercase, no &H)
                Return result.Content.ToString("X")
            Else
                MsgBox("Read Data failed: " & result.Message)
                Return ""
            End If

        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
            Return ""
        End Try
    End Function

    '=====================< Count_Form Code >=====================

    ''======< Read the Dec value >======
    'Sub ReadData()
    '    L1A_TrayCount = ReadData("D10")  'D10
    '    L1A_FuseCount = ReadData("D12") ' D12
    '    L1A_Total_TrayCount = ReadData("D30") 'D30

    '    L1B_TrayCount = ReadData("D20") 'D20
    '    L1B_FuseCount = ReadData("D22") 'D22
    '    L1B_Total_TrayCount = ReadData("D32") 'D32

    '    With Count_Form
    '        .lblTC1A.Text = L1A_TrayCount.ToString("N0")
    '        .lblFC1A.Text = L1A_FuseCount.ToString("N0")
    '        .lblTTC1A.Text = L1A_Total_TrayCount.ToString("N0")

    '        .lblTC1B.Text = L1B_TrayCount.ToString("N0")
    '        .lblFC1B.Text = L1B_FuseCount.ToString("N0")
    '        .lblTTC1B.Text = L1B_Total_TrayCount.ToString("N0")
    '    End With

    'End Sub

    '======< Read the Hex value >======
    Sub ReadData()
        L1A_TrayCount = ReadHex32("D10")
        L1A_FuseCount = ReadHex32("D12")
        L1A_Total_TrayCount = ReadHex32("D30")

        L1B_TrayCount = ReadHex32("D20")
        L1B_FuseCount = ReadHex32("D22")
        L1B_Total_TrayCount = ReadHex32("D32")

        With Count_Form
            .lblTC1A.Text = L1A_TrayCount
            .lblFC1A.Text = L1A_FuseCount
            .lblTTC1A.Text = L1A_Total_TrayCount

            .lblTC1B.Text = L1B_TrayCount
            .lblFC1B.Text = L1B_FuseCount
            .lblTTC1B.Text = L1B_Total_TrayCount
        End With

        FormatLabel(Count_Form.lblTC1A)
        FormatLabel(Count_Form.lblFC1A)
        FormatLabel(Count_Form.lblTTC1A)
        FormatLabel(Count_Form.lblTC1B)
        FormatLabel(Count_Form.lblFC1B)
        FormatLabel(Count_Form.lblTTC1B)

    End Sub

    Sub FormatLabel(lbl As Label)
        If IsNumeric(lbl.Text) Then
            lbl.Text = Decimal.Parse(lbl.Text).ToString("N0")
        End If
    End Sub


    '=====================< General Code >=====================

    Sub LoadCountForm()
        With Count_Form
            .TopLevel = False
            Form1.PanelMaster.Controls.Add(Count_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    '=====================< ChangeCOM_Form Code >=====================

    Sub Load_AvailableCOM()
        Dim TegamportName As String() = SerialPort.GetPortNames()
        For Each COMname As String In TegamportName
            ChangeCOM_Form.cboCOM.Items.Add(COMname)
        Next
    End Sub
End Module

Module AppConfig_Module
    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public COM As String
    Public New_COM As String

    Sub Get_COM_NAME()
        Dim name As String = System.Configuration.ConfigurationManager.AppSettings("COM_Name")
        Console.WriteLine("COM name: " & name)

        COM = name
    End Sub

    Sub Update_COM_NAME()
        config.AppSettings.Settings("COM_Name").Value = New_COM ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
End Module

'Module OmronRS232Test

'    Private omronPLC As OmronHostLinkCMode

'    ' Test connection and read D10
'    Public Sub TestReadD10()
'        Try
'            ' Create PLC instance
'            omronPLC = New OmronHostLinkCMode()

'            ' Configure serial port
'            omronPLC.SerialPortInni("COM8", 9600, 7, IO.Ports.Parity.Even, IO.Ports.StopBits.Two)
'            omronPLC.UnitNumber = 0      ' HostLink unit number
'            'omronPLC.Timeout = 20000     ' 20 sec timeout

'            ' Open connection
'            Dim result = omronPLC.Open()
'            If result.IsSuccess Then
'                MsgBox("Connected to PLC successfully.")
'            Else
'                MsgBox("Failed to connect: " & result.Message)
'                Exit Sub
'            End If

'            ' Read single D register
'            Dim readResult = omronPLC.ReadInt16("D10")
'            If readResult.IsSuccess Then
'                MsgBox("D10 = " & readResult.Content)
'            Else
'                MsgBox("Read D10 failed: " & readResult.Message)
'            End If

'            ' Close connection
'            omronPLC.Close()

'        Catch ex As Exception
'            MsgBox("Exception: " & ex.Message)
'        End Try
'    End Sub

'End Module