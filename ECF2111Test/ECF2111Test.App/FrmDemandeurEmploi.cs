using ECF2111Test.Lib;
using ECF2111Test.Lib.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF2111Test.App
{
    public partial class FrmDemandeurEmploi : Form
    {
        JobSeekerAddViewModel viewModel;
        JobSeeker jobSeeker;

        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void TotoIsBack_Load(object sender, EventArgs e)
        {
            //cbxLevel.DataSource = Enum.GetNames(typeof(Levels));
            cbxLevel.DataSource = Enum.GetNames<Levels>();
            cbxLevel.SelectedIndex = 0;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel = new JobSeekerAddViewModel()
                {
                    Name = tbxLname.Text,
                    Firstname = tbxFname.Text,
                    Level = (Levels)Enum.Parse<Levels>(cbxLevel.SelectedItem.ToString()),
                    LastDiplomaName = tbxDiploma.Text,
                    LastDiplomaYear = String.IsNullOrEmpty(tbxYearDip.Text) ? null : Convert.ToInt32(tbxYearDip.Text),
                    RegistrationYear = DateTime.Now.Year
                };

                if (viewModel.IsValid())
                {
                    jobSeeker = new JobSeeker(viewModel);
                    
                    FrmDemandeurValide frm = new FrmDemandeurValide();
                    frm.setParentForm(this);
                    frm.SetJobSeeker(jobSeeker);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    DisplayErrors();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayErrors()
        {
            SetControlError(tbxFname, viewModel.IsValidFirstName());
            SetControlError(tbxLname, viewModel.IsValidName());
            SetControlError(tbxDiploma, viewModel.IsValidDiplomaName());
            SetControlError(tbxYearDip, viewModel.IsValidLastDiplomaYear());
        }

        private void SetControlError(TextBox control, bool result)
        {
            if(result)
            {
                control.ForeColor = Color.Blue;
                control.Font = new Font(control.Font, FontStyle.Regular);
            }
            else
            {
                control.ForeColor = Color.Red;
                control.Font = new Font(control.Font, FontStyle.Bold);
            }
        }
    }
}
