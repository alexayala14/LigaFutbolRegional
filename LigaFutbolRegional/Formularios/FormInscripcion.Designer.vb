﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInscripcion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fecha_cierre = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_campeonato = New LigaFutbolRegional.ComboBox_01()
        Me.txt_fecha = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_estado = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_club = New LigaFutbolRegional.ComboBox_01()
        Me.txt_anio_campeonato = New LigaFutbolRegional.MaskedTextBox_01()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBaja
        '
        Me.btnBaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBaja.Location = New System.Drawing.Point(301, 69)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnBaja.TabIndex = 131
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlta.Location = New System.Drawing.Point(301, 26)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 130
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(398, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 23)
        Me.btnBuscar.TabIndex = 128
        Me.btnBuscar.Text = "Agregar Jugador"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Fecha Inscripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Estado :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Club:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Año:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Campeonato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Fecha Cierre:"
        '
        'txt_fecha_cierre
        '
        Me.txt_fecha_cierre.Location = New System.Drawing.Point(110, 187)
        Me.txt_fecha_cierre.Mask = "00/00/0000"
        Me.txt_fecha_cierre.Name = "txt_fecha_cierre"
        Me.txt_fecha_cierre.nombre_campo = "fechaCierre"
        Me.txt_fecha_cierre.nombre_tabla = "Inscripcion"
        Me.txt_fecha_cierre.Size = New System.Drawing.Size(76, 20)
        Me.txt_fecha_cierre.TabIndex = 138
        Me.txt_fecha_cierre.validable = True
        '
        'cmb_campeonato
        '
        Me.cmb_campeonato.FormattingEnabled = True
        Me.cmb_campeonato.Location = New System.Drawing.Point(113, 23)
        Me.cmb_campeonato.Name = "cmb_campeonato"
        Me.cmb_campeonato.nombre_campo = "id_campeonato"
        Me.cmb_campeonato.nombre_tabla = "Inscripcion"
        Me.cmb_campeonato.Size = New System.Drawing.Size(100, 21)
        Me.cmb_campeonato.TabIndex = 135
        Me.cmb_campeonato.validable = True
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(110, 157)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.nombre_campo = "fechaInscripcion"
        Me.txt_fecha.nombre_tabla = "Inscripcion"
        Me.txt_fecha.Size = New System.Drawing.Size(76, 20)
        Me.txt_fecha.TabIndex = 119
        Me.txt_fecha.validable = True
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(113, 124)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.nombre_campo = "estado"
        Me.cmb_estado.nombre_tabla = "Inscripcion"
        Me.cmb_estado.Size = New System.Drawing.Size(73, 21)
        Me.cmb_estado.TabIndex = 118
        Me.cmb_estado.validable = True
        '
        'cmb_club
        '
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(113, 88)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.nombre_campo = "id_club"
        Me.cmb_club.nombre_tabla = "Inscripcion"
        Me.cmb_club.Size = New System.Drawing.Size(100, 21)
        Me.cmb_club.TabIndex = 114
        Me.cmb_club.validable = True
        '
        'txt_anio_campeonato
        '
        Me.txt_anio_campeonato.Enabled = False
        Me.txt_anio_campeonato.Location = New System.Drawing.Point(113, 59)
        Me.txt_anio_campeonato.Name = "txt_anio_campeonato"
        Me.txt_anio_campeonato.nombre_campo = "anio_campeonato"
        Me.txt_anio_campeonato.nombre_tabla = "Inscripcion"
        Me.txt_anio_campeonato.Size = New System.Drawing.Size(100, 20)
        Me.txt_anio_campeonato.TabIndex = 141
        Me.txt_anio_campeonato.validable = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(473, 222)
        Me.DataGridView1.TabIndex = 142
        '
        'FormInscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(515, 476)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_anio_campeonato)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fecha_cierre)
        Me.Controls.Add(Me.cmb_campeonato)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_club)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInscripcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscripcion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_fecha As MaskedTextBox_01
    Friend WithEvents cmb_estado As ComboBox_01
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_club As ComboBox_01
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_campeonato As ComboBox_01
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fecha_cierre As MaskedTextBox_01
    Friend WithEvents txt_anio_campeonato As MaskedTextBox_01
    Friend WithEvents DataGridView1 As DataGridView

    'Friend WithEvents MaskedTextBox_011 As MaskedTextBox_01

End Class
