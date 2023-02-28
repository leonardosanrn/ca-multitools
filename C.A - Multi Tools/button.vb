Imports System.Drawing.Drawing2D

Class Adjustments


    Public Shared ReadOnly DefaultFontFamily As FontFamily = New FontFamily("Tahoma")


    Public Shared ReadOnly Roundness As Integer = 4

End Class

Class DrawingHelper

    Enum RoundingStyle
        All
        Top
        Bottom
        Left
        Right
    End Enum

    Public Function RoundRect(ByVal rect As Rectangle, ByVal slope As Integer, Optional ByVal style As RoundingStyle = RoundingStyle.All) As GraphicsPath

        Dim gp As GraphicsPath = New GraphicsPath()
        Dim arcWidth As Integer = slope * 2

        Select Case style
            Case RoundingStyle.All
                gp.AddArc(New Rectangle(rect.X, rect.Y, arcWidth, arcWidth), -180, 90)
                gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Y, arcWidth, arcWidth), -90, 90)
                gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 0, 90)
                gp.AddArc(New Rectangle(rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 90, 90)
            Case RoundingStyle.Top
                gp.AddArc(New Rectangle(rect.X, rect.Y, arcWidth, arcWidth), -180, 90)
                gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Y, arcWidth, arcWidth), -90, 90)
                gp.AddLine(New Point(rect.X + rect.Width, rect.Y + rect.Height), New Point(rect.X, rect.Y + rect.Height))
            Case RoundingStyle.Bottom
                gp.AddLine(New Point(rect.X, rect.Y), New Point(rect.X + rect.Width, rect.Y))
                gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 0, 90)
                gp.AddArc(New Rectangle(rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 90, 90)
            Case RoundingStyle.Left
                gp.AddArc(New Rectangle(rect.X, rect.Y, arcWidth, arcWidth), -180, 90)
                gp.AddLine(New Point(rect.X + rect.Width, rect.Y), New Point(rect.X + rect.Width, rect.Y + rect.Height))
                gp.AddArc(New Rectangle(rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 90, 90)
            Case RoundingStyle.Right
                gp.AddLine(New Point(rect.X, rect.Y + rect.Height), New Point(rect.X, rect.Y))
                gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Y, arcWidth, arcWidth), -90, 90)
                gp.AddArc(New Rectangle(rect.Width - arcWidth + rect.X, rect.Height - arcWidth + rect.Y, arcWidth, arcWidth), 0, 90)
        End Select

        gp.CloseAllFigures()

        Return gp

    End Function

    Enum ColorAdjustmentType
        Lighten
        Darken
    End Enum

    Public Function AdjustColor(ByVal c As Color, ByVal intensity As Integer, ByVal adjustment As ColorAdjustmentType, Optional ByVal keepAlpha As Boolean = True) As Color

        Dim r, g, b As Integer

        If intensity < 1 Then
            intensity = 1
        ElseIf intensity > 255 Then
            intensity = 255
        End If

        If adjustment = ColorAdjustmentType.Lighten Then
            r = IncrementValue(c.R, intensity)
            g = IncrementValue(c.G, intensity)
            b = IncrementValue(c.B, intensity)
        Else
            r = DecrementValue(c.R, intensity)
            g = DecrementValue(c.G, intensity)
            b = DecrementValue(c.B, intensity)
        End If

        If keepAlpha Then
            Return Color.FromArgb(c.A, r, g, b)
        Else
            Return Color.FromArgb(255, r, g, b)
        End If


    End Function

    Private Function IncrementValue(ByVal initialValue As Integer, ByVal intensity As Integer, Optional ByVal maximum As Integer = 255)
        If initialValue + intensity < maximum Then
            Return initialValue + intensity
        Else
            Return maximum
        End If
    End Function

    Private Function DecrementValue(ByVal initialValue As Integer, ByVal intensity As Integer, Optional ByVal minimum As Integer = 0)
        If initialValue - intensity > minimum Then
            Return initialValue - intensity
        Else
            Return minimum
        End If
    End Function

End Class

Class MultiLineHandler

    Public Function GetLines(ByVal g As Graphics, ByVal str As String, ByVal font As Font, ByVal maxLength As Integer) As List(Of String)

        Dim result As New List(Of String)
        Dim sb As New System.Text.StringBuilder

        str = str.Replace(vbCr, "").Replace(vbLf, "")

        Dim words As String()
        If str.Contains(" ") Then
            words = str.Replace(Environment.NewLine, Nothing).Split(" ")
        Else
            result.Add(str)
            Return result
        End If

        For i = 0 To words.Count - 1

            If i = words.Count - 1 Then
                If g.MeasureString(sb.ToString & " " & words(i), font).Width < maxLength Then
                    sb.Append(words(i))
                    result.Add(sb.ToString())
                Else
                    result.Add(sb.ToString())
                    result.Add(words(i))
                End If
            ElseIf g.MeasureString(sb.ToString & " " & words(i), font).Width > maxLength Then
                result.Add(sb.ToString())
                sb.Clear()
                sb.Append(words(i) & " ")
            Else
                sb.Append(words(i) & " ")
            End If

        Next

        Return result

    End Function

End Class

Class ProDescriptiveButton
    Inherits Control

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.HighQuality
        g.Clear(Parent.BackColor)

        Dim dh As New DrawingHelper
        Dim mlh As New MultiLineHandler
        Dim slope As Integer = Adjustments.Roundness

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim mainPath As GraphicsPath = dh.RoundRect(mainRect, slope)

        Dim backCB As New ColorBlend(3)
        backCB.Colors = {Color.DimGray, Color.DimGray, Color.FromArgb(77, 77, 77)}
        backCB.Positions = {0.0, 0.75, 1.0}
        Dim backLGB As New LinearGradientBrush(mainRect, Color.Gray, Color.Gray, 90.0F)
        backLGB.InterpolationColors = backCB
        g.FillPath(backLGB, mainPath)

        Dim textBrush As New SolidBrush(Color.FromArgb(255, 255, 255))

        If _image IsNot Nothing Then
            Dim imageRect As New Rectangle(12, 12, 48, 48)
            g.DrawImage(_image, imageRect)
            g.DrawString(_title, _titleFont, textBrush, New Point(12 + 48 + 4, 12 + (48 / 2) - (g.MeasureString(_title, _titleFont).Height / 2)))
        Else
            g.DrawString(_title, _titleFont, textBrush, New Point(12, 12 + (48 / 2) - (g.MeasureString(_title, _titleFont).Height / 2)))
        End If

        Dim descY As Integer = 12 + 48 + 14
        textBrush = New SolidBrush(Color.FromArgb(255, 255, 255))

        For Each line As String In mlh.GetLines(g, Text, Font, Width - 24)
            g.DrawString(line, Font, textBrush, New Point(12, descY))
            descY += 13
        Next

        If state = MouseState.Over Then
            g.FillPath(New SolidBrush(Color.FromArgb(10, Color.Black)), mainPath)
        ElseIf state = MouseState.Down Then
            g.FillPath(New SolidBrush(Color.FromArgb(18, Color.Black)), mainPath)
        End If

        Dim borderLGB As New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.DarkGray, Color.DarkGray, 90.0F)
        g.DrawPath(New Pen(borderLGB), mainPath)

    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        Font = New Font(Adjustments.DefaultFontFamily, 8)
        Size = New Size(200, 130)
        Cursor = Cursors.Hand
    End Sub

    Private _image As Image
    Public Property Image As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            _image = value
            Invalidate()
        End Set
    End Property

    Private _title As String = "Title"
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            Invalidate()
        End Set
    End Property

    Private _titleFont As Font = New Font(Adjustments.DefaultFontFamily, 14)
    Public Property TitleFont As Font
        Get
            Return _titleFont
        End Get
        Set(value As Font)
            _titleFont = value
            Invalidate()
        End Set
    End Property

    Enum MouseState
        None
        Over
        Down
    End Enum

    Private state As MouseState = MouseState.None

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        state = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        state = MouseState.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        state = MouseState.Down
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        state = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnFontChanged(e As EventArgs)
        MyBase.OnFontChanged(e)
        Font = New Font(Font.FontFamily, 8)
    End Sub

End Class

