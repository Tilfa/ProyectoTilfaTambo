<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoLote
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
        Me.lblNumeroLote = New System.Windows.Forms.Label()
        Me.lblTipoLote = New System.Windows.Forms.Label()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.txtNumeroLote = New System.Windows.Forms.TextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumeroLote
        '
        Me.lblNumeroLote.AutoSize = True
        Me.lblNumeroLote.Location = New System.Drawing.Point(26, 27)
        Me.lblNumeroLote.Name = "lblNumeroLote"
        Me.lblNumeroLote.Size = New System.Drawing.Size(79, 13)
        Me.lblNumeroLote.TabIndex = 0
        Me.lblNumeroLote.Text = "Numero de lote"
        '
        'lblTipoLote
        '
        Me.lblTipoLote.AutoSize = True
        Me.lblTipoLote.Location = New System.Drawing.Point(26, 60)
        Me.lblTipoLote.Name = "lblTipoLote"
        Me.lblTipoLote.Size = New System.Drawing.Size(63, 13)
        Me.lblTipoLote.TabIndex = 1
        Me.lblTipoLote.Text = "Tipo de lote"
        '
        'cboTipoLote
        '
        Me.cboTipoLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoLote.FormattingEnabled = True
        Me.cboTipoLote.Items.AddRange(New Object() {"Seleccione un item", "Vacas en pre-parto", "Vacas para ordeñe", "Vacas secas"})
        Me.cboTipoLote.Location = New System.Drawing.Point(95, 57)
        Me.cboTipoLote.Name = "cboTipoLote"
        Me.cboTipoLote.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoLote.TabIndex = 2
        '
        'txtNumeroLote
        '
        Me.txtNumeroLote.Location = New System.Drawing.Point(111, 24)
        Me.txtNumeroLote.Name = "txtNumeroLote"
        Me.txtNumeroLote.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroLote.TabIndex = 3
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(51, 117)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(190, 117)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(236, 49)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 35)
        Me.cmdAgregar.TabIndex = 6
        Me.cmdAgregar.Text = "Agregar tipo de lote"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'frmNuevoLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 157)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtNumeroLote)
        Me.Controls.Add(Me.cboTipoLote)
        Me.Controls.Add(Me.lblTipoLote)
        Me.Controls.Add(Me.lblNumeroLote)
        Me.Name = "frmNuevoLote"
        Me.Text = "Nuevo lote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumeroLote As Label
    Friend WithEvents lblTipoLote As Label
    Friend WithEvents cboTipoLote As ComboBox
    Friend WithEvents txtNumeroLote As TextBox
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdAgregar As Button
End Class
