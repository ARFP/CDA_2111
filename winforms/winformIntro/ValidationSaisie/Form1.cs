using LibValidationSaisie;
using System.Text.RegularExpressions;

namespace ValidationSaisie
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider;
        private NameValidate nameValidate;
        private DateValidate dateValidate;

        public Form1()  
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameValidate = new NameValidate();
            dateValidate = new DateValidate();
            
           // regexZip = new Regex(@"^\d{5}$");
            errorProvider = new ErrorProvider();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtName, nameValidate.IsValid(txtName.Text) ? String.Empty : "Erreur Nom");
            errorProvider.SetError(txtDate, dateValidate.IsValid(txtDate.Text) ? String.Empty : "Erreur Date");

           /* if(String.IsNullOrEmpty(errorProvider.GetError(txtName)) 
                &&
                String.IsNullOrEmpty(errorProvider.GetError(txtName)))
            {

            }

            if(errorProvider.GetError(txtName) == String.Empty) {

            }*/
        }

    }
}