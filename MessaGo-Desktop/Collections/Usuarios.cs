using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace MessaGo_Desktop.Collections
{
    [FirestoreData]
    public class Users
    {
        [FirestoreProperty]
        public string ID { get; set; }

        [FirestoreProperty]
        public string CompleteName { get; set; }

        [FirestoreProperty]
        public string UserID { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string PassWord { get; set; }

        [FirestoreProperty]
        public string PhotoUrl { get; set; }

        [FirestoreProperty]
        public string StatuUSer {  get; set; }

        [FirestoreProperty]
        public string LastTime { get; set; }

    }
}
