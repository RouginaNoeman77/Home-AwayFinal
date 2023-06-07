using Home_Away.BL.Dtos.Images_Dto;
using Home_Away.DAL;
using System.Drawing;


namespace Home_Away.BL.Managers.Images_Manager;


public interface IImagesManager
{
    List<ImagesReadDto> GetAllImages();

    ImagesReadDto GetImagesById(int id);

    ImagesReadDto GetImagesByPropertyId(int propertyId);

    int Add(AddImagesDto imagesDto);

    bool update(ImagesReadDto imagesDto);

    void delete(int id);
}
