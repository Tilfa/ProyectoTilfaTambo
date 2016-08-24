Public Class frmPrincipal

   
    Private Sub LisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.animal' Puede moverla o quitarla según sea necesario.
        Me.AnimalTableAdapter.Fill(Me.DataSet1.animal)

    End Sub

    Private Sub AñadirUnAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirUnAnimalToolStripMenuItem.Click
        frmNuevoAnimal.MdiParent = Me
        frmNuevoAnimal.Show()
        pnlNotificaciones.Visible = False
    End Sub

    Private Sub ModificarUnAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarUnAnimalToolStripMenuItem.Click
        frmModificarAnimal.MdiParent = Me
        frmModificarAnimal.Show()
        pnlNotificaciones.Visible = False
    End Sub

    Private Sub ListaDeAnimalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeAnimalesToolStripMenuItem.Click
        frmListadoAnimales.MdiParent = Me
        frmListadoAnimales.Show()
        pnlNotificaciones.Visible = False
    End Sub

    Private Sub CerrarCesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarCesionToolStripMenuItem.Click
        frmInicio.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class