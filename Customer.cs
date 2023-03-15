using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1KnowledgeCheck2
{
    public class Customer : Person
    {
        public int ID { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}. ID: {ID}, Active customer: {Active}";
        }
    }
}
