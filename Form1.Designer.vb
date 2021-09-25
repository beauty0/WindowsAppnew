<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim Add1Label As System.Windows.Forms.Label
        Dim Add2Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NewtablesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NewtablesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Add1TextBox = New System.Windows.Forms.TextBox()
        Me.Add2TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NewQueryToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewQueryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NewtablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleDBDataSet = New WindowsAppnew.SampleDBDataSet()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewtablesTableAdapter = New WindowsAppnew.SampleDBDataSetTableAdapters.NewtablesTableAdapter()
        Me.TableAdapterManager = New WindowsAppnew.SampleDBDataSetTableAdapters.TableAdapterManager()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        Add1Label = New System.Windows.Forms.Label()
        Add2Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        CType(Me.NewtablesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewtablesBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.NewQueryToolStrip.SuspendLayout()
        CType(Me.NewtablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(13, 27)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(13, 55)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(113, 17)
        CustomerNameLabel.TabIndex = 3
        CustomerNameLabel.Text = "Customer Name:"
        '
        'Add1Label
        '
        Add1Label.AutoSize = True
        Add1Label.Location = New System.Drawing.Point(13, 84)
        Add1Label.Name = "Add1Label"
        Add1Label.Size = New System.Drawing.Size(45, 17)
        Add1Label.TabIndex = 5
        Add1Label.Text = "Add1:"
        '
        'Add2Label
        '
        Add2Label.AutoSize = True
        Add2Label.Location = New System.Drawing.Point(13, 111)
        Add2Label.Name = "Add2Label"
        Add2Label.Size = New System.Drawing.Size(45, 17)
        Add2Label.TabIndex = 7
        Add2Label.Text = "Add2:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(13, 139)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 9
        CityLabel.Text = "City:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(13, 167)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(32, 17)
        ZipLabel.TabIndex = 11
        ZipLabel.Text = "Zip:"
        '
        'NewtablesBindingNavigator
        '
        Me.NewtablesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NewtablesBindingNavigator.BindingSource = Me.NewtablesBindingSource
        Me.NewtablesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NewtablesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NewtablesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NewtablesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NewtablesBindingNavigatorSaveItem})
        Me.NewtablesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NewtablesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NewtablesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NewtablesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NewtablesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NewtablesBindingNavigator.Name = "NewtablesBindingNavigator"
        Me.NewtablesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NewtablesBindingNavigator.Size = New System.Drawing.Size(1485, 31)
        Me.NewtablesBindingNavigator.TabIndex = 0
        Me.NewtablesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'NewtablesBindingNavigatorSaveItem
        '
        Me.NewtablesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewtablesBindingNavigatorSaveItem.Image = CType(resources.GetObject("NewtablesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NewtablesBindingNavigatorSaveItem.Name = "NewtablesBindingNavigatorSaveItem"
        Me.NewtablesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.NewtablesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewtablesBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(133, 27)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(148, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewtablesBindingSource, "CustomerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(133, 55)
        Me.CustomerNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(148, 22)
        Me.CustomerNameTextBox.TabIndex = 4
        '
        'Add1TextBox
        '
        Me.Add1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewtablesBindingSource, "Add1", True))
        Me.Add1TextBox.Location = New System.Drawing.Point(132, 81)
        Me.Add1TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Add1TextBox.Name = "Add1TextBox"
        Me.Add1TextBox.Size = New System.Drawing.Size(149, 22)
        Me.Add1TextBox.TabIndex = 6
        '
        'Add2TextBox
        '
        Me.Add2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewtablesBindingSource, "Add2", True))
        Me.Add2TextBox.Location = New System.Drawing.Point(133, 108)
        Me.Add2TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Add2TextBox.Name = "Add2TextBox"
        Me.Add2TextBox.Size = New System.Drawing.Size(148, 22)
        Me.Add2TextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewtablesBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(133, 137)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(148, 22)
        Me.CityTextBox.TabIndex = 10
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewtablesBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(133, 164)
        Me.ZipTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(148, 22)
        Me.ZipTextBox.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.Add1DataGridViewTextBoxColumn, Me.Add2DataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NewtablesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(451, 52)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(992, 286)
        Me.DataGridView1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 218)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 218)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(224, 218)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CustomerNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(ZipLabel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.Add2TextBox)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(Add2Label)
        Me.GroupBox1.Controls.Add(CustomerNameLabel)
        Me.GroupBox1.Controls.Add(Me.Add1TextBox)
        Me.GroupBox1.Controls.Add(Add1Label)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(344, 286)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'NewQueryToolStrip
        '
        Me.NewQueryToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NewQueryToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewQueryToolStripButton})
        Me.NewQueryToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.NewQueryToolStrip.Name = "NewQueryToolStrip"
        Me.NewQueryToolStrip.Size = New System.Drawing.Size(1485, 31)
        Me.NewQueryToolStrip.TabIndex = 18
        Me.NewQueryToolStrip.Text = "NewQueryToolStrip"
        '
        'NewQueryToolStripButton
        '
        Me.NewQueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewQueryToolStripButton.Name = "NewQueryToolStripButton"
        Me.NewQueryToolStripButton.Size = New System.Drawing.Size(79, 28)
        Me.NewQueryToolStripButton.Text = "newQuery"
        '
        'NewtablesBindingSource
        '
        Me.NewtablesBindingSource.DataMember = "Newtables"
        Me.NewtablesBindingSource.DataSource = Me.SampleDBDataSet
        '
        'SampleDBDataSet
        '
        Me.SampleDBDataSet.DataSetName = "SampleDBDataSet"
        Me.SampleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 125
        '
        'Add1DataGridViewTextBoxColumn
        '
        Me.Add1DataGridViewTextBoxColumn.DataPropertyName = "Add1"
        Me.Add1DataGridViewTextBoxColumn.HeaderText = "Add1"
        Me.Add1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Add1DataGridViewTextBoxColumn.Name = "Add1DataGridViewTextBoxColumn"
        Me.Add1DataGridViewTextBoxColumn.Width = 125
        '
        'Add2DataGridViewTextBoxColumn
        '
        Me.Add2DataGridViewTextBoxColumn.DataPropertyName = "Add2"
        Me.Add2DataGridViewTextBoxColumn.HeaderText = "Add2"
        Me.Add2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Add2DataGridViewTextBoxColumn.Name = "Add2DataGridViewTextBoxColumn"
        Me.Add2DataGridViewTextBoxColumn.Width = 125
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 125
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        Me.ZipDataGridViewTextBoxColumn.Width = 125
        '
        'NewtablesTableAdapter
        '
        Me.NewtablesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NewtablesTableAdapter = Me.NewtablesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsAppnew.SampleDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1485, 458)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewQueryToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NewtablesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NewtablesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewtablesBindingNavigator.ResumeLayout(False)
        Me.NewtablesBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.NewQueryToolStrip.ResumeLayout(False)
        Me.NewQueryToolStrip.PerformLayout()
        CType(Me.NewtablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SampleDBDataSet As SampleDBDataSet
    Friend WithEvents NewtablesBindingSource As BindingSource
    Friend WithEvents NewtablesTableAdapter As SampleDBDataSetTableAdapters.NewtablesTableAdapter
    Friend WithEvents TableAdapterManager As SampleDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NewtablesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents NewtablesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents Add1TextBox As TextBox
    Friend WithEvents Add2TextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Add1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Add2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NewQueryToolStrip As ToolStrip
    Friend WithEvents NewQueryToolStripButton As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
