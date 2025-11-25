Public Class Pass_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If txtPass.Text = "password123" Then
            Me.Close()
            ChangeCOM_Form.ShowDialog()
        Else
            MsgBox("Wrong password!", MsgBoxStyle.Critical)
            txtPass.Text = ""
        End If
    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtPass.Text = "password123" Then
                Me.Close()
                ChangeCOM_Form.ShowDialog()
            Else
                MsgBox("Wrong password!", MsgBoxStyle.Critical)
                txtPass.Text = ""
            End If
        End If
    End Sub

    Private Sub ChangeSerialPass_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.Text = ""
        txtPass.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class