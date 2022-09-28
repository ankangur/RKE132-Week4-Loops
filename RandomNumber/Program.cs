Random rnd = new Random();//oskab meie süsteemist juhuslikke numbreid kindlas väärtuses kätte saada 

//int myRandomNUm = rnd.Next(0, 11); // annab väärtused 0-10
//Console.WriteLine($"My random number is {myRandomNUm}");

int myRandomNUm;

//for(int i = 0; i < 3; i++ )
//{ 
  // myRandomNUm = rnd.Next(0, 11); // annab väärtused 0-10 kümme korda järjest
   //Console.WriteLine($"My random number is {myRandomNUm}");
//}

int randomSum = 0;

for (int i = 0; i < 10; i++)
{
    myRandomNUm = rnd.Next(0, 11); // annab väärtused 0-10 kümme korda järjest
    randomSum = randomSum + myRandomNUm;
    Console.WriteLine($"My random number is: {myRandomNUm}");
}
Console.WriteLine($"random sum total: {randomSum}"); //summeerib juhuslikud väärtused
