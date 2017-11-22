using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue_alpha_v1._01.Shop.DataStub
{
    public class DataManagerStub
    {
        public Store Store { get; set; }
        public Inventory Inventory { get; set; }
        public Wallet Wallet { get; set; }

        public DataManagerStub()
        {
            this.Store = new Store();
            this.Inventory = new Inventory();
            this.Wallet = new Wallet();
        }
    }
}
