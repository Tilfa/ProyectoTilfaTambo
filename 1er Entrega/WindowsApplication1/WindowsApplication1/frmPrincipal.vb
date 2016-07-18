Public Class frmPrincipal
    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub menuLogin_Click(sender As Object, e As EventArgs) Handles menuLogin.Click
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub

    Private Sub menuSalir_Click(sender As Object, e As EventArgs) Handles menuSalir.Click
        Me.Close()
    End Sub

    Private Sub menuPreferencias_Click(sender As Object, e As EventArgs) Handles menuPreferencias.Click
        frmPreferencias.MdiParent = Me
        frmPreferencias.Show()
    End Sub

    Private Sub menuConfiguraciones_Click(sender As Object, e As EventArgs) Handles menuConfiguraciones.Click
        frmConfiguracion.MdiParent = Me
        frmConfiguracion.Show()
    End Sub

    Private Sub menuParametros_Click(sender As Object, e As EventArgs) Handles menuParametros.Click
        frmParametros.MdiParent = Me
        frmParametros.Show()
    End Sub

    Private Sub menuNuevoAnimal_Click(sender As Object, e As EventArgs) Handles menuNuevoAnimal.Click
        frmNuevoAnimal.MdiParent = Me
        frmNuevoAnimal.Show()
    End Sub

    Private Sub menuNuevoLote_Click(sender As Object, e As EventArgs) Handles menuNuevoLote.Click
        frmNuevoLote.MdiParent = Me
        frmNuevoLote.Show()
    End Sub

    Private Sub menuListadoA_Click(sender As Object, e As EventArgs) Handles menuListadoA.Click
        frmListadoAnimales.MdiParent = Me
        frmListadoAnimales.Show()
    End Sub

    Private Sub menuListadoL_Click(sender As Object, e As EventArgs) Handles menuListadoL.Click
        frmListadoLotes.MdiParent = Me
        frmListadoLotes.Show()
    End Sub

    Private Sub menuOrdenes_Click(sender As Object, e As EventArgs) Handles menuOrdenes.Click
        frmOrdeñes.MdiParent = Me
        frmOrdeñes.Show()
    End Sub
End Class
