public class Village
{
    private string name { get; }
    private Ressources myRessources;
    public House chefHome;
    public int villageoise { get { return House.villageois * listHouse.Length; } }
    public House[] listHouse;
    public Mine mine;
    public string getName() { return name; }

    public Village(string name)
    {
        this.name = name;
        myRessources = new Ressources();
        chefHome = new House();
        listHouse = new[] { chefHome };
        mine = new Mine();


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
            myRessources.useStones(nbrVillagois * Mine.stone_cost);
            myRessources.useWoods(nbrVillagois * Mine.wood_cost);

            myRessources.addStone(mine.mineStone(nbrVillagois * Mine.stone_cost));
        }
    }


}