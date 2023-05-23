Public Class gantipassword

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Call connection()
        Cmd = New SqlClient.SqlCommand("Select Password From Akun Where Password ='" & SandiLama.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call connection()
            Dim ganti As String = "Update Akun SET Password ='" & SandiBaru.Text & "' where Password ='" & SandiLama.Text & "'"
            Cmd = New SqlClient.SqlCommand(ganti, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Sandi Berhasil Di Rubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
            SandiLama.Clear()
            SandiBaru.Clear()
            home.Show()
        Else
            MessageBox.Show("Password Lama Salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SandiLama.Clear()
            SandiBaru.Clear()
        End If
        Rd.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        SandiLama.Focus()
    End Sub


    Private Sub SandiLama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SandiLama.KeyPress
        If e.KeyChar = Chr(13) Then
            SandiBaru.Focus()
        End If

    End Sub

    Private Sub SandiBaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SandiBaru.KeyPress
        If e.KeyChar = Chr(13) Then
            Save.Focus()
        End If
    End Sub
End Class