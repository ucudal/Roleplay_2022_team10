namespace RoleplayGame
{
    public interface ICharacter
    {

        public string Name { get; set; }

        public IElement Armor  { get; set; }
        public IElement Axe  { get; set; }
        public IElement Bow  { get; set; }
        public IElement Helmet  { get; set; }
        public IElement Shield  { get; set; }
        public IElement Spell  { get; set; }
        public IElement SpellsBook  { get; set; }
        public IElement Staff  { get; set; }
        public IElement Sword  { get; set; }


        public int AttackValue { get;}

        public int DefenseValue { get;}

        public int Health { get; set; }

        public void ReceiveAttack(int power) {}

        public void Cure() {}

    }
}