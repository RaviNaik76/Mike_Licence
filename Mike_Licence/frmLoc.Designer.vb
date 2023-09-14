<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim LocLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoc))
        Me.MikeLicenceDataSet1 = New Mike_Licence.MikeLicenceDataSet1()
        Me.TblLocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLocTableAdapter = New Mike_Licence.MikeLicenceDataSet1TableAdapters.tblLocTableAdapter()
        Me.TableAdapterManager = New Mike_Licence.MikeLicenceDataSet1TableAdapters.TableAdapterManager()
        Me.TblLocBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblLocBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.LocTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        LocLabel = New System.Windows.Forms.Label()
        CType(Me.MikeLicenceDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLocBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblLocBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(46, 74)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'LocLabel
        '
        LocLabel.AutoSize = True
        LocLabel.Location = New System.Drawing.Point(12, 113)
        LocLabel.Name = "LocLabel"
        LocLabel.Size = New System.Drawing.Size(48, 13)
        LocLabel.TabIndex = 3
        LocLabel.Text = "Location"
        '
        'MikeLicenceDataSet1
        '
        Me.MikeLicenceDataSet1.DataSetName = "MikeLicenceDataSet1"
        Me.MikeLicenceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLocBindingSource
        '
        Me.TblLocBindingSource.DataMember = "tblLoc"
        Me.TblLocBindingSource.DataSource = Me.MikeLicenceDataSet1
        '
        'TblLocTableAdapter
        '
        Me.TblLocTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Genaral_ConditionTableAdapter = Nothing
        Me.TableAdapterManager.infoTableAdapter = Nothing
        Me.TableAdapterManager.infoTempTableAdapter = Nothing
        Me.TableAdapterManager.Mike_ConditionTableAdapter = Nothing
        Me.TableAdapterManager.MikeTableAdapter = Nothing
        Me.TableAdapterManager.tblInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblLocTableAdapter = Me.TblLocTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mike_Licence.MikeLicenceDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblLocBindingNavigator
        '
        Me.TblLocBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblLocBindingNavigator.BindingSource = Me.TblLocBindingSource
        Me.TblLocBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblLocBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblLocBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblLocBindingNavigatorSaveItem})
        Me.TblLocBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblLocBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblLocBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblLocBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblLocBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblLocBindingNavigator.Name = "TblLocBindingNavigator"
        Me.TblLocBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblLocBindingNavigator.Size = New System.Drawing.Size(385, 25)
        Me.TblLocBindingNavigator.TabIndex = 0
        Me.TblLocBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblLocBindingNavigatorSaveItem
        '
        Me.TblLocBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblLocBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblLocBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblLocBindingNavigatorSaveItem.Name = "TblLocBindingNavigatorSaveItem"
        Me.TblLocBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblLocBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLocBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(73, 71)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'LocTextBox
        '
        Me.LocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLocBindingSource, "Loc", True))
        Me.LocTextBox.Font = New System.Drawing.Font("Nudi 01 e", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocTextBox.Location = New System.Drawing.Point(73, 110)
        Me.LocTextBox.Name = "LocTextBox"
        Me.LocTextBox.Size = New System.Drawing.Size(278, 23)
        Me.LocTextBox.TabIndex = 4
        '
        'frmLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 163)
        Me.Controls.Add(LocLabel)
        Me.Controls.Add(Me.LocTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.TblLocBindingNavigator)
        Me.Name = "frmLoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Location"
        CType(Me.MikeLicenceDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLocBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblLocBindingNavigator.ResumeLayout(False)
        Me.TblLocBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MikeLicenceDataSet1 As Mike_Licence.MikeLicenceDataSet1
    Friend WithEvents TblLocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblLocTableAdapter As Mike_Licence.MikeLicenceDataSet1TableAdapters.tblLocTableAdapter
    Friend WithEvents TableAdapterManager As Mike_Licence.MikeLicenceDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TblLocBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblLocBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocTextBox As System.Windows.Forms.TextBox
End Class
