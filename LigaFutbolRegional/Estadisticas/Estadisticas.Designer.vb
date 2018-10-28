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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt1_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn1_buscar = New System.Windows.Forms.Button()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt2_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn2_buscar = New System.Windows.Forms.Button()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt3_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.btn3_buscar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(1, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(797, 437)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage1.Controls.Add(Me.txt_buscar)
        Me.TabPage1.Controls.Add(Me.btn_buscar)
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(789, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage2.Controls.Add(Me.txt1_buscar)
        Me.TabPage2.Controls.Add(Me.btn1_buscar)
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(789, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage3.Controls.Add(Me.txt2_buscar)
        Me.TabPage3.Controls.Add(Me.btn2_buscar)
        Me.TabPage3.Controls.Add(Me.ReportViewer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(789, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage4.Controls.Add(Me.txt3_buscar)
        Me.TabPage4.Controls.Add(Me.btn3_buscar)
        Me.TabPage4.Controls.Add(Me.ReportViewer4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(789, 411)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.DarkCyan
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 73)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(793, 342)
        Me.ReportViewer1.TabIndex = 0
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(126, 29)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscar.TabIndex = 5
        '
        'btn_buscar
        '
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_buscar.Location = New System.Drawing.Point(261, 26)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.BackColor = System.Drawing.Color.DarkCyan
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 66)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(793, 345)
        Me.ReportViewer2.TabIndex = 0
        '
        'txt1_buscar
        '
        Me.txt1_buscar.Location = New System.Drawing.Point(120, 28)
        Me.txt1_buscar.Name = "txt1_buscar"
        Me.txt1_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt1_buscar.TabIndex = 5
        '
        'btn1_buscar
        '
        Me.btn1_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn1_buscar.Location = New System.Drawing.Point(255, 25)
        Me.btn1_buscar.Name = "btn1_buscar"
        Me.btn1_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn1_buscar.TabIndex = 4
        Me.btn1_buscar.Text = "Buscar"
        Me.btn1_buscar.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.BackColor = System.Drawing.Color.DarkCyan
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico3.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(-4, 69)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ServerReport.BearerToken = Nothing
        Me.ReportViewer3.Size = New System.Drawing.Size(797, 342)
        Me.ReportViewer3.TabIndex = 0
        '
        'txt2_buscar
        '
        Me.txt2_buscar.Location = New System.Drawing.Point(123, 29)
        Me.txt2_buscar.Name = "txt2_buscar"
        Me.txt2_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt2_buscar.TabIndex = 5
        '
        'btn2_buscar
        '
        Me.btn2_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn2_buscar.Location = New System.Drawing.Point(258, 26)
        Me.btn2_buscar.Name = "btn2_buscar"
        Me.btn2_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn2_buscar.TabIndex = 4
        Me.btn2_buscar.Text = "Buscar"
        Me.btn2_buscar.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.BackColor = System.Drawing.Color.DarkCyan
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "LigaFutbolRegional.grafico4.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(0, 73)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.ServerReport.BearerToken = Nothing
        Me.ReportViewer4.Size = New System.Drawing.Size(793, 338)
        Me.ReportViewer4.TabIndex = 0
        '
        'txt3_buscar
        '
        Me.txt3_buscar.Location = New System.Drawing.Point(161, 32)
        Me.txt3_buscar.Name = "txt3_buscar"
        Me.txt3_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt3_buscar.TabIndex = 5
        '
        'btn3_buscar
        '
        Me.btn3_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn3_buscar.Location = New System.Drawing.Point(296, 29)
        Me.btn3_buscar.Name = "btn3_buscar"
        Me.btn3_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn3_buscar.TabIndex = 4
        Me.btn3_buscar.Text = "Buscar"
        Me.btn3_buscar.UseVisualStyleBackColor = True
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estadisticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadisticas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
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
End Class
