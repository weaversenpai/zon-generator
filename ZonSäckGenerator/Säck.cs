using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZonSäckGenerator
{
    class Säck
    {
        Arrays arrays = new Arrays();

        public void GenereraSäck(int backpacksize,Random seedroll,Random arraypick,int seedvalue,ListBox debugListbox,ListBox listBox1,RadioButton EasyLife, RadioButton HardLife, RadioButton HarderLife)
        {
            listBox1.Items.Clear();
            debugListbox.Items.Clear();
            switch (backpacksize)
            {

                case 1:


                    if (EasyLife.Checked)
                    {
                        for (int i = 0; i < 6; i++)
                        {


                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 120)
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

                            else if (seedrandomizer >= 105)
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

                            else if (seedrandomizer >= 95)
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

                            else if (seedrandomizer >= 80)
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

                            else if (seedrandomizer >= 35)

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

                            else if (seedrandomizer >= 1)
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


                    }
                    else if (HardLife.Checked)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 130)
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

                            else if (seedrandomizer >= 110)
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

                            else if (seedrandomizer >= 100)
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

                            else if (seedrandomizer >= 90)
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

                            else if (seedrandomizer >= 50)

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

                            else if (seedrandomizer >= 1)
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


                    }
                    else if (HarderLife.Checked)
                    {

                        for (int i = 0; i < 6; i++)
                        {

                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 135)
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

                            else if (seedrandomizer >= 115)
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

                            else if (seedrandomizer >= 105)
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
                            else if (seedrandomizer >= 90)
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

                            else if (seedrandomizer >= 65)

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

                            else if (seedrandomizer >= 1)
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
                    }
                    break;

                case 2:


                    if (EasyLife.Checked)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 120)
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

                            else if (seedrandomizer >= 105)
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

                            else if (seedrandomizer >= 95)
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

                            else if (seedrandomizer < 80)
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

                            else if (seedrandomizer < 35)

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

                            else if (seedrandomizer < 1)
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


                    }
                    else if (HardLife.Checked)
                    {
                        for (int i = 0; i < 9; i++)
                        {

                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 130)
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

                            else if (seedrandomizer >= 110)
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

                            else if (seedrandomizer >= 100)
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

                            else if (seedrandomizer >= 90)
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

                            else if (seedrandomizer >= 50)

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

                            else if (seedrandomizer >= 1)
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


                    }
                    else if (HarderLife.Checked)
                    {
                        for (int i = 0; i < 9; i++)
                        {

                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 135)
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

                            else if (seedrandomizer >= 115)
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

                            else if (seedrandomizer >= 105)
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

                            else if (seedrandomizer >= 95)
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

                            else if (seedrandomizer >= 65)

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

                            else if (seedrandomizer >= 1)
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
                    }
                    break;

                case 3:


                    if (EasyLife.Checked)
                    {
                        for (int i = 0; i < 12; i++)
                        {

                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 120)
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

                            else if (seedrandomizer >= 105)
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

                            else if (seedrandomizer >= 95)
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


                            else if (seedrandomizer >= 80)
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

                            else if (seedrandomizer >= 35)

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

                            else if (seedrandomizer >= 1)
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


                    }
                    else if (HardLife.Checked)
                    {
                        for (int i = 0; i < 12; i++)
                        {

                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 130)
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

                            else if (seedrandomizer >= 110)
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

                            else if (seedrandomizer >= 100)
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


                            else if (seedrandomizer >= 90)
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

                            else if (seedrandomizer >= 50)

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

                            else if (seedrandomizer >= 1)
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


                    }
                    else if (HarderLife.Checked)
                    {
                        for (int i = 0; i < 12; i++)
                        {

                            int seedrandomizer = seedroll.Next(1, seedvalue);
                            debugListbox.Items.Add(seedrandomizer);

                            if (seedrandomizer >= 135)
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

                            else if (seedrandomizer >= 115)
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

                            else if (seedrandomizer >= 105)
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

                            else if (seedrandomizer >= 95)
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

                            else if (seedrandomizer >= 65)

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

                            else if (seedrandomizer >= 1)
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
                    }
                    break;

                default:
                    break;
            }
        }

    }
}
