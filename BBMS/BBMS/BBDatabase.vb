Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.IO

Public Class BBDatabase
    Private Shared db As OleDbConnection = Nothing


    Public Sub New()
        If Not (db Is Nothing) Then
            Exit Sub
        End If

        Try
            Dim str As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=bbms.mdb"
            db = New OleDbConnection(str)
            db.Open()

        Catch ex As Exception
            MessageBox.Show("ERROR: Cannot open database", "Database failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    ' USER ACCOUNTS HELPER UI

    Public Function AppendUser(ByVal username As String, ByVal password As String) As Boolean
        If db Is Nothing Then
            Return False
        End If

        If username.Trim.Length < 1 Or password.Trim.Length < 1 Then
            Return False
        End If

        Try
            Dim sql As String
            sql = String.Format("INSERT INTO LOGIN VALUES ('{0}', '{1}')", username, password)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function GetPassword(ByVal username As String, ByRef password As String) As Boolean
        If db Is Nothing Then
            Return False
        End If

        If username.Trim.Length < 1 Then
            Return False
        End If

        Try
            Dim sql As String
            sql = String.Format("SELECT USERNAME, PASSWORD FROM LOGIN WHERE USERNAME='{0}'", username)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)
            If ds.Tables(0).Rows(0).Item(0) = username Then
                password = ds.Tables(0).Rows(0).Item(1)
                Return True
            Else
                Throw New Exception()
            End If


        Catch ex As Exception
            Return False
        End Try
        Return True

    End Function

    Public Function VerifyUser(ByVal username As String, ByVal password As String) As Boolean
        If db Is Nothing Then
            Return False
        End If

        If username.Trim.Length < 1 Or password.Trim.Length < 1 Then
            Return False
        End If

        Try
            Dim sql As String
            sql = String.Format("SELECT USERNAME, PASSWORD FROM LOGIN WHERE USERNAME='{0}' AND PASSWORD='{1}'", username, password)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            If ds.Tables(0).Rows(0).Item(0) = username And ds.Tables(0).Rows(0).Item(1) = password Then
                Return True
            Else
                Throw New Exception()
            End If
        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Delegate Sub funcEnumUsers(ByVal username As String, ByVal password As String, ByVal obj As Object)

    Public Sub EnumAccounts(ByVal funcEnum As funcEnumUsers, ByVal obj As Object)
        If db Is Nothing Then
            Exit Sub
        End If

        Try
            Dim sql As String
            sql = String.Format("SELECT USERNAME, PASSWORD FROM LOGIN")
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            For Each dr As DataRow In ds.Tables(0).Rows
                funcEnum(dr.Item(0), dr.Item(1), obj)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Function DeleteUser(ByVal username As String) As Boolean
        If db Is Nothing Then
            Return False
        End If

        If username.Trim.Length < 1 Then
            Return False
        End If

        Try
            Dim sql As String
            sql = String.Format("DELETE FROM LOGIN WHERE USERNAME='{0}'", username)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

        Catch ex As Exception
            Return False
        End Try
        Return True

    End Function

    Public Function UpdateUser(ByVal username As String, ByVal password As String) As Boolean
        If db Is Nothing Then
            Return False
        End If

        If username.Trim.Length < 1 Or password.Trim.Length < 1 Then
            Return False
        End If

        Try
            Dim sql As String
            sql = String.Format("UPDATE LOGIN SET [PASSWORD]='{1}' WHERE [USERNAME]='{0}'", username, password)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

        Catch ex As Exception
            Return False
        End Try
        Return True

    End Function
    'Stock Information
    Public Structure StockInfo
        Public Stock_ID As Integer
        Public Blood_Group As String
        Public Packets As Integer
        Public Rate As Double
        Public Purchase_Date As Date
        Public Exp_Date As Date
    End Structure

    Public Sub PrintBloodStock(ByVal form As Form)
        Try
            Dim dtToday As Date = Date.Today
            Dim sql As String
            sql = String.Format("SELECT STOCK_ID, BLOOD_GROUP, PACKETS, RATE, PURCHASE_DATE, EXP_DATE FROM STOCK WHERE PURCHASE_DATE=#{0}-{1}-{2}#", _
                                dtToday.Year, dtToday.Month, dtToday.Day)

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            Dim filePath As String = Path.GetTempFileName() + ".htm"
            Dim file As TextWriter = New StreamWriter(filePath, False, System.Text.Encoding.ASCII)
            If file Is Nothing Then
                Throw New Exception("Cannot create the Report file")
            End If
            file.WriteLine("<html>")
            file.WriteLine("    <head>")
            file.WriteLine("        <title>Blood Stock on " + dtToday.ToString("dd-MMM-yyyy") + "</title>")
            file.WriteLine("    </head>")
            file.WriteLine("    <body><center>")
            file.WriteLine("        <h1><u><font color=red>BLOOD BANK MANAGEMENT SYSTEM</font></u></h1>")
            file.WriteLine("        <h2><u><font color=blue>Blood Stock on " + dtToday.ToString("dd-MMM-yyyy") + "</font></u></h2>")
            file.WriteLine("        <br><br>")
            file.WriteLine("        <table align=center width='90%' border=2 cellspacing=0 cellpadding=3>")
            Dim hdr() As String = {"Stock ID", "Blood Group", "Packets", "Rate", "Purchase Date", "Expiry Date"}
            file.WriteLine("            <tr>")
            For Each hdrStr In hdr
                file.WriteLine("            <th>")
                file.WriteLine(hdrStr)
                file.WriteLine("            </th>")
            Next
            file.WriteLine("            </tr>")

            For Each row As DataRow In ds.Tables(0).Rows
                Dim rowStr() As String = {row.Item("STOCK_ID").ToString(), _
                                          row.Item("BLOOD_GROUP").ToString(), _
                                          row.Item("PACKETS").ToString(), _
                                          row.Item("RATE").ToString(), _
                                          Date.Parse(row.Item("PURCHASE_DATE")).ToString("dd-MMM-yyyy"), _
                                          Date.Parse(row.Item("EXP_DATE")).ToString("dd-MMM-yyyy")}

                file.WriteLine("            <tr>")
                For Each rstr In rowStr
                    file.WriteLine("            <td><center>")
                    file.WriteLine(rstr)
                    file.WriteLine("            </center></td>")
                Next
                file.WriteLine("            </tr>")

            Next



            file.WriteLine("        </table>")
            file.WriteLine("        <br><br>")
            file.WriteLine("        </center>")
            file.WriteLine("        <hr>")
            file.WriteLine("        <br><br>")
            file.WriteLine("        <input type='button' id='printme' value='Print the Report' onClick='window.print()' />")
            file.WriteLine("        <br><br>")
            file.WriteLine("    </body>")
            file.WriteLine("</html>")
            file.Flush()
            file.Close()

            '            System.Diagnostics.Process.Start("file:///" + filePath)
            Dim frm As New FormReportViewer()
            frm.ShowReportWindow(form, "file:///" + filePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error in generating Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function AppendDonorToStock(ByVal bloodgroup As String) As Boolean
        Try
            Dim rate As Double = 0
            Double.TryParse(InputBox("Enter Purchase Rate: ", "Purchase Rate Settings:", "0.00"), rate)

            Dim dd As String = InputBox("Enter Expiry Period (in months): ", "Expiry Period Settings", "6")
            Dim expMonth As Integer = 6
            Integer.TryParse(dd, expMonth)

            Dim purchaseDate As Date = Date.Today
            Dim expiryDate As Date = purchaseDate
            expiryDate = expiryDate.AddMonths(expMonth)

            Dim sql As String
            sql = String.Format("INSERT INTO STOCK VALUES ({0}, '{1}', {2}, {3}, #{4}-{5}-{6}#, #{7}-{8}-{9}#)", _
                                BBDatabase.GenerateId(), bloodgroup, 1, rate, _
                                purchaseDate.Year, purchaseDate.Month, purchaseDate.Day, _
                                expiryDate.Year, expiryDate.Month, expiryDate.Day)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function UpdateDonorToStock(ByVal bloodgroup As String) As Boolean
        Try
            Dim purchaseDate As Date = Date.Today
            Dim sql As String
            sql = String.Format("SELECT STOCK_ID, PACKETS FROM STOCK WHERE BLOOD_GROUP='{0}' AND PURCHASE_DATE=#{1}-{2}-{3}#", _
                                bloodgroup, purchaseDate.Year, purchaseDate.Month, purchaseDate.Day)

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            Dim stockId As Integer = 0
            Dim nPackets As Integer = 0
            Integer.TryParse(ds.Tables(0).Rows(0).Item(0).ToString(), stockId)
            Integer.TryParse(ds.Tables(0).Rows(0).Item(1).ToString(), nPackets)

            nPackets += 1

            sql = String.Format("UPDATE STOCK SET [PACKETS]={0} WHERE STOCK_ID={1}", _
                                nPackets, stockId)

            ad = New OleDbDataAdapter(sql, db)
            ds = New DataSet()
            ad.Fill(ds)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function AddDonorToStock(ByVal info As DonorInfo) As Boolean
        Try
            Dim sdate As Date = Date.Now
            Dim sbloodgroup As String = info.Blood_Group
            ' Check if we have any stock of BLOOD_GROUP at today's date
            Dim sql As String
            sql = String.Format("SELECT COUNT(STOCK_ID) FROM STOCK WHERE BLOOD_GROUP='{0}' AND PURCHASE_DATE=#{1}-{2}-{3}#", _
                                sbloodgroup, sdate.Year, sdate.Month, sdate.Day)

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)
            Dim n As Integer = 0
            Integer.TryParse(ds.Tables(0).Rows(0).Item(0).ToString(), n)
            If n < 1 Then
                Return AppendDonorToStock(sbloodgroup)
            Else
                Return UpdateDonorToStock(sbloodgroup)

            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EnumStock() As StockInfo()
        Try
            Dim sql As String
            sql = "SELECT STOCK_ID, BLOOD_GROUP, PACKETS, RATE, PURCHASE_DATE, EXP_DATE FROM STOCK"

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            Dim sinfo As New List(Of StockInfo)
            For Each rw As DataRow In ds.Tables(0).Rows
                Dim info As StockInfo
                info.Stock_ID = 0
                Integer.TryParse(rw.Item("STOCK_ID").ToString(), info.Stock_ID)
                info.Blood_Group = rw.Item("BLOOD_GROUP").ToString().Trim
                info.Packets = 0
                Integer.TryParse(rw.Item("PACKETS").ToString(), info.Packets)
                info.Rate = 0
                Double.TryParse(rw.Item("RATE").ToString(), info.Rate)
                Date.TryParse(rw.Item("PURCHASE_DATE").ToString(), info.Purchase_Date)
                Date.TryParse(rw.Item("EXP_DATE").ToString(), info.Exp_Date)
                sinfo.Add(info)
            Next
            Return sinfo.ToArray()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function UpdateStockRate(ByVal id As Integer, ByVal rate As Double)
        Try
            Dim sql As String
            sql = String.Format("UPDATE STOCK SET [RATE]={0} WHERE STOCK_ID={1}", rate, id)

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function UpdateStockExpDate(ByVal id As Integer, ByVal expdate As Date)
        Try
            Dim sql As String
            sql = String.Format("UPDATE STOCK SET [EXP_DATE]=#{0}-{1}-{2}# WHERE STOCK_ID={3}", _
                                expdate.Year, expdate.Month, expdate.Day, id)

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' Donor Information
    Public Structure DonorInfo
        Public Donor_ID As Integer
        Public Donor_Name As String
        Public Blood_Group As String
        Public Address As String
        Public PhoneNo As Long
    End Structure

    Public Function AppendDonor(ByVal info As DonorInfo) As Boolean
        Try
            Dim sql As String
            Dim bgroup As String
            bgroup = info.Blood_Group.Trim
            bgroup = bgroup.Substring(0, Math.Min(3, bgroup.Length))
            sql = String.Format("INSERT INTO DONOR VALUES({0},'{1}', '{2}', '{3}', '{4}')", _
                                info.Donor_ID, info.Donor_Name, bgroup, info.Address, info.PhoneNo.ToString)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)
            Return True
        Catch ex As Exception
            Debug.Print(ex.ToString())
            Return False
        End Try
    End Function


    Public Function EnumDonors() As DonorInfo()
        Try
            Dim sql As String
            sql = String.Format("SELECT Donor_ID, Donor_Name, Blood_Group, Address, PhoneNo FROM DONOR")

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)
            Dim l As New List(Of DonorInfo)
            For Each row As DataRow In ds.Tables(0).Rows
                Dim info As New DonorInfo()
                info.Donor_ID = 0
                Integer.TryParse(row.Item(0), info.Donor_ID)
                info.Donor_Name = row.Item(1)
                info.Blood_Group = row.Item(2)
                info.Address = row.Item(3)
                info.PhoneNo = 0
                info.PhoneNo = 0
                Long.TryParse(row.Item(4), info.PhoneNo)
                l.Add(info)
            Next

            Return l.ToArray()

        Catch ex As Exception
            Debug.Print(ex.ToString())
            Return Nothing
        End Try

    End Function


    Public Function FindDonorById(ByVal id As Integer, ByRef info As DonorInfo) As Boolean
        Try
            Dim sql As String
            sql = String.Format("SELECT DONOR_ID, DONOR_NAME, BLOOD_GROUP, ADDRESS, PHONENO FROM DONOR WHERE DONOR_ID = {0}", _
                                id)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            info.Donor_ID = Integer.Parse(ds.Tables(0).Rows(0).Item(0))
            info.Donor_Name = ds.Tables(0).Rows(0).Item(1)
            info.Blood_Group = ds.Tables(0).Rows(0).Item(2)
            info.Address = ds.Tables(0).Rows(0).Item(3)
            info.PhoneNo = Long.Parse(ds.Tables(0).Rows(0).Item(4))
            Return True

        Catch ex As Exception
            Debug.Print(ex.ToString())
            Return False
        End Try
    End Function

    Public Function UpdateDonor(ByVal info As DonorInfo) As Boolean
        Try
            Dim sql As String
            Dim bgroup As String
            bgroup = info.Blood_Group.Trim
            bgroup = bgroup.Substring(0, Math.Min(3, bgroup.Length))
            sql = String.Format("UPDATE DONOR SET [DONOR_ID]={0}, [DONOR_NAME]='{1}', BLOOD_GROUP='{2}', ADDRESS='{3}', PHONENO='{4}' WHERE DONOR_ID={0}", _
                                info.Donor_ID, info.Donor_Name, bgroup, info.Address, info.PhoneNo.ToString)

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)
            Return True
        Catch ex As Exception
            Debug.Print(ex.ToString())
            Return False
        End Try
    End Function


    ' Customer Purchase Information
    Public Structure CustomerInfo
        Public BillNo As Integer
        Public CustomerName As String
        Public Hospital_Name As String
        Public Blood_Group As String
        Public Purchase_Date As Date
        Public No_Of_Packet As Integer
        Public Price As Double
    End Structure

    Private Sub UpdateStockSetPackets(ByVal id As Integer, ByVal nPackets As Integer)
        If nPackets < 0 Then
            nPackets = 0
        End If

        Dim sql As String
        sql = String.Format("UPDATE STOCK SET [PACKETS]= {0} WHERE STOCK_ID={1}", _
                            nPackets, id)
        Dim ad As New OleDbDataAdapter(sql, db)
        Dim ds As New DataSet()
        ad.Fill(ds)
    End Sub

    Private Sub AddCustomerAppendBill(ByVal info As CustomerInfo, ByVal usablePackets As Integer, ByVal price As Double)
        Dim sql As String
        sql = String.Format("INSERT INTO CUSTOMER VALUES ({0}, '{1}', '{2}', '{3}', #{4}-{5}-{6}#, {7}, {8})", _
                            info.BillNo, _
                            info.CustomerName.Trim, _
                            info.Hospital_Name, _
                            info.Blood_Group.Trim, _
                            info.Purchase_Date.Year, info.Purchase_Date.Month, info.Purchase_Date.Day, _
                            usablePackets, _
                            price)
        Dim ad As New OleDbDataAdapter(sql, db)
        Dim ds As New DataSet()
        ad.Fill(ds)
    End Sub

    Private Sub GatherPackets(ByVal ds As DataRow, ByVal info As CustomerInfo, ByRef sampleCount As Integer)
        If sampleCount <= 0 Then
            Exit Sub
        End If

        Dim availablePackets As Integer = 0
        Integer.TryParse(ds.Item("PACKETS").ToString(), availablePackets)
        If availablePackets <= 0 Then
            Exit Sub
        End If

        Dim usablePacket As Integer = Math.Min(sampleCount, availablePackets)
        sampleCount -= usablePacket
        If usablePacket <= 0 Then
            Exit Sub
        End If

        ' update stock database
        UpdateStockSetPackets(Integer.Parse(ds.Item("STOCK_ID").ToString()), availablePackets - usablePacket)

        ' update customer database
        Dim price As Double = 0
        Double.TryParse(ds.Item("RATE").ToString(), price)
        AddCustomerAppendBill(info, usablePacket, price)
    End Sub


    Public Function AppendCustomer(ByVal info As CustomerInfo) As Boolean
        Try
            ' List all the available blood samples from stock
            Dim sql As String
            sql = String.Format("SELECT STOCK_ID, PACKETS, RATE FROM STOCK WHERE BLOOD_GROUP='{0}' AND EXP_DATE>#{1}-{2}-{3}#", _
                                info.Blood_Group, info.Purchase_Date.Year, info.Purchase_Date.Month, info.Purchase_Date.Day)
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            Dim fullCapacity As Integer = 0
            For Each rows As DataRow In ds.Tables(0).Rows
                Dim subCaps As Integer = 0
                Integer.TryParse(rows.Item("PACKETS").ToString(), subCaps)
                fullCapacity += subCaps
            Next
            If info.No_Of_Packet > fullCapacity Then
                Return False
            End If

            Dim reqPackets As Integer = info.No_Of_Packet
            For Each rows As DataRow In ds.Tables(0).Rows
                If reqPackets <= 0 Then
                    Exit For
                End If

                GatherPackets(rows, info, reqPackets)
            Next


            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Sub GenerateCustomerBill(ByVal frmParent As Form, ByVal id As Integer)
        Try
            Dim dtToday As Date = Date.Today
            Dim sql As String
            sql = String.Format("SELECT BILLNO, CUSTOMERNAME, HOSPITAL_NAME, BLOOD_GROUP, PURCHASE_DATE, NO_OF_PACKET, PRICE FROM CUSTOMER WHERE BILLNO={0}", _
                                id)

            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)

            Dim filePath As String = Path.GetTempFileName() + ".htm"
            Dim file As TextWriter = New StreamWriter(filePath, False, System.Text.Encoding.ASCII)
            If file Is Nothing Then
                Throw New Exception("Cannot create the Report file")
            End If
            file.WriteLine("<html>")
            file.WriteLine("    <head>")
            file.WriteLine("        <title>Customer Bill #" + id.ToString() + "</title>")
            file.WriteLine("    </head>")
            file.WriteLine("    <body><center>")
            file.WriteLine("        <h1><u><font color=red>BLOOD BANK MANAGEMENT SYSTEM</font></u></h1>")
            file.WriteLine("        <h2><u><font color=blue>Customer Bill # " + id.ToString() + " dtd. " + _
                           Date.Parse(ds.Tables(0).Rows(0).Item("PURCHASE_DATE")).ToString("dd-MMM-yyyy") + "</font></u></h2>")
            file.WriteLine("        <br><br>")

            file.WriteLine("<table align=center width='80%' border=0 cellspacing=0 cellpadding=0>")
            file.WriteLine("<tr>")
            file.WriteLine("<td><b>Bill No.: </b>&nbsp;&nbsp;<tt>" + ds.Tables(0).Rows(0).Item("BILLNO").ToString() + "</tt></td>")
            file.WriteLine("<td><b>Blood Group: </b>&nbsp;&nbsp;<tt>" + ds.Tables(0).Rows(0).Item("BLOOD_GROUP").ToString() + "</tt></td>")
            file.WriteLine("<td><b>Bill Date: </b>&nbsp;&nbsp;<tt>{0}</tt></td>", Date.Parse(ds.Tables(0).Rows(0).Item("PURCHASE_DATE")).ToString("dd-MMM-yyyy"))
            file.WriteLine("</tr>")
            file.WriteLine("<tr>")
            file.WriteLine("<td><b>Name: </b>&nbsp;&nbsp;<tt><b>{0}</b></tt></td>", ds.Tables(0).Rows(0).Item("CUSTOMERNAME"))
            file.WriteLine("<td colspan=2><b>Hospital Name: </b>&nbsp; &nbsp;<tt><b>{0}</b></tt></td>", ds.Tables(0).Rows(0).Item("HOSPITAL_NAME"))
            file.WriteLine("</tr>")
            file.WriteLine("</table><br>")


            file.WriteLine("        <table align=center width='90%' border=2 cellspacing=0 cellpadding=3>")
            file.WriteLine("<tr>")
            file.WriteLine("<th>{0}</th><th>{1}</th><th>{2}</th><th>{3}</th>", "Sl. No.", "Packets Supplied", "Packet Price", "Total Cost")
            file.WriteLine("</tr>")

            Dim totalPrice As Double = 0
            Dim reqPrice As Double = 0
            Dim reqCost As Double = 0
            Dim counter As Integer = 0
            For Each row As DataRow In ds.Tables(0).Rows
                Double.TryParse(row.Item("PRICE").ToString(), reqPrice)
                Dim nPackets As Integer = 0
                Integer.TryParse(row.Item("NO_OF_PACKET").ToString(), nPackets)
                reqCost = reqPrice * nPackets
                If reqCost < 0 Then
                    reqCost *= -1
                End If
                totalPrice += reqCost
                counter += 1

                file.WriteLine("<tr>")
                file.WriteLine("<td><center>{0}</center></td><td>{1}</td><td>{2}</td><td>{3}</td>", _
                               counter, nPackets, reqPrice, reqCost)

                file.WriteLine("</tr>")
            Next
            file.WriteLine("<tr>")
            file.WriteLine("<th align=right colspan=3>Gross Total amount: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>")
            file.WriteLine("<td>{0}</td>", totalPrice)
            file.WriteLine("</tr>")


            file.WriteLine("        </table>")
            file.WriteLine("        <br><br>")
            file.WriteLine("        </center>")
            file.WriteLine("        <hr>")
            file.WriteLine("        <br><br>")
            file.WriteLine("        <input type='button' id='printme' value='Print the Report' onClick='window.print()' />")
            file.WriteLine("        <br><br>")
            file.WriteLine("    </body>")
            file.WriteLine("</html>")
            file.Flush()
            file.Close()

            '            System.Diagnostics.Process.Start("file:///" + filePath)
            Dim frm As New FormReportViewer()
            frm.ShowReportWindow(frmParent, "file:///" + filePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error in generating Report", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Public Sub GenerateAllReport(ByVal frmParent As Form)
        Try
            Dim filePath As String = Path.GetTempFileName() + ".htm"
            Dim file As TextWriter = New StreamWriter(filePath, False, System.Text.Encoding.ASCII)
            If file Is Nothing Then
                Throw New Exception("Cannot create the Report file")
            End If

            file.WriteLine("<html>")
            file.WriteLine("    <head>")
            file.WriteLine("        <title>Datewise Purchase and Blood Donation Report</title>")
            file.WriteLine("    </head>")
            file.WriteLine("    <body><center>")
            file.WriteLine("        <h1><u><font color=red>BLOOD BANK MANAGEMENT SYSTEM</font></u></h1>")
            file.WriteLine("        <h2><u><font color=blue>DATEWISE PURCHASE AND BLOOD DONATION REPORT</font></u></h2>")
            file.WriteLine("        <br><br>")

            file.WriteLine("<h2><center>BLOOD DONATION REPORT</center></h2>")
            file.WriteLine("<table align=center width='90%' border=2 cellspacing=0 cellpadding=3>")
            file.WriteLine("<tr>")
            file.WriteLine("<th>{0}</th><th>{1}</th><th>{2}</th><th>{3}</th><th>{4}</th>", _
                           "Donor ID", "Name", "Blood Group", "Address", "Phone Number")
            file.WriteLine("</tr>")

            Dim sql As String
            sql = String.Format("SELECT DONOR_ID, DONOR_NAME, BLOOD_GROUP, ADDRESS, PHONENO FROM DONOR")
            Dim ad As New OleDbDataAdapter(sql, db)
            Dim ds As New DataSet()
            ad.Fill(ds)
            For Each row As DataRow In ds.Tables(0).Rows
                file.WriteLine("<tr>")
                file.WriteLine("<td><center><tt>{0}</tt></center></td>", row.Item("DONOR_ID"))
                file.WriteLine("<td>{0}</td>", row.Item("DONOR_NAME"))
                file.WriteLine("<td><center><tt><b>{0}</b></tt></center></td>", row.Item("BLOOD_GROUP"))
                file.WriteLine("<td>{0}</td>", row.Item("ADDRESS"))
                file.WriteLine("<td><center>{0}</center></td>", row.Item("PHONENO"))
                file.WriteLine("</tr>")
            Next

            file.WriteLine("</table>")
            file.WriteLine("<br><br>")
            file.WriteLine("</center>")
            file.WriteLine("<hr>")

            file.WriteLine("<h2><center>BLOOD PACKET PURCHASE REPORT</center></h2>")
            file.WriteLine("<center>")
            file.WriteLine("<table align=center width='90%' border=2 cellspacing=0 cellpadding=3>")
            file.WriteLine("<tr>")
            file.WriteLine("<th>{0}</th><th>{1}</th><th>{2}</th><th>{3}</th><th>{4}</th><th>{5}</th><th>{6}</th><th>{7}</th>", _
                           "Bill No.", "Customer Name", "Hospital Name", "Blood Group", _
                           "Purchase Date", "No. Of. Packets", "Price", "Total Cost")
            file.WriteLine("</tr>")

            sql = String.Format("SELECT BILLNO, CUSTOMERNAME, HOSPITAL_NAME, BLOOD_GROUP, PURCHASE_DATE, NO_OF_PACKET, PRICE FROM CUSTOMER")
            ad = New OleDbDataAdapter(sql, db)
            ds = New DataSet()
            ad.Fill(ds)

            Dim grossSale As Double = 0
            For Each row As DataRow In ds.Tables(0).Rows
                file.WriteLine("<tr>")
                file.WriteLine("<td><center><tt>{0}</tt></center></td>", row.Item("BILLNO"))
                file.WriteLine("<td>{0}</td>", row.Item("CUSTOMERNAME"))
                file.WriteLine("<td>{0}</td>", row.Item("HOSPITAL_NAME"))
                file.WriteLine("<td><center><tt><b>{0}</b></tt></center></td>", row.Item("BLOOD_GROUP"))
                file.WriteLine("<td><center>{0}</center></td>", Date.Parse(row.Item("PURCHASE_DATE").ToString()).ToString("dd-MMM-yyyy"))

                Dim nPackets As Integer = 0
                Dim price As Double = 0
                Integer.TryParse(row.Item("NO_OF_PACKET").ToString(), nPackets)
                Double.TryParse(row.Item("PRICE").ToString(), price)
                Dim tPrice As Double
                tPrice = nPackets * price
                If tPrice < 0 Then
                    tPrice *= -1
                End If
                grossSale += tPrice

                file.WriteLine("<td><center>{0}</center></td>", nPackets)
                file.WriteLine("<td><center>{0}</center></td>", price)
                file.WriteLine("<td><center>{0}</center></td>", tPrice)
                file.WriteLine("</tr>")
            Next

            file.WriteLine("<tr>")
            file.WriteLine("<th align=right colspan=7> Gross sale till " + Date.Now.ToString("dd-MMM-yyyy") + " : &nbsp;&nbsp;&nbsp;</th>")
            file.WriteLine("<th><tt>{0}</tt></th>", grossSale)
            file.WriteLine("</tr>")
            file.WriteLine("</table>")
            file.WriteLine("<br><br>")
            file.WriteLine("</center>")
            file.WriteLine("<hr>")

            file.WriteLine("        <br><br>")
            file.WriteLine("        <input type='button' id='printme' value='Print the Report' onClick='window.print()' />")
            file.WriteLine("        <br><br>")
            file.WriteLine("    </body>")
            file.WriteLine("</html>")
            file.Flush()
            file.Close()

            '            System.Diagnostics.Process.Start("file:///" + filePath)
            Dim frm As New FormReportViewer()
            frm.ShowReportWindow(frmParent, "file:///" + filePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error in generating Report", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    ' Id generator
    Public Shared Function GenerateId() As Integer
        Dim id As Integer = 0
        Try
            Try
                Dim db As New BBDatabase()

                Dim sql As String
                sql = String.Format("SELECT ID FROM AUTOID")
                Dim ad As New OleDbDataAdapter(sql, BBDatabase.db)
                Dim ds As New DataSet()
                ad.Fill(ds)
                id = Integer.Parse(ds.Tables(0).Rows(0).Item(0))
                id = id + 1

                sql = String.Format("UPDATE AUTOID SET [ID]={0}", id)
                Dim ad1 As New OleDbDataAdapter(sql, BBDatabase.db)
                Dim ds1 As New DataSet()
                ad1.Fill(ds1)
            Catch ex As Exception
                ' cannot apply update so apply select
                Try
                    Dim sql As String
                    sql = String.Format("UPDATE AUTOID SET [ID]={0}", id)
                    Dim ad1 As New OleDbDataAdapter(sql, BBDatabase.db)
                    Dim ds1 As New DataSet()
                    ad1.Fill(ds1)

                Catch ex1 As Exception

                End Try
            End Try

        Catch ex2 As Exception
        End Try
        Return id
    End Function
End Class
