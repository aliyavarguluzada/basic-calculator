Console.WriteLine("Enter the first number");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
string data1 = Console.ReadLine();

int firstNumber;
Console.WriteLine("Enter the second number");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
string data2 = Console.ReadLine();
int secondNumber;

Console.WriteLine("Enter the arithmetic operator");
string symbol = Console.ReadLine();

char sym;
int result = 0;

bool case1 = char.TryParse(symbol, out sym);
bool case2 = int.TryParse(data1, out firstNumber);
bool case3 = int.TryParse(data2, out secondNumber);




if (case2 == true)
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("firstNumber is incorrect");
}

if(case3 == true)
{
    Console.WriteLine();
}else
{
    Console.WriteLine("secondNumber is incorrect");
}

if (case1 == true)
{
    Console.WriteLine("everything is okay");
}
Console.WriteLine(case1);


if (symbol == "+")
{
    result = firstNumber + secondNumber;
}
else if (symbol == "-")
{
    result = firstNumber - secondNumber;
}
else if (symbol == "*")
{
    result = firstNumber * secondNumber;
}
else if (symbol == "/")
{
    result = firstNumber / secondNumber;
}
else
{
    Console.WriteLine("an error has occured");
}

Console.WriteLine(result);