
int operationType,valueA=5,valueB=9;
Console.WriteLine("0,1,2,3 gibi bir değer giriniz");
operationType = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İlk sayıyı giriniz");
valueA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz");
valueB = Convert.ToInt32(Console.ReadLine());
Operations selectedOperation = (Operations)operationType;


switch (selectedOperation)
{
    case Operations.Sum:
        Console.WriteLine($"{valueA}+{valueB}={valueA + valueB}");
        break;
    case Operations.Minus:
        Console.WriteLine($"{valueA}-{valueB}={valueA - valueB}");
        break;
    case Operations.Multiply:
        Console.WriteLine($"{valueA}*{valueB}={valueA * valueB}");
        break;
    case Operations.Divide:
        Console.WriteLine($"{valueA}/{valueB}={valueA / valueB}");
        break;
    default:
        Console.WriteLine($"\nCould not run any of operations: ");
        string[] allOperationNames = Operations.GetNames(typeof(Operations));
        foreach (var item in allOperationNames)
        {
            Console.WriteLine(item);
        }
        break;
}
public enum Operations
{
    Sum,
    Minus,
    Multiply,
    Divide,
}



