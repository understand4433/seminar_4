

int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int searchFactorial(int number){
    int i = 1;
    int result = 1;
    while(i <= number){
        result *= i;
        i++;
    }
    return result;
}

int number = enterInteger("Введите число: ");
Console.WriteLine(searchFactorial(number));