<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArbitros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormArbitros))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdArbitroRegistrar = New System.Windows.Forms.Button()
        Me.cmdArbitroEliminar = New System.Windows.Forms.Button()
        Me.cmdArbitroConsulta = New System.Windows.Forms.Button()
        Me.cmdArbitroModificar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'cmdArbitroRegistrar
        '
        Me.cmdArbitroRegistrar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdArbitroRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdArbitroRegistrar.Location = New System.Drawing.Point(3, 150)
        Me.cmdArbitroRegistrar.Name = "cmdArbitroRegistrar"
        Me.cmdArbitroRegistrar.Size = New System.Drawing.Size(132, 32)
        Me.cmdArbitroRegistrar.TabIndex = 3
        Me.cmdArbitroRegistrar.Text = "Registrar"
        Me.cmdArbitroRegistrar.UseVisualStyleBackColor = False
        '
        'cmdArbitroEliminar
        '
        Me.cmdArbitroEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdArbitroEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdArbitroEliminar.Location = New System.Drawing.Point(3, 226)
        Me.cmdArbitroEliminar.Name = "cmdArbitroEliminar"
        Me.cmdArbitroEliminar.Size = New System.Drawing.Size(132, 32)
        Me.cmdArbitroEliminar.TabIndex = 5
        Me.cmdArbitroEliminar.Text = "Eliminar"
        Me.cmdArbitroEliminar.UseVisualStyleBackColor = False
        '
        'cmdArbitroConsulta
        '
        Me.cmdArbitroConsulta.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdArbitroConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdArbitroConsulta.Location = New System.Drawing.Point(3, 112)
        Me.cmdArbitroConsulta.Name = "cmdArbitroConsulta"
        Me.cmdArbitroConsulta.Size = New System.Drawing.Size(132, 32)
        Me.cmdArbitroConsulta.TabIndex = 2
        Me.cmdArbitroConsulta.Text = "Consultar"
        Me.cmdArbitroConsulta.UseVisualStyleBackColor = False
        '
        'cmdArbitroModificar
        '
        Me.cmdArbitroModificar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdArbitroModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdArbitroModificar.Location = New System.Drawing.Point(3, 188)
        Me.cmdArbitroModificar.Name = "cmdArbitroModificar"
        Me.cmdArbitroModificar.Size = New System.Drawing.Size(132, 32)
        Me.cmdArbitroModificar.TabIndex = 4
        Me.cmdArbitroModificar.Text = "Modificar"
        Me.cmdArbitroModificar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cmdArbitroRegistrar)
        Me.Panel2.Controls.Add(Me.cmdArbitroEliminar)
        Me.Panel2.Controls.Add(Me.cmdArbitroConsulta)
        Me.Panel2.Controls.Add(Me.cmdArbitroModificar)
        Me.Panel2.Location = New System.Drawing.Point(0, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 411)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 100)
        Me.Panel1.TabIndex = 7
        '
        'FormArbitros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 413)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormArbitros"
        Me.Text = "Arbitros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdArbitroRegistrar As Button
    Friend WithEvents cmdArbitroEliminar As Button
    Friend WithEvents cmdArbitroConsulta As Button
    Friend WithEvents cmdArbitroModificar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
