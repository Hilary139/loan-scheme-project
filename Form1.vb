Public Class Form1

    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        Dim FullName As String = CStr(NameTxt.Text)
        Dim GradeLevel As Integer = CInt(GradeInt.Text)
        Dim NumYears As Integer = CInt(YearInt.Text)
        Dim LoanGrp As String = LoanList.SelectedItem
        Dim List1 As String = "CAR"
        Dim List2 As String = "MOTOCYCLE"
        Dim dtCurrent As Date = Now

        ' Evaluating the  Conditions 
        If GradeInt.Text <= 7 Then
            If LoanGrp = List1 Then
                OutputTxt.Text = "Full NAME :            " & Strings.UCase(FullName) & Environment.NewLine &
                "GRADE LEVEL :           " & GradeInt.Text & Environment.NewLine &
                "COMFIRMATION STATUS :                   " & "YES" & Environment.NewLine &
                "NUMBER OF YEARS IN SERVICE :                 " & YearInt.Text & Environment.NewLine &
                "TYPE OF LOAN :                " & LoanList.SelectedItem & Environment.NewLine &
                "AMOUNT QUALIFIED FOR :        " & "400,000" & Environment.NewLine &
                "DATE/TIME: " & dtCurrent & Environment.NewLine
            End If

        Else
            OutputTxt.Text = "Full NAME :            " & Strings.UCase(FullName) & Environment.NewLine &
                "GRADE LEVEL :           " & GradeInt.Text & Environment.NewLine &
                "COMFIRMATION STATUS :                   " & "YES" & Environment.NewLine &
                "NUMBER OF YEARS IN SERVICE :                 " & YearInt.Text & Environment.NewLine &
                "TYPE OF LOAN :                " & LoanList.SelectedItem & Environment.NewLine &
                "AMOUNT QUALIFIED FOR :          " & "2,500,000" & Environment.NewLine &
                 "DATE/TIME: " & dtCurrent & Environment.NewLine
        End If


        If GradeInt.Text <= 7 Then
            If LoanGrp = List2 Then
                OutputTxt.Text = "Full NAME :            " & Strings.UCase(FullName) & Environment.NewLine &
                "GRADE LEVEL :           " & GradeInt.Text & Environment.NewLine &
                "COMFIRMATION STATU S:                   " & "YES" & Environment.NewLine &
                "NUMBER OF YEARS IN SERVICE :                 " & YearInt.Text & Environment.NewLine &
                "TYPE OF LOAN :                " & LoanList.SelectedItem & Environment.NewLine &
                 "AMOUNT QUALIFIED FOR :          " & "200,000" & Environment.NewLine &
                  "DATE/TIME: " & dtCurrent & Environment.NewLine
            End If

        Else
            OutputTxt.Text = "Full NAME :            " & Strings.UCase(FullName) & Environment.NewLine &
                "GRADE LEVEL :           " & GradeInt.Text & Environment.NewLine &
                "COMFIRMATION STATUS:                   " & "YES" & Environment.NewLine &
                "NUMBER OF YEARS IN SERVICE :                 " & YearInt.Text & Environment.NewLine &
                "TYPE OF LOAN :                " & LoanList.SelectedItem & Environment.NewLine &
               "AMOUNT QUALIFIED FOR :          " & "350,000" & Environment.NewLine &
                "DATE/TIME: " & dtCurrent & Environment.NewLine

        End If



    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        MsgBox("THANKS FOR SUBMITTING ")
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
