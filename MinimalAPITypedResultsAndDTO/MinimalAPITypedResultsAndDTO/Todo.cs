namespace MinimalAPITypedResultsAndDTO
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? CreatedBy { get; set; }
    }
}
