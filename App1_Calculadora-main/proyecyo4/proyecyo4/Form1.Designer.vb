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
        Me.Num1 = New System.Windows.Forms.TextBox()
        Me.Etiqueta1 = New System.Windows.Forms.Label()
        Me.Mas = New System.Windows.Forms.Button()
        Me.Etiqueta2 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.TextBox()
        Me.Etiqueta3 = New System.Windows.Forms.Label()
        Me.Etiqueta4 = New System.Windows.Forms.Label()
        Me.Resta = New System.Windows.Forms.Button()
        Me.Por = New System.Windows.Forms.Button()
        Me.Dividir = New System.Windows.Forms.Button()
        Me.Boton0 = New System.Windows.Forms.Button()
        Me.Boton2 = New System.Windows.Forms.Button()
        Me.Boton3 = New System.Windows.Forms.Button()
        Me.Boton1 = New System.Windows.Forms.Button()
        Me.Boton4 = New System.Windows.Forms.Button()
        Me.Boton5 = New System.Windows.Forms.Button()
        Me.Boton6 = New System.Windows.Forms.Button()
        Me.Boton7 = New System.Windows.Forms.Button()
        Me.Boton8 = New System.Windows.Forms.Button()
        Me.Boton9 = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(101, 9)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(204, 20)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "0"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Romantic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Etiqueta1.Location = New System.Drawing.Point(31, 10)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(65, 16)
        Me.Etiqueta1.TabIndex = 1
        Me.Etiqueta1.Text = "Número 1"
        '
        'Mas
        '
        Me.Mas.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Mas.Location = New System.Drawing.Point(204, 146)
        Me.Mas.Name = "Mas"
        Me.Mas.Size = New System.Drawing.Size(104, 71)
        Me.Mas.TabIndex = 2
        Me.Mas.Text = "+"
        Me.Mas.UseVisualStyleBackColor = True
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Romantic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Etiqueta2.Location = New System.Drawing.Point(31, 54)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(65, 16)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Número 2"
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(102, 53)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(204, 20)
        Me.Num2.TabIndex = 4
        Me.Num2.Text = "0"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Romantic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Etiqueta3.Location = New System.Drawing.Point(31, 105)
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
        Me.Etiqueta4.Location = New System.Drawing.Point(104, 76)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(42, 78)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "0"
        '
        'Resta
        '
        Me.Resta.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Resta.Location = New System.Drawing.Point(204, 214)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(104, 67)
        Me.Resta.TabIndex = 7
        Me.Resta.Text = "-"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Por
        '
        Me.Por.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Por.Location = New System.Drawing.Point(204, 282)
        Me.Por.Name = "Por"
        Me.Por.Size = New System.Drawing.Size(104, 68)
        Me.Por.TabIndex = 8
        Me.Por.Text = "x"
        Me.Por.UseVisualStyleBackColor = True
        '
        'Dividir
        '
        Me.Dividir.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Dividir.Location = New System.Drawing.Point(204, 350)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(104, 61)
        Me.Dividir.TabIndex = 9
        Me.Dividir.Text = "/"
        Me.Dividir.UseVisualStyleBackColor = True
        '
        'Boton0
        '
        Me.Boton0.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton0.Location = New System.Drawing.Point(75, 350)
        Me.Boton0.Name = "Boton0"
        Me.Boton0.Size = New System.Drawing.Size(58, 62)
        Me.Boton0.TabIndex = 10
        Me.Boton0.Text = "0"
        Me.Boton0.UseVisualStyleBackColor = True
        '
        'Boton2
        '
        Me.Boton2.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton2.Location = New System.Drawing.Point(75, 282)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(58, 62)
        Me.Boton2.TabIndex = 11
        Me.Boton2.Text = "2"
        Me.Boton2.UseVisualStyleBackColor = True
        '
        'Boton3
        '
        Me.Boton3.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton3.Location = New System.Drawing.Point(139, 282)
        Me.Boton3.Name = "Boton3"
        Me.Boton3.Size = New System.Drawing.Size(58, 62)
        Me.Boton3.TabIndex = 13
        Me.Boton3.Text = "3"
        Me.Boton3.UseVisualStyleBackColor = True
        '
        'Boton1
        '
        Me.Boton1.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton1.Location = New System.Drawing.Point(11, 282)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(58, 62)
        Me.Boton1.TabIndex = 12
        Me.Boton1.Text = "1"
        Me.Boton1.UseVisualStyleBackColor = True
        '
        'Boton4
        '
        Me.Boton4.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton4.Location = New System.Drawing.Point(11, 214)
        Me.Boton4.Name = "Boton4"
        Me.Boton4.Size = New System.Drawing.Size(58, 62)
        Me.Boton4.TabIndex = 14
        Me.Boton4.Text = "4"
        Me.Boton4.UseVisualStyleBackColor = True
        '
        'Boton5
        '
        Me.Boton5.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton5.Location = New System.Drawing.Point(75, 214)
        Me.Boton5.Name = "Boton5"
        Me.Boton5.Size = New System.Drawing.Size(58, 62)
        Me.Boton5.TabIndex = 15
        Me.Boton5.Text = "5"
        Me.Boton5.UseVisualStyleBackColor = True
        '
        'Boton6
        '
        Me.Boton6.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton6.Location = New System.Drawing.Point(139, 214)
        Me.Boton6.Name = "Boton6"
        Me.Boton6.Size = New System.Drawing.Size(58, 62)
        Me.Boton6.TabIndex = 16
        Me.Boton6.Text = "6"
        Me.Boton6.UseVisualStyleBackColor = True
        '
        'Boton7
        '
        Me.Boton7.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton7.Location = New System.Drawing.Point(11, 146)
        Me.Boton7.Name = "Boton7"
        Me.Boton7.Size = New System.Drawing.Size(58, 62)
        Me.Boton7.TabIndex = 17
        Me.Boton7.Text = "7"
        Me.Boton7.UseVisualStyleBackColor = True
        '
        'Boton8
        '
        Me.Boton8.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton8.Location = New System.Drawing.Point(75, 146)
        Me.Boton8.Name = "Boton8"
        Me.Boton8.Size = New System.Drawing.Size(58, 62)
        Me.Boton8.TabIndex = 18
        Me.Boton8.Text = "8"
        Me.Boton8.UseVisualStyleBackColor = True
        '
        'Boton9
        '
        Me.Boton9.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Boton9.Location = New System.Drawing.Point(139, 146)
        Me.Boton9.Name = "Boton9"
        Me.Boton9.Size = New System.Drawing.Size(58, 62)
        Me.Boton9.TabIndex = 19
        Me.Boton9.Text = "9"
        Me.Boton9.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Romantic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Borrar.Location = New System.Drawing.Point(139, 350)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(59, 62)
        Me.Borrar.TabIndex = 20
        Me.Borrar.Text = "CE"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(333, 431)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Boton9)
        Me.Controls.Add(Me.Boton8)
        Me.Controls.Add(Me.Boton7)
        Me.Controls.Add(Me.Boton6)
        Me.Controls.Add(Me.Boton5)
        Me.Controls.Add(Me.Boton4)
        Me.Controls.Add(Me.Boton3)
        Me.Controls.Add(Me.Boton1)
        Me.Controls.Add(Me.Boton2)
        Me.Controls.Add(Me.Boton0)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.Por)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Etiqueta4)
        Me.Controls.Add(Me.Etiqueta3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Etiqueta2)
        Me.Controls.Add(Me.Mas)
        Me.Controls.Add(Me.Etiqueta1)
        Me.Controls.Add(Me.Num1)
        Me.Font = New System.Drawing.Font("Romantic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Num1 As TextBox
    Friend WithEvents Etiqueta1 As Label
    Friend WithEvents Mas As Button
    Friend WithEvents Etiqueta2 As Label
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Etiqueta3 As Label
    Friend WithEvents Etiqueta4 As Label
    Friend WithEvents Resta As Button
    Friend WithEvents Por As Button
    Friend WithEvents Dividir As Button
    Friend WithEvents Boton0 As Button
    Friend WithEvents Boton2 As Button
    Friend WithEvents Boton3 As Button
    Friend WithEvents Boton1 As Button
    Friend WithEvents Boton4 As Button
    Friend WithEvents Boton5 As Button
    Friend WithEvents Boton6 As Button
    Friend WithEvents Boton7 As Button
    Friend WithEvents Boton8 As Button
    Friend WithEvents Boton9 As Button
    Friend WithEvents Borrar As Button
End Class
