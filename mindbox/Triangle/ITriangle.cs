namespace mindbox.Triangle
{
    public interface ITriangle : IClosedFigure
    {
        /// <summary>
        /// Является ли правильным треугольником
        /// </summary>
        /// <returns>Является ли правильным треугольником</returns>
        public bool IsRightTriangle();

    }
}
