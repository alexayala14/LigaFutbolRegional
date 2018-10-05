<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizarJugador
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.cmd_estado_jugador = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_cod_postal = New LigaFutbolRegional.ComboBox_01()
        Me.txt_nro_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_fecha_nacimiento = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_apellido = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nombre = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_tipo_doc = New LigaFutbolRegional.ComboBox_01()
        Me.txt_dni = New LigaFutbolRegional.MaskedTextBox_01()
        Me.lbl_limpiar = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Estado Jugador:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "CP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "N° :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Calle:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Fecha Nac:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "N° Documento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Tipo Documento:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(275, 334)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 104
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnActualizar.Location = New System.Drawing.Point(146, 334)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 103
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBuscar.Location = New System.Drawing.Point(27, 334)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 123
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'cmd_estado_jugador
        '
        Me.cmd_estado_jugador.FormattingEnabled = True
        Me.cmd_estado_jugador.Location = New System.Drawing.Point(148, 283)
        Me.cmd_estado_jugador.Name = "cmd_estado_jugador"
        Me.cmd_estado_jugador.nombre_campo = "id_estado"
        Me.cmd_estado_jugador.nombre_tabla = "Jugador"
        Me.cmd_estado_jugador.Size = New System.Drawing.Size(73, 21)
        Me.cmd_estado_jugador.TabIndex = 122
        Me.cmd_estado_jugador.validable = True
        '
        'cmb_cod_postal
        '
        Me.cmb_cod_postal.FormattingEnabled = True
        Me.cmb_cod_postal.Location = New System.Drawing.Point(148, 253)
        Me.cmb_cod_postal.Name = "cmb_cod_postal"
        Me.cmb_cod_postal.nombre_campo = "cod_postal"
        Me.cmb_cod_postal.nombre_tabla = "Jugador"
        Me.cmb_cod_postal.Size = New System.Drawing.Size(73, 21)
        Me.cmb_cod_postal.TabIndex = 121
        Me.cmb_cod_postal.validable = True
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Location = New System.Drawing.Point(148, 227)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.nombre_campo = "nro_calle"
        Me.txt_nro_calle.nombre_tabla = "Jugador"
        Me.txt_nro_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_calle.TabIndex = 120
        Me.txt_nro_calle.validable = True
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(148, 201)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.nombre_campo = "calle"
        Me.txt_calle.nombre_tabla = "Jugador"
        Me.txt_calle.Size = New System.Drawing.Size(191, 20)
        Me.txt_calle.TabIndex = 119
        Me.txt_calle.validable = True
        '
        'txt_fecha_nacimiento
        '
        Me.txt_fecha_nacimiento.Location = New System.Drawing.Point(148, 167)
        Me.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento"
        Me.txt_fecha_nacimiento.nombre_campo = "fecha_nacimiento"
        Me.txt_fecha_nacimiento.nombre_tabla = "Jugador"
        Me.txt_fecha_nacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_nacimiento.TabIndex = 118
        Me.txt_fecha_nacimiento.validable = True
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(148, 132)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.nombre_campo = "apellido"
        Me.txt_apellido.nombre_tabla = "Jugador"
        Me.txt_apellido.Size = New System.Drawing.Size(191, 20)
        Me.txt_apellido.TabIndex = 117
        Me.txt_apellido.validable = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(148, 98)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "nombre"
        Me.txt_nombre.nombre_tabla = "Jugador"
        Me.txt_nombre.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre.TabIndex = 116
        Me.txt_nombre.validable = True
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(148, 36)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.nombre_campo = "tipo_doc"
        Me.cmb_tipo_doc.nombre_tabla = "Jugador"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(73, 21)
        Me.cmb_tipo_doc.TabIndex = 115
        Me.cmb_tipo_doc.validable = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(148, 66)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.nombre_campo = "dni"
        Me.txt_dni.nombre_tabla = "Jugador"
        Me.txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_dni.TabIndex = 114
        Me.txt_dni.validable = True
        '
        'lbl_limpiar
        '
        Me.lbl_limpiar.AutoSize = True
        Me.lbl_limpiar.Location = New System.Drawing.Point(301, 36)
        Me.lbl_limpiar.Name = "lbl_limpiar"
        Me.lbl_limpiar.Size = New System.Drawing.Size(80, 13)
        Me.lbl_limpiar.TabIndex = 124
        Me.lbl_limpiar.TabStop = True
        Me.lbl_limpiar.Text = "Limpiar campos"
        '
        'FormActualizarJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(393, 392)
        Me.Controls.Add(Me.lbl_limpiar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.cmd_estado_jugador)
        Me.Controls.Add(Me.cmb_cod_postal)
        Me.Controls.Add(Me.txt_nro_calle)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_fecha_nacimiento)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormActualizarJugador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Jugador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_estado_jugador As ComboBox_01
    Friend WithEvents cmb_cod_postal As ComboBox_01
    Friend WithEvents txt_nro_calle As MaskedTextBox_01
    Friend WithEvents txt_calle As MaskedTextBox_01
    Friend WithEvents txt_fecha_nacimiento As MaskedTextBox_01
    Friend WithEvents txt_apellido As MaskedTextBox_01
    Friend WithEvents txt_nombre As MaskedTextBox_01
    Friend WithEvents cmb_tipo_doc As ComboBox_01
    Friend WithEvents txt_dni As MaskedTextBox_01
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents lbl_limpiar As LinkLabel
End Class
