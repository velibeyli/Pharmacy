using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy2.Model
{
    public class ComboItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
           return Text;
        }
    }
}
