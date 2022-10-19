using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Chart_Group_6_Team_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[Stella Parker] Bar chart button click
        private void btnBarChart_Click(object sender, EventArgs e)
        {
            //[Stella Parker] Taking in values for Store 1-5
            int Store1 = int.Parse(txtStore1.Text);
            int Store2 = int.Parse(txtStore2.Text);
            int Store3 = int.Parse(txtStore3.Text);
            int Store4 = int.Parse(txtStore4.Text);
            int Store5 = int.Parse(txtStore5.Text);

            //[Stella Parker] Checking each value for Store 1-5
            if (Store1 > 0 && Store1 <= 5000 && Store2 > 0 && Store2 <= 5000 && Store3 > 0 && Store3 <= 5000 && Store4 > 0
                && Store4 <= 5000 && Store5 > 0 && Store5 <= 5000)
            {
                //[Stella Parker] Storing each value for Store 1-5in the array when each store
                //value is a non negative and less than 5000 
                int[] stores = new int[5] { Store1, Store2, Store3, Store4, Store5 };
                int totalSale = 0; //[Stella Parker] declaring variable for Stores total sales
                int maxSale = 0; //[Stella Parker] declaring variable for Stores maximum sales
                int minSale = 0; //[Stella Parker] declaring variable for Stores minimum sales

                //[Stella Parker] considring maximum and minimum sale as stores[0]
                maxSale = minSale = stores[0];

                //[Stella Parker] creating an aray to text box while storing each text box
                TextBox[] tb = new TextBox[] {txtStore1, txtStore2, txtStore3, txtStore4, txtStore5};

                //[Stella Parker] using for loop
                for (int i = 0; i < tb.Length; i++)
                { 



            }
        }
}
