<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJugadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJugadores))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdJugadorRegistrar = New System.Windows.Forms.Button()
        Me.cmdJugadorEliminar = New System.Windows.Forms.Button()
        Me.cmdJugadorConsulta = New System.Windows.Forms.Button()
        Me.cmdJugadorModificar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cmdJugadorRegistrar)
        Me.Panel2.Controls.Add(Me.cmdJugadorEliminar)
        Me.Panel2.Controls.Add(Me.cmdJugadorConsulta)
        Me.Panel2.Controls.Add(Me.cmdJugadorModificar)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(151, 423)
        Me.Panel2.TabIndex = 8
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
        'cmdJugadorRegistrar
        '
        Me.cmdJugadorRegistrar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdJugadorRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdJugadorRegistrar.Location = New System.Drawing.Point(9, 152)
        Me.cmdJugadorRegistrar.Name = "cmdJugadorRegistrar"
        Me.cmdJugadorRegistrar.Size = New System.Drawing.Size(132, 32)
        Me.cmdJugadorRegistrar.TabIndex = 3
        Me.cmdJugadorRegistrar.Text = "Registrar"
        Me.cmdJugadorRegistrar.UseVisualStyleBackColor = False
        '
        'cmdJugadorEliminar
        '
        Me.cmdJugadorEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdJugadorEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdJugadorEliminar.Location = New System.Drawing.Point(9, 228)
        Me.cmdJugadorEliminar.Name = "cmdJugadorEliminar"
        Me.cmdJugadorEliminar.Size = New System.Drawing.Size(132, 32)
        Me.cmdJugadorEliminar.TabIndex = 5
        Me.cmdJugadorEliminar.Text = "Eliminar"
        Me.cmdJugadorEliminar.UseVisualStyleBackColor = False
        '
        'cmdJugadorConsulta
        '
        Me.cmdJugadorConsulta.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdJugadorConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdJugadorConsulta.Location = New System.Drawing.Point(9, 114)
        Me.cmdJugadorConsulta.Name = "cmdJugadorConsulta"
        Me.cmdJugadorConsulta.Size = New System.Drawing.Size(132, 32)
        Me.cmdJugadorConsulta.TabIndex = 2
        Me.cmdJugadorConsulta.Text = "Consultar"
        Me.cmdJugadorConsulta.UseVisualStyleBackColor = False
        '
        'cmdJugadorModificar
        '
        Me.cmdJugadorModificar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdJugadorModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdJugadorModificar.Location = New System.Drawing.Point(9, 190)
        Me.cmdJugadorModificar.Name = "cmdJugadorModificar"
        Me.cmdJugadorModificar.Size = New System.Drawing.Size(132, 32)
        Me.cmdJugadorModificar.TabIndex = 4
        Me.cmdJugadorModificar.Text = "Modificar"
        Me.cmdJugadorModificar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 109)
        Me.Panel1.TabIndex = 7
        '
        'FormJugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 425)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormJugadores"
        Me.Text = "Jugadores"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdJugadorRegistrar As Button
    Friend WithEvents cmdJugadorEliminar As Button
    Friend WithEvents cmdJugadorConsulta As Button
    Friend WithEvents cmdJugadorModificar As Button
    Friend WithEvents Panel1 As Panel
End Class
