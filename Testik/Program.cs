public class ExceptionExample {

    public static void Main(string[] args) {
    mayThrowException();
  }
  public static void mayThrowException() {
    string s="abc";
    try {
      int i=s[1]; // A
      Console.Write("After A, ");
    } catch(Exception e) {
      Console.Write(e + "Uh oh - something went wrong! ");
    } finally {
      Console.Write("Finally block, ");
    }
    Console.Write("continuing...");
  }

  
}


