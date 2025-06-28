<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.hdrLogin = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.btn_Points = New System.Windows.Forms.Button()
        Me.btn_Leaderboards = New System.Windows.Forms.Button()
        Me.btn_Mechanics = New System.Windows.Forms.Button()
        Me.btn_AboutUs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'hdrLogin
        '
        Me.hdrLogin.AutoSize = True
        Me.hdrLogin.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrLogin.Location = New System.Drawing.Point(11, 27)
        Me.hdrLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hdrLogin.Name = "hdrLogin"
        Me.hdrLogin.Size = New System.Drawing.Size(335, 51)
        Me.hdrLogin.TabIndex = 1
        Me.hdrLogin.Text = "Welcome, Players"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(20, 510)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 28)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Start.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.ForeColor = System.Drawing.Color.White
        Me.btn_Start.Location = New System.Drawing.Point(133, 109)
        Me.btn_Start.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(194, 58)
        Me.btn_Start.TabIndex = 8
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'btn_Load
        '
        Me.btn_Load.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Load.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Load.ForeColor = System.Drawing.Color.White
        Me.btn_Load.Location = New System.Drawing.Point(133, 185)
        Me.btn_Load.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(194, 58)
        Me.btn_Load.TabIndex = 9
        Me.btn_Load.Text = "Load"
        Me.btn_Load.UseVisualStyleBackColor = False
        '
        'btn_Points
        '
        Me.btn_Points.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_Points.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Points.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Points.ForeColor = System.Drawing.Color.White
        Me.btn_Points.Location = New System.Drawing.Point(133, 259)
        Me.btn_Points.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Points.Name = "btn_Points"
        Me.btn_Points.Size = New System.Drawing.Size(194, 58)
        Me.btn_Points.TabIndex = 10
        Me.btn_Points.Text = "Points"
        Me.btn_Points.UseVisualStyleBackColor = False
        '
        'btn_Leaderboards
        '
        Me.btn_Leaderboards.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_Leaderboards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Leaderboards.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Leaderboards.ForeColor = System.Drawing.Color.White
        Me.btn_Leaderboards.Location = New System.Drawing.Point(133, 334)
        Me.btn_Leaderboards.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Leaderboards.Name = "btn_Leaderboards"
        Me.btn_Leaderboards.Size = New System.Drawing.Size(194, 58)
        Me.btn_Leaderboards.TabIndex = 11
        Me.btn_Leaderboards.Text = "Leaderboards"
        Me.btn_Leaderboards.UseVisualStyleBackColor = False
        '
        'btn_Mechanics
        '
        Me.btn_Mechanics.BackColor = System.Drawing.Color.Teal
        Me.btn_Mechanics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Mechanics.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Mechanics.ForeColor = System.Drawing.Color.White
        Me.btn_Mechanics.Location = New System.Drawing.Point(218, 505)
        Me.btn_Mechanics.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Mechanics.Name = "btn_Mechanics"
        Me.btn_Mechanics.Size = New System.Drawing.Size(124, 32)
        Me.btn_Mechanics.TabIndex = 12
        Me.btn_Mechanics.Text = "Mechanics"
        Me.btn_Mechanics.UseVisualStyleBackColor = False
        '
        'btn_AboutUs
        '
        Me.btn_AboutUs.BackColor = System.Drawing.Color.Teal
        Me.btn_AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AboutUs.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AboutUs.ForeColor = System.Drawing.Color.White
        Me.btn_AboutUs.Location = New System.Drawing.Point(346, 505)
        Me.btn_AboutUs.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_AboutUs.Name = "btn_AboutUs"
        Me.btn_AboutUs.Size = New System.Drawing.Size(118, 32)
        Me.btn_AboutUs.TabIndex = 13
        Me.btn_AboutUs.Text = "About Us"
        Me.btn_AboutUs.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 565)
        Me.Controls.Add(Me.btn_AboutUs)
        Me.Controls.Add(Me.btn_Mechanics)
        Me.Controls.Add(Me.btn_Leaderboards)
        Me.Controls.Add(Me.btn_Points)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.hdrLogin)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hdrLogin As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btn_Start As Button
    Friend WithEvents btn_Load As Button
    Friend WithEvents btn_Points As Button
    Friend WithEvents btn_Leaderboards As Button
    Friend WithEvents btn_Mechanics As Button
    Friend WithEvents btn_AboutUs As Button
End Class
