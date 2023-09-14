<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConditions
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
        Dim ConditionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConditions))
        Me.MikeLicenceDataSet = New Mike_Licence.MikeLicenceDataSet()
        Me.Genaral_ConditionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Genaral_ConditionTableAdapter = New Mike_Licence.MikeLicenceDataSetTableAdapters.Genaral_ConditionTableAdapter()
        Me.TableAdapterManager = New Mike_Licence.MikeLicenceDataSetTableAdapters.TableAdapterManager()
        Me.Genaral_ConditionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Genaral_ConditionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ConditionTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        ConditionLabel = New System.Windows.Forms.Label()
        CType(Me.MikeLicenceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Genaral_ConditionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Genaral_ConditionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Genaral_ConditionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(193, 48)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'ConditionLabel
        '
        ConditionLabel.AutoSize = True
        ConditionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ConditionLabel.Location = New System.Drawing.Point(288, 48)
        ConditionLabel.Name = "ConditionLabel"
        ConditionLabel.Size = New System.Drawing.Size(95, 24)
        ConditionLabel.TabIndex = 3
        ConditionLabel.Text = "Condition:"
        '
        'MikeLicenceDataSet
        '
        Me.MikeLicenceDataSet.DataSetName = "MikeLicenceDataSet"
        Me.MikeLicenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Genaral_ConditionBindingSource
        '
        Me.Genaral_ConditionBindingSource.DataMember = "Genaral_Condition"
        Me.Genaral_ConditionBindingSource.DataSource = Me.MikeLicenceDataSet
        '
        'Genaral_ConditionTableAdapter
        '
        Me.Genaral_ConditionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Genaral_ConditionTableAdapter = Me.Genaral_ConditionTableAdapter
        Me.TableAdapterManager.infoTableAdapter = Nothing
        Me.TableAdapterManager.infoTempTableAdapter = Nothing
        Me.TableAdapterManager.Mike_ConditionTableAdapter = Nothing
        Me.TableAdapterManager.MikeTableAdapter = Nothing
        Me.TableAdapterManager.tblInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mike_Licence.MikeLicenceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'Genaral_ConditionBindingNavigator
        '
        Me.Genaral_ConditionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Genaral_ConditionBindingNavigator.BindingSource = Me.Genaral_ConditionBindingSource
        Me.Genaral_ConditionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Genaral_ConditionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Genaral_ConditionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Genaral_ConditionBindingNavigatorSaveItem})
        Me.Genaral_ConditionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Genaral_ConditionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Genaral_ConditionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Genaral_ConditionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Genaral_ConditionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Genaral_ConditionBindingNavigator.Name = "Genaral_ConditionBindingNavigator"
        Me.Genaral_ConditionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Genaral_ConditionBindingNavigator.Size = New System.Drawing.Size(695, 25)
        Me.Genaral_ConditionBindingNavigator.TabIndex = 0
        Me.Genaral_ConditionBindingNavigator.Text = "BindingNavigator1"
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
        'Genaral_ConditionBindingNavigatorSaveItem
        '
        Me.Genaral_ConditionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Genaral_ConditionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Genaral_ConditionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Genaral_ConditionBindingNavigatorSaveItem.Name = "Genaral_ConditionBindingNavigatorSaveItem"
        Me.Genaral_ConditionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Genaral_ConditionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Genaral_ConditionBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(230, 41)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        Me.IDTextBox.Visible = False
        '
        'ConditionTextBox
        '
        Me.ConditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Genaral_ConditionBindingSource, "Condition", True))
        Me.ConditionTextBox.Font = New System.Drawing.Font("Nudi 01 e", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConditionTextBox.Location = New System.Drawing.Point(27, 91)
        Me.ConditionTextBox.Multiline = True
        Me.ConditionTextBox.Name = "ConditionTextBox"
        Me.ConditionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ConditionTextBox.Size = New System.Drawing.Size(633, 129)
        Me.ConditionTextBox.TabIndex = 0
        '
        'frmConditions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 256)
        Me.Controls.Add(ConditionLabel)
        Me.Controls.Add(Me.ConditionTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Genaral_ConditionBindingNavigator)
        Me.Name = "frmConditions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conditions"
        CType(Me.MikeLicenceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Genaral_ConditionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Genaral_ConditionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Genaral_ConditionBindingNavigator.ResumeLayout(False)
        Me.Genaral_ConditionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MikeLicenceDataSet As Mike_Licence.MikeLicenceDataSet
    Friend WithEvents Genaral_ConditionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Genaral_ConditionTableAdapter As Mike_Licence.MikeLicenceDataSetTableAdapters.Genaral_ConditionTableAdapter
    Friend WithEvents TableAdapterManager As Mike_Licence.MikeLicenceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Genaral_ConditionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Genaral_ConditionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConditionTextBox As System.Windows.Forms.TextBox
End Class
