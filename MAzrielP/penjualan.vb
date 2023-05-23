Public Class penjualan
    Sub kondisiAwal()
        Call connectionThree()
        Da = New SqlClient.SqlDataAdapter("Select *from barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView1.DataSource = Ds.Tables("barang")

    End Sub

    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Visible = False
        kondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call connectionThree()
        Cmd = New SqlClient.SqlCommand("Select * From barang Where kode_barcode ='" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call connectionThree()
            Da = New SqlClient.SqlDataAdapter("Select *from barang where kode_barcode = '" & TextBox1.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "barang")
            DataGridView1.DataSource = Ds.Tables("barang")
            Button3.Visible = True
            Call connectionThree()
            Cmd = New SqlClient.SqlCommand("Select harga From barang Where kode_barcode ='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
        Else
            MessageBox.Show("BarangTidak Di Temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call kondisiAwal()
        Button3.Visible = False
    End Sub
End Class