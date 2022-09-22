using reservation_hotel.Core;
using reservation_hotel.Messages;
using reservation_hotel.Services;
using reservation_hotel.Strings;
//Start Program
var hotel = new HotelProgram(StartHotelService.CreateHotel());

Message.StartProgramMessage();

int manipulator ;
do
{
    Message.FirstMenuMessage();
    manipulator = ConvertCheckService.ParseIntCheck();
    if (!ConditionsService.OptionIsValid(manipulator))
        continue;
    else
        hotel.Options(manipulator);


} while (!(manipulator == 4));

