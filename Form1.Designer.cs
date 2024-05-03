
namespace Wolf.Goast.Cabbage
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
            this.boat = new System.Windows.Forms.PictureBox();
            this.goat = new System.Windows.Forms.PictureBox();
            this.wolf = new System.Windows.Forms.PictureBox();
            this.cabbbage = new System.Windows.Forms.PictureBox();
            this.move = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabbbage)).BeginInit();
            this.SuspendLayout();
            // 
            // boat
            // 
            this.boat.BackColor = System.Drawing.Color.Transparent;
            this.boat.Image = global::Wolf.Goast.Cabbage.Properties.Resources.boat11;
            this.boat.Location = new System.Drawing.Point(440, 461);
            this.boat.Name = "boat";
            this.boat.Size = new System.Drawing.Size(240, 172);
            this.boat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boat.TabIndex = 3;
            this.boat.TabStop = false;
            this.boat.Click += new System.EventHandler(this.boat_Click);
            // 
            // goat
            // 
            this.goat.BackColor = System.Drawing.Color.Transparent;
            this.goat.Image = global::Wolf.Goast.Cabbage.Properties.Resources.goat;
            this.goat.Location = new System.Drawing.Point(639, 461);
            this.goat.Name = "goat";
            this.goat.Size = new System.Drawing.Size(62, 49);
            this.goat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goat.TabIndex = 4;
            this.goat.TabStop = false;
            this.goat.Click += new System.EventHandler(this.goat_Click);
            // 
            // wolf
            // 
            this.wolf.BackColor = System.Drawing.Color.Transparent;
            this.wolf.Image = global::Wolf.Goast.Cabbage.Properties.Resources.wolf;
            this.wolf.Location = new System.Drawing.Point(760, 467);
            this.wolf.Name = "wolf";
            this.wolf.Size = new System.Drawing.Size(52, 76);
            this.wolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolf.TabIndex = 5;
            this.wolf.TabStop = false;
            this.wolf.Click += new System.EventHandler(this.wolf_click);
            // 
            // cabbbage
            // 
            this.cabbbage.BackColor = System.Drawing.Color.Transparent;
            this.cabbbage.Image = global::Wolf.Goast.Cabbage.Properties.Resources.cabbage;
            this.cabbbage.Location = new System.Drawing.Point(696, 467);
            this.cabbbage.Name = "cabbbage";
            this.cabbbage.Size = new System.Drawing.Size(58, 61);
            this.cabbbage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cabbbage.TabIndex = 6;
            this.cabbbage.TabStop = false;
            this.cabbbage.Click += new System.EventHandler(this.cabbage_Click);
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(683, 82);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(118, 34);
            this.move.TabIndex = 7;
            this.move.Text = "move";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_button);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(683, 44);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(118, 32);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "Reset";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.reset);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "down";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.down_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "move back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.moveback);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "How to solve using BFS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "How to solve using DFS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 623);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 27);
            this.button5.TabIndex = 13;
            this.button5.Text = "score";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wolf.Goast.Cabbage.Properties.Resources.f8a8a2c8_f061_4321_a945_cc400c562bab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 662);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.move);
            this.Controls.Add(this.cabbbage);
            this.Controls.Add(this.wolf);
            this.Controls.Add(this.goat);
            this.Controls.Add(this.boat);
            this.Name = "Form1";
            this.Text = "Wolf_Goat_Cabbage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabbbage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox boat;
        private System.Windows.Forms.PictureBox goat;
        private System.Windows.Forms.PictureBox wolf;
        private System.Windows.Forms.PictureBox cabbbage;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

