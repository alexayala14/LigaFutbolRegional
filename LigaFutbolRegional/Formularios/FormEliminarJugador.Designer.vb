<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEliminarJugador
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.txt_id_club = New LigaFutbolRegional.MaskedTextBox_01()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "N° Documento:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEliminar.Location = New System.Drawing.Point(34, 110)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 21
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelar.Location = New System.Drawing.Point(146, 110)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 22
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'txt_id_club
        '
        Me.txt_id_club.Location = New System.Drawing.Point(117, 36)
        Me.txt_id_club.Name = "txt_id_club"
        Me.txt_id_club.nombre_campo = Nothing
        Me.txt_id_club.nombre_tabla = Nothing
        Me.txt_id_club.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_club.TabIndex = 43
        Me.txt_id_club.validable = False
        Me.txt_id_club.ValidatingType = GetType(Integer)
        '
        'FormEliminarJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(252, 164)
        Me.Controls.Add(Me.txt_id_club)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEliminarJugador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Jugador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents txt_id_club As MaskedTextBox_01
End Class
