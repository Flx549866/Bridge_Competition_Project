Imports System.Data.SqlClient
Imports System.Data



Public Class Form1
    Dim team_num As Integer = InputBox("Enter number of contestants.") - 1
    Dim intValues(team_num) As Double
    'Dim a as integer

    Dim bwArray(team_num) As Double
    Dim lpArray(team_num) As Double
    Dim mdrArray(team_num) As Double
    Dim bdefArray(team_num) As Double
    Dim brokenArray(team_num) As Boolean
    Dim scoreArray(team_num) As Double

    'Add and enter team names
    Dim nameArray(team_num) As String

    Dim searchValue As Integer
    Dim searchValue1 As Integer
    Dim searchValue2 As Integer
    Dim searchValue5 As Integer



    Public Sub Names()
        For count As Integer = 0 To team_num
            nameArray(count) = InputBox("Enter a team name for team" + Str(count + 1) + ": ")
            Dim bwArrayVal As String = InputBox("Enter a bridge weight for team" + Str(count + 1) + ": ")
            While IsNumeric(bwArrayVal) = False
                bwArrayVal = InputBox("Enter a bridge weight for team" + Str(count + 1) + " (numeric only): ")
            End While
            bwArray(count) = bwArrayVal
            Dim bdefArrayVal As String = InputBox("Enter the BDEF for team" + Str(count + 1) + ": ")
            While IsNumeric(bdefArrayVal) = False
                bdefArrayVal = InputBox("Enter BDEF for team" + Str(count + 1) + " (numeric only): ")
            End While
            bdefArray(count) = bdefArrayVal
        Next

    End Sub
    Public Sub AddWeight(weight As Double)

        For count As Integer = 0 To team_num
            If brokenArray(count) = False Then
                lpArray(count) += weight

            End If

        Next
    End Sub
    Private Sub BrokenStart()
        For count As Integer = 0 To team_num
            brokenArray(count) = False
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        searchValue = -1
        searchValue1 = -1
        searchValue2 = -1
        searchValue5 = -1
        Names()
        BrokenStart()





    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnApplication_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox_Team_Results.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Team_Results.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_Team_Number_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txt_LP.TextChanged

    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Bridge Competition",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If





    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs)
        'Me.DGV_Team_Results.Rows.Clear()
        'Me.DGV_Team_Rank.Rows.Clear()
        'Me.Txt_BW.Clear()
        'Me.Txt_LP.Clear()
        ' Me.Txt_MDR.Clear()




    End Sub

    'Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
    '    Dim q As Integer
    '    If DGV_Team_Results.SelectedRows.Count > 0 Then
    '        For q = DGV_Team_Results.SelectedRows.Count - 1 To 0 Step -1
    '            DGV_Team_Results.Rows.RemoveAt(DGV_Team_Results.SelectedRows(q).Index)

    '        Next
    '    ElseIf DGV_Team_Rank.SelectedRows.Count > 0 Then
    '        For i = DGV_Team_Rank.SelectedRows.Count - 1 To 0 Step -1
    '            DGV_Team_Rank.Rows.RemoveAt(DGV_Team_Rank.SelectedRows(i).Index)
    '        Next




    '    Else
    '        MessageBox.Show("No row selcted")

    '    End If
    'End Sub

    'Private Sub Btn_Update_Click(sender As Object, e As EventArgs)
    '    Dim Number As Integer
    '    Number = Txt_BW.Text

    '    If searchValue = 5 Then
    '        MsgBox("The array is full.", MsgBoxStyle.Information)

    '        Txt_BW.Text = ""
    '        Txt_BW.Enabled = True

    '    Else

    '        searchValue = searchValue + 1
    '        bwArray(searchValue) = Number
    '        Txt_BW.Text = ""
    '        Txt_BW.Focus()

    '    End If


    '    'Dim Number1 As Integer
    '    'Number1 = Txt_LP.Text
    '    'If searchValue1 = 5 Then
    '    '    MsgBox("The array is full.", MsgBoxStyle.Information)

    '    '    Txt_LP.Text = ""
    '    '    Txt_LP.Enabled = True
    '    'Else
    '    '    searchValue1 = searchValue1 + 1
    '    'lpArray(searchValue1) = Number1
    '    'Txt_LP.Text = ""
    '    'Txt_LP.Focus()

    '    'End If

    '    'Dim Number2 As Integer

    '    'Number2 = Txt_MDR.Text

    '    'If searchValue2 = 5 Then
    '    '    MsgBox("The array is full.", MsgBoxStyle.Information)

    '    '    Txt_MDR.Text = ""
    '    '    Txt_MDR.Enabled = True
    '    'Else
    '    '    searchValue2 = searchValue2 + 1
    '    '    mdrArray(searchValue2) = Number2
    '    '    Txt_MDR.Text = ""
    '    '    Txt_MDR.Focus()

    '    'End If

    '    'Dim Number3 As Integer

    '    'Number3 = Txt_BDEF.Text

    '    'If searchValue5 = 5 Then
    '    '    MsgBox("The array is full.", MsgBoxStyle.Information)

    '    '    Txt_BDEF.Text = ""
    '    '    Txt_BDEF.Enabled = True
    '    'Else
    '    '    searchValue5 = searchValue5 + 1
    '    '    bdefArray(searchValue2) = Number3
    '    '    Txt_BDEF.Text = ""
    '    '    Txt_BDEF.Focus()

    '    'End If



    'End Sub

    Private Sub Txt_Load_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Add2_Click(sender As Object, e As EventArgs) Handles Btn_Update2.Click
        For count As Integer = 0 To team_num
            mdrArray(count) = bwArray(count) / lpArray(count)
        Next
        Me.DGV_Team_Results.Rows.Clear()
        Me.DGV_Team_Rank.Rows.Clear()
        'Me.Txt_BW.Clear()
        Me.Txt_LP.Clear()

        'BW calculation
        Dim DBW, BWR, a, b As Double
        Dim Bw, BwMax, BwMin, BW1 As Double
        'Txt_BW.Text = ""
        'Commented sections are done in for loop for each team at a time
        'Bw = Txt_BW.Text
        'BW1 = CType(Bw, Double)

        BwMax = bwArray.Max
        BwMin = bwArray.Min
        a = CType(BwMax, Double)
        b = CType(BwMin, Double)

        DBW = a - b
        'BWR = 1 + ((49 / DBW) * (a - BW1))


        'Lp calculation
        Dim LPR, LPRR, c, d As Double
        Dim Lp, LpMax, LpMin, Lp1 As Double
        'Txt_LP.Text = ""
        'Lp = Txt_LP.Text
        'Lp1 = CType(Lp, Double)

        LpMax = lpArray.Max
        LpMin = lpArray.Min
        c = CType(LpMax, Double)
        d = CType(LpMin, Double)

        LPR = c - d

        Dim mdrMax, mdrMin, mdrDelta, MDRR As Double

        mdrMax = mdrArray.Max
        mdrMin = mdrArray.Min
        mdrDelta = mdrMax - mdrMin


        'Dim BDEF1 As Double
        'BDEF1 = 10
        'LPRR = 1 + ((49 / LPR) * (Lp1 - d))
        For count As Integer = 0 To team_num

            'bw needs to change per bridge, done in for loop

            Bw = bwArray(count)
            BW1 = CType(Bw, Double)
            BWR = 1.0 + ((49.0 / DBW) * (a - BW1))

            Lp = lpArray(count)
            Lp1 = CType(Lp, Double)
            LPRR = 1.0 + ((49.0 / LPR) * (Lp1 - d))


            MDRR = 1.0 + (49.0 / mdrDelta) * (mdrMax - mdrArray(count))

            scoreArray(count) = (BWR + LPRR + bdefArray(count)) + MDRR
            DGV_Team_Rank.Rows.Add(nameArray(count), Math.Round(scoreArray(count), 2))

            DGV_Team_Results.Rows.Add(count + 1, nameArray(count), Format(BWR, "0.00"), Format(LPRR, "0.00"), (bdefArray(count)), Format(scoreArray(count), "0.00"), (brokenArray(count)))
        Next
        DGV_Team_Rank.Sort(DGV_Team_Rank.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        For count As Integer = 0 To team_num
            DGV_Team_Rank(2, count).Value = count + 1
        Next



        'MDR calculation
        'Dim MDR1, MDRR, g, f, mdrMax, mdrMIN As Double
        'Dim MD As String, M1 As Double
        ''Txt_MDR.Text = ""
        'MD = Txt_MDR.Text
        'M1 = CType(MD, Double)
        'mdrMax = mdrArray.Max
        'mdrMin = mdrArray.Min
        'g = CType(mdrMax, Double)
        'f = CType(mdrMIN, Double)
        'MDR1 = g - f

        'MDRR = 1 + ((49 / MDR1) * (g - M1))







        'Dim BDEF As String

        'Txt_BDEF.Text = ""
        'BDEF = Txt_BDEF.Text

        'BDEF1 = CType(BDEF, Double)

        'Total_Score
        'Dim Total_Score(3) As Double

        'Dim searchValue3 As Integer

        'searchValue = -1
        'If searchValue3 = 5 Then
        '    MsgBox("The array is full.", MsgBoxStyle.Information)

        'Else
        '    searchValue3 = searchValue3 + 1
        '    Total_Score(searchValue3) = (BWR + LPRR + BDEF1) + (BW1 / Lp1)
        '    'Array.Sort(Total_Score)



        '    ' Txt_MDR.Focus()

        'End If
        'For AddNext = 0 To searchValue3

        '    DGV_Team_Rank.Sort(DGV_Team_Rank.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        'Next AddNext
        ''Array.Sort(Total_Score)
        '' Array.Reverse(Total_Score)


        'Total_Score1 = BWR + LPRR + MDRR + BDEF

        'DGV_Team_Rank.Rows.Add(Txt_School_Team.Text, Total_Score(searchValue3))
        ' DGV_Team_Results.Rows.Add(Txt_School_Team.Text, Math.Round(BWR, 2), Math.Round(LPRR, 2), Math.Round(MDRR, 2), Math.Round(BDEF1, 2), Math.Round(Total_Score(searchValue3), 2))





    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs)
        Me.DGV_Team_Rank.Rows.Clear()

        'Me.Txt_BW.Clear()
        Me.Txt_LP.Clear()
        ' Me.Txt_MDR.Clear()




    End Sub

    Private Sub Txt_School_Team_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_Rank_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lbl_Load_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Input_Click(sender As Object, e As EventArgs) Handles Btn_Input.Click

        Lst_BW.Items.Clear()
        'lblMessage.Text = String.Empty

        Lst_LP.Items.Clear()
        'lblMessage.Text = String.Empty




        'BW array display in listbox

        'Lst_BW.Items.Clear()

        For AddNext = 0 To team_num

            Lst_BW.Items.Add("Team " & nameArray(AddNext) & ":" & " " & (Math.Round(bwArray(AddNext), 2)))


        Next AddNext
        '  Lst_BW.Sorted = True

        'LP Array in list box
        For AddNext = 0 To team_num

            Lst_LP.Items.Add("Team " & nameArray(AddNext) & ":" & " " & (Math.Round(lpArray(AddNext), 2)))


        Next AddNext

        'MDR Array




        'Lst_BDEF.Items.Clear()

        ''Lst_MDR.Sorted = 
        ''
        ''BDEF Array
        'Dim pos7 As Integer
        'Dim pos6 As String
        'pos7 = 0
        'Lst_BDEF.Items.Clear()
        'For AddNext = 0 To searchValue5
        '    pos7 = pos7 + 1
        '    pos6 = pos7
        '    Lst_BDEF.Items.Add("Team" & pos6 & ":" & " " & bdefArray(AddNext))


        'Next AddNext




    End Sub

    'Private Sub Btn_Max_Click(sender As Object, e As EventArgs)

    '    'Dim Result1 As Integer = Largest()
    '    'Dim result2 As Integer = Smallest()

    '    lblMessage.Text = "Max= " & bwArray.Max & vbCrLf & "Min= " & bwArray.Min & vbCrLf & "Max= " & lpArray.Max & vbCrLf & "Min= " & lpArray.Min & vbCrLf & "Max= " & mdrArray.Max & vbCrLf & "Min= " & mdrArray.Min
    '    '  lblMessage.Text = "Max= " & lpArray.Max & vbCrLf & "Min= " & lpArray.Min
    '    'lblMessage.Text = "Max= " & mdrArray.Max & vbCrLf & "Min= " & mdrArray.Min


    '    'initialize BWR as bridge weight rate
    '    'Dim BWR as Integer
    '    'ChangeinBW = bwMAX - bwMIN
    '    'BWR = 1 + (49/ChangeinBW) * (bwMAX / BW)

    '    ' *****NEED USER INPUT FOR lpBROKE AND mdrBROKE*****
    '    ' intialize LP as Load in Pounds amd LPR as Loud Pound Rate
    '    ' ChangeinLP = lpMAX - lpMIN
    '    ' LPR = 1 + (49/ChangeinLP) * (lpBROKE - lpMIN)
    '    'initalizd Model Design Ratio as MDR and Model Design Ratio Rate as MDRR( RANGE IS 1 THROUGH 50)
    '    'MDR = BW/LP
    '    'ChangeinMDR = mdrMAX - mdrMIN
    '    'MDRR = 1 + (49/) * mdrMAX -mdrBROKE
    '    '
    '    '



    'End Sub



    Private Sub Btn_Clear2_Click(sender As Object, e As EventArgs)
        'Lst_BW.Items.Clear()
        'lblMessage.Text = String.Empty

        'Lst_LP.Items.Clear()
        'lblMessage.Text = String.Empty

        'Lst_BDEF.Items.Clear()
        'lblMessage.Text = String.Empty

        'Lst_BDEF.Items.Clear()
        'lblMessage.Text = String.Empty
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_updatee_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGV_Team_Rank_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Team_Rank.CellContentClick

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lst_BW_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_BW.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btn_UpdateLp.Click

        'Dim Number1 As Double
        'Number1 = Txt_LP.Text
        'If searchValue1 = 5 Then
        '    MsgBox("The array is full.", MsgBoxStyle.Information)

        '    'Txt_LP.Text = ""
        '    Txt_LP.Enabled = True
        'Else
        '    searchValue1 = searchValue1 + 1
        '    lpArray(searchValue1) = Number1
        '    Txt_LP.Text = ""
        '    Txt_LP.Focus()

        'End If
        Dim Number1 As Double
        If IsNumeric(Txt_LP.Text) Then
            Number1 = Txt_LP.Text
            AddWeight(Number1)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dim Number2 As Integer

        'Number2 = Txt_MDR.Text

        'If searchValue2 = 5 Then
        '    MsgBox("The array is full.", MsgBoxStyle.Information)

        '    Txt_MDR.Text = ""
        '    Txt_MDR.Enabled = True
        'Else
        '    searchValue2 = searchValue2 + 1
        '    mdrArray(searchValue2) = Number2
        '    Txt_MDR.Text = ""
        '    Txt_MDR.Focus()

        'End If
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    Dim Number3 As Double

    '    Number3 = Txt_BDEF.Text

    '    If searchValue5 = 5 Then
    '        MsgBox("The array is full.", MsgBoxStyle.Information)

    '        Txt_BDEF.Text = ""
    '        Txt_BDEF.Enabled = True
    '    Else
    '        searchValue5 = searchValue5 + 1
    '        bdefArray(searchValue2) = Number3
    '        Txt_BDEF.Text = ""
    '        Txt_BDEF.Focus()

    '    End If
    'End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Lbl_LP_Click(sender As Object, e As EventArgs) Handles Lbl_LP.Click

    End Sub

    Private Sub Lst_BDEF_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_BDEF_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub Button1_Click_2(sender As Object, e As EventArgs)
    '    Dim Number1 As Double
    '    Number1 = Txt_BDEF.Text
    '    If searchValue1 = 5 Then
    '        MsgBox("The array is full.", MsgBoxStyle.Information)

    '        Txt_BDEF.Text = ""
    '        Txt_BDEF.Enabled = True
    '    Else
    '        searchValue1 = searchValue1 + 1
    '        bdefArray(searchValue1) = Number1
    '        Txt_BDEF.Text = ""
    '        Txt_BDEF.Focus()

    '    End If
    'End Sub

    Private Sub Lst_BDEF_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Dim teamBroke As Integer
        If IsNumeric(Txt_Remove.Text) Then
            If (0 < Int(Txt_Remove.Text)) And (Int(Txt_Remove.Text) - 1 <= team_num) Then
                teamBroke = Int(Txt_Remove.Text) - 1
                brokenArray(teamBroke) = Not brokenArray(teamBroke)
            End If
        End If


    End Sub

    Private Sub GroupBox_Buttons_Enter(sender As Object, e As EventArgs) Handles GroupBox_Buttons.Enter

    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_2(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub



    Private Sub Btn_BW_Override_Click(sender As Object, e As EventArgs) Handles Btn_BW_Override.Click
        If Validate_Override(Txt_Team_Number.Text, Txt_Bw_Override.Text) Then
            bwArray(Txt_Team_Number.Text - 1) = Txt_Bw_Override.Text
        End If
    End Sub

    Private Sub Btn_BDEF_Override_Click(sender As Object, e As EventArgs) Handles Btn_BDEF_Override.Click
        If Validate_Override(Txt_Team_Number.Text, Txt_BDEF_Override.Text) Then
            bdefArray(Txt_Team_Number.Text - 1) = Txt_BDEF_Override.Text
        End If
    End Sub

    Private Sub Btn_LP_Override_Click(sender As Object, e As EventArgs) Handles Btn_LP_Override.Click
        If Validate_Override(Txt_Team_Number.Text, Txt_LP_Override.Text) Then
            lpArray(Txt_Team_Number.Text - 1) = Txt_LP_Override.Text
        End If
    End Sub

    'Private Sub Btn_Ranking_Click(sender As Object, e As EventArgs) Handles Btn_Ranking.Click

    'End Sub

    Private Sub Txt_BDEF_Override_TextChanged(sender As Object, e As EventArgs) Handles Txt_BDEF_Override.TextChanged

    End Sub

    Private Function Validate_Override(team_number As Object, box_text As Object) As Boolean
        'nested ifs are relevant here, i don't want it giving an error checking if team_number is within that range when team_number is not numeric. for some reason i don't think VB exits the if condition if the first part of an And is false
        If IsNumeric(team_number) And IsNumeric(box_text) Then
            If (0 < team_number) And (team_number - 1 <= team_num) Then
                Return True

            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
