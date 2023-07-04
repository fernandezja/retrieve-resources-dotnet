using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Apps.ConsoleAppNet48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starwars Quotes: Retrieve resources in .NET 4.8 from assembly (class library)");
            Console.WriteLine();

            Console.WriteLine("Retrieve resources ");

            Console.WriteLine($"    > Yoda Quote 1 : {Starwars.Core.Resources.JediResources.Quote1}");
            Console.WriteLine($"    > Yoda Quote 2 : {Starwars.Core.Resources.JediResources.Quote2}");


            var coreResourcesMain = new Core.Resources.CoreResourcesMain();

            Console.WriteLine("Retrieve resources with Build Action \"Content\" ");

            Console.WriteLine($"    > Leia's Quotes : {coreResourcesMain.GetResources2ContentLeiaQuotes()}");

            Console.WriteLine("Retrieve resources with Build Action \"Embedded Resource\"  ");
            Console.WriteLine($"    > Darth Vader's  Quotes : {coreResourcesMain.GetResources3EmbeddedResourceDarthVaderQuotes()}");


            Console.ReadKey();
        }
    }
}
