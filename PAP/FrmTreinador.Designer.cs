﻿namespace PAP
{
    partial class FrmTreinador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreinador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.lblhora = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.viewInscricoesTableAdapter1 = new PAP.PAPDataSetTableAdapters.viewInscricoesTableAdapter();
            this.avaliacoesFisicas1 = new PAP.AvaliacoesFisicas();
            this.mapadeAulas1 = new PAP.MapadeAulas();
            this.planosdeTreino1 = new PAP.PlanosdeTreino();
            this.home1 = new PAP.Home();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.lblhora);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 865);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(9, 464);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(273, 69);
            this.button5.TabIndex = 29;
            this.button5.Text = "Estatística";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // lblhora
            // 
            this.lblhora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(0, 91);
            this.lblhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(284, 23);
            this.lblhora.TabIndex = 28;
            this.lblhora.Text = "Tempo";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldata
            // 
            this.lbldata.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldata.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.Color.White;
            this.lbldata.Location = new System.Drawing.Point(0, 68);
            this.lbldata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldata.Name = "lbldata";
            this.lbldata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbldata.Size = new System.Drawing.Size(284, 23);
            this.lbldata.TabIndex = 27;
            this.lbldata.Text = "Tempo";
            this.lbldata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 186);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(9, 69);
            this.sidepanel.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = global::PAP.Properties.Resources.icons8_exit_32;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(0, 808);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(284, 57);
            this.button6.TabIndex = 25;
            this.button6.Text = "Terminar Sessão";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 68);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bem Vindo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(9, 393);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 69);
            this.button3.TabIndex = 21;
            this.button3.Text = "Aulas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(9, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 69);
            this.button2.TabIndex = 20;
            this.button2.Text = "Avaliações Físicas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 69);
            this.button1.TabIndex = 19;
            this.button1.Text = "Planos de Treino";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 186);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 69);
            this.button4.TabIndex = 18;
            this.button4.Text = "Início";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // viewInscricoesTableAdapter1
            // 
            this.viewInscricoesTableAdapter1.ClearBeforeFill = true;
            // 
            // avaliacoesFisicas1
            // 
            this.avaliacoesFisicas1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.avaliacoesFisicas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avaliacoesFisicas1.Location = new System.Drawing.Point(0, 0);
            this.avaliacoesFisicas1.Margin = new System.Windows.Forms.Padding(5);
            this.avaliacoesFisicas1.Name = "avaliacoesFisicas1";
            this.avaliacoesFisicas1.Size = new System.Drawing.Size(1795, 865);
            this.avaliacoesFisicas1.TabIndex = 5;
            this.avaliacoesFisicas1.Load += new System.EventHandler(this.avaliacoesFisicas1_Load);
            // 
            // mapadeAulas1
            // 
            this.mapadeAulas1.BackColor = System.Drawing.SystemColors.Window;
            this.mapadeAulas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapadeAulas1.Location = new System.Drawing.Point(0, 0);
            this.mapadeAulas1.Margin = new System.Windows.Forms.Padding(5);
            this.mapadeAulas1.Name = "mapadeAulas1";
            this.mapadeAulas1.Size = new System.Drawing.Size(1795, 865);
            this.mapadeAulas1.TabIndex = 4;
            // 
            // planosdeTreino1
            // 
            this.planosdeTreino1.BackColor = System.Drawing.Color.White;
            this.planosdeTreino1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planosdeTreino1.Location = new System.Drawing.Point(0, 0);
            this.planosdeTreino1.Name = "planosdeTreino1";
            this.planosdeTreino1.Size = new System.Drawing.Size(1795, 865);
            this.planosdeTreino1.TabIndex = 6;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(284, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1511, 865);
            this.home1.TabIndex = 7;
            // 
            // FrmTreinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1795, 865);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.avaliacoesFisicas1);
            this.Controls.Add(this.mapadeAulas1);
            this.Controls.Add(this.planosdeTreino1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTreinador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTreinador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.Button button1;
        private MapadeAulas mapadeAulas1;
        private AvaliacoesFisicas avaliacoesFisicas1;
        private PAPDataSetTableAdapters.viewInscricoesTableAdapter viewInscricoesTableAdapter1;
        private PlanosdeTreino planosdeTreino1;
        private Home home1;
    }
}