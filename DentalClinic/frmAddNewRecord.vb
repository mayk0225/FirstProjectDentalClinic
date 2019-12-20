Imports MySql.Data.MySqlClient

Public Class frmAddNewRecord
    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim cmd As New MySqlCommand("select Count(*) from tblpatientlist", con)
        Dim patientID = cmd.ExecuteScalar()

        frmTreatment.lblPatientID.Text = patientID

        If frmTreatment.lblAddEditPatient.Text = "New Patient" Then
            txtNameOfPatient.Text = ""
            txtAge.Text = ""
            txtCPNumber.Text = ""
            txtAddress.Text = ""

            frmTreatment.lblAddEditPatient.Text = txtNameOfPatient.Text
            frmTreatment.lblAddEditPatient.Text = txtAge.Text
            frmTreatment.lblAddEditPatient.Text = txtCPNumber.Text
            frmTreatment.lblAddEditPatient.Text = txtAddress.Text

        Else

            frmTreatment.lblAddEditPatient.Text = txtNameOfPatient.Text
            frmTreatment.lblAddEditPatient.Text = txtAge.Text
            frmTreatment.lblAddEditPatient.Text = txtCPNumber.Text
            frmTreatment.lblAddEditPatient.Text = txtAddress.Text

        End If

        Me.Close()

    End Sub

End Class