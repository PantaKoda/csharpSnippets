/// <summary>
/// Adding '_' for visible large numbers
/// </summary>
string pasreBigNumber(int n)
{

   string s = n.ToString();
    
    if (s.Length <= 3)
    {
        return s;
    }
    else
    {
        int i = s.Length % 3;
        if (i == 0)
        {
            i = 3;
        }
        return s.Substring(0, i) + "_" + pasreBigNumber(Int32.Parse(s.Substring(i)));
    }
}



Console.WriteLine(pasreBigNumber(int.MaxValue));
Console.WriteLine(pasreBigNumber(int.MinValue));
