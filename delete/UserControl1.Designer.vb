<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Column1 = New DataGridViewTextBoxColumn()
        lblChange = New Label()
        lblCost = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Column3 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        Button25 = New Button()
        Button26 = New Button()
        Button27 = New Button()
        Button28 = New Button()
        Button29 = New Button()
        Button30 = New Button()
        Button31 = New Button()
        Button32 = New Button()
        Button33 = New Button()
        Button34 = New Button()
        Button35 = New Button()
        Button36 = New Button()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Button17 = New Button()
        Button18 = New Button()
        Button19 = New Button()
        Button20 = New Button()
        Button21 = New Button()
        Button22 = New Button()
        Button23 = New Button()
        Button24 = New Button()
        Column2 = New DataGridViewTextBoxColumn()
        lblBarcode = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Label1 = New Label()
        BillDataGrid = New DataGridView()
        btn0 = New Button()
        btn1 = New Button()
        btn4 = New Button()
        btn7 = New Button()
        btnC = New Button()
        btnDot = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        cbPayment = New ComboBox()
        Panel3 = New Panel()
        Panel6 = New Panel()
        lblTotal = New Label()
        Label8 = New Label()
        Panel5 = New Panel()
        btnRemove = New Button()
        btnReset = New Button()
        btnPrint = New Button()
        btnPay = New Button()
        Panel4 = New Panel()
        lblScanSwipe = New Label()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        Bill = New TabPage()
        receiptt = New TabPage()
        txtReceipt = New Guna.UI2.WinForms.Guna2TextBox()
        Panel2.SuspendLayout()
        CType(BillDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        Bill.SuspendLayout()
        receiptt.SuspendLayout()
        SuspendLayout()
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Item"
        Column1.Name = "Column1"
        ' 
        ' lblChange
        ' 
        lblChange.BackColor = SystemColors.ButtonHighlight
        lblChange.BorderStyle = BorderStyle.Fixed3D
        lblChange.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblChange.ForeColor = Color.IndianRed
        lblChange.Location = New Point(266, 124)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(227, 45)
        lblChange.TabIndex = 3
        ' 
        ' lblCost
        ' 
        lblCost.BackColor = SystemColors.ButtonHighlight
        lblCost.BorderStyle = BorderStyle.Fixed3D
        lblCost.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblCost.Location = New Point(266, 71)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(227, 45)
        lblCost.TabIndex = 2
        lblCost.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label3.Location = New Point(7, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 31)
        Label3.TabIndex = 1
        Label3.Text = "Change"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label2.Location = New Point(7, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 31)
        Label2.TabIndex = 1
        Label2.Text = "Amount"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Amount"
        Column3.Name = "Column3"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonFace
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button25)
        Panel2.Controls.Add(Button26)
        Panel2.Controls.Add(Button27)
        Panel2.Controls.Add(Button28)
        Panel2.Controls.Add(Button29)
        Panel2.Controls.Add(Button30)
        Panel2.Controls.Add(Button31)
        Panel2.Controls.Add(Button32)
        Panel2.Controls.Add(Button33)
        Panel2.Controls.Add(Button34)
        Panel2.Controls.Add(Button35)
        Panel2.Controls.Add(Button36)
        Panel2.Controls.Add(Button13)
        Panel2.Controls.Add(Button14)
        Panel2.Controls.Add(Button15)
        Panel2.Controls.Add(Button16)
        Panel2.Controls.Add(Button17)
        Panel2.Controls.Add(Button18)
        Panel2.Controls.Add(Button19)
        Panel2.Controls.Add(Button20)
        Panel2.Controls.Add(Button21)
        Panel2.Controls.Add(Button22)
        Panel2.Controls.Add(Button23)
        Panel2.Controls.Add(Button24)
        Panel2.Location = New Point(755, 52)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(712, 452)
        Panel2.TabIndex = 10
        ' 
        ' Button25
        ' 
        Button25.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button25.Location = New Point(359, 300)
        Button25.Name = "Button25"
        Button25.Size = New Size(108, 84)
        Button25.TabIndex = 12
        Button25.Tag = "41"
        Button25.Text = "Foil"
        Button25.UseVisualStyleBackColor = True
        ' 
        ' Button26
        ' 
        Button26.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button26.Location = New Point(359, 210)
        Button26.Name = "Button26"
        Button26.Size = New Size(108, 84)
        Button26.TabIndex = 35
        Button26.Tag = "35"
        Button26.Text = "Battery"
        Button26.UseVisualStyleBackColor = True
        ' 
        ' Button27
        ' 
        Button27.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button27.Location = New Point(359, 120)
        Button27.Name = "Button27"
        Button27.Size = New Size(108, 84)
        Button27.TabIndex = 14
        Button27.Tag = "29"
        Button27.Text = "Bicycle Kids"
        Button27.UseVisualStyleBackColor = True
        ' 
        ' Button28
        ' 
        Button28.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button28.Location = New Point(359, 30)
        Button28.Name = "Button28"
        Button28.Size = New Size(108, 84)
        Button28.TabIndex = 15
        Button28.Tag = "23"
        Button28.Text = "Capacitor"
        Button28.UseVisualStyleBackColor = True
        ' 
        ' Button29
        ' 
        Button29.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Button29.Location = New Point(589, 300)
        Button29.Name = "Button29"
        Button29.Size = New Size(108, 84)
        Button29.TabIndex = 4
        Button29.Tag = "43"
        Button29.Text = "Snowbear"
        Button29.UseVisualStyleBackColor = True
        ' 
        ' Button30
        ' 
        Button30.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button30.Location = New Point(475, 300)
        Button30.Name = "Button30"
        Button30.Size = New Size(108, 84)
        Button30.TabIndex = 5
        Button30.Tag = "42"
        Button30.Text = "Lighter"
        Button30.UseVisualStyleBackColor = True
        ' 
        ' Button31
        ' 
        Button31.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Button31.Location = New Point(589, 210)
        Button31.Name = "Button31"
        Button31.Size = New Size(108, 84)
        Button31.TabIndex = 37
        Button31.Tag = "37"
        Button31.Text = "OnlyFans"
        Button31.UseVisualStyleBackColor = True
        ' 
        ' Button32
        ' 
        Button32.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button32.Location = New Point(475, 210)
        Button32.Name = "Button32"
        Button32.Size = New Size(108, 84)
        Button32.TabIndex = 36
        Button32.Tag = "36"
        Button32.Text = "Merch"
        Button32.UseVisualStyleBackColor = True
        ' 
        ' Button33
        ' 
        Button33.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button33.Location = New Point(589, 120)
        Button33.Name = "Button33"
        Button33.Size = New Size(108, 84)
        Button33.TabIndex = 8
        Button33.Tag = "31"
        Button33.Text = "Unli Puffs"
        Button33.UseVisualStyleBackColor = True
        ' 
        ' Button34
        ' 
        Button34.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button34.Location = New Point(475, 120)
        Button34.Name = "Button34"
        Button34.Size = New Size(108, 84)
        Button34.TabIndex = 28
        Button34.Tag = "30"
        Button34.Text = "Cellphone"
        Button34.UseVisualStyleBackColor = True
        ' 
        ' Button35
        ' 
        Button35.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button35.Location = New Point(589, 30)
        Button35.Name = "Button35"
        Button35.Size = New Size(108, 84)
        Button35.TabIndex = 10
        Button35.Tag = "25"
        Button35.Text = "PCB"
        Button35.UseVisualStyleBackColor = True
        ' 
        ' Button36
        ' 
        Button36.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button36.Location = New Point(475, 30)
        Button36.Name = "Button36"
        Button36.Size = New Size(108, 84)
        Button36.TabIndex = 11
        Button36.Tag = "24"
        Button36.Text = "LED"
        Button36.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button13.Location = New Point(15, 300)
        Button13.Name = "Button13"
        Button13.Size = New Size(108, 84)
        Button13.TabIndex = 38
        Button13.Tag = "38"
        Button13.Text = "100Php"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button14.Location = New Point(15, 210)
        Button14.Name = "Button14"
        Button14.Size = New Size(108, 84)
        Button14.TabIndex = 3
        Button14.Tag = "32"
        Button14.Text = "Gin"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button15.Location = New Point(15, 120)
        Button15.Name = "Button15"
        Button15.Size = New Size(108, 84)
        Button15.TabIndex = 3
        Button15.Tag = "26"
        Button15.Text = "Remote Control"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button16.Location = New Point(15, 30)
        Button16.Name = "Button16"
        Button16.Size = New Size(108, 84)
        Button16.TabIndex = 3
        Button16.Tag = "20"
        Button16.Text = "Handle Bar"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button17.Location = New Point(245, 300)
        Button17.Name = "Button17"
        Button17.Size = New Size(108, 84)
        Button17.TabIndex = 2
        Button17.Tag = "40"
        Button17.Text = "Monitor"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button18
        ' 
        Button18.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button18.Location = New Point(131, 300)
        Button18.Name = "Button18"
        Button18.Size = New Size(108, 84)
        Button18.TabIndex = 39
        Button18.Tag = "39"
        Button18.Text = "10$"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button19
        ' 
        Button19.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button19.Location = New Point(245, 210)
        Button19.Name = "Button19"
        Button19.Size = New Size(108, 84)
        Button19.TabIndex = 2
        Button19.Tag = "34"
        Button19.Text = "Keyboard"
        Button19.UseVisualStyleBackColor = True
        ' 
        ' Button20
        ' 
        Button20.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button20.Location = New Point(131, 210)
        Button20.Name = "Button20"
        Button20.Size = New Size(108, 84)
        Button20.TabIndex = 2
        Button20.Tag = "33"
        Button20.Text = "Mouse"
        Button20.UseVisualStyleBackColor = True
        ' 
        ' Button21
        ' 
        Button21.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button21.Location = New Point(245, 120)
        Button21.Name = "Button21"
        Button21.Size = New Size(108, 84)
        Button21.TabIndex = 2
        Button21.Tag = "28"
        Button21.Text = "Coke Float"
        Button21.UseVisualStyleBackColor = True
        ' 
        ' Button22
        ' 
        Button22.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button22.Location = New Point(131, 120)
        Button22.Name = "Button22"
        Button22.Size = New Size(108, 84)
        Button22.TabIndex = 2
        Button22.Tag = "27"
        Button22.Text = "Coffee"
        Button22.UseVisualStyleBackColor = True
        ' 
        ' Button23
        ' 
        Button23.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button23.Location = New Point(245, 30)
        Button23.Name = "Button23"
        Button23.Size = New Size(108, 84)
        Button23.TabIndex = 2
        Button23.Tag = "22"
        Button23.Text = "Bike Seat(Rubber)"
        Button23.UseVisualStyleBackColor = True
        ' 
        ' Button24
        ' 
        Button24.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button24.Location = New Point(131, 30)
        Button24.Name = "Button24"
        Button24.Size = New Size(108, 84)
        Button24.TabIndex = 2
        Button24.Tag = "21"
        Button24.Text = "Bike Seat"
        Button24.UseVisualStyleBackColor = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Qty"
        Column2.Name = "Column2"
        ' 
        ' lblBarcode
        ' 
        lblBarcode.AutoEllipsis = True
        lblBarcode.BackColor = SystemColors.ButtonHighlight
        lblBarcode.BorderStyle = BorderStyle.Fixed3D
        lblBarcode.Font = New Font("C39HrP24DhTt", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBarcode.Location = New Point(404, 423)
        lblBarcode.Name = "lblBarcode"
        lblBarcode.Size = New Size(345, 78)
        lblBarcode.TabIndex = 11
        lblBarcode.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold)
        Label1.Location = New Point(7, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 31)
        Label1.TabIndex = 1
        Label1.Text = "Mode of Payment"
        ' 
        ' BillDataGrid
        ' 
        BillDataGrid.BackgroundColor = Color.White
        BillDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillDataGrid.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        BillDataGrid.Location = New Point(-1, 3)
        BillDataGrid.Name = "BillDataGrid"
        BillDataGrid.Size = New Size(338, 366)
        BillDataGrid.TabIndex = 9
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn0.Location = New Point(12, 300)
        btn0.Name = "btn0"
        btn0.Size = New Size(108, 84)
        btn0.TabIndex = 3
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn1.Location = New Point(12, 210)
        btn1.Name = "btn1"
        btn1.Size = New Size(108, 84)
        btn1.TabIndex = 3
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn4.Location = New Point(12, 120)
        btn4.Name = "btn4"
        btn4.Size = New Size(108, 84)
        btn4.TabIndex = 3
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn7.Location = New Point(12, 30)
        btn7.Name = "btn7"
        btn7.Size = New Size(108, 84)
        btn7.TabIndex = 3
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btnC
        ' 
        btnC.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnC.Location = New Point(242, 300)
        btnC.Name = "btnC"
        btnC.Size = New Size(108, 84)
        btnC.TabIndex = 2
        btnC.Text = "C"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' btnDot
        ' 
        btnDot.BackColor = Color.White
        btnDot.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnDot.Location = New Point(128, 300)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(108, 84)
        btnDot.TabIndex = 2
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn3.Location = New Point(242, 210)
        btn3.Name = "btn3"
        btn3.Size = New Size(108, 84)
        btn3.TabIndex = 2
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn2.Location = New Point(128, 210)
        btn2.Name = "btn2"
        btn2.Size = New Size(108, 84)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn6.Location = New Point(242, 120)
        btn6.Name = "btn6"
        btn6.Size = New Size(108, 84)
        btn6.TabIndex = 2
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn5.Location = New Point(128, 120)
        btn5.Name = "btn5"
        btn5.Size = New Size(108, 84)
        btn5.TabIndex = 2
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn9.Location = New Point(242, 30)
        btn9.Name = "btn9"
        btn9.Size = New Size(108, 84)
        btn9.TabIndex = 2
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btn8.Location = New Point(128, 30)
        btn8.Name = "btn8"
        btn8.Size = New Size(108, 84)
        btn8.TabIndex = 2
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' cbPayment
        ' 
        cbPayment.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        cbPayment.FormattingEnabled = True
        cbPayment.Items.AddRange(New Object() {"Cash", "Direct Debit", "Visa Card", "MasterCard", "GCash"})
        cbPayment.Location = New Point(266, 10)
        cbPayment.Name = "cbPayment"
        cbPayment.Size = New Size(227, 53)
        cbPayment.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonFace
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(32, 510)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1435, 227)
        Panel3.TabIndex = 8
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ButtonFace
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(lblTotal)
        Panel6.Controls.Add(Label8)
        Panel6.Location = New Point(17, 19)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(408, 190)
        Panel6.TabIndex = 3
        ' 
        ' lblTotal
        ' 
        lblTotal.BackColor = SystemColors.ButtonHighlight
        lblTotal.BorderStyle = BorderStyle.Fixed3D
        lblTotal.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblTotal.Location = New Point(182, 68)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(204, 42)
        lblTotal.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label8.Location = New Point(32, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 45)
        Label8.TabIndex = 1
        Label8.Text = "Total"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ButtonFace
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(btnRemove)
        Panel5.Controls.Add(btnReset)
        Panel5.Controls.Add(btnPrint)
        Panel5.Controls.Add(btnPay)
        Panel5.Location = New Point(937, 16)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(483, 193)
        Panel5.TabIndex = 2
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.Location = New Point(246, 97)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(215, 88)
        btnRemove.TabIndex = 6
        btnRemove.Text = "Remove Item"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnReset.Location = New Point(246, 3)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(215, 88)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnPrint.Location = New Point(25, 97)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(215, 88)
        btnPrint.TabIndex = 4
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        btnPay.Location = New Point(25, 3)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(215, 88)
        btnPay.TabIndex = 3
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonFace
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lblChange)
        Panel4.Controls.Add(lblCost)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(lblScanSwipe)
        Panel4.Controls.Add(cbPayment)
        Panel4.Location = New Point(431, 18)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(500, 191)
        Panel4.TabIndex = 2
        ' 
        ' lblScanSwipe
        ' 
        lblScanSwipe.AutoSize = True
        lblScanSwipe.Font = New Font("Fira Code", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScanSwipe.ForeColor = SystemColors.ButtonFace
        lblScanSwipe.Location = New Point(7, 97)
        lblScanSwipe.Name = "lblScanSwipe"
        lblScanSwipe.Size = New Size(501, 72)
        lblScanSwipe.TabIndex = 4
        lblScanSwipe.Text = "Scan QR code or Swipe Card " & vbCrLf & "for Payment"
        lblScanSwipe.TextAlign = ContentAlignment.TopCenter
        lblScanSwipe.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btn0)
        Panel1.Controls.Add(btn1)
        Panel1.Controls.Add(btn4)
        Panel1.Controls.Add(btn7)
        Panel1.Controls.Add(btnC)
        Panel1.Controls.Add(btnDot)
        Panel1.Controls.Add(btn3)
        Panel1.Controls.Add(btn2)
        Panel1.Controls.Add(btn6)
        Panel1.Controls.Add(btn5)
        Panel1.Controls.Add(btn9)
        Panel1.Controls.Add(btn8)
        Panel1.Location = New Point(32, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(366, 452)
        Panel1.TabIndex = 7
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Bill)
        TabControl1.Controls.Add(receiptt)
        TabControl1.Location = New Point(404, 52)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(345, 368)
        TabControl1.TabIndex = 12
        ' 
        ' Bill
        ' 
        Bill.BackColor = SystemColors.ButtonHighlight
        Bill.Controls.Add(BillDataGrid)
        Bill.Location = New Point(4, 24)
        Bill.Name = "Bill"
        Bill.Padding = New Padding(3)
        Bill.Size = New Size(337, 340)
        Bill.TabIndex = 0
        Bill.Text = "Bill"
        ' 
        ' receiptt
        ' 
        receiptt.Controls.Add(txtReceipt)
        receiptt.Location = New Point(4, 24)
        receiptt.Name = "receiptt"
        receiptt.Padding = New Padding(3)
        receiptt.Size = New Size(337, 340)
        receiptt.TabIndex = 1
        receiptt.Text = "Receipt"
        receiptt.UseVisualStyleBackColor = True
        ' 
        ' txtReceipt
        ' 
        txtReceipt.CustomizableEdges = CustomizableEdges3
        txtReceipt.DefaultText = ""
        txtReceipt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtReceipt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtReceipt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtReceipt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtReceipt.Dock = DockStyle.Fill
        txtReceipt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtReceipt.Font = New Font("Segoe UI", 9F)
        txtReceipt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtReceipt.Location = New Point(3, 3)
        txtReceipt.Multiline = True
        txtReceipt.Name = "txtReceipt"
        txtReceipt.PasswordChar = ChrW(0)
        txtReceipt.PlaceholderText = ""
        txtReceipt.ScrollBars = ScrollBars.Vertical
        txtReceipt.SelectedText = ""
        txtReceipt.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtReceipt.Size = New Size(331, 334)
        txtReceipt.TabIndex = 0
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        Controls.Add(Panel2)
        Controls.Add(lblBarcode)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Name = "UserControl1"
        Size = New Size(1498, 788)
        Panel2.ResumeLayout(False)
        CType(BillDataGrid, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        Bill.ResumeLayout(False)
        receiptt.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents lblChange As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Button36 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents lblBarcode As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents BillDataGrid As DataGridView
    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents cbPayment As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblScanSwipe As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Bill As TabPage
    Friend WithEvents Receipt As TabPage
    Friend WithEvents receiptt As TabPage
    Friend WithEvents txtReceipt As Guna.UI2.WinForms.Guna2TextBox

End Class
