public class TodoItemDTO
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemDTO() {}
    public TodoItemDTO(Todo todoItem) => (Id, Title, IsComplete) = (todoItem.Id, todoItem.Title, todoItem.IsComplete);
}