namespace Login
{
    partial class cadastrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_categ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quem = new System.Windows.Forms.TextBox();
            this.button_cad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_alterar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button_limpar = new System.Windows.Forms.Button();
            this.picture_image = new System.Windows.Forms.PictureBox();
            this.button_inserir_img = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(118, 142);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(243, 26);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço unidade:";
            // 
            // txt_preco
            // 
            this.txt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.Location = new System.Drawing.Point(183, 195);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(178, 26);
            this.txt_preco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data da compra:";
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(183, 248);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(95, 26);
            this.txt_data.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria:";
            // 
            // txt_categ
            // 
            this.txt_categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categ.Location = new System.Drawing.Point(553, 142);
            this.txt_categ.Name = "txt_categ";
            this.txt_categ.Size = new System.Drawing.Size(199, 26);
            this.txt_categ.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantidade:";
            // 
            // txt_quant
            // 
            this.txt_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quant.Location = new System.Drawing.Point(553, 195);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(199, 26);
            this.txt_quant.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quem comprou:";
            // 
            // txt_quem
            // 
            this.txt_quem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quem.Location = new System.Drawing.Point(553, 248);
            this.txt_quem.Name = "txt_quem";
            this.txt_quem.Size = new System.Drawing.Size(199, 26);
            this.txt_quem.TabIndex = 12;
            // 
            // button_cad
            // 
            this.button_cad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cad.Location = new System.Drawing.Point(300, 312);
            this.button_cad.Name = "button_cad";
            this.button_cad.Size = new System.Drawing.Size(114, 35);
            this.button_cad.TabIndex = 13;
            this.button_cad.Text = "Cadastrar";
            this.button_cad.UseVisualStyleBackColor = true;
            this.button_cad.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_alterar
            // 
            this.button_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alterar.Location = new System.Drawing.Point(420, 312);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(116, 35);
            this.button_alterar.TabIndex = 15;
            this.button_alterar.Text = "Alterar";
            this.button_alterar.UseVisualStyleBackColor = true;
            this.button_alterar.Click += new System.EventHandler(this.button_alterar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.Location = new System.Drawing.Point(542, 312);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(114, 35);
            this.button_excluir.TabIndex = 16;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.Location = new System.Drawing.Point(174, 312);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(120, 35);
            this.button_pesquisar.TabIndex = 17;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Id:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(79, 316);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(78, 26);
            this.txtid.TabIndex = 19;
            // 
            // button_limpar
            // 
            this.button_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(662, 312);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(116, 35);
            this.button_limpar.TabIndex = 20;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // picture_image
            // 
            this.picture_image.Location = new System.Drawing.Point(939, 138);
            this.picture_image.Name = "picture_image";
            this.picture_image.Size = new System.Drawing.Size(222, 205);
            this.picture_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_image.TabIndex = 21;
            this.picture_image.TabStop = false;
            // 
            // button_inserir_img
            // 
            this.button_inserir_img.FlatAppearance.BorderSize = 0;
            this.button_inserir_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inserir_img.ImageKey = "Icon-explorador-arquivos.png";
            this.button_inserir_img.ImageList = this.imageList1;
            this.button_inserir_img.Location = new System.Drawing.Point(829, 210);
            this.button_inserir_img.Name = "button_inserir_img";
            this.button_inserir_img.Size = new System.Drawing.Size(93, 60);
            this.button_inserir_img.TabIndex = 22;
            this.button_inserir_img.UseVisualStyleBackColor = true;
            this.button_inserir_img.Click += new System.EventHandler(this.button_inserir_img_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon-explorador-arquivos.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 496);
            this.Controls.Add(this.button_inserir_img);
            this.Controls.Add(this.picture_image);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_alterar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_cad);
            this.Controls.Add(this.txt_quem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_categ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastrar";
            this.Load += new System.EventHandler(this.cadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_categ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quem;
        private System.Windows.Forms.Button button_cad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.PictureBox picture_image;
        private System.Windows.Forms.Button button_inserir_img;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}