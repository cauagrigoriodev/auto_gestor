namespace auto_gestor.Models
{
    public class Pagamentos
    {
     public int Id { get; set; }
     public string Metodo_Pagamento { get; set; }
     public DateTime Data_Inicio { get; set; }
     public DateTime Data_Vencimento { get; set; }
     public string Status {  get; set; }

    }
}
