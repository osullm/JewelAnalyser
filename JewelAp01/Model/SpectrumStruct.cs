using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelApp01.Model
{
    public class SpectrumStruct
    {
            public string SpectrumName { set; get; }
            public DateTime SpectrumDate { set; get; }
            public double[] Wavelength { set; get; }
            public double[] Dark { set; get; }
            public double[] Reference { set; get; }
            public double[] Spectrum { set; get; }
            public double[] ShowY { set; get; }
    }
}
