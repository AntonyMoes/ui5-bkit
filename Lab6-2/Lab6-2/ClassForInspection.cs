namespace Lab6_2
{
    public class ClassForInspection
    {
        public ClassForInspection() { }
        public ClassForInspection(string str) { }
        public ClassForInspection(double d) { }

        public double Divide(double a, double b)
        {
            return a / b;
        }
        
        [NewAttribute("Описание для prop1")]
        public int prop1 { get; set; }
        
        [NewAttribute("Описание для prop2")]
        public int prop2 { get; set; }
        
        public int prop3 { get; set; }

        public int[] data;
    }
}