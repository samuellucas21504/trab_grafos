using System.Text;
using trabalho_grafos_8_09;

enum TipoGrafo {LIST = 1 , ARRAY = 2}

class Program{
    public static String PATH = "assets/grafo.txt";
    
    public static void Main()
    {
        Console.WriteLine("Selecione o tipo de grafo que voce deseja");
        Console.WriteLine("1 - Grafo de Lista");

        var tipoGrafo = Console.ReadLine();
        Console.WriteLine(tipoGrafo);

        while (tipoGrafo != ((int) TipoGrafo.LIST).ToString() && tipoGrafo != ((int) TipoGrafo.ARRAY).ToString())
        {
            Console.Clear();
            Console.WriteLine("Tipo inválido. Digite um valor válido.");
            Console.WriteLine("Selecione o tipo de grafo que voce deseja");
            Console.WriteLine("1 - Grafo de Lista");
            
            tipoGrafo = Console.ReadLine();
        }
        
        Console.Clear();

        if(tipoGrafo == ((int) TipoGrafo.LIST).ToString()) listGraph();
        
    }

    public static void listGraph()
    {
        PrintListGraphMenu();
        var graph = ListGraph.Create(PATH);
        var idk = true;
        
        
        while (idk)
        {
            var value = Console.ReadLine();
            switch (value)
            {
                case "1":
                    PrintListGraphMenu();
                    break; ;
                case "2":
                    Console.WriteLine(graph.MathematicRepresentation);
                    break;
                case "3":
                    Console.WriteLine(graph.Order);
                    break;
                case "4":
                    Console.WriteLine(graph.NodeDegree);
                    break;
                case "5": 
                    Console.WriteLine(graph.Loops);
                    break;
                case "6": 
                    Console.WriteLine(byeMessage());
                    idk = false;
                    break;
                default:
                    Console.WriteLine("Digite um valor válido!");
                    break;
            }
        }
    }
    
    
    public static String byeMessage()
    {
        var builder = new StringBuilder();

        builder.AppendLine("  ______     __                      _       __        ");
        builder.AppendLine(" /_  __/____/ /_  ____ ___  ______  (_)___  / /_  ____ ");
        builder.AppendLine("  / / / ___/ __ \\/ __ `/ / / /_  / / / __ \\/ __ \\/ __ \\");
        builder.AppendLine(" / / / /__/ / / / /_/ / /_/ / / /_/ / / / / / / / /_/ /");
        builder.AppendLine("/_/  \\___/_/ /_/\\__,_/\\__,_/ /___/_/_/ /_/_/ /_/\\____/ ");
        builder.AppendLine("                                                       ");

        return builder.ToString();
    }

    public static void PrintListGraphMenu()
    {
        var builder = new StringBuilder();
        
        builder.AppendLine("1- Mostrar o menu");
        builder.AppendLine("2- Imprimir a representação matemática do grafo");
        builder.AppendLine("3- Calcular a ordem do grafo");
        builder.AppendLine("4- Determinar o grau de um vértice e se é grau par");
        builder.AppendLine("5- Verificar se algum vértice tem laço");
        builder.AppendLine("6- Sair");
        
        Console.WriteLine(builder.ToString());
    }
}

