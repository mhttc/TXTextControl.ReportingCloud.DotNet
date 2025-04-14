namespace TXTextControl.ReportingCloud
{
    public class Processing
    {
        ReportingCloud m_Parent;

        public Processing(ReportingCloud Parent)
        {
            m_Parent = Parent;
        }

        public Review Review => new Review(m_Parent);
    }
}
