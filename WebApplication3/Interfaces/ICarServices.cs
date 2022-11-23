using System.Collections.Generic;

namespace WebApplication3.Interfaces
{
    public interface ICarServices

    {
        List<string> GetCars();
        List<string> PostCars(string car);
        List<string> DeleteCars(string car);
    }
}
