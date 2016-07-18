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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblDenticion = New System.Windows.Forms.Label()
        Me.lblIDPadre = New System.Windows.Forms.Label()
        Me.lblIDMadre = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtNumeroCarabana = New System.Windows.Forms.TextBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtIDMadre = New System.Windows.Forms.TextBox()
        Me.txtIDPadre = New System.Windows.Forms.TextBox()
        Me.optMacho = New System.Windows.Forms.RadioButton()
        Me.optHembra = New System.Windows.Forms.RadioButton()
        Me.dateNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.frameSexo = New System.Windows.Forms.GroupBox()
        Me.frameVaca = New System.Windows.Forms.GroupBox()
        Me.numCantidadDePariciones = New System.Windows.Forms.NumericUpDown()
        Me.cboLote = New System.Windows.Forms.ComboBox()
        Me.datePrimerParicion = New System.Windows.Forms.DateTimePicker()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.chkSi = New System.Windows.Forms.CheckBox()
        Me.lblPrimeraParicion = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblPariciones = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.frameSexo.SuspendLayout()
        Me.frameVaca.SuspendLayout()
        CType(Me.numCantidadDePariciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(13, 13)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(107, 13)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Numero de carabana"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(13, 38)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(106, 13)
        Me.lblFechaNacimiento.TabIndex = 1
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento"
        '
        'lblDenticion
        '
        Me.lblDenticion.AutoSize = True
        Me.lblDenticion.Location = New System.Drawing.Point(13, 63)
        Me.lblDenticion.Name = "lblDenticion"
        Me.lblDenticion.Size = New System.Drawing.Size(52, 13)
        Me.lblDenticion.TabIndex = 2
        Me.lblDenticion.Text = "Denticion"
        '
        'lblIDPadre
        '
        Me.lblIDPadre.AutoSize = True
        Me.lblIDPadre.Location = New System.Drawing.Point(13, 88)
        Me.lblIDPadre.Name = "lblIDPadre"
        Me.lblIDPadre.Size = New System.Drawing.Size(154, 13)
        Me.lblIDPadre.TabIndex = 3
        Me.lblIDPadre.Text = "Numero de carabana del padre"
        '
        'lblIDMadre
        '
        Me.lblIDMadre.AutoSize = True
        Me.lblIDMadre.Location = New System.Drawing.Point(13, 113)
        Me.lblIDMadre.Name = "lblIDMadre"
        Me.lblIDMadre.Size = New System.Drawing.Size(165, 13)
        Me.lblIDMadre.TabIndex = 4
        Me.lblIDMadre.Text = "Numero de carabana de la madre"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(13, 141)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(32, 13)
        Me.lblRaza.TabIndex = 5
        Me.lblRaza.Text = "Raza"
        '
        'txtNumeroCarabana
        '
        Me.txtNumeroCarabana.Location = New System.Drawing.Point(135, 10)
        Me.txtNumeroCarabana.Name = "txtNumeroCarabana"
        Me.txtNumeroCarabana.Size = New System.Drawing.Size(81, 20)
        Me.txtNumeroCarabana.TabIndex = 7
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(51, 138)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(100, 20)
        Me.txtRaza.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(78, 60)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 10
        '
        'txtIDMadre
        '
        Me.txtIDMadre.Location = New System.Drawing.Point(181, 110)
        Me.txtIDMadre.Name = "txtIDMadre"
        Me.txtIDMadre.Size = New System.Drawing.Size(100, 20)
        Me.txtIDMadre.TabIndex = 11
        '
        'txtIDPadre
        '
        Me.txtIDPadre.Location = New System.Drawing.Point(173, 85)
        Me.txtIDPadre.Name = "txtIDPadre"
        Me.txtIDPadre.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPadre.TabIndex = 12
        '
        'optMacho
        '
        Me.optMacho.AutoSize = True
        Me.optMacho.Location = New System.Drawing.Point(6, 19)
        Me.optMacho.Name = "optMacho"
        Me.optMacho.Size = New System.Drawing.Size(58, 17)
        Me.optMacho.TabIndex = 13
        Me.optMacho.TabStop = True
        Me.optMacho.Text = "Macho"
        Me.optMacho.UseVisualStyleBackColor = True
        '
        'optHembra
        '
        Me.optHembra.AutoSize = True
        Me.optHembra.Location = New System.Drawing.Point(90, 19)
        Me.optHembra.Name = "optHembra"
        Me.optHembra.Size = New System.Drawing.Size(62, 17)
        Me.optHembra.TabIndex = 14
        Me.optHembra.TabStop = True
        Me.optHembra.Text = "Hembra"
        Me.optHembra.UseVisualStyleBackColor = True
        '
        'dateNacimiento
        '
        Me.dateNacimiento.Location = New System.Drawing.Point(125, 36)
        Me.dateNacimiento.Name = "dateNacimiento"
        Me.dateNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dateNacimiento.TabIndex = 15
        '
        'frameSexo
        '
        Me.frameSexo.Controls.Add(Me.optMacho)
        Me.frameSexo.Controls.Add(Me.optHembra)
        Me.frameSexo.Location = New System.Drawing.Point(15, 164)
        Me.frameSexo.Name = "frameSexo"
        Me.frameSexo.Size = New System.Drawing.Size(163, 49)
        Me.frameSexo.TabIndex = 16
        Me.frameSexo.TabStop = False
        Me.frameSexo.Text = "Sexo"
        '
        'frameVaca
        '
        Me.frameVaca.Controls.Add(Me.numCantidadDePariciones)
        Me.frameVaca.Controls.Add(Me.cboLote)
        Me.frameVaca.Controls.Add(Me.datePrimerParicion)
        Me.frameVaca.Controls.Add(Me.cboEstado)
        Me.frameVaca.Controls.Add(Me.chkSi)
        Me.frameVaca.Controls.Add(Me.lblPrimeraParicion)
        Me.frameVaca.Controls.Add(Me.lblLote)
        Me.frameVaca.Controls.Add(Me.lblPariciones)
        Me.frameVaca.Controls.Add(Me.lblEstado)
        Me.frameVaca.Location = New System.Drawing.Point(16, 219)
        Me.frameVaca.Name = "frameVaca"
        Me.frameVaca.Size = New System.Drawing.Size(350, 164)
        Me.frameVaca.TabIndex = 17
        Me.frameVaca.TabStop = False
        Me.frameVaca.Text = "Vaca"
        Me.frameVaca.Visible = False
        '
        'numCantidadDePariciones
        '
        Me.numCantidadDePariciones.Location = New System.Drawing.Point(131, 55)
        Me.numCantidadDePariciones.Name = "numCantidadDePariciones"
        Me.numCantidadDePariciones.Size = New System.Drawing.Size(39, 20)
        Me.numCantidadDePariciones.TabIndex = 8
        '
        'cboLote
        '
        Me.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.Location = New System.Drawing.Point(144, 112)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(121, 21)
        Me.cboLote.TabIndex = 7
        '
        'datePrimerParicion
        '
        Me.datePrimerParicion.Location = New System.Drawing.Point(130, 81)
        Me.datePrimerParicion.Name = "datePrimerParicion"
        Me.datePrimerParicion.Size = New System.Drawing.Size(195, 20)
        Me.datePrimerParicion.TabIndex = 6
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Seleccione un item", "Pre-parto", "Seca", "En espera", "En servicio", "En espera"})
        Me.cboEstado.Location = New System.Drawing.Point(62, 24)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 5
        '
        'chkSi
        '
        Me.chkSi.AutoSize = True
        Me.chkSi.Location = New System.Drawing.Point(89, 114)
        Me.chkSi.Name = "chkSi"
        Me.chkSi.Size = New System.Drawing.Size(35, 17)
        Me.chkSi.TabIndex = 4
        Me.chkSi.Text = "Si"
        Me.chkSi.UseVisualStyleBackColor = True
        '
        'lblPrimeraParicion
        '
        Me.lblPrimeraParicion.AutoSize = True
        Me.lblPrimeraParicion.Location = New System.Drawing.Point(10, 87)
        Me.lblPrimeraParicion.Name = "lblPrimeraParicion"
        Me.lblPrimeraParicion.Size = New System.Drawing.Size(114, 13)
        Me.lblPrimeraParicion.TabIndex = 3
        Me.lblPrimeraParicion.Text = "Fecha primera paricion"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(10, 115)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(68, 13)
        Me.lblLote.TabIndex = 2
        Me.lblLote.Text = "Asignar lote?"
        '
        'lblPariciones
        '
        Me.lblPariciones.AutoSize = True
        Me.lblPariciones.Location = New System.Drawing.Point(10, 56)
        Me.lblPariciones.Name = "lblPariciones"
        Me.lblPariciones.Size = New System.Drawing.Size(115, 13)
        Me.lblPariciones.TabIndex = 1
        Me.lblPariciones.Text = "Cantidad de pariciones"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(10, 27)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 0
        Me.lblEstado.Text = "Estado"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(29, 388)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 18
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(124, 388)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 19
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmNuevoAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 423)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.frameVaca)
        Me.Controls.Add(Me.frameSexo)
        Me.Controls.Add(Me.dateNacimiento)
        Me.Controls.Add(Me.txtIDPadre)
        Me.Controls.Add(Me.txtIDMadre)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtRaza)
        Me.Controls.Add(Me.txtNumeroCarabana)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblIDMadre)
        Me.Controls.Add(Me.lblIDPadre)
        Me.Controls.Add(Me.lblDenticion)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "frmNuevoAnimal"
        Me.Text = "Nuevo animal"
        Me.frameSexo.ResumeLayout(False)
        Me.frameSexo.PerformLayout()
        Me.frameVaca.ResumeLayout(False)
        Me.frameVaca.PerformLayout()
        CType(Me.numCantidadDePariciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblDenticion As Label
    Friend WithEvents lblIDPadre As Label
    Friend WithEvents lblIDMadre As Label
    Friend WithEvents lblRaza As Label
    Friend WithEvents txtNumeroCarabana As TextBox
    Friend WithEvents txtRaza As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtIDMadre As TextBox
    Friend WithEvents txtIDPadre As TextBox
    Friend WithEvents optMacho As RadioButton
    Friend WithEvents optHembra As RadioButton
    Friend WithEvents dateNacimiento As DateTimePicker
    Friend WithEvents frameSexo As GroupBox
    Friend WithEvents frameVaca As GroupBox
    Friend WithEvents datePrimerParicion As DateTimePicker
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents chkSi As CheckBox
    Friend WithEvents lblPrimeraParicion As Label
    Friend WithEvents lblLote As Label
    Friend WithEvents lblPariciones As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cboLote As ComboBox
    Friend WithEvents numCantidadDePariciones As NumericUpDown
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdCancelar As Button
End Class
