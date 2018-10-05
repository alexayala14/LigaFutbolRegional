<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JugadoresXCampeonato
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
        Me.components = New System.ComponentModel.Container()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.dni2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JugadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New LigaFutbolRegional.DataSet1()
        Me.JugadorTableAdapter = New LigaFutbolRegional.DataSet1TableAdapters.JugadorTableAdapter()
        Me.contador = New System.Windows.Forms.Label()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_camiseta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.posicion_designada = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ComboBox_011 = New LigaFutbolRegional.ComboBox_01()
        Me.cmb_campeonato = New LigaFutbolRegional.ComboBox_01()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_año = New LigaFutbolRegional.ComboBox_01()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.nombre, Me.nro_camiseta, Me.posicion_designada})
        Me.DGV1.Location = New System.Drawing.Point(12, 107)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(407, 235)
        Me.DGV1.TabIndex = 5
        '
        'DGV2
        '
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni2, Me.nombre2})
        Me.DGV2.Location = New System.Drawing.Point(444, 107)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(243, 235)
        Me.DGV2.TabIndex = 6
        '
        'dni2
        '
        Me.dni2.HeaderText = "DNI"
        Me.dni2.Name = "dni2"
        Me.dni2.ReadOnly = True
        '
        'nombre2
        '
        Me.nombre2.HeaderText = "Nombre"
        Me.nombre2.Name = "nombre2"
        Me.nombre2.ReadOnly = True
        '
        'JugadorBindingSource
        '
        Me.JugadorBindingSource.DataMember = "Jugador"
        Me.JugadorBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JugadorTableAdapter
        '
        Me.JugadorTableAdapter.ClearBeforeFill = True
        '
        'contador
        '
        Me.contador.AutoSize = True
        Me.contador.Location = New System.Drawing.Point(92, 360)
        Me.contador.Name = "contador"
        Me.contador.Size = New System.Drawing.Size(55, 13)
        Me.contador.TabIndex = 7
        Me.contador.Text = "Cantidad: "
        '
        'lbl_count
        '
        Me.lbl_count.AutoSize = True
        Me.lbl_count.Location = New System.Drawing.Point(154, 360)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(13, 13)
        Me.lbl_count.TabIndex = 8
        Me.lbl_count.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Club"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(511, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Jugadores Disponibles"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Jugadores Agregados"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(526, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(233, 409)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dni
        '
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'nro_camiseta
        '
        Me.nro_camiseta.HeaderText = "Nro Camiseta"
        Me.nro_camiseta.Name = "nro_camiseta"
        '
        'posicion_designada
        '
        Me.posicion_designada.HeaderText = "Posicion"
        Me.posicion_designada.Name = "posicion_designada"
        Me.posicion_designada.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.posicion_designada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ComboBox_011
        '
        Me.ComboBox_011.FormattingEnabled = True
        Me.ComboBox_011.Location = New System.Drawing.Point(310, 13)
        Me.ComboBox_011.Name = "ComboBox_011"
        Me.ComboBox_011.nombre_campo = Nothing
        Me.ComboBox_011.nombre_tabla = Nothing
        Me.ComboBox_011.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_011.TabIndex = 9
        Me.ComboBox_011.validable = False
        '
        'cmb_campeonato
        '
        Me.cmb_campeonato.FormattingEnabled = True
        Me.cmb_campeonato.Location = New System.Drawing.Point(108, 12)
        Me.cmb_campeonato.Name = "cmb_campeonato"
        Me.cmb_campeonato.nombre_campo = "id_campeonato"
        Me.cmb_campeonato.nombre_tabla = "Inscripcion"
        Me.cmb_campeonato.Size = New System.Drawing.Size(100, 21)
        Me.cmb_campeonato.TabIndex = 139
        Me.cmb_campeonato.validable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Campeonato:"
        '
        'cmb_año
        '
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Location = New System.Drawing.Point(108, 42)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.nombre_campo = "anio_campeonato"
        Me.cmb_año.nombre_tabla = "Inscripcion"
        Me.cmb_año.Size = New System.Drawing.Size(100, 21)
        Me.cmb_año.TabIndex = 137
        Me.cmb_año.validable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Año:"
        '
        'JugadoresXCampeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(704, 462)
        Me.Controls.Add(Me.cmb_campeonato)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_año)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_011)
        Me.Controls.Add(Me.lbl_count)
        Me.Controls.Add(Me.contador)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.DGV1)
        Me.Name = "JugadoresXCampeonato"
        Me.Text = "JugadoresXCampeonato"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents JugadorBindingSource As BindingSource
    Friend WithEvents JugadorTableAdapter As DataSet1TableAdapters.JugadorTableAdapter
    Friend WithEvents dni2 As DataGridViewTextBoxColumn
    Friend WithEvents nombre2 As DataGridViewTextBoxColumn
    Friend WithEvents contador As Label
    Friend WithEvents lbl_count As Label
    Friend WithEvents ComboBox_011 As ComboBox_01
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents nro_camiseta As DataGridViewTextBoxColumn
    Friend WithEvents posicion_designada As DataGridViewComboBoxColumn
    Friend WithEvents cmb_campeonato As ComboBox_01
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_año As ComboBox_01
    Friend WithEvents Label5 As Label
End Class
