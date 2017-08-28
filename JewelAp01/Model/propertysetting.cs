using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelApp01.Model
{
    public class propertysetting
    {
        private int integrationTime = 10;
        private int averageTime = 10;
        private int boxWidth = 2;
        private double minWavelength;
        private double maxWavelength;

        private int exposureTime = 5;


        [DisplayName("积分时间："), CategoryAttribute("光谱仪设置"), DescriptionAttribute("积分时间：单次曝光时间。修改过曝光时间后，暗值与参考值都应重新存储。"), ReadOnly(true)]
        public int IntegrationTime
        {
            get
            {
                return integrationTime;
            }
            set
            {
                integrationTime = value;

            }
        }
        [DisplayName("平均次数："), CategoryAttribute("光谱仪设置"), DescriptionAttribute("平均次数：检测时间=积分时间*平均次数，理论上只要时间允许，平均次数越多检测结果效果越好。修改过平均次数后，暗值与参考值都应重新存储。")]
        public int AverageCounts
        {
            get
            {
                return averageTime;
            }
            set
            {
                averageTime = value;
            }
        }
        [DisplayName("平滑宽度："), CategoryAttribute("光谱仪设置"), DescriptionAttribute("平滑宽度：曲线取相邻像素做平滑算法，平滑次数越多谱线越平滑，但太多曲线会失真，一般取0-3次，最多不超过3次。")]
        public int BoxWidth
        {
            get
            {
                return boxWidth;
            }
            set
            {
                boxWidth = value;
            }
        }

        [DisplayName("最小波长："), CategoryAttribute("光谱仪设置"), DescriptionAttribute("设置显示的最小波长。"), ReadOnly(false)]
        public double MinWavelength
        {
            get
            {
                return minWavelength;
            }
            set
            {
                minWavelength = value;
            }
        }
        [DisplayName("最大波长："), CategoryAttribute("光谱仪设置"), DescriptionAttribute("设置显示的最大波长。"), ReadOnly(false)]
        public double MaxWavelength
        {
            get
            {
                return maxWavelength;
            }
            set
            {
                maxWavelength = value;
            }
        }



    }
}
