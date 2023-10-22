using System.Reflection;
using System.Xml.Linq;


namespace Labb_8_OOP_Generic_collections;

internal class Program
{
    static void Main(string[] args)
    {
        //Jonny Touma NET23 Uppgift 08

        Employee emp1 = new Employee("1", "Zeuz", "male", 120000);  //Skapar nya objekt genom att använda konstruktorn i Employee, och sparar värdena i dess nya variabel emp1, emp2 etc
        Employee emp2 = new Employee("2", "Hera", "female", 85000);
        Employee emp3 = new Employee("3", "Poseidon", "male", 50000);
        Employee emp4 = new Employee("4", "Athena", "female", 65000);
        Employee emp5 = new Employee("5", "Apollo", "male", 95000);

        Stack<Employee> gods = new Stack<Employee>() { };   //Skapar an stack av klassen Employee och skapar en ny variabel med namnet gods

        gods.Push(emp1);    //Lägger till objekten från konstruktorn till den nya stacken vi skapat ovan med Push metoden 
        gods.Push(emp2);
        gods.Push(emp3);
        gods.Push(emp4);
        gods.Push(emp5);

        Console.WriteLine($"Posts in the stack: {gods.Count()}");   //skriver ut hur många poster det fins i stacken 
        PrintList(gods);    //Anropar metoden PrintList som sedan 
        Line();     //metod för att undvika repetation 
        Console.WriteLine("Retrieve using pop:");

        while (gods.Count > 0)  //While loop som loopar så länge stacken gods är större än 0
        {
            Console.WriteLine($"Posts left: {gods.Count()}");   //skriver ut hur många som finns kvar i listan.
            Console.WriteLine(gods.Pop());      //Skriver ut den sista positionen i stacken och sedan "poppar den"
        }

        Line();

        Console.WriteLine("Retrieve using peek method");

        gods.Push(emp1);        //Lägger tillbaka samtliga objekt till stacken gods
        gods.Push(emp2);
        gods.Push(emp3);
        gods.Push(emp4);
        gods.Push(emp5);

        for (int i = 0; i < 2; i++)     //forloop som ittererar 2 gånger och printar ut sista posten så länge den inte är noll
        {
            if (gods.Count != 0)
            {
                Console.WriteLine(gods.Peek());
                Console.WriteLine($"Posts left in stack: {gods.Count()}"); //räknar hur många objekt som finns i stacken
            }
        }

        Line();
        Console.WriteLine("Checking if a object with id 3 is in the list: ");

        if (gods.Contains(emp3) == true)      //gör en ifsats för att se ifall ett objekt är med i stacken 
        {
            Console.WriteLine("emp3 is in stack");
        }
        else { Console.WriteLine("emp3 is not in stack"); }

        Line();
        Console.ForegroundColor = ConsoleColor.Red;     //startar del 2 med lite egen touch 
        Console.WriteLine("\n                     Del 2\n");
        Console.ResetColor();
        Line();

        List<Employee> godsList = new List<Employee>() { emp1, emp2, emp3, emp4, emp5 };        //skapar en Lista och tilldelar den variabeln godsList,
                                                                                               //i listan lägger jag in objecten från konstruktorn 
        Console.WriteLine("Checking if employee 2 exists in the list");
        if (godsList.Contains(emp2) == true)      //liknande ifsats som tidigare för att se ifall emp2 är med i listan 
        {
            Console.WriteLine("emp2 exists in the list");
        }
        else { Console.WriteLine("emp2 does not exist in the list "); }

        Line();

        Console.WriteLine();
        Console.WriteLine("Finding first male in the list:");

        Employee search = godsList.Find(employee => employee.Gender == "male"); //Söker igenom godsList och hitta det första Employee objektet där Gender är male och 
                                                                                //lagra den i search. 

        if (search != null)     //ifall search inte är 0 presentera koden nedan 
        {
            Console.WriteLine($"ID: {search.ID}, Namn: {search.Name}, Kön: {search.Gender}, Lön: {search.Salary}");
        }
        else Console.WriteLine("No male gods found in the list");
        Console.WriteLine();
        Line();
        Console.WriteLine("Finding all males in the list: ");
        List<Employee> searchMales = godsList.FindAll(employee => employee.Gender == "male");   //likt ovan fast med ny variabel 
        foreach (Employee list in searchMales)      //Går igenom de fall av resultatet med foreach 
        {
            Console.WriteLine(list);        //presenterar resultaten i foreach 
        }

    }

    static void PrintList(IEnumerable<Employee> gods)       //Använder mig utav IEnumerable för att skapa funktion där alla objekt i listan skrivs ut 
    {                                                      //Det är här ToString metoden i Employee arbetar ihop, informationen där skrivs ut i list
        foreach (Employee list in gods)
        {
            Console.WriteLine(list);
        }
    }
    static void Line()          //Snygga gröna streck för att undvika upprepning av kod 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("----------------------------------------------------------");
        Console.ResetColor();
    }
}