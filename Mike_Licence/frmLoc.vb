Public Class frmLoc

    Private Sub TblLocBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblLocBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblLocBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MikeLicenceDataSet1)

    End Sub

    Private Sub frmLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MikeLicenceDataSet1.tblLoc' table. You can move, or remove it, as needed.
        Me.TblLocTableAdapter.Fill(Me.MikeLicenceDataSet1.tblLoc)

    End Sub

    Private Sub IDTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IDTextBox.GotFocus
        NudiTurnOffScrollLock()
    End Sub

    Private Sub LocTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocTextBox.GotFocus
        NudiTurnOnScrollLock()
    End Sub
End Class