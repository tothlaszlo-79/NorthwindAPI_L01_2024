using NorthwindAPI_L01.Domain;

namespace NorthwindAPI_L01.DTO
{
    public class CreateCtegory
    {
     
            public int CategoryId { get; set; }

            public string CategoryName { get; set; } = null!;

            public string? Description { get; set; }

           
    }
}
