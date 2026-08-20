using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_PracticeForm
{
    abstract class CrewMember
    {

        //propeties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    

        //constructor
        public CrewMember(int Id, string Name, string Role)
        {
            this.Id = Id;
            this.Name = Name;
            this.Role = Role;
        }

        //abstract method
        public abstract void PerformDuty();
    }
}
