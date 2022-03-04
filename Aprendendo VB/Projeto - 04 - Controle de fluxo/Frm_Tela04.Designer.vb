<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tela04
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Lbl_Idade = New System.Windows.Forms.Label()
        Me.Txt_Idade = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Lbl_Pais = New System.Windows.Forms.Label()
        Me.Txt_Pais = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(12, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clique Aqui"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "1 - Primeiro Projeto"
        '
        'Lbl_Idade
        '
        Me.Lbl_Idade.AutoSize = True
        Me.Lbl_Idade.Location = New System.Drawing.Point(25, 76)
        Me.Lbl_Idade.Name = "Lbl_Idade"
        Me.Lbl_Idade.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Idade.TabIndex = 2
        Me.Lbl_Idade.Text = "Label1"
        '
        'Txt_Idade
        '
        Me.Txt_Idade.Location = New System.Drawing.Point(70, 76)
        Me.Txt_Idade.Name = "Txt_Idade"
        Me.Txt_Idade.Size = New System.Drawing.Size(230, 20)
        Me.Txt_Idade.TabIndex = 3
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(70, 152)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(452, 20)
        Me.Txt_Resultado.TabIndex = 4
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(13, 155)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Resultado.TabIndex = 5
        Me.Lbl_Resultado.Text = "Label1"
        '
        'Lbl_Pais
        '
        Me.Lbl_Pais.AutoSize = True
        Me.Lbl_Pais.Location = New System.Drawing.Point(332, 79)
        Me.Lbl_Pais.Name = "Lbl_Pais"
        Me.Lbl_Pais.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_Pais.TabIndex = 6
        Me.Lbl_Pais.Text = "Lbl_Pais"
        '
        'Txt_Pais
        '
        Me.Txt_Pais.Location = New System.Drawing.Point(506, 76)
        Me.Txt_Pais.Name = "Txt_Pais"
        Me.Txt_Pais.Size = New System.Drawing.Size(230, 20)
        Me.Txt_Pais.TabIndex = 7
        '
        'Frm_Tela04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 661)
        Me.Controls.Add(Me.Txt_Pais)
        Me.Controls.Add(Me.Lbl_Pais)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_Idade)
        Me.Controls.Add(Me.Lbl_Idade)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Tela04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primeiro Programa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_Idade As Label
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Lbl_Pais As Label
    Friend WithEvents Txt_Pais As TextBox
End Class