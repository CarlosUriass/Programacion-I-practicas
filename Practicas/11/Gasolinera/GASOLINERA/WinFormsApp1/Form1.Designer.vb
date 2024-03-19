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
        GroupBox1 = New GroupBox()
        Txtb_diesel = New TextBox()
        Txtb_magna = New TextBox()
        Txtb_premium = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        rb_diesel = New RadioButton()
        rb_premium = New RadioButton()
        rb_magna = New RadioButton()
        Label4 = New Label()
        txtb_litros = New TextBox()
        Button1 = New Button()
        GroupBox3 = New GroupBox()
        rb_cheque = New RadioButton()
        Rb_tarjeta = New RadioButton()
        rb_efectivo = New RadioButton()
        Label5 = New Label()
        lbl_importe = New Label()
        GroupBox4 = New GroupBox()
        lbl_suma_pagos = New Label()
        Suma_pago = New Label()
        total_cheque_lbl = New Label()
        lbl_total_cheque = New Label()
        Label11 = New Label()
        Total_tarjeta = New Label()
        Total_efectivo = New Label()
        total_cheque = New Label()
        Label7 = New Label()
        Label6 = New Label()
        GroupBox5 = New GroupBox()
        lbl_suma_tipo_combustible = New Label()
        suma_tipo_comb = New Label()
        lbl_diesel_din = New Label()
        lbl_magna_din = New Label()
        lbl_premium_din = New Label()
        lbl_suma_combustible = New Label()
        suma_combustible = New Label()
        TOTAL_DIESEL = New Label()
        TOTAL_MAGNA = New Label()
        TOTAL_PREMIUM = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Txtb_diesel)
        GroupBox1.Controls.Add(Txtb_magna)
        GroupBox1.Controls.Add(Txtb_premium)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(49, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(468, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "PRECIOS POR LITRO"
        ' 
        ' Txtb_diesel
        ' 
        Txtb_diesel.Location = New Point(337, 52)
        Txtb_diesel.Name = "Txtb_diesel"
        Txtb_diesel.Size = New Size(100, 23)
        Txtb_diesel.TabIndex = 5
        Txtb_diesel.TextAlign = HorizontalAlignment.Right
        ' 
        ' Txtb_magna
        ' 
        Txtb_magna.Location = New Point(198, 52)
        Txtb_magna.Name = "Txtb_magna"
        Txtb_magna.Size = New Size(100, 23)
        Txtb_magna.TabIndex = 4
        Txtb_magna.TextAlign = HorizontalAlignment.Right
        ' 
        ' Txtb_premium
        ' 
        Txtb_premium.Location = New Point(29, 52)
        Txtb_premium.Name = "Txtb_premium"
        Txtb_premium.Size = New Size(100, 23)
        Txtb_premium.TabIndex = 3
        Txtb_premium.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(337, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 2
        Label3.Text = "DIESEL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(198, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "MAGNA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "PREMIUM"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rb_diesel)
        GroupBox2.Controls.Add(rb_premium)
        GroupBox2.Controls.Add(rb_magna)
        GroupBox2.Location = New Point(49, 128)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(365, 100)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "ELEGIR COMBUSTIBLE"
        ' 
        ' rb_diesel
        ' 
        rb_diesel.AutoSize = True
        rb_diesel.Location = New Point(266, 40)
        rb_diesel.Name = "rb_diesel"
        rb_diesel.Size = New Size(60, 19)
        rb_diesel.TabIndex = 2
        rb_diesel.TabStop = True
        rb_diesel.Text = "DIESEL"
        rb_diesel.UseVisualStyleBackColor = True
        ' 
        ' rb_premium
        ' 
        rb_premium.AutoSize = True
        rb_premium.Location = New Point(13, 40)
        rb_premium.Name = "rb_premium"
        rb_premium.Size = New Size(78, 19)
        rb_premium.TabIndex = 1
        rb_premium.TabStop = True
        rb_premium.Text = "PREMIUM"
        rb_premium.UseVisualStyleBackColor = True
        ' 
        ' rb_magna
        ' 
        rb_magna.AutoSize = True
        rb_magna.Location = New Point(144, 40)
        rb_magna.Name = "rb_magna"
        rb_magna.Size = New Size(69, 19)
        rb_magna.TabIndex = 0
        rb_magna.TabStop = True
        rb_magna.Text = "MAGNA"
        rb_magna.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(433, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 15)
        Label4.TabIndex = 2
        Label4.Text = "LITROS VENDIDOS"
        ' 
        ' txtb_litros
        ' 
        txtb_litros.Location = New Point(433, 187)
        txtb_litros.Name = "txtb_litros"
        txtb_litros.Size = New Size(117, 23)
        txtb_litros.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(442, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "CALCULAR Y ACUMULAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rb_cheque)
        GroupBox3.Controls.Add(Rb_tarjeta)
        GroupBox3.Controls.Add(rb_efectivo)
        GroupBox3.Location = New Point(49, 247)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(365, 71)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "METODO DE PAGO"
        ' 
        ' rb_cheque
        ' 
        rb_cheque.AutoSize = True
        rb_cheque.Location = New Point(227, 26)
        rb_cheque.Name = "rb_cheque"
        rb_cheque.Size = New Size(71, 19)
        rb_cheque.TabIndex = 2
        rb_cheque.TabStop = True
        rb_cheque.Text = "CHEQUE"
        rb_cheque.UseVisualStyleBackColor = True
        ' 
        ' Rb_tarjeta
        ' 
        Rb_tarjeta.AutoSize = True
        Rb_tarjeta.Location = New Point(125, 26)
        Rb_tarjeta.Name = "Rb_tarjeta"
        Rb_tarjeta.Size = New Size(68, 19)
        Rb_tarjeta.TabIndex = 1
        Rb_tarjeta.TabStop = True
        Rb_tarjeta.Text = "TARJETA"
        Rb_tarjeta.UseVisualStyleBackColor = True
        ' 
        ' rb_efectivo
        ' 
        rb_efectivo.AutoSize = True
        rb_efectivo.Location = New Point(13, 26)
        rb_efectivo.Name = "rb_efectivo"
        rb_efectivo.Size = New Size(76, 19)
        rb_efectivo.TabIndex = 0
        rb_efectivo.TabStop = True
        rb_efectivo.Text = "EFECTIVO"
        rb_efectivo.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(420, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 15)
        Label5.TabIndex = 6
        Label5.Text = "IMPORTE A PAGAR -->"
        ' 
        ' lbl_importe
        ' 
        lbl_importe.AutoSize = True
        lbl_importe.Location = New Point(553, 303)
        lbl_importe.Name = "lbl_importe"
        lbl_importe.Size = New Size(112, 15)
        lbl_importe.TabIndex = 7
        lbl_importe.Text = "_____________________"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lbl_suma_pagos)
        GroupBox4.Controls.Add(Suma_pago)
        GroupBox4.Controls.Add(total_cheque_lbl)
        GroupBox4.Controls.Add(lbl_total_cheque)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(Total_tarjeta)
        GroupBox4.Controls.Add(Total_efectivo)
        GroupBox4.Controls.Add(total_cheque)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Location = New Point(43, 322)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(231, 191)
        GroupBox4.TabIndex = 8
        GroupBox4.TabStop = False
        GroupBox4.Text = "TOTAL POR IMPORTE DE PAGO"
        ' 
        ' lbl_suma_pagos
        ' 
        lbl_suma_pagos.AutoSize = True
        lbl_suma_pagos.Location = New Point(84, 149)
        lbl_suma_pagos.Name = "lbl_suma_pagos"
        lbl_suma_pagos.Size = New Size(42, 15)
        lbl_suma_pagos.TabIndex = 9
        lbl_suma_pagos.Text = "_______"
        ' 
        ' Suma_pago
        ' 
        Suma_pago.AutoSize = True
        Suma_pago.Location = New Point(9, 149)
        Suma_pago.Name = "Suma_pago"
        Suma_pago.Size = New Size(43, 15)
        Suma_pago.TabIndex = 8
        Suma_pago.Text = "SUMA:"
        ' 
        ' total_cheque_lbl
        ' 
        total_cheque_lbl.AutoSize = True
        total_cheque_lbl.Location = New Point(84, 115)
        total_cheque_lbl.Name = "total_cheque_lbl"
        total_cheque_lbl.Size = New Size(42, 15)
        total_cheque_lbl.TabIndex = 7
        total_cheque_lbl.Text = "_______"
        ' 
        ' lbl_total_cheque
        ' 
        lbl_total_cheque.AutoSize = True
        lbl_total_cheque.Location = New Point(92, 116)
        lbl_total_cheque.Name = "lbl_total_cheque"
        lbl_total_cheque.Size = New Size(0, 15)
        lbl_total_cheque.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(78, 115)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 15)
        Label11.TabIndex = 5
        ' 
        ' Total_tarjeta
        ' 
        Total_tarjeta.AutoSize = True
        Total_tarjeta.Location = New Point(83, 74)
        Total_tarjeta.Name = "Total_tarjeta"
        Total_tarjeta.Size = New Size(42, 15)
        Total_tarjeta.TabIndex = 4
        Total_tarjeta.Text = "_______"
        ' 
        ' Total_efectivo
        ' 
        Total_efectivo.AutoSize = True
        Total_efectivo.Location = New Point(84, 37)
        Total_efectivo.Name = "Total_efectivo"
        Total_efectivo.Size = New Size(42, 15)
        Total_efectivo.TabIndex = 3
        Total_efectivo.Text = "_______"
        ' 
        ' total_cheque
        ' 
        total_cheque.AutoSize = True
        total_cheque.Location = New Point(9, 115)
        total_cheque.Name = "total_cheque"
        total_cheque.Size = New Size(53, 15)
        total_cheque.TabIndex = 2
        total_cheque.Text = "CHEQUE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 77)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 1
        Label7.Text = "TARJETA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 0
        Label6.Text = "EFECTIVO"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(lbl_suma_tipo_combustible)
        GroupBox5.Controls.Add(suma_tipo_comb)
        GroupBox5.Controls.Add(lbl_diesel_din)
        GroupBox5.Controls.Add(lbl_magna_din)
        GroupBox5.Controls.Add(lbl_premium_din)
        GroupBox5.Controls.Add(lbl_suma_combustible)
        GroupBox5.Controls.Add(suma_combustible)
        GroupBox5.Controls.Add(TOTAL_DIESEL)
        GroupBox5.Controls.Add(TOTAL_MAGNA)
        GroupBox5.Controls.Add(TOTAL_PREMIUM)
        GroupBox5.Controls.Add(Label14)
        GroupBox5.Controls.Add(Label13)
        GroupBox5.Controls.Add(Label12)
        GroupBox5.Location = New Point(301, 333)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(322, 180)
        GroupBox5.TabIndex = 9
        GroupBox5.TabStop = False
        GroupBox5.Text = "TOTAL POR TIPO DE COMBUSTIBLE"
        ' 
        ' lbl_suma_tipo_combustible
        ' 
        lbl_suma_tipo_combustible.AutoSize = True
        lbl_suma_tipo_combustible.Location = New Point(203, 135)
        lbl_suma_tipo_combustible.Name = "lbl_suma_tipo_combustible"
        lbl_suma_tipo_combustible.Size = New Size(0, 15)
        lbl_suma_tipo_combustible.TabIndex = 12
        ' 
        ' suma_tipo_comb
        ' 
        suma_tipo_comb.AutoSize = True
        suma_tipo_comb.Location = New Point(211, 135)
        suma_tipo_comb.Name = "suma_tipo_comb"
        suma_tipo_comb.Size = New Size(42, 15)
        suma_tipo_comb.TabIndex = 11
        suma_tipo_comb.Text = "_______"
        ' 
        ' lbl_diesel_din
        ' 
        lbl_diesel_din.AutoSize = True
        lbl_diesel_din.Location = New Point(211, 104)
        lbl_diesel_din.Name = "lbl_diesel_din"
        lbl_diesel_din.Size = New Size(42, 15)
        lbl_diesel_din.TabIndex = 10
        lbl_diesel_din.Text = "_______"
        ' 
        ' lbl_magna_din
        ' 
        lbl_magna_din.AutoSize = True
        lbl_magna_din.Location = New Point(211, 66)
        lbl_magna_din.Name = "lbl_magna_din"
        lbl_magna_din.Size = New Size(42, 15)
        lbl_magna_din.TabIndex = 9
        lbl_magna_din.Text = "_______"
        ' 
        ' lbl_premium_din
        ' 
        lbl_premium_din.AutoSize = True
        lbl_premium_din.Location = New Point(211, 36)
        lbl_premium_din.Name = "lbl_premium_din"
        lbl_premium_din.Size = New Size(42, 15)
        lbl_premium_din.TabIndex = 8
        lbl_premium_din.Text = "_______"
        ' 
        ' lbl_suma_combustible
        ' 
        lbl_suma_combustible.AutoSize = True
        lbl_suma_combustible.Location = New Point(119, 138)
        lbl_suma_combustible.Name = "lbl_suma_combustible"
        lbl_suma_combustible.Size = New Size(42, 15)
        lbl_suma_combustible.TabIndex = 7
        lbl_suma_combustible.Text = "_______"
        ' 
        ' suma_combustible
        ' 
        suma_combustible.AutoSize = True
        suma_combustible.Location = New Point(13, 138)
        suma_combustible.Name = "suma_combustible"
        suma_combustible.Size = New Size(43, 15)
        suma_combustible.TabIndex = 6
        suma_combustible.Text = "SUMA:"
        ' 
        ' TOTAL_DIESEL
        ' 
        TOTAL_DIESEL.AutoSize = True
        TOTAL_DIESEL.Location = New Point(119, 104)
        TOTAL_DIESEL.Name = "TOTAL_DIESEL"
        TOTAL_DIESEL.Size = New Size(42, 15)
        TOTAL_DIESEL.TabIndex = 5
        TOTAL_DIESEL.Text = "_______"
        ' 
        ' TOTAL_MAGNA
        ' 
        TOTAL_MAGNA.AutoSize = True
        TOTAL_MAGNA.Location = New Point(119, 66)
        TOTAL_MAGNA.Name = "TOTAL_MAGNA"
        TOTAL_MAGNA.Size = New Size(42, 15)
        TOTAL_MAGNA.TabIndex = 4
        TOTAL_MAGNA.Text = "_______"
        ' 
        ' TOTAL_PREMIUM
        ' 
        TOTAL_PREMIUM.AutoSize = True
        TOTAL_PREMIUM.Location = New Point(119, 36)
        TOTAL_PREMIUM.Name = "TOTAL_PREMIUM"
        TOTAL_PREMIUM.Size = New Size(42, 15)
        TOTAL_PREMIUM.TabIndex = 3
        TOTAL_PREMIUM.Text = "_______"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(14, 104)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 15)
        Label14.TabIndex = 2
        Label14.Text = "DIESEL"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(13, 66)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 15)
        Label13.TabIndex = 1
        Label13.Text = "MAGNA"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(13, 34)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 15)
        Label12.TabIndex = 0
        Label12.Text = "PREMIUM"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(538, 232)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "SIGUIENTE VENTA"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._834fd6db6141c10e2b4f46905058c292
        PictureBox1.Location = New Point(579, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(193, 164)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 512)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(lbl_importe)
        Controls.Add(Label5)
        Controls.Add(GroupBox3)
        Controls.Add(Button1)
        Controls.Add(txtb_litros)
        Controls.Add(Label4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "PEMEX"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txtb_diesel As TextBox
    Friend WithEvents Txtb_magna As TextBox
    Friend WithEvents Txtb_premium As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_diesel As RadioButton
    Friend WithEvents rb_premium As RadioButton
    Friend WithEvents rb_magna As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_litros As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rb_cheque As RadioButton
    Friend WithEvents Rb_tarjeta As RadioButton
    Friend WithEvents rb_efectivo As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_importe As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Total_tarjeta As Label
    Friend WithEvents Total_efectivo As Label
    Friend WithEvents total_cheque As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TOTAL_DIESEL As Label
    Friend WithEvents TOTAL_MAGNA As Label
    Friend WithEvents TOTAL_PREMIUM As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_total_cheque As Label
    Friend WithEvents total_cheque_lbl As Label
    Friend WithEvents Suma_pago As Label
    Friend WithEvents suma_combustible As Label
    Friend WithEvents lbl_suma_pagos As Label
    Friend WithEvents lbl_suma_combustible As Label
    Friend WithEvents lbl_diesel_din As Label
    Friend WithEvents lbl_magna_din As Label
    Friend WithEvents lbl_premium_din As Label
    Friend WithEvents suma_tipo_comb As Label
    Friend WithEvents lbl_suma_tipo_combustible As Label
End Class
