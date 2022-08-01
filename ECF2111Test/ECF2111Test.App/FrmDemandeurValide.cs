using ECF2111Test.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF2111Test.App
{
    public partial class FrmDemandeurValide : Form
    {
        private Form parentForm;
        private JobSeeker jobSeeker;

        public FrmDemandeurValide()
        {
            InitializeComponent();
        }

        public void setParentForm(Form frm)
        {
            parentForm = frm;
        }

        public void SetJobSeeker(JobSeeker jseeker)
        {
            jobSeeker = jseeker;
            tbxLname.Text = jobSeeker.Name;
            tbxFname.Text = jobSeeker.Firstname;
            tbxLevel.Text = jobSeeker.Level.ToString();
            tbxDiploma.Text = jobSeeker.LastDiplomaName;
            tbxYearDip.Text = jobSeeker.LastDiplomaYear.ToString();
            labelId.Text = String.Format("Demandeur n°{0} ajouté ({1})", jobSeeker.Id, jobSeeker.RegistrationYear);
            labelEmp.Text = "Employabilité : " + jobSeeker.Employability;
        }

        private void FrmDemandeurValide_FormClosing(object sender, FormClosingEventArgs e)
        {
            // parentForm.Close();
            parentForm.Show();
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            // sérialise un objet en JSON
            string json = JsonSerializer.Serialize(jobSeeker);

            // Récupération du chemin où sauvegarde le fichier
            // LocalApplicationData = C:\Users\NOM_UTILISATEUR_COURANT\AppData\Local
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // ajout du nom de fichier au chemin
            path = Path.Combine(path, "jobseeker-" + jobSeeker.Id.ToString() + ".json");

            // écrit "json" dans "path"
            File.WriteAllText(path, json, Encoding.UTF8);

            // affiche un message dans une boite de dialogue
            // MessageBox.Show(json);

            // lire les données d'un fichier
            // json = File.ReadAllText(path, Encoding.UTF8);

            // désérialiser le json en son type d'origine
            // JobSeeker toto = JsonSerializer.Deserialize<JobSeeker>(json);
            
        }
    }
}
