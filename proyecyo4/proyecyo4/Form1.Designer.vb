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
        Me.Caja1 = New System.Windows.Forms.TextBox()
        Me.Etiqueta1 = New System.Windows.Forms.Label()
        Me.Boton = New System.Windows.Forms.Button()
        Me.Etiqueta2 = New System.Windows.Forms.Label()
        Me.Caja2 = New System.Windows.Forms.TextBox()
        Me.Etiqueta3 = New System.Windows.Forms.Label()
        Me.Etiqueta4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Caja1
        '
        Me.Caja1.Location = New System.Drawing.Point(240, 72)
        Me.Caja1.Name = "Caja1"
        Me.Caja1.Size = New System.Drawing.Size(204, 20)
        Me.Caja1.TabIndex = 0
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Romantic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Etiqueta1.Location = New System.Drawing.Point(169, 73)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(65, 16)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Número 1"
        '
        'Boton
        '
        Me.Boton.Font = New System.Drawing.Font("Romantic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton.Location = New System.Drawing.Point(450, 72)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(124, 64)
        Me.Boton.TabIndex = 2
        Me.Boton.Text = "Suma"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Romantic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Etiqueta2.Location = New System.Drawing.Point(169, 117)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(65, 16)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Número 2"
        '
        'Caja2
        '
        Me.Caja2.Location = New System.Drawing.Point(240, 116)
        Me.Caja2.Name = "Caja2"
        Me.Caja2.Size = New System.Drawing.Size(204, 20)
        Me.Caja2.TabIndex = 4
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Romantic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Etiqueta3.Location = New System.Drawing.Point(169, 182)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(67, 16)
        Me.Etiqueta3.TabIndex = 5
        Me.Etiqueta3.Text = "Resultado:"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Cambria Math", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Red
        Me.Etiqueta4.Location = New System.Drawing.Point(242, 153)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(0, 78)
        Me.Etiqueta4.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 344)
        Me.Controls.Add(Me.Etiqueta4)
        Me.Controls.Add(Me.Etiqueta3)
        Me.Controls.Add(Me.Caja2)
        Me.Controls.Add(Me.Etiqueta2)
        Me.Controls.Add(Me.Boton)
        Me.Controls.Add(Me.Etiqueta1)
        Me.Controls.Add(Me.Caja1)
        Me.Font = New System.Drawing.Font("Romantic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Caja1 As TextBox
    Friend WithEvents Etiqueta1 As Label
    Friend WithEvents Boton As Button
    Friend WithEvents Etiqueta2 As Label
    Friend WithEvents Caja2 As TextBox
    Friend WithEvents Etiqueta3 As Label
    Friend WithEvents Etiqueta4 As Label
End Class
