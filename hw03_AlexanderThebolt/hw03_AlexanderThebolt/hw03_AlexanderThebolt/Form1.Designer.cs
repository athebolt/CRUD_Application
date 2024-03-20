namespace hw03_AlexanderThebolt
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
            this.lb_m_listCars = new System.Windows.Forms.ListBox();
            this.btn_m_addCar = new System.Windows.Forms.Button();
            this.lbl_m_listOfCars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_m_listCars
            // 
            this.lb_m_listCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_m_listCars.FormattingEnabled = true;
            this.lb_m_listCars.ItemHeight = 25;
            this.lb_m_listCars.Location = new System.Drawing.Point(12, 32);
            this.lb_m_listCars.Name = "lb_m_listCars";
            this.lb_m_listCars.Size = new System.Drawing.Size(298, 179);
            this.lb_m_listCars.TabIndex = 0;
            this.lb_m_listCars.DoubleClick += new System.EventHandler(this.lb_m_listCars_DoubleClick);
            // 
            // btn_m_addCar
            // 
            this.btn_m_addCar.Location = new System.Drawing.Point(97, 224);
            this.btn_m_addCar.Name = "btn_m_addCar";
            this.btn_m_addCar.Size = new System.Drawing.Size(128, 33);
            this.btn_m_addCar.TabIndex = 1;
            this.btn_m_addCar.Text = "Add Car";
            this.btn_m_addCar.UseVisualStyleBackColor = true;
            this.btn_m_addCar.Click += new System.EventHandler(this.btn_m_addCar_Click);
            // 
            // lbl_m_listOfCars
            // 
            this.lbl_m_listOfCars.AutoSize = true;
            this.lbl_m_listOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m_listOfCars.Location = new System.Drawing.Point(101, 4);
            this.lbl_m_listOfCars.Name = "lbl_m_listOfCars";
            this.lbl_m_listOfCars.Size = new System.Drawing.Size(121, 25);
            this.lbl_m_listOfCars.TabIndex = 2;
            this.lbl_m_listOfCars.Text = "List of Cars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 269);
            this.Controls.Add(this.lbl_m_listOfCars);
            this.Controls.Add(this.btn_m_addCar);
            this.Controls.Add(this.lb_m_listCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_m_listCars;
        private System.Windows.Forms.Button btn_m_addCar;
        private System.Windows.Forms.Label lbl_m_listOfCars;
    }
}

