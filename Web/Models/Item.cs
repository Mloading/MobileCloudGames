namespace Web.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Descricao { get; set; }

        public string Origem { get; set; }

        // Relacionamento item -- TipoItem
        public int TipoItemID { get; set; }

        public virtual TipoItem _TipoItem { get; set; }

    }
}