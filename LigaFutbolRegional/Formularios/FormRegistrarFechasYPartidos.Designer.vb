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
        Me.txt_nro_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nro_cuil = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_011 = New LigaFutbolRegional.ComboBox_01()
        Me.ComboBox_012 = New LigaFutbolRegional.ComboBox_01()
        Me.ComboBox_013 = New LigaFutbolRegional.ComboBox_01()
        Me.ComboBox_014 = New LigaFutbolRegional.ComboBox_01()
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
        'txt_nro_calle
        '
        Me.txt_nro_calle.Location = New System.Drawing.Point(148, 232)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.nombre_campo = "nro_calle"
        Me.txt_nro_calle.nombre_tabla = "ClubFutbol"
        Me.txt_nro_calle.Size = New System.Drawing.Size(110, 20)
        Me.txt_nro_calle.TabIndex = 69
        Me.txt_nro_calle.validable = True
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(148, 206)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.nombre_campo = "calle"
        Me.txt_calle.nombre_tabla = "ClubFutbol"
        Me.txt_calle.Size = New System.Drawing.Size(70, 20)
        Me.txt_calle.TabIndex = 68
        Me.txt_calle.validable = True
        '
        'txt_nro_cuil
        '
        Me.txt_nro_cuil.Location = New System.Drawing.Point(148, 180)
        Me.txt_nro_cuil.Name = "txt_nro_cuil"
        Me.txt_nro_cuil.nombre_campo = "nro_cuil"
        Me.txt_nro_cuil.nombre_tabla = "ClubFutbol"
        Me.txt_nro_cuil.Size = New System.Drawing.Size(70, 20)
        Me.txt_nro_cuil.TabIndex = 67
        Me.txt_nro_cuil.validable = True
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
        'ComboBox_011
        '
        Me.ComboBox_011.FormattingEnabled = True
        Me.ComboBox_011.Location = New System.Drawing.Point(148, 79)
        Me.ComboBox_011.Name = "ComboBox_011"
        Me.ComboBox_011.nombre_campo = "id_estado_club"
        Me.ComboBox_011.nombre_tabla = "ClubFutbol"
        Me.ComboBox_011.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_011.TabIndex = 77
        Me.ComboBox_011.validable = True
        '
        'ComboBox_012
        '
        Me.ComboBox_012.FormattingEnabled = True
        Me.ComboBox_012.Location = New System.Drawing.Point(148, 114)
        Me.ComboBox_012.Name = "ComboBox_012"
        Me.ComboBox_012.nombre_campo = "id_estado_club"
        Me.ComboBox_012.nombre_tabla = "ClubFutbol"
        Me.ComboBox_012.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_012.TabIndex = 78
        Me.ComboBox_012.validable = True
        '
        'ComboBox_013
        '
        Me.ComboBox_013.FormattingEnabled = True
        Me.ComboBox_013.Location = New System.Drawing.Point(148, 146)
        Me.ComboBox_013.Name = "ComboBox_013"
        Me.ComboBox_013.nombre_campo = "id_estado_club"
        Me.ComboBox_013.nombre_tabla = "ClubFutbol"
        Me.ComboBox_013.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_013.TabIndex = 79
        Me.ComboBox_013.validable = True
        '
        'ComboBox_014
        '
        Me.ComboBox_014.FormattingEnabled = True
        Me.ComboBox_014.Location = New System.Drawing.Point(148, 36)
        Me.ComboBox_014.Name = "ComboBox_014"
        Me.ComboBox_014.nombre_campo = "id_estado_club"
        Me.ComboBox_014.nombre_tabla = "ClubFutbol"
        Me.ComboBox_014.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_014.TabIndex = 81
        Me.ComboBox_014.validable = True
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
        Me.Controls.Add(Me.ComboBox_014)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox_013)
        Me.Controls.Add(Me.ComboBox_012)
        Me.Controls.Add(Me.ComboBox_011)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.txt_nro_calle)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_nro_cuil)
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
    Friend WithEvents txt_nro_calle As MaskedTextBox_01
    Friend WithEvents txt_calle As MaskedTextBox_01
    Friend WithEvents txt_nro_cuil As MaskedTextBox_01
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_011 As ComboBox_01
    Friend WithEvents ComboBox_012 As ComboBox_01
    Friend WithEvents ComboBox_013 As ComboBox_01
    Friend WithEvents ComboBox_014 As ComboBox_01
    Friend WithEvents Label5 As Label
End Class
