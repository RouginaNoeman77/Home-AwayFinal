namespace Home_Away.DAL;
public interface IImagesRepo
 {
    IEnumerable<Images> GetAllImages();

    Images? GetImagesById(int id);

    Images? GetImagesByProperty(int Prop_id);

    void AddImage(Images image);

    void UpdateImage(Images image);

    void DeleteImage(Images image);

    int SaveChanges();
 }
