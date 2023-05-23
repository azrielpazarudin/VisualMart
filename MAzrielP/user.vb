Public Class user

    Sub kondisiAwal()
        Call connection()
        Da = New SqlClient.SqlDataAdapter("Select kode,namaUser,userName,status From pengguna", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pengguna")
        DataGridView1.DataSource = Ds.Tables("pengguna")

    End Sub
    Sub awal()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = True
    End Sub
    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel14.Visible = False
        Call awal()
        Button10.Visible = False
        Button11.Visible = False
        Call kondisiAwal()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        pelanggan.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        pelanggan.Show()
    End Sub

   

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connection()
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim tukar As String = "INSERT INTO AKUN values ('" & TextBox3.Text & "','" & TextBox4.Text & "')"
            Dim ganti As String = "Insert into pengguna values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')"
            Cmd = New SqlClient.SqlCommand(tukar, Conn)
            Cmd.ExecuteNonQuery()
            Cmd = New SqlClient.SqlCommand(ganti, Conn)
            Cmd.ExecuteNonQuery()
            Call kondisiAwal()
            MessageBox.Show("Berhasil Menambah Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button12.Visible = False
        Panel14.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel14.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call connection()
        Cmd = New SqlClient.SqlCommand("Select kode From pengguna Where kode ='" & TextBox5.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Panel14.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Label1.Visible = False
            TextBox1.Visible = False
            Label3.Visible = False
            TextBox3.Visible = False
            Label4.Visible = False
            TextBox4.Visible = False
            TextBox5.Clear()
            Button10.Visible = True
        Else
            MessageBox.Show("Kode Pelanggan Tidak Di Temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Call connection()
        Dim ganti As String
        If TextBox2.Text = "" Then
            ganti = "Update pengguna set status ='" & ComboBox1.Text & "'where kode ='" & TextBox5.Text & "'"
        ElseIf ComboBox1.SelectedItem = "" Then
            ganti = "Update pengguna set namaUser ='" & TextBox7.Text & "'where kode ='" & TextBox5.Text & "'"
        Else
            ganti = "Update pengguna set namaUser ='" & TextBox7.Text & "',status ='" & ComboBox1.SelectedItem & "' where  kode ='" & TextBox5.Text & "'"
        End If
        Cmd = New SqlClient.SqlCommand(ganti, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Perubahan Berhasil")
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Label1.Visible = True
        TextBox1.Visible = True
        Label3.Visible = True
        TextBox3.Visible = True
        Label4.Visible = True
        TextBox4.Visible = True
        Call kondisiAwal()  
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        kelompok.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel14.Visible = True
        Label23.Text = "PILIH DATA UNTUK DI HAPUS"
        Label25.Visible = False
        TextBox5.Clear()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call connection()
        Cmd = New SqlClient.SqlCommand("Select kode From pengguna Where kode ='" & TextBox5.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call connection()
            Dim apus As String = "Delete From pengguna Where kode ='" & TextBox5.Text & "'"
            Cmd = New SqlClient.SqlCommand(apus, Conn)
            Cmd.ExecuteNonQuery()
            Call kondisiAwal()
        Else
            MessageBox.Show("Kode Pelanggan Tidak Di Temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Hide()
        pembelian.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Hide()
        pemasok.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        satuan.Show()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then

            Call connection()
            Cmd = New SqlClient.SqlCommand("Select kode From pengguna Where kode ='" & TextBox6.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call connection()
                Da = New SqlClient.SqlDataAdapter("Select kode,namaUser,userName,status From pengguna where kode = '" & TextBox6.Text & "'", Conn)
                Ds = New DataSet
                Da.Fill(Ds, "pengguna")
                DataGridView1.DataSource = Ds.Tables("pengguna")
                MsgBox("Ini Datanya")
                Call kondisiAwal()
            Else
                MessageBox.Show("Kode Pelanggan Tidak Di Temukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Me.Hide()
        penjualan.Show()
    End Sub
End Class