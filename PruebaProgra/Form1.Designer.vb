<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnNegro = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(202, 30)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(350, 206)
        Me.txtColores.TabIndex = 11
        '
        'btnVerde
        '
        Me.btnVerde.Location = New System.Drawing.Point(49, 213)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(75, 23)
        Me.btnVerde.TabIndex = 10
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = True
        '
        'btnAmarillo
        '
        Me.btnAmarillo.Location = New System.Drawing.Point(49, 167)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(75, 23)
        Me.btnAmarillo.TabIndex = 9
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = True
        '
        'btnNegro
        '
        Me.btnNegro.Location = New System.Drawing.Point(49, 120)
        Me.btnNegro.Name = "btnNegro"
        Me.btnNegro.Size = New System.Drawing.Size(75, 23)
        Me.btnNegro.TabIndex = 8
        Me.btnNegro.Text = "Negro"
        Me.btnNegro.UseVisualStyleBackColor = True
        '
        'btnAzul
        '
        Me.btnAzul.Location = New System.Drawing.Point(49, 74)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(75, 23)
        Me.btnAzul.TabIndex = 7
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(49, 30)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 23)
        Me.btnRojo.TabIndex = 6
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(596, 291)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.btnNegro)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtColores As TextBox
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnAmarillo As Button
    Friend WithEvents btnNegro As Button
    Friend WithEvents btnAzul As Button
    Friend WithEvents btnRojo As Button
End Class
