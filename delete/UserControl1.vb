Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader
Public Class UserControl1
    'Dim todayDate As DateTime = DateTime.Today
    'Dim dateString As String = todayDate.ToString("MM/dd/yyyy")

    Dim todayDate = Today
    Dim nowDateTime = TimeOfDay
    Dim paymentMethod As String = ""
    Dim amount As String = ""
    Public Property User As String
    '--------------------- Transaction Details
    Dim tags As String = ""

    Dim itemsTransaction As String = ""
    Dim QtyTransaction As String = ""
    Private Sub QtyPileUP()
        Form1.SalesReceiptDetails_datagrid.Rows.Clear()
        QtyTransaction = ""
        For Each row As DataGridViewRow In BillDataGrid.Rows
            If row.Cells(1).Value IsNot Nothing Then
                QtyTransaction &= row.Cells(1).Value.ToString & ","
            End If
        Next
        Dim QtySeperate() As String = QtyTransaction.Split(","c)

    End Sub
    Private Sub ItemPileUp()
        itemsTransaction = ""
        For Each row As DataGridViewRow In BillDataGrid.Rows
            If row.Cells(0).Value IsNot Nothing Then
                itemsTransaction &= row.Cells(0).Value.ToString & ","
            End If
        Next
        Dim ItemSeperate() As String = itemsTransaction.Split(","c)

    End Sub

    Private Sub setTransactionIDdetials()
        Dim tagNumber(tags.Length)
        For x As Integer = 1 To tags.Length / 2
            Dim i = 1
            tagNumber(i - 1) = tags.Chars(i - 1)
            tagNumber(i) = tags.Chars(i)
            i += 2
        Next x
        For y As Integer = 0 To ((tags.Length / 2) - 1)

        Next
        tags = ""
    End Sub


    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Carl\Documents\Documentation.accdb")
    '--------------------------------ALL ITEMS CLICK
    Private Sub itemClick(sender As Object, e As EventArgs) Handles Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click
        TabControl1.SelectedIndex = 0
        tags &= sender.tag
        mycon.Open()
        Dim mycmd As New OleDbCommand("Select * from tblStock where ItemID =" & sender.tag & "", mycon)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        Dim PricePerItem As Integer
        Try
            If myread.Read Then
                PricePerItem = Val(myread("PricePerItem").ToString)
                btnCostandRowAdd(sender, PricePerItem)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If mycon.State = ConnectionState.Open Then
                mycon.Close()
            End If
        End Try

    End Sub
    Private Sub btnCostandRowAdd(sender, price)
        For Each row As DataGridViewRow In BillDataGrid.Rows
            If row.Cells(0).Value = sender.Text Then
                row.Cells(1).Value = CInt(row.Cells(1).Value) + 1
                row.Cells(2).Value = CInt(row.Cells(2).Value) + price
                addCost()
                lblChange.Text = ""
                Exit Sub
            End If
        Next
        BillDataGrid.Rows.Add(sender.Text, 1, price)
        lblChange.Text = ""
        addCost()
    End Sub
    '---------------------------- PAY PAYYYYYYYYYYYYYYYYYYY ----------------
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        'MsgBox(tags)
        'MsgBox(QtyTransaction)
        'MsgBox(itemsTransaction)


        If cbPayment.Text = "" Then
            MsgBox("Please select Payment Method")
        ElseIf cbPayment.Text = "Cash" Then
            '------------------- SUCCESSFUL payment -------------------------------------------            
            txtReceipt.Clear()
            QtyPileUP()
            ItemPileUp()
            Dim bool As Boolean = Change()

            If bool Then
                TabControl1.SelectedIndex = 1
                btnC.Enabled = False
                receiptTab()
                insertDatatoDocumentation()
                MsgBox("Succesful Payment")
                ResetbtnotReceipt
            End If

        Else
            TabControl1.SelectedIndex = 1
            txtReceipt.Clear()
            receiptTab()
            QtyPileUP()
            ItemPileUp()
            insertDatatoDocumentation()
            MsgBox("Succesful Payment")
            ResetbtnotReceipt()
        End If

    End Sub
    '=------------------------------------ ALL CHANGES TO DOCUMENTATION
    Private Sub insertDatatoDocumentation()
        amount = lblTotal.Text
        paymentMethod = cbPayment.Text

        Try
            mycon.Open()
            ' Execute commands here
            Dim mycmd As New OleDbCommand("Insert into tblSales([Dates], [Time], [PaymentMethod], [Amount], [User]) values ('" & todayDate & "','" & nowDateTime & "','" & paymentMethod & "','" & amount & "','" & User & "')", mycon)
            mycmd.ExecuteNonQuery()

            Dim cmdValueOfID As New OleDbCommand("Select TOP 1 * from tblSales ORDER BY TRANSACTIONID DESC", mycon)
            Dim readValueLastRow As OleDbDataReader = cmdValueOfID.ExecuteReader
            Dim TransactionID As Integer
            If readValueLastRow.Read Then
                TransactionID = readValueLastRow("TransactionID")
            End If

            Dim cmdTransactionDetail As New OleDbCommand("Insert into TransactionDetails([TransactionID], [Item], [QTY]) values ('" & TransactionID & "','" & itemsTransaction & "','" & QtyTransaction & "')", mycon)
            cmdTransactionDetail.ExecuteNonQuery()
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex)
            'System.ArgumentException: 'Argument 'Prompt' cannot be converted to type 'String'.'
            Exit Sub
        End Try



    End Sub
    Dim ItemName(10) As String
    Dim ItemNumber(10) As String


    Dim vbnewline As String = vbCrLf
    Private Sub receiptTab()
        'Receipt Print        

        txtReceipt.AppendText("" + vbnewline)
        txtReceipt.AppendText("SHOPPING SYSTEM" + vbnewline)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)
        txtReceipt.AppendText("Welcome to Mon's Bikeshop: Offering professional plumbing services." + vbnewline)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)
        txtReceipt.AppendText("" + vbnewline)


        For Each row As DataGridViewRow In BillDataGrid.Rows
            Dim paddedText As String = ""
            If row.Cells(0).Value IsNot Nothing Then
                If row.Cells(0).Value.ToString().Length < 8 Then
                    paddedText = vbTab & row.Cells(1).Value & " " & row.Cells(0).Value & vbTab & vbTab & vbTab & row.Cells(2).Value & vbTab & vbnewline
                Else
                    paddedText = vbTab & row.Cells(1).Value & " " & row.Cells(0).Value & vbTab & vbTab & row.Cells(2).Value & vbTab & vbnewline
                End If
            End If

            txtReceipt.AppendText(paddedText)


        Next
        'Print
        txtReceipt.AppendText("" + vbnewline)
        txtReceipt.AppendText(vbTab & "Total Amount: " & vbTab & lblTotal.Text + vbnewline)
        If cbPayment.Text = "Cash" Then
            txtReceipt.AppendText(vbTab & "Change: " & vbTab & vbTab & lblChange.Text + vbnewline)
        Else
            txtReceipt.AppendText(vbTab & "Payment Method: " & vbTab & cbPayment.Text + vbnewline)
        End If


        txtReceipt.AppendText(" " & vbnewline)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)

        'txtReceipt.AppendText (txtNotes.Text + vbNewLine)

        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = " + vbnewline)
        txtReceipt.AppendText("" + vbnewline)
        txtReceipt.AppendText(vbTab & todayDate & vbTab & nowDateTime + vbnewline + vbnewline)
        txtReceipt.AppendText("= = = = = = = ")
        txtReceipt.AppendText("THANKS FOR SHOPPING")
        txtReceipt.AppendText(" = = = = = =" + vbnewline)
    End Sub


    Private Function cost_of_item()
        Dim sum As Double = 0
        Dim i As Integer = 0

        For i = 0 To BillDataGrid.Rows.Count - 1
            sum += CDbl(BillDataGrid.Rows(i).Cells(2).Value)
        Next i
        Return sum
    End Function
    Private Sub resetCash_input()
        lblCost.Text = "0"
        lblChange.Text = ""
    End Sub
    Private Sub addCost()
        If BillDataGrid.Rows.Count > 0 Then
            lblTotal.Text = FormatCurrency(cost_of_item)
            lblBarcode.Text = cost_of_item() * 968213412
        End If
    End Sub
    Private Function Change() As Boolean
        Dim cash_payment As Double
        Dim pesoSign As Char = ChrW(&H20B1)

        If lblCost.Text.Contains(pesoSign) Then
            lblCost.Text = Val(lblCost.Text.Replace(pesoSign, "").Replace(",", ""))
        End If
        cash_payment = Val(lblCost.Text)
        If (cash_payment < cost_of_item()) Then
            MsgBox("Please enter a sufficient amount of money")
            Return False
            Exit Function
        Else
            If BillDataGrid.Rows.Count > 1 Then
                lblChange.Text = FormatCurrency(cash_payment - cost_of_item())
                lblCost.Text = FormatCurrency(Val(lblCost.Text))
                Return True
            Else
                Return False
                Exit Function
            End If
        End If

    End Function

    Private Sub ResetbtnotReceipt()
        btnC.Enabled = True
        lblChange.Text = ""
        lblCost.Text = "0"
        lblTotal.Text = ""
        lblBarcode.Text = ""
        cbPayment.Text = ""
        BillDataGrid.Rows.Clear()
        BillDataGrid.Refresh()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnC.Enabled = True
        lblChange.Text = ""
        lblCost.Text = "0"
        lblTotal.Text = ""
        lblBarcode.Text = ""
        cbPayment.Text = ""
        BillDataGrid.Rows.Clear()
        BillDataGrid.Refresh()
        txtReceipt.Clear()
    End Sub

    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn4.Click, btn7.Click, btn3.Click, btn2.Click, btn6.Click, btn5.Click, btn9.Click, btn8.Click, btnDot.Click
        Dim b As Button = sender

        If lblCost.Text = "0" Then
            If b.Name = btnDot.Name Then
                lblCost.Text += b.Text
                btnDot.Enabled = False
                btnDot.BackColor = Color.Gainsboro
            Else
                lblCost.Text = b.Text
            End If
        ElseIf b.Text = "." Then
            lblCost.Text += b.Text
            btnDot.Enabled = False
            btnDot.BackColor = Color.Gainsboro
        Else
            lblCost.Text += b.Text
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lblCost.Text = "0"
        btnDot.Enabled = True
        btnDot.BackColor = Color.White
        lblChange.Text = ""
    End Sub
    Private Sub HOverrrr(sender As Object, e As EventArgs) Handles btn0.MouseEnter, btn1.MouseEnter, btn4.MouseEnter, btn7.MouseEnter, btnDot.MouseEnter, btn3.MouseEnter, btn2.MouseEnter, btn6.MouseEnter, btn5.MouseEnter, btn9.MouseEnter, btn8.MouseEnter, btnC.MouseEnter
        Dim b As Button = sender
        b.Cursor = Cursors.Hand
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each row As DataGridViewRow In BillDataGrid.SelectedRows
            BillDataGrid.Rows.Remove(row)
        Next
        addCost()
        If cbPayment.Text = "Cash" Then
            Change()
        End If

    End Sub







    Private bitmap As Bitmap

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 10, 10)
    End Sub

    Private Sub cbPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayment.SelectedIndexChanged
        If Not (cbPayment.Text = "Cash") Then
            resetCash_input()
            Label2.Visible = False
            Label3.Visible = False
            lblChange.Visible = False
            lblCost.Visible = False
            lblScanSwipe.Visible = True
            lblScanSwipe.ForeColor = Color.Blue
        Else
            Label2.Visible = True
            Label3.Visible = True
            lblChange.Visible = True
            lblCost.Visible = True
            lblScanSwipe.Visible = False
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim height As Integer = BillDataGrid.Height
        BillDataGrid.Height = (BillDataGrid.RowCount + 1) * BillDataGrid.RowTemplate.Height
        bitmap = New Bitmap(Me.BillDataGrid.Width, Me.BillDataGrid.Height)
        BillDataGrid.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.BillDataGrid.Width, Me.BillDataGrid.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        BillDataGrid.Height = height
    End Sub
End Class
