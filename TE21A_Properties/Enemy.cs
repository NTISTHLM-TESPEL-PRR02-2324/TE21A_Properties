public class Enemy
{
  // private int _hp = 0;
  protected string _name;

  public int Hp { get; private set; }

  public string Name { get; set; }




  // public void SetHp(int value)
  // {
  //   _hp = value;
  //   if (_hp < 0)
  //   {
  //     _hp = 0;
  //   }
  // }

  // public int GetHp()
  // {
  //   return _hp;
  // }
}

public class Goomba : Enemy
{
  public Goomba()
  {
    _name = "Goomba";
  }
}