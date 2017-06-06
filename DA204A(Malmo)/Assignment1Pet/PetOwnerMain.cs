using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    /// <summary>
    /// Main class
    /// </summary>
    class PetOwnerMain
    {
        static void Main(string[] args)
        {
            var pet = new Pet();
            pet.EditInformation();
            pet.DisplayInformation();
        }
    }
}
