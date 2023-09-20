Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.WindowState = FormWindowState.Maximized








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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox_Student_Info.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_Team_Number_TextChanged(sender As Object, e As EventArgs) Handles Txt_Team_Number.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txt_LR.TextChanged

    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Bridge Competition",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If





    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Me.DGV_Team_Results.Rows.Clear()
        Me.DGB_Team_Rank.Rows.Clear()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim q As Integer
        If DGV_Team_Results.SelectedRows.Count > 0 Then
            For q = DGV_Team_Results.SelectedRows.Count - 1 To 0 Step -1
                DGV_Team_Results.Rows.RemoveAt(DGV_Team_Results.SelectedRows(q).Index)

            Next
        Else
            MessageBox.Show("No row selcted")

        End If
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        DGV_Team_Results.Rows.Add(Txt_School_Team.Text, Txt_BDEF.Text, Txt_BW.Text, Txt_Load.Text, Txt_LR.Text, Txt_BDR.Text, Txt_BDRR.Text, Txt_Total_Final.Text)
        DGB_Team_Rank.Rows.Add(Txt_School_Team.Text, Txt_Total_Final.Text)




    End Sub

    Private Sub Txt_Load_TextChanged(sender As Object, e As EventArgs) Handles Txt_Load.TextChanged

    End Sub

    Private Sub Btn_Add2_Click(sender As Object, e As EventArgs) Handles Btn_Add2.Click

    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click

    End Sub

    Private Sub Txt_School_Team_TextChanged(sender As Object, e As EventArgs) Handles Txt_School_Team.TextChanged

    End Sub

    Private Sub Txt_Rank_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
