using System;

public class Test{
    public static string createSecretCode(string s){
        //WRITE YOUR CODE HERE
        Console.WriteLine(s[0]);
        string res="";
        for (int i=0;i<s.Length;i++) {
            res=res+"0"+(((int)(char.ToLower(s[i])))-96).ToString();

        }
        return res;
               
        
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        string s = Console.ReadLine();
        Console.WriteLine(createSecretCode(s));
    }
}