Public Class Form1

    Dim mouse As Boolean = False
    Dim radius As Integer = 1
    Dim xPos As Integer
    Dim yPos As Integer
    Dim PxPos As Integer
    Dim PyPos As Integer
    Dim MyBrush As New SolidBrush(Color.Black)


    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        X.Text = Me.MousePosition.X
        Y.Text = Me.MousePosition.Y

        PxPos = xPos
        PyPos = yPos

        xPos = Me.MousePosition.X - Me.Location.X - 15
        yPos = Me.MousePosition.Y - Me.Location.Y - 40

        'x - 15, y - 40

        Dim mouseDown As Integer = MouseButtons

        If mouse = True Then
            draw.DrawLine(New Pen(MyBrush, radius), PxPos, PyPos, xPos, yPos)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouse = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouse = False
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            radius += 1
        Else
            radius -= 1
        End If
        radius += 1
        If radius < 1 Then
            radius = 1
        End If
        If radius > 20 Then
            radius = 20
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        radius = 1
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ColorSelect.Click
        ColorDialog1.ShowDialog()
        MyBrush.Color = ColorDialog1.Color
    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        MsgBox("This is the X-coordinate.")
    End Sub

    Private Sub Y_Click(sender As Object, e As EventArgs) Handles Y.Click
        MsgBox("This is the Y-coordinate.")
    End Sub


End Class
