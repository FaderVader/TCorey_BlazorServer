using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.UserInfo
{
    public partial class Directory
    {
        public List<PersonModel> People { get; set; }

        public Directory()
        {
            People = new List<PersonModel> {

            new PersonModel
            {
                FirstName = "Jakob",
                LastName = "Viggo",
                Adresses = new List<AddressModel>
            {
                new AddressModel
                {
                    AddressType = "Home",
                    StreetAddress="Strindbergsvej 90",
                    City="Valby",
                    State="København",
                    ZipCode="2500"
                },
                new AddressModel
                {
                    AddressType = "Work",
                    StreetAddress="Emil Kanel 69",
                    City="Ærestaden",
                    State="København",
                    ZipCode="0999"
                }
            }
            },
            new PersonModel
            {
                FirstName = "Lars",
                LastName = "Vødder",
                Adresses = new List<AddressModel>
            {
                new AddressModel
                {
                    AddressType = "Home",
                    StreetAddress="Viggosvej 90",
                    City="Nørrenrop",
                    State="København",
                    ZipCode="5555"
                },
                new AddressModel
                {
                    AddressType = "Work",
                    StreetAddress="BorisJensenvej 89",
                    City="Nykøbing",
                    State="Falster",
                    ZipCode="5556"
                }
            }
            },
            new PersonModel
            {
                FirstName = "Ingen",
                LastName = "Hjemme",
                Adresses = new List<AddressModel>()
            }
        };
        }
    }
}
