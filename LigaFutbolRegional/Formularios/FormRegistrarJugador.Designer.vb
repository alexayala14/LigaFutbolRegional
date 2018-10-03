<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarJugador
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
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.txt_id_posicion_preferente = New LigaFutbolRegional.ComboBox_01()
        Me.txt_cod_postal = New LigaFutbolRegional.ComboBox_01()
        Me.txt_nro_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_fecha_nacimiento = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_apellido = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nombre = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_tipo_doc = New LigaFutbolRegional.ComboBox_01()
        Me.txt_dni = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegistrar.Location = New System.Drawing.Point(112, 314)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 18
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(216, 314)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 19
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'txt_id_posicion_preferente
        '
        Me.txt_id_posicion_preferente.FormattingEnabled = True
        Me.txt_id_posicion_preferente.Location = New System.Drawing.Point(151, 263)
        Me.txt_id_posicion_preferente.Name = "txt_id_posicion_preferente"
        Me.txt_id_posicion_preferente.nombre_campo = "id_posicion_preferente"
        Me.txt_id_posicion_preferente.nombre_tabla = "Jugador"
        Me.txt_id_posicion_preferente.Size = New System.Drawing.Size(73, 21)
        Me.txt_id_posicion_preferente.TabIndex = 102
        Me.txt_id_posicion_preferente.validable = True
        '
        'txt_cod_postal
        '
        Me.txt_cod_postal.FormattingEnabled = True
        Me.txt_cod_postal.Location = New System.Drawing.Point(151, 233)
        Me.txt_cod_postal.Name = "txt_cod_postal"
        Me.txt_cod_postal.nombre_campo = "cod_postal"
        Me.txt_cod_postal.nombre_tabla = "Jugador"
        Me.txt_cod_postal.Size = New System.Drawing.Size(73, 21)
        Me.txt_cod_postal.TabIndex = 101
        Me.txt_cod_postal.validable = True
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Location = New System.Drawing.Point(151, 207)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.nombre_campo = "nro_calle"
        Me.txt_nro_calle.nombre_tabla = "Jugador"
        Me.txt_nro_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_calle.TabIndex = 100
        Me.txt_nro_calle.validable = True
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(151, 181)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.nombre_campo = "calle"
        Me.txt_calle.nombre_tabla = "Jugador"
        Me.txt_calle.Size = New System.Drawing.Size(191, 20)
        Me.txt_calle.TabIndex = 99
        Me.txt_calle.validable = True
        '
        'txt_fecha_nacimiento
        '
        Me.txt_fecha_nacimiento.Location = New System.Drawing.Point(151, 147)
        Me.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento"
        Me.txt_fecha_nacimiento.nombre_campo = "fecha_nacimiento"
        Me.txt_fecha_nacimiento.nombre_tabla = "Jugador"
        Me.txt_fecha_nacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_nacimiento.TabIndex = 98
        Me.txt_fecha_nacimiento.validable = True
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(151, 112)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.nombre_campo = "apellido"
        Me.txt_apellido.nombre_tabla = "Jugador"
        Me.txt_apellido.Size = New System.Drawing.Size(191, 20)
        Me.txt_apellido.TabIndex = 97
        Me.txt_apellido.validable = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(151, 78)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "nombre"
        Me.txt_nombre.nombre_tabla = "Jugador"
        Me.txt_nombre.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre.TabIndex = 96
        Me.txt_nombre.validable = True
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(151, 16)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.nombre_campo = "tipo_doc"
        Me.cmb_tipo_doc.nombre_tabla = "Jugador"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(73, 21)
        Me.cmb_tipo_doc.TabIndex = 95
        Me.cmb_tipo_doc.validable = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(151, 46)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.nombre_campo = "dni"
        Me.txt_dni.nombre_tabla = "Jugador"
        Me.txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_dni.TabIndex = 94
        Me.txt_dni.validable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "N° Posicion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(121, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "CP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "N° :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Calle:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Fecha Nac:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "N° Documento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Tipo Documento:"
        '
        'FormRegistrarJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(411, 354)
        Me.Controls.Add(Me.txt_id_posicion_preferente)
        Me.Controls.Add(Me.txt_cod_postal)
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
        Me.Controls.Add(Me.BtnRegistrar)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRegistrarJugador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Jugador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents txt_id_posicion_preferente As ComboBox_01
    Friend WithEvents txt_cod_postal As ComboBox_01
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
End Class
