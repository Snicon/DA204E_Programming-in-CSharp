namespace DA204E_Assignment7.Models
{
    public class Scale
    {
        private string name;
        private decimal ratio;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Ratio
        {
            get { return ratio; }
            set { ratio = value; }
        }

        public Scale(string name, decimal ratio)
        {
            this.name = name;
            this.ratio = ratio;
        }
    }
}
