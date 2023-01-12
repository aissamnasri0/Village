// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine(House.woods_needed); // affichera 3
// Console.WriteLine(House.stone_needed); // affichera 3
// Console.WriteLine(House.stone_needed++); // --> Erreur
// House justAHouse = new House();
// justAHouse.wood_need // --> Erreur
// justAHouse.villageois // --> Erreur
// justAHouse.villageois = 20 // --> Erreur
Village myVillage = new Village("Victor le createur");
System.Console.WriteLine(myVillage.getName()); // affichera Victor le createur
Console.WriteLine(myVillage.listHouse.Length);
myVillage.addHouse();
myVillage.addHouse();
Console.WriteLine(myVillage.listHouse.Length);
Console.WriteLine(myVillage.villageoise);  
