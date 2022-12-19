namespace Shapes
{
    /// <summary>
    /// Represents an abstract Shape class
    /// which is the parent for Triangle, Circle
    /// and other geometrical shape classes.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Represents the area of a shape.
        /// </summary>
        public abstract double Area { get; }
    }
}