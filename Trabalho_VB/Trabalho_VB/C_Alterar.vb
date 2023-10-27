Imports System.Data.SqlClient

Public Class C_Alterar
    Dim Conectar As New SqlConnection("Server=DESKTOP-E400SUM\SQLEXPRESS_X86;Database=Agenda_empresa;Integrated Security = true")
    Public Sub AtaluzarFuncionario(cb1, cb2, cb3, ms1, ms2, ms3, ms4, ms5, ms8, tb1, tb3)
        Dim Empresa, Cargo As New Integer
        Empresa = cb1.SelectedIndex + 1
        Cargo = cb2.SelectedIndex + 1

        Dim myFormat = "yyyy-MM-dd"
        Dim Data_nasc = Format(CDate(ms3.Text), myFormat)
        Dim Data_contrato = Format(CDate(ms4.Text), myFormat)

        If Data_nasc > Data_contrato Then
            MsgBox("Data errada")
        Else
            Try
                Conectar.Open()
                Dim Command As New SqlCommand("update Funcionario 
                                           set Nome = '" & tb1.Text & "',
                                               NIF = " & ms1.Text & ",
                                               Telefone = " & ms2.Text & ",
                                               Data_nasc = '" & Data_nasc & "',
                                               Email = '" & tb3.Text & "',
                                               Empresa = " & cb1.SelectedIndex & ",
                                               Cargo = " & cb2.SelectedIndex & ",
                                               Data_contrato = '" & Data_contrato & "',
                                               Salario = " & ms5.Text & ",
                                               Ativo = " & cb3.SelectedIndex & "
                                           where NIF = " & ms8.Text & " ", Conectar)

                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                MsgBox("Alterado!")
                Conectar.Close()
            Catch ex As Exception
                MsgBox("Não foi possível atualizar os dados")
                Conectar.Close()
            End Try
        End If
    End Sub

    Public Sub AtualizarProjeto(cb5, cb6, cb7, ms6, ms7)
        Dim Estado As New Integer
        Dim Funcionario, Jogo As String
        Funcionario = cb5.text
        Jogo = cb6.text
        Estado = cb7.SelectedIndex

        Dim myFormat = "yyyy-MM-dd"
        Dim Data_inicio = Format(CDate(ms6.Text), myFormat)
        Dim Data_fim = Format(CDate(ms7.Text), myFormat)

        If Data_inicio > Data_fim Then
            MsgBox("Data errada")
        Else
            Try
                Conectar.Open()
                Dim Command As New SqlCommand("update grupo 
                                           set Funcionario = '" & Funcionario & "',
                                               Jogo = '" & Jogo & "',
                                               Data_inicio = '" & Data_inicio & "',
                                               Data_final = '" & Data_fim & "',
                                               Estado = " & Estado & "
                                           where Jogo = '" & Jogo & "' and Funcionario = '" & Funcionario & "' ",
                                                  Conectar)
                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                MsgBox("Atualizado!")
                Conectar.Close()
            Catch ex As Exception
                MsgBox("Não foi possível atualziar os dados")
                Conectar.Close()
            End Try
        End If
    End Sub

    Public Sub ApagarProjeto(cb5, cb6)
        Dim result As DialogResult = MessageBox.Show("Tem certeza que quer apagar??", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Try
                Conectar.Open()
                Dim Command As New SqlCommand(" delete from Grupo where Funcionario = '" & cb5.Text & "' and Jogo = '" & cb6.text & "' ", Conectar)
                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                MsgBox("Apagado!")
                Conectar.Close()

            Catch ex As Exception
                MsgBox("Não foi possível apagar os dados")
                Conectar.Close()
            End Try
        Else
        End If
    End Sub

    Public Sub ApagarFuncionario(ms8)
        Dim result As DialogResult = MessageBox.Show("Tem certeza que quer apagar??", "Title", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Try
                Conectar.Open()
                Dim Command As New SqlCommand(" delete from Funcionario where NIF = " & ms8.Text & "", Conectar)
                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                MsgBox("Apagado!")
                Conectar.Close()

            Catch ex As Exception
                MsgBox("Não foi possível apagar os dados")
                Conectar.Close()
            End Try
        Else
        End If
    End Sub
End Class