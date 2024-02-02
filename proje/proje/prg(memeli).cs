

public class Memelihayvan : Hayvanlar
{
    
    public double kdvhesapla = 1.20;
    public double fiyat = 200;
    public double indirim1 = 0.00;

    public override string Cins()
    {
        return "memelihayvan";

    }
  
    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla)-((fiyat/100)*indirim1);
    }
    public override string Ad()
    {
        return "Memeli";
    }


}
public  class Köpek : Memelihayvan
{
    public new double fiyat = 400;

    public override string Cins()
    {
        return "Akbaş";

    }
  
    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Köpek";
    }

}



public class Kedi: Memelihayvan
{

    public new double fiyat = 150;
    public override string Cins()
    {
        return "Tekir";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Kedi";
    }

}



public class  Tavşan: Memelihayvan
{

    public new double fiyat = 250;
    public override string Cins()
    {
        return "Cüce tavşan";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Tavşan";
    }

}





public class Hamster : Memelihayvan
{
    public new double fiyat = 700;

    public override string Cins()
    {
        return "Gonzales Hamster";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Hamster";
    }

}



public class Köstebek : Memelihayvan
{

    public new double fiyat = 900;
    public override string Cins()
    {
        return "Soricomorpha ";

    }

    public override double KDVhesapla()
    {
        return (fiyat * kdvhesapla) - ((fiyat / 100) * indirim1);
    }
    public override string Ad()
    {
        return "Köstebek";
    }

}

