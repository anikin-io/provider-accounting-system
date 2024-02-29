

namespace ProvaiderEF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormAuthorization());
            //Application.Run(new FormFinishRequest());


            //using (var context = new MyContext())
            //{

            //}
        }
    }
}