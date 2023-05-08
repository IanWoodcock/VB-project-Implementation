Public Class Form1
    Dim tipAmount As Decimal
    Dim strBill As String
    Dim decBill As Decimal
    Dim iNeedALoop As Boolean = True
    Dim blnBillIsValid As Boolean





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTipYes_Click(sender As Object, e As EventArgs) Handles btnTipYes.Click
        grpbxOptions.Visible = True
        lblBill.Visible = True
        txtBill.Visible = True
        btnCalculate.Visible = True
        btnTipNo.Visible = False
        btnTipYes.Visible = False
        lblPrompt.Text = "Tip Amount?"

    End Sub

    Private Sub btnTipNo_Click(sender As Object, e As EventArgs) Handles btnTipNo.Click
        lblPrompt.Text = "Thank You"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ComputeTipAmount()
        ComputeTotalCost()
        lblTipAmount.Visible = True
        lblTotalCost.Visible = True



    End Sub

    Private Function validateTip() As Boolean
        Dim blnValid As Boolean = False
        Dim strCustomTip As String
        Dim decCustomTip As Decimal
        strCustomTip = txtCustomTip.Text
        Try
            decCustomTip = Convert.ToDecimal(strCustomTip)
            If decCustomTip > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter an amount greater than $0.00", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Error")

        End Try
        txtCustomTip.Focus()
        txtCustomTip.Clear()
        Return blnValid
    End Function

    Private Function validateBill() As Boolean
        Dim blnValid As Boolean = False
        Dim strBill As String
        Dim DecBill As Decimal
        strBill = txtBill.Text
        Try
            DecBill = Convert.ToDecimal(strBill)
            If DecBill > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter an amount greater than $0.00", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Error")

        End Try
        txtBill.Focus()
        txtBill.Clear()
        Return blnValid
    End Function

    Private Function ComputeTipAmount()
        Dim blnTipIsValid As Boolean
        Dim strCustomTip As String
        Dim decCustomTip As Decimal

        blnBillIsValid = validateBill()
        If blnBillIsValid = True Then

            strBill = txtBill.Text
            decBill = Convert.ToDecimal(strBill)
            If rbtn15.Checked = True Then
                tipAmount = decBill * 0.15
            ElseIf rbtn20.Checked = True Then
                tipAmount = decBill * 0.2
            ElseIf rbtn25.Checked = True Then
                tipAmount = decBill * 0.25
            ElseIf rbtnCustom.Checked = True Then
                blnTipIsValid = validateTip()
                If blnTipIsValid = True Then
                    strCustomTip = txtCustomTip.Text
                    decCustomTip = Convert.ToDecimal(strCustomTip)
                    tipAmount = decCustomTip
                    'tipAmount = Convert.ToDecimal(txtCustomTip.Text)
                End If
            End If
        End If
        lblTipAmount.Text = "Tip Amount: " & tipAmount.ToString("C2")
        Return tipAmount
        Return blnBillIsValid
    End Function

    Private Function ComputeTotalCost()
        While iNeedALoop = True
            Dim totalCost As Decimal
            If blnBillIsValid = True Then
            strBill = txtBill.Text
            decBill = Convert.ToDecimal(strBill)
            totalCost = decBill + tipAmount
        End If
        lblTotalCost.Text = "Total Cost: " & totalCost.ToString("C2")
            Return totalCost
            iNeedALoop = False
        End While
    End Function

End Class
