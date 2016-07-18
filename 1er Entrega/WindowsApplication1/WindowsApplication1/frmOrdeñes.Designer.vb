<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdeñes
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
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblNumeroLote = New System.Windows.Forms.Label()
        Me.dateFecha = New System.Windows.Forms.DateTimePicker()
        Me.numMinutos = New System.Windows.Forms.NumericUpDown()
        Me.numHora = New System.Windows.Forms.NumericUpDown()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.cboNumeroLote = New System.Windows.Forms.ComboBox()
        Me.chkAnalisis = New System.Windows.Forms.CheckBox()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.numLitros = New System.Windows.Forms.NumericUpDown()
        Me.frameAnalisis = New System.Windows.Forms.GroupBox()
        Me.lblParametro4 = New System.Windows.Forms.Label()
        Me.lblParametro3 = New System.Windows.Forms.Label()
        Me.txtParametro4 = New System.Windows.Forms.TextBox()
        Me.txtParametro3 = New System.Windows.Forms.TextBox()
        Me.txtParametro2 = New System.Windows.Forms.TextBox()
        Me.txtParametro1 = New System.Windows.Forms.TextBox()
        Me.lblParametro2 = New System.Windows.Forms.Label()
        Me.lblParametro1 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.numMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLitros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frameAnalisis.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(13, 13)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(262, 13)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Hora"
        '
        'lblNumeroLote
        '
        Me.lblNumeroLote.AutoSize = True
        Me.lblNumeroLote.Location = New System.Drawing.Point(13, 44)
        Me.lblNumeroLote.Name = "lblNumeroLote"
        Me.lblNumeroLote.Size = New System.Drawing.Size(79, 13)
        Me.lblNumeroLote.TabIndex = 2
        Me.lblNumeroLote.Text = "Numero de lote"
        '
        'dateFecha
        '
        Me.dateFecha.Location = New System.Drawing.Point(56, 7)
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(200, 20)
        Me.dateFecha.TabIndex = 3
        '
        'numMinutos
        '
        Me.numMinutos.Location = New System.Drawing.Point(380, 11)
        Me.numMinutos.Name = "numMinutos"
        Me.numMinutos.Size = New System.Drawing.Size(33, 20)
        Me.numMinutos.TabIndex = 4
        '
        'numHora
        '
        Me.numHora.Location = New System.Drawing.Point(298, 11)
        Me.numHora.Name = "numHora"
        Me.numHora.Size = New System.Drawing.Size(31, 20)
        Me.numHora.TabIndex = 5
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(335, 14)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(39, 13)
        Me.lblMinutos.TabIndex = 6
        Me.lblMinutos.Text = "Minuto"
        '
        'cboNumeroLote
        '
        Me.cboNumeroLote.FormattingEnabled = True
        Me.cboNumeroLote.Location = New System.Drawing.Point(98, 41)
        Me.cboNumeroLote.Name = "cboNumeroLote"
        Me.cboNumeroLote.Size = New System.Drawing.Size(121, 21)
        Me.cboNumeroLote.TabIndex = 7
        '
        'chkAnalisis
        '
        Me.chkAnalisis.AutoSize = True
        Me.chkAnalisis.Location = New System.Drawing.Point(19, 99)
        Me.chkAnalisis.Name = "chkAnalisis"
        Me.chkAnalisis.Size = New System.Drawing.Size(116, 17)
        Me.chkAnalisis.TabIndex = 8
        Me.chkAnalisis.Text = "Analisis de la leche"
        Me.chkAnalisis.UseVisualStyleBackColor = True
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Location = New System.Drawing.Point(16, 73)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(32, 13)
        Me.lblLitros.TabIndex = 9
        Me.lblLitros.Text = "Litros"
        '
        'numLitros
        '
        Me.numLitros.DecimalPlaces = 2
        Me.numLitros.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numLitros.Location = New System.Drawing.Point(54, 71)
        Me.numLitros.Name = "numLitros"
        Me.numLitros.Size = New System.Drawing.Size(63, 20)
        Me.numLitros.TabIndex = 10
        '
        'frameAnalisis
        '
        Me.frameAnalisis.Controls.Add(Me.lblParametro4)
        Me.frameAnalisis.Controls.Add(Me.lblParametro3)
        Me.frameAnalisis.Controls.Add(Me.txtParametro4)
        Me.frameAnalisis.Controls.Add(Me.txtParametro3)
        Me.frameAnalisis.Controls.Add(Me.txtParametro2)
        Me.frameAnalisis.Controls.Add(Me.txtParametro1)
        Me.frameAnalisis.Controls.Add(Me.lblParametro2)
        Me.frameAnalisis.Controls.Add(Me.lblParametro1)
        Me.frameAnalisis.Location = New System.Drawing.Point(19, 122)
        Me.frameAnalisis.Name = "frameAnalisis"
        Me.frameAnalisis.Size = New System.Drawing.Size(261, 131)
        Me.frameAnalisis.TabIndex = 11
        Me.frameAnalisis.TabStop = False
        Me.frameAnalisis.Text = "Analisis"
        '
        'lblParametro4
        '
        Me.lblParametro4.AutoSize = True
        Me.lblParametro4.Location = New System.Drawing.Point(7, 104)
        Me.lblParametro4.Name = "lblParametro4"
        Me.lblParametro4.Size = New System.Drawing.Size(91, 13)
        Me.lblParametro4.TabIndex = 7
        Me.lblParametro4.Text = "Celulas somaticas"
        '
        'lblParametro3
        '
        Me.lblParametro3.AutoSize = True
        Me.lblParametro3.Location = New System.Drawing.Point(7, 77)
        Me.lblParametro3.Name = "lblParametro3"
        Me.lblParametro3.Size = New System.Drawing.Size(45, 13)
        Me.lblParametro3.TabIndex = 6
        Me.lblParametro3.Text = "Lactosa"
        '
        'txtParametro4
        '
        Me.txtParametro4.Location = New System.Drawing.Point(104, 101)
        Me.txtParametro4.Name = "txtParametro4"
        Me.txtParametro4.Size = New System.Drawing.Size(100, 20)
        Me.txtParametro4.TabIndex = 5
        '
        'txtParametro3
        '
        Me.txtParametro3.Location = New System.Drawing.Point(58, 74)
        Me.txtParametro3.Name = "txtParametro3"
        Me.txtParametro3.Size = New System.Drawing.Size(100, 20)
        Me.txtParametro3.TabIndex = 4
        '
        'txtParametro2
        '
        Me.txtParametro2.Location = New System.Drawing.Point(67, 48)
        Me.txtParametro2.Name = "txtParametro2"
        Me.txtParametro2.Size = New System.Drawing.Size(100, 20)
        Me.txtParametro2.TabIndex = 3
        '
        'txtParametro1
        '
        Me.txtParametro1.Location = New System.Drawing.Point(104, 17)
        Me.txtParametro1.Name = "txtParametro1"
        Me.txtParametro1.Size = New System.Drawing.Size(100, 20)
        Me.txtParametro1.TabIndex = 2
        '
        'lblParametro2
        '
        Me.lblParametro2.AutoSize = True
        Me.lblParametro2.Location = New System.Drawing.Point(7, 50)
        Me.lblParametro2.Name = "lblParametro2"
        Me.lblParametro2.Size = New System.Drawing.Size(51, 13)
        Me.lblParametro2.TabIndex = 1
        Me.lblParametro2.Text = "Proteinas"
        '
        'lblParametro1
        '
        Me.lblParametro1.AutoSize = True
        Me.lblParametro1.Location = New System.Drawing.Point(7, 20)
        Me.lblParametro1.Name = "lblParametro1"
        Me.lblParametro1.Size = New System.Drawing.Size(91, 13)
        Me.lblParametro1.TabIndex = 0
        Me.lblParametro1.Text = "Grasa de Butirosa"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(323, 196)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(323, 229)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 13
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmOrdeñes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 276)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.frameAnalisis)
        Me.Controls.Add(Me.numLitros)
        Me.Controls.Add(Me.lblLitros)
        Me.Controls.Add(Me.chkAnalisis)
        Me.Controls.Add(Me.cboNumeroLote)
        Me.Controls.Add(Me.lblMinutos)
        Me.Controls.Add(Me.numHora)
        Me.Controls.Add(Me.numMinutos)
        Me.Controls.Add(Me.dateFecha)
        Me.Controls.Add(Me.lblNumeroLote)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Name = "frmOrdeñes"
        Me.Text = "frmOrdeñes"
        CType(Me.numMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLitros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frameAnalisis.ResumeLayout(False)
        Me.frameAnalisis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblNumeroLote As Label
    Friend WithEvents dateFecha As DateTimePicker
    Friend WithEvents numMinutos As NumericUpDown
    Friend WithEvents numHora As NumericUpDown
    Friend WithEvents lblMinutos As Label
    Friend WithEvents cboNumeroLote As ComboBox
    Friend WithEvents chkAnalisis As CheckBox
    Friend WithEvents lblLitros As Label
    Friend WithEvents numLitros As NumericUpDown
    Friend WithEvents frameAnalisis As GroupBox
    Friend WithEvents lblParametro4 As Label
    Friend WithEvents lblParametro3 As Label
    Friend WithEvents txtParametro4 As TextBox
    Friend WithEvents txtParametro3 As TextBox
    Friend WithEvents txtParametro2 As TextBox
    Friend WithEvents txtParametro1 As TextBox
    Friend WithEvents lblParametro2 As Label
    Friend WithEvents lblParametro1 As Label
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdCancelar As Button
End Class
