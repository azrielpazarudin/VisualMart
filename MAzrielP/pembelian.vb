Public Class pembelian
    Sub kondisiAwal()
        Call connectionThree()
        Da = New SqlClient.SqlDataAdapter("Select *from barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView1.DataSource = Ds.Tables("barang")

    End Sub

    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub
End Class