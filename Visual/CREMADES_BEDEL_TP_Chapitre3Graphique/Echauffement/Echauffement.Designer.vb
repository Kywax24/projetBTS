<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Echauffement
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
        Me.labNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.bFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Location = New System.Drawing.Point(33, 60)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(93, 13)
        Me.labNombre.TabIndex = 0
        Me.labNombre.Text = "Nombre à vérifier :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(140, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        '
        'bFermer
        '
        Me.bFermer.Location = New System.Drawing.Point(202, 124)
        Me.bFermer.Name = "bFermer"
        Me.bFermer.Size = New System.Drawing.Size(75, 23)
        Me.bFermer.TabIndex = 2
        Me.bFermer.Text = "Fermer"
        Me.bFermer.UseVisualStyleBackColor = True
        '
        'Echauffement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 179)
        Me.Controls.Add(Me.bFermer)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.labNombre)
        Me.Name = "Echauffement"
        Me.Text = "Echauffement - Multiple de 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents bFermer As Button
End Class
