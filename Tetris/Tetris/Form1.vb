Imports System.Media

Public Class form1
    Dim score As Integer
    Dim jumping As Boolean
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PaceX(FirstEnemy, Platform, 10)
        PaceX(WideEnemy, Platter, 20)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width / 2 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height / 2 Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub follow(e As PictureBox, speedx As Integer, speedy As Integer, a As PictureBox)
        If e.Location.Y > a.Location.Y Then
            move(e, 0, -speedy)
        Else
            move(e, 0, speedy)
        End If
        If e.Location.X > a.Location.X Then
            move(e, -speedx, 0)
        Else
            move(e, speedx, 0)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -15, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avatar, 15, 0)
        End If
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Or e.KeyCode = Keys.Space) And Not JumpTimer.Enabled Then
            JumpTimer.Enabled = True
            Avatar.Tag = 12
        End If
        Avatar.Refresh()

    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If
        Dim j As PictureBox
        If IntersectsWith(p, "Jump", j) Then
            j.Visible = False
        End If
        If IntersectsWith(Avatar, "Win") Then
            Trophy.Visible = False
            WinScreen.Visible = True
        End If
        If IntersectsWith(Avatar, "Enemy") Then
            Avatar.Visible = False
            DeathMessage.Visible = True
        End If
        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)

    End Sub

    Function endingWith(s As String) As Collection
        Dim coll As New Collection
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If UCase(obj.Name).EndsWith(UCase(s)) Then
                    coll.Add(obj)
                End If
            End If
        Next
        Return coll
    End Function
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        Return IntersectsWith(p, tag, Nothing)
    End Function
    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        score += 1
        ScoreLabel.Text = score
    End Sub
    Dim boost As Integer = 1
    Private Sub JumpTimer_Tick(sender As Object, e As EventArgs) Handles JumpTimer.Tick
        Dim t As Integer
        t = Avatar.Tag
        If t > 0 Then move(Avatar, 0, -5 * boost)
        If t < 0 Then move(Avatar, 0, 5 * boost)
        If t = -12 Then
            JumpTimer.Enabled = False
            GravityTimer.Enabled = True
        End If
        If JumpBoost.Visible = False Then
            boost = 4
        End If
        Avatar.Tag = t - 1
    End Sub
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub
    Private Sub Gravity_Tick(sender As Object, e As EventArgs) Handles GravityTimer.Tick
        Dim grav As Integer
        grav -= 5
        move(Avatar, 0, 5)
        If JumpTimer.Enabled = True Then
            GravityTimer.Enabled = False
        Else
            GravityTimer.Enabled = True
        End If
    End Sub
    Sub Reset(m As GroupBox)
        Avatar.Location = Start.Location
        JumpBoost.Visible = True
        Avatar.Visible = True
        m.Visible = False
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset(DeathMessage)
    End Sub

    Private Sub PlayAgainButton_Click(sender As Object, e As EventArgs) Handles PlayAgainButton.Click
        Reset(WinScreen)
    End Sub
End Class