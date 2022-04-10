<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskManagement
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
        Me.components = New System.ComponentModel.Container()
        Me.HomeTaskPanel = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddTaskB = New System.Windows.Forms.Button()
        Me.ViewTaskB = New System.Windows.Forms.Button()
        Me.DeleteTaskB = New System.Windows.Forms.Button()
        Me.SoonB = New System.Windows.Forms.Button()
        Me.AddTaskL = New System.Windows.Forms.Label()
        Me.ViewTaskL = New System.Windows.Forms.Label()
        Me.DeleteTaskL = New System.Windows.Forms.Label()
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.BasePanel = New System.Windows.Forms.Panel()
        Me.ViewTaskPanel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TaskViewEndDate = New System.Windows.Forms.DateTimePicker()
        Me.TaskViewBeginDate = New System.Windows.Forms.DateTimePicker()
        Me.Status = New System.Windows.Forms.GroupBox()
        Me.CompletedChB = New System.Windows.Forms.CheckBox()
        Me.PendingChB = New System.Windows.Forms.CheckBox()
        Me.ViewViewTaskB = New System.Windows.Forms.Button()
        Me.BackFromViewTaskB = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ViewMainTaskDGV = New System.Windows.Forms.DataGridView()
        Me.MainTaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalAssistantDBDataSet = New Personal_Assistant2.PersonalAssistantDBDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DummyL = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MTPriorityL = New System.Windows.Forms.Label()
        Me.ProgressVal = New System.Windows.Forms.Label()
        Me.MTDesc = New System.Windows.Forms.Label()
        Me.ViewSubTaskDGV = New System.Windows.Forms.DataGridView()
        Me.STNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ParentTaskNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTaskNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTaskDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SubTaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddTaskPanel = New System.Windows.Forms.Panel()
        Me.InnerPanel = New System.Windows.Forms.Panel()
        Me.AddTaskTitle = New System.Windows.Forms.Label()
        Me.BackFromAddTaskB = New System.Windows.Forms.Button()
        Me.Priority = New System.Windows.Forms.ComboBox()
        Me.AddAddTaskB = New System.Windows.Forms.Button()
        Me.TaskDesc = New System.Windows.Forms.TextBox()
        Me.TaskName = New System.Windows.Forms.TextBox()
        Me.PriorityL = New System.Windows.Forms.Label()
        Me.TargetDate = New System.Windows.Forms.DateTimePicker()
        Me.TargetDateL = New System.Windows.Forms.Label()
        Me.TaslkNameL = New System.Windows.Forms.Label()
        Me.TaskDescriptionL = New System.Windows.Forms.Label()
        Me.DeleteTaskPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackFromDeleteTaskB = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TaskManagementL = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.MainTaskTableAdapter = New Personal_Assistant2.PersonalAssistantDBDataSetTableAdapters.MainTaskTableAdapter()
        Me.SubTaskTableAdapter = New Personal_Assistant2.PersonalAssistantDBDataSetTableAdapters.SubTaskTableAdapter()
        Me.TaskNumb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskNam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MTDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeTaskPanel.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.BasePanel.SuspendLayout()
        Me.ViewTaskPanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ViewMainTaskDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalAssistantDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ViewSubTaskDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubTaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddTaskPanel.SuspendLayout()
        Me.InnerPanel.SuspendLayout()
        Me.DeleteTaskPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HomeTaskPanel
        '
        Me.HomeTaskPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HomeTaskPanel.Controls.Add(Me.Splitter1)
        Me.HomeTaskPanel.Controls.Add(Me.ButtonPanel)
        Me.HomeTaskPanel.Controls.Add(Me.AnimationPanel)
        Me.HomeTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeTaskPanel.Location = New System.Drawing.Point(0, 0)
        Me.HomeTaskPanel.Name = "HomeTaskPanel"
        Me.HomeTaskPanel.Size = New System.Drawing.Size(959, 585)
        Me.HomeTaskPanel.TabIndex = 5
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.BlueViolet
        Me.Splitter1.Location = New System.Drawing.Point(600, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 585)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonPanel.Location = New System.Drawing.Point(0, 0)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(600, 585)
        Me.ButtonPanel.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AddTaskB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTaskB, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteTaskB, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SoonB, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AddTaskL, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTaskL, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteTaskL, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 585)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'AddTaskB
        '
        Me.AddTaskB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddTaskB.BackgroundImage = Global.Personal_Assistant2.My.Resources.Resources.AddTaskB
        Me.AddTaskB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.AddTaskB.FlatAppearance.BorderSize = 2
        Me.AddTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.AddTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTaskB.Location = New System.Drawing.Point(93, 90)
        Me.AddTaskB.Name = "AddTaskB"
        Me.AddTaskB.Size = New System.Drawing.Size(162, 157)
        Me.AddTaskB.TabIndex = 2
        Me.AddTaskB.UseVisualStyleBackColor = True
        '
        'ViewTaskB
        '
        Me.ViewTaskB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewTaskB.BackgroundImage = Global.Personal_Assistant2.My.Resources.Resources.ViewTaskB
        Me.ViewTaskB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.ViewTaskB.FlatAppearance.BorderSize = 2
        Me.ViewTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.ViewTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTaskB.Location = New System.Drawing.Point(345, 90)
        Me.ViewTaskB.Name = "ViewTaskB"
        Me.ViewTaskB.Size = New System.Drawing.Size(162, 157)
        Me.ViewTaskB.TabIndex = 2
        Me.ViewTaskB.UseVisualStyleBackColor = True
        '
        'DeleteTaskB
        '
        Me.DeleteTaskB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteTaskB.BackgroundImage = Global.Personal_Assistant2.My.Resources.Resources.DeleteTaskB
        Me.DeleteTaskB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.DeleteTaskB.FlatAppearance.BorderSize = 2
        Me.DeleteTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.DeleteTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteTaskB.Location = New System.Drawing.Point(93, 334)
        Me.DeleteTaskB.Name = "DeleteTaskB"
        Me.DeleteTaskB.Size = New System.Drawing.Size(162, 157)
        Me.DeleteTaskB.TabIndex = 2
        Me.DeleteTaskB.UseVisualStyleBackColor = True
        '
        'SoonB
        '
        Me.SoonB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoonB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.SoonB.FlatAppearance.BorderSize = 2
        Me.SoonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.SoonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoonB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.SoonB.ForeColor = System.Drawing.Color.White
        Me.SoonB.Location = New System.Drawing.Point(345, 334)
        Me.SoonB.Name = "SoonB"
        Me.SoonB.Size = New System.Drawing.Size(162, 157)
        Me.SoonB.TabIndex = 2
        Me.SoonB.Text = "COMING SOON"
        Me.SoonB.UseVisualStyleBackColor = True
        '
        'AddTaskL
        '
        Me.AddTaskL.AutoSize = True
        Me.AddTaskL.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddTaskL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTaskL.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.AddTaskL.ForeColor = System.Drawing.Color.BlueViolet
        Me.AddTaskL.Location = New System.Drawing.Point(93, 250)
        Me.AddTaskL.Name = "AddTaskL"
        Me.AddTaskL.Size = New System.Drawing.Size(162, 35)
        Me.AddTaskL.TabIndex = 3
        Me.AddTaskL.Text = "Add Task"
        Me.AddTaskL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewTaskL
        '
        Me.ViewTaskL.AutoSize = True
        Me.ViewTaskL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewTaskL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTaskL.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.ViewTaskL.ForeColor = System.Drawing.Color.BlueViolet
        Me.ViewTaskL.Location = New System.Drawing.Point(345, 250)
        Me.ViewTaskL.Name = "ViewTaskL"
        Me.ViewTaskL.Size = New System.Drawing.Size(162, 35)
        Me.ViewTaskL.TabIndex = 4
        Me.ViewTaskL.Text = "View Task"
        Me.ViewTaskL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteTaskL
        '
        Me.DeleteTaskL.AutoSize = True
        Me.DeleteTaskL.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteTaskL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteTaskL.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.DeleteTaskL.ForeColor = System.Drawing.Color.BlueViolet
        Me.DeleteTaskL.Location = New System.Drawing.Point(93, 494)
        Me.DeleteTaskL.Name = "DeleteTaskL"
        Me.DeleteTaskL.Size = New System.Drawing.Size(162, 35)
        Me.DeleteTaskL.TabIndex = 5
        Me.DeleteTaskL.Text = "Delete Task"
        Me.DeleteTaskL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnimationPanel
        '
        Me.AnimationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimationPanel.Location = New System.Drawing.Point(0, 0)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.AnimationPanel.Size = New System.Drawing.Size(959, 585)
        Me.AnimationPanel.TabIndex = 4
        '
        'BasePanel
        '
        Me.BasePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BasePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BasePanel.Controls.Add(Me.ViewTaskPanel)
        Me.BasePanel.Controls.Add(Me.HomeTaskPanel)
        Me.BasePanel.Controls.Add(Me.AddTaskPanel)
        Me.BasePanel.Controls.Add(Me.DeleteTaskPanel)
        Me.BasePanel.Location = New System.Drawing.Point(3, 80)
        Me.BasePanel.Name = "BasePanel"
        Me.BasePanel.Size = New System.Drawing.Size(959, 585)
        Me.BasePanel.TabIndex = 0
        '
        'ViewTaskPanel
        '
        Me.ViewTaskPanel.Controls.Add(Me.SplitContainer1)
        Me.ViewTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewTaskPanel.Enabled = False
        Me.ViewTaskPanel.Location = New System.Drawing.Point(0, 0)
        Me.ViewTaskPanel.Name = "ViewTaskPanel"
        Me.ViewTaskPanel.Size = New System.Drawing.Size(959, 585)
        Me.ViewTaskPanel.TabIndex = 0
        Me.ViewTaskPanel.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.BlueViolet
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Status)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ViewViewTaskB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BackFromViewTaskB)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(959, 585)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.TaskViewEndDate)
        Me.GroupBox1.Controls.Add(Me.TaskViewBeginDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(264, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 88)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Range"
        '
        'TaskViewEndDate
        '
        Me.TaskViewEndDate.CalendarForeColor = System.Drawing.Color.Gold
        Me.TaskViewEndDate.CalendarMonthBackground = System.Drawing.Color.Black
        Me.TaskViewEndDate.CalendarTitleBackColor = System.Drawing.Color.BlueViolet
        Me.TaskViewEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TaskViewEndDate.CalendarTrailingForeColor = System.Drawing.Color.BlueViolet
        Me.TaskViewEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskViewEndDate.Location = New System.Drawing.Point(242, 39)
        Me.TaskViewEndDate.Name = "TaskViewEndDate"
        Me.TaskViewEndDate.Size = New System.Drawing.Size(200, 28)
        Me.TaskViewEndDate.TabIndex = 0
        '
        'TaskViewBeginDate
        '
        Me.TaskViewBeginDate.CalendarForeColor = System.Drawing.Color.Gold
        Me.TaskViewBeginDate.CalendarMonthBackground = System.Drawing.Color.Black
        Me.TaskViewBeginDate.CalendarTitleBackColor = System.Drawing.Color.BlueViolet
        Me.TaskViewBeginDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TaskViewBeginDate.CalendarTrailingForeColor = System.Drawing.Color.BlueViolet
        Me.TaskViewBeginDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskViewBeginDate.Location = New System.Drawing.Point(17, 39)
        Me.TaskViewBeginDate.Name = "TaskViewBeginDate"
        Me.TaskViewBeginDate.Size = New System.Drawing.Size(200, 28)
        Me.TaskViewBeginDate.TabIndex = 0
        '
        'Status
        '
        Me.Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Status.Controls.Add(Me.CompletedChB)
        Me.Status.Controls.Add(Me.PendingChB)
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Gold
        Me.Status.Location = New System.Drawing.Point(31, 19)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(200, 88)
        Me.Status.TabIndex = 3
        Me.Status.TabStop = False
        Me.Status.Text = "Status"
        '
        'CompletedChB
        '
        Me.CompletedChB.AutoSize = True
        Me.CompletedChB.Checked = True
        Me.CompletedChB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CompletedChB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CompletedChB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompletedChB.ForeColor = System.Drawing.Color.Gold
        Me.CompletedChB.Location = New System.Drawing.Point(38, 25)
        Me.CompletedChB.Name = "CompletedChB"
        Me.CompletedChB.Size = New System.Drawing.Size(114, 26)
        Me.CompletedChB.TabIndex = 2
        Me.CompletedChB.Text = "Completed"
        Me.CompletedChB.UseVisualStyleBackColor = True
        '
        'PendingChB
        '
        Me.PendingChB.AutoSize = True
        Me.PendingChB.Checked = True
        Me.PendingChB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PendingChB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingChB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingChB.ForeColor = System.Drawing.Color.Gold
        Me.PendingChB.Location = New System.Drawing.Point(38, 51)
        Me.PendingChB.Name = "PendingChB"
        Me.PendingChB.Size = New System.Drawing.Size(94, 26)
        Me.PendingChB.TabIndex = 2
        Me.PendingChB.Text = "Pending"
        Me.PendingChB.UseVisualStyleBackColor = True
        '
        'ViewViewTaskB
        '
        Me.ViewViewTaskB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ViewViewTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.ViewViewTaskB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.ViewViewTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewViewTaskB.ForeColor = System.Drawing.Color.BlueViolet
        Me.ViewViewTaskB.Location = New System.Drawing.Point(755, 30)
        Me.ViewViewTaskB.Name = "ViewViewTaskB"
        Me.ViewViewTaskB.Size = New System.Drawing.Size(81, 77)
        Me.ViewViewTaskB.TabIndex = 0
        Me.ViewViewTaskB.Text = "View"
        Me.ViewViewTaskB.UseVisualStyleBackColor = True
        '
        'BackFromViewTaskB
        '
        Me.BackFromViewTaskB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackFromViewTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.BackFromViewTaskB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.BackFromViewTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackFromViewTaskB.ForeColor = System.Drawing.Color.BlueViolet
        Me.BackFromViewTaskB.Location = New System.Drawing.Point(857, 30)
        Me.BackFromViewTaskB.Name = "BackFromViewTaskB"
        Me.BackFromViewTaskB.Size = New System.Drawing.Size(81, 77)
        Me.BackFromViewTaskB.TabIndex = 0
        Me.BackFromViewTaskB.Text = "Back"
        Me.BackFromViewTaskB.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ViewMainTaskDGV, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ViewSubTaskDGV, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(959, 454)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ViewMainTaskDGV
        '
        Me.ViewMainTaskDGV.AllowUserToAddRows = False
        Me.ViewMainTaskDGV.AllowUserToDeleteRows = False
        Me.ViewMainTaskDGV.AutoGenerateColumns = False
        Me.ViewMainTaskDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ViewMainTaskDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ViewMainTaskDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewMainTaskDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskNumb, Me.TaskNam, Me.MTDate})
        Me.ViewMainTaskDGV.DataSource = Me.MainTaskBindingSource
        Me.ViewMainTaskDGV.GridColor = System.Drawing.Color.BlueViolet
        Me.ViewMainTaskDGV.Location = New System.Drawing.Point(3, 3)
        Me.ViewMainTaskDGV.Name = "ViewMainTaskDGV"
        Me.ViewMainTaskDGV.ReadOnly = True
        Me.ViewMainTaskDGV.RowHeadersWidth = 51
        Me.TableLayoutPanel2.SetRowSpan(Me.ViewMainTaskDGV, 2)
        Me.ViewMainTaskDGV.RowTemplate.Height = 24
        Me.ViewMainTaskDGV.Size = New System.Drawing.Size(330, 172)
        Me.ViewMainTaskDGV.TabIndex = 0
        '
        'MainTaskBindingSource
        '
        Me.MainTaskBindingSource.DataMember = "MainTask"
        Me.MainTaskBindingSource.DataSource = Me.PersonalAssistantDBDataSet
        '
        'PersonalAssistantDBDataSet
        '
        Me.PersonalAssistantDBDataSet.DataSetName = "PersonalAssistantDBDataSet"
        Me.PersonalAssistantDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DummyL)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.MTPriorityL)
        Me.Panel2.Controls.Add(Me.ProgressVal)
        Me.Panel2.Controls.Add(Me.MTDesc)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(482, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 183)
        Me.Panel2.TabIndex = 3
        '
        'DummyL
        '
        Me.DummyL.AutoSize = True
        Me.DummyL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTaskBindingSource, "TaskNum", True))
        Me.DummyL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DummyL.Location = New System.Drawing.Point(165, 103)
        Me.DummyL.Name = "DummyL"
        Me.DummyL.Size = New System.Drawing.Size(14, 16)
        Me.DummyL.TabIndex = 4
        Me.DummyL.Text = "1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MainTaskBindingSource, "Progress", True))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.BlueViolet
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 129)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(426, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainTaskBindingSource, "TaskDesc", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(24, 33)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(426, 61)
        Me.TextBox4.TabIndex = 2
        '
        'MTPriorityL
        '
        Me.MTPriorityL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MTPriorityL.AutoSize = True
        Me.MTPriorityL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTPriorityL.ForeColor = System.Drawing.Color.Gold
        Me.MTPriorityL.Location = New System.Drawing.Point(319, 7)
        Me.MTPriorityL.Name = "MTPriorityL"
        Me.MTPriorityL.Size = New System.Drawing.Size(131, 29)
        Me.MTPriorityL.TabIndex = 1
        Me.MTPriorityL.Text = "Priority : 0"
        '
        'ProgressVal
        '
        Me.ProgressVal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ProgressVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressVal.ForeColor = System.Drawing.Color.Gold
        Me.ProgressVal.Location = New System.Drawing.Point(170, 150)
        Me.ProgressVal.Name = "ProgressVal"
        Me.ProgressVal.Size = New System.Drawing.Size(135, 22)
        Me.ProgressVal.TabIndex = 1
        Me.ProgressVal.Text = "0% completed"
        '
        'MTDesc
        '
        Me.MTDesc.AutoSize = True
        Me.MTDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTDesc.ForeColor = System.Drawing.Color.Gold
        Me.MTDesc.Location = New System.Drawing.Point(19, 7)
        Me.MTDesc.Name = "MTDesc"
        Me.MTDesc.Size = New System.Drawing.Size(146, 29)
        Me.MTDesc.TabIndex = 1
        Me.MTDesc.Text = "Description"
        '
        'ViewSubTaskDGV
        '
        Me.ViewSubTaskDGV.AllowUserToAddRows = False
        Me.ViewSubTaskDGV.AllowUserToDeleteRows = False
        Me.ViewSubTaskDGV.AutoGenerateColumns = False
        Me.ViewSubTaskDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ViewSubTaskDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewSubTaskDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STNum, Me.STName, Me.STStatus, Me.ParentTaskNumDataGridViewTextBoxColumn, Me.OrderNumDataGridViewTextBoxColumn, Me.SubTaskNameDataGridViewTextBoxColumn, Me.SubTaskDescDataGridViewTextBoxColumn, Me.StatusDataGridViewImageColumn})
        Me.ViewSubTaskDGV.DataSource = Me.SubTaskBindingSource
        Me.ViewSubTaskDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewSubTaskDGV.Location = New System.Drawing.Point(482, 192)
        Me.ViewSubTaskDGV.MultiSelect = False
        Me.ViewSubTaskDGV.Name = "ViewSubTaskDGV"
        Me.ViewSubTaskDGV.ReadOnly = True
        Me.ViewSubTaskDGV.RowHeadersWidth = 51
        Me.ViewSubTaskDGV.RowTemplate.Height = 24
        Me.ViewSubTaskDGV.Size = New System.Drawing.Size(474, 259)
        Me.ViewSubTaskDGV.TabIndex = 4
        '
        'STNum
        '
        Me.STNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.STNum.DataPropertyName = "OrderNum"
        Me.STNum.FillWeight = 0.11!
        Me.STNum.HeaderText = "Num"
        Me.STNum.MinimumWidth = 6
        Me.STNum.Name = "STNum"
        Me.STNum.ReadOnly = True
        Me.STNum.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'STName
        '
        Me.STName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.STName.DataPropertyName = "SubTaskName"
        Me.STName.FillWeight = 0.75!
        Me.STName.HeaderText = "Name"
        Me.STName.MinimumWidth = 6
        Me.STName.Name = "STName"
        Me.STName.ReadOnly = True
        '
        'STStatus
        '
        Me.STStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.STStatus.DataPropertyName = "Status"
        Me.STStatus.FalseValue = "PENDING"
        Me.STStatus.FillWeight = 0.14!
        Me.STStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.STStatus.HeaderText = "Status"
        Me.STStatus.MinimumWidth = 6
        Me.STStatus.Name = "STStatus"
        Me.STStatus.ReadOnly = True
        Me.STStatus.TrueValue = "COMPLETED"
        '
        'ParentTaskNumDataGridViewTextBoxColumn
        '
        Me.ParentTaskNumDataGridViewTextBoxColumn.DataPropertyName = "ParentTaskNum"
        Me.ParentTaskNumDataGridViewTextBoxColumn.HeaderText = "ParentTaskNum"
        Me.ParentTaskNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ParentTaskNumDataGridViewTextBoxColumn.Name = "ParentTaskNumDataGridViewTextBoxColumn"
        Me.ParentTaskNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.ParentTaskNumDataGridViewTextBoxColumn.Width = 125
        '
        'OrderNumDataGridViewTextBoxColumn
        '
        Me.OrderNumDataGridViewTextBoxColumn.DataPropertyName = "OrderNum"
        Me.OrderNumDataGridViewTextBoxColumn.HeaderText = "OrderNum"
        Me.OrderNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderNumDataGridViewTextBoxColumn.Name = "OrderNumDataGridViewTextBoxColumn"
        Me.OrderNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderNumDataGridViewTextBoxColumn.Width = 125
        '
        'SubTaskNameDataGridViewTextBoxColumn
        '
        Me.SubTaskNameDataGridViewTextBoxColumn.DataPropertyName = "SubTaskName"
        Me.SubTaskNameDataGridViewTextBoxColumn.HeaderText = "SubTaskName"
        Me.SubTaskNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubTaskNameDataGridViewTextBoxColumn.Name = "SubTaskNameDataGridViewTextBoxColumn"
        Me.SubTaskNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTaskNameDataGridViewTextBoxColumn.Width = 125
        '
        'SubTaskDescDataGridViewTextBoxColumn
        '
        Me.SubTaskDescDataGridViewTextBoxColumn.DataPropertyName = "SubTaskDesc"
        Me.SubTaskDescDataGridViewTextBoxColumn.HeaderText = "SubTaskDesc"
        Me.SubTaskDescDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubTaskDescDataGridViewTextBoxColumn.Name = "SubTaskDescDataGridViewTextBoxColumn"
        Me.SubTaskDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTaskDescDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewImageColumn
        '
        Me.StatusDataGridViewImageColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewImageColumn.HeaderText = "Status"
        Me.StatusDataGridViewImageColumn.MinimumWidth = 6
        Me.StatusDataGridViewImageColumn.Name = "StatusDataGridViewImageColumn"
        Me.StatusDataGridViewImageColumn.ReadOnly = True
        Me.StatusDataGridViewImageColumn.Width = 125
        '
        'SubTaskBindingSource
        '
        Me.SubTaskBindingSource.DataMember = "SubTask"
        Me.SubTaskBindingSource.DataSource = Me.PersonalAssistantDBDataSet
        '
        'AddTaskPanel
        '
        Me.AddTaskPanel.Controls.Add(Me.InnerPanel)
        Me.AddTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddTaskPanel.Enabled = False
        Me.AddTaskPanel.Location = New System.Drawing.Point(0, 0)
        Me.AddTaskPanel.Name = "AddTaskPanel"
        Me.AddTaskPanel.Size = New System.Drawing.Size(959, 585)
        Me.AddTaskPanel.TabIndex = 0
        Me.AddTaskPanel.Visible = False
        '
        'InnerPanel
        '
        Me.InnerPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InnerPanel.Controls.Add(Me.AddTaskTitle)
        Me.InnerPanel.Controls.Add(Me.BackFromAddTaskB)
        Me.InnerPanel.Controls.Add(Me.Priority)
        Me.InnerPanel.Controls.Add(Me.AddAddTaskB)
        Me.InnerPanel.Controls.Add(Me.TaskDesc)
        Me.InnerPanel.Controls.Add(Me.TaskName)
        Me.InnerPanel.Controls.Add(Me.PriorityL)
        Me.InnerPanel.Controls.Add(Me.TargetDate)
        Me.InnerPanel.Controls.Add(Me.TargetDateL)
        Me.InnerPanel.Controls.Add(Me.TaslkNameL)
        Me.InnerPanel.Controls.Add(Me.TaskDescriptionL)
        Me.InnerPanel.Location = New System.Drawing.Point(261, 30)
        Me.InnerPanel.Name = "InnerPanel"
        Me.InnerPanel.Size = New System.Drawing.Size(437, 537)
        Me.InnerPanel.TabIndex = 6
        '
        'AddTaskTitle
        '
        Me.AddTaskTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddTaskTitle.AutoSize = True
        Me.AddTaskTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTaskTitle.ForeColor = System.Drawing.Color.Gold
        Me.AddTaskTitle.Location = New System.Drawing.Point(55, 19)
        Me.AddTaskTitle.Name = "AddTaskTitle"
        Me.AddTaskTitle.Size = New System.Drawing.Size(326, 46)
        Me.AddTaskTitle.TabIndex = 4
        Me.AddTaskTitle.Text = "Add Transaction"
        Me.AddTaskTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackFromAddTaskB
        '
        Me.BackFromAddTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.BackFromAddTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.BackFromAddTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackFromAddTaskB.ForeColor = System.Drawing.Color.BlueViolet
        Me.BackFromAddTaskB.Location = New System.Drawing.Point(224, 454)
        Me.BackFromAddTaskB.Name = "BackFromAddTaskB"
        Me.BackFromAddTaskB.Size = New System.Drawing.Size(204, 67)
        Me.BackFromAddTaskB.TabIndex = 5
        Me.BackFromAddTaskB.Text = "Back"
        Me.BackFromAddTaskB.UseVisualStyleBackColor = True
        '
        'Priority
        '
        Me.Priority.FormattingEnabled = True
        Me.Priority.Location = New System.Drawing.Point(222, 379)
        Me.Priority.Name = "Priority"
        Me.Priority.Size = New System.Drawing.Size(200, 24)
        Me.Priority.TabIndex = 1
        '
        'AddAddTaskB
        '
        Me.AddAddTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.AddAddTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.AddAddTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddAddTaskB.ForeColor = System.Drawing.Color.BlueViolet
        Me.AddAddTaskB.Location = New System.Drawing.Point(11, 454)
        Me.AddAddTaskB.Name = "AddAddTaskB"
        Me.AddAddTaskB.Size = New System.Drawing.Size(204, 67)
        Me.AddAddTaskB.TabIndex = 5
        Me.AddAddTaskB.Text = "Add"
        Me.AddAddTaskB.UseVisualStyleBackColor = True
        '
        'TaskDesc
        '
        Me.TaskDesc.Location = New System.Drawing.Point(222, 194)
        Me.TaskDesc.Multiline = True
        Me.TaskDesc.Name = "TaskDesc"
        Me.TaskDesc.Size = New System.Drawing.Size(200, 57)
        Me.TaskDesc.TabIndex = 2
        '
        'TaskName
        '
        Me.TaskName.Location = New System.Drawing.Point(222, 117)
        Me.TaskName.Name = "TaskName"
        Me.TaskName.Size = New System.Drawing.Size(200, 22)
        Me.TaskName.TabIndex = 2
        '
        'PriorityL
        '
        Me.PriorityL.AutoSize = True
        Me.PriorityL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityL.ForeColor = System.Drawing.Color.Gold
        Me.PriorityL.Location = New System.Drawing.Point(15, 375)
        Me.PriorityL.Name = "PriorityL"
        Me.PriorityL.Size = New System.Drawing.Size(79, 25)
        Me.PriorityL.TabIndex = 4
        Me.PriorityL.Text = "Priority"
        '
        'TargetDate
        '
        Me.TargetDate.Location = New System.Drawing.Point(222, 302)
        Me.TargetDate.Name = "TargetDate"
        Me.TargetDate.Size = New System.Drawing.Size(200, 22)
        Me.TargetDate.TabIndex = 3
        '
        'TargetDateL
        '
        Me.TargetDateL.AutoSize = True
        Me.TargetDateL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetDateL.ForeColor = System.Drawing.Color.Gold
        Me.TargetDateL.Location = New System.Drawing.Point(15, 299)
        Me.TargetDateL.Name = "TargetDateL"
        Me.TargetDateL.Size = New System.Drawing.Size(126, 25)
        Me.TargetDateL.TabIndex = 4
        Me.TargetDateL.Text = "Target Date"
        '
        'TaslkNameL
        '
        Me.TaslkNameL.AutoSize = True
        Me.TaslkNameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaslkNameL.ForeColor = System.Drawing.Color.Gold
        Me.TaslkNameL.Location = New System.Drawing.Point(15, 113)
        Me.TaslkNameL.Name = "TaslkNameL"
        Me.TaslkNameL.Size = New System.Drawing.Size(122, 25)
        Me.TaslkNameL.TabIndex = 4
        Me.TaslkNameL.Text = "Task Name"
        '
        'TaskDescriptionL
        '
        Me.TaskDescriptionL.AutoSize = True
        Me.TaskDescriptionL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDescriptionL.ForeColor = System.Drawing.Color.Gold
        Me.TaskDescriptionL.Location = New System.Drawing.Point(15, 190)
        Me.TaskDescriptionL.Name = "TaskDescriptionL"
        Me.TaskDescriptionL.Size = New System.Drawing.Size(174, 25)
        Me.TaskDescriptionL.TabIndex = 4
        Me.TaskDescriptionL.Text = "Task Description"
        '
        'DeleteTaskPanel
        '
        Me.DeleteTaskPanel.Controls.Add(Me.Panel1)
        Me.DeleteTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteTaskPanel.Enabled = False
        Me.DeleteTaskPanel.Location = New System.Drawing.Point(0, 0)
        Me.DeleteTaskPanel.Name = "DeleteTaskPanel"
        Me.DeleteTaskPanel.Size = New System.Drawing.Size(959, 585)
        Me.DeleteTaskPanel.TabIndex = 7
        Me.DeleteTaskPanel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BackFromDeleteTaskB)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(261, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 537)
        Me.Panel1.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(222, 372)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(222, 328)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 22)
        Me.TextBox2.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 159)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(222, 113)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Delete Transaction"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackFromDeleteTaskB
        '
        Me.BackFromDeleteTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.BackFromDeleteTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.BackFromDeleteTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackFromDeleteTaskB.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackFromDeleteTaskB.ForeColor = System.Drawing.Color.BlueViolet
        Me.BackFromDeleteTaskB.Location = New System.Drawing.Point(222, 424)
        Me.BackFromDeleteTaskB.Name = "BackFromDeleteTaskB"
        Me.BackFromDeleteTaskB.Size = New System.Drawing.Size(206, 97)
        Me.BackFromDeleteTaskB.TabIndex = 5
        Me.BackFromDeleteTaskB.Text = "Back"
        Me.BackFromDeleteTaskB.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button3.Location = New System.Drawing.Point(9, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(206, 97)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(222, 205)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 57)
        Me.TextBox1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(15, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(15, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Priority"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(222, 284)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(15, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Target Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(15, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Task Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(15, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Task Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(15, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Task Description"
        '
        'TaskManagementL
        '
        Me.TaskManagementL.AutoSize = True
        Me.TaskManagementL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskManagementL.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.TaskManagementL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TaskManagementL.Location = New System.Drawing.Point(22, 10)
        Me.TaskManagementL.Name = "TaskManagementL"
        Me.TaskManagementL.Size = New System.Drawing.Size(344, 54)
        Me.TaskManagementL.TabIndex = 0
        Me.TaskManagementL.Text = "Task Management"
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.Controls.Add(Me.TaskManagementL)
        Me.TitlePanel.Location = New System.Drawing.Point(3, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(959, 71)
        Me.TitlePanel.TabIndex = 4
        '
        'MainTaskTableAdapter
        '
        Me.MainTaskTableAdapter.ClearBeforeFill = True
        '
        'SubTaskTableAdapter
        '
        Me.SubTaskTableAdapter.ClearBeforeFill = True
        '
        'TaskNumb
        '
        Me.TaskNumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TaskNumb.DataPropertyName = "TaskNum"
        Me.TaskNumb.FillWeight = 0.15!
        Me.TaskNumb.HeaderText = "Task Number"
        Me.TaskNumb.MinimumWidth = 6
        Me.TaskNumb.Name = "TaskNumb"
        Me.TaskNumb.ReadOnly = True
        '
        'TaskNam
        '
        Me.TaskNam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TaskNam.DataPropertyName = "TaskName"
        Me.TaskNam.FillWeight = 0.65!
        Me.TaskNam.HeaderText = "Task Name"
        Me.TaskNam.MinimumWidth = 6
        Me.TaskNam.Name = "TaskNam"
        Me.TaskNam.ReadOnly = True
        '
        'MTDate
        '
        Me.MTDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MTDate.DataPropertyName = "TargetDate"
        Me.MTDate.FillWeight = 0.2!
        Me.MTDate.HeaderText = "Date"
        Me.MTDate.MinimumWidth = 6
        Me.MTDate.Name = "MTDate"
        Me.MTDate.ReadOnly = True
        '
        'TaskManagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.Controls.Add(Me.BasePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.DoubleBuffered = True
        Me.Name = "TaskManagement"
        Me.Size = New System.Drawing.Size(965, 665)
        Me.HomeTaskPanel.ResumeLayout(False)
        Me.ButtonPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.BasePanel.ResumeLayout(False)
        Me.ViewTaskPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.ViewMainTaskDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalAssistantDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ViewSubTaskDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubTaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddTaskPanel.ResumeLayout(False)
        Me.InnerPanel.ResumeLayout(False)
        Me.InnerPanel.PerformLayout()
        Me.DeleteTaskPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeTaskPanel As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AddTaskB As Button
    Friend WithEvents ViewTaskB As Button
    Friend WithEvents DeleteTaskB As Button
    Friend WithEvents SoonB As Button
    Friend WithEvents AddTaskL As Label
    Friend WithEvents ViewTaskL As Label
    Friend WithEvents DeleteTaskL As Label
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents BasePanel As Panel
    Friend WithEvents AddTaskPanel As Panel
    Friend WithEvents InnerPanel As Panel
    Friend WithEvents AddTaskTitle As Label
    Friend WithEvents BackFromAddTaskB As Button
    Friend WithEvents Priority As ComboBox
    Friend WithEvents TaskDesc As TextBox
    Friend WithEvents AddAddTaskB As Button
    Friend WithEvents TaskName As TextBox
    Friend WithEvents PriorityL As Label
    Friend WithEvents TargetDate As DateTimePicker
    Friend WithEvents TargetDateL As Label
    Friend WithEvents TaslkNameL As Label
    Friend WithEvents TaskDescriptionL As Label
    Friend WithEvents DeleteTaskPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackFromDeleteTaskB As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ViewTaskPanel As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ViewMainTaskDGV As DataGridView
    Friend WithEvents BackFromViewTaskB As Button
    Friend WithEvents ViewViewTaskB As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents MTDesc As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ViewSubTaskDGV As DataGridView
    Friend WithEvents MTPriorityL As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressVal As Label
    Friend WithEvents MainTaskBindingSource As BindingSource
    Friend WithEvents PersonalAssistantDBDataSet As PersonalAssistantDBDataSet
    Friend WithEvents SubTaskBindingSource As BindingSource
    Friend WithEvents MainTaskTableAdapter As PersonalAssistantDBDataSetTableAdapters.MainTaskTableAdapter
    Friend WithEvents SubTaskTableAdapter As PersonalAssistantDBDataSetTableAdapters.SubTaskTableAdapter
    Friend WithEvents PendingChB As CheckBox
    Friend WithEvents CompletedChB As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TaskViewBeginDate As DateTimePicker
    Friend WithEvents Status As GroupBox
    Friend WithEvents TaskViewEndDate As DateTimePicker
    Friend WithEvents TaskManagementL As Label
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents DummyL As Label
    Friend WithEvents STNum As DataGridViewTextBoxColumn
    Friend WithEvents STName As DataGridViewTextBoxColumn
    Friend WithEvents STStatus As DataGridViewCheckBoxColumn
    Friend WithEvents ParentTaskNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTaskNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTaskDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents TaskNumb As DataGridViewTextBoxColumn
    Friend WithEvents TaskNam As DataGridViewTextBoxColumn
    Friend WithEvents MTDate As DataGridViewTextBoxColumn
End Class
