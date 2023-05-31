

namespace Home_Away.DAL;
    public interface IImagesRepo
    {
        public IEnumerable<Images> GetAllImages();
        public Images? GetImagesById(int id);
        public IEnumerable<Images> GetImagesByProperty(int Prop_id);
        public void AddImage(Images image);
        public void UpdateImage(Images image);
        public void DeleteImage(Images image);
        public int SaveChanges();
    }
