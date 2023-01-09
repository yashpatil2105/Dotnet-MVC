namespace DataAccessLayer;
using BussinessObjectLayer;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DetailsManager{
    
    public static void WriteJson(User user)
    {    
        try{
        List<User> users =(List<User>)GetDetails();
        users.Add(user);
        var options =new  JsonSerializerOptions {IncludeFields = true};
        var usersJson = JsonSerializer.Serialize<List<User>>(users,options);
        string fileName = @"H:\Medic-Angel\MedicAngel\MedicAngelWebApp\wwwroot\data\data.json";
        File.WriteAllText(fileName,usersJson);
        }catch(Exception exp){
          Console.WriteLine(exp);
        }
    }

    public static List<User> GetDetails(){

        string fileName = @"H:\Medic-Angel\MedicAngel\MedicAngelWebApp\wwwroot\data\data.json";
        string jsonString = File.ReadAllText(fileName);
        List<User> jsonUser = JsonSerializer.Deserialize<List<User>>(jsonString);
        return jsonUser;
    }
    
     public static void Delete(User email)
    {    
        try{
        List<User> users =(List<User>)GetDetails();
        var options =new  JsonSerializerOptions {IncludeFields = true};
        var usersJson = JsonSerializer.Serialize<List<User>>(users,options);
        string fileName = @"H:\Medic-Angel\MedicAngel\MedicAngelWebApp\wwwroot\data\data.json";
        File.WriteAllText(fileName,usersJson);
        }catch(Exception exp){
          Console.WriteLine(exp);
        }
    }

    



}
