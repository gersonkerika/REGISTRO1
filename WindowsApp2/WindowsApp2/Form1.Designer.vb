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
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsillas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtevento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numCantidadSillas = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNALKILAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(957, 465)
        Me.txtcelular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(384, 26)
        Me.txtcelular.TabIndex = 169
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(624, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 29)
        Me.Label4.TabIndex = 168
        Me.Label4.Text = "Celular"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(957, 213)
        Me.txtdni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(384, 26)
        Me.txtdni.TabIndex = 165
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(626, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 29)
        Me.Label10.TabIndex = 164
        Me.Label10.Text = "DNI"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(957, 375)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(384, 26)
        Me.txtdireccion.TabIndex = 161
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(957, 289)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(384, 26)
        Me.txtnombre.TabIndex = 159
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(624, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 29)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(626, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 29)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(729, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 31)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "REGISTRO ALKILER DE SILLAS ""MIS ELIZABETH"""
        '
        'txtsillas
        '
        Me.txtsillas.Location = New System.Drawing.Point(957, 643)
        Me.txtsillas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsillas.Name = "txtsillas"
        Me.txtsillas.Size = New System.Drawing.Size(384, 26)
        Me.txtsillas.TabIndex = 176
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(626, 638)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 29)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "Cantidad Sillas"
        '
        'txtevento
        '
        Me.txtevento.Location = New System.Drawing.Point(957, 552)
        Me.txtevento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtevento.Name = "txtevento"
        Me.txtevento.Size = New System.Drawing.Size(384, 26)
        Me.txtevento.TabIndex = 173
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(626, 723)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 29)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Cantidad De Dias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(626, 547)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 29)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Evento Alkiler"
        '
        'numCantidadSillas
        '
        Me.numCantidadSillas.Location = New System.Drawing.Point(957, 728)
        Me.numCantidadSillas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numCantidadSillas.Name = "numCantidadSillas"
        Me.numCantidadSillas.Size = New System.Drawing.Size(384, 26)
        Me.numCantidadSillas.TabIndex = 177
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(957, 815)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(384, 26)
        Me.TextBox1.TabIndex = 179
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(626, 810)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 29)
        Me.Label8.TabIndex = 178
        Me.Label8.Text = "Fecha Devolucion"
        '
        'BTNALKILAR
        '
        Me.BTNALKILAR.BackColor = System.Drawing.Color.Lime
        Me.BTNALKILAR.Location = New System.Drawing.Point(896, 924)
        Me.BTNALKILAR.Name = "BTNALKILAR"
        Me.BTNALKILAR.Size = New System.Drawing.Size(171, 65)
        Me.BTNALKILAR.TabIndex = 180
        Me.BTNALKILAR.Text = "ALKILAR"
        Me.BTNALKILAR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources._32
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1826, 1050)
        Me.Controls.Add(Me.BTNALKILAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numCantidadSillas)
        Me.Controls.Add(Me.txtsillas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtevento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcelular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcelular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsillas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtevento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numCantidadSillas As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNALKILAR As Button
End Class
