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
            textBoxCounterEENight = new TextBox();
            label2 = new Label();
            buttonCalculateHBC = new Button();
            label1 = new Label();
            dataGridViewShowResults = new DataGridView();
            buttonReset = new Button();
            buttonSave = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowResults).BeginInit();
            SuspendLayout();
            // 
            // labelCountersHBC
            // 
            labelCountersHBC.AutoSize = true;
            labelCountersHBC.Font = new Font("Times New Roman", 15.75F);
            labelCountersHBC.Location = new Point(48, 226);
            labelCountersHBC.Name = "labelCountersHBC";
            labelCountersHBC.Size = new Size(178, 23);
            labelCountersHBC.TabIndex = 0;
            labelCountersHBC.Text = "Показания по ХВС";
            // 
            // textBoxCounterHBC
            // 
            textBoxCounterHBC.Font = new Font("Times New Roman", 15.75F);
            textBoxCounterHBC.Location = new Point(261, 217);
            textBoxCounterHBC.Name = "textBoxCounterHBC";
            textBoxCounterHBC.PlaceholderText = "0.0";
            textBoxCounterHBC.Size = new Size(195, 32);
            textBoxCounterHBC.TabIndex = 1;
            textBoxCounterHBC.KeyPress += textBoxCounterHBC_KeyPress;
            // 
            // textBoxCounterGBC
            // 
            textBoxCounterGBC.Font = new Font("Times New Roman", 15.75F);
            textBoxCounterGBC.Location = new Point(259, 311);
            textBoxCounterGBC.Name = "textBoxCounterGBC";
            textBoxCounterGBC.PlaceholderText = "0.0";
            textBoxCounterGBC.Size = new Size(197, 32);
            textBoxCounterGBC.TabIndex = 3;
            textBoxCounterGBC.KeyPress += textBoxCounterGBC_KeyPress;
            // 
            // labelCountersGBC
            // 
            labelCountersGBC.AutoSize = true;
            labelCountersGBC.Font = new Font("Times New Roman", 15.75F);
            labelCountersGBC.Location = new Point(48, 320);
            labelCountersGBC.Name = "labelCountersGBC";
            labelCountersGBC.Size = new Size(176, 23);
            labelCountersGBC.TabIndex = 2;
            labelCountersGBC.Text = "Показания по ГВС";
            // 
            // textBoxCounterEE
            // 
            textBoxCounterEE.Font = new Font("Times New Roman", 15.75F);
            textBoxCounterEE.Location = new Point(765, 217);
            textBoxCounterEE.Name = "textBoxCounterEE";
            textBoxCounterEE.PlaceholderText = "0.0";
            textBoxCounterEE.Size = new Size(197, 32);
            textBoxCounterEE.TabIndex = 5;
            textBoxCounterEE.TextChanged += textBoxCounterEE_TextChanged;
            textBoxCounterEE.KeyPress += textBoxCounterEE_KeyPress;
            // 
            // labelCountersEE
            // 
            labelCountersEE.AutoSize = true;
            labelCountersEE.Font = new Font("Times New Roman", 15.75F);
            labelCountersEE.Location = new Point(554, 226);
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
            textBoxCountPerson.PlaceholderText = "1";
            textBoxCountPerson.Size = new Size(236, 32);
            textBoxCountPerson.TabIndex = 7;
            textBoxCountPerson.KeyPress += textBoxCountPerson_KeyPress;
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
            // textBoxCounterEENight
            // 
            textBoxCounterEENight.Font = new Font("Times New Roman", 15.75F);
            textBoxCounterEENight.Location = new Point(765, 307);
            textBoxCounterEENight.Name = "textBoxCounterEENight";
            textBoxCounterEENight.PlaceholderText = "0.0";
            textBoxCounterEENight.Size = new Size(197, 32);
            textBoxCounterEENight.TabIndex = 12;
            textBoxCounterEENight.TextChanged += textBoxCounterEENight_TextChanged;
            textBoxCounterEENight.KeyPress += textBoxCounterEENight_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.Location = new Point(553, 316);
            label2.Name = "label2";
            label2.Size = new Size(211, 23);
            label2.TabIndex = 11;
            label2.Text = "Показания по ЭЭ ночь";
            // 
            // buttonCalculateHBC
            // 
            buttonCalculateHBC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculateHBC.Location = new Point(484, 395);
            buttonCalculateHBC.Name = "buttonCalculateHBC";
            buttonCalculateHBC.Size = new Size(195, 41);
            buttonCalculateHBC.TabIndex = 13;
            buttonCalculateHBC.Text = "Расчитать";
            buttonCalculateHBC.UseVisualStyleBackColor = true;
            buttonCalculateHBC.Click += buttonCalculateHBC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(102, 116);
            label1.Name = "label1";
            label1.Size = new Size(451, 64);
            label1.TabIndex = 14;
            label1.Text = "Поля услуг для которых не передаются\r\nпоказания - оставить пустыми";
            // 
            // dataGridViewShowResults
            // 
            dataGridViewShowResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewShowResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShowResults.Location = new Point(12, 12);
            dataGridViewShowResults.Name = "dataGridViewShowResults";
            dataGridViewShowResults.Size = new Size(1032, 377);
            dataGridViewShowResults.TabIndex = 15;
            dataGridViewShowResults.Visible = false;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(134, 395);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(195, 41);
            buttonReset.TabIndex = 16;
            buttonReset.Text = "Сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(803, 395);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(195, 41);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(765, 252);
            label3.Name = "label3";
            label3.Size = new Size(241, 30);
            label3.TabIndex = 14;
            label3.Text = "Для показаний по общему тарифу\r\nДля дневных если заполнен ночной тариф";
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 448);
            Controls.Add(buttonSave);
            Controls.Add(buttonReset);
            Controls.Add(dataGridViewShowResults);
            Controls.Add(label1);
            Controls.Add(buttonCalculateHBC);
            Controls.Add(textBoxCounterEENight);
            Controls.Add(label2);
            Controls.Add(textBoxCountPerson);
            Controls.Add(labelCountPerson);
            Controls.Add(textBoxCounterEE);
            Controls.Add(labelCountersEE);
            Controls.Add(textBoxCounterGBC);
            Controls.Add(labelCountersGBC);
            Controls.Add(textBoxCounterHBC);
            Controls.Add(labelCountersHBC);
            Controls.Add(label3);
            Name = "FormCalculator";
            Text = "Расчет коммунальных услуг";
            Load += FormCalculator_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowResults).EndInit();
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
        private TextBox textBoxCounterEENight;
        private Label label2;
        private Button buttonCalculateHBC;
        private Label label1;
        private DataGridView dataGridViewShowResults;
        private Button buttonReset;
        private Button buttonSave;
        private Label label3;
    }
}
