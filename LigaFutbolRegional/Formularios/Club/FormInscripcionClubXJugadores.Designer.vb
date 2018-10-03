<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInscripcionClubXJugadores
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
        Me.cmb_local = New LigaFutbolRegional.ComboBox_01()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc = New LigaFutbolRegional.ComboBox_01()
        Me.txt_dni = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fecha = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_fechaFin = New System.Windows.Forms.Label()
        Me.MaskedTextBox_011 = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaskedTextBox_012 = New LigaFutbolRegional.MaskedTextBox_01()
        Me.ComboBox_011 = New LigaFutbolRegional.ComboBox_01()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_local
        '
        Me.cmb_local.FormattingEnabled = True
        Me.cmb_local.Location = New System.Drawing.Point(107, 37)
        Me.cmb_local.Name = "cmb_local"
        Me.cmb_local.nombre_campo = "id_club_local"
        Me.cmb_local.nombre_tabla = "Partido"
        Me.cmb_local.Size = New System.Drawing.Size(100, 21)
        Me.cmb_local.TabIndex = 81
        Me.cmb_local.validable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Club:"
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(107, 70)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.nombre_campo = "tipo_doc"
        Me.cmb_tipo_doc.nombre_tabla = "Jugador"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(73, 21)
        Me.cmb_tipo_doc.TabIndex = 99
        Me.cmb_tipo_doc.validable = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(107, 100)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.nombre_campo = "dni"
        Me.txt_dni.nombre_tabla = "Jugador"
        Me.txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_dni.TabIndex = 98
        Me.txt_dni.validable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "N° Documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Tipo Documento:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(107, 135)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.nombre_campo = "dni"
        Me.txt_fecha.nombre_tabla = "Jugador"
        Me.txt_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha.TabIndex = 100
        Me.txt_fecha.validable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Fecha Inicio:"
        '
        'txt_fechaFin
        '
        Me.txt_fechaFin.AutoSize = True
        Me.txt_fechaFin.Location = New System.Drawing.Point(21, 171)
        Me.txt_fechaFin.Name = "txt_fechaFin"
        Me.txt_fechaFin.Size = New System.Drawing.Size(57, 13)
        Me.txt_fechaFin.TabIndex = 103
        Me.txt_fechaFin.Text = "Fecha Fin:"
        '
        'MaskedTextBox_011
        '
        Me.MaskedTextBox_011.Location = New System.Drawing.Point(107, 171)
        Me.MaskedTextBox_011.Name = "MaskedTextBox_011"
        Me.MaskedTextBox_011.nombre_campo = "dni"
        Me.MaskedTextBox_011.nombre_tabla = "Jugador"
        Me.MaskedTextBox_011.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox_011.TabIndex = 102
        Me.MaskedTextBox_011.validable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Examen Medico:"
        '
        'MaskedTextBox_012
        '
        Me.MaskedTextBox_012.Location = New System.Drawing.Point(107, 206)
        Me.MaskedTextBox_012.Name = "MaskedTextBox_012"
        Me.MaskedTextBox_012.nombre_campo = "dni"
        Me.MaskedTextBox_012.nombre_tabla = "Jugador"
        Me.MaskedTextBox_012.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox_012.TabIndex = 104
        Me.MaskedTextBox_012.validable = True
        '
        'ComboBox_011
        '
        Me.ComboBox_011.FormattingEnabled = True
        Me.ComboBox_011.Location = New System.Drawing.Point(107, 236)
        Me.ComboBox_011.Name = "ComboBox_011"
        Me.ComboBox_011.nombre_campo = "id_club_local"
        Me.ComboBox_011.nombre_tabla = "Partido"
        Me.ComboBox_011.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_011.TabIndex = 107
        Me.ComboBox_011.validable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Estado:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(82, 295)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 184)
        Me.DataGridView1.TabIndex = 108
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNuevo.Location = New System.Drawing.Point(370, 40)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 110
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBuscar.Location = New System.Drawing.Point(266, 40)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 109
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBaja.Location = New System.Drawing.Point(370, 93)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnBaja.TabIndex = 112
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlta.Location = New System.Drawing.Point(266, 93)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 111
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'FormInscripcionClubXJugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(511, 491)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox_011)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaskedTextBox_012)
        Me.Controls.Add(Me.txt_fechaFin)
        Me.Controls.Add(Me.MaskedTextBox_011)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_local)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInscripcionClubXJugadores"
        Me.Text = "Inscripcion  de Jugadores al Club"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_local As ComboBox_01
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tipo_doc As ComboBox_01
    Friend WithEvents txt_dni As MaskedTextBox_01
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_fecha As MaskedTextBox_01
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_fechaFin As Label
    Friend WithEvents MaskedTextBox_011 As MaskedTextBox_01
    Friend WithEvents Label5 As Label
    Friend WithEvents MaskedTextBox_012 As MaskedTextBox_01
    Friend WithEvents ComboBox_011 As ComboBox_01
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
End Class
