<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoLotes
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
        Me.lstLotes = New System.Windows.Forms.ListBox()
        Me.lblTipoLote = New System.Windows.Forms.Label()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLotes
        '
        Me.lstLotes.FormattingEnabled = True
        Me.lstLotes.Location = New System.Drawing.Point(12, 33)
        Me.lstLotes.Name = "lstLotes"
        Me.lstLotes.Size = New System.Drawing.Size(493, 264)
        Me.lstLotes.TabIndex = 0
        '
        'lblTipoLote
        '
        Me.lblTipoLote.AutoSize = True
        Me.lblTipoLote.Location = New System.Drawing.Point(12, 9)
        Me.lblTipoLote.Name = "lblTipoLote"
        Me.lblTipoLote.Size = New System.Drawing.Size(66, 13)
        Me.lblTipoLote.TabIndex = 1
        Me.lblTipoLote.Text = "Tipo de lote:"
        '
        'cboTipoLote
        '
        Me.cboTipoLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoLote.FormattingEnabled = True
        Me.cboTipoLote.Items.AddRange(New Object() {"Seleccione un item", "Vacas en pre-parto", "Vacas para ordeñe", "Vacas secas"})
        Me.cboTipoLote.Location = New System.Drawing.Point(97, 6)
        Me.cboTipoLote.Name = "cboTipoLote"
        Me.cboTipoLote.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoLote.TabIndex = 3
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(198, 303)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Cerrar"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmListadoLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 346)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cboTipoLote)
        Me.Controls.Add(Me.lblTipoLote)
        Me.Controls.Add(Me.lstLotes)
        Me.Name = "frmListadoLotes"
        Me.Text = "frmListadoLotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLotes As ListBox
    Friend WithEvents lblTipoLote As Label
    Friend WithEvents cboTipoLote As ComboBox
    Friend WithEvents cmdClose As Button
End Class
