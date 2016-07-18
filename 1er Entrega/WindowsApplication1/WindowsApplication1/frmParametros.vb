Public Class frmParametros
    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboVaquillonaMeses.SelectedIndex = 0
        cboOrdenesDiarios.SelectedIndex = 0
        cboPrepartoMeses.SelectedIndex = 0
        cboRevisionMeses.SelectedIndex = 0
        cboTiempoencrMeses.SelectedIndex = 0
        cboVacasporLote.SelectedIndex = 0

    End Sub

    Private Sub cboVaquillonaMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVaquillonaMeses.SelectedIndexChanged

    End Sub
End Class