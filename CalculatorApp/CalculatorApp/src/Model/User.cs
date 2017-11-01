using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.src.Model
{
    class User
    {
        private string name;
        private string cpf;
        private DateTime birthDate;

        public User(string name, string cpf, DateTime birthDate)
        {
            this.name = name;
            this.cpf = cpf;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return "Nome: "+ name + "\nCPF: " + cpf + "\nData de Nascimento: " + birthDate.ToShortDateString();
        }
    }
}
