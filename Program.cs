// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine(House.woods_needed); // affichera 3
// Console.WriteLine(House.stone_needed); // affichera 3
// Console.WriteLine(House.stone_needed++); // --> Erreur
// House justAHouse = new House();
// justAHouse.wood_need // --> Erreur
// justAHouse.villageois // --> Erreur
// justAHouse.villageois = 20 // --> Erreur
// Village myVillage = new Village("Victor le createur");
// System.Console.WriteLine(myVillage.getName()); // affichera Victor le createur
// Console.WriteLine(myVillage.listHouse.Length);
//myVillage.addHouse();
//myVillage.addHouse();
// Console.WriteLine(myVillage.listHouse.Length);
// Console.WriteLine(myVillage.villageoise);
// Console.WriteLine(Mine.gain_stone); // affichera 10
// Console.WriteLine(Mine.stone_cost); // affichera 2
// Console.WriteLine(Mine.wood_cost) ;// affichera 1
Village myVillage = new Village("Victor le createur");
myVillage.mineStone(50); // Affichera: Il n'y a pas assez de villageois
Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood());// Affichera 10
myVillage.mineStone(6); // Affichera : Il n'y a pas assez de ressources
Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood()); // Affichera 10
myVillage.mineStone(5);myVillage.mineStone(5);
Console.WriteLine(myVillage.getStone()); // Affichera 90
Console.WriteLine(myVillage.getWood()); // Affichera 0
myVillage.mineStone(5); // Affichera : Il n'y a pas assez de ressources
