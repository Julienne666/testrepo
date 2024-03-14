namespace HomeWork4._1.Dtos;

public class UserData
{
    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    public List<UserDto> data { get; set; }
    public SupportDto SupportDto { get; set; }
}