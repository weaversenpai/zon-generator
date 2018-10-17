using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZonSäckGenerator
{
    public partial class Form1 : Form
    {
        public int[] findArray = { 5, 15, 45, 70, 75, 85 };
        Fynd fynd = new Fynd();
        Säck säck = new Säck();
        Arrays arrays = new Arrays();
        int seedvalue = 100;
        Random arraypick = new Random();
        Random seedroll = new Random();
        System.Media.SoundPlayer BackgroundMusic = new System.Media.SoundPlayer(Properties.Resources.MusicMusic);
        Boolean musicloop = false;
        Boolean hasardspel = false;
        Boolean generator = false;
        Boolean zonfynd = false;
        int backpacksize = 1;

        public Form1()
        {
            InitializeComponent();
            debugListbox.Visible = false;
            checkBox1.Visible = false;
            label1.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            checkboxWeapon.Visible = false;
            checkboxRare.Visible = false;
            listBox1.Visible = false;
            menuButton.Visible = false;
            FyndUppslag.Visible = false;
            FyndUppslagCheckbox.Visible = false;
            labelUppslag.Visible = false;
            

        }
    
        private void label1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Visible)
            {
                checkBox1.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (zonfynd)
                {
                GenereraFynd();
                }

            if (generator)
                { 
                GenereraSäck();
                }
        }

        private void SmallBackpack_CheckedChanged(object sender, EventArgs e)
        {
            backpacksize = 1;
            label1.Text = "Skolväska 'Kånken'";
        }

        private void MediumBackpack_CheckedChanged(object sender, EventArgs e)
        {
            backpacksize = 2;
            label1.Text = "Ordentlig rygga 'Funkis'";
        }

        private void LargeBackpack_CheckedChanged(object sender, EventArgs e)
        {
            backpacksize = 3;
            label1.Text = "Grovsäck 'Skrålfan'";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            debugListbox.Visible = true;
            if (!checkBox1.Checked)
            {
                debugListbox.Visible = false;

            }
        }

        private void checkboxWeapon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxWeapon.Checked)
            {
                seedvalue = seedvalue + 20;
                debugListbox.Items.Add(seedvalue);

            }

            else
            {
                seedvalue = seedvalue - 20;
                debugListbox.Items.Add(seedvalue);
            }
        }

        private void checkboxRare_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxRare.Checked)

            {
                seedvalue = seedvalue + 20;
                debugListbox.Items.Add(seedvalue);
            }
            else
            {
                seedvalue = seedvalue - 20;
                debugListbox.Items.Add(seedvalue);
            }
        }

        private void Music_Click(object sender, EventArgs e)
        {
            if (!musicloop)
            {
                BackgroundMusic.PlayLooping();
                musicloop = true;
                Music.Text = "Slå av Stämning";
            }

            else
            {
                BackgroundMusic.Stop();
                musicloop = false;
                Music.Text = "Slå på Stämning";
            }
        }

        private void HasardKnapp_Click(object sender, EventArgs e)
        {
            menuButton.Visible = true;
            hasardspel = true;
            zonfynd = false;
            generator = false;
            label1.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            checkboxWeapon.Visible = false;
            checkboxRare.Visible = false;
            btnGen.Visible = false;
            GeneratorKnapp.Visible = false;
            HasardKnapp.Visible = false;
            FyndKnapp.Visible = false;
            textFynd.Visible = false;
            textGenerator.Visible = false;
            textHasard.Visible = false;
        }
        private void GeneratorKnapp_Click(object sender, EventArgs e)
        {
            menuButton.Visible = true;
            generator = true;
            zonfynd = false;
            hasardspel = false;
            btnGen.Visible = true;
            label1.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            checkboxWeapon.Visible = true;
            checkboxRare.Visible = true;
            listBox1.Visible = true;
            GeneratorKnapp.Visible = false;
            HasardKnapp.Visible = false;
            FyndKnapp.Visible = false;
            textFynd.Visible = false;
            textGenerator.Visible = false;
            textHasard.Visible = false;
        }
        private void FyndKnapp_Click(object sender, EventArgs e)
        {
            menuButton.Visible = true;
            hasardspel = false;
            zonfynd = true;
            generator = false;
            FyndUppslag.Visible = true;
            label1.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Text = "Fyndbetydelse";
            groupBox2.Visible = true;
            checkboxWeapon.Visible = false;
            checkboxRare.Visible = false;
            btnGen.Visible = true;
            GeneratorKnapp.Visible = false;
            HasardKnapp.Visible = false;
            FyndKnapp.Visible = false;
            textFynd.Visible = false;
            textGenerator.Visible = false;
            textHasard.Visible = false;
            FyndUppslagCheckbox.Visible = true;
            listBox1.Visible = true;
            labelUppslag.Visible = true;
            label1.Text = "Väntar på zongömma...";
            EasyLife.Text = "Århundradets fynd";
            HardLife.Text = "Häftiga prylar";
            HarderLife.Text = "Kvarlämnat skrot";
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            hasardspel = false;
            zonfynd = false;
            generator = false;
            label1.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            FyndUppslag.Visible = false;
            checkboxWeapon.Visible = false;
            checkboxRare.Visible = false;
            btnGen.Visible = false;
            GeneratorKnapp.Visible = true;
            HasardKnapp.Visible = true;
            FyndKnapp.Visible = true;
            listBox1.Visible = false;
            textFynd.Visible = true;
            textGenerator.Visible = true;
            textHasard.Visible = true;
            FyndUppslag.Visible = false;
            FyndUppslagCheckbox.Visible = false;
        }       
        private void GenereraFynd()
        {
            fynd.GenereraFynd(arraypick,seedroll,seedvalue, label1,debugListbox,FyndUppslag,FyndUppslagCheckbox,listBox1,EasyLife,HarderLife,HardLife);
        }
        private void GenereraSäck()
        {
            säck.GenereraSäck(backpacksize,seedroll,arraypick,seedvalue,debugListbox,listBox1,EasyLife,HardLife,HarderLife);
        }
    }


}
