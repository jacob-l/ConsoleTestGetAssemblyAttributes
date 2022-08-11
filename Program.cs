using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleTestGetAssemblyAttributes
{
    public class Program
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Assembly:");
            var assembly = Assembly.GetEntryAssembly();

            var attributes = Attribute.GetCustomAttributes(assembly, typeof(AssemblyMetadataAttribute))
                .OfType<AssemblyMetadataAttribute>().ToList();

            sb.AppendLine(assembly.FullName + ":");

            foreach (var att in attributes)
            {
                sb.AppendLine(att.Key + " - " + att.Value);
            }

            Console.WriteLine("------");
            Console.WriteLine(sb);
        }
    }
}