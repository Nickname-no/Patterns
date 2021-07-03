using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpreter
{
    public partial class Interpreter : Form
    {
        public Interpreter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String context = textBox1.Text;
            AbstractExpression ae = new AbstractExpression();
            ae.interpret(ref context);
            textBox1.Text = context;
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            this.textBox1.Height = this.Height - 72;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
