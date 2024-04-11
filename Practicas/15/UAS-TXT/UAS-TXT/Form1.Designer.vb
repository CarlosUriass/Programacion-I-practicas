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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtb_primerA = New System.Windows.Forms.TextBox()
        Me.txtb_segundoA = New System.Windows.Forms.TextBox()
        Me.txtb_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_software = New System.Windows.Forms.RadioButton()
        Me.rb_geodesia = New System.Windows.Forms.RadioButton()
        Me.rb_civil = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtb_grado = New System.Windows.Forms.TextBox()
        Me.Txt_grupo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pick_fecha_nac = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckb_beisbol = New System.Windows.Forms.CheckBox()
        Me.ckb_otro = New System.Windows.Forms.CheckBox()
        Me.ckb_tenis = New System.Windows.Forms.CheckBox()
        Me.ckb_box = New System.Windows.Forms.CheckBox()
        Me.ckb_ciclismo = New System.Windows.Forms.CheckBox()
        Me.ckb_natacion = New System.Windows.Forms.CheckBox()
        Me.ckb_voleibol = New System.Windows.Forms.CheckBox()
        Me.ckb_basketbol = New System.Windows.Forms.CheckBox()
        Me.ckb_futbol = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRIMER APELLIDO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SEGUNDO APELLIDO"
        '
        'txtb_primerA
        '
        Me.txtb_primerA.Location = New System.Drawing.Point(221, 33)
        Me.txtb_primerA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_primerA.Name = "txtb_primerA"
        Me.txtb_primerA.Size = New System.Drawing.Size(238, 23)
        Me.txtb_primerA.TabIndex = 2
        '
        'txtb_segundoA
        '
        Me.txtb_segundoA.Location = New System.Drawing.Point(221, 68)
        Me.txtb_segundoA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_segundoA.Name = "txtb_segundoA"
        Me.txtb_segundoA.Size = New System.Drawing.Size(238, 23)
        Me.txtb_segundoA.TabIndex = 3
        '
        'txtb_nombre
        '
        Me.txtb_nombre.Location = New System.Drawing.Point(221, 102)
        Me.txtb_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_nombre.Name = "txtb_nombre"
        Me.txtb_nombre.Size = New System.Drawing.Size(238, 23)
        Me.txtb_nombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NOMBRE(s)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_software)
        Me.GroupBox1.Controls.Add(Me.rb_geodesia)
        Me.GroupBox1.Controls.Add(Me.rb_civil)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 150)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(605, 52)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CARRRERA QUE ESTUDIA"
        '
        'rb_software
        '
        Me.rb_software.AutoSize = True
        Me.rb_software.Location = New System.Drawing.Point(448, 20)
        Me.rb_software.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_software.Name = "rb_software"
        Me.rb_software.Size = New System.Drawing.Size(84, 19)
        Me.rb_software.TabIndex = 2
        Me.rb_software.TabStop = True
        Me.rb_software.Text = "SOFTWARE"
        Me.rb_software.UseVisualStyleBackColor = True
        '
        'rb_geodesia
        '
        Me.rb_geodesia.AutoSize = True
        Me.rb_geodesia.Location = New System.Drawing.Point(255, 20)
        Me.rb_geodesia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_geodesia.Name = "rb_geodesia"
        Me.rb_geodesia.Size = New System.Drawing.Size(79, 19)
        Me.rb_geodesia.TabIndex = 1
        Me.rb_geodesia.TabStop = True
        Me.rb_geodesia.Text = "GEODESIA"
        Me.rb_geodesia.UseVisualStyleBackColor = True
        '
        'rb_civil
        '
        Me.rb_civil.AutoSize = True
        Me.rb_civil.Location = New System.Drawing.Point(44, 20)
        Me.rb_civil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_civil.Name = "rb_civil"
        Me.rb_civil.Size = New System.Drawing.Size(52, 19)
        Me.rb_civil.TabIndex = 0
        Me.rb_civil.TabStop = True
        Me.rb_civil.Text = "CIVIL"
        Me.rb_civil.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "GRADO"
        '
        'txtb_grado
        '
        Me.txtb_grado.Location = New System.Drawing.Point(126, 218)
        Me.txtb_grado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_grado.Name = "txtb_grado"
        Me.txtb_grado.Size = New System.Drawing.Size(84, 23)
        Me.txtb_grado.TabIndex = 8
        '
        'Txt_grupo
        '
        Me.Txt_grupo.Location = New System.Drawing.Point(279, 218)
        Me.Txt_grupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_grupo.Name = "Txt_grupo"
        Me.Txt_grupo.Size = New System.Drawing.Size(84, 23)
        Me.Txt_grupo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "GRUPO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "FECHA DE NACIMIENTO"
        '
        'pick_fecha_nac
        '
        Me.pick_fecha_nac.Location = New System.Drawing.Point(529, 220)
        Me.pick_fecha_nac.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pick_fecha_nac.Name = "pick_fecha_nac"
        Me.pick_fecha_nac.Size = New System.Drawing.Size(260, 23)
        Me.pick_fecha_nac.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckb_beisbol)
        Me.GroupBox2.Controls.Add(Me.ckb_otro)
        Me.GroupBox2.Controls.Add(Me.ckb_tenis)
        Me.GroupBox2.Controls.Add(Me.ckb_box)
        Me.GroupBox2.Controls.Add(Me.ckb_ciclismo)
        Me.GroupBox2.Controls.Add(Me.ckb_natacion)
        Me.GroupBox2.Controls.Add(Me.ckb_voleibol)
        Me.GroupBox2.Controls.Add(Me.ckb_basketbol)
        Me.GroupBox2.Controls.Add(Me.ckb_futbol)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 253)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(603, 76)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEPORTE QUE PRACTICA"
        '
        'ckb_beisbol
        '
        Me.ckb_beisbol.AutoSize = True
        Me.ckb_beisbol.Location = New System.Drawing.Point(254, 46)
        Me.ckb_beisbol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_beisbol.Name = "ckb_beisbol"
        Me.ckb_beisbol.Size = New System.Drawing.Size(80, 19)
        Me.ckb_beisbol.TabIndex = 8
        Me.ckb_beisbol.Text = "BASEBALL"
        Me.ckb_beisbol.UseVisualStyleBackColor = True
        '
        'ckb_otro
        '
        Me.ckb_otro.AutoSize = True
        Me.ckb_otro.Location = New System.Drawing.Point(346, 46)
        Me.ckb_otro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_otro.Name = "ckb_otro"
        Me.ckb_otro.Size = New System.Drawing.Size(56, 19)
        Me.ckb_otro.TabIndex = 7
        Me.ckb_otro.Text = "OTRO"
        Me.ckb_otro.UseVisualStyleBackColor = True
        '
        'ckb_tenis
        '
        Me.ckb_tenis.AutoSize = True
        Me.ckb_tenis.Location = New System.Drawing.Point(172, 46)
        Me.ckb_tenis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_tenis.Name = "ckb_tenis"
        Me.ckb_tenis.Size = New System.Drawing.Size(56, 19)
        Me.ckb_tenis.TabIndex = 6
        Me.ckb_tenis.Text = "TENIS"
        Me.ckb_tenis.UseVisualStyleBackColor = True
        '
        'ckb_box
        '
        Me.ckb_box.AutoSize = True
        Me.ckb_box.Location = New System.Drawing.Point(507, 24)
        Me.ckb_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_box.Name = "ckb_box"
        Me.ckb_box.Size = New System.Drawing.Size(49, 19)
        Me.ckb_box.TabIndex = 5
        Me.ckb_box.Text = "BOX"
        Me.ckb_box.UseVisualStyleBackColor = True
        '
        'ckb_ciclismo
        '
        Me.ckb_ciclismo.AutoSize = True
        Me.ckb_ciclismo.Location = New System.Drawing.Point(411, 24)
        Me.ckb_ciclismo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_ciclismo.Name = "ckb_ciclismo"
        Me.ckb_ciclismo.Size = New System.Drawing.Size(80, 19)
        Me.ckb_ciclismo.TabIndex = 4
        Me.ckb_ciclismo.Text = "CICLISMO"
        Me.ckb_ciclismo.UseVisualStyleBackColor = True
        '
        'ckb_natacion
        '
        Me.ckb_natacion.AutoSize = True
        Me.ckb_natacion.Location = New System.Drawing.Point(301, 24)
        Me.ckb_natacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_natacion.Name = "ckb_natacion"
        Me.ckb_natacion.Size = New System.Drawing.Size(84, 19)
        Me.ckb_natacion.TabIndex = 3
        Me.ckb_natacion.Text = "NATACIÓN"
        Me.ckb_natacion.UseVisualStyleBackColor = True
        '
        'ckb_voleibol
        '
        Me.ckb_voleibol.AutoSize = True
        Me.ckb_voleibol.Location = New System.Drawing.Point(211, 24)
        Me.ckb_voleibol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_voleibol.Name = "ckb_voleibol"
        Me.ckb_voleibol.Size = New System.Drawing.Size(79, 19)
        Me.ckb_voleibol.TabIndex = 2
        Me.ckb_voleibol.Text = "VOLEIBOL"
        Me.ckb_voleibol.UseVisualStyleBackColor = True
        '
        'ckb_basketbol
        '
        Me.ckb_basketbol.AutoSize = True
        Me.ckb_basketbol.Location = New System.Drawing.Point(89, 24)
        Me.ckb_basketbol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_basketbol.Name = "ckb_basketbol"
        Me.ckb_basketbol.Size = New System.Drawing.Size(93, 19)
        Me.ckb_basketbol.TabIndex = 1
        Me.ckb_basketbol.Text = "BASKETBALL"
        Me.ckb_basketbol.UseVisualStyleBackColor = True
        '
        'ckb_futbol
        '
        Me.ckb_futbol.AutoSize = True
        Me.ckb_futbol.Location = New System.Drawing.Point(11, 24)
        Me.ckb_futbol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckb_futbol.Name = "ckb_futbol"
        Me.ckb_futbol.Size = New System.Drawing.Size(68, 19)
        Me.ckb_futbol.TabIndex = 0
        Me.ckb_futbol.Text = "FUTBOL"
        Me.ckb_futbol.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(66, 347)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(540, 49)
        Me.ListBox1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(628, 347)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "GUARDAR EN ARCHIVO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(703, 406)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 22)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 440)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pick_fecha_nac)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_grupo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtb_grado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtb_nombre)
        Me.Controls.Add(Me.txtb_segundoA)
        Me.Controls.Add(Me.txtb_primerA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_primerA As TextBox
    Friend WithEvents txtb_segundoA As TextBox
    Friend WithEvents txtb_nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_software As RadioButton
    Friend WithEvents rb_geodesia As RadioButton
    Friend WithEvents rb_civil As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_grado As TextBox
    Friend WithEvents Txt_grupo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pick_fecha_nac As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ckb_otro As CheckBox
    Friend WithEvents ckb_tenis As CheckBox
    Friend WithEvents ckb_box As CheckBox
    Friend WithEvents ckb_ciclismo As CheckBox
    Friend WithEvents ckb_natacion As CheckBox
    Friend WithEvents ckb_voleibol As CheckBox
    Friend WithEvents ckb_basketbol As CheckBox
    Friend WithEvents ckb_futbol As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ckb_beisbol As CheckBox

End Class
