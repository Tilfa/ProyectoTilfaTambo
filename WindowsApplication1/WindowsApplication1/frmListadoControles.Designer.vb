<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoControles
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
        Me.IdAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoSalud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimaRevision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProximaRevison = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IrDetalles = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IrAnimal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAnimal, Me.EstadoSalud, Me.UltimaRevision, Me.ProximaRevison, Me.IrDetalles, Me.IrAnimal})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 283)
        Me.DataGridView1.TabIndex = 0
        '
        'IdAnimal
        '
        Me.IdAnimal.HeaderText = "Id Animal"
        Me.IdAnimal.Name = "IdAnimal"
        '
        'EstadoSalud
        '
        Me.EstadoSalud.HeaderText = "Estado de salud"
        Me.EstadoSalud.Name = "EstadoSalud"
        '
        'UltimaRevision
        '
        Me.UltimaRevision.HeaderText = "Ultima revision"
        Me.UltimaRevision.Name = "UltimaRevision"
        '
        'ProximaRevison
        '
        Me.ProximaRevison.HeaderText = "Proxima revision"
        Me.ProximaRevison.Name = "ProximaRevison"
        '
        'IrDetalles
        '
        Me.IrDetalles.HeaderText = "Detalles"
        Me.IrDetalles.Name = "IrDetalles"
        Me.IrDetalles.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IrDetalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IrAnimal
        '
        Me.IrAnimal.HeaderText = "Ver animal"
        Me.IrAnimal.Name = "IrAnimal"
        Me.IrAnimal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IrAnimal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(284, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Nueva revision"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmListadoControles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 404)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmListadoControles"
        Me.Text = "frmListadoControles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdAnimal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoSalud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimaRevision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProximaRevison As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IrDetalles As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents IrAnimal As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
