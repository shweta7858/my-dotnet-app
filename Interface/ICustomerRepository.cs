using Mera_yani_shweta_ka_app.models.User;

namespace Mera_yani_shweta_ka_app.Interface
{
    public interface ICustomerRepository
    {
       Task AddNewUser(Customer user, bool isGoogleUser = false);         // 🔁 Common method
         

    }




}
