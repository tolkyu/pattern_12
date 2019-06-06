using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CompetitionZ
{
    abstract class Member
    {
        public string Name { get; set; }
        public int ScoreTab { get; set; }
        public int inTarget { get; set; }
        public int Time { get; set; }
        public void Race()
        {
            Shot();
            Move();
            Score();
        }
        public abstract void Shot();
        public abstract void Move();
        public virtual void Score()
        {
            WriteLine($"{Name} reach {ScoreTab} points.");
        }
    }
    class Man : Member
    {
        public Man(string name,int inTarget,int time)
        {
            ScoreTab = 0;
            this.Name = name;
            this.inTarget = inTarget;
            this.Time = time;
        }

        public override void Move()
        {
            ScoreTab -= Time * 5;
        }

        public override void Shot()
        {
            ScoreTab += inTarget * 100;
        }
    }
    class Woman : Member
    {
        public Woman(string name,int inTarget,int time)
        {
            ScoreTab = 0;
            this.Name = name;
            this.inTarget = inTarget;
            this.Time = time;
        }
        public override void Move()
        {
            ScoreTab -= Time * 4;
        }

        public override void Shot()
        {
            ScoreTab += inTarget * 100;
        }
    }
    class Kid:Member
    {
        public Kid(string name, int inTarget, int time)
        {
            ScoreTab = 0;
            this.Name = name;
            this.inTarget = inTarget;
            this.Time = time;
        }
        public override void Move()
        {
            ScoreTab -= Time * 2;
            if (ScoreTab<0)
            {
                ScoreTab = 0;
            }
        }
        public override void Shot()
        {
            ScoreTab += inTarget * 200;
        }
    }
    class Game
    {
        Man man = null;
        Woman woman = null;
        Kid kid = null;
        public Game(Man man,Woman woman,Kid kid)
        {
            this.man = man;
            this.woman = woman;
            this.kid = kid;
        }
        public void Start()
        {
            man.Race();
            woman.Race();
            kid.Race();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("------------------------------");
            Man man = new Man("  Petro", 10, 30);
            Woman woman = new Woman("  Sveta", 20, 50);
            Kid kid = new Kid("  Ruslan", 30, 60);
            Game game = new Game(man, woman, kid);
            game.Start();
            WriteLine("------------------------------");
            Man man1 = new Man("  Vasyl", 25, 60);
            Woman woman1 = new Woman("  Olga", 55, 80);
            Kid kid1 = new Kid("  Sema", 65, 120);
            Game game1 = new Game(man1, woman1, kid1);
            game1.Start();
            WriteLine("------------------------------");
        }
    }
}
