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
        int id = 0;
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

        private void QuestionShow(int id)
        {
            this.Controls.Clear();
            Label label = new Label();
            Panel panel = new Panel();

            panel.BackColor = Color.White;
            for (int i = 0; i < 4; i++)
            {
                RadioButton button = new RadioButton();
                if (i == 0)
                {
                    button.BackColor = Color.LightGreen;
                    button.Text = "++";
                }
                else if (i == 1)
                {
                    button.BackColor = Color.LightGreen;
                    button.Text = "+";
                }
                else if (i == 2)
                {
                    button.BackColor = Color.LightGreen;
                    button.Text = "-";
                }
                else if (i == 3)
                {
                    button.BackColor = Color.LightGreen;
                    button.Text = "--";
                }
                panel.Controls.Add(button);
            }
            label.Text = questions[id - 1];
            label.Location = new Point(this.Size.Width - label.Width, 10);
            panel.Location = new Point(this.Size.Width - label.Width, 20 + label.Height);
            this.Controls.Add(panel);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Button next = new Button();
            Button prev = new Button();
            next.Size = new Size(20, 10);
            prev.Size = new Size(20, 10);


            next.Location = new Point(10, this.Height - (10 + this.Height));
            prev.Location = new Point(20 + next.Width, this.Height - (10 + this.Height));

            next.Click += Next_Click;
            prev.Click += Prev_Click;

            if(id != 9)
            {
                this.Controls.Add(next);
            }
            if(id != 0)
            {
                this.Controls.Add(prev);
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            id--;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            id++;
        }
    }
}
