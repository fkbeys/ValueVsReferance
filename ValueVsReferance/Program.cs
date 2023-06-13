using System.Text;

public class Program
{
    public static (string, string) NumEqualMaker(string a, string b)
    {
        int lenA = a.Length;
        int lenB = b.Length;

        if (lenA > lenB)
        {
            int dif = lenA - lenB;

            for (int i = 0; i < dif; i++)
            {
                b = "0" + b;
            }
        }
        if (lenB > lenA)
        {
            int dif = lenB - lenA;

            for (int i = 0; i < dif; i++)
            {
                a = "0" + a;
            }
        }
        return (a, b);
    }


    public static void Main()
    {
        string a = "99";
        string b = "88";

        StringBuilder sb = new StringBuilder();
        int hand = 0;

        (a, b) = NumEqualMaker(a, b);

        for (int i = a.Length - 1; i >= 0; i--)
        {
            var numA = a[i].ToString();
            int.TryParse(numA, out int numintA);

            int.TryParse(b[i].ToString(), out int numintB);
            var tempResult = numintA + numintB;
            if (hand > 0)
            {
                tempResult += hand;
                hand = 0;
            }
            if (tempResult > 9)
            {
                tempResult = tempResult - 10;
                hand++;
            }
            sb.Append(tempResult);
        }
        if (hand > 0)
        {
            sb.Append(1);
        }
        var st = sb.ToString();
        Console.WriteLine(st.Reverse().ToArray());
    }
}
