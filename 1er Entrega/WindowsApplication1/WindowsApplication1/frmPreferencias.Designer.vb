<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferencias
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
        Me.txtNomcoop = New System.Windows.Forms.TextBox()
        Me.txtNomTam = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.lblNombreCooperativa = New System.Windows.Forms.Label()
        Me.lblNombreTambo = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNomcoop
        '
        Me.txtNomcoop.Location = New System.Drawing.Point(182, 24)
        Me.txtNomcoop.Name = "txtNomcoop"
        Me.txtNomcoop.Size = New System.Drawing.Size(100, 20)
        Me.txtNomcoop.TabIndex = 0
        '
        'txtNomTam
        '
        Me.txtNomTam.Location = New System.Drawing.Point(182, 57)
        Me.txtNomTam.Name = "txtNomTam"
        Me.txtNomTam.Size = New System.Drawing.Size(100, 20)
        Me.txtNomTam.TabIndex = 1
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(182, 90)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(100, 20)
        Me.txtUbicacion.TabIndex = 2
        '
        'lblNombreCooperativa
        '
        Me.lblNombreCooperativa.AutoSize = True
        Me.lblNombreCooperativa.Location = New System.Drawing.Point(27, 27)
        Me.lblNombreCooperativa.Name = "lblNombreCooperativa"
        Me.lblNombreCooperativa.Size = New System.Drawing.Size(129, 13)
        Me.lblNombreCooperativa.TabIndex = 3
        Me.lblNombreCooperativa.Text = "Nombre de la cooperativa"
        '
        'lblNombreTambo
        '
        Me.lblNombreTambo.AutoSize = True
        Me.lblNombreTambo.Location = New System.Drawing.Point(27, 60)
        Me.lblNombreTambo.Name = "lblNombreTambo"
        Me.lblNombreTambo.Size = New System.Drawing.Size(87, 13)
        Me.lblNombreTambo.TabIndex = 4
        Me.lblNombreTambo.Text = "Nomre del tambo"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(27, 93)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(55, 13)
        Me.lblUbicacion.TabIndex = 5
        Me.lblUbicacion.Text = "Ubicacion"
        '
        'frmPreferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 138)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.lblNombreTambo)
        Me.Controls.Add(Me.lblNombreCooperativa)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.txtNomTam)
        Me.Controls.Add(Me.txtNomcoop)
        Me.Name = "frmPreferencias"
        Me.Text = "Preferencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNomcoop As TextBox
    Friend WithEvents txtNomTam As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents lblNombreCooperativa As Label
    Friend WithEvents lblNombreTambo As Label
    Friend WithEvents lblUbicacion As Label
End Class
