public abstract class Petshop
{
    public abstract string Ad();
    public virtual double Maas { get; set; }
}

public class Sahıp : Petshop
{
    public override string Ad()
    {
        return "Ertac";
    }
    public virtual double gelir
    {
        get { return _gelir; }
        set { _gelir = value; }
    }

    private double _gelir = 30000;

}

public class Mudur : Sahıp
{
    public override string Ad()
    {
        return "Beytullah";
    }

   public double _maas = 12000;
    public override double Maas
    {
        get { return _maas;  }
        set { _maas = 12000; }
    }

}

public class Calisan : Sahıp
{
    public override string Ad()
    {
        return "Ali";
    }

    public double _maas = 9100;
    public override double Maas
    {
        get { return _maas; }
        set { _maas = 8500; }
    }
}

public class Calisan1 : Sahıp
{
    public override string Ad()
    {
        return "Mehmet";
    }

    public double _maas = 8700;
    public override double Maas
    {
        get  { return _maas; }
        set  { _maas = 8500; }
    }

}

public class Calisan2 : Sahıp
{
    public override string Ad()
    {
        return "Veli";
    }

    public double _maas = 9000;
    public override double Maas
    {
        get {  return _maas;  }
        set { _maas = 8500; }
    }

}
