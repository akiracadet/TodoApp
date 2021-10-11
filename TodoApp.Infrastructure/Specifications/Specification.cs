namespace TodoApp.Infrastructure.Specifications
{
    using System;
    using TodoApp.Infrastructure.Interfaces;

    public class Specification<T> : ISpecification<T>
    {
        private T Entity { get; set; }

        private Func<T, bool> Condition { get; set; }

        public string Error { get; }

        public Specification(T entity, string error)
        {
            this.Entity = entity;
            this.Error = error;

            this.Condition = (entity) =>
            {
                throw new NotImplementedException("No Condition Set");
            };
        }

        public Specification(T entity, string error, Func<T, bool> condition)
        {
            this.Entity = entity;
            this.Error = error;
            this.Condition = condition;
        }

        public bool IsSatisfied()
        {
            return this.Condition(this.Entity);
        }

        public ISpecification<T> SetCondition(Func<T, bool> condition)
        {
            this.Condition = condition;
            return this;
        }
    }
}
