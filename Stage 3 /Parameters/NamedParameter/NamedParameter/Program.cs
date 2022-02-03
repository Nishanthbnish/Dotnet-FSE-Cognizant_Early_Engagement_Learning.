using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCohortDetails("ADM002", 21, "OBL", ".Net", ".Net core");

            GetCohortDetails("ADM002", 21, ".Net", ".Net core", "OBL");

            GetCohortDetails(cohortName:"ADM002", genCCount:21, track:".Net", currentModule:".Net core", mode:"OBL");
        }

        static void GetCohortDetails(string cohortName, int genCCount, string mode, string track, string currentModule)
        {
            Console.WriteLine($"It is {cohortName} with {genCCount} GenCs undergoing training for {track} thru {mode}. The current module of training is {currentModule}");
        }
    }
}
