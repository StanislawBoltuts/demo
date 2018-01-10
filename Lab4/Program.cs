using System;
using System.IO;
using System.Linq;
using Lab4XML.BL;
using Lab4XML.Properties;

namespace Lab4XML
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var xmls = Directory
                .GetFiles("C:\\Users\\User\\Desktop\\LABS_NET\\Lab4\\data\\xml")
                .Select(File.OpenRead)
                .ToArray();

            var searcher = new XmlFilesSearcher(Settings.Default.ThreadsCount);
            var result = searcher.Search(xmls, Settings.Default.SearchXPath);

            result
                .OrderBy(kv => kv.Key)
                .ToList()
                .ForEach(kv =>
                {
                    Console.WriteLine($"{(String.IsNullOrEmpty(kv.Key) ? "N/A" : kv.Key)}, {kv.Value}");
                });

            Console.ReadLine();
        }
    }
}