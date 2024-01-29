namespace BiographicCapture.Shared
{
    public class FieldGroup
    {
        public string Name { get; set; } = string.Empty;
        public List<Field> Fields { get; set; } = new();
    }
}
