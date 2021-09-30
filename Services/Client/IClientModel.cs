using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Client
{
    public interface IClientModel
    {        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime InscriptionDate { get; set; }
        public int Age { get; set; }
    }
}
