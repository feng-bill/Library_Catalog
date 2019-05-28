<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me._E_Library_1DataSet1 = New ELibraryBUS110A._E_Library_1DataSet1()
        Me.ELibrary1DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoggoutBut = New System.Windows.Forms.Button()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._E_Library_1DataSet = New ELibraryBUS110A._E_Library_1DataSet()
        Me.CheckoutTableAdapter = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.CheckoutTableAdapter()
        Me.ResourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourceTableAdapter = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.ResourceTableAdapter()
        Me.TableAdapterManager = New ELibraryBUS110A._E_Library_1DataSetTableAdapters.TableAdapterManager()
        Me.SearchBut = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me._E_Library_1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELibrary1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_Library_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Menu
        Me.Label1.Location = New System.Drawing.Point(64, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 72)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee Account " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Review"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoggoutBut
        '
        Me.LoggoutBut.AccessibleName = "btnLogOut"
        Me.LoggoutBut.BackgroundImage = CType(resources.GetObject("LoggoutBut.BackgroundImage"), System.Drawing.Image)
        Me.LoggoutBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoggoutBut.Location = New System.Drawing.Point(762, 51)
        Me.LoggoutBut.Name = "LoggoutBut"
        Me.LoggoutBut.Size = New System.Drawing.Size(29, 32)
        Me.LoggoutBut.TabIndex = 6
        Me.LoggoutBut.UseVisualStyleBackColor = True
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
        Me.SearchBut.Location = New System.Drawing.Point(64, 390)
        Me.SearchBut.Name = "SearchBut"
        Me.SearchBut.Size = New System.Drawing.Size(109, 23)
        Me.SearchBut.TabIndex = 8
        Me.SearchBut.Text = "Employee Search"
        Me.SearchBut.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(103, 236)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(82, 21)
        Me.TextBox5.TabIndex = 13
        Me.TextBox5.Text = "Employee ID"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(81, 192)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 21)
        Me.TextBox6.TabIndex = 14
        Me.TextBox6.Text = "First Name"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(201, 192)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 21)
        Me.TextBox7.TabIndex = 15
        Me.TextBox7.Text = "Last Name"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(201, 236)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(100, 21)
        Me.TextBox8.TabIndex = 16
        Me.TextBox8.Text = "Email"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(129, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "View My Information"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(212, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Add Resource"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(174, 341)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Or..."
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(81, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(22, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "ID:"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(856, 440)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.SearchBut)
        Me.Controls.Add(Me.LoggoutBut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Employee"
        CType(Me._E_Library_1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELibrary1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_Library_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ELibrary1DataSet1BindingSource As BindingSource
    Friend WithEvents _E_Library_1DataSet1 As _E_Library_1DataSet1
    Friend WithEvents _E_Library_1DataSet As _E_Library_1DataSet
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents CheckoutTableAdapter As _E_Library_1DataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents ResourceBindingSource As BindingSource
    Friend WithEvents ResourceTableAdapter As _E_Library_1DataSetTableAdapters.ResourceTableAdapter
    Friend WithEvents TableAdapterManager As _E_Library_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents LoggoutBut As Button
    Friend WithEvents SearchBut As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
