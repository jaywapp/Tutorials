using System.Windows.Media;

namespace mvvm.Model
{
    public class RGBColor
    {
        #region Properties
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        #endregion
    }
    public class Job
    {
        public string Name { get; set; }
    }

    public class Person
    {
        public Job Job { get; set; }

        public Person(Job job)
        {
            Job = job;
        }
    }
}
