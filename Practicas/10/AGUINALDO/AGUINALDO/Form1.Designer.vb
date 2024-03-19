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
        Label1 = New Label()
        txtb_empleado = New TextBox()
        Label2 = New Label()
        txtb_sueldo = New TextBox()
        Label3 = New Label()
        txtb_años = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        lbl_aguinaldo = New Label()
        lbl_aguinaldo_t = New Label()
        lbl_impuestos_t = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(199, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 15)
        Label1.TabIndex = 0
        Label1.Text = "NOMBRE DEL EMPLEADO:"
        ' 
        ' txtb_empleado
        ' 
        txtb_empleado.Location = New Point(351, 91)
        txtb_empleado.Name = "txtb_empleado"
        txtb_empleado.Size = New Size(176, 23)
        txtb_empleado.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(199, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 2
        Label2.Text = "SUELDO DIARIO:"
        ' 
        ' txtb_sueldo
        ' 
        txtb_sueldo.Location = New Point(351, 135)
        txtb_sueldo.Name = "txtb_sueldo"
        txtb_sueldo.Size = New Size(176, 23)
        txtb_sueldo.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(199, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 15)
        Label3.TabIndex = 4
        Label3.Text = "ANTIGUEDAD (EN AÑOS):"
        ' 
        ' txtb_años
        ' 
        txtb_años.Location = New Point(351, 177)
        txtb_años.Name = "txtb_años"
        txtb_años.Size = New Size(176, 23)
        txtb_años.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(318, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 23)
        Button1.TabIndex = 6
        Button1.Text = "CALCULAR AGUINALDO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(149, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 15)
        Label4.TabIndex = 7
        Label4.Text = "AGUINALDO A PAGAR:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(149, 376)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 8
        Label5.Text = "TOTAL A PAGAR:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(149, 402)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 15)
        Label6.TabIndex = 9
        Label6.Text = "TOTAL IMPUESTOS RETENIDOS:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(318, 329)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 23)
        Button2.TabIndex = 10
        Button2.Text = "LIMPIAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.pngimg_com___christmas_tree_PNG145
        PictureBox1.Location = New Point(543, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 283)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lbl_aguinaldo
        ' 
        lbl_aguinaldo.AutoSize = True
        lbl_aguinaldo.Location = New Point(280, 290)
        lbl_aguinaldo.Name = "lbl_aguinaldo"
        lbl_aguinaldo.Size = New Size(0, 15)
        lbl_aguinaldo.TabIndex = 12
        ' 
        ' lbl_aguinaldo_t
        ' 
        lbl_aguinaldo_t.AutoSize = True
        lbl_aguinaldo_t.Location = New Point(249, 375)
        lbl_aguinaldo_t.Name = "lbl_aguinaldo_t"
        lbl_aguinaldo_t.Size = New Size(42, 15)
        lbl_aguinaldo_t.TabIndex = 13
        lbl_aguinaldo_t.Text = "_______"
        ' 
        ' lbl_impuestos_t
        ' 
        lbl_impuestos_t.AutoSize = True
        lbl_impuestos_t.Location = New Point(326, 403)
        lbl_impuestos_t.Name = "lbl_impuestos_t"
        lbl_impuestos_t.Size = New Size(37, 15)
        lbl_impuestos_t.TabIndex = 14
        lbl_impuestos_t.Text = "______"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_impuestos_t)
        Controls.Add(lbl_aguinaldo_t)
        Controls.Add(lbl_aguinaldo)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(txtb_años)
        Controls.Add(Label3)
        Controls.Add(txtb_sueldo)
        Controls.Add(Label2)
        Controls.Add(txtb_empleado)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtb_empleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_sueldo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_años As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_aguinaldo As Label
    Friend WithEvents lbl_aguinaldo_t As Label
    Friend WithEvents lbl_impuestos_t As Label
End Class
