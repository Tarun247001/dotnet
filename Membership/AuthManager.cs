namespace Membership;

public static class AuthManager
{
    public static bool Validate(string email,string password){
        bool status=false;
        if(email=="tar@gmail.com" && password == "123"){
            status=true;
        }
        return status;

    }

    public static bool Register(string email,string password){
        bool status=false;
        return status;

    }

}
