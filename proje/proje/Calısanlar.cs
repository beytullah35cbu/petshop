
class calısanlar
{
    public static void Main(string[] args)
    {

        Sahıp sahıp = new Sahıp();
        Mudur mudur = new Mudur();
        Calisan calisan = new Calisan();
        Calisan calisan1 = new Calisan();
        Calisan calisan2 = new Calisan();

    calısan:
        Console.Write("Maaşlara mudahele etmek ıstıyormusunuz? (E/H) ana menı ıcın 0(sfır)tuşlayın: ");
        string urun1 = Console.ReadLine().ToUpper();
        if (urun1 != "E" && urun1 != "H" && urun1 != "0")
        {

            do
            {
                Console.Write("(E/H)'den veya 0(sıfırdan) başka değer giremesiniz : ");  //ana menu ıcın goto sorusu
                urun1 = Console.ReadLine().ToUpper();
            } while (urun1 != "E" && urun1 != "H" && urun1 != "0");
          

        }

        if (urun1.ToUpper() == "0")
        {
            Console.WriteLine("ana menuye donme kodu olacak");
            //ana menuye donme kodu goto------------------------------------------------------
        }



        if (urun1.ToUpper() == "E")
        {

            Console.WriteLine(
                     "1.Mudur" + "\n" +
                     "2.Calısan" + "\n" +
                     "3.Calısan1" + "\n" +
                     "4.Calısan2");
        }
        Console.Write(" Lütfen şifreyi girin bi önceki menu için 0(sıfır) basın   : ");
        string sifre5 = Console.ReadLine().ToUpper();
        if (sifre5 != "SAHIP" && sifre5 != "MUDUR" && sifre5 != "CALISAN" && sifre5 != "0")
        {
            do
            {
                Console.Write(" yanlış şifre girdiniz tekrar girin (SAHIP) : ");// şifreler (SAHIP/MUDUR/CALISAN)
                sifre5 = Console.ReadLine().ToUpper();
            } while (sifre5 != "SAHIP" && sifre5 != "MUDUR" && sifre5 != "CALISAN" && sifre5 != "0");

        }

        if (sifre5 == "0")
        {
            goto calısan;
        }
        if (sifre5.ToUpper() == "SAHIP")
        {


            int sayı5;
            Console.Write("LISTEYE GORE SAYI GIRINIZ : ");
            string input5 = Console.ReadLine();

            if (!int.TryParse(input5, out sayı5) || sayı5 < 1 || sayı5 > 12)
            {
                do
                {
                    Console.Write(" Lİsteye göre 1 ile 4 arsında bir sayı girin: ");
                    input5 = Console.ReadLine();
                } while (!int.TryParse(input5, out sayı5) || !(sayı5 >= 1 && sayı5 <= 4));
            }



            if (input5 == "1")
            {
                //***
                Console.Write("Mudur  maaş değiştirmek istıyormusunuz? E/H : ");
                string cevap4 = Console.ReadLine().ToUpper();
                if (cevap4 != "E" && cevap4 != "H")
                {


                    do
                    {
                        Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                        cevap4 = Console.ReadLine().ToUpper();
                    } while (cevap4 != "E" && cevap4 != "H");
                }//***




                if (cevap4.ToUpper() == "E")
                {
                    double kdvOranx;
                    Console.Write("Mudur yeni maaş giriniz : ");
                    string inputax = Console.ReadLine();
                    if (double.TryParse(inputax, out kdvOranx) && kdvOranx < mudur._maas)
                    {
                        do
                        {
                            Console.Write("Müdür maaşı güncel maaş " + mudur._maas + "dan az olamaz :");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx) || kdvOranx < mudur._maas);

                        Console.Write("GUNCEL MUDUR MAAŞ: " + (mudur._maas = kdvOranx));
                         string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                       don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto calısan;
                    }
                    }
                    Console.WriteLine("GUNCEL MUDUR MAAŞ : " + (mudur._maas = kdvOranx));
                }
                }
            if (input5 == "2")
            {
                //***
                Console.Write("Calısan  maaş değiştirmek istıyormusunuz? E/H : ");
                string cevap4 = Console.ReadLine().ToUpper();
                if (cevap4 != "E" && cevap4 != "H")
                {


                    do
                    {
                        Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                        cevap4 = Console.ReadLine().ToUpper();
                    } while (cevap4 != "E" && cevap4 != "H");
                }//***




                if (cevap4.ToUpper() == "E")
                {
                    double kdvOranx;
                    Console.Write("Calısan yeni maaş giriniz : ");
                    string inputax = Console.ReadLine();
                    if (double.TryParse(inputax, out kdvOranx) && kdvOranx < calisan._maas)
                    {
                        do
                        {
                            Console.Write("Calısan maaşı güncel maaş " + calisan._maas + "den az olamaz :");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx) || kdvOranx < calisan._maas);

                        Console.WriteLine("GUNCEL Calısan MAAŞ : " + (calisan._maas = kdvOranx));
                    }
                    Console.WriteLine("GUNCEL Calısan MAAŞ : " + (calisan._maas = kdvOranx));
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto calısan;
                    }
                }

                else
                {
                    Console.WriteLine(" Calısan1 MAAŞ : " + (calisan._maas));
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto calısan;
                    }
                }
            }
            if (input5 == "3")
            {
                //***
                Console.Write("Calısan1  maaş değiştirmek istıyormusunuz? E/H : ");
                string cevap4 = Console.ReadLine().ToUpper();
                if (cevap4 != "E" && cevap4 != "H")
                {


                    do
                    {
                        Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                        cevap4 = Console.ReadLine().ToUpper();
                    } while (cevap4 != "E" && cevap4 != "H");
                }//***




                if (cevap4.ToUpper() == "E")
                {
                    double kdvOranx;
                    Console.Write("Calısan1 yeni maaş giriniz : ");
                    string inputax = Console.ReadLine();
                    if (double.TryParse(inputax, out kdvOranx) && kdvOranx < calisan1._maas)
                    {
                        do
                        {
                            Console.Write("Calısan1 maaşı güncel maaş " + calisan1._maas + "den az olamaz :");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx) || kdvOranx < calisan1._maas);

                        Console.WriteLine("GUNCEL Calısan1 MAAŞ : " + (calisan1._maas = kdvOranx));
                    }
                    Console.WriteLine("GUNCEL Calısan1 MAAŞ : " + (calisan1._maas = kdvOranx));
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto calısan;
                    }
                }
                else
                {
                    Console.WriteLine(" Calısan1 MAAŞ : " + (calisan1._maas ));
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto calısan;
                    }
                }

            }
            if (input5 == "4")
            {
                //***
                Console.Write("Calısan2  maaş değiştirmek istıyormusunuz? E/H : ");
                string cevap4 = Console.ReadLine().ToUpper();
                if (cevap4 != "E" && cevap4 != "H")
                {


                    do
                    {
                        Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                        cevap4 = Console.ReadLine().ToUpper();
                    } while (cevap4 != "E" && cevap4 != "H");
                }//***




                if (cevap4.ToUpper() == "E")
                {
                    double kdvOranx;
                    Console.Write("Calısan2 yeni maaş giriniz : ");
                    string inputax = Console.ReadLine();
                    if (double.TryParse(inputax, out kdvOranx) && kdvOranx < calisan2._maas)
                    {
                        do
                        {
                            Console.Write("Calısan1 maaşı güncel maaş " + calisan2._maas + "den az olamaz :");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx) || kdvOranx < calisan2._maas);

                        Console.WriteLine("GUNCEL Calısan2 MAAŞ : " + (calisan2._maas = kdvOranx));
                    }
                    Console.WriteLine("GUNCEL Calısan2 MAAŞ : " + (calisan2._maas = kdvOranx));
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                       don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto calısan;
                    }
                }
                else
                {
                    Console.WriteLine(" Calısan2 MAAŞ : " + (calisan2._maas));
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto calısan;
                    }
                }


            }


            Console.ReadKey();



                }






            }
        }
    
