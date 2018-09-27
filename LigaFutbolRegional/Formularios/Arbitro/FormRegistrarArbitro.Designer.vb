<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarArbitro
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fecha_nacimiento = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_tipo_doc = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_rol_autoridad = New LigaFutbolRegional.ComboBox_01()
        Me.txt_apellido = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nombre = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_dni = New LigaFutbolRegional.MaskedTextBox_01()
        Me.lbl_limpiar = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Rol:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Fecha Nac :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(195, 273)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 54
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegistrar.Location = New System.Drawing.Point(93, 273)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 53
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nro Doc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Tipo Doc:"
        '
        'txt_fecha_nacimiento
        '
        Me.txt_fecha_nacimiento.Location = New System.Drawing.Point(120, 169)
        Me.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento"
        Me.txt_fecha_nacimiento.nombre_campo = "fecha_nacimiento"
        Me.txt_fecha_nacimiento.nombre_tabla = "Arbitro"
        Me.txt_fecha_nacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_nacimiento.TabIndex = 60
        Me.txt_fecha_nacimiento.validable = True
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(120, 56)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.nombre_campo = "tipo_doc"
        Me.cmb_tipo_doc.nombre_tabla = "Arbitro"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(55, 21)
        Me.cmb_tipo_doc.TabIndex = 59
        Me.cmb_tipo_doc.validable = True
        '
        'cmb_rol_autoridad
        '
        Me.cmb_rol_autoridad.FormattingEnabled = True
        Me.cmb_rol_autoridad.Location = New System.Drawing.Point(120, 195)
        Me.cmb_rol_autoridad.Name = "cmb_rol_autoridad"
        Me.cmb_rol_autoridad.nombre_campo = "id_rol"
        Me.cmb_rol_autoridad.nombre_tabla = "RolArbitro"
        Me.cmb_rol_autoridad.Size = New System.Drawing.Size(100, 21)
        Me.cmb_rol_autoridad.TabIndex = 58
        Me.cmb_rol_autoridad.validable = True
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(120, 143)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.nombre_campo = "apellido"
        Me.txt_apellido.nombre_tabla = "Arbitro"
        Me.txt_apellido.Size = New System.Drawing.Size(191, 20)
        Me.txt_apellido.TabIndex = 50
        Me.txt_apellido.validable = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(120, 117)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "nombre"
        Me.txt_nombre.nombre_tabla = "Arbitro"
        Me.txt_nombre.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre.TabIndex = 49
        Me.txt_nombre.validable = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(120, 86)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.nombre_campo = "DNI"
        Me.txt_dni.nombre_tabla = "Arbitro"
        Me.txt_dni.Size = New System.Drawing.Size(191, 20)
        Me.txt_dni.TabIndex = 48
        Me.txt_dni.validable = True
        '
        'lbl_limpiar
        '
        Me.lbl_limpiar.AutoSize = True
        Me.lbl_limpiar.Location = New System.Drawing.Point(231, 59)
        Me.lbl_limpiar.Name = "lbl_limpiar"
        Me.lbl_limpiar.Size = New System.Drawing.Size(80, 13)
        Me.lbl_limpiar.TabIndex = 107
        Me.lbl_limpiar.TabStop = True
        Me.lbl_limpiar.Text = "Limpiar campos"
        '
        'FormRegistrarArbitro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(359, 353)
        Me.Controls.Add(Me.lbl_limpiar)
        Me.Controls.Add(Me.txt_fecha_nacimiento)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.cmb_rol_autoridad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRegistrarArbitro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Arbitro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_rol_autoridad As ComboBox_01
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents txt_apellido As MaskedTextBox_01
    Friend WithEvents txt_nombre As MaskedTextBox_01
    Friend WithEvents txt_dni As MaskedTextBox_01
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_tipo_doc As ComboBox_01
    Friend WithEvents txt_fecha_nacimiento As MaskedTextBox_01
    Friend WithEvents lbl_limpiar As LinkLabel
End Class
