Imports MySql.Data.MySqlClient
Public Class frmRecords

    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")
    Private Sub btnAddNewRecord_Click(sender As Object, e As EventArgs) Handles btnCreateNewRecord.Click
        frmAddNewRecord.ShowDialog()
        loaddatagrid()
    End Sub


    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddatagrid()

        Dim imgEdit As New DataGridViewImageColumn()
        Dim imgDelete As New DataGridViewImageColumn()

        Try

            Dim inImgEdit As Image = Image.FromFile("C:\Users\KyaM\Desktop\DentalClinicRecordandBillingSystem\Icons\pencil-edit-button.png")
            imgEdit.Image = inImgEdit
            dgvRecords.Columns.Add(imgEdit)
            imgEdit.Width = 30



            Dim inImgDel As Image = Image.FromFile("C:\Users\KyaM\Desktop\DentalClinicRecordandBillingSystem\Icons\rubbish-bin.png")
            imgDelete.Image = inImgDel
            dgvRecords.Columns.Add(imgDelete)
            imgDelete.Width = 30

        Catch

            dgvRecords.Columns.Add(imgEdit)
            imgEdit.Width = 30


            dgvRecords.Columns.Add(imgDelete)
            imgDelete.Width = 30

        End Try




    End Sub


    Public Sub loaddatagrid()
        Dim table As DataTable

        Try
            Dim msda As New MySqlDataAdapter("select * from tblpatientlist", con)
            table = New DataTable
            msda.Fill(table)
            dgvRecords.DataSource = table
            'Dim column As DataGridViewColumn = dgvRecords.Columns(0)

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try



    End Sub

    Private Sub dgvRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellContentClick

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'EDIT CODE BELOW
        If e.ColumnIndex = 0 Then
            frmAddNewRecord.btnSave.Text = "UPDATE"
            frmAddNewRecord.lblID.Text = dgvRecords.CurrentRow.Cells(2).Value.ToString()
            frmAddNewRecord.txtNameOfPatient.Text = dgvRecords.CurrentRow.Cells(3).Value.ToString()
            frmAddNewRecord.txtAge.Text = dgvRecords.CurrentRow.Cells(4).Value.ToString()
            frmAddNewRecord.txtCPNumber.Text = dgvRecords.CurrentRow.Cells(6).Value.ToString()
            frmAddNewRecord.ShowDialog()
            loaddatagrid()

        ElseIf e.ColumnIndex = 1 Then
            Dim result As DialogResult = MessageBox.Show("Delete '" + dgvRecords.CurrentRow.Cells(3).Value.ToString() + "'s record?", "Delete", MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then

                Dim cmd As New MySqlCommand("DELETE from tblpatientlist where PatientID = '" + dgvRecords.CurrentRow.Cells(2).Value.ToString() + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("'" + dgvRecords.CurrentRow.Cells(3).Value.ToString() + "'s record has been deleted", MsgBoxStyle.Information, "Delete")
                loaddatagrid()
            End If

        End If

    End Sub
End Class