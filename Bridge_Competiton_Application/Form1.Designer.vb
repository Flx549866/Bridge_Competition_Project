<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DGV_Team_Results = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.School_Team = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BW_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LR_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDEF_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Broken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox_Team_Results = New System.Windows.Forms.GroupBox()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.GroupBox_Data = New System.Windows.Forms.GroupBox()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Txt_Remove = New System.Windows.Forms.TextBox()
        Me.Btn_UpdateLp = New System.Windows.Forms.Button()
        Me.Lbl_LP = New System.Windows.Forms.Label()
        Me.Txt_LP = New System.Windows.Forms.TextBox()
        Me.Btn_Update2 = New System.Windows.Forms.Button()
        Me.GroupBox_Buttons = New System.Windows.Forms.GroupBox()
        Me.DGV_Team_Rank = New System.Windows.Forms.DataGridView()
        Me.School_Name_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Score_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox_Final_Rank = New System.Windows.Forms.GroupBox()
        Me.Lst_BW = New System.Windows.Forms.ListBox()
        Me.Btn_Input = New System.Windows.Forms.Button()
        Me.Lst_LP = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BW = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_BDEF_Override = New System.Windows.Forms.Button()
        Me.Btn_LP_Override = New System.Windows.Forms.Button()
        Me.Btn_BW_Override = New System.Windows.Forms.Button()
        Me.Txt_BDEF_Override = New System.Windows.Forms.TextBox()
        Me.Txt_LP_Override = New System.Windows.Forms.TextBox()
        Me.Txt_Bw_Override = New System.Windows.Forms.TextBox()
        Me.Txt_Team_Number = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_Team_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Team_Results.SuspendLayout()
        Me.GroupBox_Data.SuspendLayout()
        Me.GroupBox_Buttons.SuspendLayout()
        CType(Me.DGV_Team_Rank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Final_Rank.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1540, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DGV_Team_Results
        '
        Me.DGV_Team_Results.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Team_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Team_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.School_Team, Me.BW_1, Me.LR_1, Me.BDEF_1, Me.Total_1, Me.Broken})
        Me.DGV_Team_Results.Location = New System.Drawing.Point(19, 23)
        Me.DGV_Team_Results.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGV_Team_Results.Name = "DGV_Team_Results"
        Me.DGV_Team_Results.RowHeadersWidth = 51
        Me.DGV_Team_Results.RowTemplate.Height = 24
        Me.DGV_Team_Results.Size = New System.Drawing.Size(978, 189)
        Me.DGV_Team_Results.TabIndex = 2
        '
        'Number
        '
        Me.Number.HeaderText = "#"
        Me.Number.MinimumWidth = 6
        Me.Number.Name = "Number"
        Me.Number.Width = 40
        '
        'School_Team
        '
        Me.School_Team.HeaderText = "School (Team)"
        Me.School_Team.MinimumWidth = 6
        Me.School_Team.Name = "School_Team"
        Me.School_Team.Width = 300
        '
        'BW_1
        '
        Me.BW_1.HeaderText = "BWR"
        Me.BW_1.MinimumWidth = 6
        Me.BW_1.Name = "BW_1"
        Me.BW_1.Width = 125
        '
        'LR_1
        '
        Me.LR_1.HeaderText = "LPR"
        Me.LR_1.MinimumWidth = 6
        Me.LR_1.Name = "LR_1"
        Me.LR_1.Width = 125
        '
        'BDEF_1
        '
        Me.BDEF_1.HeaderText = "BDEF"
        Me.BDEF_1.MinimumWidth = 6
        Me.BDEF_1.Name = "BDEF_1"
        Me.BDEF_1.Width = 110
        '
        'Total_1
        '
        Me.Total_1.HeaderText = "Total Score"
        Me.Total_1.MinimumWidth = 6
        Me.Total_1.Name = "Total_1"
        Me.Total_1.Width = 125
        '
        'Broken
        '
        Me.Broken.HeaderText = "Broken"
        Me.Broken.MinimumWidth = 6
        Me.Broken.Name = "Broken"
        Me.Broken.Width = 125
        '
        'GroupBox_Team_Results
        '
        Me.GroupBox_Team_Results.Controls.Add(Me.DGV_Team_Results)
        Me.GroupBox_Team_Results.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Team_Results.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Team_Results.Location = New System.Drawing.Point(401, 564)
        Me.GroupBox_Team_Results.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Team_Results.Name = "GroupBox_Team_Results"
        Me.GroupBox_Team_Results.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Team_Results.Size = New System.Drawing.Size(1017, 216)
        Me.GroupBox_Team_Results.TabIndex = 7
        Me.GroupBox_Team_Results.TabStop = False
        Me.GroupBox_Team_Results.Text = "Results"
        '
        'Btn_Exit
        '
        Me.Btn_Exit.ForeColor = System.Drawing.Color.Black
        Me.Btn_Exit.Location = New System.Drawing.Point(7, 52)
        Me.Btn_Exit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(75, 24)
        Me.Btn_Exit.TabIndex = 12
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'GroupBox_Data
        '
        Me.GroupBox_Data.BackColor = System.Drawing.Color.White
        Me.GroupBox_Data.Controls.Add(Me.Btn_Remove)
        Me.GroupBox_Data.Controls.Add(Me.Txt_Remove)
        Me.GroupBox_Data.Controls.Add(Me.Btn_UpdateLp)
        Me.GroupBox_Data.Controls.Add(Me.Lbl_LP)
        Me.GroupBox_Data.Controls.Add(Me.Txt_LP)
        Me.GroupBox_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Data.Location = New System.Drawing.Point(4, 27)
        Me.GroupBox_Data.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Data.Name = "GroupBox_Data"
        Me.GroupBox_Data.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Data.Size = New System.Drawing.Size(295, 83)
        Me.GroupBox_Data.TabIndex = 19
        Me.GroupBox_Data.TabStop = False
        Me.GroupBox_Data.Text = "Data"
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Location = New System.Drawing.Point(206, 52)
        Me.Btn_Remove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(75, 20)
        Me.Btn_Remove.TabIndex = 17
        Me.Btn_Remove.Text = "Broken"
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Txt_Remove
        '
        Me.Txt_Remove.Location = New System.Drawing.Point(104, 52)
        Me.Txt_Remove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Remove.Name = "Txt_Remove"
        Me.Txt_Remove.Size = New System.Drawing.Size(76, 19)
        Me.Txt_Remove.TabIndex = 16
        '
        'Btn_UpdateLp
        '
        Me.Btn_UpdateLp.Location = New System.Drawing.Point(206, 21)
        Me.Btn_UpdateLp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_UpdateLp.Name = "Btn_UpdateLp"
        Me.Btn_UpdateLp.Size = New System.Drawing.Size(75, 20)
        Me.Btn_UpdateLp.TabIndex = 12
        Me.Btn_UpdateLp.Text = "Update"
        Me.Btn_UpdateLp.UseVisualStyleBackColor = True
        '
        'Lbl_LP
        '
        Me.Lbl_LP.AutoSize = True
        Me.Lbl_LP.Location = New System.Drawing.Point(20, 21)
        Me.Lbl_LP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_LP.Name = "Lbl_LP"
        Me.Lbl_LP.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_LP.TabIndex = 3
        Me.Lbl_LP.Text = "LP (LOAD)"
        Me.Lbl_LP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_LP
        '
        Me.Txt_LP.Location = New System.Drawing.Point(104, 21)
        Me.Txt_LP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_LP.Name = "Txt_LP"
        Me.Txt_LP.Size = New System.Drawing.Size(76, 19)
        Me.Txt_LP.TabIndex = 5
        '
        'Btn_Update2
        '
        Me.Btn_Update2.BackgroundImage = Global.Bridge_Competiton_Application.My.Resources.Resources.hero_bridge
        Me.Btn_Update2.ForeColor = System.Drawing.Color.Black
        Me.Btn_Update2.Location = New System.Drawing.Point(7, 16)
        Me.Btn_Update2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Update2.Name = "Btn_Update2"
        Me.Btn_Update2.Size = New System.Drawing.Size(75, 24)
        Me.Btn_Update2.TabIndex = 6
        Me.Btn_Update2.Text = "Update"
        Me.Btn_Update2.UseVisualStyleBackColor = True
        '
        'GroupBox_Buttons
        '
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Update2)
        Me.GroupBox_Buttons.Controls.Add(Me.Btn_Exit)
        Me.GroupBox_Buttons.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Buttons.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Buttons.Location = New System.Drawing.Point(1422, 684)
        Me.GroupBox_Buttons.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Buttons.Name = "GroupBox_Buttons"
        Me.GroupBox_Buttons.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Buttons.Size = New System.Drawing.Size(92, 96)
        Me.GroupBox_Buttons.TabIndex = 20
        Me.GroupBox_Buttons.TabStop = False
        '
        'DGV_Team_Rank
        '
        Me.DGV_Team_Rank.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Team_Rank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Team_Rank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.School_Name_2, Me.Score_2, Me.Column1})
        Me.DGV_Team_Rank.Location = New System.Drawing.Point(14, 21)
        Me.DGV_Team_Rank.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGV_Team_Rank.Name = "DGV_Team_Rank"
        Me.DGV_Team_Rank.RowHeadersWidth = 51
        Me.DGV_Team_Rank.RowTemplate.Height = 24
        Me.DGV_Team_Rank.Size = New System.Drawing.Size(424, 329)
        Me.DGV_Team_Rank.TabIndex = 23
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
        'Column1
        '
        Me.Column1.HeaderText = "Rank"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'GroupBox_Final_Rank
        '
        Me.GroupBox_Final_Rank.Controls.Add(Me.DGV_Team_Rank)
        Me.GroupBox_Final_Rank.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Final_Rank.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Final_Rank.Location = New System.Drawing.Point(702, 27)
        Me.GroupBox_Final_Rank.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Final_Rank.Name = "GroupBox_Final_Rank"
        Me.GroupBox_Final_Rank.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox_Final_Rank.Size = New System.Drawing.Size(454, 366)
        Me.GroupBox_Final_Rank.TabIndex = 24
        Me.GroupBox_Final_Rank.TabStop = False
        '
        'Lst_BW
        '
        Me.Lst_BW.FormattingEnabled = True
        Me.Lst_BW.Location = New System.Drawing.Point(4, 273)
        Me.Lst_BW.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Lst_BW.Name = "Lst_BW"
        Me.Lst_BW.Size = New System.Drawing.Size(104, 160)
        Me.Lst_BW.TabIndex = 25
        '
        'Btn_Input
        '
        Me.Btn_Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Input.Location = New System.Drawing.Point(220, 273)
        Me.Btn_Input.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Input.Name = "Btn_Input"
        Me.Btn_Input.Size = New System.Drawing.Size(74, 20)
        Me.Btn_Input.TabIndex = 26
        Me.Btn_Input.Text = "Display"
        Me.Btn_Input.UseVisualStyleBackColor = True
        '
        'Lst_LP
        '
        Me.Lst_LP.FormattingEnabled = True
        Me.Lst_LP.Location = New System.Drawing.Point(112, 273)
        Me.Lst_LP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Lst_LP.Name = "Lst_LP"
        Me.Lst_LP.Size = New System.Drawing.Size(104, 160)
        Me.Lst_LP.TabIndex = 32
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.Bridge_Competiton_Application.My.Resources.Resources.New_UCC_Logo
        Me.PictureBox3.Location = New System.Drawing.Point(139, 564)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 74)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'BW
        '
        Me.BW.AutoSize = True
        Me.BW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BW.ForeColor = System.Drawing.Color.Black
        Me.BW.Location = New System.Drawing.Point(11, 258)
        Me.BW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BW.Name = "BW"
        Me.BW.Size = New System.Drawing.Size(27, 13)
        Me.BW.TabIndex = 38
        Me.BW.Text = "BW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(109, 258)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "LP"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.TextBox1.Location = New System.Drawing.Point(44, 633)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(287, 181)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Text = "Union College of Union County" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of NJ Annual Bridge Competition "
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_BDEF_Override)
        Me.GroupBox1.Controls.Add(Me.Btn_LP_Override)
        Me.GroupBox1.Controls.Add(Me.Btn_BW_Override)
        Me.GroupBox1.Controls.Add(Me.Txt_BDEF_Override)
        Me.GroupBox1.Controls.Add(Me.Txt_LP_Override)
        Me.GroupBox1.Controls.Add(Me.Txt_Bw_Override)
        Me.GroupBox1.Controls.Add(Me.Txt_Team_Number)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(295, 142)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Override"
        '
        'Btn_BDEF_Override
        '
        Me.Btn_BDEF_Override.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BDEF_Override.Location = New System.Drawing.Point(206, 100)
        Me.Btn_BDEF_Override.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_BDEF_Override.Name = "Btn_BDEF_Override"
        Me.Btn_BDEF_Override.Size = New System.Drawing.Size(75, 20)
        Me.Btn_BDEF_Override.TabIndex = 24
        Me.Btn_BDEF_Override.Text = "Update"
        Me.Btn_BDEF_Override.UseVisualStyleBackColor = True
        '
        'Btn_LP_Override
        '
        Me.Btn_LP_Override.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_LP_Override.Location = New System.Drawing.Point(206, 76)
        Me.Btn_LP_Override.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_LP_Override.Name = "Btn_LP_Override"
        Me.Btn_LP_Override.Size = New System.Drawing.Size(75, 20)
        Me.Btn_LP_Override.TabIndex = 23
        Me.Btn_LP_Override.Text = "Update"
        Me.Btn_LP_Override.UseVisualStyleBackColor = True
        '
        'Btn_BW_Override
        '
        Me.Btn_BW_Override.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BW_Override.Location = New System.Drawing.Point(206, 53)
        Me.Btn_BW_Override.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_BW_Override.Name = "Btn_BW_Override"
        Me.Btn_BW_Override.Size = New System.Drawing.Size(75, 20)
        Me.Btn_BW_Override.TabIndex = 22
        Me.Btn_BW_Override.Text = "Update"
        Me.Btn_BW_Override.UseVisualStyleBackColor = True
        '
        'Txt_BDEF_Override
        '
        Me.Txt_BDEF_Override.Location = New System.Drawing.Point(104, 99)
        Me.Txt_BDEF_Override.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_BDEF_Override.Name = "Txt_BDEF_Override"
        Me.Txt_BDEF_Override.Size = New System.Drawing.Size(76, 20)
        Me.Txt_BDEF_Override.TabIndex = 21
        '
        'Txt_LP_Override
        '
        Me.Txt_LP_Override.Location = New System.Drawing.Point(104, 76)
        Me.Txt_LP_Override.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_LP_Override.Name = "Txt_LP_Override"
        Me.Txt_LP_Override.Size = New System.Drawing.Size(76, 20)
        Me.Txt_LP_Override.TabIndex = 20
        '
        'Txt_Bw_Override
        '
        Me.Txt_Bw_Override.Location = New System.Drawing.Point(104, 53)
        Me.Txt_Bw_Override.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Bw_Override.Name = "Txt_Bw_Override"
        Me.Txt_Bw_Override.Size = New System.Drawing.Size(76, 20)
        Me.Txt_Bw_Override.TabIndex = 19
        '
        'Txt_Team_Number
        '
        Me.Txt_Team_Number.Location = New System.Drawing.Point(104, 29)
        Me.Txt_Team_Number.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Team_Number.Name = "Txt_Team_Number"
        Me.Txt_Team_Number.Size = New System.Drawing.Size(76, 20)
        Me.Txt_Team_Number.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "BDEF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "LP(LOAD)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "BW"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Team Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Bridge_Competiton_Application.My.Resources.Resources.hero_bridge
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1540, 845)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BW)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Lst_LP)
        Me.Controls.Add(Me.Btn_Input)
        Me.Controls.Add(Me.Lst_BW)
        Me.Controls.Add(Me.GroupBox_Final_Rank)
        Me.Controls.Add(Me.GroupBox_Buttons)
        Me.Controls.Add(Me.GroupBox_Data)
        Me.Controls.Add(Me.GroupBox_Team_Results)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.DGV_Team_Results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Team_Results.ResumeLayout(False)
        Me.GroupBox_Data.ResumeLayout(False)
        Me.GroupBox_Data.PerformLayout()
        Me.GroupBox_Buttons.ResumeLayout(False)
        CType(Me.DGV_Team_Rank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Final_Rank.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DGV_Team_Results As DataGridView
    Friend WithEvents GroupBox_Team_Results As GroupBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents GroupBox_Data As GroupBox
    Friend WithEvents Lbl_LP As Label
    Friend WithEvents Txt_LP As TextBox
    Friend WithEvents GroupBox_Buttons As GroupBox
    Friend WithEvents DGV_Team_Rank As DataGridView
    Friend WithEvents GroupBox_Final_Rank As GroupBox
    Friend WithEvents Btn_Update2 As Button
    Friend WithEvents Lst_BW As ListBox
    Friend WithEvents Btn_Input As Button
    Friend WithEvents Lst_LP As ListBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BW As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_UpdateLp As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Txt_Remove As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_BDEF_Override As Button
    Friend WithEvents Btn_LP_Override As Button
    Friend WithEvents Btn_BW_Override As Button
    Friend WithEvents Txt_BDEF_Override As TextBox
    Friend WithEvents Txt_LP_Override As TextBox
    Friend WithEvents Txt_Bw_Override As TextBox
    Friend WithEvents Txt_Team_Number As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents School_Team As DataGridViewTextBoxColumn
    Friend WithEvents BW_1 As DataGridViewTextBoxColumn
    Friend WithEvents LR_1 As DataGridViewTextBoxColumn
    Friend WithEvents BDEF_1 As DataGridViewTextBoxColumn
    Friend WithEvents Total_1 As DataGridViewTextBoxColumn
    Friend WithEvents Broken As DataGridViewTextBoxColumn
    Friend WithEvents School_Name_2 As DataGridViewTextBoxColumn
    Friend WithEvents Score_2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
