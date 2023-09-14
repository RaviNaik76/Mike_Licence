Imports System.Data.OleDb

Public Class frmInfo

    Dim cs As String = "provider=Microsoft.ACE.OLEDB.12.0;data source=MikeLicence.Mdb"
    Dim cn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim rc As Integer
    Dim r As DataRow
    Dim dt As DataTable
    Dim sql As String
    Dim cmd As OleDbCommand

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NudiTurnOffScrollLock()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection(cs)
        cn.Open()

        sql = "select * from tblInfo"
        da = New OleDbDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        setGrid()
        setSerial()
    End Sub
    Public Sub setSerial()
        If dt.Rows.Count < 0 Then
            TextBox1.Text = 1
        Else
            Dim si As Integer = dt.Rows.Count + 1
            TextBox1.Text = si
        End If
    End Sub
    Public Sub getemp(ByVal ci As Integer)
        r = dt.Rows(ci)
        TextBox1.Text = r("id")
        TextBox2.Text = r("infto")
    End Sub

    Private Sub dtv_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtv.MouseUp
        rc = dtv.CurrentRow.Index
        getemp(rc)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = dt.Rows.Count + 1 Then
            sql = "insert into tbl (infto) values ('" & TextBox2.Text & "')"
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record added succusfully")

        Else
            sql = "update tbl set infto= '" & TextBox2.Text & "' WHERE id=" & TextBox1.Text & ""
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
            MsgBox("updated succusfully")
        End If
        setGrid()


    End Sub
    Public Sub setGrid()
        With dtv
            .DataSource = dt
            .Columns(0).Width = 40
            .Columns(1).Width = 300
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        setGrid()
        setSerial()
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        NudiTurnOnScrollLock()
    End Sub

    Private Sub dtv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtv.CellContentClick

    End Sub
End Class