namespace trabalho_grafos_8_09.entrypoint;

public static class FileReader
{
    public static List<string> Read(string path)
    {
        Console.WriteLine("-------------------------");
        var lines = new List<string>();
        
        using var reader = File.OpenText(path);
        Console.WriteLine("Grafo:");
        while (reader.ReadLine() is { } line)
        {
            Console.WriteLine(line);
            lines.Add(line);
        }
        Console.WriteLine("-------------------------");

        return lines;
    }
}