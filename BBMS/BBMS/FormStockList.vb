Public Class FormStockList

    Private Sub FormStockList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvStock.Columns.Add("STOCK_ID", "Stock ID")
        dgvStock.Columns.Add("BLOOD_GROUP", "Blood Group")
        dgvStock.Columns.Add("PACKETS", "Packets")
        dgvStock.Columns.Add("RATE", "Rate")
        dgvStock.Columns.Add("PURCHASE_DATE", "Purchase Date")
        dgvStock.Columns.Add("EXP_DATE", "Expiry Date")

        LoadStockData()
    End Sub

    Private Sub LoadStockData()
        Dim db As New BBDatabase()
        Dim sinfo() As BBDatabase.StockInfo = db.EnumStock()
        If sinfo Is Nothing Then
            MessageBox.Show("No Stock list found", "Stock list empty", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Dispose()
            Exit Sub
        End If

        dgvStock.Rows.Clear()
        For Each info In sinfo
            Dim sarr() As String = {info.Stock_ID.ToString(), info.Blood_Group, info.Packets.ToString, info.Rate.ToString(), info.Purchase_Date.ToString("dd-MMM-yyyy"), info.Exp_Date.ToString("dd-MMM-yyyy")}
            dgvStock.Rows.Add(sarr)
        Next
    End Sub



    Private Sub dgvStock_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStock.CellDoubleClick
        Dim row As Integer = dgvStock.SelectedCells.Item(0).RowIndex
        Dim col As Integer = dgvStock.SelectedCells.Item(0).ColumnIndex
        If (row = -1) Or (col = -1) Then
            Exit Sub
        End If

        Dim id As Integer = -1
        Integer.TryParse(dgvStock.Rows(row).Cells.Item("STOCK_ID").Value.ToString(), id)
        If id = -1 Then
            Exit Sub
        End If

        Dim colName As String = dgvStock.Columns.Item(col).HeaderText.ToLower().Trim()
        If colName = "rate" Then
            UpdateRateOf(id, dgvStock.Rows(row).Cells.Item("RATE").Value.ToString())
        ElseIf colName = "expiry date" Then
            UpdateExpiryDateOf(id, _
                                dgvStock.Rows(row).Cells.Item("PURCHASE_DATE").Value.ToString(), _
                                dgvStock.Rows(row).Cells.Item("EXP_DATE").Value.ToString())
        End If
    End Sub

    Private Sub UpdateRateOf(ByVal id As Integer, ByVal defVal As String)
        Try
            Dim s As String
            s = InputBox("Enter new rate: ", "Modify Rate", defVal)
            Dim rt As Double = 0
            Double.TryParse(defVal, rt)
            Double.TryParse(s, rt)

            Dim db As New BBDatabase()
            If db.UpdateStockRate(id, rt) = False Then
                MessageBox.Show("Cannot update the Rate of the Selected Stock #" + id.ToString(), "Error: Update Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            LoadStockData()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UpdateExpiryDateOf(ByVal id As Integer, ByVal s_purchasedate As String, ByVal s_expdate As String)
        Try
            Dim purchaseDate As Date = Date.Today
            Date.TryParse(s_purchasedate, purchaseDate)
            Dim expDate As Date = purchaseDate
            Date.TryParse(s_expdate, expDate)

            Dim nYears, nMonths As Integer
            nYears = expDate.Year - purchaseDate.Year
            nMonths = expDate.Month - purchaseDate.Month

            Dim tMonths As Integer
            tMonths = nYears * 12 + nMonths

            Dim s As String
            s = InputBox("Enter total number of months before the Sample Expires: ", "Blood Sample Life Settings (in Month)", tMonths.ToString())
            Integer.TryParse(s, tMonths)

            expDate = purchaseDate
            expDate = expDate.AddMonths(tMonths)

            Dim db As New BBDatabase()
            If db.UpdateStockExpDate(id, expDate) = False Then
                MessageBox.Show("Cannot update the Expiry Date of the Selected Stock #" + id.ToString(), "Error: Update Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
            LoadStockData()
        Catch ex As Exception

        End Try
    End Sub
End Class