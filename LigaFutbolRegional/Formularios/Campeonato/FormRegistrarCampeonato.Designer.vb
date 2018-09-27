<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarCampeonato
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_id_estado_campeonato = New LigaFutbolRegional.ComboBox_01()
        Me.txt_puntaje_empate = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_puntaje_victoria = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_fecha_fin = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_fecha_inicio = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_nombre = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_anio = New LigaFutbolRegional.MaskedTextBox_01()
        Me.lbl_limpiar = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Id Estado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Puntaje Empate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Puntaje Victoria :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(211, 299)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 54
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegistrar.Location = New System.Drawing.Point(109, 299)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 53
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Fecha Fin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Fecha Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Año:"
        '
        'cmb_id_estado_campeonato
        '
        Me.cmb_id_estado_campeonato.FormattingEnabled = True
        Me.cmb_id_estado_campeonato.Location = New System.Drawing.Point(129, 250)
        Me.cmb_id_estado_campeonato.Name = "cmb_id_estado_campeonato"
        Me.cmb_id_estado_campeonato.nombre_campo = "id_estado_campeonato"
        Me.cmb_id_estado_campeonato.nombre_tabla = "Campeonato"
        Me.cmb_id_estado_campeonato.Size = New System.Drawing.Size(55, 21)
        Me.cmb_id_estado_campeonato.TabIndex = 58
        Me.cmb_id_estado_campeonato.validable = True
        '
        'txt_puntaje_empate
        '
        Me.txt_puntaje_empate.Location = New System.Drawing.Point(129, 220)
        Me.txt_puntaje_empate.Name = "txt_puntaje_empate"
        Me.txt_puntaje_empate.nombre_campo = "puntaje_empate"
        Me.txt_puntaje_empate.nombre_tabla = "Campeonato"
        Me.txt_puntaje_empate.Size = New System.Drawing.Size(100, 20)
        Me.txt_puntaje_empate.TabIndex = 52
        Me.txt_puntaje_empate.validable = True
        Me.txt_puntaje_empate.ValidatingType = GetType(Integer)
        '
        'txt_puntaje_victoria
        '
        Me.txt_puntaje_victoria.Location = New System.Drawing.Point(129, 194)
        Me.txt_puntaje_victoria.Name = "txt_puntaje_victoria"
        Me.txt_puntaje_victoria.nombre_campo = "puntaje_victoria"
        Me.txt_puntaje_victoria.nombre_tabla = "Campeonato"
        Me.txt_puntaje_victoria.Size = New System.Drawing.Size(100, 20)
        Me.txt_puntaje_victoria.TabIndex = 51
        Me.txt_puntaje_victoria.validable = True
        '
        'txt_fecha_fin
        '
        Me.txt_fecha_fin.Location = New System.Drawing.Point(129, 168)
        Me.txt_fecha_fin.Name = "txt_fecha_fin"
        Me.txt_fecha_fin.nombre_campo = "fecha_fin"
        Me.txt_fecha_fin.nombre_tabla = "Campeonato"
        Me.txt_fecha_fin.Size = New System.Drawing.Size(191, 20)
        Me.txt_fecha_fin.TabIndex = 50
        Me.txt_fecha_fin.validable = True
        '
        'txt_fecha_inicio
        '
        Me.txt_fecha_inicio.Location = New System.Drawing.Point(129, 142)
        Me.txt_fecha_inicio.Name = "txt_fecha_inicio"
        Me.txt_fecha_inicio.nombre_campo = "fecha_inicio"
        Me.txt_fecha_inicio.nombre_tabla = "Campeonato"
        Me.txt_fecha_inicio.Size = New System.Drawing.Size(191, 20)
        Me.txt_fecha_inicio.TabIndex = 49
        Me.txt_fecha_inicio.validable = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(129, 108)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "nombre"
        Me.txt_nombre.nombre_tabla = "Campeonato"
        Me.txt_nombre.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre.TabIndex = 48
        Me.txt_nombre.validable = True
        '
        'txt_anio
        '
        Me.txt_anio.Location = New System.Drawing.Point(129, 76)
        Me.txt_anio.Name = "txt_anio"
        Me.txt_anio.nombre_campo = "anio"
        Me.txt_anio.nombre_tabla = "Campeonato"
        Me.txt_anio.Size = New System.Drawing.Size(100, 20)
        Me.txt_anio.TabIndex = 47
        Me.txt_anio.validable = True
        '
        'lbl_limpiar
        '
        Me.lbl_limpiar.AutoSize = True
        Me.lbl_limpiar.Location = New System.Drawing.Point(277, 76)
        Me.lbl_limpiar.Name = "lbl_limpiar"
        Me.lbl_limpiar.Size = New System.Drawing.Size(80, 13)
        Me.lbl_limpiar.TabIndex = 105
        Me.lbl_limpiar.TabStop = True
        Me.lbl_limpiar.Text = "Limpiar campos"
        '
        'FormRegistrarCampeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(388, 369)
        Me.Controls.Add(Me.lbl_limpiar)
        Me.Controls.Add(Me.cmb_id_estado_campeonato)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.txt_puntaje_empate)
        Me.Controls.Add(Me.txt_puntaje_victoria)
        Me.Controls.Add(Me.txt_fecha_fin)
        Me.Controls.Add(Me.txt_fecha_inicio)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_anio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRegistrarCampeonato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Campeonato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_id_estado_campeonato As ComboBox_01
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents txt_puntaje_empate As MaskedTextBox_01
    Friend WithEvents txt_puntaje_victoria As MaskedTextBox_01
    Friend WithEvents txt_fecha_fin As MaskedTextBox_01
    Friend WithEvents txt_fecha_inicio As MaskedTextBox_01
    Friend WithEvents txt_nombre As MaskedTextBox_01
    Friend WithEvents txt_anio As MaskedTextBox_01
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_limpiar As LinkLabel
End Class
