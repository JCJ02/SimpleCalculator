Public Class simpleCalcuForm


    Private Sub systemPanel1_Paint(sender As Object, e As PaintEventArgs) Handles systemPanel1.Paint
        Me.CenterToScreen() 'To Center the system.

    End Sub

    'Exit or Close Button
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Hide()

    End Sub



    'Addition Button
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click

        'Variables
        Dim numberOne = Val(firstNumInput.Text)
        Dim numberTwo = Val(secNumInput.Text)

        'Addition Formula
        Dim results = numberOne + numberTwo

        'To display the results
        resultaInput.Text = results


    End Sub

    'Subtraction Button
    Private Sub subBtn_Click(sender As Object, e As EventArgs) Handles subBtn.Click

        'Variables
        Dim numberOne = Val(firstNumInput.Text)
        Dim numberTwo = Val(secNumInput.Text)


        'Addition Formula
        Dim results = numberOne - numberTwo

        'To display the results
        resultaInput.Text = results


    End Sub

    'Multiplication Button
    Private Sub multiBtn_Click(sender As Object, e As EventArgs) Handles multiBtn.Click

        'Variables
        Dim numberOne = Val(firstNumInput.Text)
        Dim numberTwo = Val(secNumInput.Text)


        'Addition Formula
        Dim results = numberOne * numberTwo

        'To display the results
        resultaInput.Text = results


    End Sub

    'Division Button
    Private Sub divBtn_Click(sender As Object, e As EventArgs) Handles divBtn.Click

        'Variables
        Dim numberOne = Val(firstNumInput.Text)
        Dim numberTwo = Val(secNumInput.Text)

        'Addition Formula
        Dim results = numberOne / numberTwo

        'To display the results
        resultaInput.Text = results

    End Sub

    'Reset Button
    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click

        firstNumInput.Text = ""
        secNumInput.Text = ""
        resultaInput.Text = ""

    End Sub
End Class