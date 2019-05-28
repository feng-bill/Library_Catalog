<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountReview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountReview))
        Me.Review = New System.Windows.Forms.Button()
        Me._E_Library_1DataSet1 = New ELibraryBUS110A._E_Library_1DataSet1()
        Me.ELibrary1DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Results = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RenewBut = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ReturnBut = New System.Windows.Forms.Button()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._E_Library_1DataSet = New ELibraryBUS110A._E_Library_1DataSet()
        Me.CheckoutTableAdapter = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.CheckoutTableAdapter()
        Me.ResourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourceTableAdapter = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.ResourceTableAdapter()
        Me.TableAdapterManager = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.TableAdapterManager()
        Me.SearchBut = New System.Windows.Forms.Button()
        Me._E_Library_1DataSet2 = New ELibraryBUS110A._E_Library_1DataSet()
        CType(Me._E_Library_1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELibrary1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_Library_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_Library_1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Review
        '
        Me.Review.AccessibleName = "btnRenew"
        Me.Review.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Review.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Review.Location = New System.Drawing.Point(276, 335)
        Me.Review.Name = "Review"
        Me.Review.Size = New System.Drawing.Size(86, 23)
        Me.Review.TabIndex = 0
        Me.Review.Text = "View My Items"
        Me.Review.UseVisualStyleBackColor = False
        '
        '_E_Library_1DataSet1
        '
        Me._E_Library_1DataSet1.DataSetName = "_E_Library_1DataSet1"
        Me._E_Library_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ELibrary1DataSet1BindingSource
        '
        Me.ELibrary1DataSet1BindingSource.DataSource = Me._E_Library_1DataSet1
        Me.ELibrary1DataSet1BindingSource.Position = 0
        '
        'Results
        '
        Me.Results.AccessibleName = "Results"
        Me.Results.AllowUserToAddRows = False
        Me.Results.AllowUserToDeleteRows = False
        Me.Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Results.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Results.Location = New System.Drawing.Point(59, 149)
        Me.Results.Name = "Results"
        Me.Results.ReadOnly = True
        Me.Results.RowHeadersVisible = False
        Me.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Results.Size = New System.Drawing.Size(640, 143)
        Me.Results.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Title"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 52
        '
        'Column2
        '
        Me.Column2.HeaderText = "Author"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 63
        '
        'Column3
        '
        Me.Column3.HeaderText = "Publication Year"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Series"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 61
        '
        'Column5
        '
        Me.Column5.HeaderText = "Checkout Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 96
        '
        'Column6
        '
        Me.Column6.HeaderText = "Date Due"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 72
        '
        'Column7
        '
        Me.Column7.HeaderText = "Checkout Period"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 102
        '
        'Column8
        '
        Me.Column8.HeaderText = "ResourceID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(267, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Account Review"
        '
        'RenewBut
        '
        Me.RenewBut.AccessibleName = "btnReview"
        Me.RenewBut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RenewBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RenewBut.Location = New System.Drawing.Point(410, 335)
        Me.RenewBut.Name = "RenewBut"
        Me.RenewBut.Size = New System.Drawing.Size(86, 23)
        Me.RenewBut.TabIndex = 3
        Me.RenewBut.Text = "Renew Item"
        Me.RenewBut.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AccessibleName = "btnLogOut"
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(759, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 34)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ReturnBut
        '
        Me.ReturnBut.AccessibleName = "btnReturn"
        Me.ReturnBut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ReturnBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReturnBut.Location = New System.Drawing.Point(544, 335)
        Me.ReturnBut.Name = "ReturnBut"
        Me.ReturnBut.Size = New System.Drawing.Size(86, 23)
        Me.ReturnBut.TabIndex = 7
        Me.ReturnBut.Text = "Return Item"
        Me.ReturnBut.UseVisualStyleBackColor = False
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me._E_Library_1DataSet
        '
        '_E_Library_1DataSet
        '
        Me._E_Library_1DataSet.DataSetName = "_E_Library_1DataSet"
        Me._E_Library_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MemberTableAdapter = Nothing
        Me.TableAdapterManager.ResourceTableAdapter = Me.ResourceTableAdapter
        Me.TableAdapterManager.UpdateOrder = ELibraryBUS110A._E_Library_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SearchBut
        '
        Me.SearchBut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SearchBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SearchBut.Location = New System.Drawing.Point(142, 335)
        Me.SearchBut.Name = "SearchBut"
        Me.SearchBut.Size = New System.Drawing.Size(86, 23)
        Me.SearchBut.TabIndex = 8
        Me.SearchBut.Text = "Search"
        Me.SearchBut.UseVisualStyleBackColor = False
        '
        '_E_Library_1DataSet2
        '
        Me._E_Library_1DataSet2.DataSetName = "_E_Library_1DataSet"
        Me._E_Library_1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 441)
        Me.Controls.Add(Me.SearchBut)
        Me.Controls.Add(Me.ReturnBut)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RenewBut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Results)
        Me.Controls.Add(Me.Review)
        Me.Name = "AccountReview"
        CType(Me._E_Library_1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELibrary1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_Library_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_Library_1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Review As Button
    Friend WithEvents ELibrary1DataSet1BindingSource As BindingSource
    Friend WithEvents _E_Library_1DataSet1 As _E_Library_1DataSet1
    Friend WithEvents _E_Library_1DataSet As _E_Library_1DataSet
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents CheckoutTableAdapter As _E_Library_1DataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents ResourceBindingSource As BindingSource
    Friend WithEvents ResourceTableAdapter As _E_Library_1DataSetTableAdapters.ResourceTableAdapter
    Friend WithEvents TableAdapterManager As _E_Library_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Results As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents RenewBut As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ReturnBut As Button
    Friend WithEvents SearchBut As Button
    Friend WithEvents _E_Library_1DataSet2 As _E_Library_1DataSet
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
