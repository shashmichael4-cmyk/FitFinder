using System.Data.OleDb;
using System.Data;

namespace FitFinderWEB.FitFinderORM
{
    public class DbContext : IDbContext
    {

        OleDbConnection dbConnection;    //יוצר קשר עם מסד נתונים Access
        OleDbCommand dbCommand;          //מבצע פעולות על מסד נתונים Access
        OleDbTransaction dbTransaction; 

        public DbContext()
        {
            this.dbConnection = new OleDbConnection();
            this.dbConnection.ConnectionString = @"";
        }


        public void openDb()
        {
            throw new NotImplementedException();
        }

        public void closeDb()
        {
            throw new NotImplementedException();
        }

        public IDataReader Read(string sql)
        {
            throw new NotImplementedException();
        }

        public int Insert(string sql)
        {
            throw new NotImplementedException();
        }

        public int Update(string sql)
        {
            throw new NotImplementedException();
        }

        public int Delete(string sql)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

    }
}
