namespace TestLib
{
    /// <summary>
    /// This is a summary
    /// </summary>
    /// <remarks>
    /// And some remarks.
    /// </remarks>
    public class Class1
    {
        /// <summary>
        /// This is an object.
        /// </summary>
        /// <value>The value of the object.</value>
        public object MyObj { get; set; }

        /// <summary>
        /// This method does things.
        /// </summary>
        /// <param name="boolean">A parameter.</param>
        public int MyMethod(bool boolean, bool other = false)
        {
            if (other)
                return 1;
#if NETSTANDARD
            if (boolean)
            {
                return 2;
            }
            return 3;
#endif
#if NETFRAMEWORK
            for (int i = 0; i < 10; i++)
            {
                if (boolean)
                    return 4;
            }
            return 5;
#endif
        }
    }
}
