namespace Dtos
{
    public record CreateNoteDto
    {
        public string Name { get; init; }

        public string Surname { get; init; }

        public string Description { get; init; }

        public string AuthorName { get; init; }

        public string Nickname { get; init; }
    }
}