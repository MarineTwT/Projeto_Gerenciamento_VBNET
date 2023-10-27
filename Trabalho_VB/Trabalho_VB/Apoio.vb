Option Explicit On
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Apoio
    Dim Conectar As New SqlConnection("Server=DESKTOP-E400SUM\SQLEXPRESS_X86;Database=Agenda_empresa;Integrated Security = true")

    Public Sub BuscarLB(Tabela, lb, Coluna)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select " & Coluna & " from " & Tabela & "", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                lb.text = reader.GetValue(0)
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarCB(Tabela, cb, Coluna)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select " & Coluna & " from " & Tabela & "", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                cb.Items.Add(reader.GetValue(0))
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarCB(Tabela, cb, Coluna, Coluna2, Onde)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select " & Coluna & " from " & Tabela & " where " & Coluna2 & " = " & Onde & "", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                cb.Items.Add(reader.GetValue(0))
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarTB(Tabela, tb, Coluna)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select " & Coluna & " from " & Tabela & "", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                tb.text = reader.GetValue(0)
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarTB(Tabela, tb, Coluna, Coluna2, Onde, escolha)

        Try
            Conectar.Open()
            If escolha = 0 Then
                Dim Command As New SqlCommand("select " & Coluna & " from " & Tabela & " where " & Coluna2 & " = " & Onde & " ", Conectar)
                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                While (reader.Read)
                    tb.text = reader.GetValue(0)
                End While
                Conectar.Close()
            ElseIf escolha = 1 Then
                Dim Command As New SqlCommand("select " & Coluna & " from " & Tabela & " where " & Coluna2 & " = '" & Onde & "' ", Conectar)
                Dim reader As SqlDataReader
                reader = Command.ExecuteReader
                While (reader.Read)
                        tb.text = reader.GetValue(0)
                End While
                Conectar.Close()
            End If
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarFuncionario(cb1, cb2, cb3, ms1, ms2, ms3, ms4, ms5, ms8, tb1, tb3)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select * 
                                           from Funcionario where NIF = " & ms8.Text & "", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                tb1.Text = reader.GetValue(0)
                ms1.Text = reader.GetValue(1)
                ms2.Text = reader.GetValue(2)
                ms3.Text = reader.GetValue(3)
                tb3.Text = reader.GetValue(4)
                cb1.SelectedIndex = reader.GetValue(5)
                cb2.SelectedIndex = reader.GetValue(6)
                ms4.Text = reader.GetValue(7)
                ms5.Text = reader.GetValue(8)
                cb3.SelectedIndex = reader.GetValue(9)
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarEmpresa(tb1, tb2, tb3, tb4, tb5, onde)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select * from Empresa where Nome = '" & onde & "'  ", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                tb1.Text = reader.GetValue(1)
                tb2.Text = reader.GetValue(2)
                tb3.Text = reader.GetValue(3)
                tb4.Text = reader.GetValue(4)
                tb5.Text = reader.GetValue(5)
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarJogo(tb1, tb2, tb3, tb4, tb5, onde)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select * from Jogo where Nome = '" & onde & "'  ", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                tb1.Text = reader.GetValue(0)
                tb2.Text = reader.GetValue(1)
                tb3.Text = reader.GetValue(2)
                tb4.Text = reader.GetValue(3)
                tb5.Text = reader.GetValue(4)
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarEmpresa(tb1, tb2, tb3, tb4, tb5)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select * from Empresa", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                tb1.Text = reader.GetValue(0)
                tb2.Text = reader.GetValue(1)
                tb3.Text = reader.GetValue(2)
                tb4.Text = reader.GetValue(3)
                tb5.Text = reader.GetValue(4)
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub

    Public Sub BuscarProjeto(cb5, cb6, ms6, ms7, cb7)
        Try
            Conectar.Open()
            Dim Command As New SqlCommand("select * 
                                           from Grupo 
                                           where Funcionario = '" & cb5.text & "' and Jogo = '" & cb6.text & "'", Conectar)
            Dim reader As SqlDataReader
            reader = Command.ExecuteReader
            While (reader.Read)
                ms6.text = reader.GetValue(2)
                ms7.text = reader.GetValue(3)
                cb7.SelectedIndex = reader.GetValue(4)
            End While
            Conectar.Close()
        Catch ex As Exception
            MsgBox("Não foi possível carregar algum dos dados")
            Conectar.Close()
        End Try
    End Sub
End Class