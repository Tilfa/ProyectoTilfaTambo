Public Class frmLogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            cn.Open("tilfa", txtNombreUsuario.Text, txtContraseña.Text)
            frmPrincipal.Show()
            Me.Close()
            frmInicio.Close()
        Catch ex As Exception
            MsgBox("Usuario o contraseña incorrecta.")
            Me.Close()
            Exit Sub
        End Try
        cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    End Sub
End Class