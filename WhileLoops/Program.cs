Random rnd = new Random();
int cpuRandom;

bool loopActive = true; // bool - true/false

while (loopActive) //kestab nii kaua kuni väärtus on õige
{
    cpuRandom = rnd.Next(1, 4); //väärtus 1-3 (viimast väärtust ei arvestata)
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine()); //esimesena loetakse string ehk formaadis. Peame numbriks parissma

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratiolations, you won!");
        loopActive = false; //lõpetab loopimise, kui vastus on õige
        //break; //kui soovime loopimise katkestada
    }
    else
    {
        Console.WriteLine("Oops. Try again."); 
    }
}
Console.WriteLine("Have a nice day!");
