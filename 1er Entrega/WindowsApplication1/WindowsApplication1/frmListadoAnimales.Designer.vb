<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAnimales
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
        Me.lstAnimales = New System.Windows.Forms.ListBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.chkSexo = New System.Windows.Forms.CheckBox()
        Me.chkEdad = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.chkCampoRecria = New System.Windows.Forms.CheckBox()
        Me.chkEstadoSalud = New System.Windows.Forms.CheckBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAnimales
        '
        Me.lstAnimales.FormattingEnabled = True
        Me.lstAnimales.Location = New System.Drawing.Point(26, 66)
        Me.lstAnimales.Name = "lstAnimales"
        Me.lstAnimales.Size = New System.Drawing.Size(456, 264)
        Me.lstAnimales.TabIndex = 0
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(23, 9)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(53, 13)
        Me.lblFiltro.TabIndex = 1
        Me.lblFiltro.Text = "Filtrar por:"
        '
        'chkSexo
        '
        Me.chkSexo.AutoSize = True
        Me.chkSexo.Location = New System.Drawing.Point(83, 9)
        Me.chkSexo.Name = "chkSexo"
        Me.chkSexo.Size = New System.Drawing.Size(50, 17)
        Me.chkSexo.TabIndex = 2
        Me.chkSexo.Text = "Sexo"
        Me.chkSexo.UseVisualStyleBackColor = True
        '
        'chkEdad
        '
        Me.chkEdad.AutoSize = True
        Me.chkEdad.Location = New System.Drawing.Point(139, 9)
        Me.chkEdad.Name = "chkEdad"
        Me.chkEdad.Size = New System.Drawing.Size(51, 17)
        Me.chkEdad.TabIndex = 3
        Me.chkEdad.Text = "Edad"
        Me.chkEdad.UseVisualStyleBackColor = True
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(197, 9)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(92, 17)
        Me.chkEstado.TabIndex = 4
        Me.chkEstado.Text = "Estado (vaca)"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'chkCampoRecria
        '
        Me.chkCampoRecria.AutoSize = True
        Me.chkCampoRecria.Location = New System.Drawing.Point(296, 9)
        Me.chkCampoRecria.Name = "chkCampoRecria"
        Me.chkCampoRecria.Size = New System.Drawing.Size(162, 17)
        Me.chkCampoRecria.TabIndex = 5
        Me.chkCampoRecria.Text = "Animales en campo de recria"
        Me.chkCampoRecria.UseVisualStyleBackColor = True
        '
        'chkEstadoSalud
        '
        Me.chkEstadoSalud.AutoSize = True
        Me.chkEstadoSalud.Location = New System.Drawing.Point(83, 33)
        Me.chkEstadoSalud.Name = "chkEstadoSalud"
        Me.chkEstadoSalud.Size = New System.Drawing.Size(102, 17)
        Me.chkEstadoSalud.TabIndex = 6
        Me.chkEstadoSalud.Text = "Estado de salud"
        Me.chkEstadoSalud.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(214, 336)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Cerrar"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmListadoAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 367)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.chkEstadoSalud)
        Me.Controls.Add(Me.chkCampoRecria)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.chkEdad)
        Me.Controls.Add(Me.chkSexo)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lstAnimales)
        Me.Name = "frmListadoAnimales"
        Me.Text = "ListadoAnimales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAnimales As ListBox
    Friend WithEvents lblFiltro As Label
    Friend WithEvents chkSexo As CheckBox
    Friend WithEvents chkEdad As CheckBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents chkCampoRecria As CheckBox
    Friend WithEvents chkEstadoSalud As CheckBox
    Friend WithEvents cmdClose As Button
End Class
