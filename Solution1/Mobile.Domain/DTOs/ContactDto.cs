using Mobile.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Domain.DTOs
{
    public class ContactDto

    {

        public ContactTypeEnum  ContactType { get; set;}

        public string Description { get; set;}
   

    }
}
