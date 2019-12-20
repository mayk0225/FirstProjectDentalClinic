Imports MySql.Data.MySqlClient

Public Class frmAddNewRecord
    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If btnSave.Text = "SAVE" Then

            Dim cmd As New MySqlCommand("INSERT INTO `tblpatientlist`(`PatientName`, `Age`, `CPNumber`, `Address`) VALUES ('" + txtNameOfPatient.Text + "', '" + txtAge.Text + "', '" + txtCPNumber.Text + "', '" + txtAddress.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Record added", MsgBoxStyle.Information, "Record")

            Me.Close()

        Else
            Dim cmdupdate As New MySqlCommand("UPDATE tblpatientlist Set PatientName = '" + txtNameOfPatient.Text + "', Age = '" + txtAge.Text + "', CPNumber = '" + txtCPNumber.Text + "', Address = '" + txtAddress.Text + "' Where PatientID = '" + lblID.Text + "'", con)

            cmdupdate.ExecuteNonQuery()
            MsgBox("Record updated", MsgBoxStyle.Information, "Record")

            txtNameOfPatient.Text = ""
            txtAge.Text = ""
            txtCPNumber.Text = ""
            txtAddress.Text = ""

            Me.Close()
        End If


    End Sub

End Class