Public Class Frm_ManipulandoTexto

    Dim listaCurso As String

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        'mundando os valores dinamicamente pelo codigo'
        Lbl_NomeProjeto.Text = "Manipulando textos"
        Button1.Text = "Clique para ver os resultados"
        Me.Text = "Aprendendo a manipular textos"
        Btm_Char.Text = "Clique para obter o character"
        Lbl_Curso.Text = "Digite o seu curso preferido"
        Btm_Adicionar.Text = "Adicione a sua lista"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim primeiraLetra As Char = "a"
        MsgBox("o caracter da var primeiraLetra é = " + primeiraLetra)


        Dim segundaLetra As Char = Chr(65)
        MsgBox("o caracter da var segundaLetra é = " + segundaLetra)

    End Sub

    Private Sub Btm_Char_Click(sender As Object, e As EventArgs) Handles Btm_Char.Click

        Dim valorChar As Integer = Val(Txt_NumeroChar.Text)
        Dim quintaLetra As Char = Chr(valorChar)

        MsgBox("o caracter para o numero " + valorChar.ToString + " é " + quintaLetra)
    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        Dim cursoDigitado As String = Txt_Curso.Text

        'Quebra de linha no vb é (vbCrLf)
        listaCurso += cursoDigitado + vbCrLf
        Txt_Lista.Text = listaCurso

    End Sub
End Class
