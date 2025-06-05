Imports System.Data.SQLite
Imports Microsoft.Data.Sqlite
Imports SQLitePCL

Public Class TarefasForm
    Private connectionString As String = "Data Source=GerenciadorTarefas.db;"
    Private tarefaSelecionadaId As Integer? = Nothing

    Public Sub New()
        ' Esta chamada é exigida pelo designer.
        InitializeComponent()
        ' Inicializa o SQLitePCL
        SQLitePCL.Batteries.Init()
    End Sub

    Private Sub TarefasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarTarefas()
        'dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgvTarefas.MultiSelect = False
        'dgvTarefas.ReadOnly = True
        'dgvTarefas.AllowUserToAddRows = False
        'btnEditar.Enabled = False
        'btnExcluir.Enabled = False
        'txtDescricao.Enabled = False
        'txtTitulo.Enabled = False
        'cbStatus.Enabled = False
        LimparCampos()

    End Sub

    Private Sub CarregarTarefas()
        Using conn As New Microsoft.Data.Sqlite.SqliteConnection(connectionString)
            conn.Open()
            Dim da As New SQLiteDataAdapter("SELECT Id, Titulo, Descricao, Concluida FROM Tarefas", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvTarefas.DataSource = dt
            ' Ajusta o cabeçalho das colunas
            dgvTarefas.Columns("Id").HeaderText = "ID"
            dgvTarefas.Columns("Titulo").HeaderText = "Título"
            dgvTarefas.Columns("Titulo").Width = 160
            dgvTarefas.Columns("Descricao").HeaderText = "Descrição"
            dgvTarefas.Columns("Descricao").Width = 290
            dgvTarefas.Columns("Concluida").HeaderText = "Status"
            dgvTarefas.Columns("Concluida").Width = 100
            dgvTarefas.Columns("Id").Visible = False ' Oculta a coluna Id

        End Using
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        txtTitulo.Text = ""
        txtDescricao.Text = ""
        cbStatus.Text = ""
        tarefaSelecionadaId = Nothing
        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        cbStatus.Enabled = False
        txtTitulo.Enabled = False
        txtDescricao.Enabled = False

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        LimparCampos()
        btnSalvar.Enabled = True
        txtTitulo.Enabled = True
        txtDescricao.Enabled = True
        cbStatus.Enabled = True
        txtTitulo.Focus()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If String.IsNullOrWhiteSpace(txtTitulo.Text) Then
            MessageBox.Show("Informe o título da tarefa.")
            Return
        End If

        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim cmd As New SqliteCommand("INSERT INTO Tarefas (Titulo, Descricao, Concluida) VALUES (@Titulo, @Descricao, @Concluida)", conn)
            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
            cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text)
            cmd.Parameters.AddWithValue("@Concluida", cbStatus.Text)
            cmd.ExecuteNonQuery()
        End Using
        'txtTitulo.Enabled = False
        'txtDescricao.Enabled = False
        CarregarTarefas()
        LimparCampos()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tarefaSelecionadaId Is Nothing Then
            MessageBox.Show("Selecione uma tarefa para editar.")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtTitulo.Text) Then
            MessageBox.Show("Informe o título da tarefa.")
            Return
        End If

        Using conn As New SqliteConnection(connectionString)
            conn.Open()
            Dim cmd As New SqliteCommand("UPDATE Tarefas SET Titulo = @Titulo, Descricao = @Descricao, Concluida = @Concluida WHERE Id = @Id", conn)
            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
            cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text)
            cmd.Parameters.AddWithValue("@Concluida", cbStatus.Text)
            cmd.Parameters.AddWithValue("@Id", tarefaSelecionadaId.Value)
            cmd.ExecuteNonQuery()
        End Using
        'txtTitulo.Enabled = False
        'txtDescricao.Enabled = False
        CarregarTarefas()
        LimparCampos()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If tarefaSelecionadaId Is Nothing Then
            MessageBox.Show("Selecione uma tarefa para excluir.")
            Return
        End If

        If MessageBox.Show("Tem certeza que deseja excluir esta tarefa?", "Confirmação", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As New SqliteConnection(connectionString)
                conn.Open()
                Dim cmd As New SqliteCommand("DELETE FROM Tarefas WHERE Id = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", tarefaSelecionadaId.Value)
                cmd.ExecuteNonQuery()
            End Using
            'txtTitulo.Enabled = False
            'txtDescricao.Enabled = False
            CarregarTarefas()
            LimparCampos()
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub dgvTarefas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTarefas.SelectionChanged
        If dgvTarefas.SelectedRows.Count > 0 Then
            Dim row = dgvTarefas.SelectedRows(0)
            tarefaSelecionadaId = Convert.ToInt32(row.Cells("Id").Value)
            txtTitulo.Text = row.Cells("Titulo").Value.ToString
            txtDescricao.Text = row.Cells("Descricao").Value.ToString
            cbStatus.Text = row.Cells("Concluida").Value.ToString
            btnSalvar.Enabled = False
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            txtTitulo.Enabled = True
            txtDescricao.Enabled = True
            cbStatus.Enabled = True
        Else
            LimparCampos()
        End If
    End Sub
End Class