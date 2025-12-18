Console.WriteLine("введите путь");//C:\\lab\\14\\text.txt
string path = Console.ReadLine();
using (StreamReader z = new StreamReader(path))
{
    string a = z.ReadToEnd();
    string newpath = "C:\\lab\\14\\text.txt";
    FileInfo file = new FileInfo(newpath);
    if (file.Exists)
    {
        using (StreamWriter o = new StreamWriter(newpath))
        {
            o.WriteLine(a);
        }
    }
    else
    {
        file.Create();
        using (StreamWriter o = new StreamWriter(newpath))
        {
            o.WriteLine(a);
        }
    }
    using (StringReader v = new StringReader(newpath))
    {
        string b = v.ReadToEnd();
        Console.WriteLine(b);
    }
}