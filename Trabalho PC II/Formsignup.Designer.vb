<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formsignup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.TextBoxSexo = New System.Windows.Forms.TextBox()
        Me.TextBoxDatanascimento = New System.Windows.Forms.TextBox()
        Me.TextBoxIDNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Buttoncriar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de nascimento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(265, 27)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNome.TabIndex = 5
        '
        'TextBoxSexo
        '
        Me.TextBoxSexo.Location = New System.Drawing.Point(265, 76)
        Me.TextBoxSexo.Name = "TextBoxSexo"
        Me.TextBoxSexo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSexo.TabIndex = 6
        '
        'TextBoxDatanascimento
        '
        Me.TextBoxDatanascimento.Location = New System.Drawing.Point(265, 126)
        Me.TextBoxDatanascimento.Name = "TextBoxDatanascimento"
        Me.TextBoxDatanascimento.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDatanascimento.TabIndex = 7
        '
        'TextBoxIDNumber
        '
        Me.TextBoxIDNumber.Location = New System.Drawing.Point(265, 175)
        Me.TextBoxIDNumber.Name = "TextBoxIDNumber"
        Me.TextBoxIDNumber.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDNumber.TabIndex = 8
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(265, 214)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPassword.TabIndex = 9
        '
        'Buttoncriar
        '
        Me.Buttoncriar.Location = New System.Drawing.Point(206, 254)
        Me.Buttoncriar.Name = "Buttoncriar"
        Me.Buttoncriar.Size = New System.Drawing.Size(102, 60)
        Me.Buttoncriar.TabIndex = 10
        Me.Buttoncriar.Text = "Criar"
        Me.Buttoncriar.UseVisualStyleBackColor = True
        '
        'Formsignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 342)
        Me.Controls.Add(Me.Buttoncriar)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxIDNumber)
        Me.Controls.Add(Me.TextBoxDatanascimento)
        Me.Controls.Add(Me.TextBoxSexo)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formsignup"
        Me.Text = "Formsignup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents TextBoxSexo As TextBox
    Friend WithEvents TextBoxDatanascimento As TextBox
    Friend WithEvents TextBoxIDNumber As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Buttoncriar As Button
End Class
