namespace Calculo_de_Piso
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbox_Quadrado = new System.Windows.Forms.CheckBox();
            this.cbox_Redondo = new System.Windows.Forms.CheckBox();
            this.cbox_Triangulo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(234, 277);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(184, 82);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular área";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Visible = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbox_Quadrado
            // 
            this.cbox_Quadrado.AutoSize = true;
            this.cbox_Quadrado.Location = new System.Drawing.Point(177, 96);
            this.cbox_Quadrado.Name = "cbox_Quadrado";
            this.cbox_Quadrado.Size = new System.Drawing.Size(73, 17);
            this.cbox_Quadrado.TabIndex = 3;
            this.cbox_Quadrado.Text = "Quadrado";
            this.cbox_Quadrado.UseVisualStyleBackColor = true;
            this.cbox_Quadrado.CheckedChanged += new System.EventHandler(this.cbox_Quadrado_CheckedChanged);
            // 
            // cbox_Redondo
            // 
            this.cbox_Redondo.AutoSize = true;
            this.cbox_Redondo.Location = new System.Drawing.Point(335, 96);
            this.cbox_Redondo.Name = "cbox_Redondo";
            this.cbox_Redondo.Size = new System.Drawing.Size(70, 17);
            this.cbox_Redondo.TabIndex = 4;
            this.cbox_Redondo.Text = "Redondo";
            this.cbox_Redondo.UseVisualStyleBackColor = true;
            this.cbox_Redondo.CheckedChanged += new System.EventHandler(this.cbox_Redondo_CheckedChanged);
            // 
            // cbox_Triangulo
            // 
            this.cbox_Triangulo.AutoSize = true;
            this.cbox_Triangulo.Location = new System.Drawing.Point(251, 47);
            this.cbox_Triangulo.Name = "cbox_Triangulo";
            this.cbox_Triangulo.Size = new System.Drawing.Size(70, 17);
            this.cbox_Triangulo.TabIndex = 5;
            this.cbox_Triangulo.Text = "Triângulo";
            this.cbox_Triangulo.UseVisualStyleBackColor = true;
            this.cbox_Triangulo.CheckedChanged += new System.EventHandler(this.cbox_Triangulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o formato da sua casa:";
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Location = new System.Drawing.Point(144, 178);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(0, 13);
            this.lbl_01.TabIndex = 7;
            this.lbl_01.Visible = false;
            // 
            // lbl_02
            // 
            this.lbl_02.AutoSize = true;
            this.lbl_02.Location = new System.Drawing.Point(144, 218);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(0, 13);
            this.lbl_02.TabIndex = 8;
            this.lbl_02.Visible = false;
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Selecionar.Location = new System.Drawing.Point(466, 57);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(131, 40);
            this.btn_Selecionar.TabIndex = 9;
            this.btn_Selecionar.Text = "Selecionar";
            this.btn_Selecionar.UseVisualStyleBackColor = true;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 413);
            this.Controls.Add(this.btn_Selecionar);
            this.Controls.Add(this.lbl_02);
            this.Controls.Add(this.lbl_01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_Triangulo);
            this.Controls.Add(this.cbox_Redondo);
            this.Controls.Add(this.cbox_Quadrado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox cbox_Quadrado;
        private System.Windows.Forms.CheckBox cbox_Redondo;
        private System.Windows.Forms.CheckBox cbox_Triangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.Button btn_Selecionar;
    }
}

