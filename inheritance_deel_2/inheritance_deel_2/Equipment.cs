using System;

namespace inheritance_deel_2
{
    abstract class Equipment : PickUp
    {
        static void Main()
        {

        }
        public virtual void Equip()
        {

        }
    }

    class Weapons : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("equiped weapon");
        }
    }

    class Armor : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("equiped armor");
        }
    }

    abstract class PickUp
    {
        public void MouseClick(float x, float y)
        {

        }
        public virtual void Pickup()
        {

        }
    }

    class Healthpotion : PickUp
    {
        public override void Pickup()
        {
            base.Pickup();
            Console.WriteLine("picked up health potion");
        }
    }

    class Manapotion : PickUp
    {
        public override void Pickup()
        {
            base.Pickup();
            Console.WriteLine("picked up mana potion");
        }
    }

    

    
}
