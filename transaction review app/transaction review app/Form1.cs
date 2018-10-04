using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FloSDK.Exceptions;
using FloSDK.Methods;
using Newtonsoft.Json.Linq;

namespace transaction_review_app
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings.Get("rpcusername");
            string password = ConfigurationManager.AppSettings.Get("rpcpassword");
            string wallet_url = ConfigurationManager.AppSettings.Get("wallet_url");
            string wallet_port = ConfigurationManager.AppSettings.Get("wallet_port");

            RpcMethods rpc = new RpcMethods(username, password, wallet_url, wallet_port);
            

            try
            {
                
                string Name = namebox.Text;
                string Send_to = Send_to_box.Text;
                string flo_coin = flo_box.Text;
                string Review = reviewbox.Text;
                int flocoin = 0;
                flocoin = Convert.ToInt32(flo_coin);

                string flodata = "Review from:" + Name + "-- " + Review;

                JObject jobj = JObject.Parse(rpc.SendToAddress(Send_to, flocoin, "review purpose", "review purpose", false, false, 1, "UNSET", flodata));
                if (string.IsNullOrEmpty(jobj["error"].ToString()))
                {
                    
                    labelmsg.Text = "Review saved successfully to FLO";
                    labelmsg.Visible = true;
                    labelmsg.ForeColor = Color.Green;
                }
                else
                {
                    labelmsg.Text = "Error!!!" + "could not retrieve any transaction details..plzz check ur transaction id";
                    labelmsg.Visible = true;
                    labelmsg.ForeColor = Color.Red;
                }

            }
            catch (RpcInternalServerErrorException ex)
            {
                var errCode = 0;
                var errMessage = string.Empty;
                if (ex.RpcErrorCode.GetHashCode() != 0)
                {
                    errCode = ex.RpcErrorCode.GetHashCode();
                    errMessage = ex.RpcErrorCode.ToString();
                }
                Console.WriteLine("Exception :" + errCode + "-" + errMessage);
                

                labelmsg.Text = "INternal server error!!";
                labelmsg.ForeColor = Color.Red;
                labelmsg.Visible = true;
                labelmsg.Visible = true;



            }
            catch (Exception ex1)
            {
                Console.WriteLine("Exception :" + ex1.ToString());
                labelmsg.Text = "Error connecting to the server!!";
                labelmsg.ForeColor = Color.Red;
                labelmsg.Visible = true;
                labelmsg.Visible = true;
            }
        }

        private void sendtoaddress()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void review_Click(object sender, EventArgs e)
        {
            name.Visible = true;
            Send_to.Visible = true;
            review_label.Visible = true;
            namebox.Visible = true;
            Send_to_box.Visible = true;
            reviewbox.Visible = true;
            button1.Visible = true;
            flo_label.Visible = true;
            flo_box.Visible = true;
        }

        private void refer_Click(object sender, EventArgs e)
        {
            
            trans_id.Visible = true;
            
            txidbox2.Visible = true;
            transaction.Visible = true;
            button2.Visible = true;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings.Get("rpcusername");
            string password = ConfigurationManager.AppSettings.Get("rpcpassword");
            string wallet_url = ConfigurationManager.AppSettings.Get("wallet_url");
            string wallet_port = ConfigurationManager.AppSettings.Get("wallet_port");

            RpcMethods rpc = new RpcMethods(username, password, wallet_url, wallet_port);
            try
            {
                
                string tx_id2 = txidbox2.Text;

                JObject obj1 = JObject.Parse(rpc.GetRawTransaction(tx_id2));
                if (string.IsNullOrEmpty(obj1["error"].ToString()))
                {
                    string flodata = "";
                    flodata = obj1["result"]["flodata"].ToString();
                    label2.Text = flodata;
                    label2.ForeColor = Color.Green;
                    label2.Visible = true;
                    

                }
                else
                {
                    label2.Text = "Error retrieving reviews from the flo!!";
                    label2.ForeColor = Color.Green;
                    label2.Visible = true;
                }



            }
            catch (RpcInternalServerErrorException ex)
            {
                var errCode = 0;
                var errMessage = string.Empty;
                if (ex.RpcErrorCode.GetHashCode() != 0)
                {
                    errCode = ex.RpcErrorCode.GetHashCode();
                    errMessage = ex.RpcErrorCode.ToString();
                }
                Console.WriteLine("Exception :" + errCode + "-" + errMessage);


                label2.Text = "Internal server error!!";
                label2.ForeColor = Color.Red;
                label2.Visible = true;
                label2.Visible = true;



            }
            catch (Exception ex1)
            {
                Console.WriteLine("Exception :" + ex1.ToString());
                label2.Text = "Error connecting to the server!!";
                label2.ForeColor = Color.Red;
                label2.Visible = true;
                label2.Visible = true;
            }

        }

        private void flo_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
