using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessaGo_Desktop.Collections
{
    [FirestoreData]
    public class Conversacion
    {
        //MyInfo
        [FirestoreProperty]
        public string MyUserId { get; set; }

        [FirestoreProperty]
        public string MyLastTime { get; set; }

        [FirestoreProperty]
        public string MyPhotoUrl { get; set; }

        [FirestoreProperty]
        public string MyStatuUser { get; set; }

        //YouInfo
        [FirestoreProperty]
        public string YouUserId { get; set; }

        [FirestoreProperty]
        public string YouLastTime { get; set; }

        [FirestoreProperty]
        public string YouPhotoUrl { get; set; }

        [FirestoreProperty]
        public string YouStatuUser { get; set; }

    }
}
