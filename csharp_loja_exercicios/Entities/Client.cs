using System.Text;

namespace csharp_loja_exercicios.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append($" ({BirthDate.ToString("dd/MM/yyyy")}) - ");
            stringBuilder.Append(Email);

            return stringBuilder.ToString();
        }
    }
}
