#:package Colorful.Console@1.2.15

// Tutorial for a File based dotnet app
Console.WriteLine("Hello, World!");

if (args.Length > 0)
{
    string mssg =  string.Join(' ', args);
    Console.WriteLine(mssg);
}
else
{
    while (Console.ReadLine() is string line && line.Length > 0)
    {
        Colorful.Console.WriteAscii(line);
    }
}
