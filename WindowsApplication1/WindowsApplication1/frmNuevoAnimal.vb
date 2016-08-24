Public Class frmNuevoAnimal
    Dim sexo As String
    Private Sub frmNuevoAnimal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.pnlNotificaciones.Visible = True
    End Sub

    Private Sub frmNuevoAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarFoto.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            imgAnimal.Image = Image.FromFile(file.FileName)
            cmdQuitar.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitar.Click
        imgAnimal.Image = Nothing
        cmdQuitar.Visible = False
    End Sub

    Private Sub cmdVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerificar.Click

        sql = "select * from animal where idanimal = '" & txtBuscarId.Text & "'"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar id de vaca")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then
            lblVerificacion.ForeColor = Color.Green
            lblVerificacion.Text = "Valido"
            lblVerificacion.Visible = True
            frameDatos.Enabled = True
        Else
            lblVerificacion.Visible = True
            lblVerificacion.Text = "Registro ya existente"
            lblVerificacion.ForeColor = Color.Red
        End If
        rs.Close()
    End Sub

    Private Sub optMacho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMacho.CheckedChanged
        If optHembra.Checked Then
            frameVaca.Visible = True
            sexo = "Hembra"
        ElseIf optMacho.Checked Then
            sexo = "Macho"
            frameVaca.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If lblVerificacion.ForeColor = Color.Green Then

            If optMacho.Checked = True Then

                Dim Peso As String
                Peso = Replace(CStr(numPeso.Value), ",", ".")
                sql = "insert into animal (idanimal, denticion, idpadre, idmadre, raza, sexo, fechanacimiento, estado, nombretambo, peso) values ('" & txtBuscarId.Text & "', '" & txtDenticion.Text & "', '" & txtIdPadre.Text & "', '" & txtIdMadre.Text & "', '" & txtRaza.Text & "', '" & sexo & "', '" & dateFechaNacimiento.Value.ToString("MM/dd/yyyy") & "', 'vivo', 'tamboA', " & Peso & ")"
                Try
                    cn.Execute(sql)
                    MsgBox("Animal agregado con exito")
                    If MsgBox("Desea agregar otro animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        txtBuscarId.Text = ""
                        txtDenticion.Text = ""
                        txtIdMadre.Text = ""
                        txtIdPadre.Text = ""
                        txtRaza.Text = ""
                        lblVerificacion.Visible = False
                        dateFechaNacimiento.Value = Today
                        numPeso.Value = 0
                        imgAnimal.Image = Nothing
                        numCantidadPariciones.Value = 0
                        dateIngresoCR.Value = Today
                        dateIngresoCR.Visible = False
                        chkCR.Checked = False
                        dateCambioEstado.Value = Today
                        frameDatos.Enabled = False
                        frameCria.Visible = False
                        frameVaca.Visible = False
                    Else
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Error al ingresar el animal")
                    Exit Sub
                End Try


            Else




            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class