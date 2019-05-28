Public Class Registration
    Dim state As String = ""
    Dim existingEmail As Integer
    Dim decision As Integer

    'Create unique member id
    Private Function CreateMemberID() As String
        Dim notFinish As Boolean = True
        Randomize()
        Dim memberID As String = "PLIV"
        'Ramdom value from 1 - 99999
        While notFinish
            Dim randomValue = CInt(Int(99999 * Rnd()) + 1).ToString
            'Create proper MemberID format 
            memberID += randomValue
            MessageBox.Show("Please get ready and write down your memeberID.")
            MessageBox.Show("MemberID is: " + memberID)
            'Count How many same memberID
            Dim memberCount = MemberTableAdapter.FillByMemberID(_E_Library_1DataSet.Member, memberID)
            'if there is any, reset memberID and make random value again
            If memberCount = 1 Then
                memberID = "PLIV"
                Continue While
            Else   'Is unique, escape loop
                notFinish = False
            End If
        End While
        'Returning a unique correct memberID #PLIV12345
        Login.memberID = memberID
        Return memberID

    End Function

    'Return True If have number
    Private Function hasNum(str As String) As Boolean
        Dim myChars() As Char = str.ToCharArray()
        For Each ch As Char In myChars
            If Char.IsDigit(ch) Then
                Return True
            End If
        Next
        Return False
    End Function

    'return false if there is any character
    Private Function onlyNum(str As String) As Boolean
        For index As Integer = 0 To str.Length - 1

            If Not Char.IsDigit(str.ElementAt(index)) Then
                Return False
            End If
        Next
        Return True
    End Function

    'Return True if have number then space then letter
    'ex: 123 d
    'Return True
    Private Function validAddress(str As String) As Boolean
        Dim nextIndex = 0
        Dim myChars() As Char = str.ToCharArray()
        'check if only numer, rest must have letter
        If onlyNum(str) = False Then
            For index As Integer = 0 To str.Length - 1
                'check first element compare to next element
                'if first is number and next is word, should be correct
                If IsNumeric(str.ElementAt(index)) Then
                    'EX: 123 Geneva
                    If str.ElementAt(index + 1) = " " Then
                        Char.IsLetter(str.ElementAt(index + 2))
                        Return True
                        'take care of user dont put space
                        'EX: 123Geneva
                    ElseIf Char.IsLetter(str.ElementAt(index + 1)) Then
                        Return True
                    End If
                End If
            Next
        End If

        Return False
    End Function

    'Return boolean of valid email format or not
    'In a form "someone@example.com"
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
        "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
       emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    'Register Account, insert member info into database
    Private Sub RegisterBut_Click(sender As Object, e As EventArgs) Handles RegisterBut.Click
        Dim RowData As Object
        Dim EmailArray() As String = EmailTxt.Text.Split("@")
        Dim Result As String = EmailArray(1)

        'Check for empty
        If EmailTxt.Text.Trim = "" Then
            MessageBox.Show("Please enter an email address.")
            'Check for valid formate
        ElseIf ValidateEmail(EmailTxt.Text.Trim) = False Then
            MessageBox.Show("Invalid email Address - Please re-enter.")
        Else
            'Number of existing email
            existingEmail = MemberTableAdapter.FillByEmail(_E_Library_1DataSet.Member, EmailTxt.Text.Trim)

            'Check for existing email registered.
            'Only allow empty email address
            If existingEmail = 1 Then
                MessageBox.Show("This email had already been registered, please try 
                                another one.")
                ' if Unique email, insert new data
            ElseIf existingEmail = 0 Then
                If String.IsNullOrEmpty(FirstTxt.Text.Trim) Or String.IsNullOrEmpty(LastTxt.Text.Trim) Or
                    String.IsNullOrEmpty(PasswordTxt.Text.Trim) Or String.IsNullOrEmpty(ConfirmPasswordTxt.Text.Trim) Or
                     String.IsNullOrEmpty(AddressTxt.Text.Trim) Or String.IsNullOrEmpty(ZipCodeTxt.Text.Trim) Or
                     String.IsNullOrEmpty(ComboBox1.Text) Then
                    MessageBox.Show("Please fill in all the required field.")
                    'confirm password

                ElseIf hasNum(FirstTxt.Text.Trim + LastTxt.Text.Trim + CityTxt.Text.Trim) Then
                    MessageBox.Show("Please only enter letters for names and cities.")
                ElseIf PasswordTxt.Text.Length < 6 Then
                    MessageBox.Show("Please enter a password that has at least 6 characters")
                ElseIf Result.Length < 5 Then
                    MessageBox.Show("Please enter a website for your email")
                ElseIf validAddress(AddressTxt.Text.Trim) = False Then
                    MessageBox.Show("Please enter a valid address. Format as follow.
                    'EX: 123 Geneva")
                ElseIf PasswordTxt.Text.Trim <> ConfirmPasswordTxt.Text.Trim Then
                    MessageBox.Show("Your password dont match.")
                ElseIf IsNumeric(ZipCodeTxt.Text.Trim) = False Or ZipCodeTxt.Text.Trim.Length <> 5 Then
                    MessageBox.Show("Invalid zip code - please enter 5 digits only")
                Else
                    MemberTableAdapter.InsertNewMember(CreateMemberID, FirstTxt.Text, LastTxt.Text,
                                                   AddressTxt.Text, CityTxt.Text, ComboBox1.Text,
                                                   ZipCodeTxt.Text, EmailTxt.Text, PasswordTxt.Text, 12)
                    MessageBox.Show("You have succesfully registered.")
                    ComboBox1.SelectedItem = Nothing
                    Dim i As Control
                    For Each i In Me.Controls
                        If TypeOf i Is TextBox Then
                            i.Text = ""
                        End If
                    Next

                    'Auto log in

                    Login.loginSuccess = True
                    Me.Hide()
                    AccountReview.Show()
                    AccountReview.BringToFront()


                End If
            End If
        End If
    End Sub

    Private Sub MemberBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MemberBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_Library_1DataSet)

    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_Library_1DataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me._E_Library_1DataSet.Member)

    End Sub

    Private Sub ClearBut_Click(sender As Object, e As EventArgs) Handles ClearBut.Click
        Dim i As Control
        For Each i In Me.Controls
            If TypeOf i Is TextBox Then
                i.Text = ""
            End If
        Next
        ComboBox1.SelectedItem = Nothing

    End Sub

    Private Sub HomeBut_Click(sender As Object, e As EventArgs) Handles HomeBut.Click
        Dim i As Control
        For Each i In Me.Controls
            If TypeOf i Is TextBox Then
                i.Text = ""
            End If
        Next
        ComboBox1.SelectedItem = Nothing
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub CancelBut_Click(sender As Object, e As EventArgs) Handles CancelBut.Click
        decision = MessageBox.Show("Are you sure you don't want to register?", "caption", MessageBoxButtons.YesNo)
        If decision = DialogResult.Yes Then
            Dim i As Control
            For Each i In Me.Controls
                If TypeOf i Is TextBox Then
                    i.Text = ""
                End If
            Next
            ComboBox1.SelectedItem = Nothing
            Me.Hide()
            Login.Show()
        End If

    End Sub


End Class