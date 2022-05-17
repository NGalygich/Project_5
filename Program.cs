 namespace Project_5;

 class Program
 {
     public static string[] SeparationString(string text){
        string[] subs = text.Split(' ');
        return subs;
     }
     public static void InvertString(string[] subs){
         string newString = " ";
         foreach(var sub in subs){
             newString = " " + newString.Insert(0, sub);
         }  
         Console.WriteLine($"New string:{newString}");
    }
     public static string DateInput(){
        Console.Write("Enter text: ");
        string? text = Console.ReadLine();
        return text;
     } 
     public static void DateOutput(string[] subs){
        foreach(var sub in subs){
            Console.WriteLine(sub);
        }
     } 
     public static void ClearConsole(){
         Console.ReadLine();
         Console.Clear();
     }
     public static void TaskSelection(){
         byte numTask;
         bool stateProg = true;
         while (stateProg){
             Console.Write("Stop program - 4\nEnter number Task: ");
             numTask = Convert.ToByte(Console.ReadLine());
             switch (numTask){
                case 1:
                    
                    DateOutput(SeparationString(DateInput()));
                    ClearConsole();
                    break;
                case 2:
                    InvertString(SeparationString(DateInput()));
                    ClearConsole();
                    break;
                default:
                    Console.Clear();
                    stateProg = false;
                    break;
            }
        }
     }
    public static void Main(){
        TaskSelection();
    }
 }