Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ListBox1.Items.Clear()

        For A = 1 To 20

            ListBox1.Items.Add(A & " x " & Val(TextBox1.Text) & " = " & A * Val(TextBox1.Text))

        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ListBox1.Items.Clear()

        For A = 1 To 20

            ListBox1.Items.Add(A & " - " & Val(TextBox1.Text) & " = " & A - Val(TextBox1.Text))

        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        ListBox1.Items.Clear()

        For A = 1 To 20

            ListBox1.Items.Add(A & " - " & Val(TextBox1.Text) & " = " & A - Val(TextBox1.Text))

        Next

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()

        For A = 1 To 20

            ListBox1.Items.Add(A & " / " & Val(TextBox1.Text) & " = " & A / Val(TextBox1.Text))

        Next
    End Sub
End Class