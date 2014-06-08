Public Class frm_installador

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed




    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Iniciado o instalador: " & vbCrLf & "• Selecione o caminho da pasta a ser criado o arquivo de Instalação" & vbCrLf & "• Depois edite as configurações do Medi.ini utilize o botão Atualiza para carregar valores padrões" & vbCrLf & "• Após o prenchimento click no botão Finalizar")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.pasta_instalador.ShowDialog()
        txt_dest_inst.Text = pasta_instalador.SelectedPath

        If txt_dest_inst.Text = "" Then
            btn_fim_inst.Enabled = False
        Else
            btn_fim_inst.Enabled = True

        End If
    End Sub
End Class