namespace Home_Away.DAL;

public class AdminRepo : IAdminRepo
{
    private readonly UserContext _userContext;

    public AdminRepo(UserContext userContext)
    {
    }

}

   