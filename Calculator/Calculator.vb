Public Class Calculator

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click

        Try
            Dim val1 As Decimal = CDec(txtAddVal1.Text)
            Dim val2 As Decimal = CDec(txtAddVal2.Text)

            Dim sum As Decimal = val1 + val2

            txtSum.Text = CStr(sum)

        Catch ex As Exception

            MessageBox.Show("There was an error, please re-enter numbers", "Error")



        End Try
    End Sub

    Private Sub btnSubValues_Click(sender As Object, e As EventArgs) Handles btnSubValues.Click

        Try
            Dim val1 As Decimal = CDec(txtSubVal1.Text)
            Dim val2 As Decimal = CDec(txtSubVal2.Text)

            Dim difference As Decimal = val1 - val2

            txtDifference.Text = CStr(difference)

        Catch ex As Exception

            MessageBox.Show("There was an error, please re-enter numbers", "Error")



        End Try

    End Sub

    Private Sub btnMulValues_Click(sender As Object, e As EventArgs) Handles btnMulValues.Click

        Try
            Dim val1 As Decimal = CDec(txtMulVal1.Text)
            Dim val2 As Decimal = CDec(txtMulVal2.Text)

            Dim product As Decimal = val1 * val2

            txtProduct.Text = CStr(product)

        Catch ex As Exception

            MessageBox.Show("There was an error, please re-enter numbers", "Error")



        End Try

    End Sub

    Private Sub btnDivValues_Click(sender As Object, e As EventArgs) Handles btnDivValues.Click

        Try
            Dim val1 As Decimal = CDec(txtDivVal1.Text)
            Dim val2 As Decimal = CDec(txtDivVal2.Text)

            Dim quotient As Decimal = val1 / val2

            txtQuotient.Text = CStr(quotient)

        Catch ex As Exception

            MessageBox.Show("There was an error, please re-enter numbers", "Error")



        End Try

    End Sub


    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click

        lblCalcTitle.Text = (txtUserName.Text + "'s Calculator")

        lblCalcTitle.Left = (lblCalcTitle.Parent.Width \ 2) - (lblCalcTitle.Width \ 2)


    End Sub
End Class
