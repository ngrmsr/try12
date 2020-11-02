using System;

namespace try12
{
    public class Car : IStor
    {
        public string name { get; set; }
        public int Price { get; set; }
        public int weight { get; set; }
        public void Visit(Ivisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
