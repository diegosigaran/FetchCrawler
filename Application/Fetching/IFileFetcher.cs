namespace Application.Fetching;

public interface IFileFetcher
{
    HttpResponseMessage FetchRobotsTxt(string origin);
}