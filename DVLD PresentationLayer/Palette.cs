using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_System
{
    public static class Palette
    {
        public static readonly Color Primary = Color.FromArgb(34, 40, 49);
        public static readonly Color Secondary = Color.FromArgb(57, 62, 70);
        public static readonly Color Accent = Color.FromArgb(148, 137, 121);
        public static readonly Color Light = Color.FromArgb(223, 208, 184);

        public static void Apply(Control root)
        {
            if (root == null) return;
            // If root is a Form set basic form colors
            if (root is Form f)
            {
                f.BackColor = Primary;
                f.ForeColor = Light;
            }

            ApplyToControl(root);
        }

        static void ApplyToControl(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                try
                {
                    if (ctrl is DataGridView dgv)
                    {
                        dgv.BackgroundColor = Secondary;
                        dgv.EnableHeadersVisualStyles = false;

                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Accent;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Light;

                        dgv.RowHeadersDefaultCellStyle.BackColor = Secondary;
                        dgv.RowHeadersDefaultCellStyle.ForeColor = Light;

                        dgv.RowsDefaultCellStyle.BackColor = Light;
                        dgv.RowsDefaultCellStyle.ForeColor = Primary;

                        dgv.DefaultCellStyle.SelectionBackColor = Secondary;
                        dgv.DefaultCellStyle.SelectionForeColor = Light;
                    }
                    else if (ctrl is GroupBox || ctrl is Panel || ctrl is SplitContainer)
                    {
                        ctrl.BackColor = Secondary;
                        ctrl.ForeColor = Accent;
                    }
                    else if (ctrl is TextBox || ctrl is ComboBox || ctrl is NumericUpDown || ctrl is RichTextBox)
                    {
                        ctrl.BackColor = Light;
                        ctrl.ForeColor = Primary;
                    }
                    else if (ctrl is Button || ctrl is LinkLabel)
                    {
                        ctrl.BackColor = Secondary;
                        ctrl.ForeColor = Light;
                    }
                    else if (ctrl is Label)
                    {
                        // labels: make sure they contrast with parent
                        if (IsDark(ctrl.Parent?.BackColor ?? Primary)) ctrl.ForeColor = Light;
                        else ctrl.ForeColor = Primary;
                    }
                    else if (ctrl is PictureBox)
                    {
                        ctrl.BackColor = Primary;
                    }
                    else
                    {
                        // default: pick foreground based on background brightness
                        if (IsDark(ctrl.BackColor)) ctrl.ForeColor = Light;
                        else ctrl.ForeColor = Primary;
                    }
                }
                catch
                {
                    // ignore per-control failures
                }

                // recurse
                if (ctrl.HasChildren) ApplyToControl(ctrl);
            }
        }

        static bool IsDark(Color c)
        {
            // handle Transparent / Default
            if (c == Color.Empty || c == Color.Transparent) return true;
            double l = 0.2126 * c.R + 0.7152 * c.G + 0.0722 * c.B;
            return l < 140; // threshold
        }
    }
}
