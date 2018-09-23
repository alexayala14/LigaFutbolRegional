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
        Me.ComboBox_012 = New LigaFutbolRegional.ComboBox_01()
        Me.ComboBox_011 = New LigaFutbolRegional.ComboBox_01()
        Me.MaskedTextBox_015 = New LigaFutbolRegional.MaskedTextBox_01()
        Me.MaskedTextBox_014 = New LigaFutbolRegional.MaskedTextBox_01()
        Me.MaskedTextBox_013 = New LigaFutbolRegional.MaskedTextBox_01()
        Me.MaskedTextBox_012 = New LigaFutbolRegional.MaskedTextBox_01()
        Me.MaskedTextBox_011 = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_id_estado_club = New LigaFutbolRegional.ComboBox_01()
        Me.txt_siglas = New LigaFutbolRegional.MaskedTextBox_01()
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
        'ComboBox_012
        '
        Me.ComboBox_012.FormattingEnabled = True
        Me.ComboBox_012.Location = New System.Drawing.Point(151, 263)
        Me.ComboBox_012.Name = "ComboBox_012"
        Me.ComboBox_012.nombre_campo = "id_estado_club"
        Me.ComboBox_012.nombre_tabla = "ClubFutbol"
        Me.ComboBox_012.Size = New System.Drawing.Size(73, 21)
        Me.ComboBox_012.TabIndex = 102
        Me.ComboBox_012.validable = True
        '
        'ComboBox_011
        '
        Me.ComboBox_011.FormattingEnabled = True
        Me.ComboBox_011.Location = New System.Drawing.Point(151, 233)
        Me.ComboBox_011.Name = "ComboBox_011"
        Me.ComboBox_011.nombre_campo = "id_estado_club"
        Me.ComboBox_011.nombre_tabla = "ClubFutbol"
        Me.ComboBox_011.Size = New System.Drawing.Size(73, 21)
        Me.ComboBox_011.TabIndex = 101
        Me.ComboBox_011.validable = True
        '
        'MaskedTextBox_015
        '
        Me.MaskedTextBox_015.Location = New System.Drawing.Point(151, 207)
        Me.MaskedTextBox_015.Name = "MaskedTextBox_015"
        Me.MaskedTextBox_015.nombre_campo = "siglas"
        Me.MaskedTextBox_015.nombre_tabla = "ClubFutbol"
        Me.MaskedTextBox_015.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox_015.TabIndex = 100
        Me.MaskedTextBox_015.validable = True
        '
        'MaskedTextBox_014
        '
        Me.MaskedTextBox_014.Location = New System.Drawing.Point(151, 181)
        Me.MaskedTextBox_014.Name = "MaskedTextBox_014"
        Me.MaskedTextBox_014.nombre_campo = "siglas"
        Me.MaskedTextBox_014.nombre_tabla = "ClubFutbol"
        Me.MaskedTextBox_014.Size = New System.Drawing.Size(191, 20)
        Me.MaskedTextBox_014.TabIndex = 99
        Me.MaskedTextBox_014.validable = True
        '
        'MaskedTextBox_013
        '
        Me.MaskedTextBox_013.Location = New System.Drawing.Point(151, 147)
        Me.MaskedTextBox_013.Name = "MaskedTextBox_013"
        Me.MaskedTextBox_013.nombre_campo = "siglas"
        Me.MaskedTextBox_013.nombre_tabla = "ClubFutbol"
        Me.MaskedTextBox_013.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox_013.TabIndex = 98
        Me.MaskedTextBox_013.validable = True
        '
        'MaskedTextBox_012
        '
        Me.MaskedTextBox_012.Location = New System.Drawing.Point(151, 112)
        Me.MaskedTextBox_012.Name = "MaskedTextBox_012"
        Me.MaskedTextBox_012.nombre_campo = "siglas"
        Me.MaskedTextBox_012.nombre_tabla = "ClubFutbol"
        Me.MaskedTextBox_012.Size = New System.Drawing.Size(191, 20)
        Me.MaskedTextBox_012.TabIndex = 97
        Me.MaskedTextBox_012.validable = True
        '
        'MaskedTextBox_011
        '
        Me.MaskedTextBox_011.Location = New System.Drawing.Point(151, 78)
        Me.MaskedTextBox_011.Name = "MaskedTextBox_011"
        Me.MaskedTextBox_011.nombre_campo = "siglas"
        Me.MaskedTextBox_011.nombre_tabla = "ClubFutbol"
        Me.MaskedTextBox_011.Size = New System.Drawing.Size(191, 20)
        Me.MaskedTextBox_011.TabIndex = 96
        Me.MaskedTextBox_011.validable = True
        '
        'cmb_id_estado_club
        '
        Me.cmb_id_estado_club.FormattingEnabled = True
        Me.cmb_id_estado_club.Location = New System.Drawing.Point(151, 16)
        Me.cmb_id_estado_club.Name = "cmb_id_estado_club"
        Me.cmb_id_estado_club.nombre_campo = "id_estado_club"
        Me.cmb_id_estado_club.nombre_tabla = "ClubFutbol"
        Me.cmb_id_estado_club.Size = New System.Drawing.Size(73, 21)
        Me.cmb_id_estado_club.TabIndex = 95
        Me.cmb_id_estado_club.validable = True
        '
        'txt_siglas
        '
        Me.txt_siglas.Location = New System.Drawing.Point(151, 46)
        Me.txt_siglas.Name = "txt_siglas"
        Me.txt_siglas.nombre_campo = "siglas"
        Me.txt_siglas.nombre_tabla = "ClubFutbol"
        Me.txt_siglas.Size = New System.Drawing.Size(100, 20)
        Me.txt_siglas.TabIndex = 94
        Me.txt_siglas.validable = True
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
        Me.Controls.Add(Me.ComboBox_012)
        Me.Controls.Add(Me.ComboBox_011)
        Me.Controls.Add(Me.MaskedTextBox_015)
        Me.Controls.Add(Me.MaskedTextBox_014)
        Me.Controls.Add(Me.MaskedTextBox_013)
        Me.Controls.Add(Me.MaskedTextBox_012)
        Me.Controls.Add(Me.MaskedTextBox_011)
        Me.Controls.Add(Me.cmb_id_estado_club)
        Me.Controls.Add(Me.txt_siglas)
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
    Friend WithEvents ComboBox_012 As ComboBox_01
    Friend WithEvents ComboBox_011 As ComboBox_01
    Friend WithEvents MaskedTextBox_015 As MaskedTextBox_01
    Friend WithEvents MaskedTextBox_014 As MaskedTextBox_01
    Friend WithEvents MaskedTextBox_013 As MaskedTextBox_01
    Friend WithEvents MaskedTextBox_012 As MaskedTextBox_01
    Friend WithEvents MaskedTextBox_011 As MaskedTextBox_01
    Friend WithEvents cmb_id_estado_club As ComboBox_01
    Friend WithEvents txt_siglas As MaskedTextBox_01
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
