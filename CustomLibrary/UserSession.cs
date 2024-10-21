using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public static class UserSession
    {
        private static int loggedInUserID = 0; // Initialize to 0

        public static int LoggedInUserID
        {
            get { return loggedInUserID; }
        }

        public static void SetLoggedInUserID(int userID)
        {
            loggedInUserID = userID;
        }

        public static void ClearLoggedInUserID()
        {
            loggedInUserID = 0; // Reset to 0 when a user logs out
        }
    }

}
