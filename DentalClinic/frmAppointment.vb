Imports MySql.Data.MySqlClient
Public Class frmAppointment

    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")

    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpAppointmentTime.ShowUpDown = True

        comboBoxRefresh()
        loaddatagrid()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmd As New MySqlCommand("INSERT INTO `tblappointments`(`PatientName`, `Treatment`, `Date`, `Time`) VALUES ('" + cboPatientName.Text + "', '" + cboTreatment.Text + "', '" + dtpAppointmentDate.Text + "', '" + dtpAppointmentTime.Text + "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Record added", MsgBoxStyle.Information, "Record")

        cboPatientName.Text = Nothing
        cboTreatment.Text = Nothing
        dtpAppointmentDate.ResetText()
        dtpAppointmentTime.ResetText()

        loaddatagrid()
    End Sub

    Public Sub comboBoxRefresh()

        Dim table As DataTable
        Dim msda As New MySqlDataAdapter("select PatientID, PatientName from tblpatientlist", con)
        table = New DataTable
        msda.Fill(table)
        cboPatientName.DataSource = table
        cboPatientName.ValueMember = "PatientID"
        cboPatientName.DisplayMember = "PatientName"
        ''''''''''

    End Sub

    Public Sub loaddatagrid()
        Dim table As DataTable

        Try
            Dim msda As New MySqlDataAdapter("select * from tblappointments", con)
            table = New DataTable
            msda.Fill(table)
            dgvAppointment.DataSource = table
            'Dim column As DataGridViewColumn = dgvRecords.Columns(0)

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try



    End Sub

End Class