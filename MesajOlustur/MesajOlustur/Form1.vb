Public Class Form1

    

    
    

    Private Sub ButtonMesajOlustur_Click(sender As Object, e As EventArgs) Handles ButtonMesajOlustur.Click
        Dim Ad, Soyad, Mesaj, Metin As String
        Dim Borc As Decimal
        Dim SOT As Date 'SOT= Son Ödeme Tarihi

        Ad = TextBoxAd.Text
        Soyad = TextBoxSoyad.Text
        Borc = TextBoxBorc.Text
        SOT = DateTimePickerSonOdeme.Value

        Metin = "Sayın {0} {1} Son Ödeme Tarihi {2:dd MMMM yyyy dddd } olan {3:C} borcunuzu {2:dd MMMM yyyy dddd} tarihinden önce ödemeyi unutmayız."
        'Tarih şeklindeki formatlar için date, Para birimi için decimal'
        Mesaj = String.Format(Metin, Ad, Soyad, SOT, Borc)
        TextBoxMesaj.Text = Mesaj


    End Sub


End Class
