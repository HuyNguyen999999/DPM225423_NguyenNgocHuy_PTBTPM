namespace DPM225423_NguyenNgocHuy_Myworld06_Bridge
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    public abstract class DataSource
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract string GetCurrentRecord();
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}