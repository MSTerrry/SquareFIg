using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Square
{
    public partial class Form1 : Form
    {
        private int numberPoints = 1;
        private string textboxName = "InputPoint";
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point() { }
            public Point(string[] str)
            {
                double x, y;
                if (str.Length < 2) return;
                var parseResultX = double.TryParse(str[0], out x);
                var parseResultY = double.TryParse(str[1], out y);
                if (!parseResultX)
                    MessageBox.Show($"Input data was not correct. Error parse {str[0]}");
                X = x;
                if (!parseResultY)
                    MessageBox.Show($"Input data was not correct. Error parse {str[1]}");
                Y = y;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Controls.Find(textboxName, true).Cast<TextBox>().ToList().ForEach(z => z.Clear());
            ResultTextbox.Clear();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var resultList = GetInputList();
            var result = 0.0;
            for (int i = 0; i < resultList.Count(); i++)
            {
                if (i + 1 != resultList.Count())
                    result += resultList[i].X * resultList[i + 1].Y - resultList[i + 1].X * resultList[i].Y;
                else
                    result += resultList[i].X * resultList[0].Y - resultList[i].Y * resultList[0].X;
            }
            ResultTextbox.Text = (Math.Abs(result) / 2).ToString();
        }
        private List<Point> GetInputList()
        {
            var t = Controls.Find(textboxName, true).Cast<TextBox>();
            var resultList = t.Select(z => MakePointFromText(z.Text)).ToList();
            return resultList;
        }
        private Point MakePointFromText(string text)
        {
            return new Point(text.Replace('.', ',').Trim(' ').Replace(")", "").Replace("(", "").Split(';'));
        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {
            var last = Controls.Find(textboxName, true).Last();
            numberPoints++;

            var label = new Label();
            label.Text = $"{numberPoints}.";
            label.Name = "PointNumber";
            label.Location = new System.Drawing.Point(last.Location.X - 18, last.Location.Y + 29);

            var textbox = new TextBox();
            textbox.Size = new Size(100, 20);
            textbox.Name = last.Name;
            textbox.Location = new System.Drawing.Point(last.Location.X, last.Location.Y + 28);

            Controls.Add(textbox);
            Controls.Add(label);
        }

        private void RemovePointButton_Click(object sender, EventArgs e)
        {
            if (numberPoints == 1) return;
            Controls.Remove(Controls.Find("InputPoint", true).Last());
            Controls.Remove(Controls.Find("PointNumber", true).Last());
            numberPoints--;
        }
    }
}
