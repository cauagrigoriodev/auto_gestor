namespace auto_gestor.Models // Define o namespace "auto_gestor.Models", onde a classe ClienteModel será localizada.
{
    // Criação da model e atributos
    public class ClienteModel // Define a classe "ClienteModel", que representa o modelo de dados de um cliente.
    {
        public int Id { get; set; } // Propriedade que armazena o identificador único do cliente (geralmente gerado automaticamente pelo banco de dados).
        public string Name { get; set; } // Propriedade para armazenar o nome do cliente.
        public string Cpf { get; set; } // Propriedade para armazenar o CPF do cliente.
        public string Endereco { get; set; } // Propriedade para armazenar o endereço do cliente.
        public DateTime Data_Nasc { get; set; } // Propriedade para armazenar a data de nascimento do cliente.
        public string Telefone { get; set; } // Propriedade para armazenar o número de telefone do cliente.
        public string Email { get; set; } // Propriedade para armazenar o e-mail do cliente.
        public string Categoria { get; set; } // Propriedade para armazenar a categoria do cliente (pode ser uma classificação, como "A", "B", etc.).
    }
}
