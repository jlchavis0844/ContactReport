using System;
using Newtonsoft.Json.Linq;

namespace ContactReport {
    public class Contact {

        public int id { get; set; }
        public int creator_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string customer_status { get; set; }
        public string prospect_status { get; set; }
        public string name { get; set; }

        public Contact(int id, int creator_id, DateTime created_at, DateTime updated_at, 
            string customer_status, string prospect_status, string name) {
            this.id = id;
            this.created_at = created_at;
            this.creator_id = creator_id;
            this.updated_at = updated_at;
            this.customer_status = customer_status;
            this.prospect_status = prospect_status;
            this.name = name;
        }
    }
}