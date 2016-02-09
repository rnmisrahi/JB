namespace SolutionToReg_DB
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
            this.btnDisplay1 = new System.Windows.Forms.Button();
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 424);
            this.textBox1.TabIndex = 0;
            // 
            // btnDisplay1
            // 
            this.btnDisplay1.Location = new System.Drawing.Point(319, 28);
            this.btnDisplay1.Name = "btnDisplay1";
            this.btnDisplay1.Size = new System.Drawing.Size(88, 33);
            this.btnDisplay1.TabIndex = 1;
            this.btnDisplay1.Text = "Display 1";
            this.btnDisplay1.UseVisualStyleBackColor = true;
            this.btnDisplay1.Click += new System.EventHandler(this.btnDisplay1_Click);
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.Location = new System.Drawing.Point(319, 76);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(88, 33);
            this.btnDisplay2.TabIndex = 2;
            this.btnDisplay2.Text = "Display 2";
            this.btnDisplay2.UseVisualStyleBackColor = true;
            this.btnDisplay2.Click += new System.EventHandler(this.btnDisplay2_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(445, 28);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 33);
            this.btnMap.TabIndex = 3;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(445, 76);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 33);
            this.btnClone.TabIndex = 4;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(332, 146);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(115, 23);
            this.btnChangeName.TabIndex = 5;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(453, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Lulu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 424);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnDisplay2);
            this.Controls.Add(this.btnDisplay1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDisplay1;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.TextBox textBox2;
    }
}

