using System;

namespace ODEV_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Ödevde toplam 4 adet problem var");
            Console.WriteLine("Kontrol etmek istediğiniz problem numarasını girmelisiniz");
            Console.WriteLine("1 den 4 e kadar bir tamsayı girin:");

            StringGirisKontrol instance =new StringGirisKontrol();
            if (instance.PozitifTamSayiMi(Console.ReadLine(),out int n) !=true){return;}
            switch (n)
            {
                case (1):
                Problem1();
                break;
                case (2):
                Problem2();
                break;
                case (3):
                Problem3();
                break;
                case (4):
                Problem4();
                break;
                default:
                Console.WriteLine("Geçerli bir değer girmediniz, işlem sonlandırıldı.");
                break;
            }

        }

        private static void Problem1()
        {
            Console.WriteLine("*** Ödevin 1. Problemi: ***");
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.WriteLine("Pozitif bir tamsayı girin:");
            int n = 0;
            StringGirisKontrol instance =new StringGirisKontrol();

            if (instance.PozitifTamSayiMi(Console.ReadLine(),out n) !=true){return;}
            Console.WriteLine("Toplam {0} adet pozitif tamsayı girilecektir",(n));

            int[] Tamsayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. pozitif tamsayıyı girin:", i + 1);
                if (instance.PozitifTamSayiMi(Console.ReadLine(),out int m) !=true){return;}
                Tamsayilar[i] = m;
            }

            for (int i = 0; i < n; i++)
            {
                if(Tamsayilar[i]%2==0)
                    Console.WriteLine(Tamsayilar[i]);
            }
        }

        private static void Problem2()
        {
            StringGirisKontrol instance =new StringGirisKontrol();
            Console.WriteLine("*** Ödevin 2. Problemi: ***");
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("İki adet pozitif tamsayı girilecektir");
            Console.WriteLine("1. pozitif tamsayı girin(n):");
            if (instance.PozitifTamSayiMi(Console.ReadLine(),out int n2) !=true){return;}
            Console.WriteLine("2. pozitif tamsayı girin(m):");
            if (instance.PozitifTamSayiMi(Console.ReadLine(),out int m2) !=true){return;}
            
            Console.WriteLine("Toplam {0} adet daha pozitif tamsayı girilecektir.", n2);
            int[] Tamsayilar2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("{0}. pozitif tamsayıyı girin:", i + 1);
                if (instance.PozitifTamSayiMi(Console.ReadLine(),out int mm) !=true){return;}
                Tamsayilar2[i] = mm;
            }

            for (int i = 0; i < n2; i++)
            {
                if(Tamsayilar2[i] % m2 == 0)
                    Console.WriteLine(Tamsayilar2[i]);
            }
        }

        private static void Problem3()
        {
            StringGirisKontrol instance =new StringGirisKontrol();
            Console.WriteLine("*** Ödevin 3. Problemi: ***");
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("Pozitif bir tamsayı girin:");
            if (instance.PozitifTamSayiMi(Console.ReadLine(),out int n) !=true){return;}
            Console.WriteLine("{0} adet kelime girilecektir", n);

            string[] strDizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. kelimeyi girin:", i + 1);
                strDizi[i] = Console.ReadLine();
            }

            for (int i = n-1; i > -1; i--)
            {
                Console.WriteLine(strDizi[i]);
            }

        }

        private static void Problem4()
        {
            // ******************    4. PROBLEM     ******************
            Console.WriteLine("*** Ödevin 4. Problemi: ***");
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            string cumle;
            Console.Write("Bir cümle giriniz:");
            cumle = Console.ReadLine().Trim();
            string[] kelimeler = cumle.Split(' ');
            string str = string.Join("", kelimeler);

            Console.WriteLine("Kelime Sayısı : " + kelimeler.Length);
            Console.WriteLine("Harf Sayısı : " + str.Length);       
        }
    }

    class StringGirisKontrol
    {
        public bool PozitifTamSayiMi(string str,out int n)
        {
            if ((int.TryParse(str, out n) == false) || (n<=0))
            {
                Console.WriteLine("Hatalı bir değer girdiniz işlem sonlandırıldı.");
                return false;
            }
            return true;
        }
    }
}
