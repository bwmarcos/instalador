Imports System
Imports System.IO
Imports IWshRuntimeLibrary
Imports System.Security.Cryptography
Imports System.Text

Public Class frm_splas
    Dim des_mediworks, des_medicenter, des_worksl, des_medicap, des_worksli, des_repor As String ' variáveis para descrição

    'Variáveis para instalação dos programas
    Dim caminho As String
    Dim arquivo As String
    Dim backup As String
    Dim status As String

    'Variáveis para criação de atalho na área de trabalho 

    Dim link As String
    Dim local_atalho As String
    Dim local_atalho_aplicativo As String

    'Variaveis para função iniciar junto com o windows
    Dim nome As String
    Dim local As Object
    Dim RegistryKey As Object


    'função para editar arquivos ini's 
    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer


    'Função para extrair arquivos do Resource do programa na pasta escolhida

    Private Sub install_mediworks()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediWorks)
    End Sub

    Private Sub install_center()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediCenter)
    End Sub

    Private Sub install_license()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediLicense)
    End Sub

    Private Sub install_worklist()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediWorkList)
    End Sub

    Private Sub install_capture()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediCapture)
    End Sub
    Private Sub install_worklight()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediWorksLight)
    End Sub

    Private Sub install_report()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediReport)
    End Sub

    Private Sub install_remote()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.MediRemote)
    End Sub

    Private Sub install_banco()
        System.IO.File.WriteAllBytes("" & caminho & "\" & arquivo & "", My.Resources.bancos)
    End Sub

    'função para descompactar arquivos enviados da resource
    'necessita incluir uma referência shell 32
    Private Sub extrair_arquivos()

        Dim sc As New Shell32.Shell
        Dim _pasta As Shell32.Folder = sc.NameSpace(caminho)

        Dim _arquivo As Shell32.Folder = sc.NameSpace("" & caminho & "\" & arquivo & "")
        _pasta.CopyHere(_arquivo.Items, 4)

    End Sub

    'função para excluir os arquivos após da extração
    Private Sub remover_arquivo()
        My.Computer.FileSystem.DeleteFile("" & caminho & "\" & arquivo & "")

    End Sub

    'função verifica quais check_box foram selecionados
    Private Sub verifica_check_box()

        caminho = txt_local_ins_tela3.Text 'Caminho da pasta
        If btn_ava_tela3.Enabled = True Then

            arquivo = "bancos.zip"
            install_banco()
            extrair_arquivos()
            remover_arquivo()

        End If


        If box_medilic.Checked = True Then
            lbl_status.Text = "Instalando MediLicense..."
            arquivo = "MediLicense.zip"
            install_license()
            extrair_arquivos()
            remover_arquivo()

            If box_add_area.Checked = True Then
                link = "\Medilicense.lnk"
                local_atalho_aplicativo = "MediLicense.exe"
                local_atalho = caminho & "\MediLicense\"
                cria_atalho()


                If box_exec_start.Checked = True Then
                    nome = "MediLicense"
                    local = caminho & "\MediLicense\MediLicense.exe"
                    inicia_junto()
                End If


            End If
            pbar_ins_tela4.Value = 10
        Else

            TabControl2.TabPages.Remove(TabPage7) ' desabilita tabs quando acionado

        End If


        If box_mediwor.Checked = True Then
            lbl_status.Text = "Instalando MediWorks..."
            arquivo = "MediWorks.zip"
            install_mediworks()
            extrair_arquivos()
            remover_arquivo()


            If box_add_area.Checked = True Then
                link = "\MediWorks.lnk"
                local_atalho_aplicativo = "MediWorks.exe"
                local_atalho = caminho & "\MediWorks\"
                cria_atalho()


            End If
            pbar_ins_tela4.Value = 20

        Else
            TabControl2.TabPages.Remove(TabPage9) ' desabilita tabs quando acionado

        End If
        If box_medicen.Checked = True Then
            lbl_status.Text = "Instalando MediCenter..."
            arquivo = "MediCenter.zip"
            install_center()
            extrair_arquivos()
            remover_arquivo()



            Shell("netsh advfirewall firewall add rule name=""MediCenter"" dir=in action=allow protocol=TCP localport=104") ''porta do medicenter



            If box_add_area.Checked = True Then
                link = "\MediCenter.lnk"
                local_atalho_aplicativo = "MediCenter.exe"
                local_atalho = caminho & "\MediCenter\"
                cria_atalho()

                If box_exec_start.Checked = True Then
                    nome = "MediCenter"
                    local = caminho & "\MediCenter\MediCenter.exe"
                    inicia_junto()
                End If

            End If
            pbar_ins_tela4.Value = 30
        Else

            TabControl2.TabPages.Remove(TabPage8) ' desabilita tabs quando acionado
        End If

        If box_mediworklist.Checked = True Then
            lbl_status.Text = "Instalando MediWorklist..."
            arquivo = "MediWorksList.zip"
            install_worklist()
            extrair_arquivos()
            remover_arquivo()

            If box_add_area.Checked = True Then
                link = "\MediWorklist.lnk"
                local_atalho_aplicativo = "MediWorklist.exe"
                local_atalho = caminho & "\MediWorklist\"
                cria_atalho()

                If box_exec_start.Checked = True Then
                    nome = "MediWorklist"
                    local = caminho & "\MediWorklist\MediWorklist.exe"
                    inicia_junto()
                End If

            End If
            pbar_ins_tela4.Value = 40
        Else

            TabControl2.TabPages.Remove(TabPage10) ' desabilita tabs quando acionado
        End If

        If box_medicap.Checked = True Then
            lbl_status.Text = "Instalando MediCapture..."
            arquivo = "MediCapture.zip"
            install_capture()
            extrair_arquivos()
            remover_arquivo()

            If box_add_area.Checked = True Then
                link = "\MediCapture.lnk"
                local_atalho_aplicativo = "MediCapture.exe"
                local_atalho = caminho & "\MediCapture\"
                cria_atalho()

            Else

            End If
            pbar_ins_tela4.Value = 50
        Else

            TabControl2.TabPages.Remove(TabPage11) ' desabilita tabs quando acionado
        End If

        If box_mediworl.Checked = True Then
            lbl_status.Text = "Instalando MediWorksLight..."
            arquivo = "MediWorksLight.zip"
            install_worklight()
            extrair_arquivos()
            remover_arquivo()
            If box_add_area.Checked = True Then
                link = "\MediWorksLight.lnk"
                local_atalho_aplicativo = "Mediworks.exe"
                local_atalho = caminho & "\MediWorksLight\"
                cria_atalho()

            Else

            End If

            pbar_ins_tela4.Value = 60
        Else

            TabControl2.TabPages.Remove(TabPage12) ' desabilita tabs quando acionado
        End If

        If box_medirep.Checked = True Then
            lbl_status.Text = "Instalando MediReport..."
            arquivo = "MediReport.zip"
            install_report()
            extrair_arquivos()
            remover_arquivo()

            If box_add_area.Checked = True Then
                link = "\MediReport.lnk"
                local_atalho_aplicativo = "MediReport.exe"
                local_atalho = caminho & "\MediReport\"
                cria_atalho()

            Else

            End If
            pbar_ins_tela4.Value = 75
        Else

            TabControl2.TabPages.Remove(TabPage13) ' desabilita tabs quando acionado
        End If

        If box_mediremote.Checked = True Then
            lbl_status.Text = "Instalando MediRemote..."
            arquivo = "MediRemote.zip"
            install_remote()
            extrair_arquivos()
            remover_arquivo()

            If box_add_area.Checked = True Then
                link = "\MediRemote.lnk"
                local_atalho_aplicativo = "MediRemote.exe"
                local_atalho = caminho & "\MediRemote\"
                cria_atalho()

                If box_exec_start.Checked = True Then
                    nome = "MediRemote"
                    local = caminho & "\MediRemote\MediRemote.exe"
                    inicia_junto()
                End If

            End If
            pbar_ins_tela4.Value = 85
        Else

            TabControl2.TabPages.Remove(TabPage14) ' desabilita tabs quando acionado
        End If


        lbl_status.Text = "Instalação Concluída"


        ' MsgBox("Concluido!")
        pbar_ins_tela4.Value = 100
        btn_ava_tela4.Enabled = True
        btn_can_tela4.Enabled = True

    End Sub


    Private Sub Descricao_sistema()
        des_medicenter = "Este é o sistema responsável pelo processamento e armazenamento das imagens DICOM que são geradas pelo equipamento médico."
        des_mediworks = "O Sistema Mediworks é uma workstation multimodalidade. é operado pelo médico do Centro de Diagnóstico(Clínica ou Hospital)."
        des_worksli = "O MediWorkList é responsável pela integração entre equipamentos médicos que possuem a funcionalidade DICOM"
        des_medicap = "O Mediclinic é um Sistema que permite a captura de imagens provenientes de equipamentos"
        des_worksl = "O Sistema Mediworks é uma workstation multimodalidade. é operado pelo médico do Centro de Diagnóstico(Clínica ou Hospital)."
        des_repor = "Os sistemas que compõem nosso PACS foram desenvolvidos com o objetivo de permitir o gerenciamento de imagens médicas digitais"
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'criar as dlls para realizar as funções de descompactar e criar atalhos



        ' TabControl2.TabPages.Remove(TabPage14) ' desabilita tabs quando acionado''''''''''''''Esta removendo tabdo mediremote'''''''''

        

        ' System.IO.File.WriteAllBytes("Interop.Shell32.dll", My.Resources.Interop_Shell32) 'extrair
        'System.IO.File.WriteAllBytes("Interop_IWshRuntimeLibrary.dll", My.Resources.Interop_Shell32) 'criar atalho
        Me.Width = 623

        Me.MaximumSize = New Size(619, 544)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_ava_tela2.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_can_tela2.Click
        TabControl1.SelectedIndex = 0
        box_medilic.Checked = False
        box_medicap.Checked = False
        box_medicen.Checked = False
        box_medilic.Checked = False
        box_mediremote.Checked = False
        box_medirep.Checked = False
        box_mediwor.Checked = False
        box_mediworklist.Checked = False
        box_mediworl.Checked = False



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_ava_tela3.Click

        If box_fire_bird.Checked = True Then

            Shell("netsh advfirewall firewall add rule name=""Porta do FireBird"" dir=in action=allow protocol=TCP localport=3050")

        End If

        btn_ava_tela4.Enabled = False
        btn_can_tela4.Enabled = False
        TabControl1.SelectedIndex = 3
        lbl_des_local_img.Text = txt_local_img_tela3.Text
        lbl_des_local_ins.Text = txt_local_ins_tela3.Text
        verifica_check_box()




    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_can_tela3.Click
        TabControl1.SelectedIndex = 1
        box_medilic.Checked = False
        box_medicap.Checked = False
        box_medicen.Checked = False
        box_medilic.Checked = False
        box_mediremote.Checked = False
        box_medirep.Checked = False
        box_mediwor.Checked = False
        box_mediworklist.Checked = False
        box_mediworl.Checked = False

        btn_ava_tela2.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_ava_tela4.Click
        TabControl1.SelectedIndex = 4
        If box_medilic.Checked = False And box_medicen.Checked = False Then

            btn_edita_conf.Enabled = False
            btn_update_app.Enabled = False

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_can_tela4.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_fecha_tela5.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        'TabControl1.SelectedIndex = 5 ultimo botão
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl1.SelectedIndex = 4

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_ava_tela1.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btn_edita_conf.Click
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub box_medicen_CheckedChanged(sender As Object, e As EventArgs) Handles box_medicen.CheckedChanged
        Descricao_sistema()
        lbl_desc_medi_tela3.Text = des_medicenter
    End Sub

    Private Sub box_mediwor_CheckedChanged(sender As Object, e As EventArgs) Handles box_mediwor.CheckedChanged
        Descricao_sistema()
        lbl_desc_medi_tela3.Text = des_mediworks
    End Sub

    Private Sub box_mediworklist_CheckedChanged(sender As Object, e As EventArgs) Handles box_mediworklist.CheckedChanged
        Descricao_sistema()
        lbl_desc_medi_tela3.Text = des_worksli
    End Sub

    Private Sub box_medicap_CheckedChanged(sender As Object, e As EventArgs) Handles box_medicap.CheckedChanged
        Descricao_sistema()
        lbl_desc_medi_tela3.Text = des_medicap
    End Sub

    Private Sub box_mediworl_CheckedChanged(sender As Object, e As EventArgs) Handles box_mediworl.CheckedChanged
        Descricao_sistema()
        lbl_desc_medi_tela3.Text = des_worksl
    End Sub

    Private Sub box_medirep_CheckedChanged(sender As Object, e As EventArgs) Handles box_medirep.CheckedChanged
        Descricao_sistema()
        lbl_desc_medi_tela3.Text = des_repor
    End Sub

    'botão para abrir folder dialog (seleciona pasta de origem, para instalação)
    Private Sub btn_local_ins_Click(sender As Object, e As EventArgs) Handles btn_local_ins.Click
        Me.pasta_dialog.ShowDialog()
        txt_local_ins_tela3.Text = pasta_dialog.SelectedPath

        If txt_local_ins_tela3.Text = "" Then
            btn_ava_tela3.Enabled = False
        Else
            btn_local_img.Enabled = True
            btn_ava_tela3.Enabled = True
        End If
    End Sub


    'botão para abrir folder dialog (seleciona pasta de imagens)
    Private Sub btn_local_img_Click(sender As Object, e As EventArgs) Handles btn_local_img.Click
        Me.pasta_dialog.ShowDialog()
        txt_local_img_tela3.Text = pasta_dialog.SelectedPath

        If txt_local_img_tela3.Text = "" Then
            btn_ava_tela3.Enabled = False
        Else
            btn_local_img.Enabled = True
        End If
    End Sub


    '''''''''''''Função edita arquivos ini'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    Private Function LerArquivo_medi(ByVal arquivo As String, ByVal configuracoes As String, ByVal cave As String, ByVal valor As String) As String

        Dim strBuilder As New System.Text.StringBuilder(500)
        GetPrivateProfileString(configuracoes, cave, valor, strBuilder, 500, arquivo)
        Return strBuilder.ToString
    End Function

    Private Sub EscreverArquivo_medi(ByVal arquivo As String, ByVal configuracoes As String, ByVal cave As String, ByVal valor As String)
        WritePrivateProfileString(configuracoes, cave, valor, arquivo)
    End Sub



    'Editar arquivos de configuração do Medicenter''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ler_medicenter_pega()
        txt_cen_cam.Text = LerArquivo_medi("" & caminho & "\medicenter\pega.ini", "Database", "name", "nao definido")
        txt_cen_ori.Text = LerArquivo_medi("" & caminho & "\medicenter\pega.ini", "Configuração", "DirOrigem", "nao definido")
        txt_cen_des.Text = LerArquivo_medi("" & caminho & "\medicenter\pega.ini", "Configuração", "DirDestinoAberto", "nao definido")
    End Sub
    Private Sub ler_medicenter_sislaudo()
        txt_cen_cam_s.Text = LerArquivo_medi("" & caminho & "\medicenter\sislaudo.ini", "Database", "Name", "nao definido")
        txt_cen_exa_s.Text = LerArquivo_medi("" & caminho & "\medicenter\sislaudo.ini", "Database", "Exames", "nao definido")
        txt_cen_ori_s.Text = LerArquivo_medi("" & caminho & "\medicenter\sislaudo.ini", "Images", "Dir", "nao definido")
    End Sub

    Private Sub escrever_medicenter_pega()
        EscreverArquivo_medi("" & caminho & "\medicenter\pega.ini", "Database", "name", txt_cen_cam.Text)
        EscreverArquivo_medi("" & caminho & "\medicenter\pega.ini", "Configuração", "DirOrigem", txt_cen_ori.Text)
        EscreverArquivo_medi("" & caminho & "\medicenter\pega.ini", "Configuração", "DirDestinoAberto", txt_cen_des.Text)
    End Sub
    Private Sub escrever_medicenter_sislaudo()
        EscreverArquivo_medi("" & caminho & "\medicenter\sislaudo.ini", "Database", "Name", txt_cen_cam_s.Text)
        EscreverArquivo_medi("" & caminho & "\medicenter\sislaudo.ini", "Database", "Exames", txt_cen_exa_s.Text)
        EscreverArquivo_medi("" & caminho & "\medicenter\sislaudo.ini", "Images", "Dir", txt_cen_ori_s.Text)
    End Sub
    'Fim do editar arquivos de configuração do Medicenter''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    'Editar arquivos de configuração do MediLicense''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ler_medilicense()
        txt_license.Text = LerArquivo_medi("" & caminho & "\Medilicense\medilicense.ini", "Database", "Name", "nao definido")
        'txt_license_ori.Text = LerArquivo_medi("" & caminho & "\license\medilicense.ini", "configuracoes", "Porta", "nao definido")
        'txt_license_des.Text = LerArquivo_medi("" & caminho & "\license\medilicense.ini", "configuracoes", "BD", "nao definido")
    End Sub
    Private Sub escrever_medilincense()
        EscreverArquivo_medi("" & caminho & "\Medilicense\medilicense.ini", "Database", "Name", txt_license.Text)
        'EscreverArquivo_medi("" & caminho & "\license\medilicense.ini", "configuracoes", "Porta", txt_license.Text)
        'EscreverArquivo_medi("" & caminho & "\license\medilicense.ini", "configuracoes", "BD", txt_license.Text)
    End Sub
    'Fim do editar arquivos de configuração do Medilicense'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Editar arquivos de configuração do Mediworks''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ler_works_medi()
        txt_wor_cam.Text = LerArquivo_medi("" & caminho & "\mediWorks\medi.ini", "Database", "name", "nao definido")
        txt_wor_ori.Text = LerArquivo_medi("" & caminho & "\mediWorks\medi.ini", "Database", "exames", "nao definido")
        txt_wor_des.Text = LerArquivo_medi("" & caminho & "\mediWorks\medi.ini", "Dir", "Dir", "nao definido")
    End Sub
    Private Sub ler_works_sislaudo()
        txt_wor_cam_s.Text = LerArquivo_medi("" & caminho & "\mediworks\sislaudo.ini", "Database", "Name", "nao definido")
        txt_wor_exa_s.Text = LerArquivo_medi("" & caminho & "\mediWorks\sislaudo.ini", "Database", "Exames", "nao definido")
        txt_wor_ori_s.Text = LerArquivo_medi("" & caminho & "\mediWorks\sislaudo.ini", "Images", "Dir", "nao definido")
    End Sub

    Private Sub escrever_works_medi()
        EscreverArquivo_medi("" & caminho & "\mediWorks\medi.ini", "Database", "name", txt_wor_cam.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorks\medi.ini", "Database", "exames", txt_wor_ori.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorks\medi.ini", "Dir", "Dir", txt_wor_des.Text)
    End Sub
    Private Sub escrever_works_sislaudo()
        EscreverArquivo_medi("" & caminho & "\mediWorks\sislaudo.ini", "Database", "Name", txt_wor_cam_s.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorks\sislaudo.ini", "Database", "Exames", txt_wor_exa_s.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorks\sislaudo.ini", "Images", "Dir", txt_wor_ori_s.Text)
    End Sub
    'Fim do editar arquivos de configuração do Mediworks'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Editar arquivos de configuração do Mediworklist'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ler_worklist_medi()
        txt_worklist_cam.Text = LerArquivo_medi("" & caminho & "\mediworklist\mediwlist.ini", "Integra", "Tipo", "nao definido")
        txt_worklist_ori.Text = LerArquivo_medi("" & caminho & "\mediworklist\mediwlist.ini", "Integra", "Dir", "nao definido")
        txt_worklist_des.Text = LerArquivo_medi("" & caminho & "\mediworklist\mediwlist.ini", "Data", "Formato", "nao definido")
    End Sub
    

    Private Sub escrever_worklist_medi()
        EscreverArquivo_medi("" & caminho & "\mediworklist\mediwlist.ini", "Integra", "Tipo", txt_worklist_cam.Text)
        EscreverArquivo_medi("" & caminho & "\mediworklist\mediwlist.ini", "Integra", "Dir", txt_worklist_ori.Text)
        EscreverArquivo_medi("" & caminho & "\mediworklist\medi.ini", "Data", "Formato", txt_worklist_des.Text)
    End Sub
    

    'Fim do editar arquivos de configuração do Mediworklist'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Editar arquivos de configuração do Medicapture'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ler_cap_medi()
        txt_cap_cam.Text = LerArquivo_medi("" & caminho & "\medicapture\medicapture.ini", "configuracoes", "IP", "nao definido")
        txt_cap_ori.Text = LerArquivo_medi("" & caminho & "\medicapture\medicapture.ini", "configuracoes", "BD", "nao definido")
        txt_cap_des.Text = LerArquivo_medi("" & caminho & "\medicapture\medicapture.ini", "configuracoes", "DirArquivos", "nao definido")
    End Sub

    Private Sub escrever_cap_medi()
        EscreverArquivo_medi("" & caminho & "\medicapture\medicapture.ini", "configuracoes", "IP", txt_cap_cam.Text)
        EscreverArquivo_medi("" & caminho & "\medicapture\medicapture.ini", "configuracoes", "BD", txt_cap_ori.Text)
        EscreverArquivo_medi("" & caminho & "\medicapture\medicapture.ini", "configuracoes", "DirArquivos", txt_cap_des.Text)
    End Sub
    'Fim do editar arquivos de configuração do MediCapture'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Editar arquivos de configuração do Mediworkslight'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ler_worklight_medi()
        txt_worklight_cam.Text = LerArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Dir", "Dir", "nao definido")
        txt_worklight_ori.Text = LerArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Database", "name", "nao definido")
        txt_worklight_des.Text = LerArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Database", "exames", "nao definido")
    End Sub
   

    Private Sub escrever_worklight_medi()
        EscreverArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Dir", "Dir", txt_worklight_cam.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Database", "name", txt_worklight_ori.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Database", "exames", txt_worklight_des.Text)
    End Sub

    Private Sub ler_worklight_web()
        txt_worklight_web.Text = LerArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Database", "web", "nao definido")
        txt_worklight_ip.Text = LerArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Web", "IP", "nao definido")
        txt_worklight_base.Text = LerArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Web", "database", "nao definido")
    End Sub


    Private Sub escrever_worklight_web()
        EscreverArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Database", "web", txt_worklight_web.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Web", "IP", txt_worklight_ip.Text)
        EscreverArquivo_medi("" & caminho & "\mediWorksLight\medi.ini", "Web", "database", txt_worklight_base.Text)
    End Sub

    'Fim do editar arquivos de configuração do Mediworklight'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Editar arquivos de configuração do MediReport'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    
    Private Sub ler_rep_sislaudo()
        txt_rep_cam_s.Text = LerArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Database", "Name", "nao definido")
        txt_rep_exa_s.Text = LerArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Database", "Exames", "nao definido")
        txt_rep_ori_s.Text = LerArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Images", "Dir", "nao definido")
    End Sub

    Private Sub escrever_rep_sislaudo()
        EscreverArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Database", "Name", txt_rep_cam_s.Text)
        EscreverArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Database", "Exames", txt_rep_exa_s.Text)
        EscreverArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Images", "Dir", txt_rep_ori_s.Text)
    End Sub


    Private Sub ler_rep_web()
        txt_rep_web.Text = LerArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Web", "database", "nao definido")
        txt_rep_laudo.Text = LerArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Web", "Laudos", "nao definido")

    End Sub

    Private Sub escrever_rep_web()
        EscreverArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Web", "database", txt_rep_web.Text)
        EscreverArquivo_medi("" & caminho & "\medireport\sislaudo.ini", "Web", "Laudos", txt_rep_laudo.Text)

    End Sub


    'Fim do editar arquivos de configuração do MediReport'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    'Editar arquivos de configuração do MediRemote'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub ler_remote()
        txt_rem_cam.Text = LerArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Database", "Name", "nao definido")
        txt_rem_ori.Text = LerArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Images", "Dir", "nao definido")
        txt_rem_dir.Text = LerArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Dir", "Images", "nao definido")
    End Sub

    Private Sub escrever_remote()
        EscreverArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Database", "Name", txt_rep_cam_s.Text)
        EscreverArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Images", "Dir", txt_rep_exa_s.Text)
        EscreverArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Dir", "Images", txt_rep_ori_s.Text)
    End Sub


    Private Sub ler_remote_env()
        txt_rem_envio.Text = LerArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Configuração", "PortaEnvioDicom", "nao definido")
        txt_rem_lossy.Text = LerArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Configuração", "PortaLossy", "nao definido")
        txt_rem_loss.Text = LerArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Configuração", "PortaLossLess", "nao definido")

    End Sub

    Private Sub escrever_remote_env()
        EscreverArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Configuração", "PortaEnvioDicom", txt_rem_envio.Text)
        EscreverArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Configuração", "PortaLossy", txt_rem_lossy.Text)
        EscreverArquivo_medi("" & caminho & "\MediRemote\mediremote.ini", "Configuração", "PortaLossLess", txt_rem_loss.Text)

    End Sub


    'Fim do editar arquivos de configuração do MediRemote'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



    Private Sub btn_cen_ler_Click(sender As Object, e As EventArgs) Handles btn_cen_ler.Click
        ler_medicenter_pega()
    End Sub

    Private Sub btn_cen_esc_Click(sender As Object, e As EventArgs) Handles btn_cen_esc.Click
        escrever_medicenter_pega()
    End Sub

    Private Sub btn_cen_ler_s_Click(sender As Object, e As EventArgs) Handles btn_cen_ler_s.Click
        ler_medicenter_sislaudo()
    End Sub

    Private Sub btn_cen_esc_s_Click(sender As Object, e As EventArgs) Handles btn_cen_esc_s.Click
        escrever_medicenter_sislaudo()
    End Sub

    Private Sub btn_wor_ler_Click(sender As Object, e As EventArgs) Handles btn_wor_ler.Click
        ler_works_medi()
    End Sub

    Private Sub btn_wor_esc_Click(sender As Object, e As EventArgs) Handles btn_wor_esc.Click
        escrever_works_medi()
    End Sub

    Private Sub btn_wor_ler_s_Click(sender As Object, e As EventArgs) Handles btn_wor_ler_s.Click
        ler_works_sislaudo()
    End Sub

    Private Sub btn_wor_esc_s_Click(sender As Object, e As EventArgs) Handles btn_wor_esc_s.Click
        escrever_works_sislaudo()
    End Sub

    Private Sub btn_ler_license_Click(sender As Object, e As EventArgs) Handles btn_ler_license.Click
        ler_medilicense()
    End Sub

    Private Sub btn_escrever_license_Click(sender As Object, e As EventArgs) Handles btn_escrever_license.Click
        escrever_medilincense()
    End Sub

    Private Sub btn_worklist_ler_Click(sender As Object, e As EventArgs) Handles btn_worklist_ler.Click
        ler_worklist_medi()
    End Sub

    Private Sub btn_worklist_esc_Click(sender As Object, e As EventArgs) Handles btn_worklist_esc.Click
        escrever_worklist_medi()
    End Sub

    Private Sub btn_cap_ler_Click(sender As Object, e As EventArgs) Handles btn_cap_ler.Click
        ler_cap_medi()
    End Sub

    Private Sub btn_cap_esc_Click(sender As Object, e As EventArgs) Handles btn_cap_esc.Click
        escrever_cap_medi()
    End Sub

    Private Sub btn_worklight_ler_Click(sender As Object, e As EventArgs) Handles btn_worklight_ler.Click
        ler_worklight_medi()
    End Sub

    Private Sub btn_worklight_esc_Click(sender As Object, e As EventArgs) Handles btn_worklight_esc.Click
        escrever_worklight_medi()
    End Sub

    Private Sub btn_worklight_ler_s_Click(sender As Object, e As EventArgs) Handles btn_worklight_ler_s.Click
        ler_worklight_web()
    End Sub

    Private Sub btn_worklight_esc_s_Click(sender As Object, e As EventArgs) Handles btn_worklight_esc_s.Click
        escrever_worklight_web()
    End Sub

    Private Sub btn_rep_ler_s_Click(sender As Object, e As EventArgs) Handles btn_rep_ler_s.Click
        ler_rep_sislaudo()
    End Sub

    Private Sub btn_rep_esc_s_Click(sender As Object, e As EventArgs) Handles btn_rep_esc_s.Click
        escrever_rep_sislaudo()
    End Sub

    Private Sub btn_rep_esc_web_Click(sender As Object, e As EventArgs) Handles btn_rep_esc_web.Click
        ler_rep_web()
    End Sub

    Private Sub btn_rep_ler_web_Click(sender As Object, e As EventArgs) Handles btn_rep_ler_web.Click
        escrever_rep_web()
    End Sub

    Private Sub btn_ler_rem_Click(sender As Object, e As EventArgs) Handles btn_ler_rem.Click
        ler_remote()
    End Sub

    Private Sub btn_rem_esc_Click(sender As Object, e As EventArgs) Handles btn_rem_esc.Click
        escrever_remote()
    End Sub

    Private Sub btn_rem_ler_envio_Click(sender As Object, e As EventArgs) Handles btn_rem_ler_envio.Click
        ler_remote_env()
    End Sub

    Private Sub btn_rem_esc_envio_Click(sender As Object, e As EventArgs) Handles btn_rem_esc_envio.Click
        escrever_remote_env()
    End Sub

    Private Sub btn_update_app_Click(sender As Object, e As EventArgs) Handles btn_update_app.Click
        frm_atualiza.ShowDialog()

    End Sub

    Private Sub btn_can_tela1_Click(sender As Object, e As EventArgs) Handles btn_can_tela1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_inst_tipica_Click(sender As Object, e As EventArgs) Handles btn_inst_tipica.Click
        btn_ava_tela2.Enabled = True
        box_medicen.Checked = True
        box_mediwor.Checked = True
        box_mediworl.Checked = True
        box_medilic.Checked = True
        box_medilic.Enabled = False

    End Sub

    Private Sub btn_inst_perso_Click_1(sender As Object, e As EventArgs) Handles btn_inst_perso.Click
        btn_ava_tela2.Enabled = True
        box_medilic.Enabled = True

    End Sub

    Private Sub btn_inst_comp_Click_1(sender As Object, e As EventArgs) Handles btn_inst_comp.Click
        btn_ava_tela2.Enabled = True
        box_medilic.Checked = True
        box_medicen.Checked = True
        box_mediwor.Checked = True
        box_mediworklist.Checked = True
        box_mediworl.Checked = True
        box_medirep.Checked = True
        box_medicap.Checked = True
        box_medilic.Enabled = False
        box_mediremote.Enabled = True
        box_mediremote.Enabled = True
        box_mediremote.Checked = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txt_local_ins_tela3_TextChanged(sender As Object, e As EventArgs) Handles txt_local_ins_tela3.TextChanged
        If txt_local_ins_tela3.Text = "" And txt_local_img_tela3.Text = "" Then
            btn_ava_tela3.Enabled = False

        End If
    End Sub

    ' Função Cria Atalho
    Private Sub cria_atalho()


        Dim wsh As Object = CreateObject("WScript.Shell")
        wsh = CreateObject("WScript.Shell")
        Dim MyShortCut, DesktopPath As Object
        DesktopPath = wsh.SpecialFolders("Desktop")
        MyShortCut = wsh.CreateShortcut(DesktopPath & link)
        MyShortCut.TargetPath = wsh.ExpandEnvironmentStrings(local_atalho & local_atalho_aplicativo)
        MyShortCut.WorkingDirectory = wsh.ExpandEnvironmentStrings(local_atalho)
        MyShortCut.WindowStyle = 4

        MyShortCut.Save()


    End Sub


    Private Sub inicia_junto()
        ' MsgBox("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\" & nome)

        'nome = "mediscan"
        ' local = "C:\nova\MediScan\MediScan.exe"
        RegistryKey = CreateObject("WScript.Shell")
        RegistryKey.RegWrite("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\" & nome, local)

    End Sub



    'Utilitarios do Editor de ini's
    
    Private Sub btn_gera_codigo_Click(sender As Object, e As EventArgs) Handles btn_gera_codigo.Click
        Call Shell(caminho & "\MediLicense\GeraCodigoNovo.exe", vbNormalFocus)
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_installador.ShowDialog()

    End Sub
End Class
