Public Class frmOrdeñes
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumeroLote.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnalisis.CheckedChanged
        If chkAnalisis.Checked = True Then
            frameAnalisis.Enabled = True
        Else
            frameAnalisis.Enabled = False
        End If
    End Sub

    Private Sub frmOrdeñes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkAnalisis.Checked = True
    End Sub
End Class