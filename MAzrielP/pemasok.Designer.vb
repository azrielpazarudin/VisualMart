<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pemasok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Telepon = New System.Windows.Forms.TextBox()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelangganDataSet1 = New WindowsApplication1.pelangganDataSet1()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Tukar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PelangganTableAdapter = New WindowsApplication1.pelangganDataSet1TableAdapters.pelangganTableAdapter()
        Me.PelangganDataSet2 = New WindowsApplication1.pelangganDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PerbaranganDataSet2 = New WindowsApplication1.perbaranganDataSet2()
        Me.PemasokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PemasokTableAdapter = New WindowsApplication1.perbaranganDataSet2TableAdapters.pemasokTableAdapter()
        Me.KodepemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelangganDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PelangganDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerbaranganDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemasokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Pemasok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No.Telepon"
        '
        'Kode
        '
        Me.Kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(460, 119)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(308, 26)
        Me.Kode.TabIndex = 1
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(460, 154)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(308, 26)
        Me.Nama.TabIndex = 2
        '
        'Alamat
        '
        Me.Alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alamat.Location = New System.Drawing.Point(460, 186)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(308, 26)
        Me.Alamat.TabIndex = 3
        '
        'Telepon
        '
        Me.Telepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telepon.Location = New System.Drawing.Point(460, 218)
        Me.Telepon.Name = "Telepon"
        Me.Telepon.Size = New System.Drawing.Size(308, 26)
        Me.Telepon.TabIndex = 4
        '
        'PelangganBindingSource
        '
        Me.PelangganBindingSource.DataMember = "pelanggan"
        Me.PelangganBindingSource.DataSource = Me.PelangganDataSet1
        '
        'PelangganDataSet1
        '
        Me.PelangganDataSet1.DataSetName = "pelangganDataSet1"
        Me.PelangganDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(393, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "BATAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(524, 297)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 32)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(656, 297)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Tukar)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(332, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 199)
        Me.Panel1.TabIndex = 16
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button8.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Yellow
        Me.Button8.Location = New System.Drawing.Point(67, 132)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(95, 31)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "HAPUS"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 57)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Silahkan Pilih" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Untuk Di Hapus" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*Berdasarkan Kode Pemasok"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.Location = New System.Drawing.Point(3, 166)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(380, 30)
        Me.Panel4.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Yellow
        Me.Button6.Location = New System.Drawing.Point(196, 132)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 31)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "BATAL"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Tukar
        '
        Me.Tukar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Tukar.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tukar.ForeColor = System.Drawing.Color.Yellow
        Me.Tukar.Location = New System.Drawing.Point(67, 132)
        Me.Tukar.Name = "Tukar"
        Me.Tukar.Size = New System.Drawing.Size(95, 31)
        Me.Tukar.TabIndex = 20
        Me.Tukar.Text = "CARI"
        Me.Tukar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(190, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 26)
        Me.TextBox1.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Swis721 BlkCn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Kode Pemasok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(267, 57)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Silahkan Pilih" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Untuk Di Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*Berdasarkan Kode Pemasok" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(386, 33)
        Me.Panel3.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(326, 320)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "SIMPAN PERUBAHAN"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(535, 320)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 23)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "BATAL"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Button11)
        Me.Panel2.Controls.Add(Me.Button12)
        Me.Panel2.Location = New System.Drawing.Point(2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 30)
        Me.Panel2.TabIndex = 20
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Maroon
        Me.Button11.Font = New System.Drawing.Font("Clarendon Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(606, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 16
        Me.Button11.Text = "-"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Maroon
        Me.Button12.Font = New System.Drawing.Font("Clarendon Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(711, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 17
        Me.Button12.Text = "X"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Controls.Add(Me.Panel13)
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Button9)
        Me.Panel5.Controls.Add(Me.Panel15)
        Me.Panel5.Controls.Add(Me.Button10)
        Me.Panel5.Controls.Add(Me.Button14)
        Me.Panel5.Controls.Add(Me.Panel16)
        Me.Panel5.Controls.Add(Me.Button15)
        Me.Panel5.Controls.Add(Me.Button16)
        Me.Panel5.Controls.Add(Me.Button17)
        Me.Panel5.Controls.Add(Me.Button18)
        Me.Panel5.Controls.Add(Me.Button19)
        Me.Panel5.Controls.Add(Me.Button20)
        Me.Panel5.Location = New System.Drawing.Point(2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(201, 602)
        Me.Panel5.TabIndex = 21
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Black
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(65, 399)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 23)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Barang"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Black
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(65, 350)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(98, 23)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Satuan"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Black
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(65, 303)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(98, 23)
        Me.Button14.TabIndex = 7
        Me.Button14.Text = "Kelompok"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Black
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.White
        Me.Button15.Location = New System.Drawing.Point(65, 491)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(98, 23)
        Me.Button15.TabIndex = 11
        Me.Button15.Text = "Penjualan"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button16.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button16.Location = New System.Drawing.Point(65, 122)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(98, 23)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "Home"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Black
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.White
        Me.Button17.Location = New System.Drawing.Point(65, 444)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(98, 23)
        Me.Button17.TabIndex = 10
        Me.Button17.Text = "Pembelian"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Black
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button18.Location = New System.Drawing.Point(65, 256)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(98, 23)
        Me.Button18.TabIndex = 6
        Me.Button18.Text = "Pengiriman"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button19.Location = New System.Drawing.Point(65, 166)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(98, 23)
        Me.Button19.TabIndex = 4
        Me.Button19.Text = "User"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button20.Location = New System.Drawing.Point(65, 210)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(98, 23)
        Me.Button20.TabIndex = 5
        Me.Button20.Text = "Pelanggan"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Kaufmann BT", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(205, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 42)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "#VISUAL MART"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(237, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 32)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "WWW.VMART.ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "082113923231"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 585)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 199
        Me.LineShape1.X2 = 811
        Me.LineShape1.Y1 = 114
        Me.LineShape1.Y2 = 112
        '
        'PelangganTableAdapter
        '
        Me.PelangganTableAdapter.ClearBeforeFill = True
        '
        'PelangganDataSet2
        '
        Me.PelangganDataSet2.DataSetName = "pelangganDataSet"
        Me.PelangganDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodepemasokDataGridViewTextBoxColumn, Me.NamapemasokDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NotelpDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PemasokBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(289, 409)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 150)
        Me.DataGridView1.TabIndex = 24
        '
        'PerbaranganDataSet2
        '
        Me.PerbaranganDataSet2.DataSetName = "perbaranganDataSet2"
        Me.PerbaranganDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PemasokBindingSource
        '
        Me.PemasokBindingSource.DataMember = "pemasok"
        Me.PemasokBindingSource.DataSource = Me.PerbaranganDataSet2
        '
        'PemasokTableAdapter
        '
        Me.PemasokTableAdapter.ClearBeforeFill = True
        '
        'KodepemasokDataGridViewTextBoxColumn
        '
        Me.KodepemasokDataGridViewTextBoxColumn.DataPropertyName = "kode_pemasok"
        Me.KodepemasokDataGridViewTextBoxColumn.HeaderText = "kode_pemasok"
        Me.KodepemasokDataGridViewTextBoxColumn.Name = "KodepemasokDataGridViewTextBoxColumn"
        '
        'NamapemasokDataGridViewTextBoxColumn
        '
        Me.NamapemasokDataGridViewTextBoxColumn.DataPropertyName = "Nama_pemasok"
        Me.NamapemasokDataGridViewTextBoxColumn.HeaderText = "Nama_pemasok"
        Me.NamapemasokDataGridViewTextBoxColumn.Name = "NamapemasokDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'NotelpDataGridViewTextBoxColumn
        '
        Me.NotelpDataGridViewTextBoxColumn.DataPropertyName = "No_telp"
        Me.NotelpDataGridViewTextBoxColumn.HeaderText = "No_telp"
        Me.NotelpDataGridViewTextBoxColumn.Name = "NotelpDataGridViewTextBoxColumn"
        '
        'Panel11
        '
        Me.Panel11.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_02__1__removebg_preview
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel11.Location = New System.Drawing.Point(12, 428)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(50, 39)
        Me.Panel11.TabIndex = 20
        '
        'Panel13
        '
        Me.Panel13.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_02__3__removebg_preview
        Me.Panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel13.Location = New System.Drawing.Point(15, 475)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(50, 39)
        Me.Panel13.TabIndex = 21
        '
        'Panel12
        '
        Me.Panel12.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_02_removebg_preview
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel12.Location = New System.Drawing.Point(15, 375)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(47, 47)
        Me.Panel12.TabIndex = 20
        '
        'Panel10
        '
        Me.Panel10.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_03__5__removebg_preview
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Location = New System.Drawing.Point(12, 325)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(50, 50)
        Me.Panel10.TabIndex = 20
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_03__4__removebg_preview
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel9.Location = New System.Drawing.Point(15, 275)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(47, 51)
        Me.Panel9.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_03_removebg_preview
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Location = New System.Drawing.Point(15, 183)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(44, 44)
        Me.Panel7.TabIndex = 20
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_03__2__removebg_preview
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Location = New System.Drawing.Point(12, 88)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(47, 57)
        Me.Panel6.TabIndex = 19
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkRed
        Me.Panel8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logoVmart_removebg_preview
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Location = New System.Drawing.Point(12, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(167, 63)
        Me.Panel8.TabIndex = 16
        '
        'Panel15
        '
        Me.Panel15.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_03__3__removebg_preview
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel15.Location = New System.Drawing.Point(12, 221)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(47, 48)
        Me.Panel15.TabIndex = 20
        '
        'Panel16
        '
        Me.Panel16.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_14_at_02_30_03__1__removebg_preview
        Me.Panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel16.Location = New System.Drawing.Point(15, 143)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(44, 39)
        Me.Panel16.TabIndex = 20
        '
        'pemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 585)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Telepon)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pemasok"
        Me.Text = "Form4"
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelangganDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PelangganDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerbaranganDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemasokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Kode As System.Windows.Forms.TextBox
    Friend WithEvents Nama As System.Windows.Forms.TextBox
    Friend WithEvents Alamat As System.Windows.Forms.TextBox
    Friend WithEvents Telepon As System.Windows.Forms.TextBox
    Friend WithEvents PelangganDataSet1 As WindowsApplication1.pelangganDataSet1
    Friend WithEvents PelangganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PelangganTableAdapter As WindowsApplication1.pelangganDataSet1TableAdapters.pelangganTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Tukar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PelangganDataSet2 As WindowsApplication1.pelangganDataSet
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PerbaranganDataSet2 As WindowsApplication1.perbaranganDataSet2
    Friend WithEvents PemasokBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PemasokTableAdapter As WindowsApplication1.perbaranganDataSet2TableAdapters.pemasokTableAdapter
    Friend WithEvents KodepemasokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapemasokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotelpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
