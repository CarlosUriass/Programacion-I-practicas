<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        btn_calcular = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        txtb_cliente = New TextBox()
        txtb_cantidad = New TextBox()
        Lbl_unit = New Label()
        Lbl_total = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(91, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre del cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 20)
        Label2.TabIndex = 1
        Label2.Text = "Cantidad de ladrillos:"
        ' 
        ' btn_calcular
        ' 
        btn_calcular.Location = New Point(154, 187)
        btn_calcular.Name = "btn_calcular"
        btn_calcular.Size = New Size(175, 29)
        btn_calcular.TabIndex = 2
        btn_calcular.Text = "CALCULAR IMPORTE"
        btn_calcular.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(91, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 3
        Label3.Text = "Precio unitario:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(99, 303)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 4
        Label4.Text = "Total a pagar:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(196, 380)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 5
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(370, 380)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 6
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtb_cliente
        ' 
        txtb_cliente.Location = New Point(258, 40)
        txtb_cliente.Name = "txtb_cliente"
        txtb_cliente.Size = New Size(125, 27)
        txtb_cliente.TabIndex = 7
        ' 
        ' txtb_cantidad
        ' 
        txtb_cantidad.Location = New Point(258, 123)
        txtb_cantidad.Name = "txtb_cantidad"
        txtb_cantidad.Size = New Size(125, 27)
        txtb_cantidad.TabIndex = 8
        ' 
        ' Lbl_unit
        ' 
        Lbl_unit.AutoSize = True
        Lbl_unit.Location = New Point(219, 246)
        Lbl_unit.Name = "Lbl_unit"
        Lbl_unit.Size = New Size(183, 20)
        Lbl_unit.TabIndex = 9
        Lbl_unit.Text = "_____________________________"
        ' 
        ' Lbl_total
        ' 
        Lbl_total.AutoSize = True
        Lbl_total.Location = New Point(219, 303)
        Lbl_total.Name = "Lbl_total"
        Lbl_total.Size = New Size(183, 20)
        Lbl_total.TabIndex = 10
        Lbl_total.Text = "_____________________________"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ladrillos_antiacidos
        PictureBox1.Location = New Point(468, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(305, 280)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Lbl_total)
        Controls.Add(Lbl_unit)
        Controls.Add(txtb_cantidad)
        Controls.Add(txtb_cliente)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btn_calcular)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtb_cliente As TextBox
    Friend WithEvents txtb_cantidad As TextBox
    Friend WithEvents Lbl_unit As Label
    Friend WithEvents Lbl_total As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
