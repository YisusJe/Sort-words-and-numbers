Console.WriteLine("Introduzca los elementos separados por ','. termine el proceso presionando '.'");

var wordsAux = new List<string>();
var numbers = new List<int>();
var sortList = new List<string>();
bool[] positionsTypes = new bool[20]; // initialize for avoid unasigned error
int cont1 = 0, cont2 = 0;
var text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{
    var words = text.Trim().Split(", ");
    for (int i = 0; i < words.Count(); i++)
    {
        if (int.TryParse(words[i], out _))
        {
            positionsTypes[i] = true;
            numbers.Add(Int32.Parse(words[i]));
        }
        else
        {
            positionsTypes[i] = false;
            wordsAux.Add(words[i]);
        }
    }
}
else
{
    Console.WriteLine("Error introduciendo el dato");
}
wordsAux.Sort();
numbers.Sort();

for (int i = 0; i < positionsTypes.Count(); i++)
{
    if (positionsTypes[i] && cont1 < numbers.ToArray().Length)
    {
        sortList.Add(numbers.ToArray()[cont1].ToString());
        cont1++;
    }
    else if (cont2 < wordsAux.ToArray().Length)
    {
        sortList.Add(wordsAux.ToArray()[cont2]);
        cont2++;
    }
    else
    {
        break;
    }
}

Console.WriteLine($"{string.Join(", ", sortList)}.");
