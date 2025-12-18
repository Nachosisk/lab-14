Console.Write("Введите путь к файлу: ");
string path = Console.ReadLine();  //C:\File\File.txt 
if (string.IsNullOrWhiteSpace(path))
{
    Console.WriteLine("Путь не может быть пустым!");
    return;
}
else if (!File.Exists(path))
{
    Console.WriteLine("Файл не найден!");
    return;
}
string filetext = File.ReadAllText(path);
Console.WriteLine();
Console.WriteLine($"Вывод текста из файла: {filetext}");
Console.WriteLine();