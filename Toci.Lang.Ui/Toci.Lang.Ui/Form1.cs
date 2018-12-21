using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Toci.business.Bll;
using Toci.business.Dal;
using Toci.business.EfExample;
using Toci.business.Quiz;
using Toci.business.Reflection;
using Toci.Business.Interfaces;

namespace Toci.Lang.Ui
{
    public partial class Form1 : Form
    {
        private TranslationDal dal = new TranslationDal();

        private ComboBox languageFromCombo;
        private ComboBox languageToCombo;
        private ComboBox quizQuizFromLanguageCombo;
        private ComboBox quizQuizToLanguageCombo;
        private Button ListTranslations;
        private Button quizButton;
        private List<Control> ControlsToRefresh = new List<Control>();
        private QuizLogic ql = new QuizLogic();

        public Form1()
        {
            InitializeComponent();

            AddLanguageComboBox();

            slowoToolStripMenuItem.Click += AddNewWordClick;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //DataTable result = dal.GetTranslationsFromTo("pl", textBox1.Text);
            //AddTranslationsLabels(result, "fromword","toword",20,62);
            EfClassGenerator generator = new EfClassGenerator();

            generator.GenerateCode();

            ReflectionExample re = new ReflectionExample();

            List<string> props = re.GetDataModelProperties();

            DataModel dm = new DataModel();

            re.SetPrivateField(dm, "dupa", "ToDaSieWypelnicRefleksja");

            re.RunGenericMethodByString(re, "SetPrivateField", new Type[] {typeof(DataModel), typeof(string)}, dm);

        }
        private void ButtonAcceptClick(object sender, System.EventArgs e)
        {
            DataTable result = dal.GetTranslationsFromTo(languageFromCombo.Text, languageToCombo.Text);
            AddTranslationsLabels(result, "fromword", "toword", 210, 62 );
        }

        private void AddNewWordClick(object sender, System.EventArgs e)
        {
            FormAddWord w = new FormAddWord();

            w.Show();
        }

        private void quizButtonClick(object sender, System.EventArgs e)
        {
           // DataTable result = dal.GetTranslationsFromTo(quizQuizFromLanguageCombo.Text, quizQuizToLanguageCombo.Text);
            List<IQuiz> get = ql.GetQuiz(quizQuizFromLanguageCombo.Text, quizQuizToLanguageCombo.Text);
            int i = 0;
            foreach (var quizQuestion in get)
            {
                Label l1 = ControlManager.CreateControl<Label>(100, 20, 540, 82 + (20 *++i), quizQuestion.Question.Word);
                Controls.Add(l1);

                int j = 0;
                foreach (var answer in quizQuestion.Answers)
                {
                    QuizButton b1 = ControlManager.CreateControl<QuizButton>(100, 20, 630 +(110 * ++j), 82 + (20 * i), answer.Word);
                    b1.CorrectAnswer = answer.IsCorrect;
                    
                    Controls.Add(b1);

                }
            }
           
        }

        private void selectAnswerClick(object sender, EventArgs e)
        {
            QuizButton b = (QuizButton) sender;
            //if (b.CorrectAnswer)
            //    Label ls = ControlManager.
        }

        private void AddTranslationsLabels(DataTable result, string lbFrom, string lbTo, int locationX, int locationY)
        {
            foreach (Control control in ControlsToRefresh)
            {
                Controls.Remove(control);
            }

            ControlsToRefresh = new List<Control>();

            int i = 0;
            foreach (DataRow row in result.Rows)
            {
                Label l1 = ControlManager.CreateControl<Label>(100, 20, locationX, locationY + (20 * ++i), row[lbFrom].ToString()); 
                Label l2 = ControlManager.CreateControl<Label>(100, 20, 120 + locationX, locationY + (20 * i), row[lbTo].ToString());
                ControlsToRefresh.Add(l1);
                ControlsToRefresh.Add(l2);
                Controls.Add(l1);
                Controls.Add(l2);


            }

        }

        private void AddLanguageComboBox()
        {
            //ApiTranslationProxy.languages

            languageFromCombo = ControlManager.CreateControl<ComboBox>(100, 20, 210, 42, string.Empty);
            quizQuizFromLanguageCombo = ControlManager.CreateControl<ComboBox>(100, 20, 540, 42, string.Empty);
            languageToCombo = ControlManager.CreateControl<ComboBox>(100, 20, 320, 42, string.Empty);
            quizQuizToLanguageCombo = ControlManager.CreateControl<ComboBox>(100, 20, 650, 42, string.Empty);
            ListTranslations = ControlManager.CreateControl<Button>(100, 20, 420, 42, "accept");
            quizButton = ControlManager.CreateControl<Button>(100, 20, 760, 42, "accept");

            

            ListTranslations.Click += ButtonAcceptClick;
            quizButton.Click += quizButtonClick;

            AddItemsToCombo(languageFromCombo, ApiTranslationProxy.languages);
            AddItemsToCombo(quizQuizFromLanguageCombo, ApiTranslationProxy.languages);
            AddItemsToCombo(languageToCombo, ApiTranslationProxy.languages);
            AddItemsToCombo(quizQuizToLanguageCombo, ApiTranslationProxy.languages);

            Controls.Add(languageFromCombo);
            Controls.Add(quizQuizFromLanguageCombo);
            Controls.Add(languageToCombo);
            Controls.Add(quizQuizToLanguageCombo);
            Controls.Add(ListTranslations);
            Controls.Add(quizButton);
        }

        private ComboBox AddItemsToCombo(ComboBox cmb, string[] items)
        {
            foreach (string item in items)
            {
                ComboboxItem citem = new ComboboxItem() { Text = item, Value = item};
                cmb.Items.Add(citem);
            }

            return cmb;
        }
        /*
         * ComboboxItem item = new ComboboxItem();
    item.Text = "Item text1";
    item.Value = 12;

    comboBox1.Items.Add(item);
         */

    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
