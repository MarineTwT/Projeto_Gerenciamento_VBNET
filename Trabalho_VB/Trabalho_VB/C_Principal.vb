Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class C_Principal
    Dim Conectar As New SqlConnection("Server=DESKTOP-E400SUM\SQLEXPRESS_X86;Database=Agenda_empresa;Integrated Security = true")
    Public Sub BuscarLVFuncionario(lv)
        With lv
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Nome")
            .Columns.Add("NIF")
            .Columns.Add("Telefone")
            .Columns.Add("Data de nascimento")
            .Columns.Add("Email")
            .Columns.Add("Empresa")
            .Columns.Add("Cargo")
            .Columns.Add("Data de contrato")
            .Columns.Add("Salário")
            .Columns.Add("Ativo")
        End With

        Try
            Conectar.Open()
            Dim Command As New SqlCommand("Select f.Nome,NIF,f.Telefone,Data_nasc,f.Email,e.Nome,c.Nome,Data_contrato,Salario,Ativo
                                           from Funcionario f
                                           inner join dbo.Cargo c on c.ID_C = f.Cargo 
                                           inner join dbo.Empresa e on e.ID_E = f.Empresa", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader()
            Dim afirm As String
            lv.Dock = DockStyle.Bottom
            While (reader.Read)
                If reader.GetValue(9) = True Then
                    afirm = "Sim"
                Else
                    afirm = "Não"
                End If

                lv.Items.Add(New ListViewItem(
                                 {reader.GetValue(0),
                                 reader.GetValue(1),
                                 reader.GetValue(2),
                                 reader.GetValue(3),
                                 reader.GetValue(4),
                                 reader.GetValue(5),
                                 reader.GetValue(6),
                                 reader.GetValue(7),
                                 reader.GetValue(8),
                                 afirm})
                                 )
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possivel carregar os dados...")
        End Try
    End Sub

    Public Sub BuscarLVProjeto(lv, Nome)
        With lv
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Jogo")
            .Columns.Add("Data do inicio")
            .Columns.Add("Data de entrega")
            .Columns.Add("Estado do projeto")
        End With

        Try
            Conectar.Open()
            Dim Command As New SqlCommand("Select *
                                           from Grupo
                                           where Funcionario = '" & Nome & "'", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader()
            Dim estado As String
            While (reader.Read)
                If reader.GetValue(4) = 0 Then
                    estado = "Em andamento"
                ElseIf reader.GetValue(4) = 1 Then
                    estado = "Concluído"
                ElseIf reader.GetValue(4) = 2 Then
                    estado = "Cancelado"
                End If
                lv.Items.Add(New ListViewItem(
                                 {reader.GetValue(1),
                                 reader.GetValue(2),
                                 reader.GetValue(3),
                                 estado})
                                 )
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possivel carregar os dados...")
        End Try
    End Sub
    Public Sub OrdenarColunas(sender As Object, e As ColumnClickEventArgs, lv As Object, coluna As Integer)
        sender.AutoResizeColumn(e.Column, ColumnHeaderAutoResizeStyle.HeaderSize)
        If sender.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Descending Then
            sender.Columns.Item(e.Column).ListView.Sorting = SortOrder.Descending
        ElseIf sender.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Ascending Then
            sender.Columns.Item(e.Column).ListView.Sorting = SortOrder.Ascending
        End If

        ' Verificar a coluna clicada
        If e.Column = coluna Then ' Se for a coluna do nome
            ' Definir a ordem de classificação oposta
            If sender.Sorting = SortOrder.Ascending Then
                sender.Sorting = SortOrder.Descending
            Else
                sender.Sorting = SortOrder.Ascending
            End If
            ' Ordenar os itens da ListView de acordo com o nome
            sender.ListViewItemSorter = New ListViewItemComparer(e.Column, sender.Sorting)
        End If

        ' Atualizar a exibição da ListView
        lv.ListViewItemSorter = New ListViewItemComparer(e.Column, lv.Sorting)
        lv.Sorting = If(lv.Sorting = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        sender.Sort()
        sender.Refresh()
    End Sub

    Private Class ListViewItemComparer
        Implements IComparer

        Private col As Integer
        Private order As SortOrder

        Public Sub New(column As Integer, order As SortOrder)
            Me.col = column
            Me.order = order
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim returnVal As Integer = -1
            returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
            ' Determine se a ordem deve ser invertida
            If order = SortOrder.Descending Then
                returnVal *= -1
            End If
            Return returnVal
        End Function
    End Class
End Class
