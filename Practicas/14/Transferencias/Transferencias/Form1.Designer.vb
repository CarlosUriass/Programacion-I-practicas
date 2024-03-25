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
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        MonthCalendar1 = New MonthCalendar()
        Label2 = New Label()
        cbx_banco = New ComboBox()
        Label3 = New Label()
        txtb_clabe = New TextBox()
        Label4 = New Label()
        txtb_importe = New TextBox()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(296, 263)
        Button1.Name = "Button1"
        Button1.Size = New Size(199, 23)
        Button1.TabIndex = 0
        Button1.Text = "Hacer transferencia"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.spei_logo_1
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(195, 72)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(560, 110)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(167, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 5
        Label2.Text = "Banco emisor:"
        ' 
        ' cbx_banco
        ' 
        cbx_banco.FormattingEnabled = True
        cbx_banco.Items.AddRange(New Object() {"BANAMEX", "Banca Serafín, S.A", "BBVA Bancomer, S.A", "Santander Mexicano, S.A", "Banco Nacional del Ejercito y Fuerza Aerea y Armada, S.N.C", "Banco del Bajío, S.A", "Banco Inbursa, S.A", "Scotiabank, S.A", "HSBC", "Azteca"})
        cbx_banco.Location = New Point(296, 102)
        cbx_banco.Name = "cbx_banco"
        cbx_banco.Size = New Size(199, 23)
        cbx_banco.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(167, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 15)
        Label3.TabIndex = 7
        Label3.Text = "CLABE interbancaria"
        ' 
        ' txtb_clabe
        ' 
        txtb_clabe.Location = New Point(296, 156)
        txtb_clabe.Name = "txtb_clabe"
        txtb_clabe.Size = New Size(199, 23)
        txtb_clabe.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(167, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 15)
        Label4.TabIndex = 9
        Label4.Text = "Importe:"
        ' 
        ' txtb_importe
        ' 
        txtb_importe.Location = New Point(296, 210)
        txtb_importe.Name = "txtb_importe"
        txtb_importe.Size = New Size(199, 23)
        txtb_importe.TabIndex = 10
        txtb_importe.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(625, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 11
        Label1.Text = "Seleccione la fecha"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(2, 336)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(900, 184)
        ListBox1.TabIndex = 12
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(2, 307)
        Button2.Name = "Button2"
        Button2.Size = New Size(159, 23)
        Button2.TabIndex = 13
        Button2.Text = "Generar reporte"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(167, 307)
        Button3.Name = "Button3"
        Button3.Size = New Size(159, 23)
        Button3.TabIndex = 14
        Button3.Text = "Entradas por banco"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(336, 307)
        Button4.Name = "Button4"
        Button4.Size = New Size(159, 23)
        Button4.TabIndex = 15
        Button4.Text = "Salidas por banco"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 520)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(txtb_importe)
        Controls.Add(Label4)
        Controls.Add(txtb_clabe)
        Controls.Add(Label3)
        Controls.Add(cbx_banco)
        Controls.Add(Label2)
        Controls.Add(MonthCalendar1)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_banco As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_clabe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_importe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
