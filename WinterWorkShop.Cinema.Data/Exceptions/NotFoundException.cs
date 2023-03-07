namespace WinterWorkShop.Cinema.Data.Exceptions
{
	public class NotFoundException : Exception
	{
		public NotFoundException(int id) :base($"Object with ID {id} not found. ") { }
        
        
        
    }
}
