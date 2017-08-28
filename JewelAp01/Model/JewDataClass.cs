using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JewelApp01.Model
{
    public class JewDataClass
    {
        public int jewId { set; get; }
        public string jewName { set; get; }
        public string jewClass { set; get; }
        public double[] wavelength { set; get; }
        public double[] spectrum { set; get; }
        public string addTime { set; get;}
        public string creator { set; get; }
        public string remark { set; get; }

        public List<double> realSign { set; get; } = new List<double>();

        public List<double> unRealSign { set; get; } = new List<double>();

        //public string factoryState { set; get; }
    }
}
