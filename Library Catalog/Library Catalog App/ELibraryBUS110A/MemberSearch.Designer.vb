<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberSearch))
        Me.SearchBut = New System.Windows.Forms.Button()
        Me.ClearBut = New System.Windows.Forms.Button()
        Me.ResultsDataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoutBut = New System.Windows.Forms.Button()
        Me.accountBut = New System.Windows.Forms.Button()
        Me.CheckOutBut = New System.Windows.Forms.Button()
        Me._E_Library_1DataSet = New ELibraryBUS110A._E_Library_1DataSet()
        Me.ResourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourceTableAdapter = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.ResourceTableAdapter()
        Me.CheckoutTableAdapter = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.CheckoutTableAdapter()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtseries = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HomeBut = New System.Windows.Forms.Button()
        CType(Me.ResultsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_Library_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBut
        '
        Me.SearchBut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SearchBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SearchBut.Location = New System.Drawing.Point(256, 357)
        Me.SearchBut.Name = "SearchBut"
        Me.SearchBut.Size = New System.Drawing.Size(75, 23)
        Me.SearchBut.TabIndex = 1
        Me.SearchBut.Text = "Search"
        Me.SearchBut.UseVisualStyleBackColor = False
        '
        'ClearBut
        '
        Me.ClearBut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClearBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClearBut.Location = New System.Drawing.Point(502, 357)
        Me.ClearBut.Name = "ClearBut"
        Me.ClearBut.Size = New System.Drawing.Size(75, 23)
        Me.ClearBut.TabIndex = 12
        Me.ClearBut.Text = "Clear"
        Me.ClearBut.UseVisualStyleBackColor = False
        '
        'ResultsDataGrid
        '
        Me.ResultsDataGrid.AccessibleName = "Results"
        Me.ResultsDataGrid.AllowUserToAddRows = False
        Me.ResultsDataGrid.AllowUserToDeleteRows = False
        Me.ResultsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ResultsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ResultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column10, Me.Column7, Me.Column8, Me.Column9})
        Me.ResultsDataGrid.Location = New System.Drawing.Point(19, 139)
        Me.ResultsDataGrid.Name = "ResultsDataGrid"
        Me.ResultsDataGrid.ReadOnly = True
        Me.ResultsDataGrid.RowHeadersVisible = False
        Me.ResultsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ResultsDataGrid.Size = New System.Drawing.Size(819, 138)
        Me.ResultsDataGrid.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Title"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "First Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Publication Year"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "Series"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 61
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column10.HeaderText = "Checkout Date"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "ISBN"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 57
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "CheckOut Period"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
        '
        'Column9
        '
        Me.Column9.HeaderText = "ResourceID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 89
        '
        'LogoutBut
        '
        Me.LogoutBut.AccessibleName = "btnLogOut"
        Me.LogoutBut.BackgroundImage = CType(resources.GetObject("LogoutBut.BackgroundImage"), System.Drawing.Image)
        Me.LogoutBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoutBut.Location = New System.Drawing.Point(768, 42)
        Me.LogoutBut.Name = "LogoutBut"
        Me.LogoutBut.Size = New System.Drawing.Size(34, 32)
        Me.LogoutBut.TabIndex = 15
        Me.LogoutBut.UseVisualStyleBackColor = True
        '
        'accountBut
        '
        Me.accountBut.BackgroundImage = Global.ELibraryBUS110A.My.Resources.Resources.myAccount
        Me.accountBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.accountBut.Location = New System.Drawing.Point(726, 42)
        Me.accountBut.Name = "accountBut"
        Me.accountBut.Size = New System.Drawing.Size(36, 32)
        Me.accountBut.TabIndex = 16
        Me.accountBut.UseVisualStyleBackColor = True
        '
        'CheckOutBut
        '
        Me.CheckOutBut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CheckOutBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckOutBut.Location = New System.Drawing.Point(379, 357)
        Me.CheckOutBut.Name = "CheckOutBut"
        Me.CheckOutBut.Size = New System.Drawing.Size(75, 23)
        Me.CheckOutBut.TabIndex = 17
        Me.CheckOutBut.Text = "Check Out"
        Me.CheckOutBut.UseVisualStyleBackColor = False
        '
        '_E_Library_1DataSet
        '
        Me._E_Library_1DataSet.DataSetName = "_E_Library_1DataSet"
        Me._E_Library_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResourceBindingSource
        '
        Me.ResourceBindingSource.DataMember = "Resource"
        Me.ResourceBindingSource.DataSource = Me._E_Library_1DataSet
        '
        'ResourceTableAdapter
        '
        Me.ResourceTableAdapter.ClearBeforeFill = True
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me._E_Library_1DataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(244, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(316, 283)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(316, 313)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(159, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter Author's Last Name"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(598, 286)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 20)
        Me.txtISBN.TabIndex = 7
        '
        'txtseries
        '
        Me.txtseries.Location = New System.Drawing.Point(598, 315)
        Me.txtseries.Name = "txtseries"
        Me.txtseries.Size = New System.Drawing.Size(100, 20)
        Me.txtseries.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(522, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Enter ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(480, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Enter Series Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(316, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 36)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Member Search"
        '
        'HomeBut
        '
        Me.HomeBut.BackgroundImage = Global.ELibraryBUS110A.My.Resources.Resources.homeButton2
        Me.HomeBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomeBut.Location = New System.Drawing.Point(687, 42)
        Me.HomeBut.Name = "HomeBut"
        Me.HomeBut.Size = New System.Drawing.Size(33, 32)
        Me.HomeBut.TabIndex = 20
        Me.HomeBut.UseVisualStyleBackColor = True
        '
        'MemberSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 440)
        Me.Controls.Add(Me.HomeBut)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckOutBut)
        Me.Controls.Add(Me.accountBut)
        Me.Controls.Add(Me.LogoutBut)
        Me.Controls.Add(Me.ResultsDataGrid)
        Me.Controls.Add(Me.ClearBut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtseries)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchBut)
        Me.Name = "MemberSearch"
        Me.Text = "MemberSearch"
        CType(Me.ResultsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_Library_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchBut As Button
    Friend WithEvents _E_Library_1DataSet As _E_Library_1DataSet
    Friend WithEvents ResourceBindingSource As BindingSource
    Friend WithEvents ResourceTableAdapter As _E_Library_1DataSetTableAdapters.ResourceTableAdapter
    Friend WithEvents CheckoutTableAdapter As _E_Library_1DataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents ClearBut As Button
    Friend WithEvents ResultsDataGrid As DataGridView
    Friend WithEvents LogoutBut As Button
    Friend WithEvents accountBut As Button
    Friend WithEvents CheckOutBut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtseries As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents HomeBut As Button
End Class
