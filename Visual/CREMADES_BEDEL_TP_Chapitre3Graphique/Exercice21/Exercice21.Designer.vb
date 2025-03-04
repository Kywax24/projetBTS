<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercice21
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.premierNombre = New System.Windows.Forms.Label()
        Me.deuxiemeNombre = New System.Windows.Forms.Label()
        Me.txtNbr2 = New System.Windows.Forms.TextBox()
        Me.txtNbr1 = New System.Windows.Forms.TextBox()
        Me.buttonFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'premierNombre
        '
        Me.premierNombre.AutoSize = True
        Me.premierNombre.Location = New System.Drawing.Point(40, 52)
        Me.premierNombre.Name = "premierNombre"
        Me.premierNombre.Size = New System.Drawing.Size(142, 13)
        Me.premierNombre.TabIndex = 0
        Me.premierNombre.Text = "Premier nombre à comparer :"
        '
        'deuxiemeNombre
        '
        Me.deuxiemeNombre.AutoSize = True
        Me.deuxiemeNombre.Location = New System.Drawing.Point(40, 100)
        Me.deuxiemeNombre.Name = "deuxiemeNombre"
        Me.deuxiemeNombre.Size = New System.Drawing.Size(154, 13)
        Me.deuxiemeNombre.TabIndex = 1
        Me.deuxiemeNombre.Text = "Deuxième nombre à comparer :"
        '
        'txtNbr2
        '
        Me.txtNbr2.Location = New System.Drawing.Point(208, 97)
        Me.txtNbr2.Name = "txtNbr2"
        Me.txtNbr2.Size = New System.Drawing.Size(100, 20)
        Me.txtNbr2.TabIndex = 3
        '
        'txtNbr1
        '
        Me.txtNbr1.Location = New System.Drawing.Point(208, 49)
        Me.txtNbr1.Name = "txtNbr1"
        Me.txtNbr1.Size = New System.Drawing.Size(100, 20)
        Me.txtNbr1.TabIndex = 2
        '
        'buttonFermer
        '
        Me.buttonFermer.Location = New System.Drawing.Point(208, 151)
        Me.buttonFermer.Name = "buttonFermer"
        Me.buttonFermer.Size = New System.Drawing.Size(100, 23)
        Me.buttonFermer.TabIndex = 4
        Me.buttonFermer.Text = "Fermer"
        Me.buttonFermer.UseVisualStyleBackColor = True
        '
        'Exercice21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 217)
        Me.Controls.Add(Me.buttonFermer)
        Me.Controls.Add(Me.txtNbr1)
        Me.Controls.Add(Me.txtNbr2)
        Me.Controls.Add(Me.deuxiemeNombre)
        Me.Controls.Add(Me.premierNombre)
        Me.Name = "Exercice21"
        Me.Text = "Exercice 21 - Comparaison de 2 nombres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents premierNombre As Label
    Friend WithEvents deuxiemeNombre As Label
    Friend WithEvents txtNbr2 As TextBox
    Friend WithEvents txtNbr1 As TextBox
    Friend WithEvents buttonFermer As Button
End Class
