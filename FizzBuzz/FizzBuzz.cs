namespace FizzBuzz;

public class FizzBuzz
{
    public static string Calculate(int numeral)
    {
        if (numeral == 0) 
            return "";

        var fizz = numeral % 3 == 0 ? "Fizz" : "";
        var buzz = numeral % 5 == 0 ? "Buzz" : "";

        return $"{fizz}{buzz}";
    }
}