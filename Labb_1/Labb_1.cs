
Console.WriteLine("Skriv ett gäng med tecken, helst siffror...;)");
string input = Console.ReadLine();

//string input = "29535123p48723487597645723645";
// hasMatch =   tfttffffftt

bool test = input[0] == input[1];
char referenceChar;
char currentChar;
bool[] hasMatch = new bool[input.Length];
for (int i = 0; i < input.Length; i++)
{
    referenceChar = input[i];
    hasMatch[i] = false;
    // "om INTE tecknet är en siffra i input (i)" =
    // "om tecknet i input (i) är en bokstav "
    //if (!char.IsDigit(input[i]))
    if (!char.IsDigit(referenceChar))
    {
        continue;
    }
    for (int j = i + 1; j < input.Length; j++)
    {
        currentChar = input[j];
        if (referenceChar == currentChar)
        {
            hasMatch[i] = true;
            break;
        }
        if (!char.IsDigit(currentChar))
        {
            break;
        }
    }
}



//for (int i = 0; i < hasMatch.Length; i++)
//{
//    Console.WriteLine(hasMatch[i]);
//}




long result = 0;
//Console.WriteLine(GetColoredNumber(text: "29535123p48", startOfColor: 0));
//Console.WriteLine(GetColoredNumber(text: "29535123p48", startOfColor: 2));
//Console.WriteLine(GetColoredNumber(text: "29535123p48", startOfColor: 3));
//Console.WriteLine(GetColoredNumber(text: "29535123p48", startOfColor: 5));
//Console.WriteLine(GetColoredNumber(text: input, startOfColor: 0));
//Console.WriteLine(GetColoredNumber(text: input, startOfColor: 2));
//Console.WriteLine(GetColoredNumber(text: input, startOfColor: 3));
//Console.WriteLine(GetColoredNumber(text: input, startOfColor: 9));
//Console.WriteLine(GetColoredNumber(text: input, startOfColor: 14));
//Console.WriteLine(GetColoredNumber(text: input, startOfColor: 22));
// loopar igenom alla tecken i textsträngen input.
// det tecken som har en matchning ska skrivas ut.
for (int i = 0; i < input.Length; i++)
{
    if (hasMatch[i] == true)
    {
        // 1. skriv ut hela strängen med rätt färger.
        PrintFullString(text: input, startOfColor: i);
        // 2. låt result öka med värdet av det som är rött, för aktuell rad.
        result = result + GetColoredNumber(text: input, startOfColor: i);

    }
}

Console.WriteLine("***************************");
Console.WriteLine("The result of colored numbers is " + result);

void PrintFullString(string text, int startOfColor)
{
    Console.ForegroundColor = ConsoleColor.White;
    for (int i = 0; i < text.Length; i++)
    {
        if (i == startOfColor)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.Write(text[i]);

        if (text[i] == text[startOfColor] && i > startOfColor)
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
    Console.WriteLine();

}

//Text - använd inte

//startOfColor int
//i int
//text[startOfColor]char
//Text[i] char


//12345678901234567890


long GetColoredNumber(string text, int startOfColor)
{
    string digitString = string.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (i < startOfColor)
        {
            continue;
        }

        digitString = digitString + text[i];

        if (text[i] == text[startOfColor] && i > startOfColor)
        {
            break;
        }
    }
    return long.Parse(digitString);
}


//string test = "a,b";
//test = test + "c";



