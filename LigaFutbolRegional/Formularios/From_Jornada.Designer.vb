<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class From_Jornada
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_id_campeonato = New LigaFutbolRegional.ComboBox_01()
        Me.DGV_Jornadas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DGV_Jornadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Campeonato"
        '
        'cmb_id_campeonato
        '
        Me.cmb_id_campeonato.FormattingEnabled = True
        Me.cmb_id_campeonato.Location = New System.Drawing.Point(161, 41)
        Me.cmb_id_campeonato.Name = "cmb_id_campeonato"
        Me.cmb_id_campeonato.nombre_campo = "id_campeonato"
        Me.cmb_id_campeonato.nombre_tabla = "Inscripcion"
        Me.cmb_id_campeonato.Size = New System.Drawing.Size(121, 21)
        Me.cmb_id_campeonato.TabIndex = 0
        Me.cmb_id_campeonato.validable = False
        '
        'DGV_Jornadas
        '
        Me.DGV_Jornadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Jornadas.Location = New System.Drawing.Point(33, 140)
        Me.DGV_Jornadas.Name = "DGV_Jornadas"
        Me.DGV_Jornadas.ReadOnly = True
        Me.DGV_Jornadas.Size = New System.Drawing.Size(415, 133)
        Me.DGV_Jornadas.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar Fechas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(372, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'From_Jornada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(494, 373)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV_Jornadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_id_campeonato)
        Me.Name = "From_Jornada"
        Me.Text = "From_Jornada"
        CType(Me.DGV_Jornadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_id_campeonato As ComboBox_01
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_Jornadas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
