<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.lblFrecuenciabackup = New System.Windows.Forms.Label()
        Me.lblImpresora = New System.Windows.Forms.Label()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.cboFrecuenciaBackup = New System.Windows.Forms.ComboBox()
        Me.cboImpresora = New System.Windows.Forms.ComboBox()
        Me.cboIdioma = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFrecuenciabackup
        '
        Me.lblFrecuenciabackup.AutoSize = True
        Me.lblFrecuenciabackup.Location = New System.Drawing.Point(17, 31)
        Me.lblFrecuenciabackup.Name = "lblFrecuenciabackup"
        Me.lblFrecuenciabackup.Size = New System.Drawing.Size(116, 13)
        Me.lblFrecuenciabackup.TabIndex = 0
        Me.lblFrecuenciabackup.Text = "Frecuencia del backup"
        '
        'lblImpresora
        '
        Me.lblImpresora.AutoSize = True
        Me.lblImpresora.Location = New System.Drawing.Point(17, 62)
        Me.lblImpresora.Name = "lblImpresora"
        Me.lblImpresora.Size = New System.Drawing.Size(85, 13)
        Me.lblImpresora.TabIndex = 1
        Me.lblImpresora.Text = "Impresora a usar"
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Location = New System.Drawing.Point(17, 91)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(38, 13)
        Me.lblIdioma.TabIndex = 2
        Me.lblIdioma.Text = "Idioma"
        '
        'cboFrecuenciaBackup
        '
        Me.cboFrecuenciaBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrecuenciaBackup.FormattingEnabled = True
        Me.cboFrecuenciaBackup.Items.AddRange(New Object() {"Seleccione un item", "Diario", "Una semana", "Un mes"})
        Me.cboFrecuenciaBackup.Location = New System.Drawing.Point(172, 28)
        Me.cboFrecuenciaBackup.Name = "cboFrecuenciaBackup"
        Me.cboFrecuenciaBackup.Size = New System.Drawing.Size(121, 21)
        Me.cboFrecuenciaBackup.TabIndex = 3
        '
        'cboImpresora
        '
        Me.cboImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImpresora.FormattingEnabled = True
        Me.cboImpresora.Location = New System.Drawing.Point(172, 59)
        Me.cboImpresora.Name = "cboImpresora"
        Me.cboImpresora.Size = New System.Drawing.Size(121, 21)
        Me.cboImpresora.TabIndex = 4
        '
        'cboIdioma
        '
        Me.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdioma.FormattingEnabled = True
        Me.cboIdioma.Items.AddRange(New Object() {"Seleccione un item", "Español", "Ingles"})
        Me.cboIdioma.Location = New System.Drawing.Point(172, 88)
        Me.cboIdioma.Name = "cboIdioma"
        Me.cboIdioma.Size = New System.Drawing.Size(121, 21)
        Me.cboIdioma.TabIndex = 5
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(128, 121)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "Cerrar"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 156)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cboIdioma)
        Me.Controls.Add(Me.cboImpresora)
        Me.Controls.Add(Me.cboFrecuenciaBackup)
        Me.Controls.Add(Me.lblIdioma)
        Me.Controls.Add(Me.lblImpresora)
        Me.Controls.Add(Me.lblFrecuenciabackup)
        Me.Name = "frmConfiguracion"
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrecuenciabackup As Label
    Friend WithEvents lblImpresora As Label
    Friend WithEvents lblIdioma As Label
    Friend WithEvents cboFrecuenciaBackup As ComboBox
    Friend WithEvents cboImpresora As ComboBox
    Friend WithEvents cboIdioma As ComboBox
    Friend WithEvents cmdClose As Button
End Class
