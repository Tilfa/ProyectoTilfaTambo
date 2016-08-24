<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoAnimal
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
        Me.lblBuscarId = New System.Windows.Forms.Label()
        Me.txtBuscarId = New System.Windows.Forms.TextBox()
        Me.cmdVerificar = New System.Windows.Forms.Button()
        Me.frameDatos = New System.Windows.Forms.GroupBox()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.numPeso = New System.Windows.Forms.NumericUpDown()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.cmdQuitar = New System.Windows.Forms.Button()
        Me.imgAnimal = New System.Windows.Forms.PictureBox()
        Me.cmdAgregarFoto = New System.Windows.Forms.Button()
        Me.frameCria = New System.Windows.Forms.GroupBox()
        Me.dateIngresoCR = New System.Windows.Forms.DateTimePicker()
        Me.lvlFechaCR = New System.Windows.Forms.Label()
        Me.cboCria = New System.Windows.Forms.ComboBox()
        Me.lblCria = New System.Windows.Forms.Label()
        Me.frameVaca = New System.Windows.Forms.GroupBox()
        Me.lblFechaCambioEstado = New System.Windows.Forms.Label()
        Me.dateCambioEstado = New System.Windows.Forms.DateTimePicker()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.numCantidadPariciones = New System.Windows.Forms.NumericUpDown()
        Me.lvlCantidadPariciones = New System.Windows.Forms.Label()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtIdMadre = New System.Windows.Forms.TextBox()
        Me.txtIdPadre = New System.Windows.Forms.TextBox()
        Me.lblIdMadre = New System.Windows.Forms.Label()
        Me.lblIdPadre = New System.Windows.Forms.Label()
        Me.txtDenticion = New System.Windows.Forms.TextBox()
        Me.lblDenticion = New System.Windows.Forms.Label()
        Me.dateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.optHembra = New System.Windows.Forms.RadioButton()
        Me.optMacho = New System.Windows.Forms.RadioButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblVerificacion = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.chkCR = New System.Windows.Forms.CheckBox()
        Me.frameDatos.SuspendLayout()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frameCria.SuspendLayout()
        Me.frameVaca.SuspendLayout()
        CType(Me.numCantidadPariciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscarId
        '
        Me.lblBuscarId.AutoSize = True
        Me.lblBuscarId.Location = New System.Drawing.Point(34, 27)
        Me.lblBuscarId.Name = "lblBuscarId"
        Me.lblBuscarId.Size = New System.Drawing.Size(65, 13)
        Me.lblBuscarId.TabIndex = 0
        Me.lblBuscarId.Text = "Ingrese el Id"
        '
        'txtBuscarId
        '
        Me.txtBuscarId.Location = New System.Drawing.Point(127, 24)
        Me.txtBuscarId.Name = "txtBuscarId"
        Me.txtBuscarId.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarId.TabIndex = 1
        '
        'cmdVerificar
        '
        Me.cmdVerificar.Location = New System.Drawing.Point(252, 24)
        Me.cmdVerificar.Name = "cmdVerificar"
        Me.cmdVerificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdVerificar.TabIndex = 2
        Me.cmdVerificar.Text = "Verificar"
        Me.cmdVerificar.UseVisualStyleBackColor = True
        '
        'frameDatos
        '
        Me.frameDatos.Controls.Add(Me.lblKg)
        Me.frameDatos.Controls.Add(Me.numPeso)
        Me.frameDatos.Controls.Add(Me.lblPeso)
        Me.frameDatos.Controls.Add(Me.cmdQuitar)
        Me.frameDatos.Controls.Add(Me.imgAnimal)
        Me.frameDatos.Controls.Add(Me.cmdAgregarFoto)
        Me.frameDatos.Controls.Add(Me.frameCria)
        Me.frameDatos.Controls.Add(Me.frameVaca)
        Me.frameDatos.Controls.Add(Me.txtRaza)
        Me.frameDatos.Controls.Add(Me.lblRaza)
        Me.frameDatos.Controls.Add(Me.txtIdMadre)
        Me.frameDatos.Controls.Add(Me.txtIdPadre)
        Me.frameDatos.Controls.Add(Me.lblIdMadre)
        Me.frameDatos.Controls.Add(Me.lblIdPadre)
        Me.frameDatos.Controls.Add(Me.txtDenticion)
        Me.frameDatos.Controls.Add(Me.lblDenticion)
        Me.frameDatos.Controls.Add(Me.dateFechaNacimiento)
        Me.frameDatos.Controls.Add(Me.lblFechaNacimiento)
        Me.frameDatos.Controls.Add(Me.optHembra)
        Me.frameDatos.Controls.Add(Me.optMacho)
        Me.frameDatos.Controls.Add(Me.lblSexo)
        Me.frameDatos.Enabled = False
        Me.frameDatos.Location = New System.Drawing.Point(12, 53)
        Me.frameDatos.Name = "frameDatos"
        Me.frameDatos.Size = New System.Drawing.Size(668, 328)
        Me.frameDatos.TabIndex = 3
        Me.frameDatos.TabStop = False
        Me.frameDatos.Text = "Datos del animal"
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Location = New System.Drawing.Point(321, 145)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(20, 13)
        Me.lblKg.TabIndex = 19
        Me.lblKg.Text = "Kg"
        '
        'numPeso
        '
        Me.numPeso.DecimalPlaces = 2
        Me.numPeso.Increment = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.numPeso.Location = New System.Drawing.Point(258, 141)
        Me.numPeso.Name = "numPeso"
        Me.numPeso.Size = New System.Drawing.Size(57, 20)
        Me.numPeso.TabIndex = 18
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(217, 141)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 13)
        Me.lblPeso.TabIndex = 17
        Me.lblPeso.Text = "Peso:"
        '
        'cmdQuitar
        '
        Me.cmdQuitar.Location = New System.Drawing.Point(500, 292)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuitar.TabIndex = 16
        Me.cmdQuitar.Text = "Quitar Foto"
        Me.cmdQuitar.UseVisualStyleBackColor = True
        Me.cmdQuitar.Visible = False
        '
        'imgAnimal
        '
        Me.imgAnimal.Location = New System.Drawing.Point(406, 141)
        Me.imgAnimal.Name = "imgAnimal"
        Me.imgAnimal.Size = New System.Drawing.Size(255, 145)
        Me.imgAnimal.TabIndex = 15
        Me.imgAnimal.TabStop = False
        '
        'cmdAgregarFoto
        '
        Me.cmdAgregarFoto.Location = New System.Drawing.Point(156, 170)
        Me.cmdAgregarFoto.Name = "cmdAgregarFoto"
        Me.cmdAgregarFoto.Size = New System.Drawing.Size(84, 23)
        Me.cmdAgregarFoto.TabIndex = 14
        Me.cmdAgregarFoto.Text = "Agregar Foto"
        Me.cmdAgregarFoto.UseVisualStyleBackColor = True
        '
        'frameCria
        '
        Me.frameCria.Controls.Add(Me.chkCR)
        Me.frameCria.Controls.Add(Me.dateIngresoCR)
        Me.frameCria.Controls.Add(Me.lvlFechaCR)
        Me.frameCria.Controls.Add(Me.cboCria)
        Me.frameCria.Controls.Add(Me.lblCria)
        Me.frameCria.Location = New System.Drawing.Point(416, 19)
        Me.frameCria.Name = "frameCria"
        Me.frameCria.Size = New System.Drawing.Size(245, 111)
        Me.frameCria.TabIndex = 13
        Me.frameCria.TabStop = False
        Me.frameCria.Text = "Cria"
        Me.frameCria.Visible = False
        '
        'dateIngresoCR
        '
        Me.dateIngresoCR.Location = New System.Drawing.Point(12, 76)
        Me.dateIngresoCR.Name = "dateIngresoCR"
        Me.dateIngresoCR.Size = New System.Drawing.Size(200, 20)
        Me.dateIngresoCR.TabIndex = 5
        '
        'lvlFechaCR
        '
        Me.lvlFechaCR.AutoSize = True
        Me.lvlFechaCR.Location = New System.Drawing.Point(9, 60)
        Me.lvlFechaCR.Name = "lvlFechaCR"
        Me.lvlFechaCR.Size = New System.Drawing.Size(182, 13)
        Me.lvlFechaCR.TabIndex = 2
        Me.lvlFechaCR.Text = "Fecha de ingreso al campo de recria:"
        '
        'cboCria
        '
        Me.cboCria.FormattingEnabled = True
        Me.cboCria.Location = New System.Drawing.Point(73, 23)
        Me.cboCria.Name = "cboCria"
        Me.cboCria.Size = New System.Drawing.Size(121, 21)
        Me.cboCria.TabIndex = 1
        '
        'lblCria
        '
        Me.lblCria.AutoSize = True
        Me.lblCria.Location = New System.Drawing.Point(6, 26)
        Me.lblCria.Name = "lblCria"
        Me.lblCria.Size = New System.Drawing.Size(63, 13)
        Me.lblCria.TabIndex = 0
        Me.lblCria.Text = "Estado cria:"
        '
        'frameVaca
        '
        Me.frameVaca.Controls.Add(Me.lblFechaCambioEstado)
        Me.frameVaca.Controls.Add(Me.dateCambioEstado)
        Me.frameVaca.Controls.Add(Me.cboEstado)
        Me.frameVaca.Controls.Add(Me.lblEstado)
        Me.frameVaca.Controls.Add(Me.numCantidadPariciones)
        Me.frameVaca.Controls.Add(Me.lvlCantidadPariciones)
        Me.frameVaca.Location = New System.Drawing.Point(6, 199)
        Me.frameVaca.Name = "frameVaca"
        Me.frameVaca.Size = New System.Drawing.Size(361, 123)
        Me.frameVaca.TabIndex = 12
        Me.frameVaca.TabStop = False
        Me.frameVaca.Text = "Vaca"
        Me.frameVaca.Visible = False
        '
        'lblFechaCambioEstado
        '
        Me.lblFechaCambioEstado.AutoSize = True
        Me.lblFechaCambioEstado.Location = New System.Drawing.Point(6, 92)
        Me.lblFechaCambioEstado.Name = "lblFechaCambioEstado"
        Me.lblFechaCambioEstado.Size = New System.Drawing.Size(142, 13)
        Me.lblFechaCambioEstado.TabIndex = 14
        Me.lblFechaCambioEstado.Text = "Fecha de cambio de estado:"
        '
        'dateCambioEstado
        '
        Me.dateCambioEstado.Location = New System.Drawing.Point(150, 86)
        Me.dateCambioEstado.Name = "dateCambioEstado"
        Me.dateCambioEstado.Size = New System.Drawing.Size(200, 20)
        Me.dateCambioEstado.TabIndex = 13
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(58, 55)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 3
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(6, 58)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Estado:"
        '
        'numCantidadPariciones
        '
        Me.numCantidadPariciones.Location = New System.Drawing.Point(130, 28)
        Me.numCantidadPariciones.Name = "numCantidadPariciones"
        Me.numCantidadPariciones.Size = New System.Drawing.Size(50, 20)
        Me.numCantidadPariciones.TabIndex = 1
        '
        'lvlCantidadPariciones
        '
        Me.lvlCantidadPariciones.AutoSize = True
        Me.lvlCantidadPariciones.Location = New System.Drawing.Point(6, 30)
        Me.lvlCantidadPariciones.Name = "lvlCantidadPariciones"
        Me.lvlCantidadPariciones.Size = New System.Drawing.Size(118, 13)
        Me.lvlCantidadPariciones.TabIndex = 0
        Me.lvlCantidadPariciones.Text = "Cantidad de pariciones:"
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(48, 138)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(100, 20)
        Me.txtRaza.TabIndex = 11
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(7, 141)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(35, 13)
        Me.lblRaza.TabIndex = 10
        Me.lblRaza.Text = "Raza:"
        '
        'txtIdMadre
        '
        Me.txtIdMadre.Location = New System.Drawing.Point(298, 110)
        Me.txtIdMadre.Name = "txtIdMadre"
        Me.txtIdMadre.Size = New System.Drawing.Size(100, 20)
        Me.txtIdMadre.TabIndex = 9
        '
        'txtIdPadre
        '
        Me.txtIdPadre.Location = New System.Drawing.Point(90, 110)
        Me.txtIdPadre.Name = "txtIdPadre"
        Me.txtIdPadre.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPadre.TabIndex = 4
        '
        'lblIdMadre
        '
        Me.lblIdMadre.AutoSize = True
        Me.lblIdMadre.Location = New System.Drawing.Point(217, 113)
        Me.lblIdMadre.Name = "lblIdMadre"
        Me.lblIdMadre.Size = New System.Drawing.Size(78, 13)
        Me.lblIdMadre.TabIndex = 8
        Me.lblIdMadre.Text = "Id de la Madre:"
        '
        'lblIdPadre
        '
        Me.lblIdPadre.AutoSize = True
        Me.lblIdPadre.Location = New System.Drawing.Point(7, 113)
        Me.lblIdPadre.Name = "lblIdPadre"
        Me.lblIdPadre.Size = New System.Drawing.Size(67, 13)
        Me.lblIdPadre.TabIndex = 7
        Me.lblIdPadre.Text = "Id del Padre:"
        '
        'txtDenticion
        '
        Me.txtDenticion.Location = New System.Drawing.Point(68, 84)
        Me.txtDenticion.Name = "txtDenticion"
        Me.txtDenticion.Size = New System.Drawing.Size(100, 20)
        Me.txtDenticion.TabIndex = 6
        '
        'lblDenticion
        '
        Me.lblDenticion.AutoSize = True
        Me.lblDenticion.Location = New System.Drawing.Point(7, 87)
        Me.lblDenticion.Name = "lblDenticion"
        Me.lblDenticion.Size = New System.Drawing.Size(55, 13)
        Me.lblDenticion.TabIndex = 5
        Me.lblDenticion.Text = "Denticion:"
        '
        'dateFechaNacimiento
        '
        Me.dateFechaNacimiento.Location = New System.Drawing.Point(125, 54)
        Me.dateFechaNacimiento.Name = "dateFechaNacimiento"
        Me.dateFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dateFechaNacimiento.TabIndex = 4
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(7, 60)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNacimiento.TabIndex = 3
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'optHembra
        '
        Me.optHembra.AutoSize = True
        Me.optHembra.Location = New System.Drawing.Point(115, 31)
        Me.optHembra.Name = "optHembra"
        Me.optHembra.Size = New System.Drawing.Size(62, 17)
        Me.optHembra.TabIndex = 2
        Me.optHembra.Text = "Hembra"
        Me.optHembra.UseVisualStyleBackColor = True
        '
        'optMacho
        '
        Me.optMacho.AutoSize = True
        Me.optMacho.Checked = True
        Me.optMacho.Location = New System.Drawing.Point(56, 31)
        Me.optMacho.Name = "optMacho"
        Me.optMacho.Size = New System.Drawing.Size(58, 17)
        Me.optMacho.TabIndex = 1
        Me.optMacho.TabStop = True
        Me.optMacho.Text = "Macho"
        Me.optMacho.UseVisualStyleBackColor = True
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(7, 31)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 0
        Me.lblSexo.Text = "Sexo:"
        '
        'lblVerificacion
        '
        Me.lblVerificacion.AutoSize = True
        Me.lblVerificacion.ForeColor = System.Drawing.Color.Green
        Me.lblVerificacion.Location = New System.Drawing.Point(333, 27)
        Me.lblVerificacion.Name = "lblVerificacion"
        Me.lblVerificacion.Size = New System.Drawing.Size(51, 13)
        Me.lblVerificacion.TabIndex = 4
        Me.lblVerificacion.Text = "Conexion"
        Me.lblVerificacion.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(501, 387)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(598, 387)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'chkCR
        '
        Me.chkCR.AutoSize = True
        Me.chkCR.Location = New System.Drawing.Point(197, 59)
        Me.chkCR.Name = "chkCR"
        Me.chkCR.Size = New System.Drawing.Size(35, 17)
        Me.chkCR.TabIndex = 6
        Me.chkCR.Text = "Si"
        Me.chkCR.UseVisualStyleBackColor = True
        '
        'frmNuevoAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 422)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblVerificacion)
        Me.Controls.Add(Me.frameDatos)
        Me.Controls.Add(Me.cmdVerificar)
        Me.Controls.Add(Me.txtBuscarId)
        Me.Controls.Add(Me.lblBuscarId)
        Me.Name = "frmNuevoAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNuevoAnimal"
        Me.frameDatos.ResumeLayout(False)
        Me.frameDatos.PerformLayout()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frameCria.ResumeLayout(False)
        Me.frameCria.PerformLayout()
        Me.frameVaca.ResumeLayout(False)
        Me.frameVaca.PerformLayout()
        CType(Me.numCantidadPariciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscarId As System.Windows.Forms.Label
    Friend WithEvents txtBuscarId As System.Windows.Forms.TextBox
    Friend WithEvents cmdVerificar As System.Windows.Forms.Button
    Friend WithEvents frameDatos As System.Windows.Forms.GroupBox
    Friend WithEvents frameCria As System.Windows.Forms.GroupBox
    Friend WithEvents dateIngresoCR As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvlFechaCR As System.Windows.Forms.Label
    Friend WithEvents cboCria As System.Windows.Forms.ComboBox
    Friend WithEvents lblCria As System.Windows.Forms.Label
    Friend WithEvents frameVaca As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaCambioEstado As System.Windows.Forms.Label
    Friend WithEvents dateCambioEstado As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents numCantidadPariciones As System.Windows.Forms.NumericUpDown
    Friend WithEvents lvlCantidadPariciones As System.Windows.Forms.Label
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents txtIdMadre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdPadre As System.Windows.Forms.TextBox
    Friend WithEvents lblIdMadre As System.Windows.Forms.Label
    Friend WithEvents lblIdPadre As System.Windows.Forms.Label
    Friend WithEvents txtDenticion As System.Windows.Forms.TextBox
    Friend WithEvents lblDenticion As System.Windows.Forms.Label
    Friend WithEvents dateFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents optHembra As System.Windows.Forms.RadioButton
    Friend WithEvents optMacho As System.Windows.Forms.RadioButton
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblVerificacion As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarFoto As System.Windows.Forms.Button
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents imgAnimal As System.Windows.Forms.PictureBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents numPeso As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkCR As System.Windows.Forms.CheckBox
End Class
