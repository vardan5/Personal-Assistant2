Imports System.Data.SqlClient

Public Class TaskManagement

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    'For TitlePanel Grey Border
    Private Sub GreyPanel_Paint(sender As Object, e As PaintEventArgs) Handles TitlePanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)
    End Sub
    Private Sub VioletPanel_Paint(sender As Object, e As PaintEventArgs) Handles InnerPanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.BlueViolet, 3, ButtonBorderStyle.Solid, Color.BlueViolet, 3, ButtonBorderStyle.Solid, Color.BlueViolet, 3, ButtonBorderStyle.Solid, Color.BlueViolet, 3, ButtonBorderStyle.Solid)
    End Sub

    'For Dynamically adjusting Splitter location
    Private Sub BasePanel_SizeChanged(sender As Object, e As EventArgs) Handles HomeTaskPanel.SizeChanged
        Dim width As Integer = HomeTaskPanel.Width
        ButtonPanel.Width = width * 0.67
    End Sub

    'HomeTaskPanel Buttons
    Private Sub AddTaskB_Click(sender As Object, e As EventArgs) Handles AddTaskB.Click
        HomeTaskPanel.Visible = False
        HomeTaskPanel.Enabled = False
        AddTaskPanel.Visible = True
        AddTaskPanel.Enabled = True
    End Sub
    Private Sub DeleteTaskB_Click(sender As Object, e As EventArgs) Handles DeleteTaskB.Click
        HomeTaskPanel.Visible = False
        HomeTaskPanel.Enabled = False
        DeleteTaskPanel.Visible = True
        DeleteTaskPanel.Enabled = True
    End Sub
    Private Sub ViewTaskB_Click(sender As Object, e As EventArgs) Handles ViewTaskB.Click
        HomeTaskPanel.Visible = False
        HomeTaskPanel.Enabled = False
        ViewTaskPanel.Visible = True
        ViewTaskPanel.Enabled = True
    End Sub


    'Add Task Panel
    Private Sub BackFromAddTaskB_Click(sender As Object, e As EventArgs) Handles BackFromAddTaskB.Click
        AddTaskPanel.Visible = False
        AddTaskPanel.Enabled = False
        HomeTaskPanel.Visible = True
        HomeTaskPanel.Enabled = True
    End Sub





    'Delete Task Panel
    Private Sub BackFromDeleteTaskB_Click(sender As Object, e As EventArgs) Handles BackFromDeleteTaskB.Click
        DeleteTaskPanel.Visible = False
        DeleteTaskPanel.Enabled = False
        HomeTaskPanel.Visible = True
        HomeTaskPanel.Enabled = True
    End Sub







    'View Task Panel
    Private Sub BackFromViewTaskB_Click(sender As Object, e As EventArgs) Handles BackFromViewTaskB.Click
        ViewTaskPanel.Visible = False
        ViewTaskPanel.Enabled = False
        HomeTaskPanel.Visible = True
        HomeTaskPanel.Enabled = True
    End Sub


    Private Sub TaskManagement_Load(sender As Object, e As EventArgs) Handles Me.Load
        con.ConnectionString = Personal_Assistant2.My.Settings.PADBConnString

    End Sub

    Private Sub ShowDataDGV(ByVal table As String, ByVal condition As String)
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from [" & table & "] " & condition & ";"
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ViewTaskDGV.DataSource = dt
        con.Close()
    End Sub

    Private Sub ViewViewTask_Click(sender As Object, e As EventArgs) Handles ViewViewTask.Click
        ShowDataDGV("MainTask", "")
    End Sub
End Class