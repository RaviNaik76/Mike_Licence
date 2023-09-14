Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataSet
Imports Word = Microsoft.Office.Interop.Word

Public Class frmMikeEntry
    Dim cs As String = "provider=Microsoft.ACE.OLEDB.12.0;data source=MikeLicence.Mdb"
    Dim cn As OleDbConnection : Dim da As OleDbDataAdapter : Dim ds As DataSet
    Dim dt As DataTable : Dim cmd As OleDbCommand : Dim dr As OleDbDataReader : Dim dtrw As DataRow
    Dim rc, serial As Integer : Dim sql, sql2 As String
   
    ' to Word
    Dim oWord As Word.Application : Dim oDoc As Word.Document
    Dim oPara1, oPara2, oPara3, oPara4, oPara5, oPara6, oPara7, oPara8, oPara9, oPara10, oPara11, oPara12 As Word.Paragraph
    Dim oTable, oTable2, oTable3 As Word.Table : Dim qs As Date : Dim az
    Dim x, z, r, c, r2, c2, rw, cw, cnt As Integer : Dim l, m, n, o, S, t, p, ls, mz, d As String

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NudiTurnOffScrollLock()
        cmd = New OleDbCommand("delete from infoTemp", cn)
        cn.Open() : cmd.ExecuteNonQuery() : cn.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection(cs)
        Call getGnrlCondition()
        da = New OleDbDataAdapter("select * from tblInfo", cn) : dt = New DataTable
        cn.Open() : da.Fill(dt) : cn.Close()

        cmbInof.Items.Clear()
        For Each dtrw As DataRow In dt.Rows
            cmbInof.Items.Add(dtrw(1).ToString())
        Next
        Call setSerial() : Call setInfo()

        For Each ctrl As Control In Me.Controls
            AddHandler ctrl.KeyPress, AddressOf enterkey
        Next
    End Sub

    Private Sub btnAddInf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddInf.Click
        If cmbInof.Text = vbNullString Then
            MsgBox("Field is reqired", vbApplicationModal + vbDefaultButton1 + vbInformation + vbOKOnly)
            Exit Sub : End If

        sql = "INSERT INTO infoTemp (decription) VALUES(@d1)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@d1", "decription")
            .Parameters("@d1").Value = cmbInof.Text
        End With
        cn.Open() : cmd.ExecuteNonQuery() : cn.Close()
        cmbInof.Text = "" : Call setInfo()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Call setSerial()

        Dim amt = TextBox9.Text : Dim txtboxes = Me.Controls.OfType(Of TextBox)()
        For Each txt In txtboxes
            If String.IsNullOrEmpty(txt.Text) Then : txt.Focus() : txt.BackColor = Color.Pink : TextBox9.Text = amt
            Else : txt.BackColor = Color.White
            End If
        Next

        If dtInfo.RowCount = 0 Then : cmbInof.BackColor = Color.Pink
        Else : cmbInof.BackColor = Color.White
        End If

        For Each txt In txtboxes
            If String.IsNullOrEmpty(txt.Text) Or dtInfo.RowCount = 0 Then Exit Sub
        Next

        Dim s1 As String = (Format(DateTimePicker1.Value.Date, "dd'/'MMM'/'yyyy")) : Dim s2 As String = (Format(DateTimePicker2.Value.Date, "dd'/'MMM'/'yyyy"))
        Dim s3 As String = (Format(DateTimePicker3.Value.Date, "dd'/'MMM'/'yyyy")) : Dim s4 As String = (Format(DateTimePicker4.Value.Date, "dd'/'MMM'/'yyyy"))

        'Dim s1 As String = DateTimePicker1.Value.Date : Dim s2 As String = DateTimePicker2.Value.Date
        'Dim s3 As String = DateTimePicker3.Value.Date : Dim s4 As String = DateTimePicker4.Value.Date

        sql = "INSERT INTO Mike (Licence_No, Holder_Name, Holder_Address, Holder_Mobile, " _
                & " Mike_Reason, Perm_from_Date, Perm_to_Date, Vehicle_No, Place, Challan_No, " _
                & " Challan_Date, Challan_Amount, Mike_ID, Licence_Date) VALUES('" & TextBox1.Text & "', " _
                & " '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "',  " _
                & " '" & TextBox5.Text & "', #" & s2 & "#, #" & s3 & "#, '" & TextBox6.Text & "', " _
                & " '" & TextBox7.Text & "', " & TextBox8.Text & ", #" & s4 & "#, " _
                & " " & TextBox9.Text & ", " & TextBox10.Text & ", #" & s1 & "#)"
        cmd = New OleDbCommand(sql, cn)
        cn.Open() : cmd.ExecuteNonQuery() : cn.Close()
        ' ------------------------------------------------
        da = New OleDbDataAdapter("SELECT ID, Condition from Genaral_Condition", cn)
        dt = New DataTable("Genaral_Condition")
        cn.Open() : da.Fill(dt) : cn.Close()
        If dt.Rows.Count > 0 Then
            sql2 = "INSERT INTO Mike_Condition(Sl_No, Licence_Conditions, Mike_ID) VALUES(@sl,@cond,@id)"
            cmd = New OleDbCommand(sql2, cn)
            With cmd.Parameters
                .AddWithValue("@sl", 0) : .AddWithValue("@cond", "Licence_Conditions") : .AddWithValue("@id", 0)
            End With

            serial = 1
            For i As Integer = 0 To dt.Rows.Count - 1
                With cmd
                    .Parameters("@sl").Value = serial : .Parameters("@cond").Value = dt.Rows(i)("condition")
                    .Parameters("@id").Value = TextBox1.Text
                End With
                cn.Open() : cmd.ExecuteNonQuery() : cn.Close()
                serial = serial + 1
            Next
        ElseIf dt.Rows.Count = 0 Then : End If
        '---------------------------------------------------
        da = New OleDbDataAdapter("SELECT decription from infoTemp", cn) : dt = New DataTable("infoTemp")
        cn.Open() : da.Fill(dt) : cn.Close()
        If dt.Rows.Count > 0 Then
            sql2 = "INSERT INTO info (Mike_ID, decription, Sl_No) VALUES(@id,@decr,@sl)"
            cmd = New OleDbCommand(sql2, cn)
            With cmd.Parameters
                .AddWithValue("@id", 0) : .AddWithValue("@decr", "decription") : .AddWithValue("@sl", 0)
            End With

            serial = 1
            For i As Integer = 0 To dt.Rows.Count - 1
                With cmd
                    .Parameters("@id").Value = TextBox1.Text : .Parameters("@decr").Value = dt.Rows(i)("decription")
                    .Parameters("@sl").Value = serial
                End With
                cn.Open() : cmd.ExecuteNonQuery() : cn.Close() : serial = serial + 1
            Next
        ElseIf dt.Rows.Count = 0 Then : End If
        ' -------------------------------------------
        cmd = New OleDbCommand("delete from infoTemp", cn)
        cn.Open() : cmd.ExecuteNonQuery() : cn.Close()
        ' -------------------------------------
        If MsgBox("Do you want to print ? ", vbYesNo, "Mike Licence") = vbYes Then
            Call toWord()
            oWord.PrintOut(, , , , , , , 2)

            '   MsgBox("order sent to your defalt printer")
            oDoc.Close(False) : oWord.Application.Quit(False) : oDoc = Nothing : oWord = Nothing
        Else : End If
        Call ClearAll() : Call setSerial() : Call setInfo() : Call getGnrlCondition() : TextBox1.Focus()
    End Sub

    Public Sub setInfo()
        da = New OleDbDataAdapter("select (decription) as [Information To] from InfoTemp", cn)
        dt = New DataTable : cn.Open() : da.Fill(dt) : cn.Close()
        With dtInfo
            .DataSource = dt : .Columns(0).Width = 300
        End With
    End Sub

    Public Sub setSerial()
        cmd = New OleDbCommand("select Mike_ID, Licence_Date from Mike Where Licence_Date=(Select MAX(Licence_Date) from Mike)", cn)
        cn.Open() : dr = cmd.ExecuteReader : dr.Read()
        If dr.HasRows Then
            If dr.Item(1).Year = DateTimePicker1.Value.Year Then : TextBox10.Text = dr.Item(0) + 1
            Else : TextBox10.Text = 1
            End If
        End If : cn.Close()
        TextBox1.Text = TextBox10.Text & "/" & DateTimePicker1.Value.Year
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        Call ClearAll()
        cmd = New OleDbCommand("delete from infoTemp", cn)
        cn.Open() : cmd.ExecuteNonQuery() : cn.Close()
        Call setSerial() : Call getGnrlCondition()
    End Sub
    Public Sub getGnrlCondition()
        da = New OleDbDataAdapter("select Condition from Genaral_Condition", cn)
        dt = New DataTable("Genaral_Condition") : cn.Open() : da.Fill(dt) : cn.Close()
        With gnlCondition
            .DataSource = dt : .Columns(0).Width = 700
        End With
    End Sub
    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        NudiTurnOnScrollLock()
    End Sub

    Public Sub toWord()
        oDoc = Nothing : oWord = Nothing
        oWord = CreateObject("word.application") : oDoc = oWord.Documents.Add

        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = "PÀ£ÁðlPÀ gÁdå ¥ÉÆ°Ã¸ï                                                                          ¥sÁªÀÄð £ÀA. 298(4)"
        oPara1.Range.Font.Size = 10 : oPara1.Range.Font.Name = "Nudi 01 e"
        oPara1.Range.ParagraphFormat.SpaceAfter = 0 : oPara1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        oPara1.Range.InsertParagraphAfter()

        oPara2 = oDoc.Content.Paragraphs.Add : oPara2.Range.Text = "-: zsÀé¤ªÀzsÀðPÀ §¼À¸ÀÄªÀÅzÀPÁÌV ¥ÀgÀªÁ¤UÉ :-"
        oPara2.Range.Font.Size = 18 : oPara2.Range.Font.Name = "Nudi 01 e" : oPara2.Range.ParagraphFormat.SpaceAfter = 0
        oPara2.Range.Font.Bold = True : oPara2.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        oPara2.Range.InsertParagraphAfter()

        oPara3 = oDoc.Content.Paragraphs.Add : oPara3.Range.Text = "(PÀ®A. 37 PÀ£ÁðlPÀ gÁdå ¥ÉÆ°Ã¸ï PÁ¬ÄzÉ)"
        oPara3.Range.Font.Size = 12 : oPara3.Range.Font.Name = "Nudi 01 e" : oPara3.Range.ParagraphFormat.SpaceAfter = 0
        oPara3.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter : oPara3.Range.InsertParagraphAfter()


        oTable2 = oDoc.Tables.Add(oDoc.Bookmarks("\endofdoc").Range, 7, 2)
        oTable2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        oTable2.Range.Cells.Borders.Enable = True : oTable2.Cell(1, 1).Column.Width = 200
        oTable2.Cell(1, 2).Column.Width = 300 : oTable2.Range.ParagraphFormat.LineSpacing = 10
        oTable2.Range.ParagraphFormat.SpaceAfter = 0 : oTable2.Range.ParagraphFormat.SpaceBefore = 5
        oTable2.AllowAutoFit = True

        sql = New String("SELECT Licence_No, Holder_Name, Holder_Address, Holder_Mobile, " _
                    & " Mike_Reason, Perm_from_Date, Perm_to_Date, Vehicle_No, Place, " _
                    & " Challan_No, Challan_Date, Challan_Amount, Licence_Date" _
                    & " FROM Mike WHERE Licence_No='" & TextBox1.Text & "'")

        cmd = New OleDbCommand(sql, cn) : cn.Open() : dr = cmd.ExecuteReader : dr.Read()
        If dr.HasRows Then : l = dr.Item(1) : n = dr.Item(2) : o = dr.Item(3)

            oTable2.Cell(1, 1).Range.Text = "¥ÀgÀªÁ¤UÉ ¸ÀASÉå" : oTable2.Cell(1, 2).Range.Text = "CPI/BKL/AMP/" & dr.Item(0)
            oTable2.Cell(2, 1).Range.Text = "¥ÀgÀªÁ¤UÉzÁgÀgÀ «ªÀgÀ"
            oTable2.Cell(2, 2).Range.Text = "²æÃ " & dr.Item(1) & " ¸Á|| " & dr.Item(2) & " ªÉÆ.£ÀA. " & dr.Item(3)
            oTable2.Cell(2, 2).Range.ParagraphFormat.LineSpacing = 12 : oTable2.Cell(3, 1).Range.Text = "zsÀé¤ªÀzsÀðPÀ §¼À¸ÀÄªÀ GzÉÝÃ±À"
            oTable2.Cell(3, 2).Range.Text = dr.Item(4) : oTable2.Cell(4, 1).Range.Text = "zsÀé¤ªÀzsÀðPÀ §¼À¸ÀÄªÀ ¢£ÁAPÀ"

            ' Dim sr1 As String = (dr.Item(5).Day & "/" & dr.Item(5).Month & "/" & dr.Item(5).Year)
            Dim sr2 As String = (Format(dr.Item(5), "dd'/'MM'/'yyyy"))
            Dim sr3 As String = (Format(dr.Item(6), "dd'/'MM'/'yyyy"))
            Dim sr4 As String = (Format(dr.Item(10), "dd'/'MM'/'yyyy"))
            Dim sr5 As String = (Format(dr.Item(12), "dd'/'MM'/'yyyy"))

            '  Dim s1() As String = Split(dr.Item(5).ToString, " ") : Dim s2() As String = Split(dr.Item(6).ToString, " ")
            ' Dim s3() As String = Split(dr.Item(12).ToString, " ")

            If dr.Item(5) = dr.Item(6) Then : oTable2.Cell(4, 2).Range.Text = sr2 & " gÀAzÀÄ "
            Else : oTable2.Cell(4, 2).Range.Text = sr2 & " jAzÀ " & sr3 & " gÀªÀgÉUÉ " : End If

            oTable2.Cell(5, 1).Range.Text = "zsÀé¤ªÀzsÀðPÀ §¼À¸ÀÄªÀ ªÁºÀ£ÀzÀ ¸ÀASÉå" : oTable2.Cell(5, 2).Range.Text = dr.Item(7)
            oTable2.Cell(6, 1).Range.Text = "zsÀé¤ªÀzsÀðPÀ §¼À¸ÀÄªÀ ¥ÀæzÉÃ±À" : oTable2.Cell(6, 2).Range.Text = dr.Item(8)
            oTable2.Cell(7, 1).Range.Text = "ZÀ®£ï «ªÀgÀ"
            oTable2.Cell(7, 2).Range.Text = "ZÀ®£ï £ÀA. " & dr.Item(9) & " ¢: " & sr4 & " ªÉÆvÀÛ " & dr.Item(11) & ".00 gÀÆ."

            cn.Close()

            For dic = 1 To 7
                oTable2.Rows(dic).Range.Font.Name = "Nudi 01 e" : oTable2.Rows(dic).Range.Font.Size = 13
                oTable2.Rows(dic).Range.Font.Bold = False : oTable2.Cell(1, 2).Range.Font.Name = "Times New Roman"
                oTable2.Cell(1, 2).Range.Font.Size = 12 : oTable2.Cell(5, 2).Range.Font.Name = "Times New Roman"
                oTable2.Cell(5, 2).Range.Font.Size = 12
            Next

            oPara4 = oDoc.Content.Paragraphs.Add : oPara4.Range.Text = "µÀgÀvÀÄÛUÀ¼ÀÄ :-"
            oPara4.Range.Font.Size = 16 : oPara4.Range.Font.Name = "Nudi 01 e"
            oPara4.Range.ParagraphFormat.SpaceBefore = 15 : oPara4.Range.ParagraphFormat.SpaceBefore = 15
            oPara4.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft : oPara4.Range.InsertParagraphAfter()

            sql = New String("SELECT Sl_No, Licence_Conditions from Mike_Condition WHERE Mike_ID='" & TextBox1.Text & "'")
            dt = New DataTable : da = New OleDbDataAdapter(sql, cn) : cn.Open() : da.Fill(dt) : cn.Close()

            oTable = oDoc.Tables.Add(oDoc.Bookmarks("\endofdoc").Range, dt.Rows.Count, 2, 0, 1)
            oTable.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oTable.Range.ParagraphFormat.SpaceAfter = 5 : oTable.Range.ParagraphFormat.SpaceBefore = 5
            oTable.Range.ParagraphFormat.LineSpacing = 12 : oTable.AllowAutoFit = True

            cmd = New OleDbCommand(sql, cn) : cn.Open() : dr = cmd.ExecuteReader : dr.Read()
            Do While dr.Read()
                For i = 1 To dt.Rows.Count
                    For c As Integer = 1 To 2
                        oTable.Cell(i, c).Range.Text = dt.Rows(i - 1)(c - 1)
                    Next
                Next
            Loop
            cn.Close()

            For x As Integer = 1 To dt.Rows.Count
                oTable.Rows(x).Range.Font.Bold = False : oTable.Rows(x).Range.Font.Name = "Nudi 01 e" : oTable.Rows(x).Range.Font.Size = 13
            Next

            oPara5 = oDoc.Content.Paragraphs.Add
            oPara5.Range.Text = "     F ªÉÄÃ®ÌAqÀ µÀgÀvÀÄÛUÀ¼À£ÀÄß G®èAX¹zÀ°è PÀ®A.109 PÀ£ÁðlPÀ ¥ÉÆ°Ã¸ÀÄ PÁAiÉÄÝAiÀÄAvÉ zÀAqÀ¢ü¸À§ºÀÄzÁVgÀÄvÀÛzÉ. ºÁUÀÆ zsÀé¤ªÀzsÀðPÀ ¥ÀgÀªÁ¤UÉAiÀÄ£ÀÄß AiÀiÁªÀ ¸ÀªÀÄAiÀÄzÀ°è ¨ÉÃPÁzÀgÀÆ gÀzÀÄÝ ªÀiÁqÀ§ºÀÄzÀÄ."
            oPara5.Range.Font.Size = 13 : oPara5.Range.Font.Name = "Nudi 01 e"
            oPara5.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft : oPara5.Range.InsertParagraphAfter()

            cmd = New OleDbCommand("SELECT Loc from tblLoc", cn)
            cn.Open() : dr = cmd.ExecuteReader : dr.Read()

            oPara9 = oDoc.Content.Paragraphs.Add : oPara9.Range.Text = "¸ÀÜ¼À:      " & dr.Item(0) : cn.Close()
            oPara9.Range.Font.Size = 13 : oPara9.Range.Font.Name = "Nudi 01 e" : oPara9.Range.Font.Bold = False
            oPara9.Range.ParagraphFormat.SpaceBefore = 15
            oPara9.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oPara9.LeftIndent = 0 : oPara9.Range.InsertParagraphAfter()

            oPara10 = oDoc.Content.Paragraphs.Add : oPara10.Range.Text = "¢£ÁAPÀ: " & sr5
            oPara10.Range.Font.Size = 13 : oPara10.Range.Font.Name = "Nudi 01 e"
            oPara10.Range.Font.Bold = False : oPara10.Range.ParagraphFormat.SpaceBefore = 3
            oPara10.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oPara10.LeftIndent = 0 : oPara10.Range.InsertParagraphAfter()

            oPara6 = oDoc.Content.Paragraphs.Add : oPara6.Range.Text = "jUÉ," : oPara6.Range.Font.Size = 16
            oPara6.Range.Font.Name = "Nudi 01 e" : oPara6.Range.ParagraphFormat.SpaceBefore = 15
            oPara6.Range.ParagraphFormat.SpaceBefore = 15
            oPara6.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft : oPara6.Range.InsertParagraphAfter()

            oPara7 = oDoc.Content.Paragraphs.Add : oPara7.Range.Text = "²æÃ " & l : oPara7.Range.Font.Size = 13
            oPara7.Range.Font.Name = "Nudi 01 e" : oPara7.Range.Font.Bold = False
            oPara7.Range.ParagraphFormat.SpaceBefore = 0 : oPara7.Range.ParagraphFormat.SpaceAfter = 0
            oPara7.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oPara7.LeftIndent = 25 : oPara7.Range.InsertParagraphAfter()

            oPara12 = oDoc.Content.Paragraphs.Add : oPara12.Range.Text = "¸Á|| " & n
            oPara12.Range.Font.Size = 13 : oPara12.Range.Font.Name = "Nudi 01 e" : oPara12.Range.Font.Bold = False
            oPara12.Range.ParagraphFormat.SpaceBefore = 0 : oPara12.Range.ParagraphFormat.SpaceAfter = 0
            oPara12.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oPara12.LeftIndent = 25 : oPara12.Range.InsertParagraphAfter()

            oPara11 = oDoc.Content.Paragraphs.Add : oPara11.Range.Text = "ªÉÆ. £ÀA. " & o : oPara11.Range.Font.Size = 13
            oPara11.Range.Font.Name = "Nudi 01 e" : oPara11.Range.Font.Bold = False
            oPara11.Range.ParagraphFormat.SpaceBefore = 0 : oPara11.Range.ParagraphFormat.SpaceAfter = 0
            oPara11.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oPara11.LeftIndent = 25 : oPara11.Range.InsertParagraphAfter()

            oPara8 = oDoc.Content.Paragraphs.Add : oPara8.Range.Text = "ªÀiÁ»w" : oPara8.Range.Font.Size = 13
            oPara8.Range.Font.Name = "Nudi 01 e" : oPara8.Range.Font.Bold = True
            oPara8.Range.ParagraphFormat.SpaceBefore = 15
            oPara8.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oPara8.LeftIndent = 0 : oPara8.Range.InsertParagraphAfter()

            sql = New String("select Sl_No, decription from info WHERE Mike_ID='" & TextBox1.Text & "'")
            cmd = New OleDbCommand(sql, cn) : da = New OleDbDataAdapter(cmd) : dt = New DataTable("info")
            cn.Open() : da.Fill(dt) : cn.Close()

            oTable3 = oDoc.Tables.Add(oDoc.Bookmarks("\endofdoc").Range, dt.Rows.Count, 2, 0, 1)
            oTable3.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oTable3.AllowAutoFit = True : oTable3.LeftPadding = 20 : oTable3.Range.ParagraphFormat.SpaceAfter = 2
            oTable3.Range.ParagraphFormat.SpaceBefore = 2 : oTable3.Range.ParagraphFormat.LineSpacing = 12

            For rw As Integer = 1 To dt.Rows.Count
                For cw As Integer = 1 To 2
                    oTable3.Cell(rw, cw).Range.Text = dt.Rows(rw - 1)(cw - 1)
                Next
            Next

            For xc = 1 To dt.Rows.Count
                oTable3.Rows(xc).Range.Font.Bold = False : oTable3.Rows(xc).Range.Font.Name = "Nudi 01 e"
                oTable3.Rows(xc).Range.Font.Size = 13
            Next

            oDoc.PageSetup.LayoutMode = Word.WdLayoutMode.wdLayoutModeDefault
            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait
            oDoc.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4
            oDoc.PageSetup.TopMargin = 50 : oDoc.PageSetup.LeftMargin = 50
            oDoc.PageSetup.RightMargin = 40 : oDoc.PageSetup.BottomMargin = 25

            On Error GoTo last : oDoc.FitToPages()
last:
        Else : MessageBox.Show("No Record Found", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Call toWord()
        oWord.Visible = True : oWord.Activate() : Me.SendToBack()
        oDoc = Nothing : oWord = Nothing
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If Val(TextBox10.Text - 1) & "/" & DateTimePicker1.Value.Year >= TextBox1.Text Then
            Call toWord()
            oWord.PrintOut(, , , , , , , 2)
            MsgBox("order sent to your defalt printer")

            oDoc.Close(False) : oWord.Application.Quit(False)
            oDoc = Nothing : oWord = Nothing : TextBox1.Focus()
        Else
            MsgBox("No record found", vbCritical, "Mike Licence")
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        frmRepSearch.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        TextBox10.Text = TextBox1.Text : Call Search()
    End Sub
    Public Sub Search()
        sql = New String("SELECT * from Mike WHERE Mike_ID=" & TextBox10.Text & "")
        cmd = New OleDbCommand(sql, cn) : cn.Open() : dr = cmd.ExecuteReader : dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr.Item(0) : TextBox2.Text = dr.Item(1) : TextBox3.Text = dr.Item(2)
            TextBox4.Text = dr.Item(3) : TextBox5.Text = dr.Item(4) : TextBox6.Text = dr.Item(7)
            TextBox7.Text = dr.Item(8) : TextBox8.Text = dr.Item(9) : TextBox9.Text = dr.Item(11)
            DateTimePicker1.Value = dr.Item(13) : DateTimePicker2.Value = dr.Item(5)
            DateTimePicker3.Value = dr.Item(6) : DateTimePicker4.Value = dr.Item(10)
        Else : MsgBox("no data found") : End If
        cn.Close()

        sql = New String("SELECT Licence_Conditions from Mike_Condition WHERE Mike_ID='" & TextBox1.Text & "'")
        da = New OleDbDataAdapter(sql, cn) : ds = New DataSet
        cn.Open() : da.Fill(ds, "Mike_Condition") : cn.Close()
        dt = New DataTable : dt = ds.Tables(0)
        With gnlCondition
            .DataSource = dt : .Columns(0).Width = 700
        End With

        sql = New String("SELECT decription from info WHERE Mike_ID='" & TextBox1.Text & "'")
        da = New OleDbDataAdapter(sql, cn) : ds = New DataSet
        cn.Open() : da.Fill(ds, "info") : cn.Close()
        dt = New DataTable : dt = ds.Tables(0)
        With dtInfo
            .DataSource = dt : .Columns(0).Width = 300
        End With
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call Data_Move()
        TextBox10.Text = dt.Rows(0).Item(0).ToString
        Call Search()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Call Data_Move()
        Dim a As Double : a = dt.Rows.Count - 1
        TextBox10.Text = dt.Rows(a).Item(0).ToString
        Call Search()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Call Data_Move()
        If TextBox10.Text = dt.Rows(0).Item(0).ToString Then
            Exit Sub
        Else : Dim a As Double : a = TextBox10.Text : TextBox10.Text = a - 1
            Call Search()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Call Data_Move()
        Dim b As Double : b = dt.Rows.Count - 1
        If TextBox10.Text = dt.Rows(b).Item(0).ToString Then
            Exit Sub
        Else
            Dim a As Double : a = TextBox10.Text
            TextBox10.Text = a + 1
            Call Search()
        End If
    End Sub
    Public Sub Data_Move()
        dt.Clear()
        da = New OleDbDataAdapter("select Mike_ID from Mike", cn)
        dt = New DataTable : cn.Open() : da.Fill(dt) : cn.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        frmInfo.ShowDialog()
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        NudiTurnOnScrollLock()
    End Sub

    Private Sub TextBox5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.GotFocus
        NudiTurnOnScrollLock()
        Dim fd As Date : Dim tod As Date : fd = DateTimePicker2.Value : tod = DateTimePicker3.Value
        If fd = tod Then : TextBox9.Text = 60
        Else : Dim cat : cat = DateDiff("d", fd, tod) : cat = cat * 10 : TextBox9.Text = Val(60 + cat)
        End If
    End Sub
    Private Sub TextBox7_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.GotFocus
        NudiTurnOnScrollLock()
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then : lblCount.Text = ""
        Else : lblCount.Text = Len(LTrim(RTrim(TextBox4.Text)))
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
            e.KeyChar = ChrW(0)
        End If
    End Sub
    Public Sub enterkey(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim oNextcontrol As System.Windows.Forms.Control = Me.GetNextControl(CType(sender, Control), True)
            oNextcontrol.Focus()
        End If
    End Sub
    Public Sub OnlyChr(ByVal sender As Object, ByRef e As KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
            e.KeyChar = ChrW(0)
        End If
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        NudiTurnOffScrollLock()
    End Sub
    Private Sub TextBox6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.GotFocus
        NudiTurnOffScrollLock()
    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        e.KeyChar = ChrW(Asc(UCase(Chr(Asc(e.KeyChar)))))
    End Sub
    Private Sub TextBox8_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.GotFocus
        NudiTurnOffScrollLock()
    End Sub
    Private Sub gnlCondition_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gnlCondition.CellContentClick
        frmConditions.ShowDialog()
    End Sub
    Private Sub ClearAll()
        For Each Control In Me.Controls
            If TypeOf Control Is TextBox Or TypeOf Control Is ComboBox Then : Control.Text = ""
            ElseIf TypeOf Control Is DateTimePicker Then : Control.Value = Today
            ElseIf TypeOf Control Is DataGridView Then : Control.DataSource = Nothing
            End If : Next Control
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmLoc.ShowDialog()
    End Sub
    Public Sub Validate_text()
        Dim amt = TextBox9.Text : Dim txtboxes = Me.Controls.OfType(Of TextBox)()
        For Each txt In txtboxes
            If String.IsNullOrEmpty(txt.Text) Then : txt.Focus() : txt.BackColor = Color.Pink : TextBox9.Text = amt
            Else : txt.BackColor = Color.White
            End If
        Next
        If dtInfo.RowCount = 0 Then : cmbInof.BackColor = Color.Pink
        Else : cmbInof.BackColor = Color.White
        End If
    End Sub
End Class
