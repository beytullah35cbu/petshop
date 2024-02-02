public class KanatlıHayvan : Hayvanlar
{
    public override string Ad()
    {
        return "KANATLI";
    }
    public double kdvhesapla = 1.25;
    public double fiyat = 300;
    public double indirim1 = 0.00;

    public override string Cins()
    {
        return "Kanatlı Hayvan";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
}


public class Güvercin : KanatlıHayvan
{

    public new double fiyat = 400;

    public override string Cins()
    {
        return "Taklacı";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "GÜVERCİN";
    }
}


public class MuhabbetKuşu : KanatlıHayvan
{

    public new double fiyat = 600;
        
    public override string Cins()
    {
        return "Mavi Muhabbet Kuşu";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Muhabbet Kuşu";
    }
}



public class Tavuk : KanatlıHayvan
{

    public new double fiyat = 150;

    public override string Cins()
    {
        return "Leghorn";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Tavuk";
    }
}



public class Şahin: KanatlıHayvan
{

    public new double fiyat = 1500;

    public override string Cins()
    {
        return "Akuila ";//nadir tür

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Şahin";
    }
}


