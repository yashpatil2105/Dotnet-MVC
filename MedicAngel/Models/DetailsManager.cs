namespace MedicAngel.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Serial{
    
    public static void WriteJson(User user)
    {    
        try{
        List<User> users =(List<User>)GetDetails();
        users.Add(user);
        var options =new  JsonSerializerOptions {IncludeFields = true};
        var usersJson = JsonSerializer.Serialize<List<User>>(users,options);
        string fileName = @"C:\Users\yash\OneDrive\Desktop\College\Medic-Angel\Medic-Angel\MedicAngel\wwwroot\Data\data.json";
        File.WriteAllText(fileName,usersJson);
        }catch(Exception exp){
          
        }
    }

    public static List<User> GetDetails(){

        string fileName = @"C:\Users\yash\OneDrive\Desktop\College\Medic-Angel\Medic-Angel\MedicAngel\wwwroot\Data\data.json";
        string jsonString = File.ReadAllText(fileName);
        List<User> jsonUser = JsonSerializer.Deserialize<List<User>>(jsonString);
        return jsonUser;

    }
}