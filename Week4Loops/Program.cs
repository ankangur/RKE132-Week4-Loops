//FOR-LOOP on tsükkel mis paneb meie koodi käima kuni mingi tingimus täitub (kui me ei oska ennustada mitu korda meil seda koodi on vaja käivitada)
//Dry pinciple - Do not repeat yourself

int i = 0;
for(i = 0; i < 5; i++) //i++ on sama mis i+1
{
    Console.WriteLine("We don't need no education.");
}
Console.WriteLine(i);
Console.WriteLine("Have a nice day!");
// int i=o on algväärtus, i<5 on väärtus mille juures meie töö lõppeb, i++ on step ehk samm
// Tsükkel töötab ainult nii kaua kuni i väärtus on 5. Sellega lõpetab tspkli ja liigub koodis edasi. 

//DEBUG vaade - panen koodi punase täpiga rea ees pausile (show otput from:debug)