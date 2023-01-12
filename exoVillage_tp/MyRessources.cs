public class MyRessources
{
    private int woods { get; set; }
    private int stones { get; set; }
    private int level { get; set; }
    private int woord_max { get; set; }
    private int woord_min { get; set; }
    public MyRessources()
    {
        this.woods = 10;
        this.stones = 10;
        this.level = 1;
        this.woord_max = 250;
        this.woord_min = 1;
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
        if (this.stones >= nbr)
        {
            this.stones -= nbr;
        }
    }
    public void useWoods(int nbr)
    {
        if (this.woods >= nbr)
        {
            this.woods -= nbr;
        }
    }
    public void addStone(int nbr)
    {
        this.stones += nbr;
    }
    public void upgrade()
    {
        this.woord_max *= 80 / 100;
        this.woord_max *= 2;
    }
    public void lookAround ()
    {
        if (this.stones >= 1 && this.woods >= 1)
        {
            this.stones += 1;
            this.woods += 1;
        }
    }
    

}