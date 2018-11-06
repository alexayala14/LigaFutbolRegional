<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ClubFutbolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New LigaFutbolRegional.DataSet1()
        Me.FKJugadorXClubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadorTableAdapter = New LigaFutbolRegional.DataSet1TableAdapters.JugadorTableAdapter()
        Me.JugadorXClubTableAdapter = New LigaFutbolRegional.DataSet1TableAdapters.JugadorXClubTableAdapter()
        Me.ClubFutbolTableAdapter = New LigaFutbolRegional.DataSet1TableAdapters.ClubFutbolTableAdapter()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt3_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn3_buscar = New System.Windows.Forms.Button()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt2_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn2_buscar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt1_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn1_buscar = New System.Windows.Forms.Button()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.JugadorXClubXCampeonatoXPartidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New LigaFutbolRegional.DataSet2()
        Me.ReporteClubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadorXClubXCampeonatoXPartidoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadorXClubXCampeonatoXPartidoTableAdapter = New LigaFutbolRegional.DataSet2TableAdapters.JugadorXClubXCampeonatoXPartidoTableAdapter()
        Me.ReporteClubTableAdapter = New LigaFutbolRegional.DataSet2TableAdapters.ReporteClubTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ClubFutbolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKJugadorXClubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.JugadorXClubXCampeonatoXPartidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteClubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadorXClubXCampeonatoXPartidoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClubFutbolBindingSource
        '
        Me.ClubFutbolBindingSource.DataMember = "ClubFutbol"
        Me.ClubFutbolBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FKJugadorXClubBindingSource
        '
        Me.FKJugadorXClubBindingSource.DataMember = "FK_JugadorXClub"
        Me.FKJugadorXClubBindingSource.DataSource = Me.JugadorBindingSource
        '
        'JugadorBindingSource
        '
        Me.JugadorBindingSource.DataMember = "Jugador"
        Me.JugadorBindingSource.DataSource = Me.DataSet1
        '
        'JugadorTableAdapter
        '
        Me.JugadorTableAdapter.ClearBeforeFill = True
        '
        'JugadorXClubTableAdapter
        '
        Me.JugadorXClubTableAdapter.ClearBeforeFill = True
        '
        'ClubFutbolTableAdapter
        '
        Me.ClubFutbolTableAdapter.ClearBeforeFill = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.txt3_buscar)
        Me.TabPage4.Controls.Add(Me.btn3_buscar)
        Me.TabPage4.Controls.Add(Me.ReportViewer4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(769, 413)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Goles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filtro:"
        '
        'txt3_buscar
        '
        Me.txt3_buscar.Location = New System.Drawing.Point(86, 30)
        Me.txt3_buscar.Name = "txt3_buscar"
        Me.txt3_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt3_buscar.TabIndex = 5
        '
        'btn3_buscar
        '
        Me.btn3_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn3_buscar.Location = New System.Drawing.Point(215, 28)
        Me.btn3_buscar.Name = "btn3_buscar"
        Me.btn3_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn3_buscar.TabIndex = 4
        Me.btn3_buscar.Text = "Buscar"
        Me.btn3_buscar.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.JugadorXClubXCampeonatoXPartidoBindingSource1
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.Report4.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(0, 78)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.ServerReport.BearerToken = Nothing
        Me.ReportViewer4.Size = New System.Drawing.Size(773, 333)
        Me.ReportViewer4.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.ReportViewer3)
        Me.TabPage3.Controls.Add(Me.txt2_buscar)
        Me.TabPage3.Controls.Add(Me.btn2_buscar)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(769, 413)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Posiciones"
        '
        'ReportViewer3
        '
        Me.ReportViewer3.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource2.Name = "TablaPosiciones"
        ReportDataSource2.Value = Me.ReporteClubBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.Report3.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 77)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ServerReport.BearerToken = Nothing
        Me.ReportViewer3.Size = New System.Drawing.Size(771, 331)
        Me.ReportViewer3.TabIndex = 6
        '
        'txt2_buscar
        '
        Me.txt2_buscar.Location = New System.Drawing.Point(82, 29)
        Me.txt2_buscar.Name = "txt2_buscar"
        Me.txt2_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt2_buscar.TabIndex = 5
        '
        'btn2_buscar
        '
        Me.btn2_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn2_buscar.Location = New System.Drawing.Point(213, 27)
        Me.btn2_buscar.Name = "btn2_buscar"
        Me.btn2_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn2_buscar.TabIndex = 4
        Me.btn2_buscar.Text = "Buscar"
        Me.btn2_buscar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt1_buscar)
        Me.TabPage2.Controls.Add(Me.btn1_buscar)
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(769, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Faltas"
        '
        'txt1_buscar
        '
        Me.txt1_buscar.Location = New System.Drawing.Point(82, 28)
        Me.txt1_buscar.Name = "txt1_buscar"
        Me.txt1_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt1_buscar.TabIndex = 5
        '
        'btn1_buscar
        '
        Me.btn1_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn1_buscar.Location = New System.Drawing.Point(210, 26)
        Me.btn1_buscar.Name = "btn1_buscar"
        Me.btn1_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn1_buscar.TabIndex = 4
        Me.btn1_buscar.Text = "Buscar"
        Me.btn1_buscar.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource3.Name = "DataSet2"
        ReportDataSource3.Value = Me.JugadorXClubXCampeonatoXPartidoBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.Report2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 76)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(768, 329)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Controls.Add(Me.txt_buscar)
        Me.TabPage1.Controls.Add(Me.btn_buscar)
        Me.TabPage1.ForeColor = System.Drawing.Color.DarkCyan
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(769, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clubes"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.DarkCyan
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.ClubFutbolBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 75)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(769, 330)
        Me.ReportViewer1.TabIndex = 0
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(89, 27)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscar.TabIndex = 3
        '
        'btn_buscar
        '
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_buscar.Location = New System.Drawing.Point(219, 25)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(777, 439)
        Me.TabControl1.TabIndex = 4
        '
        'JugadorXClubXCampeonatoXPartidoBindingSource
        '
        Me.JugadorXClubXCampeonatoXPartidoBindingSource.DataMember = "JugadorXClubXCampeonatoXPartido"
        Me.JugadorXClubXCampeonatoXPartidoBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteClubBindingSource
        '
        Me.ReporteClubBindingSource.DataMember = "ReporteClub"
        Me.ReporteClubBindingSource.DataSource = Me.DataSet2
        '
        'JugadorXClubXCampeonatoXPartidoBindingSource1
        '
        Me.JugadorXClubXCampeonatoXPartidoBindingSource1.DataMember = "JugadorXClubXCampeonatoXPartido"
        Me.JugadorXClubXCampeonatoXPartidoBindingSource1.DataSource = Me.DataSet2
        '
        'JugadorXClubXCampeonatoXPartidoTableAdapter
        '
        Me.JugadorXClubXCampeonatoXPartidoTableAdapter.ClearBeforeFill = True
        '
        'ReporteClubTableAdapter
        '
        Me.ReporteClubTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(51, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filtro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(44, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filtro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(44, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Filtro:"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(775, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.ClubFutbolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKJugadorXClubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.JugadorXClubXCampeonatoXPartidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteClubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadorXClubXCampeonatoXPartidoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JugadorBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents JugadorTableAdapter As DataSet1TableAdapters.JugadorTableAdapter
    Friend WithEvents FKJugadorXClubBindingSource As BindingSource
    Friend WithEvents JugadorXClubTableAdapter As DataSet1TableAdapters.JugadorXClubTableAdapter
    Friend WithEvents JugadorResultados As DataSet2TableAdapters.JugadorXClubXCampeonatoXPartidoTableAdapter
    Friend WithEvents JugadorResultadoBindingSource As BindingSource
    Friend WithEvents ClubFutbolBindingSource As BindingSource
    Friend WithEvents ClubFutbolTableAdapter As DataSet1TableAdapters.ClubFutbolTableAdapter
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents JugadorXClubXCampeonatoXPartidoBindingSource As BindingSource
    Friend WithEvents JugadorXClubXCampeonatoXPartidoTableAdapter As DataSet2TableAdapters.JugadorXClubXCampeonatoXPartidoTableAdapter
    Friend WithEvents ReporteClubBindingSource As BindingSource
    Friend WithEvents ReporteClubTableAdapter As DataSet2TableAdapters.ReporteClubTableAdapter
    Friend WithEvents JugadorXClubXCampeonatoXPartidoBindingSource1 As BindingSource
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txt3_buscar As MaskedTextBox
    Friend WithEvents btn3_buscar As Button
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt2_buscar As MaskedTextBox
    Friend WithEvents btn2_buscar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt1_buscar As MaskedTextBox
    Friend WithEvents btn1_buscar As Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt_buscar As MaskedTextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
