Public Class frmAgregarTipoLote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        frmNuevoLote.cboTipoLote.Items.Add(txtDescripcionLote.Text)
        frmListadoLotes.cboTipoLote.Items.Add(txtDescripcionLote.Text)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class