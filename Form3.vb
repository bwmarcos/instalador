Public Class frm_processo
    Dim desc_center As String
    Dim desc_works As String
    Dim desc_worksl As String
    Dim desc_medicap As String
    Dim desc_worksli As String
    Dim desc_repor As String
    Dim medi_caminho As String
    Dim img_caminho As String

    Private Sub frm_processo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        desc_center = "Este é o sistema responsável pelo processamento e armazenamento das imagens DICOM que são geradas pelo equipamento médico."
        lbl_descricao.Text = desc_center
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        desc_works = "O Sistema Mediworks é uma workstation multimodalidade. é operado pelo médico do Centro de Diagnóstico(Clínica ou Hospital)."
        lbl_descricao.Text = desc_works
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        desc_worksl = "O MediWorkList é responsável pela integração entre equipamentos médicos que possuem a funcionalidade DICOM"
        lbl_descricao.Text = desc_worksl
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        desc_medicap = "O Mediclinic é um Sistema que permite a captura de imagens provenientes de equipamentos"
        lbl_descricao.Text = desc_medicap
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        desc_worksli = "O Sistema Mediworks é uma workstation multimodalidade. é operado pelo médico do Centro de Diagnóstico(Clínica ou Hospital)."
        lbl_descricao.Text = desc_worksli
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        desc_repor = "Os sistemas que compõem nosso PACS foram desenvolvidos com o objetivo de permitir o gerenciamento de imagens médicas digitais"
        lbl_descricao.Text = desc_repor
    End Sub

End Class