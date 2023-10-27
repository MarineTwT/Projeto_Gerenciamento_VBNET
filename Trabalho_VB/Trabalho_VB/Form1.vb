Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim Ca As New C_Principal
    Dim Ap As New Apoio
    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        Dim f1 As New Adicionar
        f1.Show()
    End Sub
    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarToolStripMenuItem.Click
        Dim f1 As New Alterar
        f1.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Ca.BuscarLVFuncionario(ListView1)
    End Sub


    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If e.Column = 0 Then
            Ca.OrdenarColunas(sender, e, ListView1, 0)
        ElseIf e.Column = 1 Then
            Ca.OrdenarColunas(sender, e, ListView1, 1)
        ElseIf e.Column = 2 Then
            Ca.OrdenarColunas(sender, e, ListView1, 2)
        ElseIf e.Column = 3 Then
            Ca.OrdenarColunas(sender, e, ListView1, 3)
        ElseIf e.Column = 4 Then
            Ca.OrdenarColunas(sender, e, ListView1, 4)
        ElseIf e.Column = 5 Then
            Ca.OrdenarColunas(sender, e, ListView1, 5)
        ElseIf e.Column = 6 Then
            Ca.OrdenarColunas(sender, e, ListView1, 6)
        ElseIf e.Column = 7 Then
            Ca.OrdenarColunas(sender, e, ListView1, 7)
        ElseIf e.Column = 8 Then
            Ca.OrdenarColunas(sender, e, ListView1, 8)
        ElseIf e.Column = 9 Then
            Ca.OrdenarColunas(sender, e, ListView1, 9)
        End If
    End Sub

    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView2.ColumnClick
        If e.Column = 0 Then
            Ca.OrdenarColunas(sender, e, ListView2, 0)
        ElseIf e.Column = 1 Then
            Ca.OrdenarColunas(sender, e, ListView2, 1)
        ElseIf e.Column = 2 Then
            Ca.OrdenarColunas(sender, e, ListView2, 2)
        ElseIf e.Column = 3 Then
            Ca.OrdenarColunas(sender, e, ListView2, 3)
        End If
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ListView2.Clear()
        Try
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim empresa As String = selectedItem.SubItems(5).Text
            Dim Nome As String = selectedItem.SubItems(0).Text
            Ap.BuscarEmpresa(TextBox1, TextBox2, MaskedTextBox1, MaskedTextBox2, TextBox5, empresa)
            Ca.BuscarLVProjeto(ListView2, Nome)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        Try
            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            Dim jogo As String = selectedItem.SubItems(0).Text
            Ap.BuscarJogo(TextBox10, TextBox9, TextBox8, TextBox7, TextBox6, jogo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Clear()
        ListView2.Clear()
        Ca.BuscarLVFuncionario(ListView1)
    End Sub
End Class