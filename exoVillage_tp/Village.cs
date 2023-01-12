public class Village
{
    private string name { get; }
    private Ressources myRessources;
    public House chefHome;
    public int villageoise { get { return House.villageois * listHouse.Length; } }
    public House[] listHouse;
    public Mine mine;
    public Forest forest;
    public string getName() { return name; }

    public Village(string name)
    {
        this.name = name;
        myRessources = new Ressources();
        chefHome = new House();
        listHouse = new[] { chefHome };
        mine = new Mine();
        forest = new Forest();
        bool boucle = true;
        while (boucle)
        {
            System.Console.WriteLine("entrer le numero de methode :");
            System.Console.WriteLine("1- getwood 2- getstone 3- addhouse "
            + "4- mineStone 5- cutWood 6- buildHouse 7- upgradeRessource 8- upgradeMine 9- quiter");
            int res = int.Parse(Console.ReadLine());
            if (res >= 1 && res <= 9)
            {
                switch (res)
                {
                    case 1:
                        System.Console.WriteLine(getWood());
                        break;
                    case 2:
                        System.Console.WriteLine(getStone());
                        break;
                    case 3:
                        addHouse();
                        break;
                    case 4:
                        System.Console.WriteLine("entrer le nombre de vilaggeois : ");
                        int nbr = int.Parse(Console.ReadLine());
                        mineStone(nbr);
                        break;
                    case 5:
                        System.Console.WriteLine("entrer le nombre de vilaggeois : ");
                        int nbr1 = int.Parse(Console.ReadLine());
                        cutWord(nbr1);
                        break;
                    case 6:
                        System.Console.WriteLine("entrer le nombre : ");
                        int nbr3 = int.Parse(Console.ReadLine());
                        buildHouse(nbr3);
                        break;
                    case 7:
                        upgradeRessource();
                        break;
                    case 8:
                        upgradeMine();
                        break;
                    case 9:
                        boucle = false;
                        break;

                }
            }
            else
            {
                System.Console.WriteLine("invalid option");
            }
        }



    }
    public int getWood()
    {
        return myRessources.getWood();
    }
    public int getStone()
    {
        return myRessources.getStone();
    }
    private void addHouse()
    {
        House house = new House();
        if (listHouse == null)
        {
            listHouse = new[] { house };
        }
        else
        {
            House[] newHouse = new House[listHouse.Length + 1];
            listHouse.CopyTo(newHouse, 0);
            newHouse[listHouse.Length] = house;
            listHouse = newHouse;

        }

    }
    public void mineStone(int nbrVillagois)
    {
        if (this.villageoise < nbrVillagois)
        {
            System.Console.WriteLine("il n'y a pas assez de villageois");
        }
        else if (nbrVillagois * Mine.stone_cost > myRessources.getStone() || nbrVillagois * Mine.wood_cost > myRessources.getWood())
        {
            System.Console.WriteLine("il n'y a pas assez de ressources");

        }
        else
        {
            myRessources.useStones(nbrVillagois * Mine.stone_cost * mine.getLevel());
            myRessources.useWoods(nbrVillagois * Mine.wood_cost * mine.getLevel());

            myRessources.addStone(nbrVillagois*(Mine.stone_cost));
        }
    }
    public void cutWord(int nbrVillagois)
    {
        if (this.villageoise < nbrVillagois)
        {
            System.Console.WriteLine("il n'y a pas assez de villageois");
        }
        else if (nbrVillagois * Forest.stone_cost > myRessources.getStone() || nbrVillagois * Forest.wood_cost > myRessources.getWood())
        {
            System.Console.WriteLine("il n'y a pas assez de ressources");

        }
        else
        {
            myRessources.useStones(nbrVillagois * Forest.stone_cost * forest.getLevel() * 10);
            myRessources.useWoods(nbrVillagois * Forest.wood_cost * forest.getLevel() * 10);
            myRessources.addStone(nbrVillagois*(Forest.stone_cost));
        }

    }
    public void buildHouse(int nbr)
    {
        for (int i = 0; i < nbr; i++)
        {
            addHouse();
            myRessources.useStones(nbr);
            myRessources.useWoods(nbr);
        }


    }
    public void upgradeRessource()
    {
        myRessources.upgrade();
    }
    public void upgradeMine()
    {
        myRessources.useStones(Forest.gain_wood * forest.getLevel() * 10);
        myRessources.useWoods(Forest.gain_wood * forest.getLevel() * 10);
    }

}