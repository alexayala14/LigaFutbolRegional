<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarFechasYPartidos
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.txt_fecha = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_visitante = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_local = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_local = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_visitante = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_estado = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_fecha = New LigaFutbolRegional.ComboBox_01()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Fecha Hora Inicio :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(229, 301)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 72
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegistrar.Location = New System.Drawing.Point(127, 301)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 71
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(148, 232)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.nombre_campo = "fecha_hora_inicio"
        Me.txt_fecha.nombre_tabla = "Partido"
        Me.txt_fecha.Size = New System.Drawing.Size(110, 20)
        Me.txt_fecha.TabIndex = 69
        Me.txt_fecha.validable = True
        '
        'txt_visitante
        '
        Me.txt_visitante.Location = New System.Drawing.Point(148, 206)
        Me.txt_visitante.Name = "txt_visitante"
        Me.txt_visitante.nombre_campo = "goles_visitante"
        Me.txt_visitante.nombre_tabla = "Partido"
        Me.txt_visitante.Size = New System.Drawing.Size(70, 20)
        Me.txt_visitante.TabIndex = 68
        Me.txt_visitante.validable = True
        '
        'txt_local
        '
        Me.txt_local.Location = New System.Drawing.Point(148, 180)
        Me.txt_local.Name = "txt_local"
        Me.txt_local.nombre_campo = "goles_locales"
        Me.txt_local.nombre_tabla = "Partido"
        Me.txt_local.Size = New System.Drawing.Size(70, 20)
        Me.txt_local.TabIndex = 67
        Me.txt_local.validable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Goles Visitante:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Goles Local:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Club Visitante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Club Local:"
        '
        'cmb_local
        '
        Me.cmb_local.FormattingEnabled = True
        Me.cmb_local.Location = New System.Drawing.Point(148, 79)
        Me.cmb_local.Name = "cmb_local"
        Me.cmb_local.nombre_campo = "id_club_local"
        Me.cmb_local.nombre_tabla = "Partido"
        Me.cmb_local.Size = New System.Drawing.Size(100, 21)
        Me.cmb_local.TabIndex = 77
        Me.cmb_local.validable = True
        '
        'cmb_visitante
        '
        Me.cmb_visitante.FormattingEnabled = True
        Me.cmb_visitante.Location = New System.Drawing.Point(148, 114)
        Me.cmb_visitante.Name = "cmb_visitante"
        Me.cmb_visitante.nombre_campo = "id_club_visitante"
        Me.cmb_visitante.nombre_tabla = "Partido"
        Me.cmb_visitante.Size = New System.Drawing.Size(100, 21)
        Me.cmb_visitante.TabIndex = 78
        Me.cmb_visitante.validable = True
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(148, 146)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.nombre_campo = "id_estado_partido"
        Me.cmb_estado.nombre_tabla = "Partido"
        Me.cmb_estado.Size = New System.Drawing.Size(100, 21)
        Me.cmb_estado.TabIndex = 79
        Me.cmb_estado.validable = True
        '
        'cmb_fecha
        '
        Me.cmb_fecha.FormattingEnabled = True
        Me.cmb_fecha.Location = New System.Drawing.Point(148, 36)
        Me.cmb_fecha.Name = "cmb_fecha"
        Me.cmb_fecha.nombre_campo = "numero_fecha"
        Me.cmb_fecha.nombre_tabla = "FechaXCampeonato"
        Me.cmb_fecha.Size = New System.Drawing.Size(100, 21)
        Me.cmb_fecha.TabIndex = 81
        Me.cmb_fecha.validable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Fecha Campeonato:"
        '
        'FormRegistrarFechasYPartidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(392, 373)
        Me.Controls.Add(Me.cmb_fecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.cmb_visitante)
        Me.Controls.Add(Me.cmb_local)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_visitante)
        Me.Controls.Add(Me.txt_local)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRegistrarFechasYPartidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Fechas Y Partidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents txt_fecha As MaskedTextBox_01
    Friend WithEvents txt_visitante As MaskedTextBox_01
    Friend WithEvents txt_local As MaskedTextBox_01
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_local As ComboBox_01
    Friend WithEvents cmb_visitante As ComboBox_01
    Friend WithEvents cmb_estado As ComboBox_01
    Friend WithEvents cmb_fecha As ComboBox_01
    Friend WithEvents Label5 As Label
End Class
