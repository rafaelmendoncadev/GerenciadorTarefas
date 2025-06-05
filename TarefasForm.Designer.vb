<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TarefasForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TarefasForm))
        btnSair = New Button()
        btnExcluir = New Button()
        btnEditar = New Button()
        btnSalvar = New Button()
        btnNovo = New Button()
        dgvTarefas = New DataGridView()
        txtDescricao = New TextBox()
        Label2 = New Label()
        txtTitulo = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        cbStatus = New ComboBox()
        Label4 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        CType(dgvTarefas, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSair
        ' 
        btnSair.BackColor = Color.White
        btnSair.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSair.Location = New Point(571, 407)
        btnSair.Name = "btnSair"
        btnSair.Size = New Size(130, 49)
        btnSair.TabIndex = 30
        btnSair.Text = "Sair"
        btnSair.UseVisualStyleBackColor = False
        ' 
        ' btnExcluir
        ' 
        btnExcluir.BackColor = Color.White
        btnExcluir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExcluir.Location = New Point(334, 423)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(73, 33)
        btnExcluir.TabIndex = 29
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.White
        btnEditar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditar.Location = New Point(253, 423)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(73, 33)
        btnEditar.TabIndex = 28
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackColor = Color.White
        btnSalvar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalvar.Location = New Point(172, 423)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(73, 33)
        btnSalvar.TabIndex = 27
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = False
        ' 
        ' btnNovo
        ' 
        btnNovo.BackColor = Color.White
        btnNovo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNovo.Location = New Point(86, 423)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(78, 33)
        btnNovo.TabIndex = 26
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = False
        ' 
        ' dgvTarefas
        ' 
        dgvTarefas.BackgroundColor = Color.White
        dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTarefas.Location = New Point(88, 243)
        dgvTarefas.Name = "dgvTarefas"
        dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTarefas.Size = New Size(613, 150)
        dgvTarefas.TabIndex = 25
        ' 
        ' txtDescricao
        ' 
        txtDescricao.BackColor = Color.White
        txtDescricao.ForeColor = SystemColors.InfoText
        txtDescricao.Location = New Point(88, 202)
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(404, 23)
        txtDescricao.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(243, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 30)
        Label2.TabIndex = 23
        Label2.Text = "Descrição"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.BackColor = Color.White
        txtTitulo.ForeColor = SystemColors.InfoText
        txtTitulo.Location = New Point(88, 118)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(401, 23)
        txtTitulo.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(253, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 30)
        Label1.TabIndex = 21
        Label1.Text = "Título"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(221, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(311, 45)
        Label3.TabIndex = 31
        Label3.Text = "Controle de Tarefas"
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Pendente", "Em Andamento", "Concluída"})
        cbStatus.Location = New Point(565, 204)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(136, 23)
        cbStatus.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(498, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 21)
        Label4.TabIndex = 33
        Label4.Text = "Status:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(22, 10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(766, 72)
        Panel1.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(661, 463)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 21)
        Label5.TabIndex = 35
        Label5.Text = "(61)99851-9524"
        ' 
        ' TarefasForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 493)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cbStatus)
        Controls.Add(btnSair)
        Controls.Add(btnExcluir)
        Controls.Add(btnEditar)
        Controls.Add(btnSalvar)
        Controls.Add(btnNovo)
        Controls.Add(dgvTarefas)
        Controls.Add(txtDescricao)
        Controls.Add(Label2)
        Controls.Add(txtTitulo)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "TarefasForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gerenciador de Tarefas"
        CType(dgvTarefas, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSair As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dgvTarefas As DataGridView
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label

End Class
