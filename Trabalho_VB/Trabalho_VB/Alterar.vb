Public Class Alterar
    Private Ap As New Apoio
    Private Ca As New C_Alterar
    Private Sub Alterar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Ap.BuscarCB("Empresa", ComboBox1, "Nome")
        Ap.BuscarCB("Empresa", ComboBox4, "Nome")
        Ap.BuscarCB("Cargo", ComboBox2, "Nome")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ap.BuscarFuncionario(ComboBox1, ComboBox2, ComboBox3,
                             MaskedTextBox1, MaskedTextBox2, MaskedTextBox3,
                             MaskedTextBox4, MaskedTextBox5, MaskedTextBox8,
                             TextBox1, TextBox3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ca.AtaluzarFuncionario(ComboBox1, ComboBox2, ComboBox3,
                             MaskedTextBox1, MaskedTextBox2, MaskedTextBox3,
                             MaskedTextBox4, MaskedTextBox5, MaskedTextBox8,
                             TextBox1, TextBox3)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ca.ApagarFuncionario(MaskedTextBox8)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Ap.BuscarProjeto(ComboBox5, ComboBox6, MaskedTextBox6, MaskedTextBox7, ComboBox7)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()

        Ap.BuscarCB("Funcionario", ComboBox5, "Nome", "Empresa", (ComboBox4.SelectedIndex + 1))
        Ap.BuscarCB("Jogo", ComboBox6, "Nome", "Empresa", (ComboBox4.SelectedIndex + 1))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ca.AtualizarProjeto(ComboBox5, ComboBox6, ComboBox7, MaskedTextBox6, MaskedTextBox7)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Ca.ApagarProjeto(ComboBox5, ComboBox6)
    End Sub
End Class