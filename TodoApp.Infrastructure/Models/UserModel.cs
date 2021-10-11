namespace TodoApp.Infrastructure.Models
{
    using System.Collections.Generic;

    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TodoModel> Todos { get; set; }
    }
}
