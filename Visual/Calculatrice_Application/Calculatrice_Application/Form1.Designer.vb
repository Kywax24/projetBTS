<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fenetreExemple1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fenetreExemple1))
        Me.LabelNombre1 = New System.Windows.Forms.Label()
        Me.LabelNombre2 = New System.Windows.Forms.Label()
        Me.LabelResultat = New System.Windows.Forms.Label()
        Me.ButtonCalcul = New System.Windows.Forms.Button()
        Me.TextNombre1 = New System.Windows.Forms.TextBox()
        Me.TextNombre2 = New System.Windows.Forms.TextBox()
        Me.TextResultat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelNombre1
        '
        Me.LabelNombre1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelNombre1.AutoSize = True
        Me.LabelNombre1.BackColor = System.Drawing.Color.Transparent
        Me.LabelNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre1.ForeColor = System.Drawing.Color.Black
        Me.LabelNombre1.Location = New System.Drawing.Point(183, 67)
        Me.LabelNombre1.Name = "LabelNombre1"
        Me.LabelNombre1.Size = New System.Drawing.Size(129, 20)
        Me.LabelNombre1.TabIndex = 0
        Me.LabelNombre1.Text = "Premier nombre :"
        '
        'LabelNombre2
        '
        Me.LabelNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelNombre2.AutoSize = True
        Me.LabelNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre2.ForeColor = System.Drawing.Color.Black
        Me.LabelNombre2.Location = New System.Drawing.Point(183, 145)
        Me.LabelNombre2.Name = "LabelNombre2"
        Me.LabelNombre2.Size = New System.Drawing.Size(146, 20)
        Me.LabelNombre2.TabIndex = 1
        Me.LabelNombre2.Text = "Deuxième nombre :"
        '
        'LabelResultat
        '
        Me.LabelResultat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelResultat.AutoSize = True
        Me.LabelResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResultat.ForeColor = System.Drawing.Color.Black
        Me.LabelResultat.Location = New System.Drawing.Point(183, 293)
        Me.LabelResultat.Name = "LabelResultat"
        Me.LabelResultat.Size = New System.Drawing.Size(77, 20)
        Me.LabelResultat.TabIndex = 2
        Me.LabelResultat.Text = "Résultat :"
        '
        'ButtonCalcul
        '
        Me.ButtonCalcul.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonCalcul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalcul.Location = New System.Drawing.Point(271, 214)
        Me.ButtonCalcul.Name = "ButtonCalcul"
        Me.ButtonCalcul.Size = New System.Drawing.Size(105, 33)
        Me.ButtonCalcul.TabIndex = 3
        Me.ButtonCalcul.Text = "Calculer"
        Me.ButtonCalcul.UseVisualStyleBackColor = True
        '
        'TextNombre1
        '
        Me.TextNombre1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombre1.Location = New System.Drawing.Point(367, 64)
        Me.TextNombre1.Name = "TextNombre1"
        Me.TextNombre1.Size = New System.Drawing.Size(100, 26)
        Me.TextNombre1.TabIndex = 4
        '
        'TextNombre2
        '
        Me.TextNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombre2.Location = New System.Drawing.Point(367, 142)
        Me.TextNombre2.Name = "TextNombre2"
        Me.TextNombre2.Size = New System.Drawing.Size(100, 26)
        Me.TextNombre2.TabIndex = 5
        '
        'TextResultat
        '
        Me.TextResultat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextResultat.Location = New System.Drawing.Point(367, 290)
        Me.TextResultat.Name = "TextResultat"
        Me.TextResultat.Size = New System.Drawing.Size(100, 26)
        Me.TextResultat.TabIndex = 6
        '
        'fenetreExemple1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.TextResultat)
        Me.Controls.Add(Me.TextNombre2)
        Me.Controls.Add(Me.TextNombre1)
        Me.Controls.Add(Me.ButtonCalcul)
        Me.Controls.Add(Me.LabelResultat)
        Me.Controls.Add(Me.LabelNombre2)
        Me.Controls.Add(Me.LabelNombre1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fenetreExemple1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ma première fenêtre - Somme de 2 nombres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNombre1 As Label
    Friend WithEvents LabelNombre2 As Label
    Friend WithEvents LabelResultat As Label
    Friend WithEvents ButtonCalcul As Button
    Friend WithEvents TextNombre1 As TextBox
    Friend WithEvents TextNombre2 As TextBox
    Friend WithEvents TextResultat As TextBox
End Class
