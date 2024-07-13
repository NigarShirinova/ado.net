using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net.Constants
{
    internal enum Operations
    {
        Exit,
        AllCountries,
        AddCountry,
        UpdateCountry,
        DeleteCountry,
        DetailsOfCountry,
        AllCities,
        AllCitiesOfCountry,
        AddCity,
        UpdateCity,
        DeleteCity,
        DetailsOfCity
    }

    public enum CrudOperationType
    {
        Create,
        Add,
        Update,
        Delete
    }
}
