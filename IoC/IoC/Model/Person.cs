namespace IoC.Model
{
    public class Person
    {
        #region Properties
        public Job Job { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor (DI X)
        /// </summary>
        public Person()
        {
            Job = new Job() { Name = "" };
        }

        /// <summary>
        /// Constructor (DI O)
        /// </summary>
        /// <param name="job"></param>
        public Person(Job job)
        {
            Job = job;
        }
        #endregion

        #region Functions
        public override string ToString() => Job.ToString();
        #endregion
    }
}
