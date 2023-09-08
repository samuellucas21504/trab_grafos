using System.Text;
using trabalho_grafos_8_09.entrypoint;

namespace trabalho_grafos_8_09;

class ListGraph : Graph
{
    private readonly List<string> _node;
    private List<string> _arestasStringArray = new();
    
    private ListGraph(Dictionary<string, List<string>> graph) : base(graph.Count)
    {
        _node = graph.Keys.ToList();

        CreateMathematicRepresentation(graph);
        CreateNodeDegree(graph);
    }

    private void CreateNodeDegree(Dictionary<string, List<string>> graph)
    {
        var builder = new StringBuilder();
        foreach (var vertice in _node)
        {
            var graphSize = graph[vertice].Count;
            var graphType = graphSize % 2 == 0 ? "par" : "ímpar";
            builder.AppendLine($"{vertice}: {graphSize} e é {graphType}");
        }

        NodeDegree = builder.ToString();
    }

    public static ListGraph Create(string _path)
    {
        var lines = FileReader.Read(_path);

        var graph = new Dictionary<string, List<string>>();

        foreach (var line in lines)
        {
            var nodeEdges = line.Split(":");
            var edgesString = nodeEdges[1].Trim();

            var edges = edgesString.Split(" ");
            
            graph.Add(nodeEdges[0], edges.ToList());
        }

        return new ListGraph(graph);
    }

    protected override string CreateMatheticRepresentationString()
    {
        var builder = new StringBuilder();

        builder.AppendLine("Forma Matemática");
        builder.AppendLine($"Vértices {string.Join(",", _node)}");
        builder.AppendLine("Arestas: {");
        builder.AppendLine(string.Join(",\n", _arestasStringArray));
        builder.AppendLine("}\n");
        
        return builder.ToString();
    }
    
    private void CreateMathematicRepresentation(Dictionary<string, List<string>> grafo)
    {
        foreach(var node in _node){
            foreach (var edge in grafo[node]) {
                if (edge == node)
                {
                    Loops += $"{node} tem um laço";
                }
                _arestasStringArray.Add("\t{" + node + ", " + edge + "}");
            }
        }
    }
}