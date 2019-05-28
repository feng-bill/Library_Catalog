Imports ELibraryBUS110A._E_Library_1DataSet1TableAdapters

Public Class AccountReview
    Dim RowData As Object
    Dim CheckoutPeriod As Long
    Dim NumberOfRows As Integer
    Dim CheckedOutRecord As Integer
    Dim bookinfo As Object
    Dim resourceid As String
    Dim Resourcestatus As String
    Dim DueDate As Date
    Dim checkoutdate As Date
    Dim memberid As String = Login.memberID

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Review_Click(sender As Object, e As EventArgs) Handles Review.Click
        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckout(_E_Library_1DataSet.Checkout, memberid)
        'if the member has at least one book checked out then…
        If NumberOfRows > 0 Then
            Results.Rows.Clear()
            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView 
            For x = 0 To NumberOfRows - 1 Step 1
                bookinfo = CheckoutTableAdapter.GetDataByMemberCheckout(memberid)(x)
                resourceid = bookinfo.resourceID
                RowData = ResourceTableAdapter.GetDataByResourceID(resourceid)(0)

                'calculate the due date for a book based on the check out date and the book’s checkout period. 
                checkoutdate = bookinfo.checkoutdate
                CheckoutPeriod = RowData.checkoutperiod
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)

                'at “due” to the due date so that the member knows when the book is due            
                Resourcestatus = "Due " & DueDate.Date

                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add title to the first column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                'add author’s last name to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.authorlast
                dgvRow.Cells.Add(dgvCell)

                'add publication date to the 3rd  column of the DataGridView              
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.publicationdate
                dgvRow.Cells.Add(dgvCell)

                'add series to the 4th column of the DataGridView      
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Series
                dgvRow.Cells.Add(dgvCell)

                'add checkout data to the 5th column of the DataGridView           
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = checkoutdate.Date
                dgvRow.Cells.Add(dgvCell)

                'add resourcestatus, created above, to the 6th column of the DataGridView          
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Resourcestatus
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 7th column of the DataGridView              
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 8th column of the DataGridView              
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = resourceid
                dgvRow.Cells.Add(dgvCell)

                'Results is the name of the DataGridView Control added to the Form  
                Results.Rows.Add(dgvRow)
            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        End If
    End Sub


    Private Sub RenewBut_Click_1(sender As Object, e As EventArgs) Handles RenewBut.Click
        'Renew
        Dim currentdate As Date = Date.Today.Date
        NumberOfRows = CheckoutTableAdapter.FillByMemberID(_E_Library_1DataSet.Checkout, memberid)

        If NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else

            If Results.SelectedCells.Count = 0 Then
                MessageBox.Show("Please select the book you wish to renew")
            Else

                'renew book by altering the due date and updating the record selected in 
                ''the “results” data grid the numbers in parentheses are the index of the 
                'data grid column holding the piece of information needed.
                resourceid = Results.SelectedCells(7).Value
                CheckoutTableAdapter.RenewBookUpdateQuery(currentdate, resourceid)

                CheckoutPeriod = Results.SelectedCells(6).Value
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, currentdate)
                Resourcestatus = "Due " & DueDate.Date
                Results.SelectedCells(5).Value = Resourcestatus
                Results.SelectedCells(4).Value = currentdate

                MessageBox.Show("you have successfully renewed your book.",
                                " Book Renewal Successful", MessageBoxButtons.OK)

            End If
        End If

    End Sub

    Private Sub ReturnBut_Click(sender As Object, e As EventArgs) Handles ReturnBut.Click
        'Return
        Dim currentdate As Date = Date.Today.Date
        NumberOfRows = CheckoutTableAdapter.FillByMemberID(_E_Library_1DataSet.Checkout, memberid)

        If NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else

            If Results.SelectedCells.Count = 0 Then
                MessageBox.Show("Please select the book you wish to return")
            Else

                'return book by altering the due date and updating the record selected in ‘the “results” data grid the numbers in parentheses are the index of the ‘data grid column holding the piece of information needed.
                resourceid = Results.SelectedCells(7).Value
                CheckoutTableAdapter.ReturnDateUpdateQuery(currentdate, resourceid)

                CheckoutPeriod = Results.SelectedCells(6).Value
                DueDate = currentdate
                Resourcestatus = "returned"
                Results.SelectedCells(6).Value = Resourcestatus
                Results.SelectedCells(5).Value = DueDate

                MessageBox.Show("You have successfully return your book.", " Book Returnl Successful", MessageBoxButtons.OK)

            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SearchBut.Click
        MemberSearch.ResultsDataGrid.Rows.Clear()
        Me.Hide()
        MemberSearch.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        memberid = ""
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

