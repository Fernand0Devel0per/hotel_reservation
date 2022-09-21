using reservation_hotel.Core;
using reservation_hotel.Messages;
using reservation_hotel.Services;
//Start Program
var hotel = new HotelProgram();

//Recovery data hotel
hotel.Hotel = StartHotelService.CreateHotel();


Messages.StartProgramMessage();