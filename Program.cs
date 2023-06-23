using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Lab1
{
    public class program
    {

        static void Main(string[] args)
        {
            // Лист, который нужно заполнить обьектами из другого листа.
            List<TodoItemDto> itemDtos = new List<TodoItemDto>();

            // Другой лист.
            List<TodoItem> items = new List<TodoItem>(); 

            // Заполнение листа.
            items.Add(new TodoItem() { Id = 1, Name = "test_1", IsComplete = false, Secret = "secret_1" });
            items.Add(new TodoItem() { Id = 2, Name = "test_2", IsComplete = false, Secret = "secret_2" });
            items.Add(new TodoItem() { Id = 3, Name = "test_3", IsComplete = false, Secret = "secret_3" });
            items.Add(new TodoItem() { Id = 4, Name = "test_4", IsComplete = false, Secret = "secret_4" });

            foreach (TodoItem item in items)
            {
                Console.WriteLine($"Id: {item.Id} - Name: {item.Name} - IsComplete: {item.IsComplete} - Secret: {item.Secret}");
            }


            /*foreach (TodoItem item in items)
            {
                TodoItemDto fillingItemDto = new TodoItemDto(item);
                itemDtos.Add(fillingItemDto);
            }*/

            for (var i = 0; i < items.Count; i++)
            {
                TodoItemDto fillingItemDto = new TodoItemDto(items[i]);
                itemDtos.Add(fillingItemDto);
            }

            foreach (TodoItemDto item in itemDtos)
            {
               // Console.WriteLine($"Id: {e.Id} - Name: {e.Name} - IsComplete: {e.IsComplete} ");
                Console.WriteLine($"{JsonSerializer.Serialize(item).ToString()}");
            }
        }
    }
}
