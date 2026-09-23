namespace BT4_4_FastFoodOrder
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FastFoodForm());
        }
    }
}