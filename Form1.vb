Public Class Form1
    'Variables for mathmatical operations
    Dim a As Double
    Dim total As Double = 0
    Dim lastNumClicked As Double
    Dim tempTotal As Double
    'Variable to track supplied operator
    Dim symbol As String = ""
    'tracking what buttons were clicked last using booleans, was going to use click events but this approach seemed like I would be able to get it going more quickly.
    Dim equalsClicked As Boolean = False
    Dim plusClicked As Boolean = False
    Dim minusClicked As Boolean = False
    Dim numClicked As Boolean = False
    Dim multiplyClicked As Boolean = False
    Dim divideClicked As Boolean = False
    Dim decimalClicked As Boolean = False
    Dim lastOperatorClicked As String = ""
    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "1"
        plusClicked = False
        numClicked = True
        lastNumClicked = 1
    End Sub

    Private Sub num2_Click(sender As Object, e As EventArgs) Handles num2.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "2"
        plusClicked = False
        numClicked = True
        lastNumClicked = 2
    End Sub

    Private Sub num3_Click(sender As Object, e As EventArgs) Handles num3.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "3"
        plusClicked = False
        numClicked = True
        lastNumClicked = 3
    End Sub

    Private Sub num4_Click(sender As Object, e As EventArgs) Handles num4.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "4"
        plusClicked = False
        numClicked = True
        lastNumClicked = 4
    End Sub

    Private Sub num5_Click(sender As Object, e As EventArgs) Handles num5.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "5"
        plusClicked = False
        numClicked = True
        lastNumClicked = 5
    End Sub

    Private Sub num6_Click(sender As Object, e As EventArgs) Handles num6.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "6"
        plusClicked = False
        numClicked = True
        lastNumClicked = 6
    End Sub

    Private Sub num7_Click(sender As Object, e As EventArgs) Handles num7.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "7"
        plusClicked = False
        numClicked = True
        lastNumClicked = 7
    End Sub

    Private Sub num8_Click(sender As Object, e As EventArgs) Handles num8.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "8"
        plusClicked = False
        numClicked = True
        lastNumClicked = 8
    End Sub

    Private Sub num9_Click(sender As Object, e As EventArgs) Handles num9.Click
        If plusClicked = True And decimalClicked = False Or minusClicked = True And decimalClicked = False Or multiplyClicked = True And decimalClicked = False Or divideClicked = True And decimalClicked = False Then
            lblDisplay.Text = ""
        End If
        lblDisplay.Text += "9"
        plusClicked = False
        numClicked = True
        lastNumClicked = 9
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        If equalsClicked = True Then
            lblDisplay.Text = ""
            plusClicked = True
            equalsClicked = False
            numClicked = False
            symbol = "+"
        End If
        If equalsClicked = False And lblDisplay.Text IsNot "" And numClicked = True And lastOperatorClicked = "-" Then
            tempTotal = lblDisplay.Text
            total -= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "+"
            lblDisplay.Text = total
            plusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lastOperatorClicked = "*" Then
            tempTotal = lblDisplay.Text
            total *= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "+"
            lblDisplay.Text = total
            plusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lastOperatorClicked = "/" Then
            tempTotal = lblDisplay.Text
            total /= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "/"
            lblDisplay.Text = total
            plusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If equalsClicked = False And lblDisplay.Text IsNot "" And numClicked = True Then
            a = lblDisplay.Text
            tempTotal = lblDisplay.Text
            lblDisplay.Text = ""
            total += Double.Parse(a)
            symbol = "+"
            lblDisplay.Text = total
            plusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If equalsClicked = False And lblDisplay.Text IsNot "" And numClicked = False And plusClicked = False Then
            a = lblDisplay.Text
            tempTotal = lblDisplay.Text
            lblDisplay.Text = ""
            total += Double.Parse(tempTotal)
            symbol = "+"
            lblDisplay.Text = total
            plusClicked = True
            equalsClicked = False
            numClicked = False
        End If

        lastOperatorClicked = "+"
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        If equalsClicked = True Then
            symbol = "-"
            minusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If equalsClicked = False And lblDisplay.Text IsNot "" And numClicked = True And lastOperatorClicked = "+" Then
            tempTotal = lblDisplay.Text
            total += Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "-"
            lblDisplay.Text = total
            minusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lblDisplay.Text IsNot "" And lastOperatorClicked = "*" Then
            tempTotal = lblDisplay.Text
            total *= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "-"
            lblDisplay.Text = total
            minusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lblDisplay.Text IsNot "" And lastOperatorClicked = "/" Then
            tempTotal = lblDisplay.Text
            total /= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "-"
            lblDisplay.Text = total
            minusClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If equalsClicked = False And lblDisplay.Text IsNot "" And numClicked = True And minusClicked = True Then
            a = lblDisplay.Text
            tempTotal = lblDisplay.Text
            lblDisplay.Text = ""
            total -= Double.Parse(tempTotal)
            symbol = "-"
            lblDisplay.Text = total
            equalsClicked = False
            numClicked = False
        End If
        If minusClicked = False And total = 0 And numClicked = True Then
            total = Double.Parse(lblDisplay.Text)
            minusClicked = True
            symbol = "-"
        End If

        lastOperatorClicked = "-"
    End Sub

    Private Sub times_Click(sender As Object, e As EventArgs) Handles times.Click
        If equalsClicked = True Then
            multiplyClicked = True
            equalsClicked = False
            numClicked = False
            symbol = "*"
        End If
        If numClicked = True And lastOperatorClicked = "+" Then
            tempTotal = lblDisplay.Text
            total += Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "*"
            lblDisplay.Text = total
            multiplyClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lastOperatorClicked = "-" Then
            tempTotal = lblDisplay.Text
            total -= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "*"
            lblDisplay.Text = total
            multiplyClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lastOperatorClicked = "/" Then
            tempTotal = lblDisplay.Text
            total /= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "/"
            lblDisplay.Text = total
            multiplyClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If equalsClicked = False And multiplyClicked = True And lblDisplay.Text IsNot "" And numClicked = True Then
            tempTotal = lblDisplay.Text
            lblDisplay.Text = ""
            total *= Double.Parse(tempTotal)
            symbol = "*"
            lblDisplay.Text = total
            multiplyClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If multiplyClicked = False And total = 0 And numClicked = True Then
            total = Double.Parse(lblDisplay.Text)
            multiplyClicked = True
            numClicked = False
            symbol = "*"
        End If
        If multiplyClicked = True And decimalClicked = True Then
            lblDisplay.Text = ""
        End If

        lastOperatorClicked = "*"
    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        If equalsClicked = True Then
            divideClicked = True
            equalsClicked = False
            numClicked = False
            symbol = "/"
        End If
        If numClicked = True And lastOperatorClicked = "+" Then
            tempTotal = lblDisplay.Text
            total += Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "/"
            lblDisplay.Text = total
            divideClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lastOperatorClicked = "-" Then
            tempTotal = lblDisplay.Text
            total -= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "/"
            lblDisplay.Text = total
            divideClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If numClicked = True And lastOperatorClicked = "*" Then
            tempTotal = lblDisplay.Text
            total *= Double.Parse(tempTotal)
            lblDisplay.Text = ""
            symbol = "/"
            lblDisplay.Text = total
            divideClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If equalsClicked = False And divideClicked = True And lblDisplay.Text IsNot "" And numClicked = True Then
            tempTotal = lblDisplay.Text
            lblDisplay.Text = ""
            total /= Double.Parse(tempTotal)
            symbol = "/"
            lblDisplay.Text = total
            divideClicked = True
            equalsClicked = False
            numClicked = False
        End If
        If divideClicked = False And total = 0 And numClicked = True Then
            total = Double.Parse(lblDisplay.Text)
            divideClicked = True
            numClicked = False
            symbol = "/"
        End If
        lastOperatorClicked = "/"
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        Select Case symbol
            Case "+"
                If lblDisplay.Text IsNot "" And plusClicked = False And numClicked = True And equalsClicked = True Then
                    a = lblDisplay.Text
                    total += Double.Parse(tempTotal)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
                If equalsClicked = False And lblDisplay.Text IsNot "" And plusClicked = False Then
                    a = lblDisplay.Text
                    tempTotal = a
                    total += Double.Parse(a)
                    lblDisplay.Text = total
                    equalsClicked = True
                    plusClicked = False
                End If
                If lblDisplay.Text IsNot "" And plusClicked = True And numClicked = True And decimalClicked = True Then
                    total += Double.Parse(lblDisplay.Text)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
                If lblDisplay.Text IsNot "" And plusClicked = True And decimalClicked = False Then
                    total += Double.Parse(lblDisplay.Text)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If


            Case "-"
                If lblDisplay.Text IsNot "" And minusClicked = True And decimalClicked = False Then
                    a = lblDisplay.Text
                    total -= a
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
                If lblDisplay.Text IsNot "" And minusClicked = False And numClicked = True And equalsClicked = True Then
                    a = lblDisplay.Text
                    total -= Double.Parse(tempTotal)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
                If lblDisplay.Text IsNot "" And minusClicked = True And numClicked = True And decimalClicked = True Then
                    total -= Double.Parse(lblDisplay.Text)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If

            Case "/"
                If lblDisplay.Text IsNot "" And divideClicked = False And numClicked = True And equalsClicked = True Then
                    a = lblDisplay.Text
                    total /= Double.Parse(tempTotal)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
                If equalsClicked = False And lblDisplay.Text IsNot "" And divideClicked = False Then
                    a = lblDisplay.Text
                    tempTotal = a
                    total /= Double.Parse(a)
                    lblDisplay.Text = total
                    equalsClicked = True
                    divideClicked = False
                End If
                If lblDisplay.Text IsNot "" And divideClicked = True Then
                    a = lblDisplay.Text
                    total /= a
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
            Case "*"
                If lblDisplay.Text IsNot "" And multiplyClicked = False And numClicked = True And equalsClicked = True Then
                    a = lblDisplay.Text
                    total *= Double.Parse(tempTotal)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
                If equalsClicked = False And lblDisplay.Text IsNot "" And multiplyClicked = False Then
                    a = lblDisplay.Text
                    tempTotal = a
                    total *= Double.Parse(a)
                    lblDisplay.Text = total
                    equalsClicked = True
                    multiplyClicked = False
                End If
                If lblDisplay.Text IsNot "" And multiplyClicked = True And decimalClicked = True Then
                    a = lblDisplay.Text
                    total *= Double.Parse(a)
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
                If lblDisplay.Text IsNot "" And multiplyClicked = True And decimalClicked = False Then
                    a = lblDisplay.Text
                    total *= a
                    lblDisplay.Text = total
                    equalsClicked = True
                End If
        End Select
    End Sub

    Private Sub num0_Click(sender As Object, e As EventArgs) Handles num0.Click
        lblDisplay.Text += "0"
    End Sub

    Private Sub deci_Click(sender As Object, e As EventArgs) Handles deci.Click
        lblDisplay.Text += "."
        If plusClicked = True Or minusClicked = True Or multiplyClicked = True Or divideClicked = True Then
            lblDisplay.Text = ""
            lblDisplay.Text += "."
            decimalClicked = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplay.Text = ""
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        lblDisplay.Text = ""
        lastOperatorClicked = ""
        symbol = ""
        total = 0
        tempTotal = 0
        a = 0
        numClicked = False
        plusClicked = False
        minusClicked = False
        equalsClicked = False
        multiplyClicked = False
        divideClicked = False
        decimalClicked = False
    End Sub
End Class
