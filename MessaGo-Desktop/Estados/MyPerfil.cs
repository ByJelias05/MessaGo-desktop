using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessaGo_Desktop.Estados
{
    public class MyPerfil
    {
        public static string DocID {  get; set; } 
        public static string Nombre { get; set; }
      
        public static string UserId { get; set; }

        public static string PhotoUrl { get; set; }
    }
}
