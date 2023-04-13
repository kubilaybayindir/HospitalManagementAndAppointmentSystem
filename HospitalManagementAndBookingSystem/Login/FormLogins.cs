using HospitalManagementAndAppointmentSystem.Doctor;
using HospitalManagementAndAppointmentSystem.Patient;
using HospitalManagementAndAppointmentSystem.Secretary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementAndAppointmentSystem
{
    public partial class FormLogins : Form
    {
        public FormLogins()
        {
            InitializeComponent();
        }

        private void BtPatientScreenOpen_Click(object sender, EventArgs e)
        {
            FormPatientLogin formPatientLogin = new FormPatientLogin();
            formPatientLogin.Show();
            this.Hide();
        }

        private void BtDoctorScreenOpen_Click(object sender, EventArgs e)
        {
            FormDoctorLogin formDoctorLogin = new FormDoctorLogin();
            formDoctorLogin.Show();
            this.Hide();
        }

        private void BtSecretaryScreenOpen_Click(object sender, EventArgs e)
        {
            FormSecretaryLogin formSecretaryLogin = new FormSecretaryLogin();
            formSecretaryLogin.Show();
            this.Hide();
        }
    }
}
