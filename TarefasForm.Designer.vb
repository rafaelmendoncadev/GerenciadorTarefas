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
        Label1 = New Label()
        txtTitulo = New TextBox()
        Label2 = New Label()
        txtDescricao = New TextBox()
        dgvTarefas = New DataGridView()
        btnNovo = New Button()
        btnSalvar = New Button()
        btnEditar = New Button()
        btnExcluir = New Button()
        CType(dgvTarefas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "Título"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(55, 6)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(100, 23)
        txtTitulo.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 2
        Label2.Text = "Descrição"
        ' 
        ' txtDescricao
        ' 
        txtDescricao.Location = New Point(76, 47)
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(100, 23)
        txtDescricao.TabIndex = 3
        ' 
        ' dgvTarefas
        ' 
        dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTarefas.Location = New Point(12, 91)
        dgvTarefas.Name = "dgvTarefas"
        dgvTarefas.Size = New Size(480, 150)
        dgvTarefas.TabIndex = 4
        ' 
        ' btnNovo
        ' 
        btnNovo.Location = New Point(69, 283)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(75, 23)
        btnNovo.TabIndex = 5
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' btnSalvar
        ' 
        btnSalvar.Location = New Point(158, 283)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(75, 23)
        btnSalvar.TabIndex = 6
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(249, 283)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 7
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(345, 283)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(75, 23)
        btnExcluir.TabIndex = 8
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' TarefasForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExcluir)
        Controls.Add(btnEditar)
        Controls.Add(btnSalvar)
        Controls.Add(btnNovo)
        Controls.Add(dgvTarefas)
        Controls.Add(txtDescricao)
        Controls.Add(Label2)
        Controls.Add(txtTitulo)
        Controls.Add(Label1)
        Name = "TarefasForm"
        Text = "Form1"
        ' Remova ou comente a linha abaixo:
        ' Me.MainForm = Global.GerenciadorTarefas.TarefasForm
        CType(dgvTarefas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents dgvTarefas As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button

End Class
