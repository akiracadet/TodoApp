namespace TodoApp.Infrastructure.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using TodoApp.Infrastructure.Interfaces;

    public static class SpecificationsExtensions
    {
        public static bool IsSatisfied<T>(this List<ISpecification<T>> specifications)
        {
            var result = specifications.All(spec => spec.IsSatisfied());
            return result;
        }

        public static IEnumerable<string> Errors<T>(this List<ISpecification<T>> specifications)
        {
            var result = specifications.Where(spec => !spec.IsSatisfied()).Select(spec => spec.Error);
            return result;
        }
    }
}
