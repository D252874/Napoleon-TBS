using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napoleon_TBS
{
    class Regiment
    {
        protected int manpower;
        protected int morale;
        protected string name;
        protected bool alive;
        protected int ammo;
        protected bool shot;
        protected int range;
        protected bool CanFire;

        public Regiment(string name)
        {
            Class1 Class = new Class1();

            this.manpower = 250;
            this.morale = 100;
            this.name = name;
            this.alive = true;
            this.ammo = 30;
            this.range = 500;
            this.CanFire = false;
        }
        public void Shoot()
        {
            this.ammo--;
            if (this.ammo <= 0)
            {
                this.CanFire = false;
            }
        }
        public void GetHit(int damage)
        {
            this.manpower =- damage;
        }
        public int GetManpower()
        {
            return this.manpower;
        }
        public int GetMorale()
        {
            return this.morale;
        }
        public string GetName()
        {
            return this.name;
        }
        public bool GetShot()
        {
            return  shot;
        }
        public void SetShot(bool shot)
        {
            this.shot = shot;
        }

 
        public void SetRange(int range)
        {
            this.range = this.range - range;
        }
        public bool CheckRange()
        {
            if(this.range <= 200)
            {
                this.CanFire = true;
                if (this.ammo <= 0)
                {
                    this.CanFire = false;
                }
            }
            return this.CanFire;

        }
    }
}
