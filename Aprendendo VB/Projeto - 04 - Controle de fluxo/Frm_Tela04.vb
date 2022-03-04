Public Class Frm_Tela04
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_NomeProjeto.Text = "4 - Controle de Fluxo"
        Button1.Text = "Checagem de permissão de entrada"
        Me.Text = "Controle de Fluxo"

        Lbl_Idade.Text = "Idade"
        Lbl_Resultado.Text = "Resultado"
        Lbl_Pais.Text = "Esta acompanhado dos pais? (S/N)"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Txt_Resultado.Text = ""
        Dim idade As Integer
        idade = Txt_Idade.Text
        Dim acompanhado As String
        acompanhado = Txt_Pais.Text.ToUpper

        If (idade >= 18) Then

            Txt_Resultado.Text = "Acesso confirmado"

        Else

            If acompanhado = "S" And idade > 15 Then

                Txt_Resultado.Text = "Acesso permitido. Pessoa menor de idade, porem, acompanhada dos pais"

            Else

                If acompanhado = "N" And idade > 15 Then
                    Txt_Resultado.Text = "Acesso negado. Pessoa menor de idade e sem acompanhamento dos pais"


                Else
                    Txt_Resultado.Text = "Acesso negado. Pessoa menor de idade"

                End If

            End If

        End If
    End Sub

End Class
