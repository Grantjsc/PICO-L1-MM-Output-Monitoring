Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim secondaryMonitor = Screen.AllScreens.FirstOrDefault(Function(x) Not x.Primary)

        If secondaryMonitor IsNot Nothing Then
            ' Set the form's start position to manual
            Me.StartPosition = FormStartPosition.Manual
            ' Set the location of the form to the top-left corner of the secondary monitor
            Me.Location = secondaryMonitor.Bounds.Location
            Me.WindowState = FormWindowState.Maximized
            Me.Show()
        Else
            Me.WindowState = FormWindowState.Maximized
            'Bounds = Screen.PrimaryScreen.WorkingArea
        End If

        TimerDT.Enabled = True

        LoadCountForm()
    End Sub
    Private Sub TimerDT_Tick(sender As Object, e As EventArgs) Handles TimerDT.Tick
        lblDateTime.Text = Date.Now.ToString("MM/dd/yyyy | hh:mm tt")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub COMNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMNameToolStripMenuItem.Click
        Pass_Form.ShowDialog()
    End Sub
End Class
