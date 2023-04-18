
public class CodeChalange041723{
    static int[] IndexOfCapitals (string s) {
        int[] res = new int[NumOfCapitals(s)];
        int i =0;
        foreach (char ch in s) {
            if(char.IsAsciiLetterUpper(ch)) {
                res[i]=s.IndexOf(ch);
                i++;
            }
        }
        return res;
    }

    static int NumOfCapitals(string s) {
        int i=0;
        foreach (char ch in s) {
            if (char.IsAsciiLetterUpper(ch))
                i++;
        }
        return i;
    }
    

    public static void Main() {
        System.Console.WriteLine("Enter single string");
        string s = System.Console.ReadLine();
        System.Console.WriteLine("Result is: ");
        System.Console.WriteLine("[{0}]", string.Join(", ", IndexOfCapitals(s)));
    }
}

