<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClubes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClubes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdClubConsulta = New System.Windows.Forms.Button()
        Me.cmdClubRegistrar = New System.Windows.Forms.Button()
        Me.cmdClubModificar = New System.Windows.Forms.Button()
        Me.cmdClubEliminar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClubFutbolDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClubFutbolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CampeonatoPavDataSet1 = New LigaFutbolRegional.CampeonatoPavDataSet1()
        Me.ClubFutbolTableAdapter = New LigaFutbolRegional.CampeonatoPavDataSet1TableAdapters.ClubFutbolTableAdapter()
        Me.TableAdapterManager = New LigaFutbolRegional.CampeonatoPavDataSet1TableAdapters.TableAdapterManager()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubFutbolDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubFutbolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampeonatoPavDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 100)
        Me.Panel1.TabIndex = 0
        '
        'cmdClubConsulta
        '
        Me.cmdClubConsulta.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdClubConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdClubConsulta.Location = New System.Drawing.Point(3, 112)
        Me.cmdClubConsulta.Name = "cmdClubConsulta"
        Me.cmdClubConsulta.Size = New System.Drawing.Size(132, 32)
        Me.cmdClubConsulta.TabIndex = 2
        Me.cmdClubConsulta.Text = "Consultar"
        Me.cmdClubConsulta.UseVisualStyleBackColor = False
        '
        'cmdClubRegistrar
        '
        Me.cmdClubRegistrar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdClubRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdClubRegistrar.Location = New System.Drawing.Point(3, 150)
        Me.cmdClubRegistrar.Name = "cmdClubRegistrar"
        Me.cmdClubRegistrar.Size = New System.Drawing.Size(132, 32)
        Me.cmdClubRegistrar.TabIndex = 3
        Me.cmdClubRegistrar.Text = "Registrar"
        Me.cmdClubRegistrar.UseVisualStyleBackColor = False
        '
        'cmdClubModificar
        '
        Me.cmdClubModificar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdClubModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdClubModificar.Location = New System.Drawing.Point(3, 188)
        Me.cmdClubModificar.Name = "cmdClubModificar"
        Me.cmdClubModificar.Size = New System.Drawing.Size(132, 32)
        Me.cmdClubModificar.TabIndex = 4
        Me.cmdClubModificar.Text = "Modificar"
        Me.cmdClubModificar.UseVisualStyleBackColor = False
        '
        'cmdClubEliminar
        '
        Me.cmdClubEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdClubEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdClubEliminar.Location = New System.Drawing.Point(3, 226)
        Me.cmdClubEliminar.Name = "cmdClubEliminar"
        Me.cmdClubEliminar.Size = New System.Drawing.Size(132, 32)
        Me.cmdClubEliminar.TabIndex = 5
        Me.cmdClubEliminar.Text = "Eliminar"
        Me.cmdClubEliminar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cmdClubRegistrar)
        Me.Panel2.Controls.Add(Me.cmdClubEliminar)
        Me.Panel2.Controls.Add(Me.cmdClubConsulta)
        Me.Panel2.Controls.Add(Me.cmdClubModificar)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 411)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ClubFutbolDataGridView
        '
        Me.ClubFutbolDataGridView.AutoGenerateColumns = False
        Me.ClubFutbolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClubFutbolDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ClubFutbolDataGridView.DataSource = Me.ClubFutbolBindingSource
        Me.ClubFutbolDataGridView.Location = New System.Drawing.Point(141, 96)
        Me.ClubFutbolDataGridView.Name = "ClubFutbolDataGridView"
        Me.ClubFutbolDataGridView.Size = New System.Drawing.Size(842, 316)
        Me.ClubFutbolDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_club"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_club"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "siglas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "siglas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre_club"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre_club"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nro_cuil"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nro_cuil"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "calle"
        Me.DataGridViewTextBoxColumn5.HeaderText = "calle"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nro_calle"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nro_calle"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cod_postal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cod_postal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_estado_club"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_estado_club"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ClubFutbolBindingSource
        '
        Me.ClubFutbolBindingSource.DataMember = "ClubFutbol"
        Me.ClubFutbolBindingSource.DataSource = Me.CampeonatoPavDataSet1
        '
        'CampeonatoPavDataSet1
        '
        Me.CampeonatoPavDataSet1.DataSetName = "CampeonatoPavDataSet1"
        Me.CampeonatoPavDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClubFutbolTableAdapter
        '
        Me.ClubFutbolTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClubFutbolTableAdapter = Me.ClubFutbolTableAdapter
        Me.TableAdapterManager.UpdateOrder = LigaFutbolRegional.CampeonatoPavDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormClubes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 411)
        Me.Controls.Add(Me.ClubFutbolDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormClubes"
        Me.Text = "Clubes"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubFutbolDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubFutbolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampeonatoPavDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdClubEliminar As Button
    Friend WithEvents cmdClubModificar As Button
    Friend WithEvents cmdClubRegistrar As Button
    Friend WithEvents cmdClubConsulta As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CampeonatoPavDataSet1 As CampeonatoPavDataSet1
    Friend WithEvents ClubFutbolBindingSource As BindingSource
    Friend WithEvents ClubFutbolTableAdapter As CampeonatoPavDataSet1TableAdapters.ClubFutbolTableAdapter
    Friend WithEvents TableAdapterManager As CampeonatoPavDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ClubFutbolDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
