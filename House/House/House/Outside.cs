using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                string description = base.Description;
                if (hot)
                    description += " It is hot here.";
                return description;
            }
        }
    }
}
