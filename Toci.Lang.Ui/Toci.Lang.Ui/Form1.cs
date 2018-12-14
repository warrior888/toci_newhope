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
                Controls.Add(ControlManager.CreateControl<Label>(100,20,20, 60 + (20 * ++i), row["fromword"].ToString()));
                Controls.Add(ControlManager.CreateControl<Label>(100, 20, 140, 60 + (20 * i), row["toword"].ToString()));
            }
        }
    }
}
