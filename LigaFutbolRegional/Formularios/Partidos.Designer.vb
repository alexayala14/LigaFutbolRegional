<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partidos
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txt_anio = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_jornada = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_id_campeonato = New LigaFutbolRegional.ComboBox_01()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Campenato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jornada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Año"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(278, 49)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(355, 150)
        Me.DGV.TabIndex = 12
        '
        'txt_anio
        '
        Me.txt_anio.Enabled = False
        Me.txt_anio.Location = New System.Drawing.Point(111, 86)
        Me.txt_anio.Name = "txt_anio"
        Me.txt_anio.nombre_campo = Nothing
        Me.txt_anio.nombre_tabla = Nothing
        Me.txt_anio.Size = New System.Drawing.Size(100, 20)
        Me.txt_anio.TabIndex = 9
        Me.txt_anio.validable = False
        '
        'cmb_jornada
        '
        Me.cmb_jornada.FormattingEnabled = True
        Me.cmb_jornada.Location = New System.Drawing.Point(111, 123)
        Me.cmb_jornada.Name = "cmb_jornada"
        Me.cmb_jornada.nombre_campo = Nothing
        Me.cmb_jornada.nombre_tabla = Nothing
        Me.cmb_jornada.Size = New System.Drawing.Size(121, 21)
        Me.cmb_jornada.TabIndex = 2
        Me.cmb_jornada.validable = False
        '
        'cmb_id_campeonato
        '
        Me.cmb_id_campeonato.FormattingEnabled = True
        Me.cmb_id_campeonato.Location = New System.Drawing.Point(111, 50)
        Me.cmb_id_campeonato.Name = "cmb_id_campeonato"
        Me.cmb_id_campeonato.nombre_campo = Nothing
        Me.cmb_id_campeonato.nombre_tabla = Nothing
        Me.cmb_id_campeonato.Size = New System.Drawing.Size(121, 21)
        Me.cmb_id_campeonato.TabIndex = 1
        Me.cmb_id_campeonato.validable = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(362, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Diagramación"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(540, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Partidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(681, 326)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_anio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_jornada)
        Me.Controls.Add(Me.cmb_id_campeonato)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Partidos"
        Me.Text = "Partidos"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cmb_id_campeonato As ComboBox_01
    Friend WithEvents cmb_jornada As ComboBox_01
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents club1 As DataGridViewTextBoxColumn
    Friend WithEvents club2 As DataGridViewTextBoxColumn
    Friend WithEvents txt_anio As MaskedTextBox_01
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
