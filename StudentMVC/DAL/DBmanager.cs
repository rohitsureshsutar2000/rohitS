using models;
using MySql.Data.MySqlClient;
namespace dal;

public static class DBmanager{
    static string conString="server=localhost;port=3306;user=root;password=Atpadi@123;database=rohit";
    public static List<Student> Getall()
    {
        List<Student> lst= new List<Student>();
        string query="select * from Students";
        MySqlConnection conn =new MySqlConnection();
        conn.ConnectionString=conString;
        try{
            
            MySqlCommand cmd=new MySqlCommand(query,conn);
            conn.Open();
            MySqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                int id=int.Parse(dr["Id"].ToString());
                string name=dr["Name"].ToString();
                string mobile=dr["Mobile"].ToString();
                Student s=new Student{Id=id,Name=name,Mobile=mobile};
                lst.Add(s);
            }

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }

        return lst;
    }
    public static string Insertdata(int Id,string Name,string Mobile)
    {
        
        string query="insert into students values('"+Id+"','"+Name+"','"+Mobile+"')";
        MySqlConnection conn =new MySqlConnection();
        conn.ConnectionString=conString;
        try{
            
            MySqlCommand cmd=new MySqlCommand(query,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }

        return "Data added...";
    }
    public static string Updatedata(int Id,string Name,string Mobile)
    {
        Console.WriteLine("heee");
        
        string query="update students set Name='"+Name+"', Mobile='"+Mobile+"' where Id="+Id;
        MySqlConnection conn =new MySqlConnection();
        conn.ConnectionString=conString;
        try{
            conn.Open();
            MySqlCommand cmd=new MySqlCommand(query,conn);
            
            cmd.ExecuteNonQuery();
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }

        return "Data updated...";
    }
    public static string Deletedata(int Id)
    {
        Console.WriteLine("heee");
        
        string query="delete from students where id="+Id;
        MySqlConnection conn =new MySqlConnection();
        conn.ConnectionString=conString;
        try{
            conn.Open();
            MySqlCommand cmd=new MySqlCommand(query,conn);
            
            cmd.ExecuteNonQuery();
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }

        return "Data deleted...";
    }
}