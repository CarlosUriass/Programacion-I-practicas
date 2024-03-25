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
        Label2 = New Label()
        txtb_nombre = New TextBox()
        txtb_dias = New TextBox()
        Label3 = New Label()
        txtb_sueldo = New TextBox()
        Label4 = New Label()
        txtb_cuenta = New TextBox()
        Label5 = New Label()
        txtb_email = New TextBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        txtb_utilidad = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(179, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(373, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 1
        Label2.Text = "Dias trabajados:"
        ' 
        ' txtb_nombre
        ' 
        txtb_nombre.Location = New Point(239, 128)
        txtb_nombre.Name = "txtb_nombre"
        txtb_nombre.Size = New Size(105, 23)
        txtb_nombre.TabIndex = 2
        ' 
        ' txtb_dias
        ' 
        txtb_dias.Location = New Point(469, 125)
        txtb_dias.Name = "txtb_dias"
        txtb_dias.Size = New Size(105, 23)
        txtb_dias.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(146, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 4
        Label3.Text = "Sueldo (diario):"
        ' 
        ' txtb_sueldo
        ' 
        txtb_sueldo.Location = New Point(239, 168)
        txtb_sueldo.Name = "txtb_sueldo"
        txtb_sueldo.Size = New Size(105, 23)
        txtb_sueldo.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(370, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 15)
        Label4.TabIndex = 6
        Label4.Text = "Cuenta bancaria"
        ' 
        ' txtb_cuenta
        ' 
        txtb_cuenta.Location = New Point(469, 173)
        txtb_cuenta.Name = "txtb_cuenta"
        txtb_cuenta.Size = New Size(105, 23)
        txtb_cuenta.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(194, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 8
        Label5.Text = "Email:"
        ' 
        ' txtb_email
        ' 
        txtb_email.Location = New Point(239, 202)
        txtb_email.Name = "txtb_email"
        txtb_email.Size = New Size(335, 23)
        txtb_email.TabIndex = 9
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(-2, 293)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(803, 94)
        ListBox1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(338, 231)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 23)
        Button1.TabIndex = 11
        Button1.Text = "Siguiente"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(674, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 23)
        Button2.TabIndex = 12
        Button2.Text = "Calcular utilidades"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(179, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 15)
        Label6.TabIndex = 13
        Label6.Text = "Utilidad a repartir:"
        ' 
        ' txtb_utilidad
        ' 
        txtb_utilidad.Location = New Point(286, 37)
        txtb_utilidad.Name = "txtb_utilidad"
        txtb_utilidad.Size = New Size(166, 23)
        txtb_utilidad.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtb_utilidad)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(txtb_email)
        Controls.Add(Label5)
        Controls.Add(txtb_cuenta)
        Controls.Add(Label4)
        Controls.Add(txtb_sueldo)
        Controls.Add(Label3)
        Controls.Add(txtb_dias)
        Controls.Add(txtb_nombre)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_nombre As TextBox
    Friend WithEvents txtb_dias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_sueldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_cuenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtb_email As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtb_utilidad As TextBox

End Class
