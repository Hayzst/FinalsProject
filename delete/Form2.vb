Imports System.Data.OleDb
Imports System.Security.Cryptography.Xml
Imports Guna.UI2.WinForms

Public Class Form2
    Dim userControlInstance As UserControl1
    Dim userName As String = ""
    Private mainFormInstance As Form1
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Carl\Documents\POCdatabase.accdb")
    Public Sub New(mainForm As Form1)
        ' Store a reference to the existing instance of Form1
        mainFormInstance = mainForm
        InitializeComponent()
        userControlInstance = mainFormInstance.UserControl11
    End Sub

    Private Sub DoneLogin()
        Dim feature As Integer = 0
        If Me.UserAdminLABELLLLL.Text = "Admin Login" Then
            feature = 1
        End If
        mainFormInstance.succesfulLogin(feature)
        Me.Panel1.Visible = True
        Me.Panel2.Visible = False
        Me.pnlCober.Visible = True
        Me.btnContinue.Visible = False
        Me.pnlCober.BringToFront()

        Me.Location = New Point(865, 408)
        Me.Size = New Size(290, 200)
    End Sub
    '----------------------------- LOGIN BUTTON
    Private Sub LOGINbtn_Click(sender As Object, e As EventArgs) Handles LOGINbtn.Click
        mycon.Open()
        Dim myread As OleDbDataReader = Nothing
        Dim mycmd As New OleDbCommand("SELECT * FROM UserAdmin WHERE username = '" & usernameTXT.Text & "' AND password = '" & passwordTXT.Text & "'", mycon)
        Try
            myread = mycmd.ExecuteReader
            If myread.Read Then
                If Me.UserAdminLABELLLLL.Text = "Admin Login" Then
                    If myread("position").ToString() = "Admin" Then
                        If Me.LOGINbtn.FillColor2 = Color.Black Then
                            pnlLogin.Hide()
                            pnlRegister.Show()

                        Else
                            '------- SUCCESFUL LOGIN              -----------------------------------------                                           
                            userControlInstance.User = myread("username").ToString
                            DoneLogin()
                        End If
                    Else
                        MsgBox("Not an admin.")
                    End If
                Else
                    userControlInstance.User = myread("username").ToString
                    DoneLogin()
                End If
            Else
                MsgBox("Incorrect username or password")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ' Close the connection in the finally block to ensure it's always closed
            If mycon.State = ConnectionState.Open Then
                mycon.Close()
            End If
        End Try
        '----------------------------------------------------------------------------------------------------------
    End Sub
    Public Sub SetTitle(title As String)
        Me.UserAdminLABELLLLL.Text = title
        If title = "Admin Login" Then
            Me.LOGINbtn.FillColor = Color.Firebrick
            Me.LOGINbtn.FillColor2 = Color.Firebrick
            Me.usernameTXT.PlaceholderText = "User ID"
            Me.passwordTXT.PlaceholderText = "Passcode"
            Me.CreateAccountBTN.Visible = False
        End If
    End Sub



    '----------------------------------------------------------------------------------------------------------------------
    Private Sub loginAsAdminFIrst()
        Me.Location = New Point(865, 300)
        Me.Size = New Size(290, 200)

        Me.pnlCober.BringToFront()
        Me.pnlCober.Visible = True

        Me.Panel1.Visible = False
        Me.Panel2.Visible = True
        Me.btnDone.Visible = False
        Me.btnContinue.Visible = True
        Me.btnContinue.BringToFront()
    End Sub

    '---------------------------- btn DONE -- last thing before going back to form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnDone.Click, btnContinue.Click
        Me.Panel1.Visible = True
        Me.Panel2.Visible = False

        If sender.Text = "Done" Then
            mainFormInstance.pnlPOC.BringToFront()
            Me.Hide()
        Else
            Me.btnDone.Visible = True
            Me.Location = New Point(850, 180)
            Me.Size = New Size(337, 478)
            Me.pnlCober.Visible = False
            Me.pnlLogin.BringToFront()
            Me.UserAdminLABELLLLL.Text = "Admin Login"
            Me.LOGINbtn.FillColor = Color.Firebrick
            Me.LOGINbtn.FillColor2 = Color.Black
            Me.usernameTXT.PlaceholderText = "User ID"
            Me.passwordTXT.PlaceholderText = "Passcode"
            Me.CreateAccountBTN.Visible = False
        End If


    End Sub
    Private Sub CreateAccountBTN_Click(sender As Object, e As EventArgs) Handles CreateAccountBTN.Click
        loginAsAdminFIrst()
        'pnlLogin.Hide()
        'pnlRegister.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblBackButton.Click
        pnlLogin.Show()
        pnlRegister.Hide()
    End Sub

    Private Sub Guna2ControlBox4_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox4.Click
        mainFormInstance.pnlCover.Visible = False
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If regisEmail.Text = "" Or DropDownBox.Text = "" Or regisUsername.Text = "" Or regisUserID.Text = "" Or regisPassword.Text = "" Then
            MsgBox("Please fill in all details")
        Else
            mycon.Open()
            Try
                Dim mycmd2 As New OleDbCommand("insert into UserAdmin([username], [password], [email], [userid], [position]) Values ('" & regisUsername.Text & "', '" & regisPassword.Text & "','" & regisEmail.Text & "','" & regisUserID.Text & "','" & DropDownBox.Text & "')", mycon)
                mycmd2.ExecuteNonQuery()
                mycon.Close()
                regisUserID.Clear()
                regisUsername.Clear()
                regisEmail.Clear()
                regisPassword.Clear()
                MsgBox("Succesfully Registered!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub
    '-------------------------------------- Register Form Close Button
    Private Sub Guna2ControlBox9_Click(sender As Object, e As EventArgs) Handles RegisterCloseButton.Click
        RegisterCloseButton.Visible = False
        mainFormInstance.MenuPanel.Visible = True
        mainFormInstance.btnPOS.PerformClick()
        mainFormInstance.showCoverPanel(1)
        'mainFormInstance.pnlbtn.Height = mainFormInstance.btnPOS.Height
        'mainFormInstance.pnlbtn.Top = mainFormInstance.btnPOS.Top
        'mainFormInstance.pnlPOC.BringToFront()
    End Sub
End Class