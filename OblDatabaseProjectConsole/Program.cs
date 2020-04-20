using OblDatabaseOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OblDatabaseProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Read
            //ManageFacilities.ReadFacilities();

            //// Insert
            //ManageFacilities.ReadFacilities();
            //ManageFacilities.CreateFacility(new Facility() { Facility_No = 8, Name = "Ballpit" });
            //ManageFacilities.ReadFacilities();

            // Update
            //Facility obj = new Facility() { Facility_No = 7, Name = "Playground" };
            //ManageFacilities.UpdateFacility(obj.Facility_No, obj);

            //// Delete
            //ManageFacilities.DeleteFacility(6);


            // SHOW ET VIEW
            //ManageFacilities.ShowBookingsView();


            ManageFacilities.ReadFacilities();
            Console.ReadLine();

        }
    }
}
