<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
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
        Me.lblVaquillonaMeses = New System.Windows.Forms.Label()
        Me.lblPrepartoMeses = New System.Windows.Forms.Label()
        Me.lblTiempoCamporecria = New System.Windows.Forms.Label()
        Me.lblTiempoRevision = New System.Windows.Forms.Label()
        Me.lblCantidaddeordenes = New System.Windows.Forms.Label()
        Me.lblCantidadporlote = New System.Windows.Forms.Label()
        Me.cboVaquillonaMeses = New System.Windows.Forms.ComboBox()
        Me.cboPrepartoMeses = New System.Windows.Forms.ComboBox()
        Me.cboTiempoencrMeses = New System.Windows.Forms.ComboBox()
        Me.cboRevisionMeses = New System.Windows.Forms.ComboBox()
        Me.cboOrdenesDiarios = New System.Windows.Forms.ComboBox()
        Me.cboVacasporLote = New System.Windows.Forms.ComboBox()
        Me.lblPreparto2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVaquillonaMeses
        '
        Me.lblVaquillonaMeses.AutoSize = True
        Me.lblVaquillonaMeses.Location = New System.Drawing.Point(12, 9)
        Me.lblVaquillonaMeses.Name = "lblVaquillonaMeses"
        Me.lblVaquillonaMeses.Size = New System.Drawing.Size(120, 13)
        Me.lblVaquillonaMeses.TabIndex = 0
        Me.lblVaquillonaMeses.Text = "Vaquillona a los (meses)"
        '
        'lblPrepartoMeses
        '
        Me.lblPrepartoMeses.AutoSize = True
        Me.lblPrepartoMeses.Location = New System.Drawing.Point(12, 35)
        Me.lblPrepartoMeses.Name = "lblPrepartoMeses"
        Me.lblPrepartoMeses.Size = New System.Drawing.Size(170, 13)
        Me.lblPrepartoMeses.TabIndex = 1
        Me.lblPrepartoMeses.Text = "Se considera en pre-parto faltando"
        '
        'lblTiempoCamporecria
        '
        Me.lblTiempoCamporecria.AutoSize = True
        Me.lblTiempoCamporecria.Location = New System.Drawing.Point(12, 62)
        Me.lblTiempoCamporecria.Name = "lblTiempoCamporecria"
        Me.lblTiempoCamporecria.Size = New System.Drawing.Size(300, 13)
        Me.lblTiempoCamporecria.TabIndex = 2
        Me.lblTiempoCamporecria.Text = "El tiempo que esta un novillo en el campo de recria es (meses)"
        '
        'lblTiempoRevision
        '
        Me.lblTiempoRevision.AutoSize = True
        Me.lblTiempoRevision.Location = New System.Drawing.Point(12, 86)
        Me.lblTiempoRevision.Name = "lblTiempoRevision"
        Me.lblTiempoRevision.Size = New System.Drawing.Size(216, 13)
        Me.lblTiempoRevision.TabIndex = 3
        Me.lblTiempoRevision.Text = "El tiempo entre revision y revision es (meses)"
        '
        'lblCantidaddeordenes
        '
        Me.lblCantidaddeordenes.AutoSize = True
        Me.lblCantidaddeordenes.Location = New System.Drawing.Point(12, 109)
        Me.lblCantidaddeordenes.Name = "lblCantidaddeordenes"
        Me.lblCantidaddeordenes.Size = New System.Drawing.Size(166, 13)
        Me.lblCantidaddeordenes.TabIndex = 4
        Me.lblCantidaddeordenes.Text = "La cantidad de ordeñes diarios es"
        '
        'lblCantidadporlote
        '
        Me.lblCantidadporlote.AutoSize = True
        Me.lblCantidadporlote.Location = New System.Drawing.Point(12, 132)
        Me.lblCantidadporlote.Name = "lblCantidadporlote"
        Me.lblCantidadporlote.Size = New System.Drawing.Size(134, 13)
        Me.lblCantidadporlote.TabIndex = 5
        Me.lblCantidadporlote.Text = "Cantidad de vacas por lote"
        '
        'cboVaquillonaMeses
        '
        Me.cboVaquillonaMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVaquillonaMeses.FormattingEnabled = True
        Me.cboVaquillonaMeses.Items.AddRange(New Object() {"Seleccione un item", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cboVaquillonaMeses.Location = New System.Drawing.Point(138, 6)
        Me.cboVaquillonaMeses.Name = "cboVaquillonaMeses"
        Me.cboVaquillonaMeses.Size = New System.Drawing.Size(121, 21)
        Me.cboVaquillonaMeses.TabIndex = 6
        '
        'cboPrepartoMeses
        '
        Me.cboPrepartoMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrepartoMeses.FormattingEnabled = True
        Me.cboPrepartoMeses.Items.AddRange(New Object() {"Seleccione un item", "1", "2", "3"})
        Me.cboPrepartoMeses.Location = New System.Drawing.Point(191, 32)
        Me.cboPrepartoMeses.Name = "cboPrepartoMeses"
        Me.cboPrepartoMeses.Size = New System.Drawing.Size(121, 21)
        Me.cboPrepartoMeses.TabIndex = 7
        '
        'cboTiempoencrMeses
        '
        Me.cboTiempoencrMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiempoencrMeses.FormattingEnabled = True
        Me.cboTiempoencrMeses.Items.AddRange(New Object() {"Seleccione un item", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboTiempoencrMeses.Location = New System.Drawing.Point(318, 59)
        Me.cboTiempoencrMeses.Name = "cboTiempoencrMeses"
        Me.cboTiempoencrMeses.Size = New System.Drawing.Size(121, 21)
        Me.cboTiempoencrMeses.TabIndex = 8
        '
        'cboRevisionMeses
        '
        Me.cboRevisionMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRevisionMeses.FormattingEnabled = True
        Me.cboRevisionMeses.Items.AddRange(New Object() {"Seleccione un item", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboRevisionMeses.Location = New System.Drawing.Point(234, 83)
        Me.cboRevisionMeses.Name = "cboRevisionMeses"
        Me.cboRevisionMeses.Size = New System.Drawing.Size(121, 21)
        Me.cboRevisionMeses.TabIndex = 9
        '
        'cboOrdenesDiarios
        '
        Me.cboOrdenesDiarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrdenesDiarios.FormattingEnabled = True
        Me.cboOrdenesDiarios.Items.AddRange(New Object() {"Seleccione un item", "1", "2", "3"})
        Me.cboOrdenesDiarios.Location = New System.Drawing.Point(184, 106)
        Me.cboOrdenesDiarios.Name = "cboOrdenesDiarios"
        Me.cboOrdenesDiarios.Size = New System.Drawing.Size(121, 21)
        Me.cboOrdenesDiarios.TabIndex = 10
        '
        'cboVacasporLote
        '
        Me.cboVacasporLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVacasporLote.FormattingEnabled = True
        Me.cboVacasporLote.Items.AddRange(New Object() {"Seleccione un item", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cboVacasporLote.Location = New System.Drawing.Point(152, 129)
        Me.cboVacasporLote.Name = "cboVacasporLote"
        Me.cboVacasporLote.Size = New System.Drawing.Size(121, 21)
        Me.cboVacasporLote.TabIndex = 11
        '
        'lblPreparto2
        '
        Me.lblPreparto2.AutoSize = True
        Me.lblPreparto2.Location = New System.Drawing.Point(318, 35)
        Me.lblPreparto2.Name = "lblPreparto2"
        Me.lblPreparto2.Size = New System.Drawing.Size(99, 13)
        Me.lblPreparto2.TabIndex = 12
        Me.lblPreparto2.Text = "meses para el parto"
        '
        'frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 164)
        Me.Controls.Add(Me.lblPreparto2)
        Me.Controls.Add(Me.cboVacasporLote)
        Me.Controls.Add(Me.cboOrdenesDiarios)
        Me.Controls.Add(Me.cboRevisionMeses)
        Me.Controls.Add(Me.cboTiempoencrMeses)
        Me.Controls.Add(Me.cboPrepartoMeses)
        Me.Controls.Add(Me.cboVaquillonaMeses)
        Me.Controls.Add(Me.lblCantidadporlote)
        Me.Controls.Add(Me.lblCantidaddeordenes)
        Me.Controls.Add(Me.lblTiempoRevision)
        Me.Controls.Add(Me.lblTiempoCamporecria)
        Me.Controls.Add(Me.lblPrepartoMeses)
        Me.Controls.Add(Me.lblVaquillonaMeses)
        Me.Name = "frmParametros"
        Me.Text = "Parametros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVaquillonaMeses As Label
    Friend WithEvents lblPrepartoMeses As Label
    Friend WithEvents lblTiempoCamporecria As Label
    Friend WithEvents lblTiempoRevision As Label
    Friend WithEvents lblCantidaddeordenes As Label
    Friend WithEvents lblCantidadporlote As Label
    Friend WithEvents cboVaquillonaMeses As ComboBox
    Friend WithEvents cboPrepartoMeses As ComboBox
    Friend WithEvents cboTiempoencrMeses As ComboBox
    Friend WithEvents cboRevisionMeses As ComboBox
    Friend WithEvents cboOrdenesDiarios As ComboBox
    Friend WithEvents cboVacasporLote As ComboBox
    Friend WithEvents lblPreparto2 As Label
End Class
