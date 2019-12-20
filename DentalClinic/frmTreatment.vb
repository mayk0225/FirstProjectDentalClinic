Imports MySql.Data.MySqlClient


Public Class frmTreatment

    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")


    Private Sub frmTreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshComboBoxes()

        dgvTreatment.ColumnCount = 4
        dgvTreatment.Columns(0).Name = "Treatment"
        dgvTreatment.Columns(1).Name = "Tooth Qty"
        dgvTreatment.Columns(2).Name = "Tooth Number/s"
        dgvTreatment.Columns(3).Name = "Remarks"

    End Sub

    Public Sub refreshComboBoxes()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim table As DataTable

        Try

            Dim msda As New MySqlDataAdapter("select TreatmentNo, TreatmentName from tbltreatmentprocedures", con)
            table = New DataTable
            msda.Fill(table)
            cboTreatment.DataSource = table
            cboTreatment.ValueMember = "TreatmentNo"
            cboTreatment.DisplayMember = "TreatmentName"

        Catch
            MsgBox("There's no treatment on the list. Insert one", MsgBoxStyle.Exclamation)
            btnAddNewTreatment.PerformClick()

        End Try

    End Sub



    Private Sub btnAddNewTreatment_Click(sender As Object, e As EventArgs) Handles btnAddNewTreatment.Click
        frmAddNewTreatmentProcedure.ShowDialog()
        refreshComboBoxes()
    End Sub

    Private Sub pbxNewPatient_Click(sender As Object, e As EventArgs) Handles pbxNewPatient.Click

        frmAddNewRecord.txtNameOfPatient.Text = ""
        frmAddNewRecord.txtAge.Text = ""
        frmAddNewRecord.txtCPNumber.Text = ""
        frmAddNewRecord.txtAddress.Text = ""

        frmAddNewRecord.ShowDialog()

        lblPatientName.Text = frmAddNewRecord.txtNameOfPatient.Text
        lblPatientAge.Text = frmAddNewRecord.txtAge.Text
        lblPatientCPNumber.Text = frmAddNewRecord.txtCPNumber.Text
        lblPatientAddress.Text = frmAddNewRecord.txtAddress.Text

    End Sub

    Private Sub btnSubmitTreatment_Click(sender As Object, e As EventArgs) Handles btnSubmitTreatment.Click

        If (cboTreatment.Text = "Braces") Then
            Dim row As String() = New String() {cboTreatment.Text, "", "", txtRemarks.Text}
            dgvTreatment.Rows.Add(row)

        Else
            Dim row As String() = New String() {cboTreatment.Text, nudTeethQty.Value, txtToothNumber.Text, txtRemarks.Text}
            dgvTreatment.Rows.Add(row)
        End If


    End Sub

    Private Sub cboTreatment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTreatment.SelectedIndexChanged
        If (cboTreatment.Text = "Braces") Then
            nudTeethQty.Enabled = False
            txtToothNumber.Enabled = False

        Else
            nudTeethQty.Enabled = True
            txtToothNumber.Enabled = True

        End If

    End Sub

    Private Sub txtTreatmentCost_Leave(sender As Object, e As EventArgs) Handles txtTreatmentCost.Leave
    End Sub

    Private Sub txtTreatmentCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTreatmentCost.KeyPress


        If Len(txtTreatmentCost.Text) > 0 Then
            txtTreatmentCost.Text = FormatNumber(CDbl(txtTreatmentCost.Text), 0)
            Dim x As Integer = txtTreatmentCost.SelectionStart.ToString
            If x = 0 Then
                txtTreatmentCost.SelectionStart = Len(txtTreatmentCost.Text)
                txtTreatmentCost.SelectionLength = 0
            Else
                txtTreatmentCost.SelectionStart = x
                txtTreatmentCost.SelectionLength = 0
            End If
        End If



    End Sub
End Class