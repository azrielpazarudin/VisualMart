Public Class kelompok
    Sub kondisiAwal()
        Call connectionThree()
        Da = New SqlClient.SqlDataAdapter("Select * from kelompok", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kelompok")
        DataGridView1.DataSource = Ds.Tables("kelompok")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connectionThree()
        Dim kelompok As String = "insert into kelompok values ('" & TextBox1.Text & "')"
        Cmd = New SqlClient.SqlCommand(kelompok, Conn)
        Cmd.ExecuteNonQuery()
        Call kondisiAwal()
        TextBox1.Clear()
        MessageBox.Show("Berhasil Menambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub kelompok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel14.Visible = False
        Button8.Visible = False
        Call kondisiAwal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False

    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel14.Visible = True
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel14.Visible = True
        Label2.Text = "PILIH DATA YANG AKAN DI EDIT BERDASARKAN KELOMPOK"
        Button5.Visible = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel14.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call connectionThree()
        Cmd = New SqlClient.SqlCommand("Select kelompok From kelompok Where kelompok ='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call connectionThree()
            Dim apus As String = "Delete From kelompok Where kelompok ='" & TextBox2.Text & "'"
            Cmd = New SqlClient.SqlCommand(apus, Conn)
            Cmd.ExecuteNonQuery()
            Panel14.Visible = False
            MessageBox.Show("Berhasil Hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Call kondisiAwal()
        Else
            MessageBox.Show("Kelompok Tidak Di Temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call connectionThree()
        Cmd = New SqlClient.SqlCommand("Select kelompok From kelompok Where kelompok ='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Panel14.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button8.Visible = True
        End If
       
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call connectionThree()
        Dim rubah As String = "Update kelompok SET kelompok ='" & TextBox1.Text & "' where kelompok ='" & TextBox2.Text & "'"
        Cmd = New SqlClient.SqlCommand(rubah, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Perubahan Berhasil")
        Call kondisiAwal()
        Panel14.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button8.Visible = False
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        pelanggan.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        user.Show()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Hide()
        pembelian.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Hide()
        pemasok.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        satuan.Show()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Me.Hide()
        penjualan.Show()
    End Sub
End Class