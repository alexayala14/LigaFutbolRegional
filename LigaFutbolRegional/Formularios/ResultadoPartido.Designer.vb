<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultadoPartido
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
        Me.txt_id_club_local = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_id_club_visitante = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_jornada = New LigaFutbolRegional.ComboBox_01()
        Me.txt_anio_campeonato = New LigaFutbolRegional.MaskedTextBox_01()
        Me.cmb_id_campeonato = New LigaFutbolRegional.ComboBox_01()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_goles_visitante = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_goles_local = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_club_visitante = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_club_local = New LigaFutbolRegional.MaskedTextBox_01()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.id_club = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.goles_a_favor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.goles_en_contra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant_rojas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant_amarillas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.faltas_cometidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_cant_rojas = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_id_jugador = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_id_club = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_cant_amarillas = New LigaFutbolRegional.ComboBox_01()
        Me.txt_goles_a_favor = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_goles_en_contra = New LigaFutbolRegional.MaskedTextBox_01()
        Me.txt_faltas = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_tipo_documento = New LigaFutbolRegional.MaskedTextBox_01()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_id_club_local
        '
        Me.txt_id_club_local.Location = New System.Drawing.Point(56, 49)
        Me.txt_id_club_local.Name = "txt_id_club_local"
        Me.txt_id_club_local.nombre_campo = Nothing
        Me.txt_id_club_local.nombre_tabla = Nothing
        Me.txt_id_club_local.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_club_local.TabIndex = 43
        Me.txt_id_club_local.validable = False
        Me.txt_id_club_local.Visible = False
        '
        'txt_id_club_visitante
        '
        Me.txt_id_club_visitante.Location = New System.Drawing.Point(180, 50)
        Me.txt_id_club_visitante.Name = "txt_id_club_visitante"
        Me.txt_id_club_visitante.nombre_campo = Nothing
        Me.txt_id_club_visitante.nombre_tabla = Nothing
        Me.txt_id_club_visitante.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_club_visitante.TabIndex = 42
        Me.txt_id_club_visitante.validable = False
        Me.txt_id_club_visitante.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Jornada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Campeonato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Año"
        '
        'cmb_jornada
        '
        Me.cmb_jornada.FormattingEnabled = True
        Me.cmb_jornada.Location = New System.Drawing.Point(114, 133)
        Me.cmb_jornada.Name = "cmb_jornada"
        Me.cmb_jornada.nombre_campo = Nothing
        Me.cmb_jornada.nombre_tabla = Nothing
        Me.cmb_jornada.Size = New System.Drawing.Size(121, 21)
        Me.cmb_jornada.TabIndex = 37
        Me.cmb_jornada.validable = False
        '
        'txt_anio_campeonato
        '
        Me.txt_anio_campeonato.Enabled = False
        Me.txt_anio_campeonato.Location = New System.Drawing.Point(114, 105)
        Me.txt_anio_campeonato.Name = "txt_anio_campeonato"
        Me.txt_anio_campeonato.nombre_campo = Nothing
        Me.txt_anio_campeonato.nombre_tabla = Nothing
        Me.txt_anio_campeonato.Size = New System.Drawing.Size(100, 20)
        Me.txt_anio_campeonato.TabIndex = 36
        Me.txt_anio_campeonato.validable = False
        '
        'cmb_id_campeonato
        '
        Me.cmb_id_campeonato.FormattingEnabled = True
        Me.cmb_id_campeonato.Location = New System.Drawing.Point(114, 76)
        Me.cmb_id_campeonato.Name = "cmb_id_campeonato"
        Me.cmb_id_campeonato.nombre_campo = Nothing
        Me.cmb_id_campeonato.nombre_tabla = Nothing
        Me.cmb_id_campeonato.Size = New System.Drawing.Size(121, 21)
        Me.cmb_id_campeonato.TabIndex = 35
        Me.cmb_id_campeonato.validable = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(716, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(478, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Goles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Visitante"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Local"
        '
        'txt_goles_visitante
        '
        Me.txt_goles_visitante.Location = New System.Drawing.Point(440, 136)
        Me.txt_goles_visitante.Name = "txt_goles_visitante"
        Me.txt_goles_visitante.nombre_campo = Nothing
        Me.txt_goles_visitante.nombre_tabla = Nothing
        Me.txt_goles_visitante.Size = New System.Drawing.Size(22, 20)
        Me.txt_goles_visitante.TabIndex = 29
        Me.txt_goles_visitante.validable = False
        '
        'txt_goles_local
        '
        Me.txt_goles_local.Location = New System.Drawing.Point(394, 136)
        Me.txt_goles_local.Name = "txt_goles_local"
        Me.txt_goles_local.nombre_campo = Nothing
        Me.txt_goles_local.nombre_tabla = Nothing
        Me.txt_goles_local.Size = New System.Drawing.Size(22, 20)
        Me.txt_goles_local.TabIndex = 28
        Me.txt_goles_local.validable = False
        '
        'txt_club_visitante
        '
        Me.txt_club_visitante.Enabled = False
        Me.txt_club_visitante.Location = New System.Drawing.Point(440, 77)
        Me.txt_club_visitante.Name = "txt_club_visitante"
        Me.txt_club_visitante.nombre_campo = Nothing
        Me.txt_club_visitante.nombre_tabla = Nothing
        Me.txt_club_visitante.Size = New System.Drawing.Size(100, 20)
        Me.txt_club_visitante.TabIndex = 26
        Me.txt_club_visitante.validable = False
        '
        'txt_club_local
        '
        Me.txt_club_local.Enabled = False
        Me.txt_club_local.Location = New System.Drawing.Point(316, 78)
        Me.txt_club_local.Name = "txt_club_local"
        Me.txt_club_local.nombre_campo = Nothing
        Me.txt_club_local.nombre_tabla = Nothing
        Me.txt_club_local.Size = New System.Drawing.Size(100, 20)
        Me.txt_club_local.TabIndex = 25
        Me.txt_club_local.validable = False
        '
        'DGV1
        '
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(34, 256)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(268, 167)
        Me.DGV1.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(395, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "RESULTADOS"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(422, 227)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 23)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Agregar Detalle"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_club, Me.tipo_doc, Me.dni, Me.goles_a_favor, Me.goles_en_contra, Me.cant_rojas, Me.cant_amarillas, Me.faltas_cometidas})
        Me.DGV2.Location = New System.Drawing.Point(345, 256)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(446, 167)
        Me.DGV2.TabIndex = 47
        '
        'id_club
        '
        Me.id_club.HeaderText = "Club"
        Me.id_club.Name = "id_club"
        Me.id_club.ReadOnly = True
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        '
        'dni
        '
        Me.dni.HeaderText = "Nro Doc"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'goles_a_favor
        '
        Me.goles_a_favor.HeaderText = "Goles AF"
        Me.goles_a_favor.Name = "goles_a_favor"
        Me.goles_a_favor.ReadOnly = True
        '
        'goles_en_contra
        '
        Me.goles_en_contra.HeaderText = "Goles EC"
        Me.goles_en_contra.Name = "goles_en_contra"
        Me.goles_en_contra.ReadOnly = True
        '
        'cant_rojas
        '
        Me.cant_rojas.HeaderText = "Cant Rojas"
        Me.cant_rojas.Name = "cant_rojas"
        Me.cant_rojas.ReadOnly = True
        '
        'cant_amarillas
        '
        Me.cant_amarillas.HeaderText = "Cant Amarillas"
        Me.cant_amarillas.Name = "cant_amarillas"
        Me.cant_amarillas.ReadOnly = True
        '
        'faltas_cometidas
        '
        Me.faltas_cometidas.HeaderText = "Falas Cometidas"
        Me.faltas_cometidas.Name = "faltas_cometidas"
        Me.faltas_cometidas.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(613, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Jugador"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(588, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Goles a favor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(575, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Goles En contra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(599, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Cant Rojas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(588, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Cant Amarillas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(577, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Faltas Cometidas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(630, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Club"
        '
        'cmb_cant_rojas
        '
        Me.cmb_cant_rojas.FormattingEnabled = True
        Me.cmb_cant_rojas.Items.AddRange(New Object() {"0", "1"})
        Me.cmb_cant_rojas.Location = New System.Drawing.Point(670, 156)
        Me.cmb_cant_rojas.Name = "cmb_cant_rojas"
        Me.cmb_cant_rojas.nombre_campo = Nothing
        Me.cmb_cant_rojas.nombre_tabla = Nothing
        Me.cmb_cant_rojas.Size = New System.Drawing.Size(121, 21)
        Me.cmb_cant_rojas.TabIndex = 55
        Me.cmb_cant_rojas.validable = False
        '
        'cmb_id_jugador
        '
        Me.cmb_id_jugador.FormattingEnabled = True
        Me.cmb_id_jugador.Location = New System.Drawing.Point(670, 77)
        Me.cmb_id_jugador.Name = "cmb_id_jugador"
        Me.cmb_id_jugador.nombre_campo = Nothing
        Me.cmb_id_jugador.nombre_tabla = Nothing
        Me.cmb_id_jugador.Size = New System.Drawing.Size(121, 21)
        Me.cmb_id_jugador.TabIndex = 58
        Me.cmb_id_jugador.validable = False
        '
        'cmb_id_club
        '
        Me.cmb_id_club.FormattingEnabled = True
        Me.cmb_id_club.Location = New System.Drawing.Point(670, 50)
        Me.cmb_id_club.Name = "cmb_id_club"
        Me.cmb_id_club.nombre_campo = Nothing
        Me.cmb_id_club.nombre_tabla = Nothing
        Me.cmb_id_club.Size = New System.Drawing.Size(121, 21)
        Me.cmb_id_club.TabIndex = 59
        Me.cmb_id_club.validable = False
        '
        'cmb_cant_amarillas
        '
        Me.cmb_cant_amarillas.FormattingEnabled = True
        Me.cmb_cant_amarillas.Items.AddRange(New Object() {"0", "1", "2"})
        Me.cmb_cant_amarillas.Location = New System.Drawing.Point(670, 183)
        Me.cmb_cant_amarillas.Name = "cmb_cant_amarillas"
        Me.cmb_cant_amarillas.nombre_campo = Nothing
        Me.cmb_cant_amarillas.nombre_tabla = Nothing
        Me.cmb_cant_amarillas.Size = New System.Drawing.Size(121, 21)
        Me.cmb_cant_amarillas.TabIndex = 60
        Me.cmb_cant_amarillas.validable = False
        '
        'txt_goles_a_favor
        '
        Me.txt_goles_a_favor.Location = New System.Drawing.Point(670, 104)
        Me.txt_goles_a_favor.Name = "txt_goles_a_favor"
        Me.txt_goles_a_favor.nombre_campo = Nothing
        Me.txt_goles_a_favor.nombre_tabla = Nothing
        Me.txt_goles_a_favor.Size = New System.Drawing.Size(100, 20)
        Me.txt_goles_a_favor.TabIndex = 61
        Me.txt_goles_a_favor.validable = False
        '
        'txt_goles_en_contra
        '
        Me.txt_goles_en_contra.Location = New System.Drawing.Point(670, 130)
        Me.txt_goles_en_contra.Name = "txt_goles_en_contra"
        Me.txt_goles_en_contra.nombre_campo = Nothing
        Me.txt_goles_en_contra.nombre_tabla = Nothing
        Me.txt_goles_en_contra.Size = New System.Drawing.Size(100, 20)
        Me.txt_goles_en_contra.TabIndex = 62
        Me.txt_goles_en_contra.validable = False
        '
        'txt_faltas
        '
        Me.txt_faltas.Location = New System.Drawing.Point(670, 210)
        Me.txt_faltas.Name = "txt_faltas"
        Me.txt_faltas.nombre_campo = Nothing
        Me.txt_faltas.nombre_tabla = Nothing
        Me.txt_faltas.Size = New System.Drawing.Size(100, 20)
        Me.txt_faltas.TabIndex = 63
        Me.txt_faltas.validable = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(667, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "DETALLES"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(124, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 13)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "INFO CAMPEONATO"
        '
        'txt_tipo_documento
        '
        Me.txt_tipo_documento.Location = New System.Drawing.Point(549, 15)
        Me.txt_tipo_documento.Name = "txt_tipo_documento"
        Me.txt_tipo_documento.nombre_campo = Nothing
        Me.txt_tipo_documento.nombre_tabla = Nothing
        Me.txt_tipo_documento.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo_documento.TabIndex = 66
        Me.txt_tipo_documento.validable = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(114, 429)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "Ver partidos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ResultadoPartido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(819, 460)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txt_tipo_documento)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_faltas)
        Me.Controls.Add(Me.txt_goles_en_contra)
        Me.Controls.Add(Me.txt_goles_a_favor)
        Me.Controls.Add(Me.cmb_cant_amarillas)
        Me.Controls.Add(Me.cmb_id_club)
        Me.Controls.Add(Me.cmb_id_jugador)
        Me.Controls.Add(Me.cmb_cant_rojas)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_id_club_local)
        Me.Controls.Add(Me.txt_id_club_visitante)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_jornada)
        Me.Controls.Add(Me.txt_anio_campeonato)
        Me.Controls.Add(Me.cmb_id_campeonato)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_goles_visitante)
        Me.Controls.Add(Me.txt_goles_local)
        Me.Controls.Add(Me.txt_club_visitante)
        Me.Controls.Add(Me.txt_club_local)
        Me.Controls.Add(Me.DGV1)
        Me.Name = "ResultadoPartido"
        Me.Text = "ResultadoPartido"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_id_club_local As MaskedTextBox_01
    Friend WithEvents txt_id_club_visitante As MaskedTextBox_01
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_jornada As ComboBox_01
    Friend WithEvents txt_anio_campeonato As MaskedTextBox_01
    Friend WithEvents cmb_id_campeonato As ComboBox_01
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_goles_visitante As MaskedTextBox_01
    Friend WithEvents txt_goles_local As MaskedTextBox_01
    Friend WithEvents txt_club_visitante As MaskedTextBox_01
    Friend WithEvents txt_club_local As MaskedTextBox_01
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_cant_rojas As ComboBox_01
    Friend WithEvents cmb_id_jugador As ComboBox_01
    Friend WithEvents cmb_id_club As ComboBox_01
    Friend WithEvents cmb_cant_amarillas As ComboBox_01
    Friend WithEvents txt_goles_a_favor As MaskedTextBox_01
    Friend WithEvents txt_goles_en_contra As MaskedTextBox_01
    Friend WithEvents txt_faltas As MaskedTextBox_01
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents id_club As DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As DataGridViewTextBoxColumn
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents goles_a_favor As DataGridViewTextBoxColumn
    Friend WithEvents goles_en_contra As DataGridViewTextBoxColumn
    Friend WithEvents cant_rojas As DataGridViewTextBoxColumn
    Friend WithEvents cant_amarillas As DataGridViewTextBoxColumn
    Friend WithEvents faltas_cometidas As DataGridViewTextBoxColumn
    Friend WithEvents txt_tipo_documento As MaskedTextBox_01
    Friend WithEvents Button4 As Button
End Class
