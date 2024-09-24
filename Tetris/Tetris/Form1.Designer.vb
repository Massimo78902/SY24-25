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
        Coin1 = New PictureBox()
        Enemy = New PictureBox()
        enemy2 = New PictureBox()
        Platform = New PictureBox()
        Enemy3 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(38, 304)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(141, 173)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 500
        ' 
        ' Coin1
        ' 
        Coin1.Image = CType(resources.GetObject("Coin1.Image"), Image)
        Coin1.Location = New Point(679, 38)
        Coin1.Name = "Coin1"
        Coin1.Size = New Size(85, 88)
        Coin1.SizeMode = PictureBoxSizeMode.StretchImage
        Coin1.TabIndex = 1
        Coin1.TabStop = False
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(623, 371)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(182, 173)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 2
        Enemy.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(334, 440)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(182, 173)
        enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' Platform
        ' 
        Platform.BackColor = Color.SaddleBrown
        Platform.Location = New Point(249, 215)
        Platform.Name = "Platform"
        Platform.Size = New Size(556, 61)
        Platform.TabIndex = 4
        Platform.TabStop = False
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(299, 36)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(182, 173)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 5
        Enemy3.TabStop = False
        Enemy3.Tag = "-1"
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 625)
        Controls.Add(Enemy3)
        Controls.Add(enemy2)
        Controls.Add(Enemy)
        Controls.Add(Coin1)
        Controls.Add(Avatar)
        Controls.Add(Platform)
        Name = "form1"
        Text = "Mario Vs. John"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin1, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Coin1 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents Enemy3 As PictureBox

End Class
