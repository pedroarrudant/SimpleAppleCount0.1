Public Class Form1

    Private Sub BtnqntdMacas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnqntdMacas.Click
        Dim Valor As Double
        Valor = Convert.ToDouble(TxtqntdMacas.Text)
        If Valor > 12 Then
            LblvalorMacas.Text = Valor.ToString("F")
            PctMaca.Image = My.Resources.Maca
        Else
            Valor = Valor * 1.3
            LblvalorMacas.Text = Valor.ToString("F")
            PctMaca.Image = My.Resources.Maca
        End If
    End Sub

    Private Sub Btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsair.Click
        End
    End Sub

    Private Sub PctMaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PctMaca.Click

    End Sub
End Class
