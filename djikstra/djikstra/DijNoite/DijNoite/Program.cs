using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijNoite
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo oGrafo = new Grafo(null);
            oGrafo.NovoVertice("A");        // 0
            oGrafo.NovoVertice("B");        // 1 
            oGrafo.NovoVertice("C");        // 2
            oGrafo.NovoVertice("D");        // 3
            oGrafo.NovoVertice("E");        // 4
            oGrafo.NovoVertice("F");        // 5
            oGrafo.NovoVertice("G");        // 6
            oGrafo.NovaAresta(0, 1, 2);     // A --> B = 2
            oGrafo.NovaAresta(0, 3, 1);     // A --> D = 1
            oGrafo.NovaAresta(1, 3, 3);     // B --> D = 3
            oGrafo.NovaAresta(1, 4, 10);    // B --> E = 10
            oGrafo.NovaAresta(2, 5, 5);     // C --> F = 5
            oGrafo.NovaAresta(2, 0, 4);     // C --> A = 4
            oGrafo.NovaAresta(3, 2, 2);     // D --> C = 2
            oGrafo.NovaAresta(3, 5, 8);     // D --> F = 8
            oGrafo.NovaAresta(3, 4, 2);     // D --> E = 2
            oGrafo.NovaAresta(3, 6, 4);     // D --> G = 4
            oGrafo.NovaAresta(4, 6, 6);     // E --> G = 6
            oGrafo.NovaAresta(6, 5, 1);     // G --> F = 1
            Console.WriteLine();
            Console.WriteLine("Menores caminhos:");
            Console.WriteLine();
            Console.WriteLine(oGrafo.Caminho(2, 4));
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
