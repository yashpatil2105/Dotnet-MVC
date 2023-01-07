namespace MedicAngel.Models;
using Info;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
public class Serial{
    public void iserial(List<User> users)
    {
        try{
        var options =new  JsonSerializerOptions {IncludeFields = true};
        var usersJson = JsonSerializer.Serialize<List<User>>(users,options);
        string fileName = @"C:\Users\yash\OneDrive\Desktop\College\Medic-Angel\MedicAngel\wwwroot\data\data.json";
        File.WriteAllText(fileName,usersJson);
        }catch(Exception exp){
    
        }finally{ 
            
        }

    }

}