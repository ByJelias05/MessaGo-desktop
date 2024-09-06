using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = Google.Type.DateTime;

namespace MessaGo_Desktop.Collections
{
    [FirestoreData]
    public class Mensajes
    {
        [FirestoreProperty]
        public string Usuario {  get; set; }

        [FirestoreProperty]
        public string Foto { get; set; }

        [FirestoreProperty]
        public string TipoMensaje { get; set; }

        [FirestoreProperty]
        public string Mensaje { get; set; }

        [FirestoreProperty]
        public Timestamp Fecha { get; set; }

        [FirestoreProperty]
        public string StatusMsg { get; set; }
        

    }
}
