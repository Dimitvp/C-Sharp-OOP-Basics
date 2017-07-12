using System;

namespace _08.Raw_Data
{
    internal class Cargo
    {
        private string type;
        private int weight;
        public Cargo(int weight, string type)
        {
            this.type = type;
            this.weight = weight;
        }

        public string Type
        {
            get { return this.type; }

        }
        public int Weight
        {
            get { return this.weight; }
        }
    }
}