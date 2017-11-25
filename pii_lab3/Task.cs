using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pii_lab3
{
    class Task
    {
        List<int> list = new List<int>();
        public void start()
        {
            list.Add(77);
            list.Add(12);
            list.Add(74);
            list.Add(34);
            list.Add(56);
            list.Add(78);
            list.Add(234);
            list.Add(678);
            foreach(int i in list){
                Console.Write(i + " ");
            }
            for(int i = 0;i < list.Count - 1; i++)
            {
                for(int j = i;j < list.Count; j++)
                {
                    if(list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            int value = 56;
            Console.WriteLine(list.IndexOf(value));
        }

    }
}
