namespace MSCalculatorLib
{
  public class CharacterData
  {
    public int[] arcLv;
    public bool[] isArcEquiped;
    

    public CharacterData()
    {
      isArcEquiped = new bool[5] { true, true, true, true, true };
      arcLv = new int[5] { 11, 12, 9, 8, 1 };
    }
  }
}
