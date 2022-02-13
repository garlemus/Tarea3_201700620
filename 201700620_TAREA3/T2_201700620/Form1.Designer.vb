<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.check_compra = New System.Windows.Forms.CheckBox()
        Me.check_venta = New System.Windows.Forms.CheckBox()
        Me.text_compra = New System.Windows.Forms.TextBox()
        Me.button_calcular = New System.Windows.Forms.Button()
        Me.button_limpiar = New System.Windows.Forms.Button()
        Me.button_salir = New System.Windows.Forms.Button()
        Me.text_venta = New System.Windows.Forms.TextBox()
        Me.label_compra = New System.Windows.Forms.Label()
        Me.label_venta = New System.Windows.Forms.Label()
        Me.label_total_compra = New System.Windows.Forms.Label()
        Me.label_total_venta = New System.Windows.Forms.Label()
        Me.group_compra = New System.Windows.Forms.GroupBox()
        Me.check_dolar_compra = New System.Windows.Forms.RadioButton()
        Me.check_peso_compra = New System.Windows.Forms.RadioButton()
        Me.check_euro_compra = New System.Windows.Forms.RadioButton()
        Me.check_colon_compra = New System.Windows.Forms.RadioButton()
        Me.group_venta = New System.Windows.Forms.GroupBox()
        Me.check_colon_venta = New System.Windows.Forms.RadioButton()
        Me.check_euro_venta = New System.Windows.Forms.RadioButton()
        Me.check_peso_venta = New System.Windows.Forms.RadioButton()
        Me.check_dolar_venta = New System.Windows.Forms.RadioButton()
        Me.group_compra.SuspendLayout()
        Me.group_venta.SuspendLayout()
        Me.SuspendLayout()
        '
        'check_compra
        '
        Me.check_compra.AutoSize = True
        Me.check_compra.Location = New System.Drawing.Point(21, 12)
        Me.check_compra.Name = "check_compra"
        Me.check_compra.Size = New System.Drawing.Size(62, 17)
        Me.check_compra.TabIndex = 0
        Me.check_compra.Text = "Compra"
        Me.check_compra.UseVisualStyleBackColor = True
        '
        'check_venta
        '
        Me.check_venta.AutoSize = True
        Me.check_venta.Location = New System.Drawing.Point(247, 12)
        Me.check_venta.Name = "check_venta"
        Me.check_venta.Size = New System.Drawing.Size(54, 17)
        Me.check_venta.TabIndex = 1
        Me.check_venta.Text = "Venta"
        Me.check_venta.UseVisualStyleBackColor = True
        '
        'text_compra
        '
        Me.text_compra.Location = New System.Drawing.Point(21, 62)
        Me.text_compra.Name = "text_compra"
        Me.text_compra.Size = New System.Drawing.Size(147, 20)
        Me.text_compra.TabIndex = 2
        '
        'button_calcular
        '
        Me.button_calcular.Location = New System.Drawing.Point(65, 276)
        Me.button_calcular.Name = "button_calcular"
        Me.button_calcular.Size = New System.Drawing.Size(75, 23)
        Me.button_calcular.TabIndex = 3
        Me.button_calcular.Text = "Calcular"
        Me.button_calcular.UseVisualStyleBackColor = True
        '
        'button_limpiar
        '
        Me.button_limpiar.Location = New System.Drawing.Point(173, 276)
        Me.button_limpiar.Name = "button_limpiar"
        Me.button_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.button_limpiar.TabIndex = 4
        Me.button_limpiar.Text = "Limpiar"
        Me.button_limpiar.UseVisualStyleBackColor = True
        '
        'button_salir
        '
        Me.button_salir.Location = New System.Drawing.Point(286, 276)
        Me.button_salir.Name = "button_salir"
        Me.button_salir.Size = New System.Drawing.Size(75, 23)
        Me.button_salir.TabIndex = 5
        Me.button_salir.Text = "Salir"
        Me.button_salir.UseVisualStyleBackColor = True
        '
        'text_venta
        '
        Me.text_venta.Location = New System.Drawing.Point(252, 62)
        Me.text_venta.Name = "text_venta"
        Me.text_venta.Size = New System.Drawing.Size(142, 20)
        Me.text_venta.TabIndex = 6
        '
        'label_compra
        '
        Me.label_compra.AutoSize = True
        Me.label_compra.Location = New System.Drawing.Point(18, 35)
        Me.label_compra.Name = "label_compra"
        Me.label_compra.Size = New System.Drawing.Size(150, 13)
        Me.label_compra.TabIndex = 7
        Me.label_compra.Text = "Ingresa la cantidad a comprar:"
        '
        'label_venta
        '
        Me.label_venta.AutoSize = True
        Me.label_venta.Location = New System.Drawing.Point(249, 35)
        Me.label_venta.Name = "label_venta"
        Me.label_venta.Size = New System.Drawing.Size(145, 13)
        Me.label_venta.TabIndex = 8
        Me.label_venta.Text = "Ingresa la cantidad a vender:"
        '
        'label_total_compra
        '
        Me.label_total_compra.AutoSize = True
        Me.label_total_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total_compra.Location = New System.Drawing.Point(18, 228)
        Me.label_total_compra.Name = "label_total_compra"
        Me.label_total_compra.Size = New System.Drawing.Size(127, 13)
        Me.label_total_compra.TabIndex = 9
        Me.label_total_compra.Text = "TOTAL COMPRA (#):"
        '
        'label_total_venta
        '
        Me.label_total_venta.AutoSize = True
        Me.label_total_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_total_venta.Location = New System.Drawing.Point(244, 228)
        Me.label_total_venta.Name = "label_total_venta"
        Me.label_total_venta.Size = New System.Drawing.Size(117, 13)
        Me.label_total_venta.TabIndex = 18
        Me.label_total_venta.Text = "TOTAL VENTA (Q):"
        '
        'group_compra
        '
        Me.group_compra.Controls.Add(Me.check_colon_compra)
        Me.group_compra.Controls.Add(Me.check_euro_compra)
        Me.group_compra.Controls.Add(Me.check_peso_compra)
        Me.group_compra.Controls.Add(Me.check_dolar_compra)
        Me.group_compra.Location = New System.Drawing.Point(21, 93)
        Me.group_compra.Name = "group_compra"
        Me.group_compra.Size = New System.Drawing.Size(147, 118)
        Me.group_compra.TabIndex = 19
        Me.group_compra.TabStop = False
        Me.group_compra.Text = "Moneda Compra"
        '
        'check_dolar_compra
        '
        Me.check_dolar_compra.AutoSize = True
        Me.check_dolar_compra.Location = New System.Drawing.Point(20, 19)
        Me.check_dolar_compra.Name = "check_dolar_compra"
        Me.check_dolar_compra.Size = New System.Drawing.Size(50, 17)
        Me.check_dolar_compra.TabIndex = 0
        Me.check_dolar_compra.TabStop = True
        Me.check_dolar_compra.Text = "Dolar"
        Me.check_dolar_compra.UseVisualStyleBackColor = True
        '
        'check_peso_compra
        '
        Me.check_peso_compra.AutoSize = True
        Me.check_peso_compra.Location = New System.Drawing.Point(20, 42)
        Me.check_peso_compra.Name = "check_peso_compra"
        Me.check_peso_compra.Size = New System.Drawing.Size(49, 17)
        Me.check_peso_compra.TabIndex = 1
        Me.check_peso_compra.TabStop = True
        Me.check_peso_compra.Text = "Peso"
        Me.check_peso_compra.UseVisualStyleBackColor = True
        '
        'check_euro_compra
        '
        Me.check_euro_compra.AutoSize = True
        Me.check_euro_compra.Location = New System.Drawing.Point(20, 65)
        Me.check_euro_compra.Name = "check_euro_compra"
        Me.check_euro_compra.Size = New System.Drawing.Size(47, 17)
        Me.check_euro_compra.TabIndex = 2
        Me.check_euro_compra.TabStop = True
        Me.check_euro_compra.Text = "Euro"
        Me.check_euro_compra.UseVisualStyleBackColor = True
        '
        'check_colon_compra
        '
        Me.check_colon_compra.AutoSize = True
        Me.check_colon_compra.Location = New System.Drawing.Point(20, 88)
        Me.check_colon_compra.Name = "check_colon_compra"
        Me.check_colon_compra.Size = New System.Drawing.Size(52, 17)
        Me.check_colon_compra.TabIndex = 3
        Me.check_colon_compra.TabStop = True
        Me.check_colon_compra.Text = "Colon"
        Me.check_colon_compra.UseVisualStyleBackColor = True
        '
        'group_venta
        '
        Me.group_venta.Controls.Add(Me.check_colon_venta)
        Me.group_venta.Controls.Add(Me.check_euro_venta)
        Me.group_venta.Controls.Add(Me.check_peso_venta)
        Me.group_venta.Controls.Add(Me.check_dolar_venta)
        Me.group_venta.Location = New System.Drawing.Point(252, 93)
        Me.group_venta.Name = "group_venta"
        Me.group_venta.Size = New System.Drawing.Size(129, 118)
        Me.group_venta.TabIndex = 20
        Me.group_venta.TabStop = False
        Me.group_venta.Text = "Moneda Venta"
        '
        'check_colon_venta
        '
        Me.check_colon_venta.AutoSize = True
        Me.check_colon_venta.Location = New System.Drawing.Point(20, 88)
        Me.check_colon_venta.Name = "check_colon_venta"
        Me.check_colon_venta.Size = New System.Drawing.Size(52, 17)
        Me.check_colon_venta.TabIndex = 3
        Me.check_colon_venta.TabStop = True
        Me.check_colon_venta.Text = "Colon"
        Me.check_colon_venta.UseVisualStyleBackColor = True
        '
        'check_euro_venta
        '
        Me.check_euro_venta.AutoSize = True
        Me.check_euro_venta.Location = New System.Drawing.Point(20, 65)
        Me.check_euro_venta.Name = "check_euro_venta"
        Me.check_euro_venta.Size = New System.Drawing.Size(47, 17)
        Me.check_euro_venta.TabIndex = 2
        Me.check_euro_venta.TabStop = True
        Me.check_euro_venta.Text = "Euro"
        Me.check_euro_venta.UseVisualStyleBackColor = True
        '
        'check_peso_venta
        '
        Me.check_peso_venta.AutoSize = True
        Me.check_peso_venta.Location = New System.Drawing.Point(20, 42)
        Me.check_peso_venta.Name = "check_peso_venta"
        Me.check_peso_venta.Size = New System.Drawing.Size(49, 17)
        Me.check_peso_venta.TabIndex = 1
        Me.check_peso_venta.TabStop = True
        Me.check_peso_venta.Text = "Peso"
        Me.check_peso_venta.UseVisualStyleBackColor = True
        '
        'check_dolar_venta
        '
        Me.check_dolar_venta.AutoSize = True
        Me.check_dolar_venta.Location = New System.Drawing.Point(20, 19)
        Me.check_dolar_venta.Name = "check_dolar_venta"
        Me.check_dolar_venta.Size = New System.Drawing.Size(50, 17)
        Me.check_dolar_venta.TabIndex = 0
        Me.check_dolar_venta.TabStop = True
        Me.check_dolar_venta.Text = "Dolar"
        Me.check_dolar_venta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 332)
        Me.Controls.Add(Me.group_venta)
        Me.Controls.Add(Me.group_compra)
        Me.Controls.Add(Me.label_total_venta)
        Me.Controls.Add(Me.label_total_compra)
        Me.Controls.Add(Me.label_venta)
        Me.Controls.Add(Me.label_compra)
        Me.Controls.Add(Me.text_venta)
        Me.Controls.Add(Me.button_salir)
        Me.Controls.Add(Me.button_limpiar)
        Me.Controls.Add(Me.button_calcular)
        Me.Controls.Add(Me.text_compra)
        Me.Controls.Add(Me.check_venta)
        Me.Controls.Add(Me.check_compra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.group_compra.ResumeLayout(False)
        Me.group_compra.PerformLayout()
        Me.group_venta.ResumeLayout(False)
        Me.group_venta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents check_compra As CheckBox
    Friend WithEvents check_venta As CheckBox
    Friend WithEvents text_compra As TextBox
    Friend WithEvents button_calcular As Button
    Friend WithEvents button_limpiar As Button
    Friend WithEvents button_salir As Button
    Friend WithEvents text_venta As TextBox
    Friend WithEvents label_compra As Label
    Friend WithEvents label_venta As Label
    Friend WithEvents label_total_compra As Label
    Friend WithEvents label_total_venta As Label
    Friend WithEvents group_compra As GroupBox
    Friend WithEvents check_colon_compra As RadioButton
    Friend WithEvents check_euro_compra As RadioButton
    Friend WithEvents check_peso_compra As RadioButton
    Friend WithEvents check_dolar_compra As RadioButton
    Friend WithEvents group_venta As GroupBox
    Friend WithEvents check_colon_venta As RadioButton
    Friend WithEvents check_euro_venta As RadioButton
    Friend WithEvents check_peso_venta As RadioButton
    Friend WithEvents check_dolar_venta As RadioButton
End Class
