namespace AI_Lab_2.common.settings
{
    /// <summary>
    /// Defines the <see cref="EntityCharacteristics" />
    /// </summary>
    internal class EntityCharacteristics
    {
        /// <summary>
        /// Defines the name
        /// </summary>
        private string name;

        /// <summary>
        /// Defines the value
        /// </summary>
        private double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCharacteristics"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/></param>
        /// <param name="value">The value<see cref="double"/></param>
        public EntityCharacteristics(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public double Value { get => value; set => this.value = value; }
    }
}
