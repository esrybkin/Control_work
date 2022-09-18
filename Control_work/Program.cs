string[] arrstring = new string[] {"Hello", "2", "world", ":-)"};
int count = 0;
string[] arrtemp = new string[arrstring.Length];
for (int i=0; i<arrstring.Length; i++)
{
    if (arrstring[i].Length<=3)
    {
        arrtemp[count] = arrstring[i];
        count++;
    }
}
Array.Resize(ref arrtemp, count);
Console.WriteLine(string.Join(", ", arrtemp));