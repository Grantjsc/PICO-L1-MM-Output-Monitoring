Public Class Count_Form
    Private Sub Count_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_COM_NAME()
        Connect_toPLC_RS232()
    End Sub

    Private Sub TimerTrig_Tick(sender As Object, e As EventArgs) Handles TimerTrig.Tick
        ReadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OmronRS232Test.TestReadD10()
    End Sub
End Class