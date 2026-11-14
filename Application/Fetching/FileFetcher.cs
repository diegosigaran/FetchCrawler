namespace Application.Fetching;

public static class FileFetcher
{

    public static HttpResponseMessage FetchRobotsTxt(Uri uri)
    {
        
        string origin = uri.GetLeftPart(UriPartial.Authority);

        if (origin.EndsWith("/"))
        {
            origin += "robots.txt";
        }
        else
        {
            origin += "/robots.txt";
        }
        
        // TODO: Record a fetch attempt 
        
        
        
    }
    
}