<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DGV_Team_Results = New System.Windows.Forms.DataGridView()
        Me.Lbl_Student_Name = New System.Windows.Forms.Label()
        Me.Txt_Student_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_School_Name = New System.Windows.Forms.Label()
        Me.Txt_School_Team = New System.Windows.Forms.TextBox()
        Me.Lbl_Team_Number = New System.Windows.Forms.Label()
        Me.Txt_Team_Number = New System.Windows.Forms.TextBox()
        Me.GroupBox_Student_Info = New System.Windows.Forms.GroupBox()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.GroupBox_Team_Results = New System.Windows.Forms.GroupBox()
        Me.Btn_Ranking = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.GroupBox_Data = New System.Windows.Forms.GroupBox()
        Me.Btn_Add2 = New System.Windows.Forms.Button()
        Me.Lbl_LR = New System.Windows.Forms.Label()
        Me.Lbl_Team2 = New System.Windows.Forms.Label()
        Me.Lbl_BDEF = New System.Windows.Forms.Label()
        Me.Lbl_BDR = New System.Windows.Forms.Label()
        Me.Lbl_BW = New System.Windows.Forms.Label()
        Me.Txt_LR = New System.Windows.Forms.TextBox()
        Me.Txt_Team_Number2 = New System.Windows.Forms.TextBox()
        Me.Txt_BDEF = New System.Windows.Forms.TextBox()
        Me.Lbl_BDRR = New System.Windows.Forms.Label()
        Me.Lbl_Load = New System.Windows.Forms.Label()
        Me.Txt_BDR = New System.Windows.Forms.TextBox()
        Me.Txt_BW = New System.Windows.Forms.TextBox()
        Me.Txt_BDRR = New System.Windows.Forms.TextBox()
        Me.Txt_Load = New System.Windows.Forms.TextBox()
        Me.GroupBox_Buttons = New System.Windows.Forms.GroupBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.GroupBox_Rank = New System.Windows.Forms.GroupBox()
        Me.Txt_Total_Final = New System.Windows.Forms.TextBox()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.School_Team = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDEF_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BW_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Load_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LR_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDR_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDRR_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGB_Team_Rank = New System.Windows.Forms.DataGridView()
        Me.GroupBox_Final_Rank = New System.Windows.Forms.GroupBox()
        Me.School_Name_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Score_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rank_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_Team_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Student_Info.SuspendLayout()
        Me.GroupBox_Team_Results.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Data.SuspendLayout()
        Me.GroupBox_Buttons.SuspendLayout()
        Me.GroupBox_Rank.SuspendLayout()
        CType(Me.DGB_Team_Rank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Final_Rank.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1850, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DGV_Team_Results
        '
        Me.DGV_Team_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Team_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.School_Team, Me.BDEF_1, Me.BW_1, Me.Load_1, Me.LR_1, Me.BDR_1, Me.BDRR_1, Me.Total_1})
        Me.DGV_Team_Results.Location = New System.Drawing.Point(0, 21)
        Me.DGV_Team_Results.Name = "DGV_Team_Results"
        Me.DGV_Team_Results.RowHeadersWidth = 51
        Me.DGV_Team_Results.RowTemplate.Height = 24
        Me.DGV_Team_Results.Size = New System.Drawing.Size(1791, 343)
        Me.DGV_Team_Results.TabIndex = 2
        '
        'Lbl_Student_Name
        '
        Me.Lbl_Student_Name.AutoSize = True
        Me.Lbl_Student_Name.Location = New System.Drawing.Point(23, 44)
        Me.Lbl_Student_Name.Name = "Lbl_Student_Name"
        Me.Lbl_Student_Name.Size = New System.Drawing.Size(98, 17)
        Me.Lbl_Student_Name.TabIndex = 3
        Me.Lbl_Student_Name.Text = "Student Name"
        '
        'Txt_Student_Name
        '
        Me.Txt_Student_Name.Location = New System.Drawing.Point(137, 41)
        Me.Txt_Student_Name.Name = "Txt_Student_Name"
        Me.Txt_Student_Name.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Student_Name.TabIndex = 5
        '
        'Lbl_School_Name
        '
        Me.Lbl_School_Name.AutoSize = True
        Me.Lbl_School_Name.Location = New System.Drawing.Point(23, 82)
        Me.Lbl_School_Name.Name = "Lbl_School_Name"
        Me.Lbl_School_Name.Size = New System.Drawing.Size(101, 17)
        Me.Lbl_School_Name.TabIndex = 3
        Me.Lbl_School_Name.Text = "School (Team)"
        '
        'Txt_School_Team
        '
        Me.Txt_School_Team.Location = New System.Drawing.Point(137, 77)
        Me.Txt_School_Team.Name = "Txt_School_Team"
        Me.Txt_School_Team.Size = New System.Drawing.Size(100, 22)
        Me.Txt_School_Team.TabIndex = 5
        '
        'Lbl_Team_Number
        '
        Me.Lbl_Team_Number.AutoSize = True
        Me.Lbl_Team_Number.Location = New System.Drawing.Point(23, 126)
        Me.Lbl_Team_Number.Name = "Lbl_Team_Number"
        Me.Lbl_Team_Number.Size = New System.Drawing.Size(98, 17)
        Me.Lbl_Team_Number.TabIndex = 3
        Me.Lbl_Team_Number.Text = "Team Number"
        '
        'Txt_Team_Number
        '
        Me.Txt_Team_Number.Location = New System.Drawing.Point(137, 121)
        Me.Txt_Team_Number.Name = "Txt_Team_Number"
        Me.Txt_Team_Number.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Team_Number.TabIndex = 5
        '
        'GroupBox_Student_Info
        '
        Me.GroupBox_Student_Info.Controls.Add(Me.Btn_Add)
        Me.GroupBox_Student_Info.Controls.Add(Me.Lbl_Student_Name)
        Me.GroupBox_Student_Info.Controls.Add(Me.Lbl_School_Name)
        Me.GroupBox_Student_Info.Controls.Add(Me.Txt_Student_Name)
        Me.GroupBox_Student_Info.Controls.Add(Me.Lbl_Team_Number)
        Me.GroupBox_Student_Info.Controls.Add(Me.Txt_School_Team)
        Me.GroupBox_Student_Info.Controls.Add(Me.Txt_Team_Number)
        Me.GroupBox_Student_Info.Location = New System.Drawing.Point(27, 0)
        Me.GroupBox_Student_Info.Name = "GroupBox_Student_Info"
        Me.GroupBox_Student_Info.Size = New System.Drawing.Size(259, 201)
        Me.GroupBox_Student_Info.TabIndex = 6
        Me.GroupBox_Student_Info.TabStop = False
        Me.GroupBox_Student_Info.Text = "Student Info"
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(162, 172)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Add.TabIndex = 6
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'GroupBox_Team_Results
        '
        Me.GroupBox_Team_Results.Controls.Add(Me.DGV_Team_Results)
        Me.GroupBox_Team_Results.Location = New System.Drawing.Point(27, 513)
        Me.GroupBox_Team_Results.Name = "GroupBox_Team_Results"
        Me.GroupBox_Team_Results.Size = New System.Drawing.Size(1811, 387)
        Me.GroupBox_Team_Results.TabIndex = 7
        Me.GroupBox_Team_Results.TabStop = False
        Me.GroupBox_Team_Results.Text = "Results"
        '
        'Btn_Ranking
        '
        Me.Btn_Ranking.Location = New System.Drawing.Point(19, 21)
        Me.Btn_Ranking.Name = "Btn_Ranking"
        Me.Btn_Ranking.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Ranking.TabIndex = 8
        Me.Btn_Ranking.Text = "Ranking"
        Me.Btn_Ranking.UseVisualStyleBackColor = True
        '
        'Btn_Reset
        '
        Me.Btn_Reset.Location = New System.Drawing.Point(153, 21)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Reset.TabIndex = 9
        Me.Btn_Reset.Text = "Reset"
        Me.Btn_Reset.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(407, 21)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Delete.TabIndex = 10
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(529, 21)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Clear.TabIndex = 11
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(656, 21)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Exit.TabIndex = 12
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'GroupBox_Data
        '
        Me.GroupBox_Data.Controls.Add(Me.Btn_Add2)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_LR)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_Team2)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_BDEF)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_BDR)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_BW)
        Me.GroupBox_Data.Controls.Add(Me.Txt_LR)
        Me.GroupBox_Data.Controls.Add(Me.Txt_Team_Number2)
        Me.GroupBox_Data.Controls.Add(Me.Txt_BDEF)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_BDRR)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_Load)
        Me.GroupBox_Data.Controls.Add(Me.Txt_BDR)
        Me.GroupBox_Data.Controls.Add(Me.Txt_BW)
        Me.GroupBox_Data.Controls.Add(Me.Txt_BDRR)
        Me.GroupBox_Data.Controls.Add(Me.Txt_Load)
        Me.GroupBox_Data.Location = New System.Drawing.Point(314, 0)
        Me.GroupBox_Data.Name = "GroupBox_Data"
        Me.GroupBox_Data.Size = New System.Drawing.Size(259, 430)
        Me.GroupBox_Data.TabIndex = 19
        Me.GroupBox_Data.TabStop = False
        Me.GroupBox_Data.Text = "Data"
        '
        'Btn_Add2
        '
        Me.Btn_Add2.Location = New System.Drawing.Point(162, 395)
        Me.Btn_Add2.Name = "Btn_Add2"
        Me.Btn_Add2.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Add2.TabIndex = 6
        Me.Btn_Add2.Text = "Add"
        Me.Btn_Add2.UseVisualStyleBackColor = True
        '
        'Lbl_LR
        '
        Me.Lbl_LR.AutoSize = True
        Me.Lbl_LR.Location = New System.Drawing.Point(23, 248)
        Me.Lbl_LR.Name = "Lbl_LR"
        Me.Lbl_LR.Size = New System.Drawing.Size(26, 17)
        Me.Lbl_LR.TabIndex = 3
        Me.Lbl_LR.Text = "LR"
        Me.Lbl_LR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_Team2
        '
        Me.Lbl_Team2.AutoSize = True
        Me.Lbl_Team2.Location = New System.Drawing.Point(23, 71)
        Me.Lbl_Team2.Name = "Lbl_Team2"
        Me.Lbl_Team2.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_Team2.TabIndex = 3
        Me.Lbl_Team2.Text = "Team"
        '
        'Lbl_BDEF
        '
        Me.Lbl_BDEF.AutoSize = True
        Me.Lbl_BDEF.Location = New System.Drawing.Point(23, 115)
        Me.Lbl_BDEF.Name = "Lbl_BDEF"
        Me.Lbl_BDEF.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_BDEF.TabIndex = 3
        Me.Lbl_BDEF.Text = "BDEF"
        '
        'Lbl_BDR
        '
        Me.Lbl_BDR.AutoSize = True
        Me.Lbl_BDR.Location = New System.Drawing.Point(23, 286)
        Me.Lbl_BDR.Name = "Lbl_BDR"
        Me.Lbl_BDR.Size = New System.Drawing.Size(37, 17)
        Me.Lbl_BDR.TabIndex = 3
        Me.Lbl_BDR.Text = "BDR"
        '
        'Lbl_BW
        '
        Me.Lbl_BW.AutoSize = True
        Me.Lbl_BW.Location = New System.Drawing.Point(23, 162)
        Me.Lbl_BW.Name = "Lbl_BW"
        Me.Lbl_BW.Size = New System.Drawing.Size(30, 17)
        Me.Lbl_BW.TabIndex = 3
        Me.Lbl_BW.Text = "BW"
        '
        'Txt_LR
        '
        Me.Txt_LR.Location = New System.Drawing.Point(137, 245)
        Me.Txt_LR.Name = "Txt_LR"
        Me.Txt_LR.Size = New System.Drawing.Size(100, 22)
        Me.Txt_LR.TabIndex = 5
        '
        'Txt_Team_Number2
        '
        Me.Txt_Team_Number2.Location = New System.Drawing.Point(137, 68)
        Me.Txt_Team_Number2.Name = "Txt_Team_Number2"
        Me.Txt_Team_Number2.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Team_Number2.TabIndex = 5
        '
        'Txt_BDEF
        '
        Me.Txt_BDEF.Location = New System.Drawing.Point(137, 112)
        Me.Txt_BDEF.Name = "Txt_BDEF"
        Me.Txt_BDEF.Size = New System.Drawing.Size(100, 22)
        Me.Txt_BDEF.TabIndex = 5
        '
        'Lbl_BDRR
        '
        Me.Lbl_BDRR.AutoSize = True
        Me.Lbl_BDRR.Location = New System.Drawing.Point(23, 330)
        Me.Lbl_BDRR.Name = "Lbl_BDRR"
        Me.Lbl_BDRR.Size = New System.Drawing.Size(47, 17)
        Me.Lbl_BDRR.TabIndex = 3
        Me.Lbl_BDRR.Text = "BDRR"
        '
        'Lbl_Load
        '
        Me.Lbl_Load.AutoSize = True
        Me.Lbl_Load.Location = New System.Drawing.Point(23, 206)
        Me.Lbl_Load.Name = "Lbl_Load"
        Me.Lbl_Load.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_Load.TabIndex = 3
        Me.Lbl_Load.Text = "Load"
        '
        'Txt_BDR
        '
        Me.Txt_BDR.Location = New System.Drawing.Point(137, 281)
        Me.Txt_BDR.Name = "Txt_BDR"
        Me.Txt_BDR.Size = New System.Drawing.Size(100, 22)
        Me.Txt_BDR.TabIndex = 5
        '
        'Txt_BW
        '
        Me.Txt_BW.Location = New System.Drawing.Point(137, 157)
        Me.Txt_BW.Name = "Txt_BW"
        Me.Txt_BW.Size = New System.Drawing.Size(100, 22)
        Me.Txt_BW.TabIndex = 5
        '
        'Txt_BDRR
        '
        Me.Txt_BDRR.Location = New System.Drawing.Point(137, 325)
        Me.Txt_BDRR.Name = "Txt_BDRR"
        Me.Txt_BDRR.Size = New System.Drawing.Size(100, 22)
        Me.Txt_BDRR.TabIndex = 5
        '
        'Txt_Load
        '
        Me.Txt_Load.Location = New System.Drawing.Point(137, 201)
        Me.Txt_Load.Name = "Txt_Load"
        Me.Txt_Load.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Load.TabIndex = 5
        '
        'GroupBox_Buttons
        '
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Clear)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Ranking)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Exit)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Update)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Reset)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Delete)
        Me.GroupBox_Buttons.Location = New System.Drawing.Point(1025, 935)
        Me.GroupBox_Buttons.Name = "GroupBox_Buttons"
        Me.GroupBox_Buttons.Size = New System.Drawing.Size(772, 64)
        Me.GroupBox_Buttons.TabIndex = 20
        Me.GroupBox_Buttons.TabStop = False
        Me.GroupBox_Buttons.Text = "Buttons"
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(279, 21)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Update.TabIndex = 9
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'GroupBox_Rank
        '
        Me.GroupBox_Rank.Controls.Add(Me.Txt_Total_Final)
        Me.GroupBox_Rank.Controls.Add(Me.Lbl_Total)
        Me.GroupBox_Rank.Location = New System.Drawing.Point(27, 245)
        Me.GroupBox_Rank.Name = "GroupBox_Rank"
        Me.GroupBox_Rank.Size = New System.Drawing.Size(259, 185)
        Me.GroupBox_Rank.TabIndex = 21
        Me.GroupBox_Rank.TabStop = False
        Me.GroupBox_Rank.Text = "Total Score"
        '
        'Txt_Total_Final
        '
        Me.Txt_Total_Final.Location = New System.Drawing.Point(124, 36)
        Me.Txt_Total_Final.Name = "Txt_Total_Final"
        Me.Txt_Total_Final.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Total_Final.TabIndex = 5
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Location = New System.Drawing.Point(10, 39)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(81, 17)
        Me.Lbl_Total.TabIndex = 3
        Me.Lbl_Total.Text = "Total Score"
        '
        'School_Team
        '
        Me.School_Team.HeaderText = "School (Team)"
        Me.School_Team.MinimumWidth = 6
        Me.School_Team.Name = "School_Team"
        Me.School_Team.Width = 300
        '
        'BDEF_1
        '
        Me.BDEF_1.HeaderText = "BDEF"
        Me.BDEF_1.MinimumWidth = 6
        Me.BDEF_1.Name = "BDEF_1"
        Me.BDEF_1.Width = 125
        '
        'BW_1
        '
        Me.BW_1.HeaderText = "BW"
        Me.BW_1.MinimumWidth = 6
        Me.BW_1.Name = "BW_1"
        Me.BW_1.Width = 125
        '
        'Load_1
        '
        Me.Load_1.HeaderText = "LOAD"
        Me.Load_1.MinimumWidth = 6
        Me.Load_1.Name = "Load_1"
        Me.Load_1.Width = 125
        '
        'LR_1
        '
        Me.LR_1.HeaderText = "LR"
        Me.LR_1.MinimumWidth = 6
        Me.LR_1.Name = "LR_1"
        Me.LR_1.Width = 125
        '
        'BDR_1
        '
        Me.BDR_1.HeaderText = "BDR"
        Me.BDR_1.MinimumWidth = 6
        Me.BDR_1.Name = "BDR_1"
        Me.BDR_1.Width = 125
        '
        'BDRR_1
        '
        Me.BDRR_1.HeaderText = "BDRR"
        Me.BDRR_1.MinimumWidth = 6
        Me.BDRR_1.Name = "BDRR_1"
        Me.BDRR_1.Width = 125
        '
        'Total_1
        '
        Me.Total_1.HeaderText = "Total Score"
        Me.Total_1.MinimumWidth = 6
        Me.Total_1.Name = "Total_1"
        Me.Total_1.Width = 125
        '
        'DGB_Team_Rank
        '
        Me.DGB_Team_Rank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGB_Team_Rank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.School_Name_2, Me.Score_2, Me.Rank_2})
        Me.DGB_Team_Rank.Location = New System.Drawing.Point(19, 21)
        Me.DGB_Team_Rank.Name = "DGB_Team_Rank"
        Me.DGB_Team_Rank.RowHeadersWidth = 51
        Me.DGB_Team_Rank.RowTemplate.Height = 24
        Me.DGB_Team_Rank.Size = New System.Drawing.Size(566, 373)
        Me.DGB_Team_Rank.TabIndex = 23
        '
        'GroupBox_Final_Rank
        '
        Me.GroupBox_Final_Rank.Controls.Add(Me.DGB_Team_Rank)
        Me.GroupBox_Final_Rank.Location = New System.Drawing.Point(1212, 15)
        Me.GroupBox_Final_Rank.Name = "GroupBox_Final_Rank"
        Me.GroupBox_Final_Rank.Size = New System.Drawing.Size(606, 415)
        Me.GroupBox_Final_Rank.TabIndex = 24
        Me.GroupBox_Final_Rank.TabStop = False
        Me.GroupBox_Final_Rank.Text = "Final Rank"
        '
        'School_Name_2
        '
        Me.School_Name_2.HeaderText = "School (Team)"
        Me.School_Name_2.MinimumWidth = 6
        Me.School_Name_2.Name = "School_Name_2"
        Me.School_Name_2.Width = 125
        '
        'Score_2
        '
        Me.Score_2.HeaderText = "Total Score"
        Me.Score_2.MinimumWidth = 6
        Me.Score_2.Name = "Score_2"
        Me.Score_2.Width = 125
        '
        'Rank_2
        '
        Me.Rank_2.HeaderText = "Rank"
        Me.Rank_2.MinimumWidth = 6
        Me.Rank_2.Name = "Rank_2"
        Me.Rank_2.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1850, 1055)
        Me.Controls.Add(Me.GroupBox_Final_Rank)
        Me.Controls.Add(Me.GroupBox_Rank)
        Me.Controls.Add(Me.GroupBox_Buttons)
        Me.Controls.Add(Me.GroupBox_Data)
        Me.Controls.Add(Me.GroupBox_Team_Results)
        Me.Controls.Add(Me.GroupBox_Student_Info)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV_Team_Results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Student_Info.ResumeLayout(False)
        Me.GroupBox_Student_Info.PerformLayout()
        Me.GroupBox_Team_Results.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Data.ResumeLayout(False)
        Me.GroupBox_Data.PerformLayout()
        Me.GroupBox_Buttons.ResumeLayout(False)
        Me.GroupBox_Rank.ResumeLayout(False)
        Me.GroupBox_Rank.PerformLayout()
        CType(Me.DGB_Team_Rank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Final_Rank.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DGV_Team_Results As DataGridView
    Friend WithEvents Lbl_Student_Name As Label
    Friend WithEvents Txt_Student_Name As TextBox
    Friend WithEvents Lbl_School_Name As Label
    Friend WithEvents Txt_School_Team As TextBox
    Friend WithEvents Lbl_Team_Number As Label
    Friend WithEvents Txt_Team_Number As TextBox
    Friend WithEvents GroupBox_Student_Info As GroupBox
    Friend WithEvents GroupBox_Team_Results As GroupBox
    Friend WithEvents Btn_Ranking As Button
    Friend WithEvents Btn_Reset As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents GroupBox_Data As GroupBox
    Friend WithEvents Btn_Add2 As Button
    Friend WithEvents Lbl_LR As Label
    Friend WithEvents Lbl_BDEF As Label
    Friend WithEvents Lbl_BDR As Label
    Friend WithEvents Lbl_BW As Label
    Friend WithEvents Txt_LR As TextBox
    Friend WithEvents Txt_BDEF As TextBox
    Friend WithEvents Lbl_BDRR As Label
    Friend WithEvents Lbl_Load As Label
    Friend WithEvents Txt_BDR As TextBox
    Friend WithEvents Txt_BW As TextBox
    Friend WithEvents Txt_BDRR As TextBox
    Friend WithEvents Txt_Load As TextBox
    Friend WithEvents Lbl_Team2 As Label
    Friend WithEvents Txt_Team_Number2 As TextBox
    Friend WithEvents GroupBox_Buttons As GroupBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents GroupBox_Rank As GroupBox
    Friend WithEvents Txt_Total_Final As TextBox
    Friend WithEvents Lbl_Total As Label
    Friend WithEvents School_Team As DataGridViewTextBoxColumn
    Friend WithEvents BDEF_1 As DataGridViewTextBoxColumn
    Friend WithEvents BW_1 As DataGridViewTextBoxColumn
    Friend WithEvents Load_1 As DataGridViewTextBoxColumn
    Friend WithEvents LR_1 As DataGridViewTextBoxColumn
    Friend WithEvents BDR_1 As DataGridViewTextBoxColumn
    Friend WithEvents BDRR_1 As DataGridViewTextBoxColumn
    Friend WithEvents Total_1 As DataGridViewTextBoxColumn
    Friend WithEvents DGB_Team_Rank As DataGridView
    Friend WithEvents GroupBox_Final_Rank As GroupBox
    Friend WithEvents School_Name_2 As DataGridViewTextBoxColumn
    Friend WithEvents Score_2 As DataGridViewTextBoxColumn
    Friend WithEvents Rank_2 As DataGridViewTextBoxColumn
End Class
