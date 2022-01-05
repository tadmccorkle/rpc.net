namespace TestLib.Other
{
    /// <summary>
    /// This is a summary of the class.
    /// </summary>
    /// <remarks>
    /// And some remarks.
    /// </remarks>
    public class Class1
    {
        /// <summary>
        /// This method does things.
        /// </summary>
        /// <param name="boolean">A parameter.</param>
        public int MyMethod(bool boolean)
        {
            if (boolean)
            {
                if (!boolean)
                {
                    System.Console.WriteLine("This is testing that code coverage works.");
                }
                return 1;
            }
            return 2;
        }
    }
}
