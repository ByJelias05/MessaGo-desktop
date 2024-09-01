using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessaGo_Desktop.Collections
{
    [FirestoreData]
    public class Solicitud
    {
        [FirestoreProperty]
        public string DOcID { get; set; }

        [FirestoreProperty]
        public string Nombre { get; set; }

        [FirestoreProperty]
        public string UserId { get; set; }

        [FirestoreProperty]
        public string PhotoUrl {  get; set; }
    }
}
