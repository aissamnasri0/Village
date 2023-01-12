Village myVillage = new Village("Victor le createur");
Console.WriteLine(myVillage.getName());
myVillage.cutWord(2);
myVillage.mineStone(2);
myVillage.cutWord(4);
myVillage.mineStone(4);
Console.WriteLine(myVillage.getWood()); // affiche 58
Console.WriteLine(myVillage.getStone()); // affiche 46
myVillage.buildHouse(2);
Console.WriteLine(myVillage.listHouse.Length); // affiche 3
Console.WriteLine(myVillage.villageoise); // affiche 30
myVillage.cutWord(15);
myVillage.mineStone(15); // affiche Il n'y a pas assez de ressources
Console.WriteLine(myVillage.getWood()); // affiche 187
Console.WriteLine(myVillage.getStone()); // affiche 10
myVillage.buildHouse(4); // affiche Il n'y a pas assez de ressources