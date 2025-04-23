

namespace BookingProcesses
{
    public class ConstructorMessage
    {
        private String _constructoredMessage = String.Empty;        
        public String ConstructoredMessage
        {
            get { return _constructoredMessage; }
            set { _constructoredMessage = value; }
        }

        private String _templateMessage = String.Empty;
        public String TemplateMessage
        {
            get { return _templateMessage; }
            set { _templateMessage = value; }
        }
    }
}
