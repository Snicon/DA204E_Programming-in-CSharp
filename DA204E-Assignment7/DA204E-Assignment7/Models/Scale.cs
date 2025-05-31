// Sixten Peterson (AQ9300) 2025-05-26
namespace DA204E_Assignment7.Models
{
    /// <summary>
    /// Model represeing a scale, the scale has a name and a ratio
    /// </summary>
    public class Scale
    {
        // Fields below
        private string name; // name of the scale
        private decimal ratio; // ratio of the scale

        /// <summary>
        /// Name property
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Ratio property
        /// </summary>
        public decimal Ratio
        {
            get { return ratio; }
            set { ratio = value; }
        }

        /// <summary>
        /// Very simple constructor, accepts name and ratio as params
        /// </summary>
        /// <param name="name">the name of the scale</param>
        /// <param name="ratio">the ratio of the scale</param>
        public Scale(string name, decimal ratio)
        {
            // Setting the fields below
            this.name = name;
            this.ratio = ratio;
        }
    }
}
