using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BayerHealthCare_System.MessageContracts
{

    public class bayerHealthCare
    {
        [BsonId]
        public string _id { get; set; } 

        public appointment appointment { get; set; }
    }

    public class appointment
    {
        public Doctor[] doctor { get; set; }
    }
    public class Doctor
    {
        public int docid { get; set; }
        public string name { get; set; }
        public Patient[] patient { get; set; }
    }

    public class Patient
    {
        public int id { get; set; }
        public string pname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string apptDate { get; set; }
        public string apptTime { get; set; }
    }



}
