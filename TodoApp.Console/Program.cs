namespace TodoApp.Console
{
    using System;
    using TodoApp.Infrastructure.Builders;
    using TodoApp.Infrastructure.Extensions;
    using TodoApp.Infrastructure.Models;
    using TodoApp.Infrastructure.Specifications;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            SpecificationExperiment();
        }

        internal static void SpecificationExperiment()
        {
            var todo = new TodoModel { Id = 0 };
            //var spec = new Specification<TodoModel>(todo, "I have an error", (todo) => todo.Id == 0);
            var spec = new Specification<TodoModel>(todo, "I have an error")
                .SetCondition((todo) =>
                {
                    return todo.Id == 0;
                });

            var specs = new SpecificationsBuilder<TodoModel>()
                .AddSpecification(spec)
                .AddSpecification(spec)
                .AddSpecification(spec)
                .Build();

            if (specs.IsSatisfied())
            {
                Console.WriteLine("Satisfied");
            }
            else
            {
                foreach (var error in specs.Errors())
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
}
