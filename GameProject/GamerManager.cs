using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        public void Add(User user)
        {
            Console.WriteLine("Kayıt oldu");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
