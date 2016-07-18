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
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.menuInicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPreferencias = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfiguraciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuParametros = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAnimal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNuevoAnimal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuListadoA = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNuevoLote = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuListadoL = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOrdenes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPartos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuControlesSalud = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInicio, Me.menuOpciones, Me.menuAnimal, Me.menuEventos})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(737, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'menuInicio
        '
        Me.menuInicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogin, Me.menuSalir})
        Me.menuInicio.Name = "menuInicio"
        Me.menuInicio.Size = New System.Drawing.Size(48, 20)
        Me.menuInicio.Text = "Inicio"
        '
        'menuLogin
        '
        Me.menuLogin.Name = "menuLogin"
        Me.menuLogin.Size = New System.Drawing.Size(104, 22)
        Me.menuLogin.Text = "Login"
        '
        'menuSalir
        '
        Me.menuSalir.Name = "menuSalir"
        Me.menuSalir.Size = New System.Drawing.Size(104, 22)
        Me.menuSalir.Text = "Salir"
        '
        'menuOpciones
        '
        Me.menuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPreferencias, Me.menuConfiguraciones, Me.menuParametros, Me.menuExportar})
        Me.menuOpciones.Name = "menuOpciones"
        Me.menuOpciones.Size = New System.Drawing.Size(69, 20)
        Me.menuOpciones.Text = "Opciones"
        '
        'menuPreferencias
        '
        Me.menuPreferencias.Name = "menuPreferencias"
        Me.menuPreferencias.Size = New System.Drawing.Size(161, 22)
        Me.menuPreferencias.Text = "Preferencias"
        '
        'menuConfiguraciones
        '
        Me.menuConfiguraciones.Name = "menuConfiguraciones"
        Me.menuConfiguraciones.Size = New System.Drawing.Size(161, 22)
        Me.menuConfiguraciones.Text = "Configuraciones"
        '
        'menuParametros
        '
        Me.menuParametros.Name = "menuParametros"
        Me.menuParametros.Size = New System.Drawing.Size(161, 22)
        Me.menuParametros.Text = "Parametros"
        '
        'menuExportar
        '
        Me.menuExportar.Name = "menuExportar"
        Me.menuExportar.Size = New System.Drawing.Size(161, 22)
        Me.menuExportar.Text = "Exportar datos"
        '
        'menuAnimal
        '
        Me.menuAnimal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNuevoAnimal, Me.menuListadoA, Me.menuNuevoLote, Me.menuListadoL})
        Me.menuAnimal.Name = "menuAnimal"
        Me.menuAnimal.Size = New System.Drawing.Size(57, 20)
        Me.menuAnimal.Text = "Animal"
        '
        'menuNuevoAnimal
        '
        Me.menuNuevoAnimal.Name = "menuNuevoAnimal"
        Me.menuNuevoAnimal.Size = New System.Drawing.Size(191, 22)
        Me.menuNuevoAnimal.Text = "Ingresar nuevo animal"
        '
        'menuListadoA
        '
        Me.menuListadoA.Name = "menuListadoA"
        Me.menuListadoA.Size = New System.Drawing.Size(191, 22)
        Me.menuListadoA.Text = "Listado de animales"
        '
        'menuNuevoLote
        '
        Me.menuNuevoLote.Name = "menuNuevoLote"
        Me.menuNuevoLote.Size = New System.Drawing.Size(191, 22)
        Me.menuNuevoLote.Text = "Crear nuevo lote"
        '
        'menuListadoL
        '
        Me.menuListadoL.Name = "menuListadoL"
        Me.menuListadoL.Size = New System.Drawing.Size(191, 22)
        Me.menuListadoL.Text = "Listado de lotes"
        '
        'menuEventos
        '
        Me.menuEventos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOrdenes, Me.menuPartos, Me.menuControlesSalud})
        Me.menuEventos.Name = "menuEventos"
        Me.menuEventos.Size = New System.Drawing.Size(60, 20)
        Me.menuEventos.Text = "Eventos"
        '
        'menuOrdenes
        '
        Me.menuOrdenes.Name = "menuOrdenes"
        Me.menuOrdenes.Size = New System.Drawing.Size(172, 22)
        Me.menuOrdenes.Text = "Ordeñes"
        '
        'menuPartos
        '
        Me.menuPartos.Name = "menuPartos"
        Me.menuPartos.Size = New System.Drawing.Size(172, 22)
        Me.menuPartos.Text = "Partos"
        '
        'menuControlesSalud
        '
        Me.menuControlesSalud.Name = "menuControlesSalud"
        Me.menuControlesSalud.Size = New System.Drawing.Size(172, 22)
        Me.menuControlesSalud.Text = "Controles de salud"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 459)
        Me.Controls.Add(Me.menuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents menuInicio As ToolStripMenuItem
    Friend WithEvents menuLogin As ToolStripMenuItem
    Friend WithEvents menuSalir As ToolStripMenuItem
    Friend WithEvents menuOpciones As ToolStripMenuItem
    Friend WithEvents menuPreferencias As ToolStripMenuItem
    Friend WithEvents menuConfiguraciones As ToolStripMenuItem
    Friend WithEvents menuExportar As ToolStripMenuItem
    Friend WithEvents menuParametros As ToolStripMenuItem
    Friend WithEvents menuAnimal As ToolStripMenuItem
    Friend WithEvents menuNuevoAnimal As ToolStripMenuItem
    Friend WithEvents menuListadoA As ToolStripMenuItem
    Friend WithEvents menuListadoL As ToolStripMenuItem
    Friend WithEvents menuNuevoLote As ToolStripMenuItem
    Friend WithEvents menuEventos As ToolStripMenuItem
    Friend WithEvents menuControlesSalud As ToolStripMenuItem
    Friend WithEvents menuOrdenes As ToolStripMenuItem
    Friend WithEvents menuPartos As ToolStripMenuItem
End Class
