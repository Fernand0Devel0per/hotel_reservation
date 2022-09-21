using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Messages
{
    public static class Messages
    {
        public static void StartProgramMessage()
        {
            MessagesCustomTime.MessageDelayClear(StringLong.StartProgram, 3);
            MessagesCustomTime.MessageDelaySeconds(StringLong.WelcomeProgram, 1);

        }
    }
}
