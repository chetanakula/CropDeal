using CropAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropAPI.Repository
{
    public class LoginRepository : ILoginRepository
    {
        CropsEntities _cropDealDbEntities = null;
        public UserProfile VerifyLogin(string email, string Password)
        {
            UserProfile userProfile = null;
            try
            {
                var checkValidUser = _cropDealDbEntities.UserProfiles.Where(m => m.Email == email &&
            m.Password == Password).FirstOrDefault();
                if (checkValidUser != null)
                {
                    userProfile = checkValidUser;
                }

                else
                {
                    userProfile = null;
                }
            }
            catch (Exception ex)
            {
            }
            return userProfile;
        }

        public UserProfile VerifyLogin(object email, object password)
        {
            throw new NotImplementedException();
        }

        public LoginRepository(CropsEntities cropDealDbEntities)
        {
            this._cropDealDbEntities = cropDealDbEntities;
        }
    }
}