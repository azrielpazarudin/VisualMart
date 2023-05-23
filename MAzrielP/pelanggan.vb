Public Class pelanggan

    Sub kondisiAwal()
        Call connectionTwo()
        Da = New SqlClient.SqlDataAdapter("Select * From pelanggan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pelanggan")
        DataGridView1.DataSource = Ds.Tables("pelanggan")

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        Panel1.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Kode.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connectionTwo()
        If Kode.Text = "" And Nama.Text = "" And Alamat.Text = "" And Telepon.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim ganti As String = "Insert into pelanggan values('" & Kode.Text & "','" & Nama.Text & "','" & Alamat.Text & "','" & Telepon.Text & "')"
            Cmd = New SqlClient.SqlCommand(ganti, Conn)
            Cmd.ExecuteNonQuery()
            Call kondisiAwal()
            MessageBox.Show("Berhasil Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Nama.Clear()
            Alamat.Clear()
            Kode.Clear()
            Telepon.Clear()
            Kode.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True
        Button6.Visible = True
        Button8.Visible = False
        TextBox1.Focus()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nama.Clear()
        Alamat.Clear()
        Kode.Clear()
        Telepon.Clear()
        Kode.Focus()
    End Sub

    Private Sub Tukar_Click(sender As Object, e As EventArgs) Handles Tukar.Click
        Call connectionTwo()
        Cmd = New SqlClient.SqlCommand("Select kode From pelanggan Where kode ='" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Panel1.Visible = False
            Label1.Visible = False
            Kode.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True

            Nama.Focus()
            'Cmd = New SqlClient.SqlCommand("Update pelanggan set kode ='" & TextBox2.Text & "'", Conn)
        Else
            MessageBox.Show("Kode Pelanggan Tidak Di Temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Kode.Focus()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Tukar.Click
        Panel1.Visible = False
    End Sub

    Private Sub Kode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kode.KeyPress
        If e.KeyChar = Chr(13) Then
            Nama.Focus()
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Kode_TextChanged(sender As Object, e As EventArgs) Handles Kode.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = False
        Kode.Focus()
    End Sub

    Private Sub Nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nama.KeyPress
        If e.KeyChar = Chr(13) Then
            Alamat.Focus()
        End If
    End Sub
    Private Sub Alamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Alamat.KeyPress
        If e.KeyChar = Chr(13) Then
            Telepon.Focus()
        End If
    End Sub
    Private Sub Telepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Telepon.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Call connectionTwo()
        Dim rubah As String
        If Alamat.Text = "" And Telepon.Text = "" Then
            rubah = "Update pelanggan set nama ='" & Nama.Text & "'where kode ='" & TextBox1.Text & "'"
        ElseIf Nama.Text = "" And Telepon.Text = "" Then
            rubah = "Update pelanggan set alamat ='" & Alamat.Text & "'where kode ='" & TextBox1.Text & "'"
        ElseIf Nama.Text = "" And Alamat.Text = "" Then
            rubah = "Update pelanggan set telepon ='" & Telepon.Text & "'where kode ='" & TextBox1.Text & "'"
        ElseIf Nama.Text = "" Then
            rubah = "Update pelanggan SET alamat ='" & Alamat.Text & "',telepon = '" & Telepon.Text & "'where kode ='" & TextBox1.Text & "'"
        ElseIf Alamat.Text = "" Then
            rubah = "Update pelanggan SET nama ='" & Nama.Text & "',telepon = '" & Telepon.Text & "'where kode ='" & TextBox1.Text & "'"
        ElseIf Telepon.Text = "" Then
            rubah = "Update pelanggan SET nama ='" & Nama.Text & "',alamat ='" & Alamat.Text & "'where kode ='" & TextBox1.Text & "'"
        Else
            rubah = "Update pelanggan SET nama ='" & Nama.Text & "',alamat ='" & Alamat.Text & "',telepon = '" & Telepon.Text & "'where kode ='" & TextBox1.Text & "'"
        End If
        Cmd = New SqlClient.SqlCommand(rubah, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Perubahan Berhasil")
        Call kondisiAwal()
        Panel1.Visible = False
        Label1.Visible = False
        Label1.Visible = True
        Kode.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Kode.Focus()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = True
        Label6.Visible = True
        Button6.Visible = True
        Button8.Visible = True


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call connectionTwo()
        Cmd = New SqlClient.SqlCommand("Select kode From pelanggan Where kode ='" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Panel1.Visible = False
            Label1.Visible = False
            Kode.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = True
            Button6.Visible = True
            Call connectionTwo()
            Dim apus As String = "Delete From pelanggan Where kode ='" & TextBox1.Text & "'"
            Cmd = New SqlClient.SqlCommand(apus, Conn)
            Cmd.ExecuteNonQuery()
            Call kondisiAwal()
            Nama.Focus()
            'Cmd = New SqlClient.SqlCommand("Update pelanggan set kode ='" & TextBox2.Text & "'", Conn)
        Else
            MessageBox.Show("Kode Pelanggan Tidak Di Temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Panel1.Visible = False
        Label1.Visible = False
        Label1.Visible = True
        Kode.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Kode.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.Hide()
        user.Show()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        MessageBox.Show("Anda Ada Di Menu Ini", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Hide()
        pemasok.Show()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Hide()
        kelompok.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        satuan.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        pembelian.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        penjualan.Show()
    End Sub
End Class