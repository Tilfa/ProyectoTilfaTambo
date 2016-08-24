<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoOrdeñes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteOrdeñado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrasaButirosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proteinas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lactosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelulasSomaticas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IrLote = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IrOrdeñe = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Hora, Me.LoteOrdeñado, Me.GrasaButirosa, Me.Proteinas, Me.Lactosa, Me.CelulasSomaticas, Me.IrLote, Me.IrOrdeñe})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(942, 419)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(412, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar ordeñe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        '
        'LoteOrdeñado
        '
        Me.LoteOrdeñado.HeaderText = "ID del lote ordeñado"
        Me.LoteOrdeñado.Name = "LoteOrdeñado"
        '
        'GrasaButirosa
        '
        Me.GrasaButirosa.HeaderText = "Grasa butirosa"
        Me.GrasaButirosa.Name = "GrasaButirosa"
        '
        'Proteinas
        '
        Me.Proteinas.HeaderText = "Proteinas"
        Me.Proteinas.Name = "Proteinas"
        '
        'Lactosa
        '
        Me.Lactosa.HeaderText = "Lactosa"
        Me.Lactosa.Name = "Lactosa"
        '
        'CelulasSomaticas
        '
        Me.CelulasSomaticas.HeaderText = "Celulas somaticas"
        Me.CelulasSomaticas.Name = "CelulasSomaticas"
        '
        'IrLote
        '
        Me.IrLote.HeaderText = "Ir al lote"
        Me.IrLote.Name = "IrLote"
        '
        'IrOrdeñe
        '
        Me.IrOrdeñe.HeaderText = "Ir a ordeñe"
        Me.IrOrdeñe.Name = "IrOrdeñe"
        Me.IrOrdeñe.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IrOrdeñe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(430, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmListadoOrdeñes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 497)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmListadoOrdeñes"
        Me.Text = "frmListadoOrdeñes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteOrdeñado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrasaButirosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proteinas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lactosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelulasSomaticas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IrLote As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents IrOrdeñe As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
