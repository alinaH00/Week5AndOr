//AND (&&) and OR (||) logical operators

//AND
//true && true => true
//fals && true => false
//false && false => false

using System.ComponentModel.Design;

string username, password; //Username: admin //Password: admin1234

Console.WriteLine("Enter username:");
username = Console.ReadLine();

Console.WriteLine("Enter the password:");
password = Console.ReadLine();

//OR
if (username != "admin" || password != "admin1234")
{
    Console.WriteLine("Invalid user credentials");
}
else
{
    Console.WriteLine("Welcome");
}


//if (username == "admin" && password == "admin1234")
//{
//    Console.WriteLine("Welcome");
//}
//else
//{
//    Console.WriteLine("Invalid user credentials");
//}
