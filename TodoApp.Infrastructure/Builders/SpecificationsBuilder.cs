namespace TodoApp.Infrastructure.Builders
{
    using System.Collections.Generic;
    using TodoApp.Infrastructure.Interfaces;

    public class SpecificationsBuilder<T>
    {
        private List<ISpecification<T>> specifications;

        public SpecificationsBuilder()
        {
            this.specifications = new List<ISpecification<T>>();
        }

        public SpecificationsBuilder<T> AddSpecification(ISpecification<T> specification)
        {
            this.specifications.Add(specification);
            return this;
        }

        public List<ISpecification<T>> Build()
        {
            return this.specifications;
        }
    }
}
