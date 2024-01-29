namespace BiographicCapture.Shared
{
    public class Field
    {
        public string Name { get; set; } = "";
        public FieldType FieldType { get; set; }
        public Dictionary<string, string>? Picklist { get; set; }
        public string? Value { get; set; }
    }
}
