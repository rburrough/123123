Public Class Form1

  Dim _TaxRate As Decimal = 0
  Dim _Value As Decimal = 0
  Dim _Final As Decimal = 0

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Try
      _TaxRate = CDec(TextBox1.Text) / 100
      _TaxRate += 1
      _Value = CDec(TextBox2.Text)

      _Final = _Value / _TaxRate

      Label3.Text = "You should input: " + _Final.ToString("C")

    Catch ex As Exception

    End Try




  End Sub
End Class
