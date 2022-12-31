using Mobile.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Domain.Entities
{
    public class User : BaseEntity
    {

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime BirthDate { get; set; }

       
    }
}
