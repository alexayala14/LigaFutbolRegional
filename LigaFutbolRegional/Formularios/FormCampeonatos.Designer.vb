<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCampeonatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCampeonatos))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdCampeonatosRegistrar = New System.Windows.Forms.Button()
        Me.cmdCampeonatosEliminar = New System.Windows.Forms.Button()
        Me.cmdCampeonatosConsulta = New System.Windows.Forms.Button()
        Me.cmdCampeonatosModificar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CampeonatosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampeonatosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cmdCampeonatosRegistrar)
        Me.Panel2.Controls.Add(Me.cmdCampeonatosEliminar)
        Me.Panel2.Controls.Add(Me.cmdCampeonatosConsulta)
        Me.Panel2.Controls.Add(Me.cmdCampeonatosModificar)
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 411)
        Me.Panel2.TabIndex = 9
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
        'cmdCampeonatosRegistrar
        '
        Me.cmdCampeonatosRegistrar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdCampeonatosRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdCampeonatosRegistrar.Location = New System.Drawing.Point(3, 150)
        Me.cmdCampeonatosRegistrar.Name = "cmdCampeonatosRegistrar"
        Me.cmdCampeonatosRegistrar.Size = New System.Drawing.Size(132, 32)
        Me.cmdCampeonatosRegistrar.TabIndex = 3
        Me.cmdCampeonatosRegistrar.Text = "Registrar"
        Me.cmdCampeonatosRegistrar.UseVisualStyleBackColor = False
        '
        'cmdCampeonatosEliminar
        '
        Me.cmdCampeonatosEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdCampeonatosEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdCampeonatosEliminar.Location = New System.Drawing.Point(3, 226)
        Me.cmdCampeonatosEliminar.Name = "cmdCampeonatosEliminar"
        Me.cmdCampeonatosEliminar.Size = New System.Drawing.Size(132, 32)
        Me.cmdCampeonatosEliminar.TabIndex = 5
        Me.cmdCampeonatosEliminar.Text = "Eliminar"
        Me.cmdCampeonatosEliminar.UseVisualStyleBackColor = False
        '
        'cmdCampeonatosConsulta
        '
        Me.cmdCampeonatosConsulta.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdCampeonatosConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdCampeonatosConsulta.Location = New System.Drawing.Point(3, 112)
        Me.cmdCampeonatosConsulta.Name = "cmdCampeonatosConsulta"
        Me.cmdCampeonatosConsulta.Size = New System.Drawing.Size(132, 32)
        Me.cmdCampeonatosConsulta.TabIndex = 2
        Me.cmdCampeonatosConsulta.Text = "Consultar"
        Me.cmdCampeonatosConsulta.UseVisualStyleBackColor = False
        '
        'cmdCampeonatosModificar
        '
        Me.cmdCampeonatosModificar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdCampeonatosModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdCampeonatosModificar.Location = New System.Drawing.Point(3, 188)
        Me.cmdCampeonatosModificar.Name = "cmdCampeonatosModificar"
        Me.cmdCampeonatosModificar.Size = New System.Drawing.Size(132, 32)
        Me.cmdCampeonatosModificar.TabIndex = 4
        Me.cmdCampeonatosModificar.Text = "Modificar"
        Me.cmdCampeonatosModificar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 100)
        Me.Panel1.TabIndex = 8
        '
        'CampeonatosDataGridView
        '
        Me.CampeonatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CampeonatosDataGridView.Location = New System.Drawing.Point(144, 98)
        Me.CampeonatosDataGridView.Name = "CampeonatosDataGridView"
        Me.CampeonatosDataGridView.Size = New System.Drawing.Size(842, 315)
        Me.CampeonatosDataGridView.TabIndex = 10
        '
        'FormCampeonatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 415)
        Me.Controls.Add(Me.CampeonatosDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCampeonatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campeonatos"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampeonatosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdCampeonatosRegistrar As Button
    Friend WithEvents cmdCampeonatosEliminar As Button
    Friend WithEvents cmdCampeonatosConsulta As Button
    Friend WithEvents cmdCampeonatosModificar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CampeonatosDataGridView As DataGridView
End Class
