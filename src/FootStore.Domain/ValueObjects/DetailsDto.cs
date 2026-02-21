namespace FootStore.Domain.ValueObjects
{
    public class DetailsDto
    {
        public string Size { get; set; } = default!;
        public int Stock { get; set; }
        public bool IsAvailable => Stock > 0;
    }
}