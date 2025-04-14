using System;

namespace TXTextControl.ReportingCloud
{
    /// <summary>
    /// This class provides the structure of a modified document returned when a tracked change is removed.
    /// </summary>
    public class TrackedChangeModifiedDocument
    {
        public byte[] Document { get; set; }
        public bool Removed { get; set; }
    }

    /// <summary>
    /// This class provides the structure of a TrackedChange object.
    /// </summary>
    public class TrackedChange
    {
        public ChangeKind ChangeKind { get; set; }
        public DateTime ChangeTime { get; set; }

        public string DefaultHighlightColor { get; set; }
        public string HighlightColor { get; set; }

        public HighlightMode HighlightMode { get; set; }
        public int Length { get; set; }
        public int Start { get; set; }
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
    }

    /// <summary>
    /// This enumeration defines the kind of a tracked change.
    /// </summary>
    public enum ChangeKind
    {
        InsertedText = 4096,
        DeletedText = 8192
    }

    /// <summary>
    /// This enumeration defines the highlight mode for a tracked change.
    /// </summary>
    public enum HighlightMode
    {
        Never = 1,
        Activated = 2,
        Always = 3
    }
}
