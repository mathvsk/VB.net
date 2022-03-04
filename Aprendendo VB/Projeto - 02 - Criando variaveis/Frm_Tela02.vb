Public Class Frm_Tela02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btm_NumeroInteger.Click

        'Criando uma variavel do tipo numerico'
        Dim idade As Integer
        idade = 22

        'Plotando a mensagem na tela'
        MsgBox("Sua idade é: " + idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * 5
        MsgBox("Sua idade x5 é = " + idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * (5 + 10)
        MsgBox(idade, MsgBoxStyle.Critical)
    End Sub

    Private Sub Btm_NumeroFloat_Click(sender As Object, e As EventArgs) Handles Btm_NumeroFloat.Click

        'Double == Float'
        Dim valor As Double
        valor = 8.7
        MsgBox("Valor é = " + valor.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btm_ConversaoNumero_Click(sender As Object, e As EventArgs) Handles Btm_ConversaoNumero.Click

        Dim salario As Double
        salario = 2500.56

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O salario é = " + salario.ToString + " O salario inteiro é = " + salarioInteiro.ToString, MsgBoxStyle.Critical)

        'SHORT = uma boa pratica declarar um numero como short quando ele for pequeno '
        'Long = quando um numero For muito grande é interessante declarar como Long (essas declarações vao influenciar no espaço de memória)'
        'LONG = 64 bits, INTEGER = 32 bits, SHORT = 16 bits e SBYTE = 8 bits


    End Sub

    Private Sub Btm_Resultado_Click(sender As Object, e As EventArgs) Handles Btm_Resultado.Click

        Dim numerador As Double
        Dim denominador As Double

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text

        Dim res As Double
        res = numerador / denominador

        'para quebrar linha é preciso colocar o " _ (underscore) " '
        MsgBox("O resultado de: " + numerador.ToString + "/" + denominador.ToString _
               + " é = " + res.ToString, MsgBoxStyle.Critical)

    End Sub
End Class
