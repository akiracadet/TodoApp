namespace TodoApp.Infrastructure.Interfaces
{
    using System;

    public interface ISpecification<T>
    {
        string Error { get; }

        bool IsSatisfied();

        ISpecification<T> SetCondition(Func<T, bool> condition);
    }
}
