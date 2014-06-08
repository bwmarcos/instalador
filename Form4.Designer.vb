<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_atualiza
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_atualiza))
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_caminho = New System.Windows.Forms.TextBox()
        Me.lista = New System.Windows.Forms.ListBox()
        Me.barra = New System.Windows.Forms.ProgressBar()
        Me.btn_baixar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_mediworks = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pasta_dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_valor.ForeColor = System.Drawing.Color.Black
        Me.lbl_valor.Location = New System.Drawing.Point(157, 206)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(16, 13)
        Me.lbl_valor.TabIndex = 28
        Me.lbl_valor.Text = "..."
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.ImageIndex = 0
        Me.Button7.ImageList = Me.ImageList1
        Me.Button7.Location = New System.Drawing.Point(2, 210)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 63)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "MediCapture"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "capture.png")
        Me.ImageList1.Images.SetKeyName(1, "center.png")
        Me.ImageList1.Images.SetKeyName(2, "remote.png")
        Me.ImageList1.Images.SetKeyName(3, "works.png")
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.ImageIndex = 2
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(2, 144)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 63)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "MediRemote"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.ImageIndex = 1
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(2, 78)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 63)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "MediCenter"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(386, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 22)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(109, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Caminho da Pasta:"
        '
        'txt_caminho
        '
        Me.txt_caminho.Enabled = False
        Me.txt_caminho.Location = New System.Drawing.Point(112, 163)
        Me.txt_caminho.Name = "txt_caminho"
        Me.txt_caminho.Size = New System.Drawing.Size(273, 20)
        Me.txt_caminho.TabIndex = 21
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(112, 12)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(298, 121)
        Me.lista.TabIndex = 19
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(112, 222)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(299, 10)
        Me.barra.TabIndex = 18
        '
        'btn_baixar
        '
        Me.btn_baixar.Enabled = False
        Me.btn_baixar.Location = New System.Drawing.Point(335, 250)
        Me.btn_baixar.Name = "btn_baixar"
        Me.btn_baixar.Size = New System.Drawing.Size(75, 23)
        Me.btn_baixar.TabIndex = 17
        Me.btn_baixar.Text = "Atualizar"
        Me.btn_baixar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 284)
        Me.Panel1.TabIndex = 29
        '
        'btn_mediworks
        '
        Me.btn_mediworks.BackColor = System.Drawing.Color.White
        Me.btn_mediworks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mediworks.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_mediworks.ImageIndex = 3
        Me.btn_mediworks.ImageList = Me.ImageList1
        Me.btn_mediworks.Location = New System.Drawing.Point(2, 12)
        Me.btn_mediworks.Name = "btn_mediworks"
        Me.btn_mediworks.Size = New System.Drawing.Size(97, 63)
        Me.btn_mediworks.TabIndex = 24
        Me.btn_mediworks.Text = "MediWorks"
        Me.btn_mediworks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_mediworks.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(351, 206)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(16, 13)
        Me.lbl_total.TabIndex = 30
        Me.lbl_total.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(317, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(109, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Baixado:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_atualiza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(429, 284)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_mediworks)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_caminho)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.btn_baixar)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(445, 322)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(445, 322)
        Me.Name = "frm_atualiza"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa de Atualização"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_valor As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btn_mediworks As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_caminho As System.Windows.Forms.TextBox
    Friend WithEvents lista As System.Windows.Forms.ListBox
    Friend WithEvents barra As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_baixar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pasta_dialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
