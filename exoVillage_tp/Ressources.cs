public class Ressources
{
    private int woods { get; set; }
    private int stones { get; set; }
    public Ressources()
    {
        this.woods = 10;
        this.stones = 10;
    }
    public int getWood()
    {
        return this.woods;
    }
    public int getStone()
    {
        return this.stones;
    }
    public void useStones(int nbr)
    {
        if (this.stones > nbr)
        {
            this.stones -= nbr;
        }
    }
    public void useWoods(int nbr)
    {
        if (this.woods > nbr)
        {
            this.woods -= nbr;
        }
    }
    public void addStone(int nbr){
        this.stones += nbr;
    }

}