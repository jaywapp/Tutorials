namespace IoC.Model
{
    public class Job
    {
        #region Properties
        public string Name { get; set; }
        #endregion

        #region Functions
        public override string ToString() => Name;
        #endregion
    }
}
