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
        ListBox1 = New ListBox()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        cbx_compania = New ComboBox()
        Label3 = New Label()
        txt_num = New TextBox()
        Label4 = New Label()
        btn_x_fecha = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label5 = New Label()
        cbx_mes = New ComboBox()
        Label6 = New Label()
        txtb_año = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(23, 265)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(700, 109)
        ListBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 15)
        Label1.TabIndex = 2
        Label1.Text = "FILTRAR POR FECHA"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(170, 44)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(233, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 15)
        Label2.TabIndex = 5
        Label2.Text = "FILTRAR POR COMPAÑIA"
        ' 
        ' cbx_compania
        ' 
        cbx_compania.FormattingEnabled = True
        cbx_compania.Items.AddRange(New Object() {"TELCEL ", "MOVISTAR", "PILLOFON ", "UNEFON", "AT&T"})
        cbx_compania.Location = New Point(170, 89)
        cbx_compania.Name = "cbx_compania"
        cbx_compania.Size = New Size(233, 23)
        cbx_compania.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 15)
        Label3.TabIndex = 7
        Label3.Text = "FILTRAR POR NUMERO TELEFONICO"
        ' 
        ' txt_num
        ' 
        txt_num.Location = New Point(228, 130)
        txt_num.Name = "txt_num"
        txt_num.Size = New Size(174, 23)
        txt_num.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(240, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 9
        Label4.Text = "Inicio"
        ' 
        ' btn_x_fecha
        ' 
        btn_x_fecha.Location = New Point(453, 47)
        btn_x_fecha.Name = "btn_x_fecha"
        btn_x_fecha.Size = New Size(107, 23)
        btn_x_fecha.TabIndex = 10
        btn_x_fecha.Text = "Filtrar"
        btn_x_fecha.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(453, 89)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 23)
        Button2.TabIndex = 11
        Button2.Text = "Filtrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(453, 130)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 23)
        Button3.TabIndex = 12
        Button3.Text = "Filtrar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 15)
        Label5.TabIndex = 13
        Label5.Text = "FILTRAR POR MES"
        ' 
        ' cbx_mes
        ' 
        cbx_mes.FormattingEnabled = True
        cbx_mes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE ", "OCTUBRE ", "NOVIEMBRE", "DICIEMBRE"})
        cbx_mes.Location = New Point(170, 177)
        cbx_mes.Name = "cbx_mes"
        cbx_mes.Size = New Size(233, 23)
        cbx_mes.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 15)
        Label6.TabIndex = 15
        Label6.Text = "FILTRAR POR AÑO"
        ' 
        ' txtb_año
        ' 
        txtb_año.Location = New Point(170, 216)
        txtb_año.Name = "txtb_año"
        txtb_año.Size = New Size(174, 23)
        txtb_año.TabIndex = 16
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(453, 177)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 23)
        Button4.TabIndex = 17
        Button4.Text = "Filtrar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(453, 215)
        Button5.Name = "Button5"
        Button5.Size = New Size(107, 23)
        Button5.TabIndex = 18
        Button5.Text = "Filtrar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(771, 421)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(txtb_año)
        Controls.Add(Label6)
        Controls.Add(cbx_mes)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btn_x_fecha)
        Controls.Add(Label4)
        Controls.Add(txt_num)
        Controls.Add(Label3)
        Controls.Add(cbx_compania)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_compania As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_x_fecha As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_mes As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtb_año As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
