namespace TodoApp.Infrastructure.Builders
{
    using System.Collections.Generic;
    using TodoApp.Infrastructure.Specifications;

    public class SpecificationsBuilder<T>
    {
        private List<Specification<T>> specifications;

        public SpecificationsBuilder()
        {
            this.specifications = new List<Specification<T>>();
        }

        public SpecificationsBuilder<T> AddSpecification(Specification<T> specification)
        {
            this.specifications.Add(specification);
            return this;
        }

        public List<Specification<T>> Build()
        {
            return this.specifications;
        }
    }
}
