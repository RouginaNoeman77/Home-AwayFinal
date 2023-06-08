namespace Home_Away.BL.Dtos;
public class GeneralResponse
{
    public string Message { get; set; } = string.Empty;
    public GeneralResponse(string msg) 
    {
        Message = msg;
    }
}
