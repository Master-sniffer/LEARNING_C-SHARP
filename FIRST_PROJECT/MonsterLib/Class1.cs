using System;

namespace MonsterLib
{
    public abstract class Spirit
    {
        public abstract void Passport();
    }

    public class Monster : Spirit
    {
        public Monster()
        {
            this.health = 100;
            this.ammo = 100;
            this.name = "Noname";
        }

        public Monster(string name) : this()
        {
            this.name = name;
        }

        public Monster (int health, int ammo, string name)
        {
            this.ammo = ammo;
            this.health = health;
            this.name = name;
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 0) health = value;
                else health = 0;
            }
        }

        public int Ammo
        {
            get
            {
                return ammo;
            }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public override void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo);
        }

        string name;
        int ammo, health;
    }

    public class Daemon : Monster
    {
        public Daemon()
        {
            brain = 1;
        }

        public Daemon (string name, int brain) : base(name)
        {
            this.brain = brain;
        }

        public Daemon (int health , int ammo, string name, int brain) : base (health, ammo, name)
        {
            this.brain = brain;
        }

        public override void Passport()
        {
            Console.WriteLine("Deamon {0} \t health = {1} ammo = {2} brain = {3}", Name, Health, Ammo, brain);
        }

        public void Think()
        {
            Console.WriteLine(Name + " is ");
            for (int i = 0; i < brain; i++) Console.WriteLine(" thinkiiing");
            Console.WriteLine("...");
        }

        int brain;
    }

}
