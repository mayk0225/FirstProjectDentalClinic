Imports MySql.Data.MySqlClient

Public Class frmAddNewTreatmentProcedure
    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If btnSave.Text = "SAVE" Then
            Dim cmd As New MySqlCommand("INSERT INTO `tbltreatmentprocedures`(`TreatmentName`) VALUES ('" + txtTreatmentName.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Record added", MsgBoxStyle.Information, "Record")

            txtTreatmentName.Text = ""

            Me.Close()

        Else
            Dim cmdupdate As New MySqlCommand("UPDATE tbltreatmentprocedures Set TreatmentName = '" + txtTreatmentName.Text + "'", con)

            cmdupdate.ExecuteNonQuery()
            MsgBox("Record updated", MsgBoxStyle.Information, "Record")


            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class