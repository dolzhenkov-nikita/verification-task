namespace VerificationTask
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCountersHBC = new Label();
            textBoxCounterHBC = new TextBox();
            textBoxCounterGBC = new TextBox();
            labelCountersGBC = new Label();
            textBoxCounterEE = new TextBox();
            labelCountersEE = new Label();
            textBoxCountPerson = new TextBox();
            labelCountPerson = new Label();
            labelHBC = new Label();
            labelGBC = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            buttonCalculateHBC = new Button();
            buttonCalculateGBC = new Button();
            buttonCalculateEE = new Button();
            SuspendLayout();
            // 
            // labelCountersHBC
            // 
            labelCountersHBC.AutoSize = true;
            labelCountersHBC.Font = new Font("Times New Roman", 15.75F);
            labelCountersHBC.Location = new Point(37, 246);
            labelCountersHBC.Name = "labelCountersHBC";
            labelCountersHBC.Size = new Size(178, 23);
            labelCountersHBC.TabIndex = 0;
            labelCountersHBC.Text = "Показания по ХВС";
            // 
            // textBoxCounterHBC
            // 
            textBoxCounterHBC.Font = new Font("Times New Roman", 15.75F);
            textBoxCounterHBC.Location = new Point(221, 237);
            textBoxCounterHBC.Name = "textBoxCounterHBC";
            textBoxCounterHBC.PlaceholderText = "0.0";
            textBoxCounterHBC.Size = new Size(195, 32);
            textBoxCounterHBC.TabIndex = 1;
            textBoxCounterHBC.KeyPress += textBoxCounterHBC_KeyPress;
            // 
            // textBoxCounterGBC
            // 
            textBoxCounterGBC.Font = new Font("Times New Roman", 15.75F);
            textBoxCounterGBC.Location = new Point(692, 237);
            textBoxCounterGBC.Name = "textBoxCounterGBC";
            textBoxCounterGBC.PlaceholderText = "0.0";
            textBoxCounterGBC.Size = new Size(181, 32);
            textBoxCounterGBC.TabIndex = 3;
            // 
            // labelCountersGBC
            // 
            labelCountersGBC.AutoSize = true;
            labelCountersGBC.Font = new Font("Times New Roman", 15.75F);
            labelCountersGBC.Location = new Point(510, 246);
            labelCountersGBC.Name = "labelCountersGBC";
            labelCountersGBC.Size = new Size(176, 23);
            labelCountersGBC.TabIndex = 2;
            labelCountersGBC.Text = "Показания по ГВС";
            // 
            // textBoxCounterEE
            // 
            textBoxCounterEE.Font = new Font("Times New Roman", 15.75F);
            textBoxCounterEE.Location = new Point(1214, 237);
            textBoxCounterEE.Name = "textBoxCounterEE";
            textBoxCounterEE.Size = new Size(129, 32);
            textBoxCounterEE.TabIndex = 5;
            // 
            // labelCountersEE
            // 
            labelCountersEE.AutoSize = true;
            labelCountersEE.Font = new Font("Times New Roman", 15.75F);
            labelCountersEE.Location = new Point(1044, 246);
            labelCountersEE.Name = "labelCountersEE";
            labelCountersEE.Size = new Size(164, 23);
            labelCountersEE.TabIndex = 4;
            labelCountersEE.Text = "Показания по ЭЭ";
            // 
            // textBoxCountPerson
            // 
            textBoxCountPerson.Font = new Font("Times New Roman", 15.75F);
            textBoxCountPerson.Location = new Point(291, 54);
            textBoxCountPerson.Name = "textBoxCountPerson";
            textBoxCountPerson.PlaceholderText = "0";
            textBoxCountPerson.Size = new Size(236, 32);
            textBoxCountPerson.TabIndex = 7;
            // 
            // labelCountPerson
            // 
            labelCountPerson.AutoSize = true;
            labelCountPerson.Font = new Font("Times New Roman", 15.75F);
            labelCountPerson.Location = new Point(37, 40);
            labelCountPerson.Name = "labelCountPerson";
            labelCountPerson.Size = new Size(248, 46);
            labelCountPerson.TabIndex = 6;
            labelCountPerson.Text = "Количество проживающих\r\nв помещении";
            // 
            // labelHBC
            // 
            labelHBC.AutoSize = true;
            labelHBC.Font = new Font("Times New Roman", 15.75F);
            labelHBC.Location = new Point(37, 164);
            labelHBC.Name = "labelHBC";
            labelHBC.Size = new Size(379, 23);
            labelHBC.TabIndex = 8;
            labelHBC.Text = "Расчет услуги \"Холодное водоснабжение\"";
            // 
            // labelGBC
            // 
            labelGBC.AutoSize = true;
            labelGBC.Font = new Font("Times New Roman", 15.75F);
            labelGBC.Location = new Point(510, 164);
            labelGBC.Name = "labelGBC";
            labelGBC.Size = new Size(363, 23);
            labelGBC.TabIndex = 9;
            labelGBC.Text = "Расчет услуги \"Горячее водоснабжение\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.Location = new Point(1043, 164);
            label1.Name = "label1";
            label1.Size = new Size(299, 23);
            label1.TabIndex = 10;
            label1.Text = "Расчет услуги \"Электроэнергия \"";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 15.75F);
            textBox1.Location = new Point(1213, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 32);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.Location = new Point(1043, 296);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 11;
            label2.Text = "Показания по ЭЭ";
            // 
            // buttonCalculateHBC
            // 
            buttonCalculateHBC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculateHBC.Location = new Point(221, 370);
            buttonCalculateHBC.Name = "buttonCalculateHBC";
            buttonCalculateHBC.Size = new Size(195, 41);
            buttonCalculateHBC.TabIndex = 13;
            buttonCalculateHBC.Text = "Расчитать ХВС";
            buttonCalculateHBC.UseVisualStyleBackColor = true;
            buttonCalculateHBC.Click += buttonCalculateHBC_Click;
            // 
            // buttonCalculateGBC
            // 
            buttonCalculateGBC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculateGBC.Location = new Point(678, 370);
            buttonCalculateGBC.Name = "buttonCalculateGBC";
            buttonCalculateGBC.Size = new Size(195, 41);
            buttonCalculateGBC.TabIndex = 14;
            buttonCalculateGBC.Text = "Расчитать ХВС";
            buttonCalculateGBC.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateEE
            // 
            buttonCalculateEE.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculateEE.Location = new Point(1148, 370);
            buttonCalculateEE.Name = "buttonCalculateEE";
            buttonCalculateEE.Size = new Size(195, 41);
            buttonCalculateEE.TabIndex = 15;
            buttonCalculateEE.Text = "Расчитать ЭЭ";
            buttonCalculateEE.UseVisualStyleBackColor = true;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 490);
            Controls.Add(buttonCalculateEE);
            Controls.Add(buttonCalculateGBC);
            Controls.Add(buttonCalculateHBC);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelGBC);
            Controls.Add(labelHBC);
            Controls.Add(textBoxCountPerson);
            Controls.Add(labelCountPerson);
            Controls.Add(textBoxCounterEE);
            Controls.Add(labelCountersEE);
            Controls.Add(textBoxCounterGBC);
            Controls.Add(labelCountersGBC);
            Controls.Add(textBoxCounterHBC);
            Controls.Add(labelCountersHBC);
            Name = "FormCalculator";
            Text = "Расчет коммунальных услуг";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCountersHBC;
        private TextBox textBoxCounterHBC;
        private TextBox textBoxCounterGBC;
        private Label labelCountersGBC;
        private TextBox textBoxCounterEE;
        private Label labelCountersEE;
        private TextBox textBoxCountPerson;
        private Label labelCountPerson;
        private Label labelHBC;
        private Label labelGBC;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button buttonCalculateHBC;
        private Button buttonCalculateGBC;
        private Button buttonCalculateEE;
    }
}
