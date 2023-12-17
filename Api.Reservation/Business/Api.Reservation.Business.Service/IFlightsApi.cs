using Api.Reservation.Business.Models;
using Refit;

namespace Api.Reservation.Business.Service
{
    public interface IFlightsApi
    {
        /*  [Get("/api/Flights/{numeroVol}/siege/{nomSiege}")]
          Task<Seat> GetSiegeStatusAsync(string numeroVol, string nomSiege);*/

        [Get("/flight/getByFlightNumber/{flightNumber}/")]
        Task<Seat> GetFlightNumberAsync(string numeroVol);
    }
}