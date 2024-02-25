using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrdenadas_Click(object sender, EventArgs e)
        {
            double x = int.Parse(txtX.Text);
            double y = int.Parse(txtY.Text);
            double dosy = int.Parse(txtY2.Text);
            double dosx = int.Parse(txtX2.Text);
            double pendiente = (dosy - y) / (dosx - x);
            pendiente = Math.Round(pendiente,3);
            int k = dataGridView1.Rows.Add();

            dataGridView1.Rows[k].Cells[0].Value = x;
            dataGridView1.Rows[k].Cells[1].Value = y;
            chart1.Series["Graficar"].Points.AddXY(x, y);
            if (x>dosx && y > dosy && pendiente>0 && pendiente < 0.99)
            {
                
                x = x + 1;
                txtPendiente.Text = Convert.ToString(pendiente);
                double nuevoy1 = y - pendiente;

                direcion.Text = " +M<1 izq --> der  arr --> abj";
                int f = dataGridView1.Rows.Add();
                
                dataGridView1.Rows[f].Cells[0].Value = x;
                dataGridView1.Rows[f].Cells[1].Value = y;
                dataGridView1.Rows[f].Cells[1].Value = nuevoy1;
                direcion.Text = "";
                
                for (int i = 0; i < 10; i++)
                {


                    double num = x - 1;
                    double nume = nuevoy1 - pendiente;

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = num;
                    dataGridView1.Rows[n].Cells[1].Value = Math.Round(nume, 2);


                    chart1.Series["Graficar"].Points.AddXY(num, nume);

                    x = num;
                    nuevoy1 = nume;
                }
                return;
            }
            if (x < dosx && y < dosy && pendiente > 0 && pendiente < 0.99)
            {
                x = x + 1;
                txtPendiente.Text = Convert.ToString(pendiente);
                double nuevoy = y + pendiente;

                direcion.Text = "+M<1 izq --> der  abj --> arr";
                int m = dataGridView1.Rows.Add();

                dataGridView1.Rows[m].Cells[0].Value = x;
              
                dataGridView1.Rows[m].Cells[1].Value = y;
                dataGridView1.Rows[m].Cells[1].Value = nuevoy;

                
                for (int i = 0; i < 10; i++)
                {

                   
                    double num = x + 1;
                    double nume = nuevoy + pendiente;

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = num;
                    dataGridView1.Rows[n].Cells[1].Value = Math.Round(nume, 2);


                    chart1.Series["Graficar"].Points.AddXY(num, nume);

                    x = num;
                    nuevoy = nume;
                }
                return;
            }

            //CASOSSSSSSSSSSSSSSSSSSS
            if (x > dosx && y > dosy && pendiente > 1)
            {
                direcion.Text = " +M>1 izq --> der  arr --> abj";

                y = y - 1;
                double pendiente1 = 1 / pendiente;
                pendiente1 = Math.Round(pendiente1,3);
                txtPendiente.Text = Convert.ToString(pendiente1);
                
                double nuevox1 = x - pendiente1;
                
                

                int f = dataGridView1.Rows.Add();

                dataGridView1.Rows[f].Cells[0].Value = x;
                dataGridView1.Rows[f].Cells[1].Value = y;
                dataGridView1.Rows[f].Cells[0].Value = nuevox1;


                for (int i = 0; i < 10; i++)
                {


                    double num = nuevox1 - pendiente1;
                    double nume = y -1 ;

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Math.Round(num, 2);
                    dataGridView1.Rows[n].Cells[1].Value = nume;


                    chart1.Series["Graficar"].Points.AddXY(num, nume);

                    nuevox1 = num;
                    y = nume;
                }
                return;
            }

            if (x < dosx && y < dosy && pendiente > 1)
            {
                y = y + 1;
                double pendiente1 = 1 / pendiente;
                txtPendiente.Text = Convert.ToString(Math.Round( pendiente1,3));
                pendiente1 = Math.Round(pendiente1,3);
                double nuevox1 = x + pendiente1;

                direcion.Text = " +M>1 der --> izq  arr --> abj";

                int f = dataGridView1.Rows.Add();

                dataGridView1.Rows[f].Cells[0].Value = x;
                dataGridView1.Rows[f].Cells[1].Value = y;
                dataGridView1.Rows[f].Cells[0].Value = nuevox1;


                for (int i = 0; i < 10; i++)
                {


                    double num = nuevox1 + pendiente1;
                    double nume = y + 1;

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Math.Round(num, 2);
                    dataGridView1.Rows[n].Cells[1].Value = nume;


                    chart1.Series["Graficar"].Points.AddXY(num, nume);

                   nuevox1= num;
                   y = nume;
                }
                return;
            }
            //cAOSSSSSS
            if (x > dosx && y < dosy && pendiente > -0.99 && pendiente < -0)
            {
                direcion.Text = " -M<1 der --> izq  arr --> abj";
                x = x - 1;
                txtPendiente.Text = Convert.ToString(pendiente);
                double nuevoy1 = y + Math.Abs( pendiente);
                

                int f = dataGridView1.Rows.Add();

                dataGridView1.Rows[f].Cells[0].Value = x;
                dataGridView1.Rows[f].Cells[1].Value = y;
                dataGridView1.Rows[f].Cells[1].Value = nuevoy1;


                for (int i = 0; i < 10; i++)
                {


                    double num = x - 1;
                    double nume = nuevoy1 + Math.Abs( pendiente);

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = num;
                    dataGridView1.Rows[n].Cells[1].Value = Math.Round(nume, 2);


                    chart1.Series["Graficar"].Points.AddXY(num, nume);

                    x = num;
                    nuevoy1 = nume;
                }
                return;
            }
            if (x < dosx && y > dosy && pendiente > -0.99 && pendiente < -0.1)
            {
                x = x + 1;
                txtPendiente.Text = Convert.ToString(pendiente);
                double nuevoy = y - Math.Abs(pendiente);
                direcion.Text = "-M<1 izq --> der  arr --> abj";

                int m = dataGridView1.Rows.Add();

                dataGridView1.Rows[m].Cells[0].Value = x;
                dataGridView1.Rows[m].Cells[1].Value = y;
                dataGridView1.Rows[m].Cells[1].Value = nuevoy;


                for (int i = 0; i < 10; i++)
                {


                    double num = x + 1;
                    double nume = nuevoy - Math.Abs(pendiente);

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = num;
                    dataGridView1.Rows[n].Cells[1].Value = Math.Round(nume, 2);


                    chart1.Series["Graficar"].Points.AddXY(num, nume);

                    x = num;
                    nuevoy = nume;
                }
                return;
            }

            if (x > dosx && y < dosy && pendiente < -1)
            {
                y = y + 1;
                double pendiente1 = 1 / pendiente;
                pendiente1 = Math.Abs(pendiente1);
                txtPendiente.Text = Convert.ToString(pendiente);
                double nuevox1 = x + Math.Round(pendiente1,2);
                direcion.Text = "-M<1 der -->   abj --> arr";


                int f = dataGridView1.Rows.Add();

                dataGridView1.Rows[f].Cells[0].Value = x;
                dataGridView1.Rows[f].Cells[1].Value = y;
                dataGridView1.Rows[f].Cells[0].Value = nuevox1;


                for (int i = 0; i < 10; i++)
                {


                    double num = nuevox1 + Math.Abs( pendiente1);
                    double nume = y + 1;

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Math.Round(num,2);
                    dataGridView1.Rows[n].Cells[1].Value = nume;


                    chart1.Series["Graficar"].Points.AddXY(Math.Round( num,2), nume);

                    nuevox1 = num;
                    y = nume;
                }
                return;
            }

            if (x < dosx && y > dosy && pendiente < -1)
            {
                y = y + 1;
                double pendiente1 = 1 / pendiente;
                pendiente1=Math.Abs(pendiente1);
                txtPendiente.Text = Convert.ToString(pendiente);
                double nuevox1 = x - Math.Round(pendiente1,2);
                direcion.Text = "-M>1 izq --> der  arr --> abj";


                int f = dataGridView1.Rows.Add();

                dataGridView1.Rows[f].Cells[0].Value = x;
                dataGridView1.Rows[f].Cells[1].Value = y;
                dataGridView1.Rows[f].Cells[0].Value = nuevox1;


                for (int i = 0; i < 10; i++)
                {


                    double num = nuevox1 - Math.Abs(pendiente1);
                    double nume = y + 1;

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Math.Round(num,2);
                    dataGridView1.Rows[n].Cells[1].Value = nume;


                    chart1.Series["Graficar"].Points.AddXY(Math.Round( num,2), nume);

                    nuevox1 = num;
                    y = nume;
                }
                return;
            }
            else
                {
                     x = x + 1;
                    txtPendiente.Text = Convert.ToString(pendiente);
                    double nuevoy2 = y + pendiente;
                    direcion.Text = "+M<1 izq --> der  abj --> arr";


                int l = dataGridView1.Rows.Add();

                    dataGridView1.Rows[l].Cells[0].Value = x;
                    dataGridView1.Rows[l].Cells[1].Value = y;
                    dataGridView1.Rows[l].Cells[1].Value = nuevoy2;


                    for (int i = 0; i < 10; i++)
                    {


                        double num = x + 1;
                        double nume = nuevoy2 + pendiente;

                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = num;
                        dataGridView1.Rows[n].Cells[1].Value = Math.Round(nume,2);


                        chart1.Series["Graficar"].Points.AddXY(num, nume);

                        x = num;
                        nuevoy2 = nume;
                    }
                    return;
            }
            
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtX2.Clear();
            txtY2.Clear();
            txtPendiente.Clear();
            direcion.Text = "Direcion";
            chart1.Series["Graficar"].Points.Clear();
            dataGridView1.Rows.Clear();

        }
    }
}
