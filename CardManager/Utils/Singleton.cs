using CardManagerRepo;
using System;

namespace CardManager
{
    public class Singleton
    {
        #region business
        private static business currentBusiness {get; set; }
        public static void setCurrentBusiness(business b)
        {
            currentBusiness = b;
        }
        public static business getCurrentBusiness()
        {
            if (currentBusiness != null)
                return currentBusiness;
            else
                return null;
        }
        #endregion

        #region user
        private static user currentUser { get; set; }
        public static void setCurrentUser(user u)
        {
            currentUser = u;
        }
        public static user getCurrentUser()
        {
            if (currentUser != null)
                return currentUser;
            else
                return null;
        }
        #endregion
    }
}
