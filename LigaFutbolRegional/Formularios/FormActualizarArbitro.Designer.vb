<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizarArbitro
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
        Me.cmb_tipo_doc = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_id_estado_club = New LigaFutbolRegional.ComboBox_01()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.txt_nro_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_calle = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nro_cuil = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nombre_club = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_id_club = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(139, 85)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.nombre_campo = "id_estado_club"
        Me.cmb_tipo_doc.nombre_tabla = "ClubFutbol"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(55, 21)
        Me.cmb_tipo_doc.TabIndex = 75
        Me.cmb_tipo_doc.validable = True
        '
        'cmb_id_estado_club
        '
        Me.cmb_id_estado_club.FormattingEnabled = True
        Me.cmb_id_estado_club.Location = New System.Drawing.Point(139, 224)
        Me.cmb_id_estado_club.Name = "cmb_id_estado_club"
        Me.cmb_id_estado_club.nombre_campo = "id_estado_club"
        Me.cmb_id_estado_club.nombre_tabla = "ClubFutbol"
        Me.cmb_id_estado_club.Size = New System.Drawing.Size(100, 21)
        Me.cmb_id_estado_club.TabIndex = 74
        Me.cmb_id_estado_club.validable = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(109, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Rol:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Fecha Nac :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(221, 303)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 71
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnActualizar.Location = New System.Drawing.Point(119, 303)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 70
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Location = New System.Drawing.Point(139, 198)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.nombre_campo = "nro_calle"
        Me.txt_nro_calle.nombre_tabla = "ClubFutbol"
        Me.txt_nro_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_calle.TabIndex = 69
        Me.txt_nro_calle.validable = True
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(139, 172)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.nombre_campo = "calle"
        Me.txt_calle.nombre_tabla = "ClubFutbol"
        Me.txt_calle.Size = New System.Drawing.Size(191, 20)
        Me.txt_calle.TabIndex = 68
        Me.txt_calle.validable = True
        '
        'txt_nro_cuil
        '
        Me.txt_nro_cuil.Location = New System.Drawing.Point(139, 146)
        Me.txt_nro_cuil.Name = "txt_nro_cuil"
        Me.txt_nro_cuil.nombre_campo = "nro_cuil"
        Me.txt_nro_cuil.nombre_tabla = "ClubFutbol"
        Me.txt_nro_cuil.Size = New System.Drawing.Size(191, 20)
        Me.txt_nro_cuil.TabIndex = 67
        Me.txt_nro_cuil.validable = True
        '
        'txt_nombre_club
        '
        Me.txt_nombre_club.Location = New System.Drawing.Point(139, 115)
        Me.txt_nombre_club.Name = "txt_nombre_club"
        Me.txt_nombre_club.nombre_campo = "nombre_club"
        Me.txt_nombre_club.nombre_tabla = "ClubFutbol"
        Me.txt_nombre_club.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre_club.TabIndex = 66
        Me.txt_nombre_club.validable = True
        '
        'txt_id_club
        '
        Me.txt_id_club.Location = New System.Drawing.Point(139, 50)
        Me.txt_id_club.Name = "txt_id_club"
        Me.txt_id_club.nombre_campo = "id_club"
        Me.txt_id_club.nombre_tabla = "ClubFutbol"
        Me.txt_id_club.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_club.TabIndex = 65
        Me.txt_id_club.validable = True
        Me.txt_id_club.ValidatingType = GetType(Integer)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Nro Doc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Tipo Doc:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Id:"
        '
        'FormActualizarArbitro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(396, 377)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.cmb_id_estado_club)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.txt_nro_calle)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_nro_cuil)
        Me.Controls.Add(Me.txt_nombre_club)
        Me.Controls.Add(Me.txt_id_club)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormActualizarArbitro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Arbitro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_tipo_doc As ComboBox_01
    Friend WithEvents cmb_id_estado_club As ComboBox_01
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents txt_nro_calle As MaskedTextBox_01
    Friend WithEvents txt_calle As MaskedTextBox_01
    Friend WithEvents txt_nro_cuil As MaskedTextBox_01
    Friend WithEvents txt_nombre_club As MaskedTextBox_01
    Friend WithEvents txt_id_club As MaskedTextBox_01
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
