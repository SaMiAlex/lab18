using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string[] array = new string[] { "(", ")", "[", "]" };//формируем строку
            list.AddRange(array);

            foreach (string l in list)//выводим строку на консоль
            {
                Console.Write(l);
            }            
            Console.WriteLine();

            Stack<string> br = new Stack<string>();//создаем стек

            for (int i = 0; i < list.Count; i++)//заполняем стек
            {
                if (list[i] == "(")
                {
                    br.Push(")");
                }
                else if (list[i] == "[")
                {
                    br.Push("]");
                }
                else if (list[i] == "{")
                {
                    br.Push("}");
                }

                else if (br.Count > 0 && list[i] == br.Peek())//если очередной символ совпал с верхушкой стека, возвращаем его на место 
                {
                    br.Pop();
                }
                else
                if (list[i] == ")" || list[i] == "]" || list[i] == "}")//если сначала встретилась закрывающая скобка
                {
                    br.Push("|");//добавляем любой символ в стек
                    break;
                }
            }
            if (br.Count == 0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Not OK");
            }

            Console.ReadKey();
        }
    }
}
