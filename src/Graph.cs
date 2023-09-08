namespace trabalho_grafos_8_09;

public abstract class Graph
{
    private string _loops = "";
    private string _nodeDegree;

    
    public int Order { get; }
    public string Loops
    {
        get => _loops;
        protected set => _loops = value;
    }
    public string MathematicRepresentation => CreateMatheticRepresentationString();
    public string NodeDegree
    {
        get => _nodeDegree;
        set => _nodeDegree = value;
    }
    
    public Graph(int order)
    {
        Order = order;

    }

    protected abstract string CreateMatheticRepresentationString();

}