using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilizandoForms
{
    public partial class frm_princ_calc : Form
    {
        public frm_princ_calc()
        {
            InitializeComponent();

        }

        public double resultado = 0.0;
        public string tipoCalculo;
        public double pm;
        public double disp;
        public double dilui;
        public double adm;
        
        
            
        private void btt_calc_Click(object sender, EventArgs e)
        {


            if (rb_macrogotas.Checked || rb_microgotas.Checked)
            {

                string farmaco = txt_farmaco.Text;
                string apresentacao = txt_apresentacao.Text;
                int dosagem = Int32.Parse(txt_dosagem.Text);
                int volume = Int32.Parse(txt_volume.Text);
                int tempo = Int32.Parse(txt_tempo.Text);


                if (rb_macrogotas.Checked)
                {
                    resultado = volume / (tempo * 3);
                    tipoCalculo = rb_macrogotas.Text;
                }
                if (rb_microgotas.Checked)
                {
                    resultado = volume / tempo;
                    tipoCalculo = rb_microgotas.Text;
                }
            }
            if (rb_diluicao.Checked)
            {
                disp = Int32.Parse(txt_disp.Text);
                pm = Int32.Parse(txt_pm.Text);
                dilui = Int32.Parse(txt_dilui.Text);
                adm = pm*dilui/disp;

                resultado = adm;
                tipoCalculo = "mililitros";



            }

            lbl_exibirResultado.Text = String.Concat(resultado.ToString(), " " , tipoCalculo);
     
        }

        private void btt_limpar_Click(object sender, EventArgs e)
        {
            
            LimparCampos();

        }

        private void rb_diluicao_CheckedChanged(object sender, EventArgs e)
        {
            txt_apresentacao.Enabled= false;
            txt_farmaco.Enabled = false;
            txt_volume.Enabled = false;
            txt_tempo.Enabled=false;
            txt_dosagem.Enabled = false;
            txt_pm.Focus();

            txt_pm.Enabled = true;
            txt_disp.Enabled = true;
            txt_dilui.Enabled = true;
          


        }

        private void rb_macrogotas_CheckedChanged(object sender, EventArgs e)
        {
            txt_apresentacao.Enabled =true;
            txt_farmaco.Enabled = true;
            txt_volume.Enabled = true;
            txt_tempo.Enabled = true;
            txt_dosagem.Enabled = true;
            txt_farmaco.Focus();

            txt_pm.Enabled = false;
            txt_disp.Enabled = false;
            txt_dilui.Enabled = false;
           


        }

        private void rb_microgotas_CheckedChanged(object sender, EventArgs e)
        {
            txt_apresentacao.Enabled = true;
            txt_farmaco.Enabled = true;
            txt_volume.Enabled = true;
            txt_tempo.Enabled = true;
            txt_dosagem.Enabled = true;
            txt_farmaco.Focus();

            txt_pm.Enabled = false;
            txt_disp.Enabled = false;
            txt_dilui.Enabled = false;
            
        }

        public void LimparCampos()
        {
           
                txt_apresentacao.Text = "";
                txt_farmaco.Text = "";
                txt_volume.Text = "";
                txt_tempo.Text = "";
                txt_dosagem.Text = "";
                lbl_exibirResultado.Text = "";
                txt_farmaco.Focus();

                txt_pm.Text = "";
                txt_disp.Text = "";
                txt_dilui.Text = "";
                txt_pm.Focus();
            
        }

    }
}
