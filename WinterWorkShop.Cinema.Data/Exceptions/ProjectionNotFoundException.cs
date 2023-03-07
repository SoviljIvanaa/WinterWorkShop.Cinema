

namespace WinterWorkShop.Cinema.Data.Exceptions
{
    internal class ProjectionNotFoundException : Exception
    {
        public ProjectionNotFoundException() { }

        public ProjectionNotFoundException(int movieId) : base(String.Format($"Projection with that MovieId : {movieId} not found"))
        {

        }
    }
}
