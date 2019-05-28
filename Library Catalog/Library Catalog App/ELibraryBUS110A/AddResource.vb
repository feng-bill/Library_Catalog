Public Class AddResource

    'return false if there is any character
    Private Function onlyNum(str As String) As Boolean
        For index As Integer = 0 To str.Length - 1

            If Not Char.IsDigit(str.ElementAt(index)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub AddResourceBut_Click(sender As Object, e As EventArgs) Handles AddResourceBut.Click
        Dim existingResource As Integer
        Dim subjects(1) As String
        Dim subject1 As String
        Dim subject2 As String
        Dim resourceid As String = "%" & TxtResourceID.Text & "%"
        Dim newresource As String
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim decision As Integer
        'check how many boxes are clicked
        For Each i As Object In CheckedListBox1.CheckedItems
            subjects(x) = i.ToString
            x += 1
        Next

        subject1 = subjects(0)
        subject2 = subjects(1)

        'make sure user select at least one item
        If String.IsNullOrEmpty(subject1) And String.IsNullOrEmpty(subject2) Then
            MessageBox.Show("Please select at least one subject area for this resource.")

        Else
            If String.IsNullOrEmpty(subject1) Then
                subject1 = "--"
            End If

            If String.IsNullOrEmpty(subject2) Then
                subject2 = "--"
            End If

            'Add resource if is correct numeric id
            'all number and length = 7 
            If IsNumeric(TxtResourceID.Text) And TxtResourceID.Text.Length = 7 Then
                existingResource = ResourceTableAdapter.FillByResourceID(_E_Library_1DataSet.Resource, resourceid)

                'last name, checkoutperiod, isbn, title must be filled in
                If String.IsNullOrEmpty(TxtAuthorLAst.Text) Or String.IsNullOrEmpty(TxtCheckoutPeriod.Text) _
                    Or String.IsNullOrEmpty(TxtISBN.Text) Or String.IsNullOrEmpty(TxtTitle.Text) Or
                    String.IsNullOrEmpty(TxtPubDate.Text) Or String.IsNullOrEmpty(TxtAuthorFirst.Text) Then
                    MessageBox.Show("Please fill in all the required field.")

                    'Checkout period must be numeric
                ElseIf IsNumeric(TxtCheckoutPeriod.Text) = False Then
                    MessageBox.Show("Please enter an integer for checkout period.")
                    'check if publication year makes sense
                ElseIf IsNumeric(TxtPubDate.Text) = False Or TxtPubDate.Text.Length <> 4 Then
                    MessageBox.Show("Please enter 4 digit number for publication year, and we only
accept books from 1900 - 2017")
                ElseIf Int(TxtPubDate.Text) < 1900 Then
                    MessageBox.Show("Please enter 4 digit number for publication year, and we only
accept books from 1900 - 2017")
                ElseIf (Int(TxtPubDate.Text) > 2017) Then
                    MessageBox.Show("Please enter 4 digit number for publication year, and we only
accept books from 1900 - 2017")
                    'check isbn to be right format
                ElseIf TxtISBN.Text.Length <> 10 And TxtISBN.Text.Length <> 14 Then
                    MessageBox.Show("Please enter a valid 10 or 13 digit ISBN with '-' at the 4th character for ISBN")
                ElseIf TxtISBN.Text.Length = 10 And IsNumeric(TxtISBN.Text) = False Then
                    MessageBox.Show("Please enter a valid 10 or 13 digit ISBN with '-' at the 4th character for ISBN")
                ElseIf TxtISBN.Text.Length = 14 And TxtISBN.Text.ElementAt(3) <> "-" Then
                    MessageBox.Show("Please enter a valid 10 or 13 digit ISBN with '-' at the 4th character for ISBasdfN")
                    'title cant have number
                ElseIf IsNumeric(TxtTitle.Text) Then
                    MessageBox.Show("You can't have a numeric title.")
                    'name cant have number
                ElseIf onlyNum(TxtAuthorFirst.Text) Then
                    MessageBox.Show("You can't have a number in your first name.")
                    'name cant have number
                ElseIf onlyNum(TxtAuthorLAst.Text) Then
                    MessageBox.Show("You can't have a number in your last name.")
                ElseIf onlyNum(TxtAuthorMiddle.Text) Then
                    MessageBox.Show("You can't have a number in your middle name.")
                ElseIf IsNumeric(TxtSeries.Text) Then
                    MessageBox.Show("You can't have a numeric series.")
                ElseIf IsNumeric(TxtBookInfo.Text) Then
                    MessageBox.Show("You can't have a numeric book info.")

                    'Check if ResourceID is not taken
                ElseIf existingResource = 0 Then
                    newresource = "b" + TxtResourceID.Text + "_1"
                    ResourceTableAdapter.InsertNewResource(newresource, TxtTitle.Text,
                                                           TxtAuthorLAst.Text, TxtAuthorFirst.Text,
                                                           TxtAuthorMiddle.Text, TxtPubDate.Text, TxtSeries.Text,
                                                           TxtISBN.Text, TxtCheckoutPeriod.Text, subject1, subject2,
                                                           TxtBookInfo.Text)
                    MessageBox.Show("Record successfully added")
                    Dim i As Control
                    For Each i In Me.Controls
                        If TypeOf i Is TextBox Then
                            i.Text = ""
                        End If
                    Next
                Else
                    'add resource when item is repeated. 
                    'prompt user choice to decide continue or cancel
                    decision = MessageBox.Show("You are about to add an existing book. Did you want to do that?", "caption", MessageBoxButtons.YesNo)
                    If decision = DialogResult.Yes Then
                        'create resource id start with m
                        newresource = "b" + TxtResourceID.Text + (existingResource + 1).ToString

                        ResourceTableAdapter.InsertNewResource(newresource, TxtTitle.Text,
                                                           TxtAuthorLAst.Text, TxtAuthorFirst.Text,
                                                           TxtAuthorMiddle.Text, TxtPubDate.Text, TxtSeries.Text,
                                                           TxtISBN.Text, TxtCheckoutPeriod.Text, subject1, subject2,
                                                           TxtBookInfo.Text)
                        MessageBox.Show("Record succefully added for +1 resources")
                        'clear form
                        Dim i As Control
                        For Each i In Me.Controls
                            If TypeOf i Is TextBox Then
                                i.Text = ""
                            End If
                        Next
                    End If
                End If
            Else
                MessageBox.Show("Please ONLY enter a 7 digit Resource ID!")
            End If
        End If
    End Sub


    Private Sub ResourceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ResourceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_Library_1DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Employee.Show()
    End Sub

    Private Sub SearchBut_Click(sender As Object, e As EventArgs) Handles SearchBut.Click
        'clear form
        Dim i As Control
        For Each i In Me.Controls
            If TypeOf i Is TextBox Then
                i.Text = ""
            End If
        Next
        Me.Hide()
        EmployeeSearch.Show()

    End Sub

    Private Sub LogoutBut_Click(sender As Object, e As EventArgs)
        Login.loginSuccess = False
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub HomeBut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AccountReview.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.loginSuccess = False
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub accountBut_Click(sender As Object, e As EventArgs) Handles accountBut.Click
        Me.Hide()
        Employee.Show()
        Employee.BringToFront()
    End Sub
End Class