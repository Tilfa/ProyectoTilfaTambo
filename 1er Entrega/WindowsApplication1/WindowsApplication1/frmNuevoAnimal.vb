Public Class frmNuevoAnimal
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles frameSexo.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles frameVaca.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles optHembra.CheckedChanged
        If optHembra.Checked = True Then
            frameVaca.Visible = True
            chkSi.Checked = True
        Else
            frameVaca.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkSi.CheckedChanged
        If chkSi.Checked = True Then
            cboLote.Enabled = True
        Else
            cboLote.Enabled = False
        End If
    End Sub

    Private Sub frmNuevoAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblFechaNacimiento.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblPariciones.Click

    End Sub
End Class