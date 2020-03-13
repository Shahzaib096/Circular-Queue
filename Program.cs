using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuller_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Circuller_Queue CQ = new Circuller_Queue();
            int Option, Value;
            do
            {
                Console.WriteLine("Enter Option Number You Want To Perform On Circuller Queue !");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: EnQueue Value in Queue");
                Console.WriteLine("2: DeQueue Value From Queue");
                Console.WriteLine("3: Check Queue Is Full or Not?");
                Console.WriteLine("4: Check Queue Is Empty or Not?");
                Console.WriteLine("5: Count Items In Queue");
                Console.WriteLine("6: Display Values In Queue");
                Console.Write("Enter Option :");
                Option = int.Parse(Console.ReadLine());
                switch(Option)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Enter Value You Want To Enter In Queue :");
                        Value = int.Parse(Console.ReadLine());
                        CQ.EnQueue(Value);
                        Console.WriteLine("Value Added Successfully");
                        break;
                    case 2:
                        CQ.DeQueue();
                        Console.WriteLine("Value DeQueued From Queue !");
                        break;
                    case 3:
                        if(CQ.IsFull())
                        {
                            Console.WriteLine("Queue Is Full !");
                        }
                        else
                        {
                            Console.WriteLine("Queue Is Not Full ");
                        }
                        break;
                    case 4:
                        if (CQ.IsEmpty())
                        {
                            Console.WriteLine("Queue Is Empty !");
                        }
                        else
                        {
                            Console.WriteLine("Queue is Not Empty !");
                        }
                        break;
                    case 5:
                        Console.Write("Items In The Queue are :"+CQ.Count());
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("All Values In The Queue Are :");
                        CQ.Display();
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (Option != 0);
        }
    }
}
