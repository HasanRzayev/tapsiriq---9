using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq___9
{

    delegate void Func(string a);

    class MyClass
    {
        public MyClass(string str)
        {
            this.str = str;
        }

        public string str { get; set; }

        public void Space( string str) {

            var num=str.Length;
            int i = 1;
            while (true) { 
                if (i == num+num-1) break;
                if (str[i] == '_')
                {
                    i++;
                    continue;
                }
             
                str=str.Insert(i,"_");
                i+=2;
            }
       
            Console.WriteLine(str);
        }
        public void Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            
            Console.WriteLine(charArray);
        }
    }
}
