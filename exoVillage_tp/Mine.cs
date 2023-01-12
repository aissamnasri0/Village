public class Mine{
    public static int gain_stone=10;
    public static int stone_cost=2;
    public static int wood_cost=1;
public Mine(){
    System.Console.WriteLine("mine created");
}
public int mineStone(int village){
    return village*gain_stone;
}
}