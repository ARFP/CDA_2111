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
                    LastDiplomaYear = Convert.ToInt32(tbxYearDip.Text),
                    RegistrationYear = DateTime.Now.Year
                };

                if (viewModel.IsValid())
                {
                    jobSeeker = new JobSeeker(viewModel);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
