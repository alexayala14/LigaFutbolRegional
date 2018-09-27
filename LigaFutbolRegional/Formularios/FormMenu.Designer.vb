<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.cmdFP = New System.Windows.Forms.Button()
        Me.cmdRE = New System.Windows.Forms.Button()
        Me.cmdArbitro = New System.Windows.Forms.Button()
        Me.cmdJugador = New System.Windows.Forms.Button()
        Me.cmdClub = New System.Windows.Forms.Button()
        Me.cmdCampeonatos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCampeonatos = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel_Reportes = New System.Windows.Forms.Panel()
        Me.btn_estadisticas = New System.Windows.Forms.Button()
        Me.btn_reportes = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCampeonatos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Reportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelMenu.Controls.Add(Me.cmdFP)
        Me.PanelMenu.Controls.Add(Me.cmdRE)
        Me.PanelMenu.Controls.Add(Me.cmdArbitro)
        Me.PanelMenu.Controls.Add(Me.cmdJugador)
        Me.PanelMenu.Controls.Add(Me.cmdClub)
        Me.PanelMenu.Controls.Add(Me.cmdCampeonatos)
        Me.PanelMenu.Location = New System.Drawing.Point(2, 106)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(141, 384)
        Me.PanelMenu.TabIndex = 0
        '
        'cmdFP
        '
        Me.cmdFP.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdFP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdFP.Location = New System.Drawing.Point(3, 155)
        Me.cmdFP.Name = "cmdFP"
        Me.cmdFP.Size = New System.Drawing.Size(132, 32)
        Me.cmdFP.TabIndex = 5
        Me.cmdFP.Text = "Fechas y Partidos"
        Me.cmdFP.UseVisualStyleBackColor = False
        '
        'cmdRE
        '
        Me.cmdRE.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdRE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdRE.Location = New System.Drawing.Point(3, 193)
        Me.cmdRE.Name = "cmdRE"
        Me.cmdRE.Size = New System.Drawing.Size(132, 32)
        Me.cmdRE.TabIndex = 4
        Me.cmdRE.Text = "Reportes y Estadisticas"
        Me.cmdRE.UseVisualStyleBackColor = False
        '
        'cmdArbitro
        '
        Me.cmdArbitro.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdArbitro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdArbitro.Location = New System.Drawing.Point(3, 117)
        Me.cmdArbitro.Name = "cmdArbitro"
        Me.cmdArbitro.Size = New System.Drawing.Size(132, 32)
        Me.cmdArbitro.TabIndex = 3
        Me.cmdArbitro.Text = "Arbitros"
        Me.cmdArbitro.UseVisualStyleBackColor = False
        '
        'cmdJugador
        '
        Me.cmdJugador.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdJugador.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdJugador.Location = New System.Drawing.Point(3, 79)
        Me.cmdJugador.Name = "cmdJugador"
        Me.cmdJugador.Size = New System.Drawing.Size(132, 32)
        Me.cmdJugador.TabIndex = 2
        Me.cmdJugador.Text = "Jugadores"
        Me.cmdJugador.UseVisualStyleBackColor = False
        '
        'cmdClub
        '
        Me.cmdClub.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdClub.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdClub.Location = New System.Drawing.Point(3, 41)
        Me.cmdClub.Name = "cmdClub"
        Me.cmdClub.Size = New System.Drawing.Size(132, 32)
        Me.cmdClub.TabIndex = 1
        Me.cmdClub.Text = "Clubes"
        Me.cmdClub.UseVisualStyleBackColor = False
        '
        'cmdCampeonatos
        '
        Me.cmdCampeonatos.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdCampeonatos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdCampeonatos.Location = New System.Drawing.Point(3, 3)
        Me.cmdCampeonatos.Name = "cmdCampeonatos"
        Me.cmdCampeonatos.Size = New System.Drawing.Size(132, 32)
        Me.cmdCampeonatos.TabIndex = 0
        Me.cmdCampeonatos.Text = "Campeonatos"
        Me.cmdCampeonatos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 98)
        Me.Panel1.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(714, 45)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cerrar Sesion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 45.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 77)
        Me.Label1.TabIndex = 0
        '
        'PanelCampeonatos
        '
        Me.PanelCampeonatos.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelCampeonatos.Controls.Add(Me.Button4)
        Me.PanelCampeonatos.Controls.Add(Me.Button3)
        Me.PanelCampeonatos.Controls.Add(Me.Button2)
        Me.PanelCampeonatos.Location = New System.Drawing.Point(149, 147)
        Me.PanelCampeonatos.Name = "PanelCampeonatos"
        Me.PanelCampeonatos.Size = New System.Drawing.Size(138, 108)
        Me.PanelCampeonatos.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(3, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Diagramacion"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(3, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Inscripcion"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Administrar "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(342, 205)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 157)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'panel_Reportes
        '
        Me.panel_Reportes.BackColor = System.Drawing.Color.DarkCyan
        Me.panel_Reportes.Controls.Add(Me.btn_estadisticas)
        Me.panel_Reportes.Controls.Add(Me.btn_reportes)
        Me.panel_Reportes.Location = New System.Drawing.Point(149, 333)
        Me.panel_Reportes.Name = "panel_Reportes"
        Me.panel_Reportes.Size = New System.Drawing.Size(138, 85)
        Me.panel_Reportes.TabIndex = 4
        '
        'btn_estadisticas
        '
        Me.btn_estadisticas.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_estadisticas.FlatAppearance.BorderSize = 0
        Me.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estadisticas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_estadisticas.Location = New System.Drawing.Point(3, 38)
        Me.btn_estadisticas.Name = "btn_estadisticas"
        Me.btn_estadisticas.Size = New System.Drawing.Size(132, 32)
        Me.btn_estadisticas.TabIndex = 2
        Me.btn_estadisticas.Text = "Estadisticas"
        Me.btn_estadisticas.UseVisualStyleBackColor = False
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_reportes.FlatAppearance.BorderSize = 0
        Me.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reportes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_reportes.Location = New System.Drawing.Point(3, 3)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(132, 32)
        Me.btn_reportes.TabIndex = 1
        Me.btn_reportes.Text = "Reportes"
        Me.btn_reportes.UseVisualStyleBackColor = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 490)
        Me.Controls.Add(Me.panel_Reportes)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PanelCampeonatos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liga de Futbol Regional"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCampeonatos.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Reportes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdCampeonatos As Button
    Friend WithEvents cmdArbitro As Button
    Friend WithEvents cmdJugador As Button
    Friend WithEvents cmdClub As Button
    Friend WithEvents cmdRE As Button
    Friend WithEvents cmdFP As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PanelCampeonatos As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panel_Reportes As Panel
    Friend WithEvents btn_estadisticas As Button
    Friend WithEvents btn_reportes As Button
End Class
