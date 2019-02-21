using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PeopleService.Service
{
    public class Authenticator : UserNamePasswordValidator
    {
        //public Authenticator()
        //{
        //    throw new Exception();
        //}

        public override void Validate(string userName, string password)
        {
            if (userName != "peoplesite" || password != "password")
            {
                throw new FaultException("Invalid user and/or password 123");
            }
        }
    }
}