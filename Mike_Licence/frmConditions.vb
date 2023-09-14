Imports System.Data.OleDb

Public Class frmConditions
    Dim cs As String = "provider=Microsoft.ACE.OLEDB.12.0;data source=MikeLicence.Mdb"
    Dim cn As OleDbConnection
    Dim sql As String
    Dim cmd As OleDbCommand
    Dim RC As Integer
    Dim pls As Boolean = False
    Private Sub Genaral_ConditionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Genaral_ConditionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Genaral_ConditionBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.MikeLicenceDataSet)

        If ConditionTextBox.Text = "" Then
            MsgBox("Please enter somthing to Add")

        ElseIf pls = True Then
            sql = "insert into Genaral_Condition (id, condition) values (" & BindingNavigatorPositionItem.Text & ", '" & ConditionTextBox.Text & "')"
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Added Successfuly")
            frmMikeEntry.Label16.Text = "Stop"
        Else
            '"update tbl set infto= '" & TextBox2.Text & "' WHERE id=" & TextBox1.Text & ""
            sql = "Update Genaral_Condition set condition='" & ConditionTextBox.Text & "' where ID=" & BindingNavigatorPositionItem.Text & ""
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Updated Successfuly")
            frmMikeEntry.Label16.Text = "Stop"
        End If
        frmMikeEntry.gnlCondition.DataSource = Nothing
        ' frmMikeEntry.gnlCondition.Refresh()
    End Sub

    Private Sub frmConditions_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NudiTurnOffScrollLock()
        frmMikeEntry.getGnrlCondition()
    End Sub

    Private Sub frmConditions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MikeLicenceDataSet.Genaral_Condition' table. You can move, or remove it, as needed.
        Me.Genaral_ConditionTableAdapter.Fill(Me.MikeLicenceDataSet.Genaral_Condition)
        cn = New OleDbConnection(cs)
        cn.Open()
        Try
            RC = frmMikeEntry.gnlCondition.CurrentRow.Index
            Genaral_ConditionBindingSource.Position = RC
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        sql = "Delete from Genaral_Condition where ID=" & BindingNavigatorPositionItem.Text & ""
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Deleted")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        pls = True
    End Sub

    Private Sub ConditionTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConditionTextBox.GotFocus
        NudiTurnOnScrollLock()
    End Sub

End Class