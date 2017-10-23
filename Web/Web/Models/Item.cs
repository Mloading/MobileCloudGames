
namespace Web.Models
{
    public class Item
    {
        public string ItemID { get; set; }

        public int Nome { get; set; }

        public string Descricao { get; set; }

        public int Raridade { get; set; }

        public int DanoMaximo { get; set; }

        //Relacionamento item -= Tipo Item

        public int TipoItemID { get; set; }


        public virtual TipoItem _TipoItem{ get; set; }

    } 
}