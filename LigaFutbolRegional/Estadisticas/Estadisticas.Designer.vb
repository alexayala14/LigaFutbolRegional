<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
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
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataSet31BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet31 = New LigaFutbolRegional.DataSet3()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txt_restriccion = New System.Windows.Forms.MaskedTextBox()
        Me.btn_restriccion = New System.Windows.Forms.Button()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.txt_restriccion1 = New System.Windows.Forms.MaskedTextBox()
        Me.btn_restriccion1 = New System.Windows.Forms.Button()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.txt_restriccion2 = New System.Windows.Forms.MaskedTextBox()
        Me.btn_restriccion2 = New System.Windows.Forms.Button()
        Me.ReportViewer7 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.txt_restriccion3 = New System.Windows.Forms.MaskedTextBox()
        Me.btn_restriccion3 = New System.Windows.Forms.Button()
        Me.ReportViewer8 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataSet31BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet31BindingSource
        '
        Me.DataSet31BindingSource.DataSource = Me.DataSet31
        Me.DataSet31BindingSource.Position = 0
        '
        'DataSet31
        '
        Me.DataSet31.DataSetName = "DataSet3"
        Me.DataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Location = New System.Drawing.Point(0, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(926, 544)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.txt_restriccion)
        Me.TabPage5.Controls.Add(Me.btn_restriccion)
        Me.TabPage5.Controls.Add(Me.ReportViewer5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(918, 518)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Posiciones"
        '
        'txt_restriccion
        '
        Me.txt_restriccion.Location = New System.Drawing.Point(124, 31)
        Me.txt_restriccion.Name = "txt_restriccion"
        Me.txt_restriccion.Size = New System.Drawing.Size(100, 20)
        Me.txt_restriccion.TabIndex = 2
        '
        'btn_restriccion
        '
        Me.btn_restriccion.Location = New System.Drawing.Point(250, 31)
        Me.btn_restriccion.Name = "btn_restriccion"
        Me.btn_restriccion.Size = New System.Drawing.Size(75, 23)
        Me.btn_restriccion.TabIndex = 1
        Me.btn_restriccion.Text = "Graficar"
        Me.btn_restriccion.UseVisualStyleBackColor = True
        '
        'ReportViewer5
        '
        Me.ReportViewer5.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.DataSet31BindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico1.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(0, 76)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.ServerReport.BearerToken = Nothing
        Me.ReportViewer5.Size = New System.Drawing.Size(918, 439)
        Me.ReportViewer5.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage6.Controls.Add(Me.Label2)
        Me.TabPage6.Controls.Add(Me.txt_restriccion1)
        Me.TabPage6.Controls.Add(Me.btn_restriccion1)
        Me.TabPage6.Controls.Add(Me.ReportViewer6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(918, 518)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Goles"
        '
        'txt_restriccion1
        '
        Me.txt_restriccion1.Location = New System.Drawing.Point(124, 39)
        Me.txt_restriccion1.Name = "txt_restriccion1"
        Me.txt_restriccion1.Size = New System.Drawing.Size(100, 20)
        Me.txt_restriccion1.TabIndex = 4
        '
        'btn_restriccion1
        '
        Me.btn_restriccion1.Location = New System.Drawing.Point(250, 37)
        Me.btn_restriccion1.Name = "btn_restriccion1"
        Me.btn_restriccion1.Size = New System.Drawing.Size(75, 23)
        Me.btn_restriccion1.TabIndex = 3
        Me.btn_restriccion1.Text = "Graficar"
        Me.btn_restriccion1.UseVisualStyleBackColor = True
        '
        'ReportViewer6
        '
        Me.ReportViewer6.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource10.Name = "DataSet1"
        ReportDataSource10.Value = Me.DataSet31BindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico2.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(3, 84)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.ServerReport.BearerToken = Nothing
        Me.ReportViewer6.Size = New System.Drawing.Size(915, 434)
        Me.ReportViewer6.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage7.Controls.Add(Me.Label3)
        Me.TabPage7.Controls.Add(Me.txt_restriccion2)
        Me.TabPage7.Controls.Add(Me.btn_restriccion2)
        Me.TabPage7.Controls.Add(Me.ReportViewer7)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(918, 518)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "Faltas"
        '
        'txt_restriccion2
        '
        Me.txt_restriccion2.Location = New System.Drawing.Point(123, 40)
        Me.txt_restriccion2.Name = "txt_restriccion2"
        Me.txt_restriccion2.Size = New System.Drawing.Size(100, 20)
        Me.txt_restriccion2.TabIndex = 4
        '
        'btn_restriccion2
        '
        Me.btn_restriccion2.Location = New System.Drawing.Point(249, 38)
        Me.btn_restriccion2.Name = "btn_restriccion2"
        Me.btn_restriccion2.Size = New System.Drawing.Size(75, 23)
        Me.btn_restriccion2.TabIndex = 3
        Me.btn_restriccion2.Text = "Graficar"
        Me.btn_restriccion2.UseVisualStyleBackColor = True
        '
        'ReportViewer7
        '
        Me.ReportViewer7.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource11.Name = "DataSet1"
        ReportDataSource11.Value = Me.DataSet31BindingSource
        Me.ReportViewer7.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer7.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico3.rdlc"
        Me.ReportViewer7.Location = New System.Drawing.Point(0, 81)
        Me.ReportViewer7.Name = "ReportViewer7"
        Me.ReportViewer7.ServerReport.BearerToken = Nothing
        Me.ReportViewer7.Size = New System.Drawing.Size(918, 431)
        Me.ReportViewer7.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage8.Controls.Add(Me.Label4)
        Me.TabPage8.Controls.Add(Me.txt_restriccion3)
        Me.TabPage8.Controls.Add(Me.btn_restriccion3)
        Me.TabPage8.Controls.Add(Me.ReportViewer8)
        Me.TabPage8.ForeColor = System.Drawing.Color.DarkCyan
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(918, 518)
        Me.TabPage8.TabIndex = 3
        Me.TabPage8.Text = "Tarjetas Amarillas"
        '
        'txt_restriccion3
        '
        Me.txt_restriccion3.Location = New System.Drawing.Point(124, 40)
        Me.txt_restriccion3.Name = "txt_restriccion3"
        Me.txt_restriccion3.Size = New System.Drawing.Size(100, 20)
        Me.txt_restriccion3.TabIndex = 4
        '
        'btn_restriccion3
        '
        Me.btn_restriccion3.ForeColor = System.Drawing.Color.Black
        Me.btn_restriccion3.Location = New System.Drawing.Point(250, 38)
        Me.btn_restriccion3.Name = "btn_restriccion3"
        Me.btn_restriccion3.Size = New System.Drawing.Size(75, 23)
        Me.btn_restriccion3.TabIndex = 3
        Me.btn_restriccion3.Text = "Graficar"
        Me.btn_restriccion3.UseVisualStyleBackColor = True
        '
        'ReportViewer8
        '
        Me.ReportViewer8.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource12.Name = "DataSet1"
        ReportDataSource12.Value = Me.DataSet31BindingSource
        Me.ReportViewer8.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer8.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico4.rdlc"
        Me.ReportViewer8.Location = New System.Drawing.Point(0, 81)
        Me.ReportViewer8.Name = "ReportViewer8"
        Me.ReportViewer8.ServerReport.BearerToken = Nothing
        Me.ReportViewer8.Size = New System.Drawing.Size(918, 434)
        Me.ReportViewer8.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Restriccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(44, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Restriccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(45, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Restriccion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(41, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Restriccion:"
        '
        'Estadisticas
        '
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(927, 556)
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estadisticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataSet31BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txt_buscar As MaskedTextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt1_buscar As MaskedTextBox
    Friend WithEvents btn1_buscar As Button
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt2_buscar As MaskedTextBox
    Friend WithEvents btn2_buscar As Button
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt3_buscar As MaskedTextBox
    Friend WithEvents btn3_buscar As Button
    Friend WithEvents ClubFutbolBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ClubFutbolTableAdapter As DataSet1TableAdapters.ClubFutbolTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstadisticaBindingSource As BindingSource
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents ReportViewer7 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer8 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt_restriccion As MaskedTextBox
    Friend WithEvents btn_restriccion As Button
    Friend WithEvents DataSet31BindingSource As BindingSource
    Friend WithEvents DataSet31 As DataSet3
    Friend WithEvents txt_restriccion1 As MaskedTextBox
    Friend WithEvents btn_restriccion1 As Button
    Friend WithEvents txt_restriccion2 As MaskedTextBox
    Friend WithEvents btn_restriccion2 As Button
    Friend WithEvents txt_restriccion3 As MaskedTextBox
    Friend WithEvents btn_restriccion3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
