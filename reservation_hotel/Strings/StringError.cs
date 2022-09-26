using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Strings
{
    public static class StringError
    {
        public static readonly string FileRoomsNotFound = "O arquivo com os quartos não foi encontrado";
        public static readonly string FileUsersNotFound = "O arquivo com os usuarios não foi encontrado";
        public static readonly string FileOrderActivesNotFound = "O arquivo com os ordens ativas não foi encontrado";
        public static readonly string FileOrderFinishNotFound = "O arquivo com os ordens finalizadas não foi encontrado";
        public static readonly string ValueIsNotInteger = "Error, confira o valor digitado e tente novamente.";
        public static readonly string PhoneIsNotValid = "O Numero digitado não é um telefone valido.";
        public static readonly string CpfIsNotValid = "O Numero digitado não é um Cpf valido.";
        public static readonly string UserIsRegister = "Este cliente ja esta cadastrado.";
        public static readonly string UserIsNotRegister = "Este cliente não foi encontrado em nossos registros.";
        public static readonly string ValueBiggerZero = "O numero precisa ser mais que zero.";
        public static readonly string ValueIsNotDecimal = "O numero digitado não é um valor monetario.";
        public static readonly string ValueBiggerZeroDecimal = "O valor da diaria precisa ser superior a zero.";
        public static readonly string RoomIsRegister = "Este quarto ja esta cadastrado.";
        public static readonly string RoomIsNotRegister = "Este quarto não foi encontrado em nossos registros.";
    }
}
