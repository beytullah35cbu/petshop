
public class Sepet
{
    private List<Hayvanlar> urunler = new List<Hayvanlar>(); //urunler listesı

    public double ToplamTutar()
    {
        double toplamFiyat = 0;

        foreach (Hayvanlar item in urunler) //değerleri urunler lıstesıne aktar
        {
            toplamFiyat += item.KDVhesapla(); //toplam fıyata ekle
        }

        return toplamFiyat; //son kdvlı fıyatı dondur
    }

    public void Ekle(Hayvanlar yeniUrun) //voıd oldugu ıcın return olmaz
    {
        urunler.Add(yeniUrun);
    }


}