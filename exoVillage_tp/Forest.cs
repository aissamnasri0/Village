public class Forest
{
    public static int gain_wood = 10;
    public static int stone_cost = 2;
    public static int wood_cost = 1;
    public static int level = 1;

    public int cutWood(int village)
    {
        return village * gain_wood;
    }
    public int getLevel()
    {
        return level ;
    }
    public void upgrade()
    {
        level += 1;
    }

}