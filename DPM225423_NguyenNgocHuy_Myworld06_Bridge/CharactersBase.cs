namespace DPM225423_NguyenNgocHuy_Myworld06_Bridge
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class CharactersBase
    {
        private DataSource dataSource;

        public DataSource Data
        {
            set { dataSource = value; }
            get { return dataSource; }
        }

        public virtual void Next()
        {
            dataSource.NextRecord();
        }

        public virtual void Prior()
        {
            dataSource.PriorRecord();
        }

        public virtual void Add(string character)
        {
            dataSource.AddRecord(character);
        }

        public virtual void Delete(string character)
        {
            dataSource.DeleteRecord(character);
        }

        public virtual void Show()
        {
            dataSource.ShowRecord();
        }

        public virtual void ShowAll()
        {
            dataSource.ShowAllRecords();
        }
    }
}