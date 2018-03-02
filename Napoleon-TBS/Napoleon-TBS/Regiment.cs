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
    }
}
