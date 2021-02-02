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
            string str = "";
            foreach (var it in m)
                str += it;
            return str;
        }
        public Yitstona(string key1, string key2)
        {
            Key1 = new string(key1.Distinct().ToArray());
            Key2 = new string(key2.Distinct().ToArray());
            int k = 0;
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
            Console.WriteLine("kvadrat 1");
            vivod_kv(kv1);
            Console.WriteLine("kvadrat 2");
            vivod_kv(kv2);
        }
        public void vivod_kv(char[,] kv)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(kv[i, j] + " ");
                Console.WriteLine();
            }
        }
        public string Zawifr(string fraza)
        {
            string answer = "";
            bool for_break = false;
            if (fraza.Length % 2 != 0)
                fraza += " ";
            for (int i = 0; i < fraza.Length - 1; i++)
            {
                for_break = false;
                for (int k = 0; k < kv1.GetLength(0); k++)
                {
                    if (for_break == true)
                        break;
                    for (int j = 0; j < kv1.GetLength(1); j++)
                    {
                        if (for_break == true)
                            break;
                        if (fraza[i] == kv1[k, j])
                            for (int k1 = 0; k1 < kv1.GetLength(0); k1++)
                            {
                                if (for_break == true)
                                    break;
                                for (int j1 = 0; j1 < kv1.GetLength(1); j1++)
                                    if (fraza[i + 1] == kv2[k1, j1])
                                    {
                                        answer += kv2[k, j1];
                                        answer += kv1[k1, j];
                                        for_break = true;
                                        break;
                                    }
                            }
                    }
                }
                i++;
            }
            return answer;
        }
        public string Raswifr(string fraza)
        {
            string answer = "";
            bool for_break = false;
            if (fraza.Length % 2 != 0)
                fraza += " ";
            for (int i = 0; i < fraza.Length - 1; i++)
            {
                for_break = false;
                for (int k = 0; k < kv1.GetLength(0); k++)
                {
                    if (for_break == true)
                        break;
                    for (int j = 0; j < kv1.GetLength(1); j++)
                    {
                        if (for_break == true)
                            break;
                        if (fraza[i+1] == kv1[k, j])
                            for (int k1 = 0; k1 < kv1.GetLength(0); k1++)
                            {
                                if (for_break == true)
                                    break;
                                for (int j1 = 0; j1 < kv1.GetLength(1); j1++)
                                    if (fraza[i] == kv2[k1, j1])
                                    {
                                        answer += kv1[k1, j];
                                        answer += kv2[k, j1];
                                        for_break = true;
                                        break;
                                    }
                            }
                    }
                }
                i++;
            }
            return answer;
        }
    }
}
