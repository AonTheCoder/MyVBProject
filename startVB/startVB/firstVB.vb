Public Class firstVB

    Private Sub btcal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcal.Click
        txtresult.Text = Val(txthour.Text) * Val(txtpay.Text)

    End Sub

    Private Sub btclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Me.Close()
    End Sub
End Class
