using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private List<string> questions = new List<string>()
        {
            "Economics would be closed from world.",
            "Author right must disapear.",
            "In country would be one national language.",
            "Culture would be telling about greatness of country.",
            "Freedom is bad for people.",
            "Country must be controled by one person.",
            "Social rights would be only on men.",
            "Travelling is forbidden.",
            "In country must be one currency.",
            "All people have they own minimal payment.",
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
