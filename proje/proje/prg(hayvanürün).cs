public class Urun:Hayvanlar
{

    public double gelişf = 70;
    public double gidişf = 100;
    public double kdv=1.10;
    public double indirim1 = 0.00;

    public override string Ad()
    {
        return "";
    }

    public override string Cins()
    {
        return "";
    }

    public override double KDVhesapla()
    {
        return (gidişf  * kdv)-((gidişf/100)*indirim1);
    }

   
}



public class   Sampuan : Urun
{
    public double gelişf = 60;
    public string ad = "sampuan";
    public new double gidişf= 90;
    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }


}
public class Mama : Urun
{

    public double gelişf = 90;
    public string ad = "mama";
    public new double gidişf = 120;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}
public class Sukap : Urun
{
    public double gelişf = 130;

    public string ad = "sukap";
    public new double gidişf = 150;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}



public class Mamakapı : Urun
{
    public double gelişf = 10;

    public string ad = "mamakap";
    public new double gidişf = 30;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}


public class Vitaminler : Urun
{

    public double gelişf = 100;
    public string ad = "vitaminler";
    public new double gidişf = 130;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}


public class Minareller : Urun
{
    public double gelişf = 30;

    public string ad = "minareller";
    public new double gidişf = 50;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}



public class Kumlar : Urun
{
    public double gelişf = 70;

    public string ad = "kumlar";
    public new double gidişf = 200;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}

public class Kafesler : Urun
{
    public double gelişf = 50;

    public string ad = "Kafes";
    public new double gidişf = 80;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}


public class Aksesuar : Urun
{

    public double gelişf = 5;
    public string ad = "aksesuar";
    public new double gidişf = 20;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}

public class Yuvalar : Urun
{

    public double gelişf = 70;
    public string ad = "mama";
    public new double gidişf = 120;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}




public class Yataklar : Urun
{

    public double gelişf = 370;
    public string ad = "Yataklar";
    public new double gidişf = 400;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}
public class Kıyafet : Urun
{
    public double gelişf = 270;


    public string ad = "Kıyafet";
    public new double gidişf = 300;


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}


public class Aşı : Urun {

    public double gelişf = 30;
    public string ad = "Aşı";
    public new double gidişf = 55;//satılan fıyat


    public double KDVhesapla()
    {
        return (gidişf * kdv) - ((gidişf / 100) * indirim1);
    }

}



