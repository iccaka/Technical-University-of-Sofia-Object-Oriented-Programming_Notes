
namespace Notes
{
    public interface INote
    {
        string GetHeading();
        void SetHeading(string heading);
        string GetBody();
        void SetBody(string body);
    }
}
