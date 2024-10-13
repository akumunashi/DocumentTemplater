namespace Database.Interfaces
{
    public interface IDatabaseConnection<T> where T : class
    {
        void Add(T entity);
    }
}
