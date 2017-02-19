namespace EelDataAPI.XML
{
    public class XMLManagerSingleton
    {
        private static readonly System.Lazy<XMLManager> lazy;

        static XMLManagerSingleton()
        {
            lazy = new System.Lazy<XMLManager>(() => new XMLManager());
        }

        public static XMLManager Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
