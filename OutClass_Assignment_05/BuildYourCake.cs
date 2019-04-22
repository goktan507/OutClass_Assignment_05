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
    public partial class BuildYourCake : Form
    {
        public static string getCakeType = "";
        public static string getIngredients = "";
        public static double cost = 0;
        public static string payment = "";
        public BuildYourCake()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cost_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.box_breadLayer.Text != ""
                && this.box_cakeType.Text != ""
                && this.box_ingredients.Text != ""
                && this.box_payment.Text != "")
                {
                    cost = int.Parse(box_breadLayer.Text) * 3.49;
                    if (box_ingredients.Text == "White Chocolate"
                        || box_ingredients.Text == "Mile Chocolate")
                        cost += 5.89;
                    else if (box_ingredients.Text == "Dark Chocolate")
                        cost += 4.29;
                    else if (box_ingredients.Text == "Double Chocolate")
                        cost += 6.99;
                    else if (box_ingredients.Text == "Grapes"
                        || box_ingredients.Text == "Cherry"
                        || box_ingredients.Text == "Apple")
                        cost += 2.49;
                    else if (box_ingredients.Text == "Strawberry"
                        || box_ingredients.Text == "Banana"
                        || box_ingredients.Text == "Pineapple")
                        cost += 3.29;
                    else if (box_ingredients.Text == "Sweat Sour Cream")
                        cost += 1.89;
                    else if (box_ingredients.Text == "Chocolate Cream")
                        cost += 2.89;
                    else if (box_ingredients.Text == "Vanilla Cream"
                        || box_ingredients.Text == "Banana Cream")
                        cost += 2.69;

                    if (box_payment.Text == "Credit Card")
                        cost += 3.99;
                    else if (box_payment.Text == "Paypal" || box_payment.Text == "Debit Card")
                        cost += 0.89;
                    else
                        cost += 0.00;

                    getCakeType = box_cakeType.Text;
                    payment = box_payment.Text;
                    getIngredients = box_ingredients.Text;
                    CakeCost theCost = new CakeCost();
                    theCost.ShowDialog();
                    
                }
                else
                    MessageBox.Show("You need to select everything before get the cost");

                this.Close();
                
            }
            catch
            {
                MessageBox.Show("You need to select everything before get the cost");
            }
            

        }

        private void box_breadLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.box_breadLayer.Text != null && box_cakeType.Visible != true && lbl_cakeType.Visible != true)
            {
                this.box_cakeType.Visible = true;
                this.lbl_cakeType.Visible = true;
            }

        }
        private void box_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.box_ingredients.Text != null && box_payment.Visible != true && lbl_paymentSelection.Visible != true)
            {
                this.box_payment.Visible = true;
                this.lbl_paymentSelection.Visible = true;
            }

        }
        private void box_cakeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.box_cakeType.Text != null && box_ingredients.Visible != true && lbl_ingredients.Visible != true)
            {
                this.box_ingredients.Visible = true;
                this.lbl_ingredients.Visible = true;
            }
            if (this.box_cakeType.SelectedItem.ToString() == "Chocolate Cake")
            {
                if(!this.box_ingredients.Items.Contains("White Chocolate"))
                {
                    this.box_ingredients.Items.Add("White Chocolate");
                    this.box_ingredients.Items.Add("Dark Chocolate");
                    this.box_ingredients.Items.Add("Milk Chocolate");
                    this.box_ingredients.Items.Add("Double Chocolate");
                }
                if(this.box_ingredients.Items.Contains("Cherry"))
                {
                    this.box_ingredients.Items.Remove("Grapes");
                    this.box_ingredients.Items.Remove("Banana");
                    this.box_ingredients.Items.Remove("Strawberry");
                    this.box_ingredients.Items.Remove("Pineapple");
                    this.box_ingredients.Items.Remove("Apple");
                    this.box_ingredients.Items.Remove("Cherry");
                }
                if(this.box_ingredients.Items.Contains("Vanilla Cream"))
                {
                    this.box_ingredients.Items.Remove("Vanilla Cream");
                    this.box_ingredients.Items.Remove("Chocolate Cream");
                    this.box_ingredients.Items.Remove("Banana Cream");
                    this.box_ingredients.Items.Remove("Sweat Sour Cream");
                }
                
            }
            else if (this.box_cakeType.SelectedItem.ToString() == "Fruit Cake")
            {
                if(!this.box_ingredients.Items.Contains("Cherry"))
                {
                    this.box_ingredients.Items.Add("Grapes");
                    this.box_ingredients.Items.Add("Banana");
                    this.box_ingredients.Items.Add("Strawberry");
                    this.box_ingredients.Items.Add("Pineapple");
                    this.box_ingredients.Items.Add("Apple");
                    this.box_ingredients.Items.Add("Cherry");
                }
                if(this.box_ingredients.Items.Contains("White Chocolate"))
                {
                    this.box_ingredients.Items.Remove("White Chocolate");
                    this.box_ingredients.Items.Remove("Dark Chocolate");
                    this.box_ingredients.Items.Remove("Milk Chocolate");
                    this.box_ingredients.Items.Remove("Double Chocolate");
                }
                if(this.box_ingredients.Items.Contains("Vanilla Cream"))
                {
                    this.box_ingredients.Items.Remove("Vanilla Cream");
                    this.box_ingredients.Items.Remove("Chocolate Cream");
                    this.box_ingredients.Items.Remove("Banana Cream");
                    this.box_ingredients.Items.Remove("Sweat Sour Cream");
                }
            }

            else if (this.box_cakeType.SelectedItem.ToString() == "Creamy Cake")
            {
                if(!this.box_ingredients.Items.Contains("Vanilla Cream"))
                {
                    this.box_ingredients.Items.Add("Vanilla Cream");
                    this.box_ingredients.Items.Add("Chocolate Cream");
                    this.box_ingredients.Items.Add("Banana Cream");
                    this.box_ingredients.Items.Add("Sweat Sour Cream");
                }
                if(this.box_ingredients.Items.Contains("Apple"))
                {
                    this.box_ingredients.Items.Remove("Grapes");
                    this.box_ingredients.Items.Remove("Banana");
                    this.box_ingredients.Items.Remove("Strawberry");
                    this.box_ingredients.Items.Remove("Pineapple");
                    this.box_ingredients.Items.Remove("Apple");
                    this.box_ingredients.Items.Remove("Cherry");
                }
                if(this.box_ingredients.Items.Contains("White Chocolate"))
                {
                    this.box_ingredients.Items.Remove("White Chocolate");
                    this.box_ingredients.Items.Remove("Dark Chocolate");
                    this.box_ingredients.Items.Remove("Milk Chocolate");
                    this.box_ingredients.Items.Remove("Double Chocolate");
                } 
            }
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
