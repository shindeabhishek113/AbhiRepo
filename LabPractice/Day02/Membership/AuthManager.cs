namespace Membership;

public static class AuthManager{

    public static bool Validate(String email,String password){
        bool status = false;
        try{

                if(email == "shindeabhishek113@gmail.com"  && password == "Abhi#1234"){
                status=true;
        }
        }
        catch(Exception e){

        }
        finally{
            
        }
        return status;
    }
}