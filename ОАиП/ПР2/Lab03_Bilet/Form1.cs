using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRaschet_Click(object sender, EventArgs e)
        {
            string vvod = txtVozrast.Text;
            int vozrast;
            bool etochislo = int.TryParse(vvod, out vozrast);
            if (etochislo == false)
            {
                lblRezultat.Text = "Ошибка: введите целое число";
                return;
            }

            if (vozrast < 0 || vozrast > 120)
            {
                lblRezultat.Text = "Ошибка: возраст должен быть от 0 до 120.";
            }
            else if (vozrast <= 6)
            {
                lblRezultat.Text = "Категория: дошкольник. Цена: 0 руб.";
            }
            else if (vozrast <= 17)
            {
                lblRezultat.Text = "Категория: детский. Цена: 250 руб.";
            }
            else if (vozrast <= 59)
            {
                lblRezultat.Text = "Категория: взрослый. Цена: 450 руб.";
            }
            else 
            {
                lblRezultat.Text = "Категория: льготный. Цена: 200 руб.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
