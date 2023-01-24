namespace UtilizandoForms
{
    partial class frm_princ_calc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_princ_calc));
            this.lbl_farmaco = new System.Windows.Forms.Label();
            this.txt_farmaco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apresentacao = new System.Windows.Forms.TextBox();
            this.lbl_dose = new System.Windows.Forms.Label();
            this.txt_dosagem = new System.Windows.Forms.TextBox();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.txt_volume = new System.Windows.Forms.TextBox();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btt_calc = new System.Windows.Forms.Button();
            this.btt_limpar = new System.Windows.Forms.Button();
            this.lbl_exibirResultado = new System.Windows.Forms.Label();
            this.rb_macrogotas = new System.Windows.Forms.RadioButton();
            this.rb_microgotas = new System.Windows.Forms.RadioButton();
            this.rb_diluicao = new System.Windows.Forms.RadioButton();
            this.lbl_pm = new System.Windows.Forms.Label();
            this.txt_pm = new System.Windows.Forms.TextBox();
            this.lbl_disp = new System.Windows.Forms.Label();
            this.txt_disp = new System.Windows.Forms.TextBox();
            this.txt_dilui = new System.Windows.Forms.TextBox();
            this.lbl_dilui = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_farmaco
            // 
            this.lbl_farmaco.AutoSize = true;
            this.lbl_farmaco.Location = new System.Drawing.Point(12, 92);
            this.lbl_farmaco.Name = "lbl_farmaco";
            this.lbl_farmaco.Size = new System.Drawing.Size(49, 13);
            this.lbl_farmaco.TabIndex = 0;
            this.lbl_farmaco.Text = "Fármaco:";
            // 
            // txt_farmaco
            // 
            this.txt_farmaco.Enabled = false;
            this.txt_farmaco.Location = new System.Drawing.Point(12, 109);
            this.txt_farmaco.MaxLength = 30;
            this.txt_farmaco.Name = "txt_farmaco";
            this.txt_farmaco.Size = new System.Drawing.Size(168, 21);
            this.txt_farmaco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apresentação:";
            // 
            // txt_apresentacao
            // 
            this.txt_apresentacao.Enabled = false;
            this.txt_apresentacao.Location = new System.Drawing.Point(12, 150);
            this.txt_apresentacao.MaxLength = 30;
            this.txt_apresentacao.Name = "txt_apresentacao";
            this.txt_apresentacao.Size = new System.Drawing.Size(168, 21);
            this.txt_apresentacao.TabIndex = 3;
            // 
            // lbl_dose
            // 
            this.lbl_dose.AutoSize = true;
            this.lbl_dose.Location = new System.Drawing.Point(12, 184);
            this.lbl_dose.Name = "lbl_dose";
            this.lbl_dose.Size = new System.Drawing.Size(66, 13);
            this.lbl_dose.TabIndex = 4;
            this.lbl_dose.Text = "Dosagem/mg";
            // 
            // txt_dosagem
            // 
            this.txt_dosagem.Enabled = false;
            this.txt_dosagem.Location = new System.Drawing.Point(12, 199);
            this.txt_dosagem.MaxLength = 4;
            this.txt_dosagem.Name = "txt_dosagem";
            this.txt_dosagem.Size = new System.Drawing.Size(109, 21);
            this.txt_dosagem.TabIndex = 5;
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(12, 235);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(56, 13);
            this.lbl_volume.TabIndex = 6;
            this.lbl_volume.Text = "Volume/ml";
            // 
            // txt_volume
            // 
            this.txt_volume.Enabled = false;
            this.txt_volume.Location = new System.Drawing.Point(12, 251);
            this.txt_volume.MaxLength = 4;
            this.txt_volume.Name = "txt_volume";
            this.txt_volume.Size = new System.Drawing.Size(109, 21);
            this.txt_volume.TabIndex = 7;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Location = new System.Drawing.Point(12, 287);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(51, 13);
            this.lbl_tempo.TabIndex = 8;
            this.lbl_tempo.Text = "Tempo/hr";
            // 
            // txt_tempo
            // 
            this.txt_tempo.Enabled = false;
            this.txt_tempo.Location = new System.Drawing.Point(12, 302);
            this.txt_tempo.MaxLength = 3;
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(109, 21);
            this.txt_tempo.TabIndex = 9;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(14, 353);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(85, 15);
            this.lbl_resultado.TabIndex = 13;
            this.lbl_resultado.Text = "RESULTADO:";
            // 
            // btt_calc
            // 
            this.btt_calc.Location = new System.Drawing.Point(14, 415);
            this.btt_calc.Name = "btt_calc";
            this.btt_calc.Size = new System.Drawing.Size(75, 23);
            this.btt_calc.TabIndex = 14;
            this.btt_calc.Text = "Calcular";
            this.btt_calc.UseVisualStyleBackColor = true;
            this.btt_calc.Click += new System.EventHandler(this.btt_calc_Click);
            // 
            // btt_limpar
            // 
            this.btt_limpar.Location = new System.Drawing.Point(96, 415);
            this.btt_limpar.Name = "btt_limpar";
            this.btt_limpar.Size = new System.Drawing.Size(75, 23);
            this.btt_limpar.TabIndex = 15;
            this.btt_limpar.Text = "Limpar";
            this.btt_limpar.UseVisualStyleBackColor = true;
            this.btt_limpar.Click += new System.EventHandler(this.btt_limpar_Click);
            // 
            // lbl_exibirResultado
            // 
            this.lbl_exibirResultado.AutoSize = true;
            this.lbl_exibirResultado.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exibirResultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_exibirResultado.Location = new System.Drawing.Point(104, 345);
            this.lbl_exibirResultado.Name = "lbl_exibirResultado";
            this.lbl_exibirResultado.Size = new System.Drawing.Size(67, 27);
            this.lbl_exibirResultado.TabIndex = 16;
            this.lbl_exibirResultado.Text = "00000";
            // 
            // rb_macrogotas
            // 
            this.rb_macrogotas.AutoSize = true;
            this.rb_macrogotas.Location = new System.Drawing.Point(15, 23);
            this.rb_macrogotas.Name = "rb_macrogotas";
            this.rb_macrogotas.Size = new System.Drawing.Size(82, 17);
            this.rb_macrogotas.TabIndex = 17;
            this.rb_macrogotas.TabStop = true;
            this.rb_macrogotas.Text = "Macro Gotas";
            this.rb_macrogotas.UseVisualStyleBackColor = true;
            this.rb_macrogotas.CheckedChanged += new System.EventHandler(this.rb_macrogotas_CheckedChanged);
            // 
            // rb_microgotas
            // 
            this.rb_microgotas.AutoSize = true;
            this.rb_microgotas.Location = new System.Drawing.Point(15, 47);
            this.rb_microgotas.Name = "rb_microgotas";
            this.rb_microgotas.Size = new System.Drawing.Size(79, 17);
            this.rb_microgotas.TabIndex = 18;
            this.rb_microgotas.TabStop = true;
            this.rb_microgotas.Text = "Micro Gotas";
            this.rb_microgotas.UseVisualStyleBackColor = true;
            this.rb_microgotas.CheckedChanged += new System.EventHandler(this.rb_microgotas_CheckedChanged);
            // 
            // rb_diluicao
            // 
            this.rb_diluicao.AutoSize = true;
            this.rb_diluicao.Location = new System.Drawing.Point(351, 47);
            this.rb_diluicao.Name = "rb_diluicao";
            this.rb_diluicao.Size = new System.Drawing.Size(60, 17);
            this.rb_diluicao.TabIndex = 19;
            this.rb_diluicao.TabStop = true;
            this.rb_diluicao.Text = "Diluição";
            this.rb_diluicao.UseVisualStyleBackColor = true;
            this.rb_diluicao.CheckedChanged += new System.EventHandler(this.rb_diluicao_CheckedChanged);
            // 
            // lbl_pm
            // 
            this.lbl_pm.AutoSize = true;
            this.lbl_pm.Location = new System.Drawing.Point(348, 93);
            this.lbl_pm.Name = "lbl_pm";
            this.lbl_pm.Size = new System.Drawing.Size(53, 13);
            this.lbl_pm.TabIndex = 20;
            this.lbl_pm.Text = "Prescrição";
            // 
            // txt_pm
            // 
            this.txt_pm.Enabled = false;
            this.txt_pm.Location = new System.Drawing.Point(351, 109);
            this.txt_pm.Name = "txt_pm";
            this.txt_pm.Size = new System.Drawing.Size(100, 21);
            this.txt_pm.TabIndex = 21;
            // 
            // lbl_disp
            // 
            this.lbl_disp.AutoSize = true;
            this.lbl_disp.Location = new System.Drawing.Point(348, 150);
            this.lbl_disp.Name = "lbl_disp";
            this.lbl_disp.Size = new System.Drawing.Size(52, 13);
            this.lbl_disp.TabIndex = 22;
            this.lbl_disp.Text = "Disponível";
            // 
            // txt_disp
            // 
            this.txt_disp.Enabled = false;
            this.txt_disp.Location = new System.Drawing.Point(351, 166);
            this.txt_disp.Name = "txt_disp";
            this.txt_disp.Size = new System.Drawing.Size(100, 21);
            this.txt_disp.TabIndex = 23;
            // 
            // txt_dilui
            // 
            this.txt_dilui.Enabled = false;
            this.txt_dilui.Location = new System.Drawing.Point(351, 232);
            this.txt_dilui.Name = "txt_dilui";
            this.txt_dilui.Size = new System.Drawing.Size(100, 21);
            this.txt_dilui.TabIndex = 24;
            // 
            // lbl_dilui
            // 
            this.lbl_dilui.AutoSize = true;
            this.lbl_dilui.Location = new System.Drawing.Point(348, 207);
            this.lbl_dilui.Name = "lbl_dilui";
            this.lbl_dilui.Size = new System.Drawing.Size(41, 13);
            this.lbl_dilui.TabIndex = 25;
            this.lbl_dilui.Text = "Volume";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frm_princ_calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_dilui);
            this.Controls.Add(this.txt_dilui);
            this.Controls.Add(this.txt_disp);
            this.Controls.Add(this.lbl_disp);
            this.Controls.Add(this.txt_pm);
            this.Controls.Add(this.lbl_pm);
            this.Controls.Add(this.rb_diluicao);
            this.Controls.Add(this.rb_microgotas);
            this.Controls.Add(this.rb_macrogotas);
            this.Controls.Add(this.lbl_exibirResultado);
            this.Controls.Add(this.btt_limpar);
            this.Controls.Add(this.btt_calc);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.txt_volume);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.txt_dosagem);
            this.Controls.Add(this.lbl_dose);
            this.Controls.Add(this.txt_apresentacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_farmaco);
            this.Controls.Add(this.lbl_farmaco);
            this.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_princ_calc";
            this.ShowIcon = false;
            this.Text = "Calculadora Medicamentosa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_farmaco;
        private System.Windows.Forms.TextBox txt_farmaco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apresentacao;
        private System.Windows.Forms.Label lbl_dose;
        private System.Windows.Forms.TextBox txt_dosagem;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.TextBox txt_volume;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btt_calc;
        private System.Windows.Forms.Button btt_limpar;
        private System.Windows.Forms.Label lbl_exibirResultado;
        private System.Windows.Forms.RadioButton rb_macrogotas;
        private System.Windows.Forms.RadioButton rb_microgotas;
        private System.Windows.Forms.RadioButton rb_diluicao;
        private System.Windows.Forms.Label lbl_pm;
        private System.Windows.Forms.TextBox txt_pm;
        private System.Windows.Forms.Label lbl_disp;
        private System.Windows.Forms.TextBox txt_disp;
        private System.Windows.Forms.TextBox txt_dilui;
        private System.Windows.Forms.Label lbl_dilui;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

