using System;

namespace studiomoderna.Models.Model
{
    internal class TabelAttribute : Attribute
    {
        private string v;

        public TabelAttribute(string v)
        {
            this.v = v;
        }
    }
}