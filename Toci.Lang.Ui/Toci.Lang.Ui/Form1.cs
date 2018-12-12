using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Toci.business.Dal;

namespace Toci.Lang.Ui
{
    public partial class Form1 : Form
    {
        private TranslationDal dal = new TranslationDal();
        public Form1()
        {
            InitializeComponent();

            FormAddWord w = new FormAddWord();

            w.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DataTable result = dal.GetTranslations(textBox1.Text);
            int i = 0;
            foreach (DataRow row in result.Rows)
            {
                Label l = new Label();
                l.Text = row["fromword"].ToString();

                Label l2 = new Label();

                l2.Text = row["toword"].ToString();

                l.Size = new Size(100, 20);
                l2.Size = new Size(100, 20);

                l.Location = new Point(20, 60 +(20 * ++i));
                l2.Location = new Point(140, 60 + (20 * i));

                Controls.Add(l);
                Controls.Add(l2);
            }
        }
    }
}
