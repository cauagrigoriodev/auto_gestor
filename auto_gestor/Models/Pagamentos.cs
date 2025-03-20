namespace auto_gestor.Models // Define o namespace "auto_gestor.Models", onde os modelos de dados estão localizados.
{
    // Criando a Model "Pagamentos" e colocando os atributos necessários para armazenar informações de pagamento.
    public class Pagamentos
    {
        // Propriedade para armazenar o ID do pagamento (identificador único).
        public int Id { get; set; }

        // Propriedade para armazenar o método de pagamento (como cartão de crédito, transferência bancária, etc.).
        public string? Metodo_Pagamento { get; set; }

        // Propriedade para armazenar a data de início do pagamento (quando o pagamento foi iniciado ou registrado).
        public DateTime Data_Inicio { get; set; }

        // Propriedade para armazenar a data de vencimento do pagamento (quando o pagamento deve ser realizado).
        public DateTime Data_Vencimento { get; set; }

        // Propriedade para armazenar o status do pagamento (pode ser "pendente", "pago", "cancelado", etc.).
        public string? Status { get; set; }
    }
}
