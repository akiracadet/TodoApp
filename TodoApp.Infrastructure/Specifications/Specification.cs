namespace TodoApp.Infrastructure.Specifications
{
    using System;
    using TodoApp.Infrastructure.Interfaces;

    public class Specification<T> : ISpecification<T>
    {
        private T Entity { get; set; }

        private Func<bool> Condition { get; set; }

        public string Error { get; }

        public Specification(T entity, string error, Func<bool> condition)
        {
            this.Entity = entity;
            this.Error = error;
            this.Condition = condition;
        }

        public bool IsSatisfied()
        {
            return this.Condition();
        }
    }
}
