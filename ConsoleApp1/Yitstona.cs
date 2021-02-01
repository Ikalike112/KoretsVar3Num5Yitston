using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Yitstona
    {
        List<char> alf1 = new List<char> { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', ' ', ',', '.' };
        List<char> alf2 = new List<char> { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', ' ', ',', '.' };
        public char[,] kv1 = new char[6, 6];
        public char[,] kv2 = new char[6, 6];
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public Yitstona()
        {

        }
        private string GetText(char[,] m)
        {
            string str="";
            foreach (var it in m)
                str += it;
            return str;
        }
        public Yitstona(string key1, string key2)
        {
            Key1 = new string(key1.Distinct().ToArray());
            Key2 = new string(key2.Distinct().ToArray());
            int k = 0;
            int k_alf1 = 0;
            int k_alf2 = 0;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                {
                    if (k < Key1.Length)
                    {
                        kv1[i, j] = Char.ToUpper(Key1[k]);
                        alf1.Remove(Char.ToUpper(Key1[k]));
                    }
                    else
                    {
                        try
                        {
                            
                            if (!GetText(kv1).Contains(alf1[0]))// ne soderwit bykvy
                                kv1[i, j] = alf1[0];
                            alf1.RemoveAt(0);
                        }
                        catch
                        {

                        }
                    }
                    if (k < Key2.Length)
                    {
                        kv2[i, j] = Char.ToUpper(Key2[k]);
                        alf2.Remove(Char.ToUpper(Key2[k]));
                    }
                    else
                    {
                        try
                        {
                            if (!GetText(kv2).Contains(alf2[0]))// ne soderwit bykvy
                                kv2[i, j] = alf2[0];
                            alf2.RemoveAt(0);
                        }
                        catch
                        {

                        }
                    }
                    k++;
                }
            Console.WriteLine(GetText(kv1));// vivod pervogo kvadrata
        }

    }
}
