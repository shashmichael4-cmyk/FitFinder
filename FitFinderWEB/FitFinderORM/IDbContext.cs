
using System.Data;



namespace FitFinderWEB.FitFinderORM
{
    public interface IDbContext
    {
        void openDb();

        void closeDb();    
        IDataReader Read(string sql);
        int Insert(string sql); // הכנסת נתונים
        int Update(string sql); // עדכון נתונים
        int Delete(string sql); // מחיקת נתונים

        //טיפול בטטרנזקציה
        void BeginTransaction();

        void Rollback();

        void Commit();
    }
}
