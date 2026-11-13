
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace text4._2
{
    public partial class QeydlerDefteri : Form
    {
        private RichTextBox metn;
        private StatusStrip status;
        private ToolStripStatusLabel simvolSay;

        public QeydlerDefteri()
        {
            InitializeComponent();

            metn = Controls.Find("rtbMetn", true)
                .FirstOrDefault() as RichTextBox;

            status = Controls.OfType<StatusStrip>()
                .FirstOrDefault();

            if (metn == null)
            {
                MessageBox.Show("RichTextBox tapılmadı!");
                return;
            }

            if (status != null)
            {
                simvolSay = new ToolStripStatusLabel();
                status.Items.Add(simvolSay);
            }

            metn.TextChanged += (s, e) =>
            {
                if (simvolSay != null)
                    simvolSay.Text = "Simvol sayı: " + metn.Text.Length;
            };

            MenyulariQos();
        }

        private void MenyulariQos()
        {
            foreach (MenuStrip menu in Controls.OfType<MenuStrip>())
            {
                foreach (ToolStripMenuItem item in menu.Items)
                    MenyuElementleriniQos(item);
            }
        }

        private void MenyuElementleriniQos(ToolStripMenuItem item)
        {
            string ad = item.Text.Replace("&", "").ToLower();

            item.Click -= Menyu_Click;

            if (ad.Contains("yeni"))
                item.Click += Yeni_Click;
            else if (ad.Contains("aç") || ad.Contains("ac"))
                item.Click += Ac_Click;
            else if (ad.Contains("saxla"))
                item.Click += Saxla_Click;
            else if (ad.Contains("çıxış") || ad.Contains("cixis"))
                item.Click += Cixis_Click;
            else if (ad.Contains("şrift") || ad.Contains("srift"))
                item.Click += Srift_Click;
            else if (ad.Contains("rəng") || ad.Contains("reng"))
                item.Click += Reng_Click;

            foreach (ToolStripItem child in item.DropDownItems)
            {
                if (child is ToolStripMenuItem subItem)
                    MenyuElementleriniQos(subItem);
            }
        }

        private void Menyu_Click(object sender, EventArgs e)
        {
        }

        private void Yeni_Click(object sender, EventArgs e)
        {
            metn.Clear();
        }

        private void Ac_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ac = new OpenFileDialog())
            {
                ac.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (ac.ShowDialog() == DialogResult.OK)
                    metn.Text = File.ReadAllText(ac.FileName);
            }
        }

        private void Saxla_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saxla = new SaveFileDialog())
            {
                saxla.Filter = "Text Files (*.txt)|*.txt";

                if (saxla.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saxla.FileName, metn.Text);
                    MessageBox.Show("Fayl saxlanıldı!");
                }
            }
        }

        private void Cixis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Srift_Click(object sender, EventArgs e)
        {
            using (FontDialog font = new FontDialog())
            {
                font.Font = metn.SelectionFont ?? metn.Font;

                if (font.ShowDialog() == DialogResult.OK)
                {
                    if (metn.SelectionLength > 0)
                        metn.SelectionFont = font.Font;
                    else
                        metn.Font = font.Font;
                }
            }
        }

        private void Reng_Click(object sender, EventArgs e)
        {
            using (ColorDialog reng = new ColorDialog())
            {
                if (reng.ShowDialog() == DialogResult.OK)
                {
                    if (metn.SelectionLength > 0)
                        metn.SelectionColor = reng.Color;
                    else
                        metn.ForeColor = reng.Color;
                }
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metn.Clear();
        }
    }
}
