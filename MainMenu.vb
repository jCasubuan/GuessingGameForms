Public Class MainMenu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        MessageBox.Show("Starting a Game...", "Start", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        MessageBox.Show("Loading a Game...", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_Points_Click(sender As Object, e As EventArgs) Handles btn_Points.Click
        MessageBox.Show("Your Points...", "Points", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_Leaderboards_Click(sender As Object, e As EventArgs) Handles btn_Leaderboards.Click
        MessageBox.Show("Leaderboards...", "Leaderboards", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_Mechanics_Click(sender As Object, e As EventArgs) Handles btn_Mechanics.Click
        MessageBox.Show("Mechanics...", "Mechanics", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_AboutUs_Click(sender As Object, e As EventArgs) Handles btn_AboutUs.Click
        MessageBox.Show("About us...", "About us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class