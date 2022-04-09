using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class Reservations
    {
        public Reservations()
        {
        }

        public int Id { get; set; }
        public int UserID { get; set; }
        public int MotorbikeID { get; set; }
        public string From_Date { get; set; }
        public string To_Date { get; set; }
        public string Status { get; set; }

        public Reservations(int userID, int motorbikeID, string from_Date, string to_Date, string status)
        {
            UserID = userID;
            MotorbikeID = motorbikeID;
            From_Date = from_Date;
            To_Date = to_Date;
            Status = status;
        }
    }
}
