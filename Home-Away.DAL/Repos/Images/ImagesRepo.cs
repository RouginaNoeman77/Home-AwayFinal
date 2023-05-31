using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace Home_Away.DAL;
public class ImagesRepo : IImagesRepo
{
    private readonly UserContext _userContext;

    public ImagesRepo(UserContext userContext)
    {
        _userContext = userContext;
    }

    public IEnumerable<Images> GetAllImages()
    {
        return _userContext.Set<Images>().AsNoTracking();
    }

    public Images? GetImagesById(int id)
    {
        return _userContext.Set<Images>().Find(id);
    }

    public Images? GetImagesByProperty(int Prop_id)
    {
        return _userContext.Set<Images>().FirstOrDefault(p=>p.PropertyId == Prop_id);
    }

    public void AddImage(Images image)
    {
        _userContext.Add(image);
    }

    public void UpdateImage(Images image)
    {
        
    }

    public void DeleteImage(Images image)
    {
        _userContext.Set<Images>().Remove(image);
    }

    public int SaveChanges()
    {
        return _userContext.SaveChanges();
    }


}
