using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice
{
    public class AutoStorage
    {
        private Dictionary<int, Auto> Autos { get; } = new Dictionary<int, Auto>();
        public void Create(Auto auto)
        {
            Autos.Add(auto.AutoID, auto);
        }
        public Auto Read(int autoID)
        {
            return Autos[autoID];
        }
        public Auto Update(int autoID, Auto newAuto)
        {
            Autos[autoID] = newAuto;
            return Autos[autoID];
        }
        public bool Delete(int autoID)
        {
            return Autos.Remove(autoID);
        }
    }
}
