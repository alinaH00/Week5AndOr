//0 or below - feezing
//0-5 - Cold
//5-10 - chilly
//10-15 - cool
//15-28 warm
//above 28 - boiling hot

Console.WriteLine("Please enter the temperature");
int currentTemp= Int32.Parse(Console.ReadLine());

if(currentTemp<=0)
{
    Console.WriteLine("Freezing");

}

else if (currentTemp> 0 && currentTemp <5)
{
    Console.WriteLine("Cold");
}
else if (currentTemp > 5 && currentTemp < 10)
{
    Console.WriteLine("Chilly");
}
else if (currentTemp > 10 && currentTemp < 15)
{
    Console.WriteLine("Cool");
}
else if (currentTemp > 15 && currentTemp < 28)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Hot");

}