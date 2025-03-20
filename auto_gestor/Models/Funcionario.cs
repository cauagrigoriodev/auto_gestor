namespace auto_gestor.Models // Define o namespace "auto_gestor.Models", onde os modelos de dados estão localizados.
{
    // Criando a Model "Funcionario" e colocando atributos.
    public class Funcionario
    {
        // Propriedade para armazenar o ID do funcionário.
        public int Id { get; set; }

        // Propriedade para armazenar o nome do funcionário.
        public string? Name { get; set; }
    }
}
