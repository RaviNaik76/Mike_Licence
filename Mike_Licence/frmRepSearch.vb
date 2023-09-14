Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Globalization

Public Class frmRepSearch
    Dim cs As String = "provider=Microsoft.ACE.OLEDB.12.0;data source=MikeLicence.Mdb"
    Dim cn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim dtb As DataTable
    Dim sql As String

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        TextBox2.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        RadioButton1.Checked = True

        cn = New OleDbConnection(cs)
        cn.Open()

        ' DataGridView1.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Visible = True
        TextBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Visible = False
        TextBox2.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing
        If RadioButton3.Checked Then
            Dim s1 As String = DateTimePicker1.Value.Date
            Dim s2 As String = DateTimePicker1.Value.Date

            sql = "SELECT Holder_Name, Holder_Address, Holder_Mobile, Mike_Reason, " _
                        & " Perm_from_Date as From_Date, Perm_to_Date as To_Date, Place, " _
                        & " Challan_No, Challan_Date, Challan_Amount as Amount, Mike_ID, Licence_Date " _
                        & " FROM Mike " _
                        & " Where Licence_Date between '" & s1 & "' and '" & s2 & "'"

        ElseIf RadioButton2.Checked Then
            sql = "SELECT Holder_Name, Holder_Address, Holder_Mobile, Mike_Reason, " _
                        & " Perm_from_Date as From_Date, Perm_to_Date as To_Date, Place, " _
                        & " Challan_No, Challan_Date, Challan_Amount as Amount, Mike_ID, Licence_Date " _
                        & " FROM Mike Where Mike_ID BETWEEN " & (TextBox1.Text) & " AND " & (TextBox2.Text) & ""
        Else
            sql = "SELECT Holder_Name, Holder_Address, Holder_Mobile, Mike_Reason, " _
                        & " Perm_from_Date as From_Date, Perm_to_Date as To_Date, Place, " _
                        & " Challan_No, Challan_Date, Challan_Amount as Amount, Mike_ID, Licence_Date " _
                        & " FROM Mike"
        End If
        DataGridView1.DataSource = Nothing
        da = New OleDbDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        callrpt()
    End Sub
    Private Sub callrpt()
        dtb = New DataTable
        With dtb
            .Columns.Add("SrNo")
            .Columns.Add("Holder_Name")
            .Columns.Add("Holder_Address")
            .Columns.Add("Holder_Mobile")
            .Columns.Add("Mike_Reason")
            .Columns.Add("From_Date")
            .Columns.Add("To_Date")
            .Columns.Add("Place")
            .Columns.Add("Challan_No")
            .Columns.Add("Challan_Date")
            .Columns.Add("Amount")
            .Columns.Add("Mike_ID")
            .Columns.Add("Licence_Date")
        End With
        Dim serial As Integer
        serial = 1
        'For Each row As DataRow In Me.dt.Rows   'but date value is date and time
        'dtb.Rows.Add(serial, row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11))
        'serial = serial + 1
        ' Next
        For Each row As DataGridViewRow In Me.DataGridView1.Rows    'but ("From_Date", GetType(Date)) not work
            dtb.Rows.Add(serial, row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).FormattedValue, row.Cells(5).FormattedValue, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).FormattedValue, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).FormattedValue)
            serial = serial + 1
        Next
        dtb.AcceptChanges()

        frmReportReg.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtb
        frmReportReg.ShowDialog()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Visible = False
        TextBox2.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub

End Class