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

        public Regiment(string name)
        {
            this.manpower = 250;
            this.morale = 100;
            this.name = name;
            this.alive = true;
            this.ammo = 100;
        }
        public void Shoot()
        {
            this.ammo--;
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
    }
}
