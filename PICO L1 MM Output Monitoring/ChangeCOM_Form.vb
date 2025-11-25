Imports System.Threading

Public Class ChangeCOM_Form
    Private Sub ChangeCOM_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_AvailableCOM()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If String.IsNullOrEmpty(cboCOM.Text) Then
            MsgBox("Please choose COM name!", MsgBoxStyle.Critical)
        Else
            New_COM = cboCOM.Text
            Update_COM_NAME()
            Thread.Sleep(100)
            Get_COM_NAME()

            cboCOM.Items.Clear()
            cboCOM.Text = Nothing
            MsgBox("COM name is changed!" & vbNewLine & "Kindly restart the software to reflect changes.", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
End Class