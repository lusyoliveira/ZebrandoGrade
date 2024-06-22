Public Class Form1

    Private Sub btnPreencher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreencher.Click
        Dim x, z As Integer
        For x = 0 To 10

            Grade.Rows.Add()

            Grade.Item(1, x).Value = x
            For z = 0 To Grade.ColumnCount - 1
                If x Mod 2 = 0 Then
                    Grade.Rows(x).Cells(z).Style.BackColor = Color.LightGray
                Else
                    Grade.Rows(x).Cells(z).Style.BackColor = Color.White
                End If
            Next
        Next
    End Sub
End Class
