using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Manager
{
    public class Gym
    {
        private string _name;
        private List<Membership> _membership;

        public string Name { get { return _name; }set { _name = value; } }
        public List<Membership> Memberships { get { return _membership; } }

        public Gym(string name)
        {
            _name = name;
            _membership = new List<Membership>();
        }

        public void AddMembership(Membership membership)
        {
            _membership.Add(membership);
        }

        public int TotalIncome()
        {
            return _membership.Sum(x => x.TotalCost());
        }

        public Member MostActive()
        {
            return _membership.OrderByDescending(x => x.Owner.Visits).Select(x => x.Owner).First();
        }

        public Membership BestValue()
        {
            return _membership.OrderByDescending(x => x.PricePerVisit()).Select(x => x).First();
        }



    }
}
