using System.Data.SQLite;
using SqliteDAL.DataContextObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCHFramework;
using System.Data;
using System.Data.Entity;
using MP3OrganizerBusinessLogic;
using SqliteDAL.DataObjects;
using System.IO;

namespace SqliteDAL
{
    public class AdminRepository
    {
        private readonly AdminDbContext _adminContext;
        private readonly string _dbFileName;
        //private readonly SQLiteConnection conn;
        public AdminRepository(string dbFileName, ref OperationResult op)
        {
            try
            {
                _dbFileName = dbFileName;
                _adminContext = new AdminDbContext(dbFileName);

                // Create a new database connection:
                //conn = new SQLiteConnection($"Data Source={dbFileName}; Version = 3; New = True; Compress = True; ");
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        public User Login(string username, string password, ref OperationResult op)
        {
            var user = (from u in _adminContext.User
                        where username.Trim().Equals(u.UserName, StringComparison.InvariantCultureIgnoreCase) &&
                            password.Equals(u.Password)
                        select u).FirstOrDefault();
            if(user == null)
            {
                op.AddError("Incorrect username or password.");
            }
            return user;
        }
    }
}
