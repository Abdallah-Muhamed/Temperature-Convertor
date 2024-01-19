using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment_4
{
    partial class Form1
    {
  
        private void InitializeComponent()
        {
            temp = new Label();
            temp.Size = new System.Drawing.Size(100, 20);
            temp.Text = "Temperature";
            temp.Location = new System.Drawing.Point(50, 50);
            temp.BackColor = Color.Transparent;
            Controls.Add(temp);

            converfrom = new Label();
            converfrom.Size = new System.Drawing.Size(100, 20);
            converfrom.Text = "Convert from";
            converfrom.Location = new System.Drawing.Point(50, 100);
            converfrom.BackColor = Color.Transparent;
            Controls.Add(converfrom);

            converto = new Label();
            converto.Size = new System.Drawing.Size(100, 20);
            converto.Text = "Convert to";
            converto.Location = new System.Drawing.Point(50, 150);
            converto.BackColor = Color.Transparent;
            Controls.Add(converto);

            result = new Label();
            result.Size = new System.Drawing.Size(100, 20);
            result.Text = "Result";
            result.Location = new System.Drawing.Point(50, 200);
            result.BackColor = Color.Transparent;
            Controls.Add(result);

            temptext = new TextBox();
            temptext.Size = new Size(150, 25);
            temptext.Location = new System.Drawing.Point(170, 50);
            Controls.Add(temptext);

            resulttext = new TextBox();
            resulttext.Size = new Size(150, 25);
            resulttext.Location = new System.Drawing.Point(170, 200);
            Controls.Add(resulttext);

            cel = new RadioButton();
            cel.Size = new System.Drawing.Size(100, 20);
            cel.Text = "Celsius";
            cel.Location = new System.Drawing.Point(170, 150);
            cel.BackColor = Color.Transparent;
            Controls.Add(cel);

            fah = new RadioButton();
            fah.Size = new System.Drawing.Size(100, 20);
            fah.Text = "Fahrenheit";
            fah.Location = new System.Drawing.Point(300, 150);
            fah.BackColor = Color.Transparent;
            Controls.Add(fah);

            conver = new Button();
            conver.Size = new Size(120, 30);
            conver.Location = new System.Drawing.Point(180, 250);
            conver.Text = "Convert";
            conver.Click += Convert_Click;
            Controls.Add(conver);

            choiceBox = new ComboBox();
            choiceBox.Size = new System.Drawing.Size(150, 20);
            choiceBox.Location = new System.Drawing.Point(170, 100);
            choiceBox.Items.Add("Fahrenheit");
            choiceBox.Items.Add("Celsius");
            choiceBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            choiceBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            Controls.Add(choiceBox);


            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Temperature convertor";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
        private Label temp;
        private Label converfrom;
        private Label converto;
        private Label result;

        private TextBox temptext;
        private TextBox resulttext;
        private ComboBox choiceBox;

        private RadioButton cel;
        private RadioButton fah;

        private Button conver;



    }
}

