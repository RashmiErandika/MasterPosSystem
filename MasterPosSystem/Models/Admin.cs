using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterPosSystem.Models
{
    public class Admin : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Contact_Number { get; set; }


    }
}