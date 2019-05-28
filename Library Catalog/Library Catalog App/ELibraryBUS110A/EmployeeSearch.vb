Public Class EmployeeSearch

    Private Sub MemberSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_Library_1DataSet.Resource' table. You can move, or remove it, as needed.
        'Me.ResourceTableAdapter.Fill(Me._E_Library_1DataSet.Resource)

    End Sub

    'Search results should also indicate if each resource's status 
    '(whether the resource Is available for checkout Or Not).

    'Cueing or instructions are provided for search fields.

    'OutcomeClicking Checkout Button should insert a New record into the CheckOut Table.

    Dim DueDate As Date
    Dim resourceid As String
    Dim CheckoutPeriod As Long
    Dim Resourcestatus As String
    Dim decision As Integer
    Private Sub SearchBut_CLick(sender As Object, e As EventArgs) Handles SearchBut.Click

        ResultsDataGrid.Rows.Clear()

        Dim title = Me.txtTitle.Text
        If String.IsNullOrEmpty(txtTitle.Text) = False Then
            title = ("%" & Me.txtTitle.Text & "%")
        End If
        Dim ISBN = Me.txtISBN.Text
        Dim splitname = Split(Me.txtLastName.Text, ",")
        Dim Authorlast = splitname(0)
        Dim Series = Me.txtseries.Text
        If String.IsNullOrEmpty(txtseries.Text) = False Then
            Series = ("%" & Me.txtseries.Text & "%")
        End If
        Dim NumberOfRows As Integer
        Dim RowData As Object
        Dim checkedoutbooks As Object
        Dim checkedoutbookinfo As Object
        Dim checkoutdate As Date
        Dim defaultdate As Date

        If String.IsNullOrEmpty(txtISBN.Text) And String.IsNullOrEmpty(txtseries.Text) _
            And String.IsNullOrEmpty(txtLastName.Text) And String.IsNullOrEmpty(txtTitle.Text) Then
            MessageBox.Show("Please Enter at least one field.")
        Else
            'find number of rows with fullfilled criteria
            NumberOfRows = ResourceTableAdapter.FillByTitleAuthorLastSeriesISBN(_E_Library_1DataSet.Resource, title, Authorlast, Series, ISBN)
            'if there is any item
            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1
                    'get data from each item
                    RowData = ResourceTableAdapter.GetDataByTitleAuthorLastSeriesISBN(title,
                                                                                        Authorlast, Series, ISBN)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckoutTableAdapter.FillByResourceID(_E_Library_1DataSet.Checkout, resourceid)
                    'if there is a checkout book
                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckoutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.CheckOutDate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Due " & DueDate
                    Else
                        checkoutdate = Nothing
                        Resourcestatus = "Available"
                    End If

                    'add info to all appropriate cells
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorfirst
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publicationdate
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    If (DateTime.Compare(checkoutdate, defaultdate) = 0) Then
                        dgvCell.Value = ""

                    Else
                        dgvCell.Value = checkoutdate
                    End If
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.ISBN
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    ResultsDataGrid.Rows.Add(dgvRow)
                Next

            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results matching your search were found. Please try again.")
            End If
        End If
    End Sub

    'clear return result and type in text. 
    Private Sub ClearBut_Click(sender As Object, e As EventArgs) Handles ClearBut.Click
        txtTitle.Text = ""
        txtseries.Text = ""
        txtLastName.Text = ""
        txtISBN.Text = ""

        ResultsDataGrid.Rows.Clear()
    End Sub

    Private Sub LogoutBut_Click(sender As Object, e As EventArgs) Handles LogoutBut.Click
        If Login.loginSuccess = True Then
            decision = MessageBox.Show("Are you sure you want to log out?", "caption", MessageBoxButtons.YesNo)
            If decision = DialogResult.Yes Then
                Me.Hide()
                Login.Show()
                Login.loginSuccess = False
                Login.BringToFront()
            End If
        Else
            MessageBox.Show("You were never login")
        End If
    End Sub

    Private Sub CheckOutBut_Click(sender As Object, e As EventArgs) Handles CheckOutBut.Click
        Me.Hide()
        AddResource.Show()
        AddResource.BringToFront()
    End Sub

    'show account review
    Private Sub accountBut_Click(sender As Object, e As EventArgs) Handles accountBut.Click
        If Login.loginSuccess = True Then
            Me.Hide()
            Employee.Show()
            Employee.BringToFront()
        Else
            MessageBox.Show("You have not log in successful yet.")
        End If
    End Sub

End Class
