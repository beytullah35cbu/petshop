

 /*
class test1
{



    public static void Main(string[] args)
    {
   
        
        Sampuan sampuan = new Sampuan();
        Mama mama = new Mama();
        Sukap sukap = new Sukap();
        Vitaminler vitaminler = new Vitaminler();
        Minareller minareller = new Minareller();
        Kumlar kumlar = new Kumlar();
        Kafesler kafesler = new Kafesler();
        Aksesuar aksesuar = new Aksesuar();
        Yuvalar yuvalar = new Yuvalar();
        Yataklar yataklar = new Yataklar();
        Kıyafet kıyafet = new Kıyafet();
        Aşı aşı = new Aşı();

        urunkdv:
        Console.Write("Ürun fiyat ve kdv degıstırmek ıstıyor musunuz? (E/H) : ");
        string urun1 = Console.ReadLine().ToUpper();
        if (urun1 != "E" && urun1 != "H")
        {

            do
            {
                Console.Write("(E/H)'den başka değer giremesiniz : ");
                urun1 = Console.ReadLine().ToUpper();
            } while (urun1 != "E" && urun1 != "H");
            //-----------------------------------------------------------ana menu doncen *_* goto

        }


        
        if (urun1.ToUpper() == "E")
        {
           
            Console.WriteLine(
                     "1.Sampuan" + "\n" +
                     "2.Mama" + "\n" +
                     "3.Sukap" + "\n" +
                     "4.Vitaminler" + "\n" +
                     "5.Minareller" + "\n" +
                     "6.Kumlar" + "\n" +
                     "7.Kafesler" + "\n" +
                     "8.Aksesuar" + "\n" +
                     "9.Yuvalar" + "\n" +
                     "10.Yataklar" + "\n" +
                     "11.Kıyafet" + "\n" +
                     "12.Aşı" );

            Console.Write(" Lütfen şifreyi girin bi önceki menu için 0(sıfır) basın SAHIP/MUDUR/CALISAN  : ");
            string sifre5 = Console.ReadLine().ToUpper();
            if (sifre5 != "SAHIP" && sifre5 != "MUDUR" && sifre5 != "CALISAN" && sifre5 != "0")
            {
                do
                {
                    Console.Write(" yanlış şifer girdiniz tekrar girin : ");// şifreler (SAHIP/MUDUR/CALISAN)
                    sifre5 = Console.ReadLine().ToUpper();
                } while (sifre5 != "SAHIP" && sifre5 != "MUDUR" && sifre5 != "CALISAN" &&sifre5 != "0");

            }

            if (sifre5=="0")
            {
                goto urunkdv;
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
                        Console.Write(" Lİsteye göre 1 ile 12 arsında bir sayı girin: ");
                        input5 = Console.ReadLine();
                    } while (!int.TryParse(input5, out sayı5) || !(sayı5 >= 1 && sayı5 <= 12));
                }




                if (input5 == "1")
                {
                    //***
                    Console.Write("Sampuan KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
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
                        string inputax;

                        do
                        {
                            Console.Write("Sampuan KDV oranını giriniz: ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx));

                        sampuan.kdv = kdvOranx;


                    }

                    //***
                    Console.Write("Sampuan Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva1w = Console.ReadLine().ToUpper();
                    if (ceva1w != "E" && ceva1w != "H")
                    {
                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }//*********

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Sampuan  fiyatı yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1));

                        sampuan.gidişf = kdvOrany1;

                    }

                    Console.WriteLine("Sampuan Güncel Fiyat :" + sampuan.KDVhesapla());

                    //********* yapıldı
                    string don;

                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                    //------------------------------------------------------------------------bunu aşağıda hepsine tanımla

                }
                if (input5 == "2")
                {

                    Console.Write("Mama KDV değiştirmek  istiyomusunuz (E/H) : ");
                    string cevap4 = Console.ReadLine().ToUpper();

                    do
                    {
                        Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                        cevap4 = Console.ReadLine().ToUpper();
                    } while (cevap4 != "E" && cevap4 != "H");

                    if (cevap4.ToUpper() == "E")
                    {

                        double kdvOranx;
                        string inputax;

                        do
                        {
                            Console.Write("Mama KDV oranını girin: ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx));

                        mama.kdv = kdvOranx;
                    }

                    Console.Write("Mama Fiyatı   değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva1w = Console.ReadLine().ToUpper();
                    if (ceva1w != "E" && ceva1w != "H")
                    {
                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Mama  fiyatı yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1));

                        mama.gidişf = kdvOrany1;

                    }

                    Console.WriteLine("Mama Güncel Fiyat : " + mama.KDVhesapla());
                    string don;

                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }

                if (input5 == "3")
                {
                    Console.Write("Sukap KDV değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva11 = Console.ReadLine().ToUpper();

                    do
                    {
                        Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                        ceva11 = Console.ReadLine().ToUpper();
                    } while (ceva11 != "E" && ceva11 != "H");


                    if (ceva11.ToUpper() == "E")
                    {
                        double kdvOranx;
                        string inputax;

                        do
                        {
                            Console.Write("Sukap KDV oranını girin: ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx));

                        sukap.kdv = kdvOranx;
                    }
                    Console.Write(" Sukap Fiyatı  değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva1w = Console.ReadLine().ToUpper();
                    if (ceva1w != "E" && ceva1w != "H")
                    {
                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Sukap  fiyatı yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1));

                        sukap.gidişf = kdvOrany1;

                    }

                    Console.WriteLine("Sukap Güncel Fiyat : " + sukap.KDVhesapla());
                    string don;

                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }
                if (input5 == "4")
                {
                    Console.Write("Vitaminler KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }




                    if (ceva11.ToUpper() == "E")
                    {


                        double kdvOranx;
                        string inputax;

                        do
                        {
                            Console.Write("Vitaminler KDV oranını girin: ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx));

                        vitaminler.kdv = kdvOranx;
                    }
                    Console.Write("Vitaminler Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva1w = Console.ReadLine().ToUpper();
                    if (ceva1w != "E" && ceva1w != "H")
                    {
                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Vitaminler  fiyatı yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1));

                        vitaminler.gidişf = kdvOrany1;

                    }

                    Console.WriteLine("Vitaminler Güncel Fiyat : " + vitaminler.KDVhesapla());
                    string don;

                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }

                if (input5 == "5")
                {
                    Console.Write("Minareller KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    if (ceva11.ToUpper() == "E")
                    {
                        double kdvOranx;
                        string inputax;

                        do
                        {
                            Console.Write("Minareller KDV oranını girin: ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx));

                        minareller.kdv = kdvOranx;
                    }

                    Console.Write("Minareller Fİyatı  değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva1w = Console.ReadLine().ToUpper();
                    if (ceva1w != "E" && ceva1w != "H")
                    {
                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Minareller  fiyatı yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1));

                        minareller.gidişf = kdvOrany1;

                    }

                    Console.WriteLine("Minareller Güncel Fiyat :" + minareller.KDVhesapla());
                    string don;

                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }

                if (input5 == "6")
                {

                    Console.Write("Kumlar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");



                        if (ceva11 != "E" && ceva11 != "H")
                        {


                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva11 = Console.ReadLine().ToUpper();
                            } while (ceva11 != "E" && ceva11 != "H");
                        }

                        if (ceva11.ToUpper() == "E")
                        {

                            double kdvOranx;
                            string inputax;

                            do
                            {
                                Console.Write("Kumlar KDV oranını girin: ");
                                inputax = Console.ReadLine();

                            } while (!double.TryParse(inputax, out kdvOranx));

                            kumlar.kdv = kdvOranx;
                        }
                        Console.Write("Kumlar Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                        if (ceva1w != "E" && ceva1w != "H")
                        {
                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva1w = Console.ReadLine().ToUpper();
                            } while (ceva1w != "E" && ceva1w != "H");
                        }

                        if (ceva1w.ToUpper() == "E")
                        {


                            double kdvOrany1;
                            string inputy;

                            do
                            {
                                Console.Write("kumlar  fiyatı yazabilirsiniz : ");
                                inputy = Console.ReadLine();

                            } while (!double.TryParse(inputy, out kdvOrany1));

                            kumlar.gidişf = kdvOrany1;

                        }

                        Console.WriteLine("Kumlar Güncel Fiyat : " + kumlar.KDVhesapla());
                        string don;

                        do
                        {
                            Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                            don = Console.ReadLine().ToUpper();

                        } while (don != "0");
                        if (don == "0")
                        {
                            goto urunkdv;
                        }

                    }
                }

                if (input5 == "7")
                {

                    Console.Write("Kafesler KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                        if (ceva11 != "E" && ceva11 != "H")
                        {


                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva11 = Console.ReadLine().ToUpper();
                            } while (ceva11 != "E" && ceva11 != "H");
                        }

                        if (ceva11.ToUpper() == "E")
                        {

                            double kdvOranx;
                            string inputax;

                            do
                            {
                                Console.Write("Kafesler KDV oranını girin: ");
                                inputax = Console.ReadLine();

                            } while (!double.TryParse(inputax, out kdvOranx));

                            kafesler.kdv = kdvOranx;
                        }

                        Console.Write("Kafesler Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                        if (ceva1w != "E" && ceva1w != "H")
                        {
                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva1w = Console.ReadLine().ToUpper();
                            } while (ceva1w != "E" && ceva1w != "H");
                        }


                        if (ceva1w.ToUpper() == "E")
                        {
                            Console.Write("Kafesler KDV değiştirmek  istiyomusunuz (E/H) : ");
                            string ceva1 = Console.ReadLine();

                            if (ceva1.ToUpper() == "E")
                            {

                                double kdvOrany1;
                                string inputy;

                                do
                                {
                                    Console.Write("Kafesler fiyatı yazabilirsiniz : ");
                                    inputy = Console.ReadLine();

                                } while (!double.TryParse(inputy, out kdvOrany1));

                                kafesler.gidişf = kdvOrany1;
                            }
                        }

                        Console.WriteLine("Kafesler Güncel Fiyat : " + kafesler.KDVhesapla());
                        string don;

                        do
                        {
                            Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                            don = Console.ReadLine().ToUpper();

                        } while (don != "0");
                        if (don == "0")
                        {
                            goto urunkdv;
                        }

                    }
                }
                if (input5 == "8")
                {


                    Console.Write("Aksesuar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");

                        if (ceva11.ToUpper() == "E")
                        {
                            double kdvOranx;
                            string inputax;

                            do
                            {
                                Console.Write("Aksesuar KDV oranını girin: ");
                                inputax = Console.ReadLine();

                            } while (!double.TryParse(inputax, out kdvOranx));

                            aksesuar.kdv = kdvOranx;
                        }

                        Console.Write("Aksesuar Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                        if (ceva1w != "E" && ceva1w != "H")
                        {
                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva1w = Console.ReadLine().ToUpper();
                            } while (ceva1w != "E" && ceva1w != "H");
                        }


                        if (ceva1w.ToUpper() == "E")
                        {


                            double kdvOrany1;
                            string inputy;

                            do
                            {
                                Console.Write("Aksesuar  fiyatı yazabilirsiniz : ");
                                inputy = Console.ReadLine();

                            } while (!double.TryParse(inputy, out kdvOrany1));

                            aksesuar.gidişf = kdvOrany1;

                        }

                        Console.WriteLine("Aksesuar Güncel Fiyat : " + aksesuar.KDVhesapla());
                    } 
                }
                if (input5 == "9")
                {

                    Console.Write("Yuvalar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");

                        if (ceva11.ToUpper() == "E")
                        {

                            double kdvOranx;
                            string inputax;

                            do
                            {
                                Console.Write("Yuvalar KDV oranını girin: ");
                                inputax = Console.ReadLine();

                            } while (!double.TryParse(inputax, out kdvOranx));

                            yuvalar.kdv = kdvOranx;
                        }
                        Console.Write("Yuvalar Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                        if (ceva1w != "E" && ceva1w != "H")
                        {
                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva1w = Console.ReadLine().ToUpper();
                            } while (ceva1w != "E" && ceva1w != "H");
                        }

                        if (ceva1w.ToUpper() == "E")
                        {


                            double kdvOrany1;
                            string inputy;

                            do
                            {
                                Console.Write("Yuvalar fiyatı yazabilirsiniz : ");
                                inputy = Console.ReadLine();

                            } while (!double.TryParse(inputy, out kdvOrany1));

                            yuvalar.gidişf = kdvOrany1;

                        }

                        Console.WriteLine("Yuvalar Güncel Fiyat : " + yuvalar.KDVhesapla());
                        string don;

                        do
                        {
                            Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                            don = Console.ReadLine().ToUpper();

                        } while (don != "0");
                        if (don == "0")
                        {
                            goto urunkdv;
                        }
                    }
                }
                if (input5 == "10")
                {

                    Console.Write("Yataklar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");

                        if (ceva11.ToUpper() == "E")
                        {

                            double kdvOranx;
                            string inputax;

                            do
                            {
                                Console.Write("Yataklar KDV oranını girin: ");
                                inputax = Console.ReadLine();

                            } while (!double.TryParse(inputax, out kdvOranx));

                            yataklar.kdv = kdvOranx;
                        }

                        Console.Write("Yataklar Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                        if (ceva1w != "E" && ceva1w != "H")
                        {
                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva1w = Console.ReadLine().ToUpper();
                            } while (ceva1w != "E" && ceva1w != "H");
                        }

                        if (ceva1w.ToUpper() == "E")
                        {


                            double kdvOrany1;
                            string inputy;

                            do
                            {
                                Console.Write("Yataklar  fiyatı yazabilirsiniz : ");
                                inputy = Console.ReadLine();

                            } while (!double.TryParse(inputy, out kdvOrany1));

                            yataklar.gidişf = kdvOrany1;

                        }

                        Console.WriteLine("Yataklar Güncel Fiyat : " + yataklar.KDVhesapla());
                        string don;

                        do
                        {
                            Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                            don = Console.ReadLine().ToUpper();

                        } while (don != "0");
                        if (don == "0")
                        {
                            goto urunkdv;
                        }

                    }


                }

                if (input5 == "11")
                {

                    Console.Write(" Kıyafet KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");

                        if (ceva11.ToUpper() == "E")
                        {

                            double kdvOranx;
                            string inputax;

                            do
                            {
                                Console.Write("Kıyafet KDV oranını girin: ");
                                inputax = Console.ReadLine();

                            } while (!double.TryParse(inputax, out kdvOranx));

                            kıyafet.kdv = kdvOranx;
                        }

                        Console.Write(" Kıyafet Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                        if (ceva1w != "E" && ceva1w != "H")
                        {
                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva1w = Console.ReadLine().ToUpper();
                            } while (ceva1w != "E" && ceva1w != "H");
                        }


                        if (ceva1w.ToUpper() == "E")
                        {


                            double kdvOrany1;
                            string inputy;

                            do
                            {
                                Console.Write("Kıyafet  fiyatı yazabilirsiniz : ");
                                inputy = Console.ReadLine();

                            } while (!double.TryParse(inputy, out kdvOrany1));

                            kıyafet.gidişf = kdvOrany1;

                        }

                        Console.WriteLine(" Kıyafet Güncel Fiyat : " + kıyafet.KDVhesapla());
                        string don;
                        do
                        {
                            Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                            don = Console.ReadLine().ToUpper();

                        } while (don != "0");
                        if (don == "0")
                        {
                            goto urunkdv;
                        }

                    }
                }
                if (input5 == "12")
                {

                    Console.Write(" Aşı KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");

                        if (ceva11.ToUpper() == "E")
                        {

                            double kdvOranx;
                            string inputax;

                            do
                            {
                                Console.Write("Aşı KDV oranını girin: ");
                                inputax = Console.ReadLine();

                            } while (!double.TryParse(inputax, out kdvOranx));

                            aşı.kdv = kdvOranx;
                        }
                        Console.Write(" Aşı Fİyatı   değiştirmek  istiyomusunuz (E/H) : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                        if (ceva1w != "E" && ceva1w != "H")
                        {
                            do
                            {
                                Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                                ceva1w = Console.ReadLine().ToUpper();
                            } while (ceva1w != "E" && ceva1w != "H");
                        }

                        if (ceva1w.ToUpper() == "E")
                        {


                            double kdvOrany1;
                            string inputy;

                            do
                            {
                                Console.Write("Aşı fiyatı yazabilirsiniz : ");
                                inputy = Console.ReadLine();

                            } while (!double.TryParse(inputy, out kdvOrany1));

                            aşı.gidişf = kdvOrany1;

                        }

                        Console.WriteLine(" Aşı Güncel Fiyat : " + aşı.KDVhesapla());

                        string don;
                        do
                        {
                            Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                            don = Console.ReadLine().ToUpper();

                        } while (don != "0");
                        if (don == "0")
                        {
                            goto urunkdv;
                        }


                    }

                }


            }

            //---------------------------------------------------------------------------------------------
            if (sifre5.ToUpper() == "MUDUR")
            {
                int sayı5;
                Console.Write("LISTEYE GORE SAYI GIRINIZ : ");
                string input5 = Console.ReadLine();

                if (!int.TryParse(input5, out sayı5) || sayı5 < 1 || sayı5 > 12)
                {
                    do
                    {
                        Console.Write(" Lİsteye göre 1 ile 12 arsında bir sayı girin : ");
                        input5 = Console.ReadLine();
                    } while (!int.TryParse(input5, out sayı5) || !(sayı5 >= 1 && sayı5 <= 12));
                }


                if (input5 == "1")
                {
                    //-------------------------------------------------------------kdv oranı sorusu e h

                    Console.Write("Sampuan KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string cevap4 = Console.ReadLine().ToUpper();
                    if (cevap4 != "E" && cevap4 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap4 = Console.ReadLine().ToUpper();
                        } while (cevap4 != "E" && cevap4 != "H");
                    }
                    if (cevap4 != "E" && cevap4 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap4 = Console.ReadLine().ToUpper();
                        } while (cevap4 != "E" && cevap4 != "H");
                    }

                    if (cevap4.ToUpper() == "E")
                    {

                        double kdvOranx;
                        string inputax;

                        do
                        {
                            Console.Write(" Sampuan KDV oranını girin: 1.20den fazla olamaz ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx)|| kdvOranx > 1.20 );

                        sampuan.kdv = kdvOranx;

                        // -------------------------------------------------------------------------ındırım sorsuna e yada h baska kbl etmıck
                    }

                    //-------------------kdv de iki soru olacak alt soru e ve h
                    Console.Write("İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevap1w = Console.ReadLine().ToUpper();
                   
                    if (cevap1w != "E" && cevap1w != "H")
                    { 


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap1w = Console.ReadLine().ToUpper();
                        } while (cevap1w != "E" && cevap1w != "H");
                    }

                    if (cevap1w.ToUpper() == "E")
                    {


                        double kdvOrany;
                        string inputy;

                        do
                        {
                            Console.Write("Sampuan indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany) || kdvOrany > 1.20);

                        sampuan.indirim1 = kdvOrany;
                       
                    }


                    Console.WriteLine(" Sampuan Güncel Fiyat : " + sampuan.KDVhesapla());

                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }



                if (input5 == "2")
                {

                    Console.Write("Mama KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11.ToUpper() == "E")
                    {

                        double kdvOranx;
                        string inputax;

                        do
                        {
                            Console.Write(" mama KDV oranını girin:en fazla 1.20 yazabilirsiniz ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx) || kdvOranx > 1.20);

                        mama.kdv = kdvOranx;

                    }
                    Console.Write("Mama İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevap1a = Console.ReadLine().ToUpper();

                    if (cevap1a != "E" && cevap1a != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap1a = Console.ReadLine().ToUpper();
                        } while (cevap1a != "E" && cevap1a != "H");
                    }
                    if (cevap1a.ToUpper() == "E")
                    {


                        double kdvOrany;
                        string inputy;

                        do
                        {
                            Console.Write("Mama indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany) || kdvOrany > 1.20);

                        mama.indirim1 = kdvOrany;

                       
                    }
                    Console.WriteLine("Mama Güncel Fiyat : " + mama.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }



                if (input5 == "3")
                {

                    Console.Write("Sukap KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                   

                    if (ceva11.ToUpper() == "E")
                    {

                        double kdvOranx;
                        string inputax;

                        do
                        {
                            Console.Write(" sukap  KDV oranını girin: ");
                            inputax = Console.ReadLine();

                        } while (!double.TryParse(inputax, out kdvOranx ));

                        sukap.kdv = kdvOranx;
                    }



                    Console.Write("İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevap1a = Console.ReadLine().ToUpper();

                    if (cevap1a != "E" && cevap1a != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap1a = Console.ReadLine().ToUpper();
                        } while (cevap1a != "E" && cevap1a != "H");
                    }

                    if (cevap1a.ToUpper() == "E")
                    {


                        double kdvOrany;
                        string inputy;

                        do
                        {
                            Console.Write("Sukap indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany) || kdvOrany > 1.20);

                        sukap.indirim1 = kdvOrany;




                    }
                    Console.WriteLine("Sukap Güncel Fiyat : " + sukap.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }

                if (input5 == "4")
                {

                    Console.Write("Vitaminler KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOranx1;
                        string inputax1;

                        do
                        {
                            Console.Write("Vitaminler KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputax1 = Console.ReadLine();

                        } while (!double.TryParse(inputax1, out kdvOranx1) || kdvOranx1 > 1.20);

                        vitaminler.kdv = kdvOranx1;

                    }


                    Console.Write("Vitaminler İndirim fiyatı değiştirmek  istiyomusunuz (E/H) : ");
                    string cevapx = Console.ReadLine();

                    if (cevapx.ToUpper() == "E")
                    {


                        double kdvOrany;
                        string inputy;

                        do
                        {
                            Console.Write("Vitaminler indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany) || kdvOrany > 1.20);

                        vitaminler.indirim1 = kdvOrany;

                    }


                    Console.WriteLine("Vitaminler Güncel Fiyat : " + vitaminler.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }
                

                if (input5 == "5")
                {

                    Console.Write("Minareller KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOrany;
                        string inputay1;

                        do
                        {
                            Console.Write("Minareller KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputay1 = Console.ReadLine();

                        } while (!double.TryParse(inputay1, out kdvOrany) || kdvOrany > 1.20);

                        minareller.kdv = kdvOrany;
                    }

                    Console.Write("Minareller İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevapx1 = Console.ReadLine().ToUpper();

                    if (cevapx1 != "E" && cevapx1 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevapx1 = Console.ReadLine().ToUpper();
                        } while (cevapx1 != "E" && cevapx1 != "H");
                    }

                    if (cevapx1.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Minareller indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);

                        vitaminler.indirim1 = kdvOrany1;

                      
                    }
                    Console.WriteLine("Minareller Güncel Fiyat : " + vitaminler.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }
              

                if (input5 == "6")
                {
                    Console.Write("Kumlar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOran1x;
                        string inputay2;

                        do
                        {
                            Console.Write("Kumlar KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputay2 = Console.ReadLine();

                        } while (!double.TryParse(inputay2, out kdvOran1x) || kdvOran1x > 1.20);

                        kumlar.kdv = kdvOran1x;
                    }



                    Console.Write("Kumlar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevapx11 = Console.ReadLine().ToUpper();

                    if (cevapx11 != "E" && cevapx11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevapx11 = Console.ReadLine().ToUpper();
                        } while (cevapx11 != "E" && cevapx11 != "H");
                    }
                    if (cevapx11.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Kumlar indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);

                        kumlar.indirim1 = kdvOrany1;


                        
                    }

                    Console.WriteLine("Kumlar Güncel Fiyat : " + kumlar.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }

                if (input5 == "7")
                {
                    Console.Write("Kafesler KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOranx11;
                        string inputax11;

                        do
                        {
                            Console.Write("Kafesler KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.20);

                        kafesler.kdv = kdvOranx11;


                    }
                    Console.Write("Kafesler İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevapp1 = Console.ReadLine().ToUpper();

                    if (cevapp1 != "E" && cevapp1 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevapp1 = Console.ReadLine().ToUpper();
                        } while (cevapp1 != "E" && cevapp1 != "H");
                    }


                    if (cevapp1.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("kafesler indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);

                        kafesler.indirim1 = kdvOrany1;
                    }
                    Console.WriteLine("Kafesler Güncel Fiyat : " + kafesler.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }
                if (input5 == "8")
                {
                    Console.Write("Aksesuar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOran;
                        string inputa;

                        do
                        {
                            Console.Write("Aksesuar KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputa = Console.ReadLine();

                        } while (!double.TryParse(inputa, out kdvOran) || kdvOran > 1.20);

                        aksesuar.kdv = kdvOran;
                    }

                    Console.Write("Aksesuar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevap = Console.ReadLine().ToUpper();

                    if (cevap != "E" && cevap != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap = Console.ReadLine().ToUpper();
                        } while (cevap != "E" && cevap != "H");
                    }


                    if (cevap.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Aksesuar indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);


                        aksesuar.indirim1 = kdvOrany1;
                        
                    }
                    Console.WriteLine("Aksesuar Güncel Fiyat : " + aksesuar.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }

                if (input5 == "9")
                {
                    Console.Write("Yuvalar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOranx2;
                        string inputax2;

                        do
                        {
                            Console.Write("Yuvalar KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputax2 = Console.ReadLine();

                        } while (!double.TryParse(inputax2, out kdvOranx2) || kdvOranx2 > 1.20);


                        yuvalar.kdv = kdvOranx2;

                    }

                    Console.Write("Yuvalar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevap2 = Console.ReadLine().ToUpper();

                    if (cevap2 != "E" && cevap2 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap2 = Console.ReadLine().ToUpper();
                        } while (cevap2 != "E" && cevap2 != "H");
                    }


                    if (cevap2.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Yuvalar indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);


                        yuvalar.indirim1 = kdvOrany1;


                    }
                    Console.WriteLine("Yuvalar Güncel Fiyat : " + yuvalar.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }
                if (input5 == "10")
                {
                    Console.Write("Yataklar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOran12;
                        string input;

                        do
                        {
                            Console.Write("Yataklar KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            input = Console.ReadLine();

                        } while (!double.TryParse(input, out kdvOran12) || kdvOran12 > 1.20);

                        yataklar.kdv = kdvOran12;

                    }

                    Console.Write("Yataklar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevapw = Console.ReadLine().ToUpper();

                    if (cevapw != "E" && cevapw != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevapw = Console.ReadLine().ToUpper();
                        } while (cevapw != "E" && cevapw != "H");
                    }


                    if (cevapw.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Yataklar indirim fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);

                        yataklar.indirim1 = kdvOrany1;
                       
                    }
                    Console.WriteLine("Yataklar Güncel Fiyat : " + yataklar.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın *_* : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }

                if (input5 == "11")
                {
                    Console.Write("Kıyafet KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {
                        double kdvOran1;
                        string inputa1;

                        do
                        {
                            Console.Write("Kıyafet KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputa1 = Console.ReadLine();

                        } while (!double.TryParse(inputa1, out kdvOran1) || kdvOran1 > 1.20);

                        kıyafet.kdv = kdvOran1;
                    }

                    Console.Write("Kıyafet İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string cevap1w = Console.ReadLine().ToUpper();

                    if (cevap1w != "E" && cevap1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            cevap1w = Console.ReadLine().ToUpper();
                        } while (cevap1w != "E" && cevap1w != "H");
                    }

                    if (cevap1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Kıyafet fiyatı en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);

                        kıyafet.indirim1 = kdvOrany1;


                       
                    }
                    Console.WriteLine("Kıyafet Güncel Fiyat : " + kıyafet.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }
                if (input5 == "12")
                {
                    Console.Write("Aşı KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {


                        double kdvOrans;
                        string inputas;

                        do
                        {
                            Console.Write(" Aşı KDV oranını girin: 1.20den fazla kdv yapamazsın ");
                            inputas = Console.ReadLine();

                        } while (!double.TryParse(inputas, out kdvOrans) || kdvOrans > 1.20);

                        aşı.kdv = kdvOrans;
                    }

                    Console.Write("Aşı İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }


                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Aşı İndirim oranı  en fazla 1.20 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.20);

                        aşı.indirim1 = kdvOrany1;


                        
                    }
                    Console.WriteLine("Aşı Güncel Fiyat : " + aşı.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }


                }
            }
         
            //---------------------------------------------------------------------------------------------------

            if (sifre5.ToUpper() == "CALISAN")
            {
                int sayi5;
                string input5;

                do
                {
                    Console.Write("Sampuan Lütfen listeye bir sayı girin: ");
                    input5 = Console.ReadLine();
                } while (!int.TryParse(input5, out sayi5));



                if (input5 == "1")
                {
                    Console.Write("Sampuan KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11 == "E")
                    {

                        double kdvOranx11;
                        string inputax11;

                        do
                        {
                            Console.Write("Sampuan KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        sampuan.kdv = kdvOranx11;
                    }

                    Console.Write("Sampuan İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }


                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Sampuan İndirim oranı  1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        sampuan.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Sampuan Güncel Fiyat : " + sampuan.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }
                if (input5 == "2")
                {

                    Console.Write("Mama KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }


                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Mama KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        mama.kdv = kdvOranx11;
                    }
                    Console.Write("Mama İndirim oranı değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva1w = Console.ReadLine();
                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Mama İndirim oranı  en fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        mama.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Mama Güncel Fiyat: : " + mama.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }
                if (input5 == "3")
                {
                    Console.Write("Sukap KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Sukap KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        sukap.kdv = kdvOranx11;
                    }

                    Console.Write("Sukap İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();


                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Sukap  İndirim oranı  en fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        sukap.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Güncel Fiyat: " + sukap.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }
                if (input5 == "4")
                {
                    Console.Write("Vitaminler KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Vitaminler KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        vitaminler.kdv = kdvOranx11;
                    }
                    Console.Write("Vitaminler İndirim oranı  değiştirmek  istiyomusunuz (E/H) : ");
                    string ceva1w = Console.ReadLine();


                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Vitaminler İndirim oranı  en fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        vitaminler.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Vitaminler Güncel Fiyat : " + vitaminler.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }

                if (input5 == "5")
                {
                    Console.Write("Minareller KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Minareller KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        minareller.kdv = kdvOranx11;
                    }
                    Console.Write("Minareller İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }



                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Minareller İndirim oranı  fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        minareller.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Minareller Güncel Fiyat:: " + minareller.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }
                if (input5 == "6")
                {
                    Console.Write("Kumlar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Kumlar KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        kumlar.kdv = kdvOranx11;
                    }
                    Console.Write("Kumlar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Kumlar İndirim oranı  girin (1.10dan fazla giremezsin!) :");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        kumlar.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Güncel Fiyat: : " + kumlar.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }

                }

                if (input5 == "7")
                {
                    Console.Write("Kafesler KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;

                    do
                    {
                        Console.Write("Kafesler KDV oranını girin (1.10dan fazla giremezsin!) : ");
                        inputax11 = Console.ReadLine();

                    } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                    kafesler.kdv = kdvOranx11;

                    Console.Write("Kafesler İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;
                        if (ceva11.ToUpper() == "E")
                        {
                            do
                            {
                                Console.Write("Kafesler fiyatı en fazla 1.10 yazabilirsiniz : ");
                                inputy = Console.ReadLine();

                            } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                            kafesler.indirim1 = kdvOrany1;
                        }

                    }

                    Console.WriteLine("Kafesler Güncel Fiyat: : " + kafesler.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }


                if (input5 == "8")
                {
                    Console.Write("Aksesuar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Aksesuar KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        aksesuar.kdv = kdvOranx11;
                    }
                    Console.Write("Aksesuar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                        string ceva1w = Console.ReadLine().ToUpper();
                   
                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Aksesuar İndirim oranı en fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        aksesuar.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Aksesuar Güncel Fiyat: : " + aksesuar.KDVhesapla());
                }
                if (input5 == "9")
                {
                    Console.Write("Yuvalar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Yuvalar KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        yuvalar.kdv = kdvOranx11;
                    }
                    Console.Write("Yuvalar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }
                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Yuvalar  fiyatı en fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        yuvalar.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Yuvalar Güncel Fiyat: : " + yuvalar.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }
                if (input5 == "10")
                {
                    Console.Write("Yataklar KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    double kdvOranx11;
                    string inputax11;
                    if (ceva11.ToUpper() == "E")
                    {
                        do
                        {
                            Console.Write("Yataklar KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        yataklar.kdv = kdvOranx11;
                    }
                    Console.Write("Yataklar İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Yataklar  fiyatı en fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        yataklar.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Yataklar Güncel Fiyat:: " + yataklar.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }




                if (input5 == "11")
                {
                    Console.Write("Kıyafet KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }

                    if (ceva11.ToUpper() == "E")
                    {
                        double kdvOranx11;
                        string inputax11;

                        do
                        {
                            Console.Write("Kıyafet KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        kıyafet.kdv = kdvOranx11;
                    }

                    Console.Write("Kıyafet İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }

                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Kıyafet  İndirim oranı 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        kıyafet.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Kıyafet Güncel Fiyat: : " + kıyafet.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }

                if (input5 == "12")
                {
                    Console.Write("Aşı KDV değiştirmek  istiyomusunuz (E/H) : ");//-------------------kdv de iki soru olacak alt soru e ve h
                    string ceva11 = Console.ReadLine().ToUpper();
                    if (ceva11 != "E" && ceva11 != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva11 = Console.ReadLine().ToUpper();
                        } while (ceva11 != "E" && ceva11 != "H");
                    }
                    if (ceva11.ToUpper() == "E")
                    {
                        double kdvOranx11;
                        string inputax11;

                        do
                        {
                            Console.Write("Aşı KDV oranını girin (1.10dan fazla giremezsin!) : ");
                            inputax11 = Console.ReadLine();

                        } while (!double.TryParse(inputax11, out kdvOranx11) || kdvOranx11 > 1.10);

                        aşı.kdv = kdvOranx11;
                    }
                    Console.Write("aşı İndirim değiştirmek  istiyomusunuz (E/H)  : ");
                    string ceva1w = Console.ReadLine().ToUpper();

                    if (ceva1w != "E" && ceva1w != "H")
                    {


                        do
                        {
                            Console.Write(" (E/H)'den başka değer giremesiniz  : ");
                            ceva1w = Console.ReadLine().ToUpper();
                        } while (ceva1w != "E" && ceva1w != "H");
                    }


                    if (ceva1w.ToUpper() == "E")
                    {


                        double kdvOrany1;
                        string inputy;

                        do
                        {
                            Console.Write("Aşı İndirim oranı en fazla 1.10 yazabilirsiniz : ");
                            inputy = Console.ReadLine();

                        } while (!double.TryParse(inputy, out kdvOrany1) || kdvOrany1 > 1.10);

                        aşı.indirim1 = kdvOrany1;

                    }

                    Console.WriteLine("Aşı Güncel Fiyat: : " + aşı.KDVhesapla());
                    string don;
                    do
                    {
                        Console.WriteLine("Bir önceki menüye dönmek için 0(sıfır) basın : ");
                        don = Console.ReadLine().ToUpper();

                    } while (don != "0");
                    if (don == "0")
                    {
                        goto urunkdv;
                    }
                }


            }












        }


        Console.ReadKey();
    }



}




*/