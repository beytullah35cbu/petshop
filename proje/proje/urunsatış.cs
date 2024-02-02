


/*




using System;

class Urunsatısı
{
    static void Main(string[] args)
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


        satısmenusu:
        Sepet sepet = new Sepet();

        Console.WriteLine("1.Sampuan" + "\n" +
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
                         "12.Aşı"
                         );

       



        int sayı5;
        string uruncvp;

        do
        {
            Console.Write("Hangı urunu almak ıstıyorsunuz : ");
            uruncvp = Console.ReadLine();
        } while (!int.TryParse(uruncvp, out sayı5));


        if (uruncvp == "1")
        {
            Console.WriteLine("Ad :" + sampuan.ad+
                "\nFiyat : " + sampuan.gidişf +
                "\nKDV : " + sampuan.kdv+
                "\n İndirim : " + sampuan.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(sampuan);
           
            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen


        }
         else if (uruncvp == "2")
        {
            Console.WriteLine("Ad :" + mama.ad +
                "\nFiyat : " + mama.gidişf +
                "\nKDV : " + mama.kdv +
                "\n İndirim : " + mama.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(mama);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen


        }

        else if (uruncvp == "3")
        {
            Console.WriteLine("Ad :" + sukap.ad +
                "\nFiyat : " + sukap.gidişf +
                "\nKDV : " + sukap.kdv +
                "\n İndirim : " + sukap.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(sukap);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen


        }

        else if (uruncvp == "4")
        {
            Console.WriteLine("Ad :" + vitaminler.ad +
                "\nFiyat : " + vitaminler.gidişf +
                "\nKDV : " + vitaminler.kdv +
                "\n İndirim : " + vitaminler.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(vitaminler);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }


        else if (uruncvp == "5")
        {
            Console.WriteLine("Ad :" + minareller.ad +
                "\nFiyat : " + minareller.gidişf +
                "\nKDV : " + minareller.kdv +
                "\n İndirim : " + minareller.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(minareller);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }
        else if (uruncvp == "6")
        {
            Console.WriteLine("Ad :" + kumlar.ad +
                "\nFiyat : " + kumlar.gidişf +
                "\nKDV : " + kumlar.kdv +
                "\n İndirim : " + kumlar.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(kumlar);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }

        else if (uruncvp == "7")
        {
            Console.WriteLine("Ad :" + kafesler.ad +
                "\nFiyat : " + kafesler.gidişf +
                "\nKDV : " + kafesler.kdv +
                "\n İndirim : " + kafesler.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(kafesler);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }

        else if (uruncvp == "8")
        {
            Console.WriteLine("Ad :" + aksesuar.ad +
                "\nFiyat : " + aksesuar.gidişf +
                "\nKDV : " + aksesuar.kdv +
                "\n İndirim : " + aksesuar.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(aksesuar);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }
        else if (uruncvp == "9")
        {
            Console.WriteLine("Ad :" + yuvalar.ad +
                "\nFiyat : " + yuvalar.gidişf +
                "\nKDV : " + yuvalar.kdv +
                "\n İndirim : " + yuvalar.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(yuvalar);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }

        else if (uruncvp == "10")
        {
            Console.WriteLine("Ad :" + yataklar.ad +
                "\nFiyat : " + yataklar.gidişf +
                "\nKDV : " + yataklar.kdv +
                "\n İndirim : " + yataklar.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(yataklar);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }

        else if (uruncvp == "11")
        {
            Console.WriteLine("Ad :" + kıyafet.ad +
                "\nFiyat : " + kıyafet.gidişf +
                "\nKDV : " + kıyafet.kdv +
                "\n İndirim : " + kıyafet.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(kıyafet);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }
        else if (uruncvp == "12")
        {
            Console.WriteLine("Ad :" + aşı.ad +
                "\nFiyat : " + aşı.gidişf +
                "\nKDV : " + aşı.kdv +
                "\n İndirim : " + aşı.indirim1
                );

            int sayı6;
            string inputT;

            do
            {
                Console.Write("Satın almak istiyomusunuz(E/H) : ");
                inputT = Console.ReadLine().ToUpper();
            } while (inputT != "E" && inputT != "H");



            if (inputT.ToUpper() == "E")
            {
                sepet.Ekle(aşı);

            }


            string inputk;

            do
            {
                Console.Write("Satış menüsüne dönmek istiyomusunuz(E/H) : ");
                inputk = Console.ReadLine().ToUpper();
            } while (inputk != "E" && inputk != "H");

            if (inputk == "E")
            {
                goto satısmenusu;
            }
            // --------------------------------------------------------------------------buraya else diyerek en ana menüye dödericen
        }
        Console.ReadKey();

    }

}



*/







