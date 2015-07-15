using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Entity;

namespace WindowsFormsApplication1.ServiceReferences
{
    class LoginDaoService
    {
        public UserMstEntity getUserJoho(string userId)
        {
            Int64 Int64userId = int.Parse(userId);

            using (var db = new CallEntityService())
            {
                var q =
                    from a in db.UserMstEntities
                    where a.userId == Int64userId
                    select a;

                return (UserMstEntity)q;
            }
        }

    }
}
