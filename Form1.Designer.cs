namespace Practise
{
    partial class Form
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxPatrol = new GroupBox();
            finalPricePatrol = new GroupBox();
            label2 = new Label();
            patrolToPayLabel = new Label();
            litersLabel = new Label();
            UAHLabel2 = new Label();
            UAHLabel = new Label();
            textBoxPatrolPrice = new TextBox();
            textBoxPatrolCount = new TextBox();
            groupBoxPatrolChoice = new GroupBox();
            priceRadio = new RadioButton();
            countRadio = new RadioButton();
            textBoxTypePrice = new TextBox();
            patrolPriceLabel = new Label();
            comboBoxPatrolType = new ComboBox();
            patrolTypeLabel = new Label();
            groupBoxFood = new GroupBox();
            panelFood = new Panel();
            textBoxFrenchfriesPrice = new TextBox();
            label1 = new Label();
            textBoxColaCount = new TextBox();
            label3 = new Label();
            textBoxFrenchfriesCount = new TextBox();
            textBoxHotdogPrice = new TextBox();
            textBoxBurgerCount = new TextBox();
            textBoxBurgerPrice = new TextBox();
            textBoxHotDogCount = new TextBox();
            textBoxColaPrice = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            foodToPayLabel = new Label();
            foodChoicePanel = new Panel();
            checkBoxHotDog = new CheckBox();
            checkBoxCola = new CheckBox();
            checkBoxBurger = new CheckBox();
            checkBoxFrenchfries = new CheckBox();
            groupBox2 = new GroupBox();
            buttonTotalPay = new Button();
            label7 = new Label();
            totalPayLabel = new Label();
            groupBoxPatrol.SuspendLayout();
            finalPricePatrol.SuspendLayout();
            groupBoxPatrolChoice.SuspendLayout();
            groupBoxFood.SuspendLayout();
            panelFood.SuspendLayout();
            groupBox1.SuspendLayout();
            foodChoicePanel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPatrol
            // 
            groupBoxPatrol.BackColor = Color.White;
            groupBoxPatrol.Controls.Add(finalPricePatrol);
            groupBoxPatrol.Controls.Add(litersLabel);
            groupBoxPatrol.Controls.Add(UAHLabel2);
            groupBoxPatrol.Controls.Add(UAHLabel);
            groupBoxPatrol.Controls.Add(textBoxPatrolPrice);
            groupBoxPatrol.Controls.Add(textBoxPatrolCount);
            groupBoxPatrol.Controls.Add(groupBoxPatrolChoice);
            groupBoxPatrol.Controls.Add(textBoxTypePrice);
            groupBoxPatrol.Controls.Add(patrolPriceLabel);
            groupBoxPatrol.Controls.Add(comboBoxPatrolType);
            groupBoxPatrol.Controls.Add(patrolTypeLabel);
            groupBoxPatrol.Location = new Point(12, 12);
            groupBoxPatrol.Name = "groupBoxPatrol";
            groupBoxPatrol.Size = new Size(309, 362);
            groupBoxPatrol.TabIndex = 0;
            groupBoxPatrol.TabStop = false;
            groupBoxPatrol.Text = "Patrol";
            // 
            // finalPricePatrol
            // 
            finalPricePatrol.Controls.Add(label2);
            finalPricePatrol.Controls.Add(patrolToPayLabel);
            finalPricePatrol.Location = new Point(21, 256);
            finalPricePatrol.Name = "finalPricePatrol";
            finalPricePatrol.Size = new Size(235, 100);
            finalPricePatrol.TabIndex = 12;
            finalPricePatrol.TabStop = false;
            finalPricePatrol.Text = "To pay";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(199, 62);
            label2.Name = "label2";
            label2.Size = new Size(30, 14);
            label2.TabIndex = 1;
            label2.Text = "UAH";
            // 
            // patrolToPayLabel
            // 
            patrolToPayLabel.Anchor = AnchorStyles.None;
            patrolToPayLabel.AutoSize = true;
            patrolToPayLabel.Font = new Font("Yu Gothic UI Semibold", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            patrolToPayLabel.Location = new Point(6, 29);
            patrolToPayLabel.Name = "patrolToPayLabel";
            patrolToPayLabel.Size = new Size(103, 55);
            patrolToPayLabel.TabIndex = 0;
            patrolToPayLabel.Text = "0.00";
            patrolToPayLabel.TextChanged += TotalPriceChange;
            // 
            // litersLabel
            // 
            litersLabel.AutoSize = true;
            litersLabel.Location = new Point(262, 157);
            litersLabel.Name = "litersLabel";
            litersLabel.Size = new Size(13, 15);
            litersLabel.TabIndex = 11;
            litersLabel.Text = "l.";
            // 
            // UAHLabel2
            // 
            UAHLabel2.AutoSize = true;
            UAHLabel2.Location = new Point(262, 202);
            UAHLabel2.Name = "UAHLabel2";
            UAHLabel2.Size = new Size(32, 15);
            UAHLabel2.TabIndex = 10;
            UAHLabel2.Text = "UAH";
            // 
            // UAHLabel
            // 
            UAHLabel.AutoSize = true;
            UAHLabel.Location = new Point(262, 102);
            UAHLabel.Name = "UAHLabel";
            UAHLabel.Size = new Size(32, 15);
            UAHLabel.TabIndex = 9;
            UAHLabel.Text = "UAH";
            // 
            // textBoxPatrolPrice
            // 
            textBoxPatrolPrice.Location = new Point(135, 194);
            textBoxPatrolPrice.Name = "textBoxPatrolPrice";
            textBoxPatrolPrice.ReadOnly = true;
            textBoxPatrolPrice.Size = new Size(121, 23);
            textBoxPatrolPrice.TabIndex = 8;
            textBoxPatrolPrice.TextChanged += textBoxPatrolPrice_TextChanged;
            // 
            // textBoxPatrolCount
            // 
            textBoxPatrolCount.Location = new Point(135, 149);
            textBoxPatrolCount.Name = "textBoxPatrolCount";
            textBoxPatrolCount.Size = new Size(121, 23);
            textBoxPatrolCount.TabIndex = 7;
            textBoxPatrolCount.TextChanged += textBoxPatrolCount_TextChanged;
            // 
            // groupBoxPatrolChoice
            // 
            groupBoxPatrolChoice.Controls.Add(priceRadio);
            groupBoxPatrolChoice.Controls.Add(countRadio);
            groupBoxPatrolChoice.Location = new Point(21, 131);
            groupBoxPatrolChoice.Name = "groupBoxPatrolChoice";
            groupBoxPatrolChoice.Size = new Size(108, 100);
            groupBoxPatrolChoice.TabIndex = 6;
            groupBoxPatrolChoice.TabStop = false;
            // 
            // priceRadio
            // 
            priceRadio.AutoSize = true;
            priceRadio.Location = new Point(21, 64);
            priceRadio.Name = "priceRadio";
            priceRadio.Size = new Size(51, 19);
            priceRadio.TabIndex = 6;
            priceRadio.Text = "Price";
            priceRadio.UseVisualStyleBackColor = true;
            priceRadio.CheckedChanged += priceRadio_CheckedChanged;
            // 
            // countRadio
            // 
            countRadio.AutoSize = true;
            countRadio.Checked = true;
            countRadio.Location = new Point(21, 22);
            countRadio.Name = "countRadio";
            countRadio.Size = new Size(58, 19);
            countRadio.TabIndex = 5;
            countRadio.TabStop = true;
            countRadio.Text = "Count";
            countRadio.UseVisualStyleBackColor = true;
            countRadio.CheckedChanged += countRadio_CheckedChanged;
            // 
            // textBoxTypePrice
            // 
            textBoxTypePrice.Location = new Point(135, 94);
            textBoxTypePrice.Name = "textBoxTypePrice";
            textBoxTypePrice.ReadOnly = true;
            textBoxTypePrice.Size = new Size(121, 23);
            textBoxTypePrice.TabIndex = 4;
            // 
            // patrolPriceLabel
            // 
            patrolPriceLabel.AutoSize = true;
            patrolPriceLabel.Location = new Point(21, 102);
            patrolPriceLabel.Name = "patrolPriceLabel";
            patrolPriceLabel.Size = new Size(33, 15);
            patrolPriceLabel.TabIndex = 3;
            patrolPriceLabel.Text = "Price";
            // 
            // comboBoxPatrolType
            // 
            comboBoxPatrolType.FormattingEnabled = true;
            comboBoxPatrolType.Items.AddRange(new object[] { "A-76", "Disel", "B-32", "Best" });
            comboBoxPatrolType.Location = new Point(135, 28);
            comboBoxPatrolType.Name = "comboBoxPatrolType";
            comboBoxPatrolType.Size = new Size(121, 23);
            comboBoxPatrolType.TabIndex = 2;
            comboBoxPatrolType.SelectedValueChanged += comboBoxPatrolType_SelectedValueChanged;
            // 
            // patrolTypeLabel
            // 
            patrolTypeLabel.AutoSize = true;
            patrolTypeLabel.Location = new Point(21, 31);
            patrolTypeLabel.Name = "patrolTypeLabel";
            patrolTypeLabel.Size = new Size(79, 15);
            patrolTypeLabel.TabIndex = 0;
            patrolTypeLabel.Text = "Type of patrol";
            // 
            // groupBoxFood
            // 
            groupBoxFood.BackColor = Color.White;
            groupBoxFood.Controls.Add(panelFood);
            groupBoxFood.Controls.Add(groupBox1);
            groupBoxFood.Controls.Add(foodChoicePanel);
            groupBoxFood.Location = new Point(338, 12);
            groupBoxFood.Name = "groupBoxFood";
            groupBoxFood.Size = new Size(309, 362);
            groupBoxFood.TabIndex = 1;
            groupBoxFood.TabStop = false;
            groupBoxFood.Text = "Food";
            // 
            // panelFood
            // 
            panelFood.Controls.Add(textBoxFrenchfriesPrice);
            panelFood.Controls.Add(label1);
            panelFood.Controls.Add(textBoxColaCount);
            panelFood.Controls.Add(label3);
            panelFood.Controls.Add(textBoxFrenchfriesCount);
            panelFood.Controls.Add(textBoxHotdogPrice);
            panelFood.Controls.Add(textBoxBurgerCount);
            panelFood.Controls.Add(textBoxBurgerPrice);
            panelFood.Controls.Add(textBoxHotDogCount);
            panelFood.Controls.Add(textBoxColaPrice);
            panelFood.Location = new Point(147, 15);
            panelFood.Name = "panelFood";
            panelFood.Size = new Size(145, 133);
            panelFood.TabIndex = 16;
            // 
            // textBoxFrenchfriesPrice
            // 
            textBoxFrenchfriesPrice.Location = new Point(5, 78);
            textBoxFrenchfriesPrice.Name = "textBoxFrenchfriesPrice";
            textBoxFrenchfriesPrice.ReadOnly = true;
            textBoxFrenchfriesPrice.Size = new Size(61, 23);
            textBoxFrenchfriesPrice.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 4);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 6;
            label1.Text = "Price";
            // 
            // textBoxColaCount
            // 
            textBoxColaCount.Location = new Point(72, 103);
            textBoxColaCount.Name = "textBoxColaCount";
            textBoxColaCount.ReadOnly = true;
            textBoxColaCount.Size = new Size(61, 23);
            textBoxColaCount.TabIndex = 15;
            textBoxColaCount.TextChanged += EnterCountItem;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 4);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Count";
            // 
            // textBoxFrenchfriesCount
            // 
            textBoxFrenchfriesCount.Location = new Point(72, 78);
            textBoxFrenchfriesCount.Name = "textBoxFrenchfriesCount";
            textBoxFrenchfriesCount.ReadOnly = true;
            textBoxFrenchfriesCount.Size = new Size(61, 23);
            textBoxFrenchfriesCount.TabIndex = 14;
            textBoxFrenchfriesCount.TextChanged += EnterCountItem;
            // 
            // textBoxHotdogPrice
            // 
            textBoxHotdogPrice.Location = new Point(5, 30);
            textBoxHotdogPrice.Name = "textBoxHotdogPrice";
            textBoxHotdogPrice.ReadOnly = true;
            textBoxHotdogPrice.Size = new Size(61, 23);
            textBoxHotdogPrice.TabIndex = 8;
            // 
            // textBoxBurgerCount
            // 
            textBoxBurgerCount.Location = new Point(72, 55);
            textBoxBurgerCount.Name = "textBoxBurgerCount";
            textBoxBurgerCount.ReadOnly = true;
            textBoxBurgerCount.Size = new Size(61, 23);
            textBoxBurgerCount.TabIndex = 13;
            textBoxBurgerCount.TextChanged += EnterCountItem;
            // 
            // textBoxBurgerPrice
            // 
            textBoxBurgerPrice.Location = new Point(5, 55);
            textBoxBurgerPrice.Name = "textBoxBurgerPrice";
            textBoxBurgerPrice.ReadOnly = true;
            textBoxBurgerPrice.Size = new Size(61, 23);
            textBoxBurgerPrice.TabIndex = 9;
            // 
            // textBoxHotDogCount
            // 
            textBoxHotDogCount.Location = new Point(72, 30);
            textBoxHotDogCount.Name = "textBoxHotDogCount";
            textBoxHotDogCount.ReadOnly = true;
            textBoxHotDogCount.Size = new Size(61, 23);
            textBoxHotDogCount.TabIndex = 12;
            textBoxHotDogCount.TextChanged += EnterCountItem;
            // 
            // textBoxColaPrice
            // 
            textBoxColaPrice.Location = new Point(5, 103);
            textBoxColaPrice.Name = "textBoxColaPrice";
            textBoxColaPrice.ReadOnly = true;
            textBoxColaPrice.Size = new Size(61, 23);
            textBoxColaPrice.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(foodToPayLabel);
            groupBox1.Location = new Point(18, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "To pay";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(199, 62);
            label4.Name = "label4";
            label4.Size = new Size(30, 14);
            label4.TabIndex = 1;
            label4.Text = "UAH";
            // 
            // foodToPayLabel
            // 
            foodToPayLabel.Anchor = AnchorStyles.None;
            foodToPayLabel.AutoSize = true;
            foodToPayLabel.Font = new Font("Yu Gothic UI Semibold", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            foodToPayLabel.Location = new Point(6, 29);
            foodToPayLabel.Name = "foodToPayLabel";
            foodToPayLabel.Size = new Size(103, 55);
            foodToPayLabel.TabIndex = 0;
            foodToPayLabel.Text = "0.00";
            foodToPayLabel.TextChanged += TotalPriceChange;
            // 
            // foodChoicePanel
            // 
            foodChoicePanel.Controls.Add(checkBoxHotDog);
            foodChoicePanel.Controls.Add(checkBoxCola);
            foodChoicePanel.Controls.Add(checkBoxBurger);
            foodChoicePanel.Controls.Add(checkBoxFrenchfries);
            foodChoicePanel.Location = new Point(15, 48);
            foodChoicePanel.Name = "foodChoicePanel";
            foodChoicePanel.Size = new Size(115, 100);
            foodChoicePanel.TabIndex = 5;
            // 
            // checkBoxHotDog
            // 
            checkBoxHotDog.AutoSize = true;
            checkBoxHotDog.Location = new Point(3, 0);
            checkBoxHotDog.Name = "checkBoxHotDog";
            checkBoxHotDog.Size = new Size(67, 19);
            checkBoxHotDog.TabIndex = 1;
            checkBoxHotDog.Text = "Hotdog";
            checkBoxHotDog.UseVisualStyleBackColor = true;
            checkBoxHotDog.CheckedChanged += CheckFoodItem;
            // 
            // checkBoxCola
            // 
            checkBoxCola.AutoSize = true;
            checkBoxCola.Location = new Point(3, 75);
            checkBoxCola.Name = "checkBoxCola";
            checkBoxCola.Size = new Size(50, 19);
            checkBoxCola.TabIndex = 4;
            checkBoxCola.Text = "Cola";
            checkBoxCola.UseVisualStyleBackColor = true;
            checkBoxCola.CheckedChanged += CheckFoodItem;
            // 
            // checkBoxBurger
            // 
            checkBoxBurger.AutoSize = true;
            checkBoxBurger.Location = new Point(3, 25);
            checkBoxBurger.Name = "checkBoxBurger";
            checkBoxBurger.Size = new Size(61, 19);
            checkBoxBurger.TabIndex = 2;
            checkBoxBurger.Text = "Burger";
            checkBoxBurger.UseVisualStyleBackColor = true;
            checkBoxBurger.CheckedChanged += CheckFoodItem;
            // 
            // checkBoxFrenchfries
            // 
            checkBoxFrenchfries.AutoSize = true;
            checkBoxFrenchfries.Location = new Point(3, 50);
            checkBoxFrenchfries.Name = "checkBoxFrenchfries";
            checkBoxFrenchfries.Size = new Size(87, 19);
            checkBoxFrenchfries.TabIndex = 3;
            checkBoxFrenchfries.Text = "French fries";
            checkBoxFrenchfries.UseVisualStyleBackColor = true;
            checkBoxFrenchfries.CheckedChanged += CheckFoodItem;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTotalPay);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(totalPayLabel);
            groupBox2.Location = new Point(12, 392);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 119);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total payment";
            // 
            // buttonTotalPay
            // 
            buttonTotalPay.Font = new Font("Yu Gothic UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTotalPay.Location = new Point(6, 40);
            buttonTotalPay.Name = "buttonTotalPay";
            buttonTotalPay.Size = new Size(327, 55);
            buttonTotalPay.TabIndex = 3;
            buttonTotalPay.Text = "Pay";
            buttonTotalPay.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(543, 71);
            label7.Name = "label7";
            label7.Size = new Size(30, 14);
            label7.TabIndex = 2;
            label7.Text = "UAH";
            // 
            // totalPayLabel
            // 
            totalPayLabel.Anchor = AnchorStyles.None;
            totalPayLabel.AutoSize = true;
            totalPayLabel.Font = new Font("Yu Gothic UI Semibold", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalPayLabel.Location = new Point(350, 38);
            totalPayLabel.Name = "totalPayLabel";
            totalPayLabel.Size = new Size(103, 55);
            totalPayLabel.TabIndex = 2;
            totalPayLabel.Text = "0.00";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 523);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxFood);
            Controls.Add(groupBoxPatrol);
            Name = "Form";
            Text = "BestOil";
            groupBoxPatrol.ResumeLayout(false);
            groupBoxPatrol.PerformLayout();
            finalPricePatrol.ResumeLayout(false);
            finalPricePatrol.PerformLayout();
            groupBoxPatrolChoice.ResumeLayout(false);
            groupBoxPatrolChoice.PerformLayout();
            groupBoxFood.ResumeLayout(false);
            panelFood.ResumeLayout(false);
            panelFood.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            foodChoicePanel.ResumeLayout(false);
            foodChoicePanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxPatrol;
        private GroupBox groupBoxFood;
        private ComboBox comboBoxPatrolType;
        private Label patrolTypeLabel;
        private GroupBox groupBoxPatrolChoice;
        private RadioButton countRadio;
        private TextBox textBoxTypePrice;
        private Label patrolPriceLabel;
        private RadioButton priceRadio;
        private TextBox textBoxPatrolPrice;
        private TextBox textBoxPatrolCount;
        private GroupBox finalPricePatrol;
        private Label patrolToPayLabel;
        private Label litersLabel;
        private Label UAHLabel2;
        private Label UAHLabel;
        private CheckBox checkBoxCola;
        private CheckBox checkBoxFrenchfries;
        private CheckBox checkBoxBurger;
        private CheckBox checkBoxHotDog;
        private Label label2;
        private Panel foodChoicePanel;
        private TextBox textBoxColaPrice;
        private TextBox textBoxFrenchfriesPrice;
        private TextBox textBoxBurgerPrice;
        private TextBox textBoxHotdogPrice;
        private Label label3;
        private Label label1;
        private TextBox textBoxColaCount;
        private TextBox textBoxFrenchfriesCount;
        private TextBox textBoxBurgerCount;
        private TextBox textBoxHotDogCount;
        private GroupBox groupBox1;
        private Label label4;
        private Label foodToPayLabel;
        private GroupBox groupBox2;
        private Button buttonTotalPay;
        private Label label7;
        private Label totalPayLabel;
        private Panel panelFood;
    }
}