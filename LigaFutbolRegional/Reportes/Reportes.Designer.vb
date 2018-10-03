<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportes
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.DataSet1 = New LigaFutbolRegional.DataSet1()
        Me.JugadorXClubXCampeonatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadorXClubXCampeonatoTableAdapter = New LigaFutbolRegional.DataSet1TableAdapters.JugadorXClubXCampeonatoTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadorXClubXCampeonatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.JugadorXClubXCampeonatoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 90)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 358)
        Me.ReportViewer1.TabIndex = 0
        '
        'btn_reporte
        '
        Me.btn_reporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_reporte.Location = New System.Drawing.Point(641, 44)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(105, 23)
        Me.btn_reporte.TabIndex = 1
        Me.btn_reporte.Text = "Generar Reporte"
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JugadorXClubXCampeonatoBindingSource
        '
        Me.JugadorXClubXCampeonatoBindingSource.DataMember = "JugadorXClubXCampeonato"
        Me.JugadorXClubXCampeonatoBindingSource.DataSource = Me.DataSet1
        '
        'JugadorXClubXCampeonatoTableAdapter
        '
        Me.JugadorXClubXCampeonatoTableAdapter.ClearBeforeFill = True
        '
        'FormReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.ReportViewer1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadorXClubXCampeonatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btn_reporte As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents JugadorXClubXCampeonatoBindingSource As BindingSource
    Friend WithEvents JugadorXClubXCampeonatoTableAdapter As DataSet1TableAdapters.JugadorXClubXCampeonatoTableAdapter
End Class
