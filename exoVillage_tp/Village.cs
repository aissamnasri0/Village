public class Village
{
    private string name { get; }
    private Ressources myRessources;
    public House chefHome;
    public int villageoise = 0;
    public House[] listHouse;
    public string getName() { return name; }

    public Village(string name)
    {
        this.name = name;
        myRessources = new Ressources();
        chefHome = new House();
        listHouse = new[] { chefHome };
        this.villageoise = House.villageois;
    }
    public int getWood()
    {
        return myRessources.getWood();
    }
    public int getStone()
    {
        return myRessources.getStone();
    }
    public void addHouse()
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

}