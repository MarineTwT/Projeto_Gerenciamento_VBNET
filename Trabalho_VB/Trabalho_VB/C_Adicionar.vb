Imports System.Data.SqlClient

Public Class C_Adicionar
    Dim Conectar As New SqlConnection("Server=DESKTOP-E400SUM\SQLEXPRESS_X86;Database=Agenda_empresa;Integrated Security = true")

    Public Sub AdicionarFuncionario(cb1, cb2, cb3, ms1, ms2, ms3, ms4, ms5, tb1, tb3)
        Dim myFormat = "yyyy-MM-dd"
        Dim Data_nasc = Format(CDate(ms3.Text), myFormat)
        Dim Data_contrato = Format(CDate(ms4.Text), myFormat)

        If Data_nasc > Data_contrato Then
            MsgBox("Data errada")
        Else
            Try
                Conectar.Open()
                Dim Command As New SqlCommand("insert into funcionario(Nome,NIF,Telefone,Data_nasc,Email,Empresa,Cargo,Data_contrato,Salario,Ativo) 
            values
            ('" & tb1.Text & "'," & ms1.Text & "," & ms2.Text & ",
            '" & Data_nasc & "','" & tb3.Text & "'," & cb1.SelectedIndex + 1 & "," & cb2.SelectedIndex + 1 & ",
            '" & Data_contrato & "'," & ms5.Text & "," & cb3.SelectedIndex & ")", Conectar)

                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                MsgBox("Inserido!")
                Conectar.Close()
            Catch ex As Exception
                MsgBox("Não foi possível inserir os dados")
                Conectar.Close()
            End Try
        End If
    End Sub

    Public Sub AdicionarProjeto(cb5, cb6, cb7, ms6, ms7)
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
                Dim Command As New SqlCommand("insert into grupo(Funcionario,Jogo,Data_inicio,Data_final,Estado) 
            values
            ('" & Funcionario & "','" & Jogo & "','" & Data_inicio & "','" & Data_fim & "'," & Estado & ")", Conectar)
                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                MsgBox("Inserido!")
                Conectar.Close()
            Catch ex As Exception
                MsgBox("Não foi possível inserir os dados")
                Conectar.Close()
            End Try
        End If
    End Sub
End Class