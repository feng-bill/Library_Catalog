Imports ELibraryBUS110A._E_Library_1DataSet1TableAdapters

Public Class Employee
    Dim RowData As Object
    Dim NumberOfRows As Integer
    Dim memberid As String = Login.memberID

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_Library_1DataSet.Resource' table. You can move, or remove it, as needed.
        'Me.ResourceTableAdapter.Fill(Me._E_Library_1DataSet.Resource)
        'TODO: This line of code loads data into the '_E_Library_1DataSet.Checkout' table. You can move, or remove it, as needed.
        'Me.CheckoutTableAdapter.Fill(Me._E_Library_1DataSet.Checkout)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SearchBut.Click
        EmployeeSearch.Show()
        Me.Hide()
    End Sub

    Private Sub LoggoutBut_Click(sender As Object, e As EventArgs) Handles LoggoutBut.Click
        memberid = ""
        Me.Hide()
        Login.Show()
        Login.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = Login.employeeid
        TextBox6.Text = Login.firstname
        TextBox7.Text = Login.lastname
        TextBox8.Text = Login.email
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AddResource.Show()
    End Sub

End Class

