using System;
using System.IO;
using System.Linq;

namespace DosyaIslemleri
{
    class Program
    {
        public static void DosyaOlustur()
        {
            #region random 
            Random random = new Random();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            string uret = "";
            int sayı = random.Next(20);
            for (int i = 0; i < sayı; i++)
            {
                uret += harfler[random.Next(harfler.Length)];
            }
            string dsname = uret;
            #endregion
            string path = @"C:\Users\mevlüt\Desktop\Yeni klasör\" + dsname + ".txt";
            File.Create(path);
            

        }

        public static void DosyaBoyutu() 
        {
            string path = @"C:\Users\mevlüt\Desktop\Yeni klasör";
            int[] size = new int[15];
            int i = 0;
            foreach (var item in Directory.GetFiles(path))
            {
                if (size.Contains((int)new FileInfo(item).Length))
                {
                    File.Delete(item);
                    continue;
                }
                size[i] = (int)new FileInfo(item).Length;
                i++;
            }
            
           
        




        }





        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
               DosyaOlustur();
                
            }
            File.Exists(@"C:\Users\mevlüt\Desktop\Yeni klasör");
            DosyaBoyutu();
        }
    }
}
