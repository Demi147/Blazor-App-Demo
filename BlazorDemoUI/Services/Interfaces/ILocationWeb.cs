namespace BlazorDemoUI.Services
{
    public interface ILocationWeb
    {
        double Check_Valid(string Value);
        double[] Get_lat_Long(string Country, string Province, string City, string Street);
    }
}