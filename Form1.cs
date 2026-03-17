using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SymfoniaBug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic item = new JObject();
                item.id = 1234;

                MessageBox.Show(item.id.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}