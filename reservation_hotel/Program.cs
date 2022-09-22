using reservation_hotel.Core;
using reservation_hotel.Messages;
using reservation_hotel.Services;
using reservation_hotel.Strings;
//Start Program
var hotel = new HotelProgram(StartHotelService.CreateHotel());

Messages.StartProgramMessage();

int manipulator ;
do
{
    Messages.FirstMenuMessage();
    manipulator = ConvertCheckService.ParseIntCheck();
	if (manipulator == -1 || manipulator == 4) {
        
        continue;
    } else if (manipulator < -1 || manipulator > 4)
        MessagesCustom.MessageDelayClear(StringShort.InvalidOption);



} while (!(manipulator == 4));

