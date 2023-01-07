namespace MedicAngel.Models;

public class User{
    public string lastname{set;get;}
    public string firstname{set;get;}
    public string email{set;get;}
    public string password{set;get;}
    
    public User(string firstname, string lastname, string email, string password){
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.password = password;
    }

    public override string ToString(){
        return (this.firstname +" "+ this.lastname +" "+ this.email +" "+ this.password);
    }
    
}