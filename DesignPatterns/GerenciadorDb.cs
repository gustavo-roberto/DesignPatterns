
namespace DesignPatterns
{
    public class GerenciadorDb
    {
        private static GerenciadorDb _gerenciadorDb = null;

        private GerenciadorDb() { }

        public static GerenciadorDb GetInstance()
        {
            if(_gerenciadorDb == null)
            {
                _gerenciadorDb = new GerenciadorDb();
            }

            return _gerenciadorDb;
        }

        public string Propriedade { get; set; } = "String Padrão";
    }
}


