namespace patronesDiseno
{
    internal class singleton
    {
        private static singleton instance = null;
        public string mensaje = "";
        protected singleton()
        {
            mensaje = "hola mundo";
        }
        public static singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new singleton();

                return instance;
            }
        }
    }
}
