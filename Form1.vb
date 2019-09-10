Public Class Form1
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxAdd.Clear()
        txtBoxList.Clear()
        txtBoxAdd.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'txtBoxList.Text = txtBoxList.Text & txtBoxAdd.Text & ControlChars.CrLf
        'txtBoxList.Text = txtBoxList.Text & txtBoxAdd.Text & Environment.NewLine
        'txtBoxList.Text = txtBoxList.Text & txtBoxAdd.Text & Chr(13) & Chr(10)
        txtBoxList.Text = txtBoxList.Text & txtBoxAdd.Text + vbCrLf
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Shopping List", New Font("arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 25, 25)
        e.Graphics.DrawString("______________", New Font("arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 25, 50)
        e.Graphics.DrawString(txtBoxList.Text, New Font("arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 25, 75)
    End Sub
End Class
