using dal;
using models;
namespace bll;


public static class Service{
    
    public static string Insertdata(int id,string name,string mobile)
    {
         return DBmanager.Insertdata(id,name,mobile);
    }
     public static string Updatedata(int id,string name,string mobile)
    {

        return DBmanager.Updatedata(id,name,mobile);
    }

    public static string Deletedata(int id)
    {
 
        return DBmanager.Deletedata(id);
    }
    
     public static List<Student> getall()
    {
        return DBmanager.Getall();
    }
} 