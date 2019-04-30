<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forminicial
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
        Me.TextBoxlogin = New System.Windows.Forms.TextBox()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Buttonautenticar = New System.Windows.Forms.Button()
        Me.ButtonSignup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxlogin
        '
        Me.TextBoxlogin.Location = New System.Drawing.Point(334, 119)
        Me.TextBoxlogin.Name = "TextBoxlogin"
        Me.TextBoxlogin.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxlogin.TabIndex = 0
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Location = New System.Drawing.Point(334, 210)
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxpassword.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxpassword.TabIndex = 1
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.Location = New System.Drawing.Point(135, 126)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(33, 13)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Buttonautenticar
        '
        Me.Buttonautenticar.Location = New System.Drawing.Point(287, 281)
        Me.Buttonautenticar.Name = "Buttonautenticar"
        Me.Buttonautenticar.Size = New System.Drawing.Size(133, 60)
        Me.Buttonautenticar.TabIndex = 4
        Me.Buttonautenticar.Text = "Autenticar"
        Me.Buttonautenticar.UseVisualStyleBackColor = True
        '
        'ButtonSignup
        '
        Me.ButtonSignup.Location = New System.Drawing.Point(525, 281)
        Me.ButtonSignup.Name = "ButtonSignup"
        Me.ButtonSignup.Size = New System.Drawing.Size(114, 60)
        Me.ButtonSignup.TabIndex = 5
        Me.ButtonSignup.Text = "Sign Up"
        Me.ButtonSignup.UseVisualStyleBackColor = True
        '
        'Forminicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 395)
        Me.Controls.Add(Me.ButtonSignup)
        Me.Controls.Add(Me.Buttonautenticar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.TextBoxpassword)
        Me.Controls.Add(Me.TextBoxlogin)
        Me.Name = "Forminicial"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxlogin As TextBox
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents Login As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Buttonautenticar As Button
    Friend WithEvents ButtonSignup As Button
End Class
