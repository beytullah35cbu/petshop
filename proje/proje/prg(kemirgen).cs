public class Kemirgen : Hayvanlar
{

    public double kdvhesapla = 1.23;
    public double fiyat = 450;
    public double indirim1 = 0.00;

    public override string Cins()
    {
        return "Kemirgen";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }

    public override string Ad()
    {
        return "KEMİRGEN";
    }
}



public class Gelincik: KanatlıHayvan 
{

    public new double fiyat = 350;

    public override string Cins()
    {
        return "Sansar";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "GELİNCİK";
    }
}


public class Sincap : KanatlıHayvan
{

    public new double fiyat = 700;

    public override string Cins()
    {
        return "Boz Sincap";

    }
    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "SİNCAP";
    }
}