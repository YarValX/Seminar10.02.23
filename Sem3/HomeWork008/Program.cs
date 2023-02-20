string ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}

bool ispalindrome(string number)

{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Это палиндром.");
        return true;
    }
    else 
    {
        Console.WriteLine("Это не палиндром!");
        return false;     
    }
}


string number = ReadInt("Введите пятизначное число: ");

bool result = ispalindrome(number);
