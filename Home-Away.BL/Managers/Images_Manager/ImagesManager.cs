using Home_Away.BL.Dtos.Images_Dto;
using Home_Away.DAL;


namespace Home_Away.BL.Managers.Images_Manager;

public class ImagesManager : IImagesManager
{
    private readonly IImagesRepo _imagesRepo;

    public ImagesManager(IImagesRepo imagesRepo)
    {
        _imagesRepo = imagesRepo;
    }

    public List<ImagesReadDto> GetAllImages()
    {
        var ImagesFromDb = _imagesRepo.GetAllImages();

        return ImagesFromDb.Select(i => new ImagesReadDto
        {
            Id = i.Id,
            Url = i.Url
        }).ToList();
    }

    public ImagesReadDto GetImagesById(int id)
    {
        var Image = _imagesRepo.GetImagesById(id);

        if (Image is null)
        {
            return null;
        }

        return new ImagesReadDto
        {
            Id = Image.Id,
            Url = Image.Url
        };

    }

    public List<ImagesReadDto>GetImagesByPropertyId(int propertyId)
    {
        var images = _imagesRepo.GetImagesByProperty(propertyId);

        return images.Select(i => new ImagesReadDto
        {
            Id = i.Id,
            Url = i.Url
        }).ToList();
       
    }

    public int Add(AddImagesDto imagesDto)
    {
        var Image = new Images
        {
            Url = imagesDto.Url
        };
        _imagesRepo.AddImage(Image);
        _imagesRepo.SaveChanges();
        return Image.Id;
    }

    public bool update(ImagesReadDto imagesDto)
    {
        var ImageFromDb = _imagesRepo.GetImagesById(imagesDto.Id);
        if (ImageFromDb is null)
        {
            return false;
        }
        ImageFromDb.Url = imagesDto.Url;
        _imagesRepo.UpdateImage(ImageFromDb);
        _imagesRepo.SaveChanges();
        return true;
    }

    public bool delete(int id)
    {
        var ImageFromDb = _imagesRepo.GetImagesById(id);

        if (ImageFromDb is null)
        {
            return false;
        }

        _imagesRepo.DeleteImage(ImageFromDb);
        _imagesRepo.SaveChanges();
        return true;
    }

   
}

