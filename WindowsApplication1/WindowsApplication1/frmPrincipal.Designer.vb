<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarCesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirUnAnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUnAnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeAnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUnLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUnLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeLotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirUnOrdeñeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUnOrdeñeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarOrdeñesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarControlMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarControlesMedicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarEstadoMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramarMontaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarMontaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMontasProgramadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeAviso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IrA = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pnlNotificaciones = New System.Windows.Forms.Panel()
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimalTableAdapter = New WindowsApplication1.DataSet1TableAdapters.animalTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotificaciones.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AnimalesToolStripMenuItem, Me.EventosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(819, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionToolStripMenuItem, Me.CerrarCesionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'CerrarCesionToolStripMenuItem
        '
        Me.CerrarCesionToolStripMenuItem.Name = "CerrarCesionToolStripMenuItem"
        Me.CerrarCesionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CerrarCesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AnimalesToolStripMenuItem
        '
        Me.AnimalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirUnAnimalToolStripMenuItem, Me.ModificarUnAnimalToolStripMenuItem, Me.ListaDeAnimalesToolStripMenuItem, Me.CrearUnLoteToolStripMenuItem, Me.ModificarUnLoteToolStripMenuItem, Me.ListaDeLotesToolStripMenuItem})
        Me.AnimalesToolStripMenuItem.Name = "AnimalesToolStripMenuItem"
        Me.AnimalesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AnimalesToolStripMenuItem.Text = "Animales"
        '
        'AñadirUnAnimalToolStripMenuItem
        '
        Me.AñadirUnAnimalToolStripMenuItem.Name = "AñadirUnAnimalToolStripMenuItem"
        Me.AñadirUnAnimalToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AñadirUnAnimalToolStripMenuItem.Text = "Añadir un animal"
        '
        'ModificarUnAnimalToolStripMenuItem
        '
        Me.ModificarUnAnimalToolStripMenuItem.Name = "ModificarUnAnimalToolStripMenuItem"
        Me.ModificarUnAnimalToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ModificarUnAnimalToolStripMenuItem.Text = "Modificar un animal"
        '
        'ListaDeAnimalesToolStripMenuItem
        '
        Me.ListaDeAnimalesToolStripMenuItem.Name = "ListaDeAnimalesToolStripMenuItem"
        Me.ListaDeAnimalesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListaDeAnimalesToolStripMenuItem.Text = "Lista de animales"
        '
        'CrearUnLoteToolStripMenuItem
        '
        Me.CrearUnLoteToolStripMenuItem.Name = "CrearUnLoteToolStripMenuItem"
        Me.CrearUnLoteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CrearUnLoteToolStripMenuItem.Text = "Crear un lote"
        '
        'ModificarUnLoteToolStripMenuItem
        '
        Me.ModificarUnLoteToolStripMenuItem.Name = "ModificarUnLoteToolStripMenuItem"
        Me.ModificarUnLoteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ModificarUnLoteToolStripMenuItem.Text = "Modificar un lote"
        '
        'ListaDeLotesToolStripMenuItem
        '
        Me.ListaDeLotesToolStripMenuItem.Name = "ListaDeLotesToolStripMenuItem"
        Me.ListaDeLotesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListaDeLotesToolStripMenuItem.Text = "Lista de lotes"
        '
        'EventosToolStripMenuItem
        '
        Me.EventosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirUnOrdeñeToolStripMenuItem, Me.ModificarUnOrdeñeToolStripMenuItem, Me.ListarOrdeñesToolStripMenuItem, Me.IngresarControlMedicoToolStripMenuItem, Me.ListarControlesMedicosToolStripMenuItem, Me.ActualizarEstadoMedicoToolStripMenuItem, Me.ProgramarMontaToolStripMenuItem, Me.EditarMontaToolStripMenuItem, Me.ListarMontasProgramadasToolStripMenuItem})
        Me.EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        Me.EventosToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.EventosToolStripMenuItem.Text = "Eventos"
        '
        'AñadirUnOrdeñeToolStripMenuItem
        '
        Me.AñadirUnOrdeñeToolStripMenuItem.Name = "AñadirUnOrdeñeToolStripMenuItem"
        Me.AñadirUnOrdeñeToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AñadirUnOrdeñeToolStripMenuItem.Text = "Añadir un ordeñe"
        '
        'ModificarUnOrdeñeToolStripMenuItem
        '
        Me.ModificarUnOrdeñeToolStripMenuItem.Name = "ModificarUnOrdeñeToolStripMenuItem"
        Me.ModificarUnOrdeñeToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ModificarUnOrdeñeToolStripMenuItem.Text = "Modificar un ordeñe"
        '
        'ListarOrdeñesToolStripMenuItem
        '
        Me.ListarOrdeñesToolStripMenuItem.Name = "ListarOrdeñesToolStripMenuItem"
        Me.ListarOrdeñesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ListarOrdeñesToolStripMenuItem.Text = "Listar ordeñes"
        '
        'IngresarControlMedicoToolStripMenuItem
        '
        Me.IngresarControlMedicoToolStripMenuItem.Name = "IngresarControlMedicoToolStripMenuItem"
        Me.IngresarControlMedicoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IngresarControlMedicoToolStripMenuItem.Text = "Ingresar control medico"
        '
        'ListarControlesMedicosToolStripMenuItem
        '
        Me.ListarControlesMedicosToolStripMenuItem.Name = "ListarControlesMedicosToolStripMenuItem"
        Me.ListarControlesMedicosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ListarControlesMedicosToolStripMenuItem.Text = "Listar controles medicos"
        '
        'ActualizarEstadoMedicoToolStripMenuItem
        '
        Me.ActualizarEstadoMedicoToolStripMenuItem.Name = "ActualizarEstadoMedicoToolStripMenuItem"
        Me.ActualizarEstadoMedicoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ActualizarEstadoMedicoToolStripMenuItem.Text = "Actualizar estado medico"
        '
        'ProgramarMontaToolStripMenuItem
        '
        Me.ProgramarMontaToolStripMenuItem.Name = "ProgramarMontaToolStripMenuItem"
        Me.ProgramarMontaToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ProgramarMontaToolStripMenuItem.Text = "Programar monta"
        '
        'EditarMontaToolStripMenuItem
        '
        Me.EditarMontaToolStripMenuItem.Name = "EditarMontaToolStripMenuItem"
        Me.EditarMontaToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.EditarMontaToolStripMenuItem.Text = "Editar monta"
        '
        'ListarMontasProgramadasToolStripMenuItem
        '
        Me.ListarMontasProgramadasToolStripMenuItem.Name = "ListarMontasProgramadasToolStripMenuItem"
        Me.ListarMontasProgramadasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ListarMontasProgramadasToolStripMenuItem.Text = "Listar montas programadas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Evento, Me.FechaDeAviso, Me.Animal, Me.IrA})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Evento
        '
        Me.Evento.HeaderText = "Evento"
        Me.Evento.Name = "Evento"
        '
        'FechaDeAviso
        '
        Me.FechaDeAviso.HeaderText = "Fecha de aviso"
        Me.FechaDeAviso.Name = "FechaDeAviso"
        '
        'Animal
        '
        Me.Animal.HeaderText = "Animal"
        Me.Animal.Name = "Animal"
        '
        'IrA
        '
        Me.IrA.HeaderText = "Ir a"
        Me.IrA.Name = "IrA"
        Me.IrA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IrA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IrA.Text = "Ir a ..."
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(3, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(147, 25)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Notificaciones"
        '
        'pnlNotificaciones
        '
        Me.pnlNotificaciones.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlNotificaciones.Controls.Add(Me.DataGridView1)
        Me.pnlNotificaciones.Controls.Add(Me.label1)
        Me.pnlNotificaciones.Location = New System.Drawing.Point(12, 40)
        Me.pnlNotificaciones.Name = "pnlNotificaciones"
        Me.pnlNotificaciones.Size = New System.Drawing.Size(464, 199)
        Me.pnlNotificaciones.TabIndex = 7
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1BindingSource1
        '
        Me.DataSet1BindingSource1.DataSource = Me.DataSet1
        Me.DataSet1BindingSource1.Position = 0
        '
        'AnimalBindingSource
        '
        Me.AnimalBindingSource.DataMember = "animal"
        Me.AnimalBindingSource.DataSource = Me.DataSet1BindingSource
        '
        'AnimalTableAdapter
        '
        Me.AnimalTableAdapter.ClearBeforeFill = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 481)
        Me.Controls.Add(Me.pnlNotificaciones)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotificaciones.ResumeLayout(False)
        Me.pnlNotificaciones.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarCesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirUnAnimalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarUnAnimalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeAnimalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearUnLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarUnLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeLotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirUnOrdeñeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarUnOrdeñeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarOrdeñesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarControlMedicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarControlesMedicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Evento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDeAviso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Animal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IrA As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents pnlNotificaciones As System.Windows.Forms.Panel
    Friend WithEvents ActualizarEstadoMedicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramarMontaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarMontaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarMontasProgramadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AnimalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimalTableAdapter As WindowsApplication1.DataSet1TableAdapters.animalTableAdapter
End Class
