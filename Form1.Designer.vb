<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NupPasswordSize = New System.Windows.Forms.NumericUpDown()
        Me.CbxSymbole = New System.Windows.Forms.CheckBox()
        Me.CbxNumber = New System.Windows.Forms.CheckBox()
        Me.CbxLower = New System.Windows.Forms.CheckBox()
        Me.CbxUpper = New System.Windows.Forms.CheckBox()
        Me.CbxSimilar = New System.Windows.Forms.CheckBox()
        Me.CbxAmbigu = New System.Windows.Forms.CheckBox()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        CType(Me.NupPasswordSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Longueur du mot de passe:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inclure des symboles:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inclure des nombres:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Inclure des charactères minuscules:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Inclure des charactères majuscules:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(303, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Exclure les charactères similaires:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(303, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Exclure les charactères ambigus:"
        '
        'NupPasswordSize
        '
        Me.NupPasswordSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupPasswordSize.Location = New System.Drawing.Point(321, 43)
        Me.NupPasswordSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NupPasswordSize.Name = "NupPasswordSize"
        Me.NupPasswordSize.ReadOnly = True
        Me.NupPasswordSize.Size = New System.Drawing.Size(203, 26)
        Me.NupPasswordSize.TabIndex = 7
        Me.NupPasswordSize.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'CbxSymbole
        '
        Me.CbxSymbole.AutoSize = True
        Me.CbxSymbole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSymbole.Location = New System.Drawing.Point(321, 75)
        Me.CbxSymbole.Name = "CbxSymbole"
        Me.CbxSymbole.Size = New System.Drawing.Size(188, 24)
        Me.CbxSymbole.TabIndex = 8
        Me.CbxSymbole.Text = "( par exemple, @#$% )"
        Me.CbxSymbole.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CbxSymbole.UseVisualStyleBackColor = True
        '
        'CbxNumber
        '
        Me.CbxNumber.AutoSize = True
        Me.CbxNumber.Checked = True
        Me.CbxNumber.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxNumber.Location = New System.Drawing.Point(321, 105)
        Me.CbxNumber.Name = "CbxNumber"
        Me.CbxNumber.Size = New System.Drawing.Size(194, 24)
        Me.CbxNumber.TabIndex = 9
        Me.CbxNumber.Text = "( par exemple, 123456 )"
        Me.CbxNumber.UseVisualStyleBackColor = True
        '
        'CbxLower
        '
        Me.CbxLower.AutoSize = True
        Me.CbxLower.Checked = True
        Me.CbxLower.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbxLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxLower.Location = New System.Drawing.Point(321, 136)
        Me.CbxLower.Name = "CbxLower"
        Me.CbxLower.Size = New System.Drawing.Size(207, 24)
        Me.CbxLower.TabIndex = 10
        Me.CbxLower.Text = "( par exemple, abcdefgh )"
        Me.CbxLower.UseVisualStyleBackColor = True
        '
        'CbxUpper
        '
        Me.CbxUpper.AutoSize = True
        Me.CbxUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxUpper.Location = New System.Drawing.Point(321, 168)
        Me.CbxUpper.Name = "CbxUpper"
        Me.CbxUpper.Size = New System.Drawing.Size(231, 24)
        Me.CbxUpper.TabIndex = 11
        Me.CbxUpper.Text = "( par exemple, ABCDEFGH )"
        Me.CbxUpper.UseVisualStyleBackColor = True
        '
        'CbxSimilar
        '
        Me.CbxSimilar.AutoSize = True
        Me.CbxSimilar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSimilar.Location = New System.Drawing.Point(321, 196)
        Me.CbxSimilar.Name = "CbxSimilar"
        Me.CbxSimilar.Size = New System.Drawing.Size(242, 24)
        Me.CbxSimilar.TabIndex = 12
        Me.CbxSimilar.Text = "( par exemple, i, l, 1, L, o, 0, O )"
        Me.CbxSimilar.UseVisualStyleBackColor = True
        '
        'CbxAmbigu
        '
        Me.CbxAmbigu.AutoSize = True
        Me.CbxAmbigu.Checked = True
        Me.CbxAmbigu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbxAmbigu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxAmbigu.Location = New System.Drawing.Point(321, 229)
        Me.CbxAmbigu.Name = "CbxAmbigu"
        Me.CbxAmbigu.Size = New System.Drawing.Size(207, 24)
        Me.CbxAmbigu.TabIndex = 13
        Me.CbxAmbigu.Text = "( { } [ ] ( ) / \ ' "" ` ~ , ; : . < > )"
        Me.CbxAmbigu.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.ForeColor = System.Drawing.Color.Blue
        Me.BtnCreate.Location = New System.Drawing.Point(123, 303)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(216, 33)
        Me.BtnCreate.TabIndex = 14
        Me.BtnCreate.Text = "Créer un mot de passe"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.ForeColor = System.Drawing.Color.Blue
        Me.BtnCopy.Location = New System.Drawing.Point(367, 303)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(75, 33)
        Me.BtnCopy.TabIndex = 15
        Me.BtnCopy.Text = "Copie"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.ForestGreen
        Me.TxtPassword.Location = New System.Drawing.Point(16, 349)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(561, 29)
        Me.TxtPassword.TabIndex = 16
        Me.TxtPassword.Text = "Votre nouveau mot de passe apparaîtra ici."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 392)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.CbxAmbigu)
        Me.Controls.Add(Me.CbxSimilar)
        Me.Controls.Add(Me.CbxUpper)
        Me.Controls.Add(Me.CbxLower)
        Me.Controls.Add(Me.CbxNumber)
        Me.Controls.Add(Me.CbxSymbole)
        Me.Controls.Add(Me.NupPasswordSize)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Génerateur de mots de passe"
        CType(Me.NupPasswordSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NupPasswordSize As NumericUpDown
    Friend WithEvents CbxSymbole As CheckBox
    Friend WithEvents CbxNumber As CheckBox
    Friend WithEvents CbxLower As CheckBox
    Friend WithEvents CbxUpper As CheckBox
    Friend WithEvents CbxSimilar As CheckBox
    Friend WithEvents CbxAmbigu As CheckBox
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents TxtPassword As TextBox
End Class
