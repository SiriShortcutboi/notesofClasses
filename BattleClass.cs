using System;
using System.Globalization;

public class Program{
    


Character hero = new Character()
hero.Level = 1;
hero.MyClass = BattleClass.Warrior;
hero.LevelUp();
hero.LevelUp();
hero.LevelUp();
hero.LevelUp();
hero.LevelUp();


 
/*enum BattleClass:

thing1,
thing2, 
thing3

*/

public class Character
{
    public int Level {get; set; }
    public BattleClass MyClass {get; set; }

    public void LevelUp()
}

class Character
{
    

}

}