using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Invitations:BaseEntity
    {
        private Flight invitationFlight;
        public Flight InvitationFlight { get => invitationFlight;set => invitationFlight = value; }
        private Passenger invitationPassenger;
        public Passenger InvitationPassenger { get => invitationPassenger; set => invitationPassenger = value; }

    }
}
