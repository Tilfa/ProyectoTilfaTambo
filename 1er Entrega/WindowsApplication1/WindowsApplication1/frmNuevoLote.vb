Public Class frmNuevoLote
    Private Sub frmNuevoLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipoLote.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        frmAgregarTipoLote.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class