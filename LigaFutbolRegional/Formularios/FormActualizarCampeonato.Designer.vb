﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizarCampeonato
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
        Me.cmb_id_estado_club = New LigaFutbolRegional.ComboBox_01()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.txt_cod_postal = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nro_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nro_cuil = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nombre_club = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_siglas = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_011 = New LigaFutbolRegional.ComboBox_01()
        Me.SuspendLayout()
        '
        'cmb_id_estado_club
        '
        Me.cmb_id_estado_club.FormattingEnabled = True
        Me.cmb_id_estado_club.Location = New System.Drawing.Point(145, 250)
        Me.cmb_id_estado_club.Name = "cmb_id_estado_club"
        Me.cmb_id_estado_club.nombre_campo = "id_estado_club"
        Me.cmb_id_estado_club.nombre_tabla = "ClubFutbol"
        Me.cmb_id_estado_club.Size = New System.Drawing.Size(55, 21)
        Me.cmb_id_estado_club.TabIndex = 76
        Me.cmb_id_estado_club.validable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Id Estado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Puntaje Empate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Puntaje Victoria :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(227, 299)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 72
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegistrar.Location = New System.Drawing.Point(125, 299)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 71
        Me.BtnRegistrar.Text = "Actualizar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'txt_cod_postal
        '
        Me.txt_cod_postal.Location = New System.Drawing.Point(145, 220)
        Me.txt_cod_postal.Name = "txt_cod_postal"
        Me.txt_cod_postal.nombre_campo = "cod_postal"
        Me.txt_cod_postal.nombre_tabla = "ClubFutbol"
        Me.txt_cod_postal.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_postal.TabIndex = 70
        Me.txt_cod_postal.validable = True
        Me.txt_cod_postal.ValidatingType = GetType(Integer)
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Location = New System.Drawing.Point(145, 194)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.nombre_campo = "nro_calle"
        Me.txt_nro_calle.nombre_tabla = "ClubFutbol"
        Me.txt_nro_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_calle.TabIndex = 69
        Me.txt_nro_calle.validable = True
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(145, 168)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.nombre_campo = "calle"
        Me.txt_calle.nombre_tabla = "ClubFutbol"
        Me.txt_calle.Size = New System.Drawing.Size(191, 20)
        Me.txt_calle.TabIndex = 68
        Me.txt_calle.validable = True
        '
        'txt_nro_cuil
        '
        Me.txt_nro_cuil.Location = New System.Drawing.Point(145, 142)
        Me.txt_nro_cuil.Name = "txt_nro_cuil"
        Me.txt_nro_cuil.nombre_campo = "nro_cuil"
        Me.txt_nro_cuil.nombre_tabla = "ClubFutbol"
        Me.txt_nro_cuil.Size = New System.Drawing.Size(191, 20)
        Me.txt_nro_cuil.TabIndex = 67
        Me.txt_nro_cuil.validable = True
        '
        'txt_nombre_club
        '
        Me.txt_nombre_club.Location = New System.Drawing.Point(145, 108)
        Me.txt_nombre_club.Name = "txt_nombre_club"
        Me.txt_nombre_club.nombre_campo = "nombre_club"
        Me.txt_nombre_club.nombre_tabla = "ClubFutbol"
        Me.txt_nombre_club.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre_club.TabIndex = 66
        Me.txt_nombre_club.validable = True
        '
        'txt_siglas
        '
        Me.txt_siglas.Location = New System.Drawing.Point(145, 76)
        Me.txt_siglas.Name = "txt_siglas"
        Me.txt_siglas.nombre_campo = "siglas"
        Me.txt_siglas.nombre_tabla = "ClubFutbol"
        Me.txt_siglas.Size = New System.Drawing.Size(100, 20)
        Me.txt_siglas.TabIndex = 65
        Me.txt_siglas.validable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Fecha Fin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Fecha Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Año:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Id:"
        '
        'ComboBox_011
        '
        Me.ComboBox_011.FormattingEnabled = True
        Me.ComboBox_011.Location = New System.Drawing.Point(145, 46)
        Me.ComboBox_011.Name = "ComboBox_011"
        Me.ComboBox_011.nombre_campo = "id_estado_club"
        Me.ComboBox_011.nombre_tabla = "ClubFutbol"
        Me.ComboBox_011.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_011.TabIndex = 77
        Me.ComboBox_011.validable = True
        '
        'FormActualizarCampeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(388, 369)
        Me.Controls.Add(Me.ComboBox_011)
        Me.Controls.Add(Me.cmb_id_estado_club)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.txt_cod_postal)
        Me.Controls.Add(Me.txt_nro_calle)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_nro_cuil)
        Me.Controls.Add(Me.txt_nombre_club)
        Me.Controls.Add(Me.txt_siglas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormActualizarCampeonato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Campeonato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_id_estado_club As ComboBox_01
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents txt_cod_postal As MaskedTextBox_01
    Friend WithEvents txt_nro_calle As MaskedTextBox_01
    Friend WithEvents txt_calle As MaskedTextBox_01
    Friend WithEvents txt_nro_cuil As MaskedTextBox_01
    Friend WithEvents txt_nombre_club As MaskedTextBox_01
    Friend WithEvents txt_siglas As MaskedTextBox_01
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_011 As ComboBox_01
End Class
