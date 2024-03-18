namespace Authentication.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel()
            {
                Username="json_admin",Email="json.admin@email.com",Password="MyPass_w0rd",GivenName="Jason",Surname="Bryant"
                ,Role="Administer"
            },
             new UserModel()
            {
                Username="elyse_seller",Email="elyse.seller@email.com",Password="MyPass_w0rd",GivenName="Elyse",Surname="Lambart"
                ,Role="Seller"
            },

        };
    }
}
