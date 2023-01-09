namespace BussinessObjectLayer;
public class User{
    public string lastname{set;get;}
    public string firstname{set;get;}
    public string email{set;get;}
    public string password{set;get;}
    public string gender{set;get;}
    public string city{set;get;}
    public string country{set;get;}
    
    public User(string firstname, string lastname, string email, string password,string gender,string city,string country){
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.password = password;
        this.gender = gender;
        this.city = city;
        this.country = country;
    }

    public override string ToString(){
        return (this.firstname +"   "+ this.lastname +"   "+ this.email +"   "+ this.password+"   "+this.gender+"   "+ this.city+"   "+this.country);
    }
    
}