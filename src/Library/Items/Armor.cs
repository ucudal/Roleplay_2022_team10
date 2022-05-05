namespace RoleplayGame
{
    public class Armor : IDefense, IAttack
    {
        public int DefenseValue()
        {
                return 25;
        }

        public int AttackValue()
        {
                return 0;
        }
    }
}