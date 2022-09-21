using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Strings
{
    public static class StringOptions
    {
        public static readonly string OptionUser = "(1) Clientes.";
        public static readonly string OptionRoom = "(2) Quartos.";
        public static readonly string OptionReservation = "(3) Reservas";

        public static readonly string ListUser = "(1) Listar Clientes.";
        public static readonly string RegisterUser = "(2) Cadastrar Cliente.";
        public static readonly string RemoveUser = "(3) Excluir Cliente.";

        public static readonly string ListRoom = "(1) Listar Quartos.";
        public static readonly string RegisterRoom = "(2) Cadastrar Quarto.";
        public static readonly string RemoveRoom = "(3) Excluir Quarto.";

        public static readonly string ReservatioActives = "(1) Reservas Ativas";
        public static readonly string ReservatioFinish = "(2) Reservas Terminadas";

        public static readonly string ListReservatioActives = "(1) Listar Reservas Ativas.";
        public static readonly string RegisterReservatioActive = "(2) Cadastrar Reserva.";
        public static readonly string RemoveReservatioActive = "(3) Excluir Reserva.";

        public static readonly string ListReservatioFinish = "(1) Listar Todas Reservas Terminadas.";
        public static readonly string ListReservatioFinishUser = "(2) Listar Reservas Terminadas Por Cliente.";
        public static readonly string ListReservatioFinishRoom = "(3)  Listar Reservas Terminadas Por Quarto.";


    }
}
