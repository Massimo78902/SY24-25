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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        WideEnemy = New PictureBox()
        JohnOfDeath = New PictureBox()
        FirstEnemy = New PictureBox()
        Plat = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Platform = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label1 = New Label()
        Platter = New PictureBox()
        ScoreLabel = New Label()
        Timer2 = New Timer(components)
        Floor = New PictureBox()
        JumpBoost = New PictureBox()
        JumpTimer = New Timer(components)
        Roof = New PictureBox()
        LeftWall = New PictureBox()
        RightWall = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        DeathMessage = New GroupBox()
        Label2 = New Label()
        ResetButton = New Button()
        Start = New Label()
        GravityTimer = New Timer(components)
        Trophy = New PictureBox()
        WinScreen = New GroupBox()
        PictureBox17 = New PictureBox()
        PictureBox16 = New PictureBox()
        Label3 = New Label()
        PlayAgainButton = New Button()
        PictureBox15 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(WideEnemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(JohnOfDeath, ComponentModel.ISupportInitialize).BeginInit()
        CType(FirstEnemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Plat, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platter, ComponentModel.ISupportInitialize).BeginInit()
        CType(Floor, ComponentModel.ISupportInitialize).BeginInit()
        CType(JumpBoost, ComponentModel.ISupportInitialize).BeginInit()
        CType(Roof, ComponentModel.ISupportInitialize).BeginInit()
        CType(LeftWall, ComponentModel.ISupportInitialize).BeginInit()
        CType(RightWall, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        DeathMessage.SuspendLayout()
        CType(Trophy, ComponentModel.ISupportInitialize).BeginInit()
        WinScreen.SuspendLayout()
        CType(PictureBox17, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(57, 940)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(25, 31)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 500
        ' 
        ' WideEnemy
        ' 
        WideEnemy.Image = CType(resources.GetObject("WideEnemy.Image"), Image)
        WideEnemy.Location = New Point(459, 192)
        WideEnemy.Name = "WideEnemy"
        WideEnemy.Size = New Size(171, 87)
        WideEnemy.SizeMode = PictureBoxSizeMode.StretchImage
        WideEnemy.TabIndex = 2
        WideEnemy.TabStop = False
        WideEnemy.Tag = "-1"
        ' 
        ' JohnOfDeath
        ' 
        JohnOfDeath.Image = CType(resources.GetObject("JohnOfDeath.Image"), Image)
        JohnOfDeath.Location = New Point(6, 96)
        JohnOfDeath.Name = "JohnOfDeath"
        JohnOfDeath.Size = New Size(366, 173)
        JohnOfDeath.SizeMode = PictureBoxSizeMode.StretchImage
        JohnOfDeath.TabIndex = 3
        JohnOfDeath.TabStop = False
        ' 
        ' FirstEnemy
        ' 
        FirstEnemy.Image = CType(resources.GetObject("FirstEnemy.Image"), Image)
        FirstEnemy.Location = New Point(278, 774)
        FirstEnemy.Name = "FirstEnemy"
        FirstEnemy.Size = New Size(29, 37)
        FirstEnemy.SizeMode = PictureBoxSizeMode.StretchImage
        FirstEnemy.TabIndex = 5
        FirstEnemy.TabStop = False
        FirstEnemy.Tag = "-1"
        ' 
        ' Plat
        ' 
        Plat.BackColor = Color.SaddleBrown
        Plat.Location = New Point(111, 959)
        Plat.Name = "Plat"
        Plat.Size = New Size(220, 20)
        Plat.TabIndex = 4
        Plat.TabStop = False
        Plat.Tag = "wall"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.SaddleBrown
        PictureBox1.Location = New Point(618, 704)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(159, 29)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        PictureBox1.Tag = "wall"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.SaddleBrown
        PictureBox2.Location = New Point(419, 762)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(220, 29)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        PictureBox2.Tag = "wall"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.SaddleBrown
        PictureBox3.Location = New Point(211, 332)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(96, 29)
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        PictureBox3.Tag = "wall"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.SaddleBrown
        PictureBox4.Location = New Point(211, 869)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(192, 10)
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        PictureBox4.Tag = "wall"
        ' 
        ' Platform
        ' 
        Platform.BackColor = Color.SaddleBrown
        Platform.Location = New Point(211, 817)
        Platform.Name = "Platform"
        Platform.Size = New Size(192, 10)
        Platform.TabIndex = 10
        Platform.TabStop = False
        Platform.Tag = "wall"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.SaddleBrown
        PictureBox6.Location = New Point(211, 921)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(192, 10)
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        PictureBox6.Tag = "wall"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.LightSlateGray
        PictureBox7.Location = New Point(667, 378)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(40, 99)
        PictureBox7.TabIndex = 12
        PictureBox7.TabStop = False
        PictureBox7.Tag = "wall"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.LightSlateGray
        PictureBox8.Location = New Point(42, 213)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(178, 41)
        PictureBox8.TabIndex = 13
        PictureBox8.TabStop = False
        PictureBox8.Tag = "wall"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.LightSlateGray
        PictureBox9.Location = New Point(375, 378)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(40, 99)
        PictureBox9.TabIndex = 14
        PictureBox9.TabStop = False
        PictureBox9.Tag = "wall"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.LightSlateGray
        PictureBox10.Location = New Point(745, 541)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(77, 28)
        PictureBox10.TabIndex = 15
        PictureBox10.TabStop = False
        PictureBox10.Tag = "wall"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.LightSlateGray
        PictureBox11.Location = New Point(521, 378)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(40, 99)
        PictureBox11.TabIndex = 16
        PictureBox11.TabStop = False
        PictureBox11.Tag = "wall"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.LimeGreen
        PictureBox5.Location = New Point(246, 107)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(357, 50)
        PictureBox5.TabIndex = 17
        PictureBox5.TabStop = False
        PictureBox5.Tag = "wall"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.YellowGreen
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(375, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 32)
        Label1.TabIndex = 18
        Label1.Text = "Victory"
        ' 
        ' Platter
        ' 
        Platter.BackColor = Color.LightSlateGray
        Platter.Location = New Point(313, 280)
        Platter.Name = "Platter"
        Platter.Size = New Size(425, 29)
        Platter.TabIndex = 19
        Platter.TabStop = False
        Platter.Tag = ""
        Platter.Visible = False
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.BorderStyle = BorderStyle.Fixed3D
        ScoreLabel.Font = New Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ScoreLabel.Location = New Point(667, 18)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(110, 46)
        ScoreLabel.TabIndex = 20
        ScoreLabel.Text = "0"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' Floor
        ' 
        Floor.BackColor = SystemColors.ActiveCaptionText
        Floor.Location = New Point(-9, 974)
        Floor.Name = "Floor"
        Floor.Size = New Size(852, 29)
        Floor.TabIndex = 21
        Floor.TabStop = False
        Floor.Tag = "wall"
        ' 
        ' JumpBoost
        ' 
        JumpBoost.Image = CType(resources.GetObject("JumpBoost.Image"), Image)
        JumpBoost.Location = New Point(768, 492)
        JumpBoost.Name = "JumpBoost"
        JumpBoost.Size = New Size(39, 32)
        JumpBoost.SizeMode = PictureBoxSizeMode.StretchImage
        JumpBoost.TabIndex = 22
        JumpBoost.TabStop = False
        JumpBoost.Tag = "Jump"
        ' 
        ' JumpTimer
        ' 
        JumpTimer.Interval = 50
        ' 
        ' Roof
        ' 
        Roof.BackColor = SystemColors.ActiveCaptionText
        Roof.Location = New Point(-9, -14)
        Roof.Name = "Roof"
        Roof.Size = New Size(852, 29)
        Roof.TabIndex = 23
        Roof.TabStop = False
        Roof.Tag = "wall"
        ' 
        ' LeftWall
        ' 
        LeftWall.BackColor = SystemColors.ActiveCaptionText
        LeftWall.Location = New Point(-7, 8)
        LeftWall.Name = "LeftWall"
        LeftWall.Size = New Size(27, 973)
        LeftWall.TabIndex = 24
        LeftWall.TabStop = False
        LeftWall.Tag = "wall"
        ' 
        ' RightWall
        ' 
        RightWall.BackColor = SystemColors.ActiveCaptionText
        RightWall.Location = New Point(828, -14)
        RightWall.Name = "RightWall"
        RightWall.Size = New Size(24, 1017)
        RightWall.TabIndex = 25
        RightWall.TabStop = False
        RightWall.Tag = "wall"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.SaddleBrown
        PictureBox12.Location = New Point(608, 592)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(159, 13)
        PictureBox12.TabIndex = 26
        PictureBox12.TabStop = False
        PictureBox12.Tag = "wall"
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.SaddleBrown
        PictureBox13.Location = New Point(459, 646)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(159, 13)
        PictureBox13.TabIndex = 27
        PictureBox13.TabStop = False
        PictureBox13.Tag = "wall"
        ' 
        ' DeathMessage
        ' 
        DeathMessage.BackColor = Color.DarkRed
        DeathMessage.Controls.Add(WinScreen)
        DeathMessage.Controls.Add(Label2)
        DeathMessage.Controls.Add(ResetButton)
        DeathMessage.Controls.Add(JohnOfDeath)
        DeathMessage.Location = New Point(246, 315)
        DeathMessage.Name = "DeathMessage"
        DeathMessage.Size = New Size(384, 402)
        DeathMessage.TabIndex = 28
        DeathMessage.TabStop = False
        DeathMessage.Visible = False
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(80, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 41)
        Label2.TabIndex = 5
        Label2.Text = "John Ate You"
        ' 
        ' ResetButton
        ' 
        ResetButton.BackColor = Color.IndianRed
        ResetButton.Font = New Font("Segoe UI Semibold", 26F, FontStyle.Bold)
        ResetButton.ForeColor = Color.Crimson
        ResetButton.Location = New Point(80, 292)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(239, 100)
        ResetButton.TabIndex = 4
        ResetButton.Text = "Try Again"
        ResetButton.UseVisualStyleBackColor = False
        ' 
        ' Start
        ' 
        Start.AutoSize = True
        Start.BackColor = Color.Lime
        Start.Location = New Point(57, 936)
        Start.Name = "Start"
        Start.Size = New Size(40, 20)
        Start.TabIndex = 29
        Start.Text = "Start"
        Start.Visible = False
        ' 
        ' GravityTimer
        ' 
        GravityTimer.Enabled = True
        GravityTimer.Interval = 50
        ' 
        ' Trophy
        ' 
        Trophy.Image = CType(resources.GetObject("Trophy.Image"), Image)
        Trophy.Location = New Point(386, 52)
        Trophy.Name = "Trophy"
        Trophy.Size = New Size(46, 49)
        Trophy.SizeMode = PictureBoxSizeMode.StretchImage
        Trophy.TabIndex = 30
        Trophy.TabStop = False
        Trophy.Tag = "Win"
        ' 
        ' WinScreen
        ' 
        WinScreen.BackColor = Color.Lime
        WinScreen.Controls.Add(PictureBox17)
        WinScreen.Controls.Add(PictureBox16)
        WinScreen.Controls.Add(Label3)
        WinScreen.Controls.Add(PlayAgainButton)
        WinScreen.Controls.Add(PictureBox15)
        WinScreen.Location = New Point(0, 0)
        WinScreen.Name = "WinScreen"
        WinScreen.Size = New Size(384, 402)
        WinScreen.TabIndex = 29
        WinScreen.TabStop = False
        WinScreen.Visible = False
        ' 
        ' PictureBox17
        ' 
        PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), Image)
        PictureBox17.Location = New Point(22, 101)
        PictureBox17.Name = "PictureBox17"
        PictureBox17.Size = New Size(86, 145)
        PictureBox17.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox17.TabIndex = 9
        PictureBox17.TabStop = False
        ' 
        ' PictureBox16
        ' 
        PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), Image)
        PictureBox16.Location = New Point(283, 101)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(86, 145)
        PictureBox16.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox16.TabIndex = 8
        PictureBox16.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(345, 38)
        Label3.TabIndex = 5
        Label3.Text = "You Avoided John's Earthquakes :)"
        ' 
        ' PlayAgainButton
        ' 
        PlayAgainButton.BackColor = Color.DarkSeaGreen
        PlayAgainButton.Font = New Font("Segoe UI Semibold", 26F, FontStyle.Bold)
        PlayAgainButton.ForeColor = Color.White
        PlayAgainButton.Location = New Point(74, 292)
        PlayAgainButton.Name = "PlayAgainButton"
        PlayAgainButton.Size = New Size(252, 100)
        PlayAgainButton.TabIndex = 4
        PlayAgainButton.Text = "Play Again"
        PlayAgainButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox15
        ' 
        PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), Image)
        PictureBox15.Location = New Point(122, 94)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(135, 173)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 3
        PictureBox15.TabStop = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(839, 993)
        Controls.Add(Trophy)
        Controls.Add(Avatar)
        Controls.Add(Start)
        Controls.Add(DeathMessage)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox12)
        Controls.Add(RightWall)
        Controls.Add(LeftWall)
        Controls.Add(Roof)
        Controls.Add(JumpBoost)
        Controls.Add(Floor)
        Controls.Add(ScoreLabel)
        Controls.Add(Platter)
        Controls.Add(Label1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(Platform)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(FirstEnemy)
        Controls.Add(WideEnemy)
        Controls.Add(Plat)
        Name = "form1"
        Text = "Mario Vs. John"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(WideEnemy, ComponentModel.ISupportInitialize).EndInit()
        CType(JohnOfDeath, ComponentModel.ISupportInitialize).EndInit()
        CType(FirstEnemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Plat, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(Platter, ComponentModel.ISupportInitialize).EndInit()
        CType(Floor, ComponentModel.ISupportInitialize).EndInit()
        CType(JumpBoost, ComponentModel.ISupportInitialize).EndInit()
        CType(Roof, ComponentModel.ISupportInitialize).EndInit()
        CType(LeftWall, ComponentModel.ISupportInitialize).EndInit()
        CType(RightWall, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        DeathMessage.ResumeLayout(False)
        CType(Trophy, ComponentModel.ISupportInitialize).EndInit()
        WinScreen.ResumeLayout(False)
        CType(PictureBox17, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WideEnemy As PictureBox
    Friend WithEvents JohnOfDeath As PictureBox
    Friend WithEvents FirstEnemy As PictureBox
    Friend WithEvents Plat As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Platter As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Floor As PictureBox
    Friend WithEvents JumpBoost As PictureBox
    Friend WithEvents JumpTimer As Timer
    Friend WithEvents Roof As PictureBox
    Friend WithEvents LeftWall As PictureBox
    Friend WithEvents RightWall As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents DeathMessage As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents Start As Label
    Friend WithEvents GravityTimer As Timer
    Friend WithEvents Trophy As PictureBox
    Friend WithEvents WinScreen As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PlayAgainButton As Button
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox

End Class
