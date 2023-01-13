public class MyRessources : Ressources
{
    private int woods { get; set; }
    private int stones { get; set; }
    private int level { get; set; }
    private int woord_max { get; set; }
    private int woord_min { get; set; }

    public MyRessources() : base()
    {
        this.woods = 10;
        this.stones = 10;
        this.level = 1;
        this.woord_max = 250;
        this.woord_min = 1;

    }
    public override int getWood()
    {

        return this.woods;
    }
    public override int getStone()
    {
        return this.stones;
    }
    public override void useStones(int nbr)
    {
        if (this.stones >= nbr)
        {
            this.stones -= nbr;
        }
    }
    public override void useWoods(int nbr)
    {
        if (this.woods >= nbr)
        {
            this.woods -= nbr;
        }
    }
    public override void addStone(int nbr)
    {
        this.stones += nbr;
    }
    public override void upgrade()
    {
        useStones(this.woord_max *= 80 / 100);
        useWoods(this.woord_min *= 80 / 100);
        this.woord_max *= 2;
    }
    public override void lookAround()
    {
        if (this.stones >= 1 && this.woods >= 1)
        {
            this.stones += 1;
            this.woods += 1;
        }
    }


}