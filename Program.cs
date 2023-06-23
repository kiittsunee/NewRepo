using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class program
    {

        static void Main(string[] args)
        {
            List<TodoItemDTO> lst2 = new List<TodoItemDTO>();//лист, который нужно заполнить обьектами из другого листа 
            List<TodoItem> lst = new List<TodoItem>(); //другой лист
            lst.Add(new TodoItem() { Id = 1, Name = "test_1", IsComplete = false, Secret = "secret_1" });
            lst.Add(new TodoItem() { Id = 2, Name = "test_2", IsComplete = false, Secret = "secret_2" });
            lst.Add(new TodoItem() { Id = 3, Name = "test_3", IsComplete = false, Secret = "secret_3" });
            lst.Add(new TodoItem() { Id = 4, Name = "test_4", IsComplete = false, Secret = "secret_4" });
            foreach (TodoItem e in lst)
            {
                Console.WriteLine($"Id: {e.Id} - Name: {e.Name} - IsComplete: {e.IsComplete} - Secret: {e.Secret}");
            }


            foreach (TodoItem t in lst)
            {
                TodoItemDTO example = new TodoItemDTO(t);
                lst2.Add(example);
            }
            for (int i = 0; i < lst.Count; i++)
            {
                TodoItemDTO example = new TodoItemDTO(lst[i]);
                lst2.Add(example);
            }
            foreach (TodoItemDTO e in lst2)
            {
                Console.WriteLine($"Id: {e.Id} - Name: {e.Name} - IsComplete: {e.IsComplete} ");
            }
        }
    }
}
