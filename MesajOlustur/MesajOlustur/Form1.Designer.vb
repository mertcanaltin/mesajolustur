<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAd = New System.Windows.Forms.TextBox()
        Me.TextBoxSoyad = New System.Windows.Forms.TextBox()
        Me.TextBoxBorc = New System.Windows.Forms.TextBox()
        Me.TextBoxMesaj = New System.Windows.Forms.TextBox()
        Me.DateTimePickerSonOdeme = New System.Windows.Forms.DateTimePicker()
        Me.ButtonMesajOlustur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ad: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Soyad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Borç"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Son Ödeme Tarihi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mesaj"
        '
        'TextBoxAd
        '
        Me.TextBoxAd.Location = New System.Drawing.Point(110, 40)
        Me.TextBoxAd.Name = "TextBoxAd"
        Me.TextBoxAd.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAd.TabIndex = 5
        '
        'TextBoxSoyad
        '
        Me.TextBoxSoyad.Location = New System.Drawing.Point(110, 66)
        Me.TextBoxSoyad.Name = "TextBoxSoyad"
        Me.TextBoxSoyad.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSoyad.TabIndex = 6
        '
        'TextBoxBorc
        '
        Me.TextBoxBorc.Location = New System.Drawing.Point(110, 89)
        Me.TextBoxBorc.Name = "TextBoxBorc"
        Me.TextBoxBorc.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBorc.TabIndex = 7
        '
        'TextBoxMesaj
        '
        Me.TextBoxMesaj.Location = New System.Drawing.Point(12, 237)
        Me.TextBoxMesaj.Multiline = True
        Me.TextBoxMesaj.Name = "TextBoxMesaj"
        Me.TextBoxMesaj.Size = New System.Drawing.Size(439, 73)
        Me.TextBoxMesaj.TabIndex = 8
        '
        'DateTimePickerSonOdeme
        '
        Me.DateTimePickerSonOdeme.Location = New System.Drawing.Point(110, 115)
        Me.DateTimePickerSonOdeme.Name = "DateTimePickerSonOdeme"
        Me.DateTimePickerSonOdeme.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerSonOdeme.TabIndex = 9
        Me.DateTimePickerSonOdeme.Value = New Date(2018, 4, 12, 0, 0, 0, 0)
        '
        'ButtonMesajOlustur
        '
        Me.ButtonMesajOlustur.Location = New System.Drawing.Point(15, 147)
        Me.ButtonMesajOlustur.Name = "ButtonMesajOlustur"
        Me.ButtonMesajOlustur.Size = New System.Drawing.Size(439, 44)
        Me.ButtonMesajOlustur.TabIndex = 10
        Me.ButtonMesajOlustur.Text = "Mesaj Oluştur"
        Me.ButtonMesajOlustur.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 322)
        Me.Controls.Add(Me.ButtonMesajOlustur)
        Me.Controls.Add(Me.DateTimePickerSonOdeme)
        Me.Controls.Add(Me.TextBoxMesaj)
        Me.Controls.Add(Me.TextBoxBorc)
        Me.Controls.Add(Me.TextBoxSoyad)
        Me.Controls.Add(Me.TextBoxAd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAd As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSoyad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBorc As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMesaj As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerSonOdeme As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMesajOlustur As System.Windows.Forms.Button

End Class
