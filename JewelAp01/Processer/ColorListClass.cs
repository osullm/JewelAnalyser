using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelApp01.Processer
{
    public class ColorListClass
    {
        private List<Color> colorList = new List<Color>();

        private int usingIndex  = 0;

        public ColorListClass()
        {
            readList();
        }

        private void readList()
        {
            StreamReader sr = new StreamReader("colorList.txt");
            string str=sr.ReadLine();
            while(str!=null)
            {
                colorList.Add (Color.FromName(str));
                str = sr.ReadLine();
            }
            sr.Close();
            
        }
        public Color getNextColor()
        {
            usingIndex++;
            if (usingIndex >= 0 && usingIndex <= 95)
            {
                return colorList[usingIndex];
            }
           
            else return Color.Blue;
        }
    }
}
