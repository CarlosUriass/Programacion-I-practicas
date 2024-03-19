<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtb_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtb_primer_ap = New System.Windows.Forms.TextBox()
        Me.txtb_segundo_ap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_dia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_mes = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtb_año = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_sexo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_estado = New System.Windows.Forms.ComboBox()
        Me.lbl_curp = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lbl_rfc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE(S)"
        '
        'txtb_nombre
        '
        Me.txtb_nombre.Location = New System.Drawing.Point(200, 92)
        Me.txtb_nombre.Name = "txtb_nombre"
        Me.txtb_nombre.Size = New System.Drawing.Size(134, 23)
        Me.txtb_nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRIMER APELLIDO"
        '
        'txtb_primer_ap
        '
        Me.txtb_primer_ap.Location = New System.Drawing.Point(375, 92)
        Me.txtb_primer_ap.Name = "txtb_primer_ap"
        Me.txtb_primer_ap.Size = New System.Drawing.Size(136, 23)
        Me.txtb_primer_ap.TabIndex = 3
        '
        'txtb_segundo_ap
        '
        Me.txtb_segundo_ap.Location = New System.Drawing.Point(200, 145)
        Me.txtb_segundo_ap.Name = "txtb_segundo_ap"
        Me.txtb_segundo_ap.Size = New System.Drawing.Size(134, 23)
        Me.txtb_segundo_ap.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SEGUNDO APELLIDO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DIA DE NACIMIENTO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbx_dia
        '
        Me.cbx_dia.FormattingEnabled = True
        Me.cbx_dia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbx_dia.Location = New System.Drawing.Point(375, 145)
        Me.cbx_dia.Name = "cbx_dia"
        Me.cbx_dia.Size = New System.Drawing.Size(136, 23)
        Me.cbx_dia.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MES DE NACIMIENTO"
        '
        'cbx_mes
        '
        Me.cbx_mes.FormattingEnabled = True
        Me.cbx_mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbx_mes.Location = New System.Drawing.Point(200, 201)
        Me.cbx_mes.Name = "cbx_mes"
        Me.cbx_mes.Size = New System.Drawing.Size(134, 23)
        Me.cbx_mes.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "AÑO DE NACIMIENTO"
        '
        'txtb_año
        '
        Me.txtb_año.Location = New System.Drawing.Point(375, 201)
        Me.txtb_año.Name = "txtb_año"
        Me.txtb_año.Size = New System.Drawing.Size(136, 23)
        Me.txtb_año.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 39)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "CONSULTA CURP Y RFC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SEXO"
        '
        'cbx_sexo
        '
        Me.cbx_sexo.FormattingEnabled = True
        Me.cbx_sexo.Items.AddRange(New Object() {"HOMBRE", "MUJER", "NO BINARIO"})
        Me.cbx_sexo.Location = New System.Drawing.Point(200, 254)
        Me.cbx_sexo.Name = "cbx_sexo"
        Me.cbx_sexo.Size = New System.Drawing.Size(134, 23)
        Me.cbx_sexo.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(375, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ESTADO DE NACIMIENTO"
        '
        'cbx_estado
        '
        Me.cbx_estado.FormattingEnabled = True
        Me.cbx_estado.Items.AddRange(New Object() {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Ciudad de México", "Coahuila", "Colima", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas", "Nacido en el extranjero"})
        Me.cbx_estado.Location = New System.Drawing.Point(375, 254)
        Me.cbx_estado.Name = "cbx_estado"
        Me.cbx_estado.Size = New System.Drawing.Size(136, 23)
        Me.cbx_estado.TabIndex = 16
        '
        'lbl_curp
        '
        Me.lbl_curp.AutoSize = True
        Me.lbl_curp.Location = New System.Drawing.Point(225, 397)
        Me.lbl_curp.Name = "lbl_curp"
        Me.lbl_curp.Size = New System.Drawing.Size(92, 15)
        Me.lbl_curp.TabIndex = 17
        Me.lbl_curp.Text = "_________________"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(574, 397)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 29)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "SIGUIENTE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(672, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 28)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbl_rfc
        '
        Me.lbl_rfc.AutoSize = True
        Me.lbl_rfc.Location = New System.Drawing.Point(400, 397)
        Me.lbl_rfc.Name = "lbl_rfc"
        Me.lbl_rfc.Size = New System.Drawing.Size(92, 15)
        Me.lbl_rfc.TabIndex = 21
        Me.lbl_rfc.Text = "_________________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 451)
        Me.Controls.Add(Me.lbl_rfc)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl_curp)
        Me.Controls.Add(Me.cbx_estado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbx_sexo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtb_año)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbx_mes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbx_dia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtb_segundo_ap)
        Me.Controls.Add(Me.txtb_primer_ap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtb_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtb_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_primer_ap As TextBox
    Friend WithEvents txtb_segundo_ap As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_dia As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_mes As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtb_año As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_sexo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_estado As ComboBox
    Friend WithEvents lbl_curp As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lbl_rfc As Label
End Class
