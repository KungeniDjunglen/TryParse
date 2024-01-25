using System;

class Program{
    static void Main(){
        int result;
        if(!TryParse(Console.ReadLine(), out result)){
            Console.WriteLine("Skriv en nuffra");
        }s
        else{
            Console.Write(result);
        }
    }
    public static bool TryParse(string s, out int result)
    {

        try{
            result = int.Parse(s); 
            return true;
        }
        catch{
            result = -1;
            return false;
        }
        
    }
}