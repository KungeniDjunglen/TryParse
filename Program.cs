using System;

class Program{
    static void Main(){
        int result;
        if(!int.TryParse(Console.ReadLine(), out result)){
            Console.WriteLine("Skriv en nuffra");
        }
        else{
            Console.Write(result);
        }
    }
    public static bool TryParse(string s, out int result)
    {
        result = int.Parse(s);
        if(result != null){
            return true;
        }
        else{
            return false;
        }
    }
}