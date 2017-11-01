using System;
using System.Windows.Forms;
using UserApp.src.Model;

namespace UserApp
{
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                User newUser = new User(nameTextbox.Text, cpfTextBox.Text, birthDatePicker.Value);
                MessageBox.Show("Usuário cadastrado com sucesso! " + newUser + "\n");
            }
            else
            {
                MessageBox.Show("Algum campo não foi preenchido corretamente");
            }
        }

        private void cpfTextBox_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cpfTextBox, "");
        }

        private void cpfTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UserValidations.IsCpfValid(cpfTextBox.Text))
            {
                this.errorProvider1.SetError(cpfTextBox, "");
            }
            else
            {
                e.Cancel = true;
                this.errorProvider1.SetError(cpfTextBox, "CPF inválido");
            }
        }

        private void birthDatePicker_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(birthDatePicker, "");
        }

        private void birthDatePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UserValidations.IsBirthDateValid(birthDatePicker.Value))
            {
                this.errorProvider1.SetError(birthDatePicker, "");
            }
            else
            {
                e.Cancel = true;
                this.errorProvider1.SetError(birthDatePicker, "Data de aniversário inválida");
            }
        }
    }
}
