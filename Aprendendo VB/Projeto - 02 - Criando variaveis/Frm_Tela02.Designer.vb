<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tela02
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btm_NumeroInteger = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_NumeroFloat = New System.Windows.Forms.Button()
        Me.Btm_ConversaoNumero = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Btm_Resultado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_NumeroInteger
        '
        Me.Btm_NumeroInteger.Location = New System.Drawing.Point(55, 252)
        Me.Btm_NumeroInteger.Name = "Btm_NumeroInteger"
        Me.Btm_NumeroInteger.Size = New System.Drawing.Size(349, 140)
        Me.Btm_NumeroInteger.TabIndex = 0
        Me.Btm_NumeroInteger.Text = "Exemplos de números inteiros"
        Me.Btm_NumeroInteger.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(726, 23)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "2 - Criando Variaveis"
        '
        'Btm_NumeroFloat
        '
        Me.Btm_NumeroFloat.Location = New System.Drawing.Point(55, 82)
        Me.Btm_NumeroFloat.Name = "Btm_NumeroFloat"
        Me.Btm_NumeroFloat.Size = New System.Drawing.Size(349, 140)
        Me.Btm_NumeroFloat.TabIndex = 3
        Me.Btm_NumeroFloat.Text = "Exemplos de números flutuantes"
        Me.Btm_NumeroFloat.UseVisualStyleBackColor = True
        '
        'Btm_ConversaoNumero
        '
        Me.Btm_ConversaoNumero.Location = New System.Drawing.Point(55, 440)
        Me.Btm_ConversaoNumero.Name = "Btm_ConversaoNumero"
        Me.Btm_ConversaoNumero.Size = New System.Drawing.Size(349, 140)
        Me.Btm_ConversaoNumero.TabIndex = 4
        Me.Btm_ConversaoNumero.Text = "Conversão de numeros"
        Me.Btm_ConversaoNumero.UseVisualStyleBackColor = True
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(443, 109)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(270, 20)
        Me.Txt_Numerador.TabIndex = 5
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(443, 135)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(270, 20)
        Me.Txt_Denominador.TabIndex = 6
        '
        'Btm_Resultado
        '
        Me.Btm_Resultado.Location = New System.Drawing.Point(443, 161)
        Me.Btm_Resultado.Name = "Btm_Resultado"
        Me.Btm_Resultado.Size = New System.Drawing.Size(270, 23)
        Me.Btm_Resultado.TabIndex = 7
        Me.Btm_Resultado.Text = "Resultado"
        Me.Btm_Resultado.UseVisualStyleBackColor = True
        '
        'Frm_Tela02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 661)
        Me.Controls.Add(Me.Btm_Resultado)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.Btm_ConversaoNumero)
        Me.Controls.Add(Me.Btm_NumeroFloat)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_NumeroInteger)
        Me.Name = "Frm_Tela02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primeiro Programa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_NumeroInteger As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_NumeroFloat As Button
    Friend WithEvents Btm_ConversaoNumero As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btm_Resultado As Button
End Class
