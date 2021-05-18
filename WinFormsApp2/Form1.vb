Public Class Form1
    Dim k As Double
    Dim d As Integer
    'd=1 - сложение
    'd=2 - вычетание
    'd=3 - сложение
    'd=4 - вычетание
    'd=5 - если степень
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.Text = "Нельзя делить на 0" Or TextBox1.Text = "" Then
        Else
            k = TextBox1.Text
            k = Math.Abs(k)
            TextBox1.Text = k
        End If

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = ""
        k = 0
        d = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "1"
            Else
                TextBox1.Text &= "1"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "1"
            End If
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "2"
            Else
                TextBox1.Text &= "2"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "2"
            End If
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "3"
            Else
                TextBox1.Text &= "3"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "3"
            End If
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "4"
            Else
                TextBox1.Text &= "4"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "4"
            End If
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "5"
            Else
                TextBox1.Text &= "5"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "5"
            End If
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "6"
            Else
                TextBox1.Text &= "6"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "6"
            End If
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "7"
            Else
                TextBox1.Text &= "7"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "7"
            End If
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "8"
            Else
                TextBox1.Text &= "8"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "8"
            End If
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            If TextBox1.Text = "Нельзя делить на 0" Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
                TextBox1.Text = "9"
            Else
                TextBox1.Text &= "9"
            End If
        Catch ex As Exception
            If TextBox1.Text = "" Then
                TextBox1.Text = "9"
            End If
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text = "Нельзя делить на 0" Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Or TextBox1.Text = "тестерам тут не рады" Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text = "-" Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Not TextBox1.Text = "" And Not TextBox1.Text = "+" Then
            Try
                k = TextBox1.Text
                TextBox1.Text = ""
                d = 1
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Select Case d
            Case = 1
                'Если сложение

                If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
                    TextBox1.Text = k + TextBox1.Text
                End If
            Case = 2
                'Если вычетание
                If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
                    TextBox1.Text = k - TextBox1.Text
                End If
            Case = 3
                'Если умножение
                If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
                    TextBox1.Text = k * TextBox1.Text
                End If
            Case = 4
                'Если деление
                Try
                    If k = 0 Or (TextBox1.Text.Last() <> "," And Convert.ToDouble(TextBox1.Text) = 0) Then
                        TextBox1.Text = "Нельзя делить на 0"
                    Else
                        If k = Math.PI Or TextBox1.Text = Math.PI.ToString().Replace(".", ",") Then
                            TextBox1.Text = "1" '
                        Else
                            TextBox1.Text = k / TextBox1.Text
                        End If
                    End If
                Catch ex As Exception

                End Try



            Case = 5
                'Если степень 
                If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
                    Dim answer As Double = k ^ TextBox1.Text
                    If answer = Double.PositiveInfinity Or answer = Double.NegativeInfinity Then
                        TextBox1.Text = "тестерам тут не рады"
                    Else
                        TextBox1.Text = answer
                    End If
                End If
        End Select

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Not TextBox1.Text.Contains(",") And TextBox1.Text <> "" Then
            TextBox1.Text &= ","
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Not TextBox1.Text.Contains(Math.PI.ToString().Replace(".", ",")) Then
            TextBox1.Text = Math.PI.ToString().Replace(".", ",")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
            Try
                k = TextBox1.Text
                TextBox1.Text = ""
                d = 2
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
            Try
                k = TextBox1.Text
                TextBox1.Text = ""
                d = 3
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
            Try
                k = TextBox1.Text
                TextBox1.Text = ""
                d = 4
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Not TextBox1.Text = "" And Not TextBox1.Text = "-" Then
            Try
                k = TextBox1.Text
                TextBox1.Text = ""
                d = 5
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        If TextBox1.Text = "Нельзя делить на 0" Or TextBox1.Text = "тестерам тут не рады" Or TextBox1.Text = "" Then

        Else
            k = TextBox1.Text
            If k < 1 Then
                TextBox1.Text = "тестерам тут не рады"
            Else
                k = Math.Sqrt(k)
                TextBox1.Text = k
            End If
        End If


    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "-" Then
            TextBox1.Text = ""

        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            Try
                k = TextBox1.Text
                k = k * (-1)
                TextBox1.Text = k
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "-0" Then
            TextBox1.Text = "0"
        End If
    End Sub
End Class
