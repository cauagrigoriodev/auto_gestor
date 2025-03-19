namespace auto_gestor.Models
{
    // Criação da mmodel e atributos
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Categoria { get; set; }

    }
}
