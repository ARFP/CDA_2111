using DemoMdiContainer.Lib;
using System.Text.RegularExpressions;

namespace DemoMdiContainer.Apps
{
    public partial class FrmValidationSaisie : Form
    {
        private ErrorProvider errorProvider;
        private NameValidate nameValidate;
        private DateValidate dateValidate;

        private FrmDemo frmDemo;

        public FrmValidationSaisie()  
        {
            InitializeComponent();
        }

        public void SetFormDemo(FrmDemo frmDemo)
        {
            this.frmDemo = frmDemo;
            txtName.Text = frmDemo.TextValid.Text;
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