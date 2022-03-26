using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        // Vissa variabler är på svenska och vissa på engelska för att undvika användning av å ä ö i koden, 
        // Jag skulle skrivit allt på engelska vanligtvis men nu har jag kommit för långt för att orka byta :D
        // Jag använder mig av switch statements i koden eftersom det är mer effektivt (enligt vissa källor) ->
        // än att skriva flera if else statements och jag lärde mig mer om det under tiden jag programmerade spelet, det är även lättare att läsa
        Random svarSkapare = new Random();
        PictureBox[] pBox = new PictureBox[93];
        int colorPicked, tur, rVal, fVal;  
        int[] plats = new int[4];
        int[] platsKorrekt = new int[4];
        int[] tempPlatsKorrekt = new int[4];
        int[] tagna = new int[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tur = 1;

            colorPicked = 0;

            // Skapar en kod som skall gissas. Tillåter ej dubletter
            for (int i = 0; i < 4; i++)
            {
                platsKorrekt[i] = svarSkapare.Next(1, 9);
                while (tagna.Contains(platsKorrekt[i]))
                {
                    platsKorrekt[i] = svarSkapare.Next(1, 9);
                }
                tagna[i] = platsKorrekt[i];
            }

            pBox[1] = pictureBox1;
            pBox[2] = pictureBox2;
            pBox[3] = pictureBox3;
            pBox[4] = pictureBox4;
            pBox[5] = pictureBox5;
            pBox[6] = pictureBox6;
            pBox[7] = pictureBox7;
            pBox[8] = pictureBox8; 
            pBox[9] =  pictureBox9;
            pBox[10] = pictureBox10;
            pBox[11] = pictureBox11;
            pBox[12] = pictureBox12;
            pBox[13] = pictureBox13;
            pBox[14] = pictureBox14;
            pBox[15] = pictureBox15;
            pBox[16] = pictureBox16;
            pBox[17] = pictureBox17;
            pBox[18] = pictureBox18;
            pBox[19] = pictureBox19;
            pBox[20] = pictureBox20;
            pBox[21] = pictureBox21;
            pBox[22] = pictureBox22;
            pBox[23] = pictureBox23;
            pBox[24] = pictureBox24;
            pBox[25] = pictureBox25;
            pBox[26] = pictureBox26;
            pBox[27] = pictureBox27;
            pBox[28] = pictureBox28;
            pBox[29] = pictureBox29;
            pBox[30] = pictureBox30;
            pBox[31] = pictureBox31;
            pBox[32] = pictureBox32;
            pBox[33] = pictureBox33;
            pBox[34] = pictureBox34;
            pBox[35] = pictureBox35;
            pBox[36] = pictureBox36;
            pBox[37] = pictureBox37;
            pBox[38] = pictureBox38;
            pBox[39] = pictureBox39;
            pBox[40] = pictureBox40;
            pBox[41] = pictureBox41;
            pBox[42] = pictureBox42;
            pBox[43] = pictureBox43;
            pBox[44] = pictureBox44;
            pBox[45] = pictureBox45;
            pBox[46] = pictureBox46;
            pBox[47] = pictureBox47;
            pBox[48] = pictureBox48;
            pBox[49] = pictureBox49;
            pBox[50] = pictureBox50;
            pBox[51] = pictureBox51;
            pBox[52] = pictureBox52;
            pBox[53] = pictureBox53;
            pBox[54] = pictureBox54;
            pBox[55] = pictureBox55;
            pBox[56] = pictureBox56;
            pBox[57] = pictureBox57;
            pBox[58] = pictureBox58;
            pBox[59] = pictureBox59;
            pBox[60] = pictureBox60;
            pBox[61] = pictureBox61;
            pBox[62] = pictureBox62;
            pBox[63] = pictureBox63;
            pBox[64] = pictureBox64;
            pBox[65] = pictureBox65;
            pBox[66] = pictureBox66;
            pBox[67] = pictureBox67;
            pBox[68] = pictureBox68;
            pBox[69] = pictureBox69;
            pBox[70] = pictureBox70;
            pBox[71] = pictureBox71;
            pBox[72] = pictureBox72;
            pBox[73] = pictureBox73;
            pBox[74] = pictureBox74;
            pBox[75] = pictureBox75;
            pBox[76] = pictureBox76;
            pBox[77] = pictureBox77;
            pBox[78] = pictureBox78;
            pBox[79] = pictureBox79;
            pBox[80] = pictureBox80;
            pBox[81] = pictureBox81;
            pBox[82] = pictureBox82;
            pBox[83] = pictureBox83;
            pBox[84] = pictureBox84;
            pBox[85] = pictureBox85;
            pBox[86] = pictureBox86;
            pBox[87] = pictureBox87;
            pBox[88] = pictureBox88;
            pBox[89] = pictureBox89;
            pBox[90] = pictureBox90;
            pBox[91] = pictureBox91;
            pBox[92] = pictureBox92;

            for (int i = 1; i < 9; i++)
            {
                pBox[i].Click += pickColorFirst;
            }

            for (int i = 9; i < pBox.Length; i++)
            {
                pBox[i].Click += pickColorSecond;
            }

        }
        // Jag delade upp rutinen i två även om det skulle fungera lika väl i en subrutin istället för 2
        // Detta valet gjordes för att göra koden lättare att läsa
        private void pickColorFirst(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
            {
                if (sender == pBox[i])
                {
                    colorPicked = i;
                }
            }
        }
        private void pickColorSecond(object sender, EventArgs e)
        {
            for (int j = 0; j < 11; j++)
            {
                if (tur == j)
                {
                    for (int i = 9 + 4 * (j - 1); i < 9 + 4 * j; i++)
                    {
                        if (sender == pBox[i])
                        {
                            switch (colorPicked)
                            {
                                case 0:
                                    break;
                                case 1:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_1;
                                    plats[(i - 4 * (j - 1)) % 9] = 1;
                                    break;
                                case 2:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_2;
                                    plats[(i - 4 * (j - 1)) % 9] = 2;
                                    break;
                                case 3:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_3;
                                    plats[(i - 4 * (j - 1)) % 9] = 3;
                                    break;
                                case 4:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_4;
                                    plats[(i - 4 * (j - 1)) % 9] = 4;
                                    break;
                                case 5:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_5;
                                    plats[(i - 4 * (j - 1)) % 9] = 5;
                                    break;
                                case 6:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_6;
                                    plats[(i - 4 * (j - 1)) % 9] = 6;
                                    break;
                                case 7:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_7;
                                    plats[(i - 4 * (j - 1)) % 9] = 7;
                                    break;
                                case 8:
                                    pBox[i].BackColor = Color.Gray;
                                    pBox[i].Image = MasterMind.Properties.Resources.color_8;
                                    plats[(i - 4 * (j - 1)) % 9] = 8;
                                    break;
                            }
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (plats[0] > 0 && plats[1] > 0 && plats[2] > 0 && plats[3] > 0 && tur < 11)
            {
                // Vinst
                if (plats[0] == platsKorrekt[0] && plats[1] == platsKorrekt[1] && plats[2] == platsKorrekt[2] && plats[3] == platsKorrekt[3]) 
                {
                    for (int i = 0; i < 4; i++)
                    {
                        switch (platsKorrekt[i])
                        {
                            case 1:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_1;
                                break;
                            case 2:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_2;
                                break;
                            case 3:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_3;
                                break;
                            case 4:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_4;
                                break;
                            case 5:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_5;
                                break;
                            case 6:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_6;
                                break;
                            case 7:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_7;
                                break;
                            case 8:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_8;
                                break;
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        pBox[49 + 4 * (tur - 1) + i].Image = MasterMind.Properties.Resources.color_1;
                        pBox[49 + 4 * (tur - 1) + i].BackColor = Color.Gray;
                    }
                    DialogResult result = MessageBox.Show("Grattis du vann!\nVill du spela igen?", "Mastermind", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        tur = 1;
                        rVal = 0;
                        fVal = 0;
                        button1.Top = 590;
                        pictureBox93.Top = 590;
                        for (int i = 0; i < 4; i++)
                        {
                            plats[i] = 0;
                            tagna[i] = 0;
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            platsKorrekt[i] = svarSkapare.Next(1, 9);
                            while (tagna.Contains(platsKorrekt[i]))
                            {
                                platsKorrekt[i] = svarSkapare.Next(1, 9);
                            }
                            tagna[i] = platsKorrekt[i];
                        }
                        for (int i = 9; i < 89; i++)
                        {
                            pBox[i].Image = MasterMind.Properties.Resources.Hole;
                        }
                        for (int i = 89; i < 93; i++)
                        {
                            pBox[i].Image = MasterMind.Properties.Resources.qm;
                        }

                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                //Förlorar
                else if (tur == 10)
                {
                    button1.Visible = false;
                    pictureBox93.Visible = false;
                    for (int i = 0; i < 4; i++)
                    {
                        switch (platsKorrekt[i])
                        {
                            case 1:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_1;
                                break;
                            case 2:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_2;
                                break;
                            case 3:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_3;
                                break;
                            case 4:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_4;
                                break;
                            case 5:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_5;
                                break;
                            case 6:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_6;
                                break;
                            case 7:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_7;
                                break;
                            case 8:
                                pBox[i + 89].BackColor = Color.Gray;
                                pBox[i + 89].Image = MasterMind.Properties.Resources.color_8;
                                break;
                        }
                    }
                    // Initialiserar temporära korrekta platser
                    for (int i = 0; i < 4; i++)
                    {
                        tempPlatsKorrekt[i] = platsKorrekt[i];
                    }

                    // Bestämmer hints
                    for (int i = 0; i < 4; i++)
                    {
                        if (plats[i] == tempPlatsKorrekt[i])
                        {
                            rVal++;
                            plats[i] = 28;
                            tempPlatsKorrekt[i] = 82;
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (plats[i] == tempPlatsKorrekt[j] && i != j)
                            {
                                fVal++;
                                plats[i] = 28;
                                tempPlatsKorrekt[j] = 82;
                            }
                        }
                    }

                    // Visar hints
                    for (int i = 0; i < 4; i++)
                    {
                        if (rVal > 0)
                        {
                            pBox[49 + 4 * (tur - 1) + i].Image = MasterMind.Properties.Resources.color_1;
                            pBox[49 + 4 * (tur - 1) + i].BackColor = Color.Gray;
                            rVal--;
                        }
                        else if (fVal > 0)
                        {
                            pBox[49 + 4 * (tur - 1) + i].Image = MasterMind.Properties.Resources.color_8;
                            pBox[49 + 4 * (tur - 1) + i].BackColor = Color.Gray;
                            fVal--;
                        }
                    }
                    DialogResult result = MessageBox.Show("Bättre lycka nästa gång\nVill du spela igen?", "Mastermind", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        tur = 1;
                        rVal = 0;
                        fVal = 0;
                        button1.Top = 590;
                        pictureBox93.Top = 590;
                        button1.Visible = true;
                        pictureBox93.Visible = true;
                        for (int i = 0; i < 4; i++)
                        {
                            plats[i] = 0;
                            tagna[i] = 0;
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            platsKorrekt[i] = svarSkapare.Next(1, 9);
                            while (tagna.Contains(platsKorrekt[i]))
                            {
                                platsKorrekt[i] = svarSkapare.Next(1, 9);
                            }
                            tagna[i] = platsKorrekt[i];
                        }
                        for (int i = 9; i < 89; i++)
                        {
                            pBox[i].Image = MasterMind.Properties.Resources.Hole;
                        }
                        for (int i = 89; i < 93; i++)
                        {
                            pBox[i].Image = MasterMind.Properties.Resources.qm;
                        }
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                // Fortsätt som vanligt
                else
                {
                    // Initialiserar temporära korrekta platser
                    for(int i = 0; i <  4; i++)
                    {
                        tempPlatsKorrekt[i] = platsKorrekt[i];
                    }
                    
                    // Bestämmer hints
                    for (int i = 0; i < 4; i++)
                    {
                        if (plats[i] == tempPlatsKorrekt[i])
                        {
                            rVal++;
                            plats[i] = 28;
                            tempPlatsKorrekt[i] = 82;
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (plats[i] == tempPlatsKorrekt[j] && i != j) 
                            {
                                fVal++;
                                plats[i] = 28;
                                tempPlatsKorrekt[j] = 82;
                            }
                        }
                    }

                    // Visar hints
                    for (int i = 0; i < 4; i++)
                    {
                        if (rVal > 0) 
                        {
                            pBox[49 + 4 * (tur - 1) + i].Image = MasterMind.Properties.Resources.color_1;
                            pBox[49 + 4 * (tur - 1) + i].BackColor = Color.Gray;
                            rVal--;
                        }
                        else if (fVal > 0)
                        {
                            pBox[49 + 4 * (tur - 1) + i].Image = MasterMind.Properties.Resources.color_8;
                            pBox[49 + 4 * (tur - 1) + i].BackColor = Color.Gray;
                            fVal--;
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        plats[i] = 0;
                    }
                    tur++;
                    button1.Top -= 46;
                    pictureBox93.Top -= 46;
                    rVal = 0;
                    fVal = 0;
                }
            }
        }
    }
}

//BerraFFS </3
