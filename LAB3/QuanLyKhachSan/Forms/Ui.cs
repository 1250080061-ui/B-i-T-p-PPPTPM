using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    internal static class Ui
    {
        public static Label L(string text, int width = 110)
        {
            return new Label
            {
                Text = text,
                Width = width,
                Height = 28,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(5)
            };
        }

        public static TextBox T(int width = 170)
        {
            return new TextBox
            {
                Width = width,
                Margin = new Padding(5)
            };
        }

        public static ComboBox C(int width = 180)
        {
            return new ComboBox
            {
                Width = width,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Margin = new Padding(5)
            };
        }

        public static NumericUpDown N(
            decimal max = 1000000000M,
            int width = 140)
        {
            return new NumericUpDown
            {
                Width = width,
                Maximum = max,
                Minimum = 0,
                ThousandsSeparator = true,
                Margin = new Padding(5)
            };
        }

        public static DateTimePicker D(int width = 150)
        {
            return new DateTimePicker
            {
                Width = width,
                Format = DateTimePickerFormat.Short,
                Margin = new Padding(5)
            };
        }

        public static Button B(
            string text,
            EventHandler click)
        {
            var b = new Button
            {
                Text = text,
                AutoSize = true,
                Height = 32,
                Margin = new Padding(5)
            };

            if (click != null)
                b.Click += click;

            return b;
        }

        public static DataGridView G(int height = 230)
        {
            return new DataGridView
            {
                Width = 1050,
                Height = height,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                MultiSelect = false,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                Margin = new Padding(5)
            };
        }

        public static FlowLayoutPanel Row(
            params Control[] controls)
        {
            var p = new FlowLayoutPanel
            {
                AutoSize = true,
                WrapContents = true,
                FlowDirection =
                    FlowDirection.LeftToRight,
                Margin = new Padding(3)
            };

            p.Controls.AddRange(controls);

            return p;
        }

        public static FlowLayoutPanel Stack()
        {
            return new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection =
                    FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10)
            };
        }
    }
}