using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutClass_Assignment_05
{
    public partial class CakeCost : Form
    {
        public CakeCost()
        {
            InitializeComponent();
        }

        private void CakeCost_Load(object sender, EventArgs e)
        {
            if(BuildYourCake.getCakeType == "Chocolate Cake")
                cakeImage.Image = Image.FromFile(@"D:\00 Classes\Year 1 - Semester 2\CST - 117 ( Enterprise )\OutClass_Assignment_05\Chocolate_cake.png");
            else if(BuildYourCake.getCakeType == "Fruit Cake")
                cakeImage.Image = Image.FromFile(@"D:\00 Classes\Year 1 - Semester 2\CST - 117 ( Enterprise )\OutClass_Assignment_05\Fruit_cake.png");
            else if (BuildYourCake.getCakeType == "Creamy Cake" && BuildYourCake.getIngredients != "Chocolate Cream")
                cakeImage.Image = Image.FromFile(@"D:\00 Classes\Year 1 - Semester 2\CST - 117 ( Enterprise )\OutClass_Assignment_05\VanillaCream_cake.jpg");
            else if(BuildYourCake.getCakeType == "Creamy Cake" && BuildYourCake.getIngredients == "Chocolate Cream")
                cakeImage.Image = Image.FromFile(@"D:\00 Classes\Year 1 - Semester 2\CST - 117 ( Enterprise )\OutClass_Assignment_05\ChocolateCream_cake.jpg");
            double cost = BuildYourCake.cost;
            double monthly = cost / 3;
            if (BuildYourCake.payment == "Credit Card")
            {
                lbl_cost.Text = "Your Total Cost is $" + cost + "\n $" + Math.Round(monthly, 2) + " per 3 months.";
            }
            else
                lbl_cost.Text = "Your Total Cost is $" + BuildYourCake.cost.ToString();

            if (BuildYourCake.payment == "Cash / Pick up")
            {
                lbl_readyTime.Text = "You can pay and pick up your \n cake 4 hours later.";
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
