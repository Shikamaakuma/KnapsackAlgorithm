using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnapsackAlgorithm
{
    public partial class Calculator : Form
    {
        private int objectAmount;
        private int objectCurrent;
        private int[,] objects;
        private int[,,] dp_table;
        private string[] names;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //to prevent overflow we set the maximal Values according to int
            NUD_MaxVolume.Maximum = int.MaxValue;
            NUD_MaxWeight.Maximum = int.MaxValue;
            NUD_ObjectNum.Maximum = int.MaxValue;
            NUD_Value.Maximum = int.MaxValue;
            NUD_Volume.Maximum = int.MaxValue;
            NUD_Weight.Maximum = int.MaxValue;
        }

        //initialises process and creates all needed structures
        private void BT_ToObjects_Click(object sender, EventArgs e)
        {
            this.objectAmount = (int)NUD_ObjectNum.Value;
            this.objects = new int[this.objectAmount, 3];
            this.names = new string[this.objectAmount];
            this.dp_table = new int[this.objectAmount + 1, (int)NUD_MaxWeight.Value + 1, (int)NUD_MaxVolume.Value + 1];
            GB_Objects.Enabled = true;
            BT_Next.Enabled = true;
            this.objectCurrent = 0;
            GB_Objects.Text = "object " + (objectCurrent + 1);
            GB_Initialise.Enabled = false;
        }

        //gets all objects (int[,]) and outputs the solution
        private void BT_Next_Click(object sender, EventArgs e)
        {
            if (objectCurrent < this.objectAmount - 2)
            {
                GetObjectValues();
                GB_Objects.Text = "Object " + (objectCurrent + 1);

            }
            else if (objectCurrent < this.objectAmount -1)
            {
                GetObjectValues();
                GB_Objects.Text = "";
                GB_Objects.Enabled = false;
                BT_Next.Text = "GO";
            }
            else
            {
                Knapsack solve = new Knapsack();
                bool[] used;

                int maxValue = solve.Main(this.dp_table, this.objects, out used);

                LB_Solution.Text = "The maximal value of the knapsack's content is " + maxValue + " containing:";
                for (int i = 0; i < names.Length; i++)
                {
                    if (used[i])
                        LB_Solution.Text += "\r\n" + names[i];
                }
                GB_Initialise.Enabled=true;
                BT_Next.Text = "Next";
            }
        }

        //creates the objects (int[,])
        private void GetObjectValues()
        {
            this.names[objectCurrent] = TB_Name.Text;
            this.objects[objectCurrent, 0] = (int)NUD_Value.Value;
            this.objects[objectCurrent, 1] = (int)NUD_Weight.Value;
            this.objects[objectCurrent, 2] = (int)NUD_Volume.Value;

            objectCurrent++;
            TB_Name.Text = "";
            NUD_Weight.Value = 0;
            NUD_Volume.Value = 0;
            NUD_Value.Value = 0;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }
    }
}
