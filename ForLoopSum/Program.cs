for (int i = 0; i < 10; i++) //nummerdab 0-9
{
    Console.WriteLine($"i = {i}");
}

for (int i = 1; i < 11; i++) //nummerdab 1-9
{
    Console.WriteLine($"i = {i}");
}

for (int i = 0; i < 10; i++) //nummerdab 1-10
{
    Console.WriteLine($"i = {i + 1}"); // i+1 ei muuda väärtust vaid viisi kuidas seda kuvatakse
}

for (int i = 10; i > 0; i--) //nummerdab tagurpidi 10-1, i--1 on sammuga miinus 1
{
    Console.WriteLine($"i = {i}");
}


int sum = 0;
for (int i = 1; i < 11; i++) //arvutab mis kõikide i-de summa
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum+=1
}


Console.WriteLine($"Final total { sum}");