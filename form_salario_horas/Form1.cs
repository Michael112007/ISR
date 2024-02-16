using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace form_salario_horas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double Pago_Hora, Horas_Trabajadas, Sueldo_Bruto, AFP, SFS, Sueldo_Neto, Total_Descuento, Sueldo_Anual, ISR;

            Pago_Hora = Double.Parse(txt_pago_por_hora.Text);
            Horas_Trabajadas = Double.Parse(txt_horas_trabajadas.Text);


            Sueldo_Bruto = Pago_Hora * Horas_Trabajadas;

            AFP = Sueldo_Bruto * 0.0287;
            SFS = Sueldo_Bruto * 0.034;

            Total_Descuento = AFP + SFS;

            Sueldo_Neto = Sueldo_Bruto - Total_Descuento;
            Sueldo_Anual = Sueldo_Neto * 12;

            txt_sueldo_bruto.Text = Sueldo_Bruto.ToString();
            txt_afp.Text = AFP.ToString();
            txt_sfs.Text = SFS.ToString();
            txt_sueldo_anual.Text = Sueldo_Neto.ToString();
            txt_total_des.Text = Total_Descuento.ToString();
            txt_sueldo_anual.Text = Sueldo_Anual.ToString();



            if (Sueldo_Anual <= 416220.00)
            {
                ISR = 0;
                txt_isr.Text = "Excepto";
                txt_status.Text = "Excento";

            }

            else if (Sueldo_Anual >= 416220.01 && Sueldo_Anual <= 624329.00)
            {
                ISR = ((Sueldo_Anual - 416220.01) * 0.15) / 12;
                txt_status.Text = "Aplica";

            }

            else if (Sueldo_Anual >= 624329.01 && Sueldo_Anual <= 867123.00)
            {
                ISR = (31216 + (Sueldo_Anual - 624329.01) * 0.20) / 12;
                txt_status.Text = "Aplica";
            }

            else
            {
                ISR = (79726.00 + (Sueldo_Anual - 867123.00) * 0.25) / 12;
                txt_status.Text = "Aplica";
            }
            txt_isr.Text = ISR.ToString();


            




        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_pago_por_hora.Clear();
            txt_horas_trabajadas.Clear();
            txt_sueldo_bruto.Clear();
            txt_afp.Clear();
            txt_sfs.Clear();
            txt_sueldo_anual.Clear();
            txt_isr.Clear();
            txt_status.Clear();
            txt_total_des.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
