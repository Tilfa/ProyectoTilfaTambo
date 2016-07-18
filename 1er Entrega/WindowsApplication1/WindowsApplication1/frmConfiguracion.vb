Public Class frmConfiguracion
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFrecuenciaBackup.SelectedIndex = 0
        cboIdioma.SelectedIndex = 0
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class