namespace MainProject;

public class Helper
{
    public int Add(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    public string Greet(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return "Hello!";
        }
        
        return $"Hello, {name}!";
    }
}