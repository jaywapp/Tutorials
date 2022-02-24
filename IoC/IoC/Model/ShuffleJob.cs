using System;

namespace IoC.Model
{
    public class ShuffleJob : Job
    {
        public ShuffleJob()
        {
            var random = new Random();
            var value = random.Next();

            switch (value % 3)
            {
                case 0:
                    Name = "Singer";
                    break;
                case 1:
                    Name = "Doctor";
                    break;
                case 2:
                    Name = "Software Developer";
                    break;
                default:
                    break;
            }
        }
    }
}
