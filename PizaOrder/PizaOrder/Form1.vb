Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPizzaVariety.Items.Add("Hawaiian")
        cboPizzaVariety.Items.Add("Pepperoni")
        cboPizzaVariety.Items.Add("Bacon and Ham")

        lbSizeOfPizza.Items.Add("Small")
        lbSizeOfPizza.Items.Add("Medium")
        lbSizeOfPizza.Items.Add("Large")
    End Sub

    Private Sub cboPizzaVariety_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizzaVariety.SelectedIndexChanged
        lblOutputVariety.Text = cboPizzaVariety.Text
    End Sub

    Private Sub lbSizeOfPizza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSizeOfPizza.SelectedIndexChanged
        lblOutputSize.Text = lbSizeOfPizza.Text
    End Sub

    Private Sub rdbThickCrust_CheckedChanged(sender As Object, e As EventArgs) Handles rdbThickCrust.CheckedChanged
        lblOutputCrust.Text = rdbThickCrust.Text
    End Sub

    Private Sub rdbThinCrust_CheckedChanged(sender As Object, e As EventArgs) Handles rdbThinCrust.CheckedChanged
        lblOutputCrust.Text = rdbThinCrust.Text
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        cboPizzaVariety.SelectedItem = Nothing
        lbSizeOfPizza.SelectedItem = Nothing
        rdbThickCrust.Checked = False
        rdbThinCrust.Checked = False
        lblOutputCrust.Text = ""
    End Sub
End Class
