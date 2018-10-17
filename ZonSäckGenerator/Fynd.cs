using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZonSäckGenerator
{
    class Fynd
    {
        Arrays arrays = new Arrays();
        public void GenereraFynd(Random arraypick,Random seedroll,int seedvalue,Label label1,ListBox debugListbox,ListBox FyndUppslag,CheckBox FyndUppslagCheckBox,ListBox listBox1,RadioButton EasyLife,RadioButton HarderLife, RadioButton HardLife)
        {
            DecidefindArray(arrays.findArray,EasyLife,HarderLife,HardLife,debugListbox);
            listBox1.Items.Clear();
            debugListbox.Items.Clear();
            for (int i = 0; i < arrays.findArray.Length; i++)
            {
                debugListbox.Items.Add(arrays.findArray[i].ToString());
                debugListbox.Items.Add("END OF FINDARRAY");
            }
            int storlek = arraypick.Next(7, 16);
            label1.Text = arrays.FyndLabelFlavorArray[arraypick.Next(0, arrays.FyndLabelFlavorArray.Length)];
            for (int i = 0; i < storlek; i++)
            {
                
                seedvalue = 100;
                int seedrandomizer = seedroll.Next(1, seedvalue);
                debugListbox.Items.Add(seedrandomizer);

                if (seedrandomizer >= arrays.findArray[5])
                {
                    string seed = arrays.RareItemsArray[arraypick.Next(1, arrays.RareItemsArray.Length)];
                    if (!listBox1.Items.Contains(seed))
                    {
                        listBox1.Items.Add(seed);
                    }
                    else
                    {

                        i--;
                    }

                }
                
                else if (seedrandomizer >= arrays.findArray[4])
                {
                    string seed = arrays.FireArmsArray[arraypick.Next(1, arrays.FireArmsArray.Length)];
                    if (!listBox1.Items.Contains(seed))
                    {
                        listBox1.Items.Add(seed);
                    }
                    else
                    {

                        i--;
                    }

                }

                else if (seedrandomizer >= arrays.findArray[3])
                {
                    string seed = arrays.LowTechWeaponsArray[arraypick.Next(1, arrays.LowTechWeaponsArray.Length)];
                    if (!listBox1.Items.Contains(seed))
                    {
                        listBox1.Items.Add(seed);
                    }
                    else
                    {

                        i--;
                    }

                }

                else if (seedrandomizer >= arrays.findArray[2])
                {
                    string seed = arrays.HighValArray[arraypick.Next(1, arrays.HighValArray.Length)];
                    if (!listBox1.Items.Contains(seed))
                    {
                        listBox1.Items.Add(seed);
                    }
                    else
                    {

                        i--;
                    }

                }

                else if (seedrandomizer >= arrays.findArray[1])

                {
                    string seed = arrays.MedValArray[arraypick.Next(1, arrays.MedValArray.Length)];
                    if (!listBox1.Items.Contains(seed))
                    {
                        listBox1.Items.Add(seed);
                    }
                    else
                    {

                        i--;
                    }

                }

                else if (seedrandomizer >= arrays.findArray[0])
                {
                    string seed = arrays.LowValArray[arraypick.Next(1, arrays.LowValArray.Length)];
                    if (!listBox1.Items.Contains(seed))
                    {
                        listBox1.Items.Add(seed);
                    }
                    else
                    {

                        i--;
                    }


                }
            }
            if (FyndUppslagCheckBox.Checked)
            {
                string seed = arrays.FyndFlavorArray[arraypick.Next(0, arrays.FyndFlavorArray.Length)];
                FyndUppslag.Items.Add(seed);
            }
        }


        public void DecidefindArray(int[] findArray,RadioButton EasyLife,RadioButton HarderLife, RadioButton HardLife,ListBox debugListbox)
        {
            if (HarderLife.Checked)
            {
                debugListbox.Items.Add("HarderLife");
                findArray[0] = 10;
                findArray[1] = 20;
                findArray[2] = 50;
                findArray[3] = 75;
                findArray[4] = 85;
                findArray[5] = 95;
            }
            else if (EasyLife.Checked)
            {
                findArray[0] = 1;
                findArray[1] = 10;
                findArray[2] = 40;
                findArray[3] = 65;
                findArray[4] = 70;
                findArray[5] = 80;
                debugListbox.Items.Add("EasyLife");

            }
            else
            {
                findArray[0] = 5;
                findArray[1] = 15;
                findArray[2] = 45;
                findArray[3] = 70;
                findArray[4] = 75;
                findArray[5] = 85;
                debugListbox.Items.Add("HardLife");

            }
        }


    }


}
