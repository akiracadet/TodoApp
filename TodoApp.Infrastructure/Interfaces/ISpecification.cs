namespace TodoApp.Infrastructure.Interfaces
{
    using System;

    public interface ISpecification<T>
    {
        bool IsSatisfied();
    }
}
