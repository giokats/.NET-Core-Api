namespace Api.Domain.Common
{
    public abstract class EntityBase<TKey>
    {
        public TKey Id { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        protected EntityBase() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="id"></param>
        protected EntityBase(TKey id)
        {
            Id = id;
        }
    }
}
