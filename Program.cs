// See https://aka.ms/new-console-template for more information
using Software1KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var customers = new List<Customer>();


for (int i = 0; i < numberOfRecords; i++)
{
    var myClass = new Customer();

    Console.WriteLine("Enter the value for the customer first name:");
    myClass.FirstName = Console.ReadLine();

    Console.WriteLine("Enter the value for the customer last name:");
    myClass.LastName = Console.ReadLine();

    Console.WriteLine("Enter the value for the customer ID:");
    var isValidID = int.TryParse(Console.ReadLine(), out int ID);
    if (isValidID)
    {
        myClass.ID = ID;
    } 
    else
    {
        Console.WriteLine("Invalid Input");
    }

    Console.WriteLine("Customer is active? True/False");
    var isActive = bool.TryParse(Console.ReadLine(), out bool Active);
    if (isActive)
    {
        myClass.Active = Active;
    }

    customers.Add(myClass);
}

foreach (var customer in customers)
{
Console.WriteLine(customer);
}