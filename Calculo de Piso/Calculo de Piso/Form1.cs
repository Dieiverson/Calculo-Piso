using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_Piso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            
            if (cbox_Quadrado.Checked == true)

            {
                lbl_01.Text = "Digite a altura do quadrado:";
                lbl_01.Visible = true;
                lbl_02.Text = "Digite o comprimento do quadrado";
                lbl_02.Visible = true;
                btn_calcular.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;

                
                



            }
            if (cbox_Triangulo.Checked == true)
            {
                lbl_01.Text = "Digite a altura do triângulo:";
                lbl_01.Visible = true;
                lbl_02.Text = "Digite a base do triângulo";
                lbl_02.Visible = true;
                btn_calcular.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;

            }
            if (cbox_Redondo.Checked == true)
            {
                lbl_01.Text = "Digite o raio do círculo:";
                lbl_01.Visible = true;

                btn_calcular.Visible = true;
                textBox1.Visible = true;
				lbl_02.Visible = false;
				textBox2.Visible = false;
            }
           
            if (cbox_Redondo.Checked == false & cbox_Quadrado.Checked == false & cbox_Triangulo.Checked == false)
            {
                MessageBox.Show("Selecione uma opção!!");

            }
        }

        private void cbox_Quadrado_CheckedChanged(object sender, EventArgs e)
        {
            cbox_Redondo.Checked = false;
            cbox_Triangulo.Checked = false;
        }

        private void cbox_Redondo_CheckedChanged(object sender, EventArgs e)
        {
            cbox_Quadrado.Checked = false;
            cbox_Triangulo.Checked = false;
        }

        private void cbox_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            cbox_Quadrado.Checked = false;
            cbox_Redondo.Checked = false;

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (cbox_Quadrado.Checked)
            {
                if (textBox1.Text == "" | textBox1.Text == null | textBox2.Text == "" | textBox2.Text == null)
                {
                    MessageBox.Show(" Preencha os campos ");
                }
                else if (Convert.ToDouble(textBox1.Text) < 1 || Convert.ToDouble(textBox2.Text) < 1)
                {
                    MessageBox.Show("não existe área negativa");
                }

                else
                {
                    MessageBox.Show((Quadrado(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text))));
                }







            }
            if (cbox_Redondo.Checked)
            {

                if (textBox1.Text != "")
                {
                    if (Convert.ToDouble(textBox1.Text) > 1)
                    {

                        MessageBox.Show((circulo(Convert.ToDouble(textBox1.Text))));
                        

                    }
                    else
                    {
                        MessageBox.Show("Não existe área negativa");
                    }
                }



                else
                {
                    MessageBox.Show(" Preencha os campos ");
                }





            }
            if (cbox_Triangulo.Checked)
            {

                if (textBox1.Text != "" & textBox1.Text != null & textBox2.Text != "" & textBox2.Text != null)
                {
                    if (Convert.ToDouble(textBox1.Text) > 1 & Convert.ToDouble(textBox2.Text) > 1)
                    {
                        MessageBox.Show((triangulo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text))));
                       

                    }

                    else
                    {
                        MessageBox.Show("Não existe área negativa");
                    }

                }

                
            
            else
            {
                MessageBox.Show("Preencha os campos!");
            }

            }
        


        }
        string Quadrado(double Altura, double Comprimento)
        {
           double sobraquadrado = Altura * Comprimento / 100 * 2; 
           return ("  Você vai usar  ") + Altura * Comprimento + "m² de revestimentos. Sendo: " + sobraquadrado+" de sobra,ou seja 2% " ;
        }

       
        string circulo(double raio)

        {
            double sobracirculo = (raio * raio) * Math.PI / 100 * 2;
            return ("  Você vai usar  ")+(raio * raio) * Math.PI + "m² de revestimentos. Sendo: "+ sobracirculo + " de sobra,ou seja 2% ";
        }
        string triangulo (double triangulobase,double altura)
        {
            double sobratriangulo = (triangulobase * altura) / 2 / (100 * 2);
            return ("  Você vai usar  ")+(triangulobase * altura )/ 2 + "m² de revestimentos. Sendo: " +sobratriangulo+ " de sobra,ou seja 2% ";
			
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

