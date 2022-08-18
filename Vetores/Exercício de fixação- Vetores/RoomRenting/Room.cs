using System;
using System.Globalization;

namespace RoomRenting
{
    internal class Room
    {
        public string Nome { get; private set; }
        public string Email { get;  private set; }
        public int NumQuarto { get; private set; }

         public Room(string nome, string email, int i)
        {
            Nome = nome;    
            Email = email;
            NumQuarto = i;  

        } 
    }
}
