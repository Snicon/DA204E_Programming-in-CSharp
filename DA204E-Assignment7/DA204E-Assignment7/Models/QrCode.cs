namespace DA204E_Assignment7.Models
{
    public class QrCode
    {
        private string name;
        private string content;
        private DateTime dateTime;
        private string filePath;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
        }

        public string FilePath
        {
            get { return filePath; }
        }

        public QrCode(string name, string content, DateTime dateTime, string filePath)
        {
            this.name = name;
            this.content = content;
            this.dateTime = dateTime;
            this.filePath = filePath;
        }


    }
}
