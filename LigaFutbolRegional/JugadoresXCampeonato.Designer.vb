<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JugadoresXCampeonato
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
        Me.lista_elementos = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nuevo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lista_elementos
        '
        Me.lista_elementos.FormattingEnabled = True
        Me.lista_elementos.Location = New System.Drawing.Point(109, 114)
        Me.lista_elementos.Name = "lista_elementos"
        Me.lista_elementos.Size = New System.Drawing.Size(120, 95)
        Me.lista_elementos.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(320, 114)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 1
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(274, 273)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "Button1"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Club"
        '
        'txt_nuevo
        '
        Me.txt_nuevo.Location = New System.Drawing.Point(129, 273)
        Me.txt_nuevo.Name = "txt_nuevo"
        Me.txt_nuevo.Size = New System.Drawing.Size(100, 20)
        Me.txt_nuevo.TabIndex = 4
        '
        'JugadoresXCampeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_nuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.lista_elementos)
        Me.Name = "JugadoresXCampeonato"
        Me.Text = "JugadoresXCampeonato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lista_elementos As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nuevo As TextBox
End Class
