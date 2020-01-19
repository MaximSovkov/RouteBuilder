namespace RouteBuilder
{
    /// <summary>
    /// Path model.
    /// </summary>
    public class Path
    {
        /// <summary>
        /// The starting point of the path.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// The endpoint of the path.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Get a convenient representation of the path.
        /// </summary>
        public override string ToString()
        {
            return $"{{ {From}, {To} }}";
        }
    }
}
