Public Class Login
    Friend Shared memberID As String
    Friend Shared loginSuccess As Boolean = False
    Friend Shared employeeid As Integer
    Friend Shared firstname As String = String.Empty
    Friend Shared lastname As String = String.Empty
    Friend Shared email As String = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_Library_1DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me._E_Library_1DataSet.Employee)
        'TODO: This line of code loads data into the '_E_Library_1DataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me._E_Library_1DataSet.Member)

    End Sub

    Private Sub MemberBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MemberBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_Library_1DataSet)

    End Sub

    Private Sub MemberBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserLoginButton_Click(sender As Object, e As EventArgs) Handles UserLoginButton.Click

        Dim NumberOfRows As Integer
        Dim RowData As Object
        Dim Password As String = String.Empty
        If txtEmail.Text = String.Empty Or TxtPassword.Text = String.Empty Then
            MessageBox.Show("Please enter your email and password.")
        Else
            NumberOfRows = MemberTableAdapter.FillByEmail(_E_Library_1DataSet.Member, txtEmail.Text)
            If NumberOfRows = 1 Then
                RowData = MemberTableAdapter.GetDataByEmail(txtEmail.Text)(0)
                Password = RowData.Password
                If Password = TxtPassword.Text Then
                    memberID = RowData.memberID
                    txtEmail.Text = ""
                    Password = ""
                    TxtPassword.Clear()
                    txtEmail.Clear()
                    loginSuccess = True
                    MessageBox.Show("Login successful.")
                    AccountReview.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Login unsuccessful, Check Username and password.")
                    TxtPassword.Clear()
                End If
            End If
            'Check employee
            If NumberOfRows <> 1 Then
                NumberOfRows = EmployeeTableAdapter.FillByEmail(_E_Library_1DataSet.Employee, txtEmail.Text)
                If NumberOfRows = 1 Then
                    RowData = EmployeeTableAdapter.GetDataByEmail(txtEmail.Text)(0)
                    Password = RowData.Password
                    If Password = TxtPassword.Text Then
                        employeeid = RowData.EmployeeID
                        firstname = RowData.FirstName
                        lastname = RowData.LastName
                        email = RowData.Email
                        Password = ""
                        TxtPassword.Clear()
                        txtEmail.Clear()
                        loginSuccess = True
                        MessageBox.Show("Employee Login successful")
                        Employee.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Employee Login unsuccessful, Check Username and password")
                        TxtPassword.Clear()

                    End If
                ElseIf NumberOfRows = 0 Then
                    MessageBox.Show("Check Username and password.")
                End If
            End If
        End If
    End Sub


    Private Sub SearchBut_Click(sender As Object, e As EventArgs) Handles SearchBut.Click
        MemberSearch.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Registration.Show()
    End Sub

End Class

