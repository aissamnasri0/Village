public class Village
{
    private string name { get; }
    private Ressources myRessources;
    public House chefHome;
    public int villageoise=0;
    public House[] listHouse;
    public string getName() { return name; }
    public Village(string name)
    {
        this.name = name;
        myRessources = new Ressources();
        chefHome = new House();
        listHouse =  new []{chefHome};
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
    public void addHouse(){
      House house = new House();
    for(int i=0; i<listHouse.Length+1; i++){
        if(listHouse.Length+1==i){
            listHouse[i] = house;
        }
    }
    }

}