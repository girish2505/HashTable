using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->Hash Table<--------");
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            MapNode<string, int> myMapNode = new MapNode<string, int>(6);
            switch (num)
            {
                case 1:
                    string[] words = {"to", "be", "or", "not", "to", "be"};
                    int count = 1;
                    foreach (string i in words)
                    {
                        count = myMapNode.CheckHash(i);
                        if (count > 1)
                        {
                            myMapNode.Add(i, count);
                        }
                        else
                        {
                            myMapNode.Add(i, 1);
                        }
                    }

                    IEnumerable<string> uniqueItems = words.Distinct<string>();
                    foreach (var i in uniqueItems)
                    {
                        myMapNode.Display(i);
                    }
                    break;
                case 2:

                    MapNode<string, int> maapNode = new MapNode<string, int>(10);
                    string[] Paragraph;
                    string input = "I had never eaten any kind of Thai food, so I was pretty excited about going to a Thai restaurant with my grandmother.";
                    Paragraph = input.Split(' ');
                    //Given string input

                    int counts = 1;
                    foreach (string i in Paragraph)
                    {
                        counts = maapNode.CheckHash(i);
                        if (counts > 1)
                        {
                            maapNode.Add(i, counts);
                        }
                        else
                        {
                            maapNode.Add(i, 1);
                        }
                    }
                    IEnumerable<string> distinct = Paragraph.Distinct<string>();
                    foreach (var i in distinct)
                    {
                        maapNode.Display(i);
                    }

                    break;
                default:
                    Console.WriteLine("Enter the valid number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
