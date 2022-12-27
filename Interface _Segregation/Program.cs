// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Interface Segregation Principle, bir nesnenin yapması gereken her farklı 
//davranışların, o davranışlara odaklanmış özel interface'ler ile 
//eşleşmesini öneren prensiptir.

interface IPrint
{
    public void Print();
}

interface IScan
{
    public void Scan();
}

interface IFax
{
    public void Fax();
}

interface IPrintDublex
{
    public void PrintDublex();
}

class HdPrinter : IPrint, IFax, IPrintDublex, IScan
{
    public void PrintDublex()
    {
        Console.WriteLine("Print Dublex");
    }

    public void Scan()
    {
        Console.WriteLine("Scan");
    }

    public void Fax()
    {
        Console.WriteLine("Fax");
    }

    public void Print()
    {
        Console.WriteLine("Print");
    }
}

class SamsungPrinter : IPrint, IFax
{
    public void Fax()
    {
        Console.WriteLine("Fax");
    }

    public void Print()
    {
        Console.WriteLine("Print");
    }
}

class LexmarpPrinter : IPrint, IScan, IFax
{
    public void Fax()
    {
        Console.WriteLine("Fax");
    }

    public void Print()
    {
        Console.WriteLine("Print");
    }

    public void Scan()
    {
        Console.WriteLine("Scan");
    }
}


