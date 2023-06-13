namespace ValueVsReferance
{
    public class DataProvider
    {
        private static Lazy<DataProvider> _dataProvider = new Lazy<DataProvider>(() =>
        {
            Console.WriteLine("Instance created...");
            return new DataProvider();
        });

        private DataProvider()
        {

        }

        public static DataProvider GetInstance()
        {
            return _dataProvider.Value;
        }
    }
}
