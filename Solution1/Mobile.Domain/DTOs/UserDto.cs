using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Domain.DTOs
{
    public class UserDto
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime BirthDate { get; set; }

        public AddressDto Address { get; set; }

        public IEnumerable<ContactDto> Contacts { get; set; }

    }
}
