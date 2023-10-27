Public Class Adicionar
    Private Ap As New Apoio
    Private Ca As New C_Adicionar
    Private Sub Adicionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Ap.BuscarCB("Empresa", ComboBox1, "Nome")
        Ap.BuscarCB("Empresa", ComboBox4, "Nome")
        Ap.BuscarCB("Cargo", ComboBox2, "Nome")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ca.AdicionarFuncionario(ComboBox1, ComboBox2, ComboBox3,
                     MaskedTextBox1, MaskedTextBox2, MaskedTextBox3,
                     MaskedTextBox4, MaskedTextBox5,
                     TextBox1, TextBox3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()

        Ap.BuscarCB("Funcionario", ComboBox5, "Nome", "Empresa", (ComboBox4.SelectedIndex + 1))
        Ap.BuscarCB("Jogo", ComboBox6, "Nome", "Empresa", (ComboBox4.SelectedIndex + 1))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ca.AdicionarProjeto(ComboBox5, ComboBox6, ComboBox7, MaskedTextBox6, MaskedTextBox7)
    End Sub
End Class