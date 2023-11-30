using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public class Literature
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private string Writer { get; set; }
        private string Year { get; set; }

        public string id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string writer
        {
            get
            {
                return Writer;
            }
            set
            {
                Writer = value;
            }
        }

        public string year
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }
    }
}
